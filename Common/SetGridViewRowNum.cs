using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    /// <summary>
    /// 操作gridview
    /// </summary>
    public class SetGridViewRowNum
    {
        /// <summary>
        /// 显示girdview行号
        /// </summary>
        /// <param name="gv"></param>
        public static void SetRowNum(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            try
            {
                //添加行号
                gv.IndicatorWidth = 50;
                gv.CustomDrawRowIndicator += delegate (object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
                {
                    e.Appearance.Font = new System.Drawing.Font("宋体", 9);
                    e.Info.ImageIndex = -1;
                    if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                    {
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                };

                //允许ctrl+c复制
                gv.KeyDown += delegate (object sender, System.Windows.Forms.KeyEventArgs e)
                {
                    if (e.Control & e.KeyCode == Keys.C)
                    {
                        Clipboard.Clear();
                        Clipboard.SetDataObject(gv.GetFocusedRowCellValue(gv.FocusedColumn).ToString());
                        e.Handled = true;
                    }
                };

                if (gv.Columns["C_EMP_ID"] != null)
                {
                    gv.Columns["C_EMP_ID"].ColumnEdit = RV.UI.UserInfo.repoUserName;
                    gv.Columns["C_EMP_ID"].OptionsColumn.AllowEdit = false;
                }

                CommonSub commonSub = new CommonSub();
                if (gv.Columns["C_SHIFT"] != null)
                {
                    gv.Columns["C_SHIFT"].ColumnEdit = commonSub.GetBCIdDescItemComboBox();
                    gv.Columns["C_SHIFT"].OptionsColumn.AllowEdit = false;
                }
                if (gv.Columns["C_GROUP"] != null)
                {
                    gv.Columns["C_GROUP"].ColumnEdit = commonSub.GetBZIdDescItemComboBox();
                    gv.Columns["C_GROUP"].OptionsColumn.AllowEdit = false;
                }
                if (gv.Columns["C_WE_SHIFT"] != null)
                {
                    gv.Columns["C_WE_SHIFT"].ColumnEdit = commonSub.GetBCIdDescItemComboBox();
                    gv.Columns["C_WE_SHIFT"].OptionsColumn.AllowEdit = false;
                }
                if (gv.Columns["C_WE_GROUP"] != null)
                {
                    gv.Columns["C_WE_GROUP"].ColumnEdit = commonSub.GetBZIdDescItemComboBox();
                    gv.Columns["C_WE_GROUP"].OptionsColumn.AllowEdit = false;
                }
                if (gv.Columns["C_PRODUCE_SHIFT"] != null)
                {
                    gv.Columns["C_PRODUCE_SHIFT"].ColumnEdit = commonSub.GetBCIdDescItemComboBox();
                    gv.Columns["C_PRODUCE_SHIFT"].OptionsColumn.AllowEdit = false;
                }
                if (gv.Columns["C_PRODUCE_GROUP"] != null)
                {
                    gv.Columns["C_PRODUCE_GROUP"].ColumnEdit = commonSub.GetBZIdDescItemComboBox();
                    gv.Columns["C_PRODUCE_GROUP"].OptionsColumn.AllowEdit = false;
                }
                gv.BestFitColumns();
            }
            catch
            {
                gv.BestFitColumns();
            }
        }
    }
}
