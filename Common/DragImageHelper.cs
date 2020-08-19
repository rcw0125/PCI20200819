using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Common
{

    internal class DragImageHelper : GridPainter
    {
        protected internal readonly DevExpress.XtraGrid.Views.Grid.GridView _View;
        public DragImageHelper(DevExpress.XtraGrid.Views.Grid.GridView view)
            : base(view)
        {
            _View = view;
        }
        public Cursor GetDragCellCursor(GridHitInfo hitInfo, Point e)
        {
            GridViewInfo info = _View.GetViewInfo() as GridViewInfo;
            GridCellInfo cellinfo = info.GetGridCellInfo(hitInfo);

            Rectangle imageBounds = new Rectangle(new Point(0, 0), cellinfo.Bounds.Size);
            Rectangle totalBounds = new Rectangle(new Point(0, 0), info.Bounds.Size);
            Bitmap bitmap = new Bitmap(totalBounds.Width, totalBounds.Height);
            DevExpress.Utils.Drawing.GraphicsCache cache = new DevExpress.Utils.Drawing.GraphicsCache(Graphics.FromImage(bitmap));
            GridViewDrawArgs args = new GridViewDrawArgs(cache, info, totalBounds);

            base.DrawRowCell(args, cellinfo);

            Bitmap result = new Bitmap(imageBounds.Width, imageBounds.Height);
            Graphics resultGraphics = Graphics.FromImage(result);
            float[][] matrixItems ={
                               new float[] {1, 0, 0, 0, 0},
                               new float[] {0, 1, 0, 0, 0},
                               new float[] {0, 0, 1, 0, 0},
                               new float[] {0, 0, 0, 0.7f, 0},
                               new float[] {0, 0, 0, 0, 1}};
            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(
               colorMatrix,
               ColorMatrixFlag.Default,
               ColorAdjustType.Bitmap);
            resultGraphics.DrawImage(bitmap, imageBounds, cellinfo.Bounds.X, cellinfo.Bounds.Y, cellinfo.Bounds.Width, cellinfo.Bounds.Height, GraphicsUnit.Pixel, imageAttributes);
            resultGraphics.DrawIcon(Icon.FromHandle(Cursors.Default.Handle), 0, 0);
            return CreateCursor(result);
        }
        public Cursor GetDragRowCursor(int rowHandle, Point e)
        {
            GridViewInfo info = _View.GetViewInfo() as GridViewInfo;
            GridRowInfo rowInfo = info.GetGridRowInfo(rowHandle);
            if (rowInfo == null) return Cursor.Current;
            Rectangle imageBounds = new Rectangle(new Point(0, 0), rowInfo.TotalBounds.Size);
            Rectangle totalBounds = new Rectangle(new Point(0, 0), info.Bounds.Size);
            Bitmap bitmap = new Bitmap(totalBounds.Width, totalBounds.Height);
            DevExpress.Utils.Drawing.GraphicsCache cache = new DevExpress.Utils.Drawing.GraphicsCache(Graphics.FromImage(bitmap));
            GridViewDrawArgs args = new GridViewDrawArgs(cache, info, totalBounds);
            DrawRow(args, rowInfo);
            Bitmap result = new Bitmap(imageBounds.Width, imageBounds.Height);
            Graphics resultGraphics = Graphics.FromImage(result);
            float[][] matrixItems ={
                               new float[] {1, 0, 0, 0, 0},
                               new float[] {0, 1, 0, 0, 0},
                               new float[] {0, 0, 1, 0, 0},
                               new float[] {0, 0, 0, 0.7f, 0},
                               new float[] {0, 0, 0, 0, 1}};
            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(
               colorMatrix,
               ColorMatrixFlag.Default,
               ColorAdjustType.Bitmap);
            resultGraphics.DrawImage(bitmap, imageBounds, rowInfo.TotalBounds.X, rowInfo.TotalBounds.Y, rowInfo.TotalBounds.Width, rowInfo.TotalBounds.Height, GraphicsUnit.Pixel, imageAttributes);
            resultGraphics.DrawIcon(Icon.FromHandle(Cursors.Default.Handle), 0, 0);
            return CreateCursor(result);
        }

        public Cursor GetDragRowsCursor(int[] rowHandles, Point poi)
        {
            if (rowHandles == null || rowHandles.Length == 0)
                return Cursor.Current;

            //return DevExpress.Utils.DragAndDropCursors.MoveEffectCursor;

            GridViewInfo vi = _View.GetViewInfo() as GridViewInfo;

            //需要绘制的第一行（选中并且grid中显示的）
            var topRowInfo = vi.GetGridRowInfo(new[] { rowHandles.Min(), _View.TopRowIndex }.Max());

            //需要绘制的最后一行 （选中并且grid中显示的）
            var btmRowInfo = vi.GetGridRowInfo(new[] { rowHandles.Max(), vi.RowsInfo.Max(x => x.VisibleIndex) }.Min());

            //没有显示选中行
            if (topRowInfo == null || btmRowInfo == null)
                return Cursor.Current;


            //所有选中行的高度和
            var height = Rectangle.Union(topRowInfo.Bounds, btmRowInfo.Bounds).Size.Height;

            //所有列的宽度和
            var width = vi.ColumnsInfo.Where(x => x.Type == GridColumnInfoType.Indicator || x.Type == GridColumnInfoType.Column).Sum(x => x.Bounds.Width);

            //最终图像的矩形
            var imageBounds = new Rectangle(new Point(0, 0), new Size(width, height));

            //绘制
            var imgTmp = new Bitmap(imageBounds.Width, imageBounds.Height);
            using (var gTmp = Graphics.FromImage(imgTmp))
            {

                //draw control to bitmap
                var ctrl = _View.GridControl;
                var imgControl = new Bitmap(ctrl.Width, ctrl.Height);
                ctrl.DrawToBitmap(imgControl, new Rectangle(0, 0, imgControl.Width, imgControl.Height));

                //从整个grid图像中截取需要的图像
                gTmp.DrawImage(imgControl,
                    new Rectangle(0, 0, imgTmp.Width, imgTmp.Height),
                    new Rectangle(topRowInfo.Bounds.X, topRowInfo.Bounds.Y, imgTmp.Width, imgTmp.Height),
                    GraphicsUnit.Pixel);

            }

            //1/3比例缩放图片
            var img = new Bitmap(imgTmp, new Size(imgTmp.Width / 3, (imgTmp.Height / 3)));

            var imgCur = Icon.FromHandle(DevExpress.Utils.DragCursors.HandDragCursor.Handle);


            //最终返回的图像
            var imgRes = new Bitmap(img.Width + imgCur.Width, img.Height + imgCur.Height);
            using (var gRes = Graphics.FromImage(imgRes))
            {
                //将之前处理完成的图像绘制到新的图片中
                gRes.DrawImage(img, new Rectangle(new Point(imgCur.Width, imgCur.Height), img.Size));

                //将鼠标指针绘制到左上角
                gRes.DrawIcon(imgCur, 0, 0);

            }

            //从bitmap创建cursor
            return CreateCursor(imgRes, imgCur.Width / 2, imgCur.Height / 2);


        }


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);
        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        public static Cursor CreateCursor(Bitmap bmp, int xHotspot, int yHotspot)
        {
            if (bmp == null) return Cursors.Default;
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.fIcon = false;
            tmp.xHotspot = xHotspot;
            tmp.yHotspot = yHotspot;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }

        /// <summary>
        /// 创建鼠标指针，焦点在左上角
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Cursor CreateCursor(Bitmap bmp)
        {
            if (bmp == null) return Cursors.Default;
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.fIcon = false;
            tmp.xHotspot = 0;
            tmp.yHotspot = 0;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }

        /// <summary>
        /// 创建鼠标指针，焦点在图片中心
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Cursor CreateCursorMiddle(Bitmap bmp)
        {
            if (bmp == null) return Cursors.Default;
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.fIcon = false;
            tmp.xHotspot = bmp.Width / 2;
            tmp.yHotspot = bmp.Height / 2;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }

    }
}
