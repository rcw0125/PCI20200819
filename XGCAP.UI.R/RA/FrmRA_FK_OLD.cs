using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.RA
{
    public partial class FrmRA_FK_OLD : Form
    {
        string staID = "";//工位ID

        public FrmRA_FK_OLD()
        {
            InitializeComponent();
            staID = bll_TB_STA.GetStaIdByCode(RV.UI.QueryString.parameter);
        }

        Bll_TSC_SLAB_MAIN bll = new Bll_TSC_SLAB_MAIN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRA_FK_OLD_Load(object sender, EventArgs e)
        {
            BindAllotBillet();
            BindStore();
            BindAllotCanterBillet();
        }

        /// <summary>
        /// 绑定可调拨钢坯数据
        /// </summary>
        public void BindAllotBillet()
        {
            DataTable dt = bll.GetAllotData(staID).Tables[0];
            this.gc_Allot.DataSource = dt;
            this.gv_Allot.OptionsView.ColumnAutoWidth = false;
            this.gv_Allot.BestFitColumns();
        }

        /// <summary>
        /// 绑定可调拨钢坯数据
        /// </summary>
        public void BindAllotCanterBillet()
        {
            DataTable dt = bll.GetAllotData(staID, 1).Tables[0];
            this.gc_AllotCenter.DataSource = dt;
            this.gv_AllotCenter.OptionsView.ColumnAutoWidth = false;
            this.gv_AllotCenter.BestFitColumns();
        }

        /// <summary>
        /// 绑定仓库
        /// </summary>
        public void BindStore()
        {
            DataTable dt = bll_TPB_SLABWH.GetSlabwh().Tables[0];
            image_Store.Properties.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                image_Store.Properties.Items.Add(item["C_SLABWH_CODE"].ToString() + item["C_SLABWH_NAME"].ToString(), item["C_SLABWH_CODE"], -1);
            }
        }

        private void gv_Allot_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Allot.GetDataRow(gv_Allot.FocusedRowHandle);
                if (dr != null)
                {
                    txt_AllotNum.Text = dr["N_QUA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 分库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SeparateStore_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("确认分库吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedPlanHandle = this.gv_Allot.FocusedRowHandle;//获取计划焦点行索引
                int selectedAllowGrd = this.gv_Allot.FocusedRowHandle;//获取可轧钢种焦点行索引
                if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
                {
                    MessageBox.Show("请检调拨钢种，记录为空!");
                    return;
                }

                if (this.image_Store.Text == null || this.image_Store.Text == "")
                {
                    MessageBox.Show("请选择仓库!");
                    return;
                }

                string stove = this.gv_Allot.GetRowCellValue(selectedPlanHandle, "C_STOVE").ToString();//获取焦点炉号
                string num = this.gv_Allot.GetRowCellValue(selectedPlanHandle, "N_QUA").ToString();//获取焦点调拨支数            
                string grd = this.gv_Allot.GetRowCellValue(selectedPlanHandle, "C_STL_GRD").ToString();//获取焦点钢种
                string std = this.gv_Allot.GetRowCellValue(selectedPlanHandle, "C_STD_CODE").ToString();//获取焦点执行标准
                string spec = this.gv_Allot.GetRowCellValue(selectedPlanHandle, "C_SPEC").ToString();//获取焦点规格
                string matCode = this.gv_Allot.GetRowCellValue(selectedPlanHandle, "C_MAT_CODE").ToString();//获取焦点物料编码
                string store = this.image_Store.EditValue.ToString();//仓库
                string shift = this.cbo_Shift.EditValue.ToString();//班次
                string group = this.cbo_Group.EditValue.ToString();//班组

                int errorNum = 0;//TryParse 输出参数
                string allotNum = txt_AllotNum.Text.Trim();
                if (!Int32.TryParse(allotNum, out errorNum))
                {
                    MessageBox.Show("调拨支数只能是整数!");
                    return;
                }

                if (Convert.ToInt32(allotNum) > Convert.ToInt32(num))
                {
                    MessageBox.Show("调拨支数不能超过可调拨钢坯总数!");
                    return;
                }
                else
                    num = allotNum;


                string result = bll.AllotHandler(staID, stove, grd, spec, std, matCode, Convert.ToInt32(num), store, shift, group);
                if (result == "1")
                {
                    BindAllotBillet();
                    BindStore();
                    BindAllotCanterBillet();
                    MessageBox.Show("操作成功!");
                }
                else
                {
                    MessageBox.Show("操作失败!");
                }

            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// 撤回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BackOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("确认撤回分库吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedPlanHandle = this.gv_AllotCenter.FocusedRowHandle;//获取计划焦点行索引
                int selectedAllowGrd = this.gv_AllotCenter.FocusedRowHandle;//获取可轧钢种焦点行索引
                if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
                {
                    MessageBox.Show("请检调拨中钢种，记录为空!");
                    return;
                }

                string stove = this.gv_AllotCenter.GetRowCellValue(selectedPlanHandle, "C_STOVE").ToString();//获取焦点炉号
                string num = this.gv_AllotCenter.GetRowCellValue(selectedPlanHandle, "N_QUA").ToString();//获取焦点调拨支数            
                string grd = this.gv_AllotCenter.GetRowCellValue(selectedPlanHandle, "C_STL_GRD").ToString();//获取焦点钢种
                string std = this.gv_AllotCenter.GetRowCellValue(selectedPlanHandle, "C_STD_CODE").ToString();//获取焦点执行标准
                string spec = this.gv_AllotCenter.GetRowCellValue(selectedPlanHandle, "C_SPEC").ToString();//获取焦点规格
                string matCode = this.gv_AllotCenter.GetRowCellValue(selectedPlanHandle, "C_MAT_CODE").ToString();//获取焦点规格

                string result = bll.BackAllotHandler(staID, stove, grd, spec, std, matCode, Convert.ToInt32(num));
                if (result == "1")
                {
                    BindAllotBillet();
                    BindStore();
                    BindAllotCanterBillet();
                    MessageBox.Show("操作成功!");
                }
                else
                {
                    MessageBox.Show("操作失败!");
                }
            }
            catch (Exception ex) { }

        }

        private void txt_AllotNum_Leave(object sender, EventArgs e)
        {
            DataRow dr = gv_Allot.GetDataRow(gv_Allot.FocusedRowHandle);
            if (dr != null)
            {
                if (Convert.ToInt32(this.txt_AllotNum.Text) > Convert.ToInt32(dr["N_QUA"]))
                {
                    this.txt_AllotNum.Text = (Convert.ToInt32(dr["N_QUA"])).ToString();
                }
            }
        }

        private void btn_AssePlanQuery_Click(object sender, EventArgs e)
        {
            BindAllotBillet();
            BindAllotCanterBillet();
        }
    }
}
