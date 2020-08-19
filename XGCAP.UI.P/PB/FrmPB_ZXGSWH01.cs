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
    public partial class FrmPB_ZXGSWH01 : Form
    {
         string strQueryString = ""; //参数
        public FrmPB_ZXGSWH01()
        {
            InitializeComponent();

             strQueryString =  RV.UI.QueryString.parameter;//页面参数
        }
        Bll_TPB_STA_HOOK_NUM bll_TPB_STA_HOOK_NUM = new Bll_TPB_STA_HOOK_NUM();
        Bll_TPB_STA_HOOK_NO bll_TPB_STA_HOOK_NO = new Bll_TPB_STA_HOOK_NO();
        
        CommonSub sub = new CommonSub();

        private string strMenuName;


        private void FrmPB_ZXGSWH_Load(object sender, EventArgs e)
        {
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;

                cbo_GW1.EditValue = "";
                sub.ImageComboBoxEditBindGWByGX("ZG", cbo_GW1);
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_SaveDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认保存产线钩号信息？", "提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                if (cbo_GW1.EditValue.ToString() == "")
                {
                    MessageBox.Show("请选择产线！");
                    this.txt_PGH.Focus();
                    return;
                }
                if (txt_PGH.Text == "")
                {
                    MessageBox.Show("请输入钩数");
                    this.txt_PGH.Focus();
                    return;
                }
                if (this.txt_Online_Num.Text == "")
                {
                    MessageBox.Show("请输入在线钩数");
                    this.txt_PGH.Focus();
                    return;
                }
                if (this.lbl_ID.Text.Trim() == "")//新增
                {
                    Mod_TPB_STA_HOOK_NUM model = new Mod_TPB_STA_HOOK_NUM();
                    model.C_STA_ID = cbo_GW1.EditValue.ToString();
                    model.N_HOOK_NUM = Convert.ToInt32(txt_PGH.Text);
                    model.N_ONLINE_NUM = Convert.ToInt32(this.txt_Online_Num.Text);
                    model.C_REMARK = txt_BZ.Text;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    try
                    {
                        if (bll_TPB_STA_HOOK_NUM.Add(model))
                        {
                            for (int i = 1; i < model.N_ONLINE_NUM + 1; i++)
                            {
                                Mod_TPB_STA_HOOK_NO mod_TPB_STA_HOOK_NO = new Mod_TPB_STA_HOOK_NO();//产线在线顺序表
                                mod_TPB_STA_HOOK_NO.C_EMP_ID = RV.UI.UserInfo.userID;
                                mod_TPB_STA_HOOK_NO.C_STA_ID = model.C_STA_ID;
                                mod_TPB_STA_HOOK_NO.N_NO = i;
                                mod_TPB_STA_HOOK_NO.C_HOOK_NAME = i.ToString();
                                bll_TPB_STA_HOOK_NO.Add(mod_TPB_STA_HOOK_NO);
                            }

                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧线钩数信息");//添加操作日志

                            MessageBox.Show("保存成功！");
                            Query();//重新加载仓库信息
                            
                        }
                    }
                    catch (Exception)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧线钩数信息--添加失败！");//添加操作日志
                        MessageBox.Show("保存失败！");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        Mod_TPB_STA_HOOK_NUM model = bll_TPB_STA_HOOK_NUM.GetModel(this.lbl_ID.Text.Trim());
                        model.C_STA_ID = cbo_GW1.EditValue.ToString();
                        model.N_HOOK_NUM = Convert.ToInt32(txt_PGH.Text);
                        model.N_ONLINE_NUM = Convert.ToInt32(this.txt_Online_Num.Text);
                        model.C_REMARK = txt_BZ.Text;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        bll_TPB_STA_HOOK_NUM.Update(model);
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧线钩数信息");//添加操作日志
                        MessageBox.Show("保存成功！");
                        Query();//重新加载仓库信息
                    }
                    catch (Exception)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧线钩数信息--保存失败！");//添加操作日志

                        MessageBox.Show("保存失败！");
                        return;
                    }
                   
                }

                btn_Reset_Click(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        /// <summary>
        /// 获取工序列表焦点行信息
        /// </summary>
        public void BindFocusedRowGX()
        {
            int selectedHandle = this.gv_CXGS.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                return;
            }
            this.lbl_ID.Text = this.gv_CXGS.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到工序对象，并在界面赋值
            Mod_TPB_STA_HOOK_NUM model = bll_TPB_STA_HOOK_NUM.GetModel(this.lbl_ID.Text);
            for (int i = 0; i < this.cbo_GW1.Properties.Items.Count; i++)
            {
                if (this.cbo_GW1.Properties.Items[i].Value.ToString() == model.C_STA_ID)
                {
                    this.cbo_GW1.SelectedIndex = i;
                }
            }
            this.txt_PGH.Text = model.N_HOOK_NUM.ToString();
            this.txt_Online_Num.Text = model.N_ONLINE_NUM.ToString();
            this.txt_BZ.Text = model.C_REMARK;



        }


        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearPanelControl(panelControl1.Controls);
                lbl_ID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用选中的数据？", "提示"))
                {
                    return;
                }

                int selectedNum = this.gv_CXGS.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_CXGS.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_CXGS.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    Mod_TPB_STA_HOOK_NUM model = bll_TPB_STA_HOOK_NUM.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.D_END_DATE = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_STA_HOOK_NUM.Update(model);
                    if (update)
                    {
                        commitNum = commitNum + 1;
                    }
                    else
                    {
                        failtNum = failtNum + 1;
                    }
                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，停用" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用轧线钩数信息");//添加操作日志

                Query();//重新加载仓库信息
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 查询
        /// </summary>
        private void Query()
        {
            DataTable dt = null;
            string cx = "";/* this.cbo_GW1.Properties.Items[this.cbo_GW1.SelectedIndex].Value.ToString();*/
           
            dt = bll_TPB_STA_HOOK_NUM.GetListByStatus(1, cx).Tables[0];

            this.gc_CXGS.DataSource = dt;
            this.gv_CXGS.OptionsView.ColumnAutoWidth = false;
            this.gv_CXGS.OptionsSelection.MultiSelect = true;
            //gv_CXGS.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_CXGS.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_CXGS);
        }

        private void gv_CXGS_Click(object sender, EventArgs e)
        {
            BindFocusedRowGX();
        }
    }
}
