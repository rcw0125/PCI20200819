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
    public partial class FrmPB_ZXJRLTJ : Form
    {
        public FrmPB_ZXJRLTJ()
        {
            InitializeComponent();
        }
        Bll_TPB_JRLTJ bll_TPB_JRLTJ = new Bll_TPB_JRLTJ();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        Bll_TQB_STD_SPEC bll_TQB_STD_SPEC = new Bll_TQB_STD_SPEC();
        CommonSub sub = new CommonSub();
        private void FrmPB_ZXJRLTJ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            Query();
            sub.ComboBoxEditBindSPEC(cbo_GG1, "");
            cbo_GG1.SelectedIndex = 0;
            sub.ImageComboBoxEditBindGWByGXstr("'ZX','KP'",cbo_GW1);
            sub.ImageComboBoxEditBindGWByGXstr("'ZX','KP'", cbo_GW2);
            cbo_GW1.SelectedIndex = 0;
            cbo_GW2.SelectedIndex = 0;
            BindGGByID();
        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            DataTable dt = null;
            dt = bll_TQB_STD_MAIN.GetList(txt_Std.Text, txt_Grd.Text).Tables[0];
            this.gc_StdMain.DataSource = dt;
            this.gv_StdMain.OptionsView.ColumnAutoWidth = false;
            this.gv_StdMain.OptionsSelection.MultiSelect = true;
            gv_StdMain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_StdMain.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdMain);
        }

        private void btn_QueryGG_Click(object sender, EventArgs e)
        {
            try
            {
                BindGGByID();
            }
            catch
            {
                MessageBox.Show("规格输入错误，请输入数字!");
            }
          
        }
        public void BindGGByID()
        {
            DataTable dt = bll_TQB_STD_SPEC.GetSPECListBySTA("", cbo_GG1.EditValue.ToString(), cbo_GG2.EditValue.ToString()).Tables[0];
            this.gc_GG.DataSource = dt;
            this.gv_GG.OptionsView.ColumnAutoWidth = false;

            this.gv_GG.OptionsSelection.MultiSelect = true;
            this.gv_GG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GG.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GG);
        }

        private void cbo_GG1_SelectedValueChanged(object sender, EventArgs e)
        {
            sub.ComboBoxEditBindSPEC(cbo_GG2, cbo_GG1.EditValue.ToString());
            cbo_GG2.SelectedIndex = cbo_GG2.Properties.Items.Count - 1;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int[] grdrow = gv_StdMain.GetSelectedRows();
            int[] ggrow = gv_GG.GetSelectedRows();
            if (grdrow.Count() < 1)
            {
                MessageBox.Show("未选中钢种！");
                return;
            }
            if (ggrow.Count() < 1)
            {
                MessageBox.Show("未选中规格！");
                return;
            }
            if (txt_TIME.Text.Trim() == ""|| txt_TIME.Text.Trim() == "0")
            {
                MessageBox.Show("时间不能为0或为空！");
                return;
            }
            if (txt_WD.Text.Trim() == "" || txt_WD.Text.Trim() == "0")
            {
                MessageBox.Show("温度不能为0或为空！");
                return;
            }
            string yczmessage = "";
            string cgmessage = "";
            string sbmessage = "";
            foreach (var grditem in grdrow)
            {

                string ggstr = "";
                foreach (var ggitem in ggrow)
                {
                    string gg = gv_GG.GetRowCellValue(ggitem, "C_SPEC").ToString();
                    ggstr +=  gg + ",";
                }
                ggstr = ggstr.Substring(0, ggstr.Length - 1);
                string grd = gv_StdMain.GetRowCellValue(grditem, "C_STL_GRD").ToString();
                string std = gv_StdMain.GetRowCellValue(grditem, "C_STD_CODE").ToString();
                Mod_TPB_JRLTJ mod_TPB_JRLTJ = new Mod_TPB_JRLTJ();
                mod_TPB_JRLTJ.C_STL_GRD = grd;
                mod_TPB_JRLTJ.C_STD_CODE = std;
                mod_TPB_JRLTJ.C_STA_ID = cbo_GW2.EditValue.ToString();
                mod_TPB_JRLTJ.C_EMP_ID = RV.UI.UserInfo.userID;
                mod_TPB_JRLTJ.N_WD = Convert.ToDecimal(txt_WD.Text==""?"0": txt_WD.Text);
                mod_TPB_JRLTJ.N_TIME = Convert.ToDecimal(txt_TIME.Text == "" ? "0": txt_TIME.Text);
                string[] ggarr = ggstr.Split(',');
                string msggg = "";
                foreach (var gg in ggarr)
                {
                    mod_TPB_JRLTJ.C_SPEC_STR = gg;
                    if (bll_TPB_JRLTJ.SFCF(mod_TPB_JRLTJ) > 0)
                    {
                        msggg += gg + ",";
                    }
                }
                if (msggg != "")
                {
                    msggg = msggg.Substring(0, msggg.Length - 1);
                    yczmessage += grd + "(" + std + "):" + msggg + "\r\n";
                    continue;
                }
                mod_TPB_JRLTJ.C_SPEC_STR = ggstr;
                if (bll_TPB_JRLTJ.Add(mod_TPB_JRLTJ) == true)
                {
                    cgmessage += grd + "(" + std + ") \r\n";
                }
                else
                {
                    sbmessage += grd + "(" + std + ") \r\n";
                }
            }
            if (cgmessage != "")
            {
                cgmessage += "保存成功！\r\n";
            }
            if (yczmessage != "")
            {
                yczmessage += "已存在，保存失败！\r\n";
            }
            if (sbmessage != "")
            {
                sbmessage += "保存异常！";
            }
            MessageBox.Show(cgmessage + yczmessage + sbmessage);
            cbo_GW2.EditValue = cbo_GW1.EditValue;
            QueryJRLTJ();
        }


        public void QueryJRLTJ()
        {
            DataTable dt = bll_TPB_JRLTJ.GetList(txt_Grd1.Text.Trim(), txt_Std1.Text.Trim(),cbo_GW1.EditValue.ToString()).Tables[0];
            this.gc_XMTJ.DataSource = dt;
            this.gv_XMTJ.OptionsView.ColumnAutoWidth = false;
            this.gv_XMTJ.OptionsSelection.MultiSelect = true;
            this.gv_XMTJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_XMTJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_XMTJ);
        }
        private void btn_DCJRLTJ_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_XMTJ);
        }

        private void btn_Stop2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_XMTJ.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_XMTJ.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_XMTJ.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    bool update = bll_TPB_JRLTJ.Delete(strID);
                    if (update)
                    {
                        commitNum = commitNum + 1;
                    }
                    else
                    {
                        failtNum = failtNum + 1;
                    }
                }
                if (selectedNum == 0)
                {
                    MessageBox.Show("未选中修磨条件！");
                }
                else
                {
                    MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");
                }

                QueryJRLTJ();//重新加载加热炉条件
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_QueryJRLTJ_Click(object sender, EventArgs e)
        {
            QueryJRLTJ();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bll_TPB_JRLTJ.DSJ();
        }
    }
}
