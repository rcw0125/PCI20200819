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
using DevExpress.XtraEditors;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    /// <summary>
    /// 2018-4-19 zmc
    /// </summary>
    public partial class FrmQB_JCSJ : Form
    {
        public FrmQB_JCSJ()
        {
            InitializeComponent();
        }
        Bll_TQB_CHECKTYPE type_bll = new Bll_TQB_CHECKTYPE();
        Bll_TQB_CHARACTER bll = new Bll_TQB_CHARACTER();
        Bll_TQB_STD_CFXN bll_cfxn = new Bll_TQB_STD_CFXN();

        private string strMenuName;
        string max = "";
        string max_order = "";
        private void FrmQB0103_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                DataSet dt = type_bll.GetList("");
                imgcbo_Type.Properties.Items.Clear();
                imgcbo_Type1.Properties.Items.Clear();
                imgcbo_Type1.Properties.Items.Add("全部", "全部", -1);
                foreach (DataRow item in dt.Tables[0].Rows)
                {
                    imgcbo_Type.Properties.Items.Add(item["C_TYPE_NAME"].ToString(), item["C_ID"], -1);
                    imgcbo_Type1.Properties.Items.Add(item["C_TYPE_NAME"].ToString(), item["C_ID"], -1);
                }

                imgcbo_Type1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }


        }

        private void NewMethod()
        {
            WaitingFrom.ShowWait("");
            DataTable dt_max = bll.GetList_Max().Tables[0];
            max = dt_max.Rows[0]["max"].ToString();
            max_order = dt_max.Rows[0]["max_order"].ToString();
            gc_JCSJ.DataSource = null;
            string type = imgcbo_Type1.EditValue?.ToString();
            DataTable dt = bll.GetList(txt_name1.Text, type).Tables[0];

            this.gc_JCSJ.DataSource = dt;
            gv_JCSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_JCSJ);
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (imgcbo_Type.SelectedIndex == -1)
            {
                MessageBox.Show("检测类别不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
            {
                MessageBox.Show("项目名称不能为空！");
                return;
            } 
            try
            {
                Mod_TQB_CHARACTER mod_add = new Mod_TQB_CHARACTER();

                mod_add.C_TYPE_ID = imgcbo_Type.EditValue.ToString();
                mod_add.C_NAME = txt_Name.Text.Trim();
                mod_add.C_UNIT = txt_Unit.Text.Trim();
                mod_add.C_BOOK_SHOW = txt_Book_Show.Text.Trim();
                mod_add.C_FORMULA = txt_Formula.Text.Trim();
                mod_add.C_QUANTITATIVE = imgcbo_Quantitative.Text;
                mod_add.C_DIGIT = txt_XSWS.Text.Trim();
                mod_add.C_REMARK = txt_Remark.Text.Trim();
                mod_add.C_EMP_ID = RV.UI.UserInfo.UserID;
                DataTable dt = bll.GetList_Name(txt_Name.Text.Trim(), imgcbo_Type.Text.Trim()).Tables[0];

                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("N_STATUS", 1);
                ht.Add("C_TYPE_ID", mod_add.C_TYPE_ID);
                ht.Add("C_NAME", mod_add.C_NAME);
                if (Common.CheckRepeat.CheckTable("TQB_CHARACTER", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (string.IsNullOrEmpty(max))
                {
                    max = "10001";
                }
                else
                {
                    max = (Convert.ToInt32(max) + 1).ToString();
                }
                if (string.IsNullOrEmpty(max_order))
                {
                    max_order = "1";
                }
                else
                {
                    max_order = (Convert.ToInt32(max_order) + 1).ToString();
                }
                mod_add.C_CODE = max;
                mod_add.N_ORDER = Convert.ToInt32(max_order);
                bll.Add(mod_add);
                NewMethod();//查询
                MessageBox.Show("添加成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加检验基础数据");//添加操作日志

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            try
            {
                NewMethod1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void NewMethod1()
        {
            ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = this.gv_JCSJ.GetDataRow(this.gv_JCSJ.FocusedRowHandle);
                if (dr==null) return;
                Mod_TQB_CHARACTER mod_ID = bll.GetModel(dr["C_ID"].ToString());
                if (bll_cfxn.GetRecordCount(dr["C_ID"].ToString()) > 0)
                {
                    MessageBox.Show("该数据正在使用，请勿修改！");
                    return;

                }
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    try
                    {

                        Mod_TQB_CHARACTER mod = bll.GetModel(dr["C_ID"].ToString());
                        mod.N_STATUS = 0;
                        bll.Update(mod);
                        NewMethod();
                        MessageBox.Show("已停用！");

                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用检验基础数据信息");//添加操作日志
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else//如果点击“取消”按钮
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_JCSJ.GetDataRow(this.gv_JCSJ.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_JCSJ_EDIT frm = new FrmQB_JCSJ_EDIT();
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
    }
}
