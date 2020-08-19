using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IDAL;

namespace XGCAP.UI.R.RP
{
    public partial class FRMCS_RFJK : Form
    {
        public FRMCS_RFJK()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_TRC_ROLL_PRODCUT = new Bll_TRC_ROLL_PRODCUT();
        Dal_Interface_FR dal_Interface_FR = new Dal_Interface_FR();
        private void btn_SCZKD_Click(object sender, EventArgs e)
        {
            int[] rows = gv_ZGSJ.GetSelectedRows();
            string idstr = "";
            foreach (var item in rows)
            {
                DataRow dr = gv_ZGSJ.GetDataRow(item);
                idstr += "'" + dr["C_ID"].ToString() + "',";
            }
            idstr = idstr.Substring(0, idstr.Length - 1);
            dal_Interface_FR.SENDZKD(idstr,cbo_CK1.EditValue.ToString());
        }

        private void FRMCS_RFJK_Load(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TRC_ROLL_PRODCUT.GetList("").Tables[0];
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

        private void btn_TBTM_Click(object sender, EventArgs e)
        {
            dal_Interface_FR.TBZKD(Application.StartupPath);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int[] rows = gv_ZGSJ.GetSelectedRows();
            string idstr = "";
            foreach (var item in rows)
            {
                DataRow dr = gv_ZGSJ.GetDataRow(item);
                idstr += "'" + dr["C_ID"].ToString() + "',";
            }
            idstr = idstr.Substring(0, idstr.Length - 1);
            dal_Interface_FR.SENDQTCKD(idstr, txt_CPH.Text, txt_Adderss.Text, "yy", txt_TYPE.Text, txt_SHDW.Text, de_SLSJ.DateTime,"","","");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dal_Interface_FR.TBQTCKD(Application.StartupPath);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dal_Interface_FR.TBYWD();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dal_Interface_FR.SendGRD("15", "311802382");
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            dal_Interface_FR.TBFYD(Application.StartupPath);

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            dal_Interface_FR.SENDFYD("DM18112900142");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            //dal_Interface_FR.SendXml_DM(Application.StartupPath, "DM18121200229");
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            Bll_Interface_NC_Roll_ZK4I bll_Interface_NC_Roll_ZK4I = new Bll_Interface_NC_Roll_ZK4I();
            Bll_Interface_NC_Roll_ZK4A bll_Interface_NC_Roll_ZK4A = new Bll_Interface_NC_Roll_ZK4A();
            bll_Interface_NC_Roll_ZK4I.SendXml_GP(Application.StartupPath, "2018122500002");
            bll_Interface_NC_Roll_ZK4A.SendXml_GP(Application.StartupPath, "2018122500002");
        }
    }
}
