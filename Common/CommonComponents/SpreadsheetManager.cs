using DevExpress.Spreadsheet;
using DevExpress.Utils.Menu;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraSpreadsheet.Commands;
using DevExpress.XtraSpreadsheet.Menu;
using DevExpress.XtraSpreadsheet.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Common
{
    public class SpreadsheetManager : Component
    {
        public event Action<List<Cell>> ContentChanged;

        private SpreadsheetControl _control;

        /// <summary>
        /// 存储Spreadsheet模板
        /// </summary>
        private byte[] _arrTemplateByte;

        /// <summary>
        /// Spreadsheet控件对象
        /// </summary>
        public SpreadsheetControl Control
        {
            get
            {
                return _control;
            }
            set
            {
                _control = value;

                this.Control.SelectionChanged += (o, e) =>
                {
                    // GlueNet.Winforms.GlueForm.MainView?.ShowStatusMessage(this.Control.GetSelectionSummaryInfo().ToString());
                };

                this.Control.PopupMenuShowing += Sp_PopupMenuShowing;

                this._arrTemplateByte = _control.SaveDocument(DocumentFormat.Xlsx);
            }
        }

        private void Sp_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            SpreadsheetControl control = sender as SpreadsheetControl;
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                ISpreadsheetCommandFactoryService service = (ISpreadsheetCommandFactoryService)control.GetService(typeof(ISpreadsheetCommandFactoryService));

                //SpreadsheetMenuItemCommandWinAdapter adapter = new SpreadsheetMenuItemCommandWinAdapter(service.CreateCommand(SpreadsheetCommandId.FileNew));
                //SpreadsheetMenuItem item = (SpreadsheetMenuItem)adapter.CreateMenuItem(DXMenuItemPriority.Normal);
                //item.BeginGroup = true;
                //item.Caption = "新建";
                //e.Menu.Items.Add(item);

                //SpreadsheetMenuItemCommandWinAdapter adapter2 = new SpreadsheetMenuItemCommandWinAdapter(service.CreateCommand(SpreadsheetCommandId.FileOpen));
                //var item2 = (SpreadsheetMenuItem)adapter2.CreateMenuItem(DXMenuItemPriority.Normal);
                //item2.Caption = "打开Excel文件";
                //e.Menu.Items.Add(item2);

                SpreadsheetMenuItemCommandWinAdapter adapter3 = new SpreadsheetMenuItemCommandWinAdapter(service.CreateCommand(SpreadsheetCommandId.FileSaveAs));
                var item3 = (SpreadsheetMenuItem)adapter3.CreateMenuItem(DXMenuItemPriority.Normal);
                item3.Caption = "另存为";
                e.Menu.Items.Add(item3);

                SpreadsheetMenuItemCommandWinAdapter adapter4 = new SpreadsheetMenuItemCommandWinAdapter(service.CreateCommand(SpreadsheetCommandId.FilePrintPreview));
                var item4 = (SpreadsheetMenuItem)adapter4.CreateMenuItem(DXMenuItemPriority.Normal);
                item4.Caption = "打印预览";
                e.Menu.Items.Add(item4);

                SpreadsheetMenuItemCommandWinAdapter adapter5 = new SpreadsheetMenuItemCommandWinAdapter(service.CreateCommand(SpreadsheetCommandId.ViewShowGridlines));
                var item5 = (SpreadsheetMenuItem)adapter5.CreateMenuItem(DXMenuItemPriority.Normal);
                item5.Caption = "显示/隐藏网格线";
                e.Menu.Items.Add(item5);

                SpreadsheetMenuItemCommandWinAdapter adapter6 = new SpreadsheetMenuItemCommandWinAdapter(service.CreateCommand(SpreadsheetCommandId.ViewShowHeadings));
                var item6 = (SpreadsheetMenuItem)adapter6.CreateMenuItem(DXMenuItemPriority.Normal);
                item6.Caption = "显示/隐藏excel列头";
                e.Menu.Items.Add(item6);

            }
        }

        public Worksheet Worksheet
        {
            get
            {
                return this.Control.ActiveWorksheet;
            }
        }

        private List<Cell> ChangedCells
        {
            get; set;
        } = new List<Cell>();

        public Range this[string referense]
        {
            get
            {
                return this.Worksheet[referense];
            }
        }

        /// <summary>
        /// 初始化SpreadSheet
        /// </summary>
        public void Init(SpreadsheetElementVisibility sheetVisible = SpreadsheetElementVisibility.Hidden, bool showZeroValue = false)
        {
            this.Control.LoadDocument(_arrTemplateByte, DocumentFormat.Xlsx);

            this.Control.CellValueChanged -= Control_CellValueChanged;
            this.Control.ContentChanged -= Control_ContentChanged;
            this.Control.CellValueChanged += Control_CellValueChanged;
            this.Control.ContentChanged += Control_ContentChanged;

            this.Control.Options.TabSelector.Visibility = sheetVisible;

            this.Worksheet.ActiveView.ShowGridlines = false;
            this.Worksheet.ActiveView.ShowHeadings = false;

            this.Worksheet.ActiveView.ShowZeroValues = showZeroValue;
        }

        private void Control_ContentChanged(object sender, EventArgs e)
        {
            if (ChangedCells.Count > 0)
            {
                ContentChanged?.Invoke(ChangedCells);

                ChangedCells.Clear();
            }
        }

        private void Control_CellValueChanged(object sender, SpreadsheetCellEventArgs e)
        {
            if (
                // 撤销时候Action 是 UndoRedo
                //e.Action == CellValueChangedAction.UndoRedo ||
                e.Cell.Value == e.OldValue)
            {
                return;
            }

            ChangedCells.Add(e.Cell);
        }

        /// <summary>
        /// 绑定列头
        /// </summary>
        /// <param name="tmpRange"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        public Range BuildHeader(Range tmpRange, params string[] headers)
        {
            var currentRange = tmpRange;
            foreach (var headerItem in headers)
            {
                currentRange.CopyFrom(tmpRange, PasteSpecial.All);
                currentRange.ColumnWidth = tmpRange.ColumnWidth;
                this.Worksheet[currentRange.TopRowIndex, currentRange.LeftColumnIndex].SetValue(headerItem);

                this.Worksheet.Range.FromLTRB(
                    currentRange.LeftColumnIndex,
                    currentRange.TopRowIndex,
                    currentRange.RightColumnIndex,
                    currentRange.TopRowIndex).Merge();

                currentRange = this.R(currentRange);
            }

            return this.Worksheet.Range.FromLTRB(
                tmpRange.LeftColumnIndex,
                tmpRange.TopRowIndex,
                tmpRange.LeftColumnIndex + (headers.Length * tmpRange.ColumnCount) - 1,
                tmpRange.BottomRowIndex
            );
        }

        /// <summary>
        /// 区域向右移动返回新的区域，用于定位新的区域
        /// </summary>
        /// <param name="range">移动的区域</param>
        /// <param name="count">跳过列数目（1表示不跳过，直接向右移动区域，2表示跳过一列）</param>
        /// <returns></returns>
        public Range R(Range range, int count = 1)
        {
            if (count == 0) return range;

            count = count < 0 ? 0 : count;

            return this.Worksheet.Range.FromLTRB(
                range.RightColumnIndex + count,
                range.TopRowIndex,
                range.RightColumnIndex + count + range.ColumnCount - 1,
                range.BottomRowIndex);
        }

        /// <summary>
        /// 区域向下移动返回新的区域，用于定位新的区域
        /// </summary>
        /// <param name="range">移动的区域</param>
        /// <param name="count">跳过行数目（1表示不跳过，直接向下移动区域,，2表示跳过一行）</param>
        /// <returns></returns>
        public Range B(Range range, int count = 1)
        {
            if (count == 0) return range;

            count = count < 0 ? 0 : count;

            return this.Worksheet.Range.FromLTRB(
                range.LeftColumnIndex,
                range.BottomRowIndex + count,
                range.RightColumnIndex,
                range.BottomRowIndex + count + range.RowCount - 1);
        }

        /// <summary>
        /// 强制关闭正在编辑cell，使得可以获取正在编辑cell值
        /// </summary>
        public void EndEdit()
        {
            //this.Control.BeginUpdate();

            var a = this.Control.Selection;

            //var b = a.MoveToBottom();


            //this.Control.SetSelectedRanges(new List<Range> { b });
            //this.Control.SetSelectedRanges(new List<Range> { a });

            //this.Control.EndUpdate();
        }
    }
}
