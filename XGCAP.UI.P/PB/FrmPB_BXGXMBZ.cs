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
    public partial class FrmPB_BXGXMBZ : Form
    {
        public FrmPB_BXGXMBZ()
        {
            InitializeComponent();
        }
        private string strMenuName;
        private Bll_TQB_COPING_BASIC bll_xm = new Bll_TQB_COPING_BASIC();
        private Bll_TB_MATRL_MAIN bll_wl = new Bll_TB_MATRL_MAIN();
        private Bll_TPB_BXGXMGZ bll_bxg = new Bll_TPB_BXGXMGZ();
        private void FrmPB_BXGXMBZ_Load(object sender, EventArgs e)
        {
            DataTable dtxm = bll_xm.GetBxgBZ();
            icbo_xm.Properties.Items.Clear();
            icbo_xm.Properties.Items.Add("", "", -1);
            for (int i = 0; i < dtxm.Rows.Count; i++)
            {

                icbo_xm.Properties.Items.Add(dtxm.Rows[i]["C_CRAFT_FLOW"].ToString(), dtxm.Rows[i]["C_COPING_CRAFT"].ToString(), -1);

            }
            icbo_xm.SelectedIndex = 0;
            strMenuName = RV.UI.UserInfo.menuName;
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bll_wl.GetMatral(this.txt_Grd.Text, "1");
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gridView1.OptionsSelection.MultiSelect = true;//允许多选
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            this.gridView1.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gridView1);
            WaitingFrom.CloseWait();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            try
            {
                int a = 1;
                Mod_TPB_BXGXMGZ mod = bll_bxg.GetModel(this.txt_gz.Text, this.txt_dm.Text, Convert.ToDecimal(this.txt_dc.Text), this.icbo_xm.Properties.Items[this.icbo_xm.SelectedIndex].Value.ToString());
                if (mod==null)
                {
                    a = 0;
                    mod = new Mod_TPB_BXGXMGZ();
                }
                mod.C_GZLX = this.icbo_xm.Properties.Items[this.icbo_xm.SelectedIndex].Value.ToString();
                mod.C_REMARK = this.icbo_xm.Properties.Items[this.icbo_xm.SelectedIndex].Description.ToString();
                mod.C_STL_GRD = this.txt_gz.Text;//钢种
                mod.N_JSCN = Convert.ToDecimal(this.txt_jscn.Text);
                mod.N_TOTAL_CN = Convert.ToDecimal(txt_cn.Text);
                mod.C_SLAB_SIZE = this.txt_dm.Text;//断面
                mod.N_LTH = Convert.ToDecimal(this.txt_dc.Text);
                mod.C_IS_BXG ="1";//是否不锈钢
                mod.C_EMP_ID = RV.UI.UserInfo.userID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                if (a==0)
                {
                    bll_bxg.Add(mod);
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加不锈钢修磨规则："+ mod.C_STL_GRD+"~"+ mod.C_SLAB_SIZE + "~" + mod.N_LTH.ToString() + "~" + mod.C_GZLX);//添加操作日志
                    MessageBox.Show("不锈钢修磨规则添加成功！");
                }
                else
                {
                    bll_bxg.Update(mod);
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改不锈钢修磨规则：" + mod.C_STL_GRD + "~" + mod.C_SLAB_SIZE + "~" + mod.N_LTH.ToString() + "~" + mod.C_GZLX);//添加操作日志
                    MessageBox.Show("不锈钢修磨规则修改成功！");
                }
                
                //int[] rownumberCX = this.gridView1.GetSelectedRows();//获取产线选中行号数组；
                //if (rownumberCX.Count() == 0)
                //{
                //    MessageBox.Show("未选中钢种信息！"); return;
                //}
                //int count = rownumberCX.Length;
                //int scount = 0;
                //string str = "";
                //foreach (var item in rownumberCX)
                //{

                //    Mod_TPB_BXGXMGZ mod = new Mod_TPB_BXGXMGZ();
                //    mod.C_GZLX = this.icbo_xm.Properties.Items[this.icbo_xm.SelectedIndex].Value.ToString();
                //    mod.C_REMARK= this.icbo_xm.Properties.Items[this.icbo_xm.SelectedIndex].Description.ToString();
                //    mod.C_STL_GRD = gridView1.GetRowCellValue(item, "C_STL_GRD").ToString();//钢种
                //    mod.N_JSCN = Convert.ToDecimal(txt_cn.Text)/12;
                //    mod.N_TOTAL_CN = Convert.ToDecimal(txt_cn.Text);
                //    mod.C_SLAB_SIZE= gridView1.GetRowCellValue(item, "C_SLAB_SIZE").ToString();//断面
                //    mod.N_LTH = Convert.ToDecimal(gridView1.GetRowCellValue(item, "N_LTH").ToString());
                //    mod.C_IS_BXG= gridView1.GetRowCellValue(item, "C_IS_BXG").ToString();//是否不锈钢
                //    mod.C_EMP_ID = RV.UI.UserInfo.userID;
                //    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                //    #region 检测是否重复添加
                //    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                //    ht.Add("C_STL_GRD", mod.C_STL_GRD);
                //    ht.Add("C_SLAB_SIZE", mod.C_SLAB_SIZE);
                //    ht.Add("N_LTH", mod.N_LTH);
                //    ht.Add("C_GZLX", mod.C_GZLX);
                //    if (Common.CheckRepeat.CheckTable("TPB_BXGXMGZ", ht) > 0)
                //    {
                //        str += mod.C_STL_GRD + ",";
                //    }
                //    else
                //    {
                //        if (bll_bxg.Add(mod) == false)
                //        {
                //            str += mod.C_STL_GRD + ",";
                //        }
                //        else
                //        {
                //            scount++;
                //        }
                //    }
                //    #endregion


                //}
                //if (str.Length > 0)
                //{
                //    MessageBox.Show("共" + count + "条数据，保存成功" + scount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                //}
                //else
                //{
                //    MessageBox.Show("共" + count + "条数据，保存成功" + scount + "条!");

                //}
                btn_Query_Click(null, null);
                btn_QueryGZ_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


          
        }

        private void btn_Stop2_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumberCX = this.gridView2.GetSelectedRows();//获取产线选中行号数组；
                if (rownumberCX.Count() == 0)
                {
                    MessageBox.Show("未选中钢种信息！"); return;
                }
                int count = rownumberCX.Length;
                int scount = 0;
                string str = "";
                foreach (var item in rownumberCX)
                {
                    string id = gridView2.GetRowCellValue(item, "C_ID").ToString();//钢种
                    bll_bxg.Delete(id);
                    scount += 1;
                }
                if (str.Length > 0)
                {
                    MessageBox.Show("共" + count + "条数据，删除成功" + scount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                }
                else
                {
                    MessageBox.Show("共" + count + "条数据，删除成功" + scount + "条");

                }
                btn_Query_Click(null, null);
                btn_QueryGZ_Click(null,null);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_DCKSCGG_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl2,"不锈钢修磨要求");
        }

        private void btn_QueryGZ_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bll_bxg.GetList(" C_STL_GRD like '%"+ this.txt_Grd1.Text + "%'").Tables[0];
            this.gridControl2.DataSource = dt;
            this.gridView2.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gridView2.OptionsSelection.MultiSelect = true;//允许多选
            gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            this.gridView2.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gridView2);
            WaitingFrom.CloseWait();
        }
        private Bll_TB_MATRL_MAIN bllwl = new Bll_TB_MATRL_MAIN();
        private void gridView1_Click(object sender, EventArgs e)
        {
            int selectedHandle = this.gridView1.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle >= 0)
            {
                icbo_xm.SelectedIndex = -1;
                this.txt_cn.Text = "0";
                this.txt_gz.Text = this.gridView1.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();//
                this.txt_dm.Text = this.gridView1.GetRowCellValue(selectedHandle, "C_SLAB_SIZE").ToString();
                this.txt_dc.Text = this.gridView1.GetRowCellValue(selectedHandle, "N_LTH").ToString();

               
                DataTable dt = bllwl.GetWL(this.txt_gz.Text, this.txt_dm.Text, this.txt_dc.Text);
                if (dt.Rows.Count>0)
                {
                    txt_dz.Text = dt.Rows[0]["N_HSL"].ToString();//单重
                }
                else
                {
                    txt_dz.Text = "1.5";//单重
                }
                this.txt_jscn.Text =Math.Round (Convert.ToDecimal(this.txt_cn.Text) * Convert.ToDecimal(txt_dz.Text) / 12,2).ToString();
            }
           
        }

        private void txt_cn_EditValueChanged(object sender, EventArgs e)
        {
            if (this.txt_cn.Text.Trim()!=""&& this.txt_dz.Text.Trim() != "")
            {
                this.txt_jscn.Text = Math.Round(Convert.ToDecimal(this.txt_cn.Text) * Convert.ToDecimal(txt_dz.Text) / 12, 2).ToString();
            }
            else
            {
                this.txt_jscn.Text = "0";
            }
           
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            int selectedHandle = this.gridView2.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle >= 0)
            {
                this.txt_cn.Text = "0";
                this.txt_gz.Text = this.gridView2.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();//
                this.txt_dm.Text = this.gridView2.GetRowCellValue(selectedHandle, "C_SLAB_SIZE").ToString();
                this.txt_dc.Text = this.gridView2.GetRowCellValue(selectedHandle, "N_LTH").ToString();

                DataTable dt = bllwl.GetWL(this.txt_gz.Text, this.txt_dm.Text, this.txt_dc.Text);
                if (dt.Rows.Count > 0)
                {
                    txt_dz.Text = dt.Rows[0]["N_HSL"].ToString();//单重
                }
                else
                {
                    txt_dz.Text = "1.5";//单重
                }
                this.txt_cn.Text= this.gridView2.GetRowCellValue(selectedHandle, "N_TOTAL_CN").ToString(); 
               // this.txt_jscn.Text = Math.Round(Convert.ToDecimal(this.txt_cn.Text) * Convert.ToDecimal(txt_dz.Text) / 12, 2).ToString();
                for (int i = 0; i < icbo_xm.Properties.Items.Count; i++)
                {
                    if (this.gridView2.GetRowCellValue(selectedHandle, "C_GZLX").ToString()== icbo_xm.Properties.Items[i].Value.ToString())
                    {
                        icbo_xm.SelectedIndex = i;
                    }
                }
                
            }
        }
    }
}
