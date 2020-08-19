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


namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_PCDQ : Form
    {
        public FrmPO_PCDQ()
        {
            InitializeComponent();
        }
        private Bll_TPP_PROD_INITIALIZE bll_TPP_PROD_INITIALIZE = new Bll_TPP_PROD_INITIALIZE();
        private Bll_TPP_INITIALIZE_ITEM bll_Item = new Bll_TPP_INITIALIZE_ITEM();
        private void FrmPO_PCDQ_Load(object sender, EventArgs e)
        {
            BindYearMonth(3);
        }
        /// <summary>
        /// 从当月开始加载年月
        /// </summary>
        /// <param name="MonNum">加载月数</param>
        public void BindYearMonth(int MonNum)
        {
            cbo_yyyyMM.Properties.Items.Clear();
            for (int i = 0; i < MonNum; i++)
            {
                cbo_yyyyMM.Properties.Items.Add(System.DateTime.Now.AddMonths(i).ToString("yyyy-MM"));
            }
        }
        /// <summary>
        /// 根据年月加载档期信息
        /// </summary>
        /// <param name="YM">选择的年月</param>
        /// <param name="type">类型</param>
        public void BindDQ(string YM,string type)
        {
            DataTable dt = bll_TPP_PROD_INITIALIZE.GetListByYM(YM,type);
            this.gc_dq.DataSource = dt;
            this.gv_dq.OptionsView.ColumnAutoWidth = false;
          
            this.gv_dq.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_dq);
        }

        private void cbo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_yyyyMM.SelectedIndex<0)
            {
                MessageBox.Show("请选择排产档期的年月！");
                return;
            }
            if (this.cbo_type.Text=="月排产")
            {
                txt_QS.Text = cbo_yyyyMM.SelectedText;//月排产档期号
                DateTime dt1 =new DateTime(Convert.ToDateTime((cbo_yyyyMM.SelectedText+"-01")).Year, Convert.ToDateTime((cbo_yyyyMM.SelectedText + "-01")).Month,1);//当前月第一天
                DateTime dt2 = dt1.AddMonths(1).AddDays(-1);//当前月份最后一天

                this.dtp_from.Text = dt1.ToString("yyyy-MM-dd");
                this.dtp_end.Text = dt2.ToString("yyyy-MM-dd");

            }
            if (this.cbo_type.Text == "旬排产")
            {
                //获取当月最大排产期号
                int num = bll_TPP_PROD_INITIALIZE.GetTheMonthNum(cbo_yyyyMM.SelectedText, this.cbo_type.Text);
                if (num == 3)
                {
                    num = 2;
                }
                txt_QS.Text = cbo_yyyyMM.SelectedText + "-"+ (num + 1).ToString();//旬排产档期号
               
                int dayNum = num * 10;
                DateTime dt1 = new DateTime(Convert.ToDateTime((cbo_yyyyMM.SelectedText + "-01")).Year, Convert.ToDateTime((cbo_yyyyMM.SelectedText + "-01")).Month, 1);//当前月第一天

                this.dtp_from.Text = dt1.AddDays(dayNum).ToString("yyyy-MM-dd");
                if (num==2)
                {
                    this.dtp_end.Text = dt1.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
                }
                else
                {
                    this.dtp_end.Text = dt1.AddDays(dayNum+9).ToString("yyyy-MM-dd");
                }
              


            }
        }

        /// <summary>
        /// 添加排产档期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_dq_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认保存当前编辑的档期内容？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            if (txt_QS.Text=="")
            {
                MessageBox.Show("未选中期数！");
                return;
            }
            int num = bll_TPP_PROD_INITIALIZE.GetTheMonthNum(cbo_yyyyMM.SelectedText, this.cbo_type.Text);
            if (this.cbo_type.SelectedText=="月排产")
            {
                if (num>0)
                {
                    MessageBox.Show("月排产档期已添加！");
                    return;
                }
            }
            if (this.cbo_type.SelectedText == "旬排产")
            {
                if (num >=3)
                {
                    MessageBox.Show("本月旬排产档期已添加完毕！");
                    return;
                }
            }

            Mod_TPP_PROD_INITIALIZE model = new Mod_TPP_PROD_INITIALIZE();
            model.C_YM = this.cbo_yyyyMM.SelectedText;
            model.C_TYPE = this.cbo_type.SelectedText;
            model.C_ISSUE = this.txt_QS.Text;
            model.C_EMP_ID = RV.UI.UserInfo.userName;
            model.D_START_TIME =Convert.ToDateTime( this.dtp_from.Text);
            model.D_END_TIME= Convert.ToDateTime(this.dtp_end.Text);
            bool a = bll_TPP_PROD_INITIALIZE.Add(model);
            BindDQ(this.cbo_yyyyMM.Text.Trim(),this.cbo_type.Text.Trim());
            cbo_type_SelectedIndexChanged(null,null);

        }

        private void btn_query_dq_Click(object sender, EventArgs e)
        {
            BindDQ(this.cbo_yyyyMM.Text.Trim(), this.cbo_type.Text.Trim());
        }

        /// <summary>
        /// 获取档期列表焦点行变化
        /// </summary>
        public void GetFocusDQ()
        {
            int selectedHandle = this.gv_dq.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                groupControl2.Text = "工位维护";
                return;
            }
            this.txt_DQ.Text = this.gv_dq.GetRowCellValue(selectedHandle, "C_ISSUE").ToString();//获取焦点行档期号
            //根据档期号加载方案信息
            BindInfoByDQ(this.txt_DQ.Text);
            GetNewFAH(this.txt_DQ.Text);

        }
       

        /// <summary>
        /// 根据档期号加载方案信息
        /// </summary>
        /// <param name="DQ">档期号</param>
        public void BindInfoByDQ(String DQ)
        {
            DataTable dt = bll_Item.GetList(null, DQ, "").Tables[0];
            this.gc_fa.DataSource = dt;
            this.gv_fa.OptionsView.ColumnAutoWidth = false;
            this.gv_fa.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_fa);
        }

       
        /// <summary>
        /// 添加方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_fa_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认添加当前编辑的方案内容？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            if (this.txt_fah.Text.Trim()=="")
            {
                MessageBox.Show("方案编号不能为空！");
                txt_fah.Focus();
                return;
            }
            if (this.cbo_fa_mb.Text.Trim()=="")
            {
                MessageBox.Show("排产方案目标不能为空！");
                this.cbo_fa_mb.Focus();
                return;
            }

            Mod_TPP_INITIALIZE_ITEM model = new Mod_TPP_INITIALIZE_ITEM();
            model.C_ISSUE = this.txt_DQ.Text;
            model.C_ITEM_NAME = this.txt_fah.Text;
            model.C_GOAL = this.cbo_fa_mb.Text;
            model.C_REMARK = this.txt_bz.Text;
            model.C_EMP_ID = RV.UI.UserInfo.userName;
            bool res = bll_Item.Add(model);
            BindInfoByDQ(this.txt_DQ.Text);
            GetNewFAH(this.txt_DQ.Text);
        }

        /// <summary>
        /// 删除方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_del_fa_Click(object sender, EventArgs e)
        {
            if (gv_fa.FocusedRowHandle<0)
            {
                MessageBox.Show("没有选中要删除的行！");
                return;
            }
            if (DialogResult.No == MessageBox.Show("是否确认删除第"+ (gv_fa.FocusedRowHandle +1).ToString()+ "行内容？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            string strID = this.gv_fa.GetRowCellValue(gv_fa.FocusedRowHandle, "C_ID").ToString();//获取焦点行主键号
            Mod_TPP_INITIALIZE_ITEM model = bll_Item.GetModel(strID);
            model.N_STATUS = -2;
            model.D_END_TIME = System.DateTime.Now;
            model.C_EMP_ID = RV.UI.UserInfo.userName;
            bool res = bll_Item.Update(model);

            BindInfoByDQ(this.txt_DQ.Text);
            GetNewFAH(this.txt_DQ.Text);
        }

        /// <summary>
        /// 根据档期号获取最新方案号
        /// </summary>
        /// <param name="ISSUE">档期号</param>
        /// <returns></returns>
        public void GetNewFAH(string ISSUE)
        {
            this.txt_fah.Text= bll_Item.GetNewItemNameByIssue(ISSUE);
        }

        /// <summary>
        /// 单击档期列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_dq_Click(object sender, EventArgs e)
        {
            GetFocusDQ();
        }
        /// <summary>
        /// 档期列表焦点行变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_dq_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            GetFocusDQ();
        }
    }
}
