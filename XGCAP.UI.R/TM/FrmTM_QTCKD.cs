using BLL;
using IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace XGCAP.UI.R.TM
{
    public partial class FrmTM_QTCKD : Form
    {
        public FrmTM_QTCKD()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_TRC_ROLL_PRODCUT = new Bll_TRC_ROLL_PRODCUT();
        Dal_Interface_FR dal_Interface_FR = new Dal_Interface_FR();
        CommonSub commonSub = new CommonSub();
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query("E");
        }

        private void FrmTM_QTCKD_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindXCK(cbo_CK2);
            cbo_CK2.SelectedIndex = 0;
            commonSub.ImageComboBoxEditBindXCK(cbo_CK1);
            cbo_CK1.SelectedIndex = 0;
            commonSub.ImageComboBoxEditBindXCK(cbo_MBCK);
            cbo_CK1.SelectedIndex = 0;
            Query("E");
            QueryQC("QC");
        }

        private void Query(string status)
        {
            try
            {
                DataTable dt = null;
                dt = bll_TRC_ROLL_PRODCUT.GetXCKList("", txt_Grd.Text, txt_Std.Text, cbo_CK1.EditValue.ToString(), cbo_QY.EditValue.ToString(), cbo_KW.EditValue.ToString(), status).Tables[0];
                this.gc_ZGSJ.DataSource = dt;
                this.gv_ZGSJ.OptionsView.ColumnAutoWidth = false;
                this.gv_ZGSJ.OptionsSelection.MultiSelect = true;
                gv_ZGSJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                //this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox(); //翻译工位
                this.gv_ZGSJ.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_QueryQC_Click(object sender, EventArgs e)
        {
            QueryQC("QC");
        }
        private void QueryQC(string status)
        {
            try
            {
                DataTable dt = null;
                dt = bll_TRC_ROLL_PRODCUT.GetXCKList("", txt_Grd1.Text, txt_Std1.Text, cbo_CK2.EditValue.ToString(), "", "", status).Tables[0];
                this.gc_QC.DataSource = dt;
                this.gv_QC.OptionsView.ColumnAutoWidth = false;
                this.gv_QC.OptionsSelection.MultiSelect = true;
                gv_QC.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                //this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox(); //翻译工位
                this.gv_ZGSJ.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_QTCK_Click(object sender, EventArgs e)
        {
            int[] rows = gv_ZGSJ.GetSelectedRows();
            if (rows.Count()>0)
            {
                string idstr = "";
                foreach (var item in rows)
                {
                    DataRow dr = gv_ZGSJ.GetDataRow(item);
                    idstr += "'" + dr["C_ID"].ToString() + "',";
                }
                idstr = idstr.Substring(0, idstr.Length - 1);
                string message = dal_Interface_FR.SENDQTCKD(idstr, txt_CPH.Text, txt_Adderss.Text, RV.UI.UserInfo.userID, txt_TYPE.Text, txt_SHDW.Text, de_SLSJ.DateTime, txt_CYS.Text, cbo_MBCK.EditValue.ToString(), cbo_MBCK.Text);
                if (message == "1")
                {
                    MessageBox.Show("发送条码成功！");
                }
                else
                {
                    MessageBox.Show(message);
                    dal_Interface_FR.RFLOG("其他出库单", message);
                }
            }
            Query("E");
            QueryQC("QC");
        }

        private void btn_TbTM_Click(object sender, EventArgs e)
        {
            string message = dal_Interface_FR.TBQTCKD(Application.StartupPath);
            if (message == "1")
            {
                MessageBox.Show("同步成功！");
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btn_OutBack_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rows = gv_QC.GetSelectedRows();
                string idstr = "";
                foreach (var item in rows)
                {
                    DataRow dr = gv_QC.GetDataRow(item);
                    idstr += "'" + dr["C_ID"].ToString() + "',";
                }
                idstr = idstr.Substring(0, idstr.Length - 1);
                if (dal_Interface_FR.CXQTCKDByIdstr(idstr) > 0)
                {
                    MessageBox.Show("撤销成功！");
                }
                else
                {
                    MessageBox.Show("撤销失败,条码已读取！");
                }
                Query("E");
                QueryQC("QC");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbo_CK1_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindXCKQY(cbo_CK2.EditValue.ToString(), cbo_QY);
            cbo_QY.Properties.Items.Add("全部", "", 0);
            cbo_QY.SelectedIndex = cbo_QY.Properties.Items.Count - 1;
        }

        private void cbo_QY_SelectedValueChanged(object sender, EventArgs e)
        {
            cbo_KW.Properties.Items.Clear();
            if (cbo_QY.EditValue.ToString() == "")
            {
                cbo_KW.Properties.Items.Add("全部", "", 0);
                cbo_KW.SelectedIndex = cbo_KW.Properties.Items.Count - 1;
            }
            else
            {
                commonSub.ImageComboBoxEditBindXCKKW(cbo_QY.EditValue.ToString(), cbo_KW);
                cbo_KW.Properties.Items.Add("全部", "", 0);
                cbo_KW.SelectedIndex = cbo_KW.Properties.Items.Count - 1;
            }
        }

        private void cbo_CK2_SelectedValueChanged(object sender, EventArgs e)
        {

            commonSub.ImageComboBoxEditBindXCKQY(cbo_CK2.EditValue.ToString(), cbo_QY2);
            cbo_QY2.Properties.Items.Add("全部", "", 0);
            cbo_QY2.SelectedIndex = cbo_QY2.Properties.Items.Count - 1;
        }

        private void cbo_QY2_SelectedValueChanged(object sender, EventArgs e)
        {
            cbo_KW2.Properties.Items.Clear();
            if (cbo_QY2.EditValue.ToString() == "")
            {
                cbo_KW2.Properties.Items.Add("全部", "", 0);
                cbo_KW2.SelectedIndex = cbo_KW2.Properties.Items.Count - 1;
            }
            else
            {
                commonSub.ImageComboBoxEditBindXCKKW(cbo_QY.EditValue.ToString(), cbo_KW2);
                cbo_KW2.Properties.Items.Add("全部", "", 0);
                cbo_KW2.SelectedIndex = cbo_KW2.Properties.Items.Count - 1;
            }

        }
    }
}
