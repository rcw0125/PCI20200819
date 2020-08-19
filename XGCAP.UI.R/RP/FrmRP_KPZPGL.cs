using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.RP
{
    public partial class FrmRP_KPZPGL : Form
    {
        public FrmRP_KPZPGL()
        {
            InitializeComponent();
        }

        Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();

        private void btn_AssePlanQuery_Click(object sender, EventArgs e)
        {
            Query1();
        }

        /// <summary>
        /// 组批查询
        /// </summary>
        private void Query1()
        {
            if (string.IsNullOrWhiteSpace(txt_BranchNo.Text))
            {
                MessageBox.Show("批次号不能为空！");
                return;
            }
            this.gc_KPZPSJ.DataSource = null;
            string whereSql = " AND TRM.C_BATCH_NO='" + txt_BranchNo.Text + "' ";
            DataTable dt = bll_TRC_COGDOWN_MAIN.GetListMain(whereSql, false).Tables[0];
            this.gc_KPZPSJ.DataSource = dt;
            this.gv_KPZPSJ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_KPZPSJ);
            Query2();
        }

        private void Query2()
        {
            this.gc_KDZGZ.DataSource = null;
            int selectedPlanHandle = this.gv_KPZPSJ.FocusedRowHandle;//获取计划焦点行索引
            string stove = this.gv_KPZPSJ.GetRowCellValue(selectedPlanHandle, "C_STOVE") == null ? "" : this.gv_KPZPSJ.GetRowCellValue(selectedPlanHandle, "C_STOVE").ToString();//获取焦点主键
            DataTable dt = bll_TRC_COGDOWN_MAIN.GetStl(stove).Tables[0];
            this.gc_KDZGZ.DataSource = dt;
            this.gv_KDZGZ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_KDZGZ);
        }

        private void gv_KPZPSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr2 = gv_KPZPSJ.GetDataRow(gv_KPZPSJ.FocusedRowHandle);
                if (dr2 != null)
                {
                    string id = dr2["C_ID"].ToString();
                    var countDt = bll_TRC_COGDOWN_MAIN.GetCogdownMainItem(id);
                    if (countDt.Rows.Count > 0)
                        txt_Elim.Text = countDt.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_KPZPSJ_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr2 = gv_KPZPSJ.GetDataRow(gv_KPZPSJ.FocusedRowHandle);
                if (dr2 != null)
                {
                    string id = dr2["C_ID"].ToString();
                    var countDt = bll_TRC_COGDOWN_MAIN.GetCogdownMainItem(id);
                    if (countDt.Rows.Count > 0)
                        txt_Elim.Text = countDt.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmRP_KPZPGL_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }

        private void gv_KDZGZ_RowCountChanged(object sender, EventArgs e)
        {

        }

        private void gv_KDZGZ_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_KDZGZ.GetDataRow(gv_KDZGZ.FocusedRowHandle);
                if (dr != null)
                {
                    txt_AsseNum.Text = dr["N_QUA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_KDZGZ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_KDZGZ.GetDataRow(gv_KDZGZ.FocusedRowHandle);
                if (dr != null)
                {
                    txt_AsseNum.Text = dr["N_QUA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否补单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_KPZPSJ.FocusedRowHandle;//获取组坯计划焦点行索引
            string planID = this.gv_KPZPSJ.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点组坯主键

            int selectedHandle = this.gv_KDZGZ.FocusedRowHandle;//获取焦点行索引
            int allowGrdNum = Convert.ToInt32(this.gv_KDZGZ.GetRowCellValue(selectedHandle, "N_QUA"));//可轧钢种支数
            string stove = this.gv_KDZGZ.GetRowCellValue(selectedHandle, "C_STOVE") == null ? "" : this.gv_KDZGZ.GetRowCellValue(selectedHandle, "C_STOVE").ToString();//可轧钢种支数

            if (selectedHandle < 0)
            {
                MessageBox.Show("记录为空!");
                return;
            }

            int errorNum = 0;//TryParse 输出参数
            string asseNum = txt_AsseNum.Text.Trim();
            if (!Int32.TryParse(asseNum, out errorNum) || int.Parse(asseNum) == 0)
            {
                MessageBox.Show("补批支数只能是整数!");
                return;
            }

            if (int.Parse(asseNum) > allowGrdNum)
            {
                MessageBox.Show("补批支数不能大于钢坯库存支数!");
                return;
            }

            var dt = bll_TRC_COGDOWN_MAIN.GetStlIds(stove).Tables[0];

            string result = bll_TRC_COGDOWN_MAIN.SupplementSlab(planID, dt);

            if (result == "1")
            {
                MessageBox.Show("操作成功");
                Query1();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否剔除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_KPZPSJ.FocusedRowHandle;//获取组坯计划焦点行索引
            string planID = this.gv_KPZPSJ.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点组坯主键
            int errorNum = 0;//TryParse 输出参数
            string asseNum = txt_Elim.Text.Trim();
            if (!Int32.TryParse(asseNum, out errorNum) || int.Parse(asseNum) == 0)
            {
                MessageBox.Show("补批支数只能是整数!");
                return;
            }

            var dt = bll_TRC_COGDOWN_MAIN.GetCogdownMainItem(planID);

            if (int.Parse(asseNum) > dt.Rows.Count)
            {
                MessageBox.Show("剔除支数不能大于组坯支数!");
                return;
            }

            string result = bll_TRC_COGDOWN_MAIN.ElimSlab(planID, int.Parse(asseNum));
            if (result == "1")
            {
                MessageBox.Show("操作成功");
                Query1();
            }
            else
            {
                MessageBox.Show("操作失败");
            }

        }
    }
}
