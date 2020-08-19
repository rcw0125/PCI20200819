using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_BCBZGZ : Form
    {
        public FrmPB_BCBZGZ()
        {
            InitializeComponent();
        }
        Bll_TB_BCBZGZ bll = new Bll_TB_BCBZGZ();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_GZ.Text.Trim()=="")
            {
                MessageBox.Show("规则不能未空");
                return;
            }
            if (txt_GZMC.Text.Trim() == "")
            {
                MessageBox.Show("规则名称不能未空");
                return;
            }
            string strSF = "";//首炉要求
            if (this.ck_sfzh.Checked)
            {
                strSF = ck_sfzh.Text;
            }
            Mod_TB_BCBZGZ mod = new Mod_TB_BCBZGZ();
            mod.C_EMP_ID = RV.UI.UserInfo.UserID;
            mod.C_GZ = txt_GZ.Text.Trim();
            mod.C_GZMC = txt_GZMC.Text.Trim();
            mod.C_SFYS = strSF;
            bll.Add(mod);
            Query();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll.GetListByMC(txt_mccx.Text.Trim()).Tables[0];
                this.gc_BCBZ.DataSource = dt;
                this.gv_BCBZ.OptionsView.ColumnAutoWidth = false;
                this.gv_BCBZ.OptionsSelection.MultiSelect = true;
                gv_BCBZ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                SetGridViewRowNum.SetRowNum(gv_BCBZ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int[] row = gv_BCBZ.GetSelectedRows();
            foreach (var item in row)
            {
                string id = gv_BCBZ.GetRowCellValue(item,"C_ID").ToString();
                bll.Delete(id);
            }
            Query();
        }
    }
}
