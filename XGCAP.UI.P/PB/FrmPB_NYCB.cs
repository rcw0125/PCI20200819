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
    public partial class FrmPB_NYCB : Form
    {
        public FrmPB_NYCB()
        {
            InitializeComponent();
        }
        private string strMenuName;
        CommonSub sub = new CommonSub();
        Bll_TB_MATERIAL_COST bll = new BLL.Bll_TB_MATERIAL_COST();
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPB_NYCB_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (DialogResult.No == MessageBox.Show("是否确认添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    if (txt_NYJZ1.Text == "")
                    {
                        MessageBox.Show("请输入能源介质！");
                        return;
                    }
                    if (txt_DJ.Text == "")
                    {
                        MessageBox.Show("请输入单价！");
                        return;
                    }
                    if (txt_DW.Text == "")
                    {
                        MessageBox.Show("请输入单位！");
                        return;
                    }
                    if (bll.ExistsByNYJZ(txt_NYJZ1.Text.Trim()))
                    {
                        MessageBox.Show("已经存在该介质！");
                        return;
                    }
                    else
                    {
                        MODEL.Mod_TB_MATERIAL_COST mod = new MODEL.Mod_TB_MATERIAL_COST
                        {
                            C_MATERIAL_NAME = txt_NYJZ1.Text,
                            C_UNIT = txt_DW.Text,
                            N_COST = Convert.ToDecimal(txt_DJ.Text),
                            C_REMARK = txt_BZ.Text,
                            C_EMP_ID = RV.UI.UserInfo.userID
                        };
                        bll.Add(mod);

                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加能源介质成本信息");//添加操作日志

                        NewMethod();

                    }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                if (true)
                {

                }
                int[] rows = this.gv_NYCB.GetSelectedRows();
                if (rows.Count()==0)
                {
                    return;
                }
                foreach (var item in rows)
                {
                    DataRow dr = this.gv_NYCB.GetDataRow(item);
                    Mod_TB_MATERIAL_COST mod = bll.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    mod.D_END_DATE = DateTime.Now;
                    bll.Update(mod);
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除能源介质成本信息");//添加操作日志
                }
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="sqlwhere"></param>
        private void NewMethod()
        {
            DataSet ds = bll.GetList("1", txt_NYJZ2.Text);
            this.gc_NYCB.DataSource = ds.Tables[0];
            this.gv_NYCB.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_NYCB.OptionsSelection.MultiSelect = true;//允许多选
            gv_NYCB.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            gv_NYCB.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_NYCB);
            //GetFoucs();
        }


        ///// <summary>
        ///// 重置
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btn_Reset_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}

        //private void gv_NYCB_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        GetFoucs();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
        //public void GetFoucs()
        //{
        //    int selectedHandle = this.gv_NYCB.FocusedRowHandle;//获取焦点行索引
        //    if (selectedHandle < 0)
        //    {
        //        ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
        //        lbl_id.Text = "";
        //        return;
        //    }
        //    this.lbl_id.Text = this.gv_NYCB.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键                     
        //    Mod_TB_MATERIAL_COST mod = bll.GetModel(lbl_id.Text);
        //    txt_NYJZ1.Text = mod.C_MATERIAL_NAME;
        //    txt_DJ.Text = mod.N_COST.ToString();
        //    txt_DW.Text = mod.C_UNIT;
        //    txt_BZ.Text = mod.C_REMARK;
        //}

        //private void lbl_id_TextChanged(object sender, EventArgs e)
        //{
        //    if (lbl_id.Text != "")
        //    {
        //        txt_NYJZ1.Enabled = false;
        //    }
        //    else
        //    {
        //        txt_NYJZ1.Enabled = true;
        //    }
        //}

    
        private void btn_UpdateGW_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_NYCB.GetDataRow(this.gv_NYCB.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_NYKZCB_EDIT frm = new FrmPB_NYKZCB_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    NewMethod();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DCNYCB_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_NYCB);
        }

        //private void rbtn_isty_gx_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (rbtn_isty_gx.SelectedIndex==0)
        //    {
        //        btn_Stop.Enabled = true;
        //        btn_UpdateGW.Enabled = true;
        //    }
        //    else
        //    {
        //        btn_Stop.Enabled = false;
        //        btn_UpdateGW.Enabled = false;
        //    }
        //}
    }
}
