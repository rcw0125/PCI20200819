using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
    /// <summary>
    /// GridView数据项拖动管理
    /// </summary>
    public class GridViewDragDropHelper
    {
        private GridControl _gcSource;
        private GridView _gvSource;
        private GridControl _gcTarget;
        private GridView _gvTarget;
        GridHitInfo _downHitInfo = null;
        Action<int, int> _callBack;
        private int _autoscroll;
        private Timer _timer;
        private bool _allowDrop;
        private DragImageHelper _imgHelper;
        static Cursor _cursor;
        /// <summary>
        /// 获取或设置拖动时是否允许滚动条自动滚动
        /// </summary>
        public bool AllowAutoScroll
        {
            get { return _timer.Enabled; }
            set { _timer.Enabled = value && AllowDrop; }
        }

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

                this._gcSource.GiveFeedback -= _gc_GiveFeedback;
                this._gcTarget.GiveFeedback -= _gc_GiveFeedback;
                this._gcTarget.Paint -= GridControl_Paint;
                this._gcTarget.MouseUp -= Gc_MouseUp;

                if (value == true)
                {
                    this._gvSource.MouseDown += GvSource_MouseDown;
                    this._gvSource.MouseMove += GvSource_MouseMove;
                    this._gcTarget.DragDrop += Gc_DragDrop;
                    this._gcTarget.DragOver += Gc_DragOver;

                    this._gcSource.GiveFeedback += _gc_GiveFeedback;
                    this._gcTarget.GiveFeedback += _gc_GiveFeedback;
                    this._gcTarget.Paint += GridControl_Paint;
                    this._gcTarget.MouseUp += Gc_MouseUp;
                }

                _allowDrop = value;
                _gcSource.AllowDrop = value;
            }
        }

        /// <summary>
        /// 允许鼠标点击拖动的位置
        /// </summary>
        public DragDropMode DragDropMode { get; set; } = DragDropMode.Default;

        /// <summary>
        /// 在DragDropMode设置为ColumnCell时指定拖动点击的列
        /// </summary>
        public List<GridColumn> DragColumns { get; set; }

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
        /// GridView数据项拖动管理
        /// </summary>
        /// <param name="gvSource">拖动的源GridView</param>
        /// <param name="gvTarget">拖动的目标GridView</param>
        /// <param name="callBack">当拖放完成后的回调函数，第一个参数是拖动的源数据RowIndex，第二个参数是目标RowIndex</param>
        public GridViewDragDropHelper(GridView gvSource, GridView gvTarget, Action<int, int> callBack)
        {
            this._gcSource = gvSource.GridControl;
            this._gvSource = gvSource;
            this._gvTarget = gvTarget;
            this._gcTarget = gvTarget.GridControl;
            this._callBack = callBack;
            this._imgHelper = new DragImageHelper(gvSource);
            this._timer = new Timer();
            _timer.Interval = 200;
            _timer.Enabled = true;
            _timer.Tick += _timer_Tick;

            AllowDrop = true;
        }

        private void Gc_MouseUp(object sender, MouseEventArgs e)
        {
            _downHitInfo = null;
            DropTargetRowHandle = -1;
        }

        void GridControl_Paint(object sender, PaintEventArgs e)
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

            Pen pen = new Pen(ColorTranslator.FromHtml("#2091E1"), 3);
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
            var condition = false;
            switch (this.DragDropMode)
            {
                case DragDropMode.InRow:
                    condition = hitInfo.InRow;
                    break;
                case DragDropMode.RowCell:
                    condition = hitInfo.HitTest == GridHitTest.RowCell;
                    break;
                case DragDropMode.RowIndicator:
                    condition = hitInfo.HitTest == GridHitTest.RowIndicator;
                    break;
                case DragDropMode.ColumnCell:
                    condition = hitInfo.HitTest == GridHitTest.RowCell && this.DragColumns.Contains(hitInfo.Column);
                    break;
                default:
                    break;
            }
            if (e.Button == MouseButtons.Left && condition && hitInfo.RowHandle != GridControl.NewItemRowHandle)
                _downHitInfo = hitInfo;
        }

        private void GvSource_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && _downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(_downHitInfo.HitPoint.X - dragSize.Width / 2,
                    _downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    _cursor = _imgHelper.GetDragRowCursor(_downHitInfo.RowHandle, e.Location);
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
            _gcSource.BeginInvoke(new Action<int, int>((r, r1) =>
             {
                 _callBack?.Invoke(r, r1);
             }), sourceRow, DropTargetRowHandle);
        }

    }


    /// <summary>
    /// 允许鼠标点击拖动的位置
    /// </summary>
    public enum DragDropMode
    {
        /// <summary>
        /// 整行
        /// </summary>
        InRow = 1,
        /// <summary>
        /// 行单元格
        /// </summary>
        RowCell = 2,
        /// <summary>
        /// 行指示器
        /// </summary>
        RowIndicator = 3,
        /// <summary>
        /// 指定列的单元格
        /// </summary>
        ColumnCell = 4,

        Default = RowIndicator
    }
}
