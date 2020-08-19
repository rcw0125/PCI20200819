using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;
namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_SCLX : Form
    {
        public FrmPB_SCLX()
        {
            InitializeComponent();
        }
        CommonSub commonSub = new CommonSub();
        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();
        Bll_TPB_SCLX bll_TPB_SCLX = new Bll_TPB_SCLX();
        private void FrmPB_SCLX_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            Query();
        }
        //检测是否有新增连铸
        public void CKCC()
        {
            string proid = bll_TB_PRO.GetIDByProCode("CC");
            DataTable dt = bll_TPB_SCLX.CKGW(proid).Tables[0];
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Mod_TPB_SCLX mod_TPB_SCLX = new Mod_TPB_SCLX();
                    mod_TPB_SCLX.C_CC = item["C_ID"].ToString();
                    bll_TPB_SCLX.Add(mod_TPB_SCLX);
                }
            }
            MessageBox.Show("检测到有新增连铸！");
            Query();
        }
        public void Query()
        {
            DataTable dt = bll_TPB_SCLX.GetAllList().Tables[0];
            this.gc_SCLX.DataSource = dt;
            Col_CC.ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("CC");
            Col_LF.ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("LF");
            Col_RH.ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("RH");
            Col_ZL.ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("ZL");
            this.gv_SCLX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_SCLX);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < gv_SCLX.RowCount; i++)
            {
              string cc=  gv_SCLX.GetRowCellDisplayText(i, "C_CC").ToString();
                //3#
                if (cc.Contains("3")==true)
                {
                    string rh = gv_SCLX.GetRowCellDisplayText(i, "C_RH").ToString();
                    if (rh.Contains("1") == true)
                    {
                        MessageBox.Show("3#铸机不能选择1#RH！");
                        Query();
                        return;
                    }
                    string lf = gv_SCLX.GetRowCellDisplayText(i, "C_LF").ToString();
                    if (lf.Contains("3") == true)
                    {
                        MessageBox.Show("3#铸机不能选择3#LF！");
                        Query();
                        return;
                    }
                    string zl = gv_SCLX.GetRowCellDisplayText(i, "C_ZL").ToString();
                    if (zl.Contains("AOD")==true|| zl.Contains("4") == true)
                    {
                        MessageBox.Show("3#铸机不能选择AOD炉或4#转炉！");
                        Query();
                        return;
                    }
                }
                //4#
                if (cc.Contains("4") == true)
                {
                    string rh = gv_SCLX.GetRowCellDisplayText(i, "C_RH").ToString();
                    if (rh.Contains("1") == true)
                    {
                        MessageBox.Show("4#铸机不能选择1#RH！");
                        Query();
                        return;
                    }
                    string lf = gv_SCLX.GetRowCellDisplayText(i, "C_LF").ToString();
                    if (lf.Contains("4") == true)
                    {
                        MessageBox.Show("4#铸机不能选择3#转炉！");
                        Query();
                        return;
                    }
                    string zl = gv_SCLX.GetRowCellDisplayText(i, "C_ZL").ToString();
                    if (zl.Contains("AOD") == true || zl.Contains("4") == true)
                    {
                        MessageBox.Show("4#铸机不能选择AOD炉或4#转炉！");
                        Query();
                        return;
                    }
                }
                //5#
                if (cc.Contains("5") == true)
                {
                    string zl = gv_SCLX.GetRowCellDisplayText(i, "C_ZL").ToString();
                    if (zl.Contains("AOD") == true)
                    {
                        MessageBox.Show("5#铸机不能选择AOD炉！");
                        Query();
                        return;
                    }
                }
                //6#
                if (cc.Contains("6") == true)
                {
                    string rh = gv_SCLX.GetRowCellDisplayText(i, "C_RH").ToString();
                    if (rh.Contains("1") == true)
                    {
                        MessageBox.Show("6#铸机不能选择1#RH！");
                        Query();
                        return;
                    }
                    string lf = gv_SCLX.GetRowCellDisplayText(i, "C_LF").ToString();
                    if (lf.Contains("3") == true)
                    {
                        MessageBox.Show("6#铸机不能选择3#精炼！");
                        Query();
                        return;
                    }
                    string zl = gv_SCLX.GetRowCellDisplayText(i, "C_ZL").ToString();
                    if (zl.Contains("4") == true)
                    {
                        MessageBox.Show("6#铸机不能选择4#转炉！");
                        Query();
                        return;
                    }
                }
                //7#
                if (cc.Contains("7") == true)
                {
                    string rh = gv_SCLX.GetRowCellDisplayText(i, "C_RH").ToString();
                    if (rh.Contains("1") == true)
                    {
                        MessageBox.Show("7#铸机不能选择1#RH！");
                        Query();
                        return;
                    }
                    string lf = gv_SCLX.GetRowCellDisplayText(i, "C_LF").ToString();
                    if (lf.Contains("3") == true)
                    {
                        MessageBox.Show("7#铸机不能选择3#精炼！");
                        Query();
                        return;
                    }
                    string zl = gv_SCLX.GetRowCellDisplayText(i, "C_ZL").ToString();
                    if (zl.Contains("AOD") == true)
                    {
                        MessageBox.Show("7#铸机不能选择AOD炉！");
                        Query();
                        return;
                    }
                }
            }
            bll_TPB_SCLX.Delete();
            for (int i = 0; i < gv_SCLX.RowCount; i++)
            {
                Mod_TPB_SCLX mod_TPB_SCLX = new Mod_TPB_SCLX();
                mod_TPB_SCLX.C_CC = gv_SCLX.GetRowCellValue(i, "C_CC").ToString();
                mod_TPB_SCLX.C_EMP_ID = RV.UI.UserInfo.userID;
                mod_TPB_SCLX.C_LF = gv_SCLX.GetRowCellValue(i, "C_LF").ToString();
                mod_TPB_SCLX.C_RH = gv_SCLX.GetRowCellValue(i, "C_RH").ToString();
                mod_TPB_SCLX.C_ZL = gv_SCLX.GetRowCellValue(i, "C_ZL").ToString();
                bll_TPB_SCLX.Add(mod_TPB_SCLX);
            }
            MessageBox.Show("保存成功！");
            Query();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_SCLX);
        }
    }
}
