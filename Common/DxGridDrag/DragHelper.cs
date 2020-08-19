using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    /// <summary>
    /// 拖拽帮助类
    /// </summary>
    public static class DragHelper
    {
        /// <summary>
        /// BandedGridView 拖拽
        /// </summary>
        /// <param name="gvMain"></param>
        public static void DragGridRow<T>(this BandedGridView gvMain)
        {
            // 拖拽遮罩控件
            DragMaster dragMaster = new DragMaster();
            // 当前拖拽行绘画区域
            Rectangle _DragRowRect = Rectangle.Empty;

            GridControl gcMain = gvMain.GridControl;
            GridHitInfo _DownHitInfo = null;

            //表格属性 允许拖拽
            gcMain.AllowDrop = true;
            gvMain.OptionsDetail.EnableMasterViewMode = false;
            #region 将对象拖至边界时发生 DragOver
            gcMain.DragOver += delegate (object sender, System.Windows.Forms.DragEventArgs e)
            {
                if (e.Data.GetDataPresent(typeof(T)))
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            };
            #endregion

            #region 拖拽完成时处理数据 DragDrop
            gcMain.DragDrop += delegate (object sender, System.Windows.Forms.DragEventArgs e)
            {
                // 拖过来的新数据
                T newRow = (T)e.Data.GetData(typeof(T));
                // 原来在此坐标的数据
                // e的坐标是相对于屏幕的
                var clientPoint = gcMain.PointToClient(new Point(e.X, e.Y));
                GridHitInfo hitInfo = gvMain.CalcHitInfo(new Point(clientPoint.X, clientPoint.Y));
                var oldRow = (T)gvMain.GetRow(hitInfo.RowHandle);

                // 如果相等则不处理
                if (oldRow == null || newRow == null) return;

                // 且目标位置不是最后一行的话要将所有序号重排
                // 原来的行号
                var oldIndex = _DownHitInfo.RowHandle;
                // 新的行号
                var newIndex = hitInfo.RowHandle;

                BindingSource bs = (BindingSource)(gcMain.DataSource);
                if (bs == null)
                    return;

                bs.RemoveAt(oldIndex);
                bs.Insert(oldIndex, oldRow);
                bs.RemoveAt(newIndex);
                bs.Insert(newIndex, newRow);

                bs.ResetBindings(false);
            };
            #endregion

            #region 鼠标按下 MouseDown
            gcMain.MouseDown += delegate (object sender, MouseEventArgs e)
            {
                _DownHitInfo = null;
                GridHitInfo hitInfo = gvMain.CalcHitInfo(new Point(e.X, e.Y));
                if (Control.ModifierKeys != Keys.None) return;
                if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
                {
                    // 禁用的Grid不支持拖拽
                    if (!gvMain.OptionsBehavior.Editable
                        || gvMain.OptionsBehavior.ReadOnly)
                        return;
                    // 只有点击最前面才能拖拽
                    if (hitInfo.InRowCell)
                        return;
                    // 缓存
                    _DownHitInfo = hitInfo;
                }
            };
            #endregion

            #region 鼠标移动 MouseMove
            gcMain.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (_DownHitInfo != null)
                    {
                        Size dragSize = SystemInformation.DragSize;
                        // 偏离区域
                        Rectangle dragRect = new Rectangle(new Point(_DownHitInfo.HitPoint.X - dragSize.Width / 2, _DownHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                        if (!dragRect.Contains(new Point(e.X, e.Y)))
                        {
                            // 屏幕坐标
                            var p = gcMain.PointToScreen(e.Location);
                            // 刷新是必须要的
                            gcMain.Refresh();
                            // 获取当前行截图
                            var bmp = GetDragRowImage(gcMain, _DownHitInfo, _DragRowRect);

                            Point offSetPoint = new Point(p.X + 1, p.Y - dragMaster.DragSize.Height / 2);
                            // 开始显示拖拽遮罩
                            dragMaster.StartDrag(bmp, offSetPoint, DragDropEffects.Move);
                            // 获取要拖拽的数据
                            object row = gvMain.GetRow(_DownHitInfo.RowHandle);
                            // 开始拖拽
                            gcMain.DoDragDrop(row, DragDropEffects.Move);
                            // 取消事件
                            DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                            // 清空缓存
                            _DownHitInfo = null;
                        }
                    }
                }
            };
            #endregion

            #region 在用鼠标拖动某项时发生，是否允许继续拖放 QueryContinueDrag
            gcMain.QueryContinueDrag += delegate (object sender, QueryContinueDragEventArgs e)
            {
                switch (e.Action)
                {
                    case DragAction.Continue:
                        // 移动遮罩
                        Point offSetPoint = new Point(Cursor.Position.X + 1, Cursor.Position.Y - dragMaster.DragSize.Height / 2);
                        dragMaster.DoDrag(offSetPoint, DragDropEffects.Move, false);
                        break;
                    default:
                        // 清空
                        _DragRowRect = Rectangle.Empty;
                        // 停止拖动
                        dragMaster.EndDrag();
                        break;
                }
            };
            #endregion

            #region 点击行头移动行
            gvMain.CustomDrawRowIndicator += delegate (object sender, RowIndicatorCustomDrawEventArgs e)
            {
                if (_DragRowRect == Rectangle.Empty && _DownHitInfo != null && _DownHitInfo.RowHandle == e.RowHandle)
                {
                    _DragRowRect = e.Bounds;
                }
            };
            #endregion

        }

        /// <summary>
        /// GridView 拖拽
        /// </summary>
        /// <param name="gvMain"></param>
        public static void DragGridRow<T>(this GridView gvMain)
        {
            // 拖拽遮罩控件
            DragMaster dragMaster = new DragMaster();
            // 当前拖拽行绘画区域
            Rectangle _DragRowRect = Rectangle.Empty;

            GridControl gcMain = gvMain.GridControl;
            GridHitInfo _DownHitInfo = null;

            //表格属性 允许拖拽
            gcMain.AllowDrop = true;
            gvMain.OptionsDetail.EnableMasterViewMode = false;
            #region 将对象拖至边界时发生 DragOver
            gcMain.DragOver += delegate (object sender, System.Windows.Forms.DragEventArgs e)
            {
                if (e.Data.GetDataPresent(typeof(T)))
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            };
            #endregion

            #region 拖拽完成时处理数据 DragDrop
            gcMain.DragDrop += delegate (object sender, System.Windows.Forms.DragEventArgs e)
            {
                // 拖过来的新数据
                T newRow = (T)e.Data.GetData(typeof(T));
                // 原来在此坐标的数据
                // e的坐标是相对于屏幕的
                var clientPoint = gcMain.PointToClient(new Point(e.X, e.Y));
                GridHitInfo hitInfo = gvMain.CalcHitInfo(new Point(clientPoint.X, clientPoint.Y));
                var oldRow = (T)gvMain.GetRow(hitInfo.RowHandle);

                // 如果相等则不处理
                if (oldRow == null || newRow == null) return;

                // 且目标位置不是最后一行的话要将所有序号重排
                // 原来的行号
                var oldIndex = _DownHitInfo.RowHandle;
                // 新的行号
                var newIndex = hitInfo.RowHandle;

                BindingSource bs = (BindingSource)(gcMain.DataSource);
                if (bs == null)
                    return;

                bs.RemoveAt(oldIndex);
                bs.Insert(oldIndex, oldRow);
                bs.RemoveAt(newIndex);
                bs.Insert(newIndex, newRow);

                bs.ResetBindings(false);
            };
            #endregion

            #region 鼠标按下 MouseDown
            gcMain.MouseDown += delegate (object sender, MouseEventArgs e)
            {
                _DownHitInfo = null;
                GridHitInfo hitInfo = gvMain.CalcHitInfo(new Point(e.X, e.Y));
                if (Control.ModifierKeys != Keys.None) return;
                if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
                {
                    // 禁用的Grid不支持拖拽
                    if (!gvMain.OptionsBehavior.Editable
                        || gvMain.OptionsBehavior.ReadOnly)
                        return;
                    // 只有点击最前面才能拖拽
                    if (hitInfo.InRowCell)
                        return;
                    // 缓存
                    _DownHitInfo = hitInfo;

                    var rowHandles = gvMain.GetSelectedRows();
                    if (rowHandles.Length == 0) rowHandles = new[] { gvMain.FocusedRowHandle };

                    var vi = gvMain.GetViewInfo() as GridViewInfo;
                    var topRowInfo = vi.GetGridRowInfo(new[] { rowHandles.Min(), gvMain.TopRowIndex }.Max());
                    var btmRowInfo = vi.GetGridRowInfo(new[] { rowHandles.Max(), vi.RowsInfo.Max(x => x.VisibleIndex) }.Min());
                    var height = Rectangle.Union(topRowInfo.Bounds, btmRowInfo.Bounds).Size.Height;
                    _DragRowRect = new Rectangle(topRowInfo.Bounds.Location, new Size(1000, height));
                }
            };
            #endregion

            #region 鼠标移动 MouseMove
            gcMain.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (_DownHitInfo != null)
                    {
                        Size dragSize = SystemInformation.DragSize;
                        // 偏离区域
                        Rectangle dragRect = new Rectangle(new Point(_DownHitInfo.HitPoint.X - dragSize.Width / 2, _DownHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                        if (!dragRect.Contains(new Point(e.X, e.Y)))
                        {
                            // 屏幕坐标
                            var p = gcMain.PointToScreen(e.Location);
                            // 刷新是必须要的
                            gcMain.Refresh();
                            // 获取当前行截图
                            var bmp = GetDragRowImage(gcMain, _DownHitInfo, _DragRowRect);

                            Point offSetPoint = new Point(p.X + 1, p.Y);
                            // 开始显示拖拽遮罩
                            dragMaster.StartDrag(bmp, offSetPoint, DragDropEffects.Move);
                            // 获取要拖拽的数据
                            object row = gvMain.GetRow(_DownHitInfo.RowHandle);
                            // 开始拖拽
                            gcMain.DoDragDrop(row, DragDropEffects.Move);
                            // 取消事件
                            DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                            // 清空缓存
                            _DownHitInfo = null;
                        }
                    }
                }
            };
            #endregion

            #region 在用鼠标拖动某项时发生，是否允许继续拖放 QueryContinueDrag
            gcMain.QueryContinueDrag += delegate (object sender, QueryContinueDragEventArgs e)
            {
                switch (e.Action)
                {
                    case DragAction.Continue:
                        // 移动遮罩
                        Point offSetPoint = new Point(Cursor.Position.X + 1, Cursor.Position.Y - dragMaster.DragSize.Height / 2);
                        dragMaster.DoDrag(offSetPoint, DragDropEffects.Move, false);
                        break;
                    default:
                        // 清空
                        _DragRowRect = Rectangle.Empty;
                        // 停止拖动
                        dragMaster.EndDrag();
                        break;
                }
            };
            #endregion

            #region 点击行头移动行
            //gvMain.CustomDrawRowIndicator += GvMain_CustomDrawRowIndicator;
            #endregion

        }
         
        /// <summary>
        /// 获取拖拽截图
        /// </summary>
        /// <param name="hitInfo"></param>
        /// <param name="gcMain"></param>
        /// <param name="dragRowRect"></param>
        /// <returns></returns>
        public static Bitmap GetDragRowImage(GridControl gcMain, GridHitInfo hitInfo, Rectangle dragRowRect)
        {
            // 截图
            var bmp = DragImageCapturer.GetControlBitmap(gcMain, null
                      , dragRowRect.Width + 1, dragRowRect.Top, gcMain.Width - dragRowRect.Width - 4, 200 + dragRowRect.Height - 1);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                var p1 = new Point(1, 1);
                var p2 = new Point(bmp.Width - 1, 1);
                var p3 = new Point(1, bmp.Height - 2);
                var p4 = new Point(bmp.Width - 1, bmp.Height - 2);

                using (Pen pen = new Pen(gcMain.ForeColor))
                {
                    g.DrawLine(pen, p1, p2);
                    g.DrawLine(pen, p1, p3);
                    g.DrawLine(pen, p2, p4);
                    g.DrawLine(pen, p3, p4);
                }
            }
            return bmp;
        }
    }

    public class DragHelper_gridview
    {
        DragMaster _dragMaster;
        GridHitInfo _DownHitInfo = null;
        Rectangle _DragRowRect = Rectangle.Empty;
        GridView _gvMain;

        public DragHelper_gridview(GridView gvMain)
        {
            _gvMain = gvMain;
            _dragMaster = new DragMaster();

            //表格属性 允许拖拽
            gvMain.GridControl.AllowDrop = true;
            gvMain.OptionsDetail.EnableMasterViewMode = false;

            gvMain.GridControl.DragOver += GcMain_DragOver;
            gvMain.GridControl.DragDrop += GcMain_DragDrop;
            gvMain.GridControl.MouseDown += GcMain_MouseDown;
            gvMain.GridControl.MouseMove += GcMain_MouseMove;
            gvMain.GridControl.QueryContinueDrag += GcMain_QueryContinueDrag;

            gvMain.CustomDrawRowIndicator += GvMain_CustomDrawRowIndicator;
        }

        private void GvMain_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (_DragRowRect == Rectangle.Empty && _DownHitInfo != null && _DownHitInfo.RowHandle == e.RowHandle)
            {
                var rowHandles = _gvMain.GetSelectedRows();
                if (rowHandles.Length == 0) rowHandles = new[] { _gvMain.FocusedRowHandle };

                var vi = _gvMain.GetViewInfo() as GridViewInfo;
                var topRowInfo = vi.GetGridRowInfo(new[] { rowHandles.Min(), _gvMain.TopRowIndex }.Max());
                var btmRowInfo = vi.GetGridRowInfo(new[] { rowHandles.Max(), vi.RowsInfo.Max(x => x.VisibleIndex) }.Min());
                var height = Rectangle.Union(topRowInfo.Bounds, btmRowInfo.Bounds).Size.Height;
                _DragRowRect = e.Bounds;
            }
        }

        private void GcMain_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            switch (e.Action)
            {
                case DragAction.Continue:
                    // 移动遮罩
                    Point offSetPoint = new Point(Cursor.Position.X + 1, Cursor.Position.Y);
                    _dragMaster.DoDrag(offSetPoint, DragDropEffects.Move, false);
                    break;
                default:
                    // 清空
                    _DragRowRect = Rectangle.Empty;
                    // 停止拖动
                    _dragMaster.EndDrag();
                    break;
            }
        }

        private void GcMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_DownHitInfo != null)
                {
                    Size dragSize = SystemInformation.DragSize;
                    // 偏离区域
                    Rectangle dragRect = new Rectangle(new Point(_DownHitInfo.HitPoint.X - dragSize.Width / 2, _DownHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                    if (!dragRect.Contains(new Point(e.X, e.Y)))
                    {
                        // 屏幕坐标
                        var p = _gvMain.GridControl.PointToScreen(e.Location);
                        // 刷新是必须要的
                        _gvMain.GridControl.Refresh();
                        // 获取当前行截图
                        var bmp = GetDragRowImage(_gvMain.GridControl, _DownHitInfo, _DragRowRect);

                        Point offSetPoint = new Point(p.X + 1, p.Y);
                        // 开始显示拖拽遮罩
                        _dragMaster.StartDrag(bmp, offSetPoint, DragDropEffects.Move);
                        // 获取要拖拽的数据
                        object row = _gvMain.GetRow(_DownHitInfo.RowHandle);
                        // 开始拖拽
                        _gvMain.GridControl.DoDragDrop(row, DragDropEffects.Move);
                        // 取消事件
                        DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                        // 清空缓存
                        _DownHitInfo = null;
                    }
                }
            }
        }

        private void GcMain_MouseDown(object sender, MouseEventArgs e)
        {
            _DownHitInfo = null;
            GridHitInfo hitInfo = _gvMain.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                // 禁用的Grid不支持拖拽
                if (!_gvMain.OptionsBehavior.Editable
                    || _gvMain.OptionsBehavior.ReadOnly)
                    return;
                // 只有点击最前面才能拖拽
                if (hitInfo.InRowCell)
                    return;
                // 缓存
                _DownHitInfo = hitInfo; 
            }
        }

        private void GcMain_DragDrop(object sender, DragEventArgs e)
        {
            //// 拖过来的新数据
            //T newRow = (T)e.Data.GetData(typeof(T));
            //// 原来在此坐标的数据
            //// e的坐标是相对于屏幕的
            //var clientPoint = gcMain.PointToClient(new Point(e.X, e.Y));
            //GridHitInfo hitInfo = _gvMain.CalcHitInfo(new Point(clientPoint.X, clientPoint.Y));
            //var oldRow = (T)_gvMain.GetRow(hitInfo.RowHandle);

            //// 如果相等则不处理
            //if (oldRow == null || newRow == null) return;

            //// 且目标位置不是最后一行的话要将所有序号重排
            //// 原来的行号
            //var oldIndex = _DownHitInfo.RowHandle;
            //// 新的行号
            //var newIndex = hitInfo.RowHandle;

            //var bs = (BindingSource)(_gvMain.GridControl.DataSource);
            //if (bs == null) return;

            //bs.RemoveAt(oldIndex);
            //bs.Insert(oldIndex, oldRow);
            //bs.RemoveAt(newIndex);
            //bs.Insert(newIndex, newRow);

            //bs.ResetBindings(false);
        }

        private void GcMain_DragOver(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(typeof(T)))
            //    e.Effect = DragDropEffects.Move;
            //else
            //    e.Effect = DragDropEffects.None;

            e.Effect = DragDropEffects.Move;
        }

        private static Bitmap GetDragRowImage(GridControl gcMain, GridHitInfo hitInfo, Rectangle dragRowRect)
        {
            // 截图
            var bmp = DragImageCapturer.GetControlBitmap(gcMain, null
                      , dragRowRect.Width + 1, dragRowRect.Top, gcMain.Width - dragRowRect.Width - 4, 200 + dragRowRect.Height - 1);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                var p1 = new Point(1, 1);
                var p2 = new Point(bmp.Width - 1, 1);
                var p3 = new Point(1, bmp.Height - 2);
                var p4 = new Point(bmp.Width - 1, bmp.Height - 2);

                using (Pen pen = new Pen(gcMain.ForeColor))
                {
                    g.DrawLine(pen, p1, p2);
                    g.DrawLine(pen, p1, p3);
                    g.DrawLine(pen, p2, p4);
                    g.DrawLine(pen, p3, p4);
                }
            }
            return bmp;
        }
    }
}
