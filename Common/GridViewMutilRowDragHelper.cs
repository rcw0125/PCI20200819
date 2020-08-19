using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public class GridViewMutilRowDragHelper
    {
        private GridControl _gcSource;
        private GridView _gvSource;
        private GridControl _gcTarget;
        private GridView _gvTarget;
        GridHitInfo _downHitInfo = null;
        Action<int, int, int> _callBack;
        private int _autoscroll;
        private Timer _timer;
        private bool _allowDrop;
        private DragImageHelper _imgHelper;
        static Cursor _cursor;
        int[] SelectedRows => _gvSource.GetSelectedRows();

        int _dropTargetRowHandle;
        int DropTargetRowHandle
        {
            get { return _dropTargetRowHandle; }
            set
            {
                _dropTargetRowHandle = value;
                _gvTarget.Invalidate();
            }
        }

        /// <summary>
        /// 获取或设置拖动时是否允许滚动条自动滚动
        /// </summary>
        public bool AllowAutoScroll
        {
            get { return _timer.Enabled; }
            set { _timer.Enabled = value && AllowDrop; }
        }

        GridColumn DragColumn { get; } = new GridColumn();

        /// <summary>
        /// 获取或设置是否允许拖动
        /// </summary>
        public bool AllowDrop
        {
            get
            {
                return _allowDrop;
            }
            set
            {
                this._gvSource.MouseDown -= GvSource_MouseDown;
                this._gvSource.MouseMove -= GvSource_MouseMove;
                this._gcTarget.DragDrop -= Gc_DragDrop;
                this._gcTarget.DragOver -= Gc_DragOver;

                this._gcSource.Paint -= _gcSource_Paint;
                this._gcSource.GiveFeedback -= _gc_GiveFeedback;
                this._gcTarget.GiveFeedback -= _gc_GiveFeedback;
                this._gcTarget.Paint -= GvTarget_Paint;
                this._gcTarget.MouseUp -= Gc_MouseUp;

                if (value)
                {
                    this._gvSource.MouseDown += GvSource_MouseDown;
                    this._gvSource.MouseMove += GvSource_MouseMove;
                    this._gcTarget.DragDrop += Gc_DragDrop;
                    this._gcTarget.DragOver += Gc_DragOver;

                    this._gcSource.Paint += _gcSource_Paint;
                    this._gcSource.GiveFeedback += _gc_GiveFeedback;
                    this._gcTarget.GiveFeedback += _gc_GiveFeedback;
                    this._gcTarget.Paint += GvTarget_Paint;
                    this._gcTarget.MouseUp += Gc_MouseUp;
                }
                DragColumn.Visible = value;

                _allowDrop = value;
                _gcSource.AllowDrop = value;
                _timer.Enabled = value && AllowAutoScroll;
            }
        }

        private void _gcSource_Paint(object sender, PaintEventArgs e)
        {
            if (SelectedRows == null || SelectedRows.Length == 0)
            {
                return;
            }
            var vi = (GridViewInfo)_gvSource.GetViewInfo();
            if (vi.RowsInfo.Count == 0)
            {
                return;
            }
            var ci1 = vi.GetGridCellInfo(new[] { SelectedRows.Min(), _gvSource.TopRowIndex }.Max(), DragColumn);
            var ci2 = vi.GetGridCellInfo(new[] { SelectedRows.Max(), vi.RowsInfo.Max(x => x.VisibleIndex) }.Min(), DragColumn);

            if (ci1 == null || ci2 == null)
            {
                return;
            }

            var bounds = Rectangle.Union(ci1.Bounds, ci2.Bounds);
            e.Graphics.FillRectangle(new SolidBrush(_gvSource.GridControl.BackColor), bounds);

            var size = new Size(16, 16);
            e.Graphics.DrawImage(ImageHelper.Image_Arrow_Move,
                new Rectangle(new Point(bounds.X + 1 + (bounds.Width - size.Width) / 2, bounds.Y + (bounds.Height - size.Height) / 2), size));
        }

        /// <summary>
        /// GridView数据项拖动管理
        /// </summary>
        /// <param name="gvSource">拖动的源GridView</param>
        /// <param name="gvTarget">拖动的目标GridView</param>
        /// <param name="callBack">当拖放完成后的回调函数，第一个参数是拖动的源数据RowIndex，第二个参数是目标RowIndex</param>
        public GridViewMutilRowDragHelper(GridView gvSource, GridView gvTarget, Action<int, int, int> callBack)
        {
            var fieldName = "dragColumnField";
            if (!gvSource.Columns.Select(x => x.FieldName).Contains(fieldName))
            {
                if (gvSource is BandedGridView bgv)
                {
                    DragColumn = new BandedGridColumn();
                    var band = new GridBand();
                    band.OptionsBand.AllowMove = false;
                    band.OptionsBand.AllowSize = false;
                    band.OptionsBand.FixedWidth = true;
                    band.Visible = true;
                    band.Width = 20;
                    band.Fixed = FixedStyle.Left;
                    bgv.Bands.Insert(0, band);
                    band.Columns.Add(DragColumn as BandedGridColumn);

                    gvSource.Columns.Add(DragColumn);
                }
                else
                {
                    DragColumn = new GridColumn();
                    DragColumn.Fixed = FixedStyle.Left;
                    gvSource.Columns.Insert(0, DragColumn);
                }

                DragColumn.Width = 20;
                DragColumn.FieldName = fieldName;
                DragColumn.Visible = true;
                DragColumn.VisibleIndex = 0;
                DragColumn.OptionsColumn.AllowSize = false;
                DragColumn.OptionsColumn.AllowEdit = false;
                DragColumn.OptionsColumn.ShowCaption = false;
                DragColumn.OptionsColumn.FixedWidth = true;
                DragColumn.OptionsColumn.AllowMove = false;
            }
            else
            {
                DragColumn = gvSource.Columns.FirstOrDefault(x => x.FieldName == fieldName);
            }

            this._gcSource = gvSource.GridControl;
            this._gvSource = gvSource;
            this._gvTarget = gvTarget;
            this._gcTarget = gvTarget.GridControl;
            this._callBack = callBack;
            this._gvSource.SelectionChanged += GvSrc_SelectionChanged;

            this._imgHelper = new DragImageHelper(gvSource);
            this._timer = new Timer();
            _timer.Interval = 200;
            _timer.Enabled = true;
            _timer.Tick += _timer_Tick;

            AllowDrop = true;
            AllowAutoScroll = true;
        }

        private void GvSrc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectedRows.Length == 0)
                return;

            if (SelectedRows.Length == 1)
            {
                var cols = _gvSource.GetSelectedCells(SelectedRows[0]);
                if (cols.Length == 1 && cols[0] == DragColumn)
                    return;
            }
            _gvSource.SelectionChanged -= GvSrc_SelectionChanged;
            _gvSource.UnSelectCells(0, DragColumn, _gvSource.RowCount - 1, DragColumn);
            _gvSource.SelectionChanged += GvSrc_SelectionChanged;

            //SelectedRows = _gvSource.GetSelectedRows();

            if (SelectedRows == null || SelectedRows.Length == 0)
                return;

            _gvSource.SelectionChanged -= GvSrc_SelectionChanged;
            _gvSource.SelectCells(SelectedRows.Min(), DragColumn, SelectedRows.Max(), DragColumn);
            _gvSource.SelectionChanged += GvSrc_SelectionChanged;
        }

        private void Gc_MouseUp(object sender, MouseEventArgs e)
        {
            _downHitInfo = null;
            DropTargetRowHandle = -1;
        }

        void GvTarget_Paint(object sender, PaintEventArgs e)
        {
            if (_downHitInfo == null)
                return;
            GridControl grid = (GridControl)sender;
            GridView view = (GridView)grid.MainView;

            bool isBottomLine = DropTargetRowHandle == view.DataRowCount;

            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            GridRowInfo rowInfo = viewInfo.GetGridRowInfo(isBottomLine ? DropTargetRowHandle - 1 : DropTargetRowHandle);

            if (rowInfo == null) return;

            Point p1, p2;
            if (isBottomLine)
            {
                p1 = new Point(rowInfo.Bounds.Left, rowInfo.Bounds.Bottom - 1);
                p2 = new Point(rowInfo.Bounds.Right, rowInfo.Bounds.Bottom - 1);
            }
            else
            {
                p1 = new Point(rowInfo.Bounds.Left, rowInfo.Bounds.Top - 1);
                p2 = new Point(rowInfo.Bounds.Right, rowInfo.Bounds.Top - 1);
            }

            Pen pen = new Pen(Color.Blue, 3);
            e.Graphics.DrawLine(pen, p1, p2);


        }

        private void _gc_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (_downHitInfo != null && _cursor != null)
            {
                e.UseDefaultCursors = false;
                Cursor.Current = _cursor;
            }
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            DoScrollView();
        }

        void DoScrollView()
        {
            if (_autoscroll == 0) return;
            this._gvTarget.TopRowIndex += _autoscroll;
            _autoscroll = 0;
        }

        private void GvSource_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            GridView view = sender as GridView;
            _downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None)
                return;

            var condition = hitInfo.HitTest == GridHitTest.RowCell && hitInfo.Column == DragColumn;

            if (e.Button == MouseButtons.Left && condition && hitInfo.RowHandle != GridControl.NewItemRowHandle)
            {
                _downHitInfo = hitInfo;
                Cursor.Current = DevExpress.Utils.DragCursors.HandDragCursor;
                return;
            }


        }

        private void GvSource_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (hitInfo.Column == DragColumn && hitInfo.HitTest == GridHitTest.RowCell && hitInfo.RowHandle != GridControl.NewItemRowHandle)
            {
                if (e.Button == MouseButtons.None)
                {
                    _gcSource.Cursor = DevExpress.Utils.DragCursors.HandCursor;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    _gcSource.Cursor = DevExpress.Utils.DragCursors.HandDragCursor;
                }
            }
            else
            {
                _gcSource.Cursor = Cursors.Default;
            }

            if (e.Button == MouseButtons.Left && _downHitInfo != null && !(SelectedRows == null || SelectedRows.Length == 0))
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(_downHitInfo.HitPoint.X - dragSize.Width / 2,
                    _downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    _cursor = _imgHelper.GetDragRowsCursor(SelectedRows, e.Location);
                    view.GridControl.DoDragDrop(_downHitInfo, DragDropEffects.All);
                    this._downHitInfo = null;
                    DropTargetRowHandle = -1;
                }
            }
        }

        private void Gc_DragOver(object sender, DragEventArgs e)
        {
            GridHitInfo downHitInfo;
            if (e.Data.GetDataPresent(typeof(GridHitInfo)))
            {
                downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            }
            else if (e.Data.GetDataPresent(typeof(BandedGridHitInfo)))
            {
                downHitInfo = e.Data.GetData(typeof(BandedGridHitInfo)) as BandedGridHitInfo;
            }
            else
            {
                return;
            }
            if (downHitInfo == null)
                return;

            GridControl grid = sender as GridControl;
            GridView view = grid.MainView as GridView;
            Point pt = grid.PointToClient(new Point(e.X, e.Y));
            GridHitInfo hitInfo = view.CalcHitInfo(pt);

            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                GridViewInfo gvi = view.GetViewInfo() as GridViewInfo;
                if (gvi.RowsLoadInfo.ResultRows[0].RowHandle == hitInfo.RowHandle && hitInfo.InRow)
                {
                    _autoscroll = -1;
                }
                else if (gvi.RowsLoadInfo.ResultRows[gvi.RowsLoadInfo.ResultRows.Count - 2].RowHandle <= hitInfo.RowHandle && hitInfo.InRow)
                {
                    _autoscroll = 1;
                }
            }
            else if (hitInfo.HitTest == GridHitTest.VScrollBar)
            {
                Rectangle scrollrect = (view.GetViewInfo() as GridViewInfo).ViewRects.Scroll;
                _autoscroll = ((pt.Y - scrollrect.Top) < (scrollrect.Bottom - pt.Y)) ? -1 : 1;
            }

            if (hitInfo.HitTest == GridHitTest.EmptyRow)
                DropTargetRowHandle = view.DataRowCount;
            else
                DropTargetRowHandle = hitInfo.RowHandle;

            if (DropTargetRowHandle >= 0)
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Gc_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            GridHitInfo srcHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            if (srcHitInfo == null)
                srcHitInfo = e.Data.GetData(typeof(BandedGridHitInfo)) as BandedGridHitInfo;

            if (!srcHitInfo.View.Equals(this._gvSource)) return;
            int sourceRow = srcHitInfo.RowHandle;
            _gcSource.BeginInvoke(new Action<int, int, int>((r, r1, num) =>
            {
                _callBack?.Invoke(r, r1, num);
            }), SelectedRows.Min(), DropTargetRowHandle, SelectedRows.Length);
        }

    }
}
