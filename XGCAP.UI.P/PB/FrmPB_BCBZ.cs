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
    public partial class FrmPB_BCBZ : Form
    {
        public FrmPB_BCBZ()
        {
            InitializeComponent();
        }
        CommonSub commonSub = new CommonSub();
        Bll_TB_BCBZ bll_TB_BCBZ = new Bll_TB_BCBZ();
        Bll_TB_BCBZGZ bll = new Bll_TB_BCBZGZ();
        private void FrmPB_BCBZ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            commonSub.ImageComboBoxEditBindGX("", cbo_GX2, "");
            commonSub.ImageComboBoxEditBindGX("", cbo_GX, "");
            cbo_GX2.SelectedIndex = 0;
            cbo_PBSL.SelectedIndex = 0;
            cbo_BZSL.SelectedIndex = 0;
            DateTime time = DateTime.Now;
            de_ST.DateTime = Convert.ToDateTime(time.Year + "/" + time.Month + "/" + time.Day + " 8:0:0");
            de_ET.DateTime = de_ST.DateTime.AddYears(1);
            cbo_GX.SelectedIndex = 0;
            de_ST1.EditValue = Convert.ToDateTime(time.Year + "/" + time.Month + "/" + time.Day + " 8:0:0");
            de_ET1.EditValue = de_ST1.DateTime.AddYears(1);
            commonSub.ImageComboBoxEditBindPBGZ(cbo_GZ);
            cbo_GZ.SelectedIndex = 0;
        }
        private void txt_PBSL_TextChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindBC(cbo_BC, Convert.ToInt32(cbo_PBSL.Text));
            cbo_BC.SelectedIndex = 0;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DateTime st = de_ST.DateTime;
            DateTime et = de_ET.DateTime;
            var aa = et - st;
            var bbb = aa.TotalHours;
            var list1 = cbo_BC.Properties.Items.ToList();
            var list2 = cbo_BZ.Properties.Items.ToList();
            int startbc = 0;
            int startbz = 0;
            bll_TB_BCBZ.Delete(st, cbo_GX2.EditValue.ToString());
            for (int i = 0; i < list1.Count; i++)
            {
                if (cbo_BC.EditValue.ToString() == list1[i].Value.ToString())
                {
                    startbc = i;
                    break;
                }
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (cbo_BZ.EditValue.ToString() == list2[i].Value.ToString())
                {
                    startbz = i;
                    break;
                }
            }
            int hours = (24 / Convert.ToInt32(cbo_PBSL.Text));
            for (int i = 1; i < Math.Ceiling(bbb / hours); i++)
            {
                Mod_TB_BCBZ mod_TB_BCBZ = new Mod_TB_BCBZ();
                mod_TB_BCBZ.C_PRO_ID = cbo_GX2.EditValue.ToString();
                mod_TB_BCBZ.C_BC = list1[startbc].Value.ToString();
                mod_TB_BCBZ.C_BZ = list2[startbz].Value.ToString();
                mod_TB_BCBZ.D_START = st;
                mod_TB_BCBZ.D_END = st.AddHours(hours);
                mod_TB_BCBZ.C_EMP_ID = RV.UI.UserInfo.userID;
                bll_TB_BCBZ.Add(mod_TB_BCBZ);
                st = st.AddHours(hours);
                if (startbc == list1.Count - 1)
                {
                    startbc = -1;
                }
                if (startbz == list2.Count - 1)
                {
                    startbz = -1;
                }
                startbc++;
                startbz++;
            }
            cbo_GX2.EditValue = cbo_GX.EditValue;
            MessageBox.Show("保存成功");
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
                WaitingFrom.ShowWait("");
                DataTable dt = null;
                dt = bll_TB_BCBZ.GetList(cbo_GX.EditValue.ToString(), de_ST1.DateTime, de_ET1.DateTime).Tables[0];
                this.gc_BCBZ.DataSource = dt;
                this.gv_BCBZ.OptionsView.ColumnAutoWidth = false;
                this.gv_BCBZ.OptionsSelection.MultiSelect = true;
                gv_BCBZ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                GX.ColumnEdit = commonSub.GetGXIdDescItemComboBox();
                SetGridViewRowNum.SetRowNum(gv_BCBZ);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbo_BZSL_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindBZ(cbo_BZ, Convert.ToInt32(cbo_BZSL.Text));
            cbo_BZ.SelectedIndex = 0;
        }

        private void btn_DC_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_BCBZ);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime st = de_ST.DateTime;
            DateTime et = de_ET.DateTime;
            var aa = et - st;
            var bbb = aa.TotalHours;
            var list1 = cbo_BC.Properties.Items.ToList();
            var list2 = cbo_BZ.Properties.Items.ToList();
            int startbc = 0;
            int startbz = 0;
            bll_TB_BCBZ.Delete(st, cbo_GX2.EditValue.ToString());
            for (int i = 0; i < list1.Count; i++)
            {
                if (cbo_BC.EditValue.ToString() == list1[i].Value.ToString())
                {
                    startbc = i;
                    break;
                }
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (cbo_BZ.EditValue.ToString() == list2[i].Value.ToString())
                {
                    startbz = i;
                    break;
                }
            }
            int hours = (24 / Convert.ToInt32(cbo_PBSL.Text));
            int bzbj = -1;
            for (int i = 1; i < Math.Ceiling(bbb / hours); i++)
            {
                if (startbc == 0)
                {
                    if (bzbj == -1)
                    {
                        bzbj = startbz;
                    }
                    else
                    {
                        startbz = bzbj;
                        bzbj = -1;
                    }
                }
                Mod_TB_BCBZ mod_TB_BCBZ = new Mod_TB_BCBZ();
                mod_TB_BCBZ.C_PRO_ID = cbo_GX2.EditValue.ToString();
                mod_TB_BCBZ.C_BC = list1[startbc].Value.ToString();
                mod_TB_BCBZ.C_BZ = list2[startbz].Value.ToString();
                mod_TB_BCBZ.D_START = st;
                mod_TB_BCBZ.D_END = st.AddHours(hours);
                mod_TB_BCBZ.C_EMP_ID = RV.UI.UserInfo.userID;
                bll_TB_BCBZ.Add(mod_TB_BCBZ);
                st = st.AddHours(hours);
                if (startbc == list1.Count - 1)
                {
                    startbc = -1;
                }
                if (startbz == list2.Count - 1)
                {
                    startbz = -1;
                }
                startbc++;
                startbz++;
            }
            cbo_GX2.EditValue = cbo_GX.EditValue;
            MessageBox.Show("保存成功");
            Query();
        }

        private void btn_ZXGZ_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            string gzmc = cbo_GZ.Text.ToString();
            Mod_TB_BCBZGZ mod = bll.GetModel(cbo_GZ.EditValue.ToString());
            string gz1 = mod.C_GZ;
            string gzn = mod.C_GZ;
            DateTime st = de_ST.DateTime;
            DateTime et = de_ET.DateTime;
            var aa = et - st;
            var bbb = aa.TotalHours;
            var list1 = cbo_BC.Properties.Items.ToList();
            var list2 = cbo_BZ.Properties.Items.ToList();
            int startbc = 0;
            int startbz = 0;
            int hours = (24 / Convert.ToInt32(cbo_PBSL.Text));
            double sumbc = Math.Ceiling(bbb / hours);//获取时间段总班次次数
            double sumgz = Math.Ceiling(  sumbc/ gz1.Length) - 1;//获取时间段规则周期次数
            double sybcsl =  sumbc% gz1.Length;
            bll_TB_BCBZ.Delete(st, cbo_GX2.EditValue.ToString());
            double sss = Math.Ceiling(10.001);
            for (int i = 0; i < list1.Count; i++)
            {
                if (cbo_BC.EditValue.ToString() == list1[i].Value.ToString())
                {
                    startbc = i;
                    break;
                }
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (cbo_BZ.EditValue.ToString() == list2[i].Value.ToString())
                {
                    startbz = i;
                    break;
                }
            }

            int b = 0;
            DataTable dt = bll_TB_BCBZ.GetLastList(cbo_GX.EditValue.ToString(), de_ST1.DateTime).Tables[0];
            string lastgz = dt.Rows[0]["C_BZ_NAME"].ToString();
            if (lastgz == "甲")
            {
                lastgz = "1";
            }
            else
            if (lastgz == "乙")
            {
                lastgz = "2";
            }
            else
            if (lastgz == "丙")
            {
                lastgz = "3";
            }
            else
            if (lastgz == "丁")
            {
                lastgz = "4";
            }
            int c = 0;
            if (cbo_BZ.Text == "甲")
            {
                c = 1;
            }
            else
            if (cbo_BZ.Text == "乙")
            {
                c = 2;
            }
            else
            if (cbo_BZ.Text == "丙")
            {
                c = 3;
            }
            else
            if (cbo_BZ.Text == "丁")
            {
                c = 4;
            }
            //获取首次规则排班
            for (int i = 0; i < gz1.Length; i++)
            {
                string bz = gz1.Substring(0, 1);
                if (b == 0)
                {
                    if (Convert.ToInt32(bz) != c)
                    {
                        gz1 = gz1.Substring(Convert.ToInt32(cbo_PBSL.Text), gz1.Length - Convert.ToInt32(cbo_PBSL.Text));
                        continue;
                    }
                    else
                    {
                        b = 1;
                        continue;
                    }
                }
            }
            if (sumgz == 0)
            {
                //首次规则排班
                for (int i = 0; i < sybcsl; i++)
                {
                    int bz = Convert.ToInt32(gz1.Substring(i, 1));
                    Mod_TB_BCBZ mod_TB_BCBZ = new Mod_TB_BCBZ();
                    mod_TB_BCBZ.C_PRO_ID = cbo_GX2.EditValue.ToString();
                    mod_TB_BCBZ.C_BC = list1[startbc].Value.ToString();
                    mod_TB_BCBZ.C_BZ = list2[bz - 1].Value.ToString();
                    mod_TB_BCBZ.D_START = st;
                    mod_TB_BCBZ.D_END = st.AddHours(hours);
                    mod_TB_BCBZ.C_EMP_ID = RV.UI.UserInfo.userID;
                    mod_TB_BCBZ.C_GZ = gzmc;
                    bll_TB_BCBZ.Add(mod_TB_BCBZ);
                    st = st.AddHours(hours);
                    if (startbc == list1.Count - 1)
                    {
                        startbc = -1;
                    }
                    startbc++;
                }
            }
            else
            {
                //首次规则排班
                for (int i = 0; i < gz1.Length; i++)
                {
                    int bz = Convert.ToInt32(gz1.Substring(i, 1));
                    Mod_TB_BCBZ mod_TB_BCBZ = new Mod_TB_BCBZ();
                    mod_TB_BCBZ.C_PRO_ID = cbo_GX2.EditValue.ToString();
                    mod_TB_BCBZ.C_BC = list1[startbc].Value.ToString();
                    mod_TB_BCBZ.C_BZ = list2[bz - 1].Value.ToString();
                    mod_TB_BCBZ.D_START = st;
                    mod_TB_BCBZ.D_END = st.AddHours(hours);
                    mod_TB_BCBZ.C_EMP_ID = RV.UI.UserInfo.userID;
                    mod_TB_BCBZ.C_GZ = gzmc;
                    bll_TB_BCBZ.Add(mod_TB_BCBZ);
                    st = st.AddHours(hours);
                    if (startbc == list1.Count - 1)
                    {
                        startbc = -1;
                    }
                    startbc++;
                }
                if (sumgz!=1)
                {
                    for (int a = 0; a < sumgz; a++)
                    {
                        for (int i = 0; i < gzn.Length; i++)
                        {
                            int bz = Convert.ToInt32(gzn.Substring(i, 1));
                            Mod_TB_BCBZ mod_TB_BCBZ = new Mod_TB_BCBZ();
                            mod_TB_BCBZ.C_PRO_ID = cbo_GX2.EditValue.ToString();
                            mod_TB_BCBZ.C_BC = list1[startbc].Value.ToString();
                            mod_TB_BCBZ.C_BZ = list2[bz - 1].Value.ToString();
                            mod_TB_BCBZ.D_START = st;
                            mod_TB_BCBZ.D_END = st.AddHours(hours);
                            mod_TB_BCBZ.C_EMP_ID = RV.UI.UserInfo.userID;
                            mod_TB_BCBZ.C_GZ = gzmc;
                            bll_TB_BCBZ.Add(mod_TB_BCBZ);
                            st = st.AddHours(hours);
                            if (startbc == list1.Count - 1)
                            {
                                startbc = -1;
                            }
                            startbc++;
                        }
                    }  
                }
                //尾次规则排班
                for (int i = 0; i < sybcsl; i++)
                {
                    int bz = Convert.ToInt32(gzn.Substring(i, 1));
                    Mod_TB_BCBZ mod_TB_BCBZ = new Mod_TB_BCBZ();
                    mod_TB_BCBZ.C_PRO_ID = cbo_GX2.EditValue.ToString();
                    mod_TB_BCBZ.C_BC = list1[startbc].Value.ToString();
                    mod_TB_BCBZ.C_BZ = list2[bz - 1].Value.ToString();
                    mod_TB_BCBZ.D_START = st;
                    mod_TB_BCBZ.D_END = st.AddHours(hours);
                    mod_TB_BCBZ.C_GZ = gzmc;
                    mod_TB_BCBZ.C_EMP_ID = RV.UI.UserInfo.userID;
                    bll_TB_BCBZ.Add(mod_TB_BCBZ);
                    st = st.AddHours(hours);
                    if (startbc == list1.Count - 1)
                    {
                        startbc = -1;
                    }
                    startbc++;
                }
            }
            cbo_GX2.EditValue = cbo_GX.EditValue;
            MessageBox.Show("保存成功");
            WaitingFrom.CloseWait();
            Query();
        }
    }
}
