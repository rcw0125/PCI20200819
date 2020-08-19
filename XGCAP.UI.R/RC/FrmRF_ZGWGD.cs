using BLL;
using Common;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
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
    public partial class FrmRF_ZGWGD : Form
    {
        public FrmRF_ZGWGD()
        {
            InitializeComponent();
            //staID = bll_TB_STA.GetStaIdByCode(RV.UI.QueryString.parameter);
        }

        //string staID = "";//轧线工位ID

        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        Bll_TRC_ROLL_WGD_ITEM bll_TRC_ROLL_WGD_ITEM = new Bll_TRC_ROLL_WGD_ITEM();

        int num_wgd = 0;

        private void FrmRF_ZGWGD_Load_1(object sender, EventArgs e)
        {
            BindWgdData();
            BindWgdVData();
            this.dt_ExecStart.DateTime = DateTime.Now;
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }

        /// <summary>
        /// 绑定完工单数据
        /// </summary>
        public void BindWgdData()
        {
            this.gc_WGD.DataSource = null;
            string whereSql = "  N_STATUS=0  ";
            if (!string.IsNullOrWhiteSpace(txt_Stove.Text))
                whereSql += "  AND C_STOVE like '%" + txt_Stove.Text + "%' ";
            //if (!string.IsNullOrWhiteSpace(staID))
            //    whereSql += "  AND C_STA_ID='" + staID + "'";

            DataTable dt = bll_TRC_ROLL_WGD.GetList(whereSql).Tables[0];

            num_wgd = dt.Rows.Count;

            this.gc_WGD.DataSource = dt;
            this.gv_WGD.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_WGD);
        }

        /// <summary>
        /// 绑定完工单数据
        /// </summary>
        public void BindWgdVData()
        {
            string whereSql = "  N_STATUS=1 AND N_SCRF=0 ";
            if (!string.IsNullOrWhiteSpace(txt_Stove.Text))
                whereSql += "  AND C_BATCH_NO like '%" + txt_Stove.Text + "%' ";

            // whereSql += "  AND C_STA_ID='" + staID + "'";

            DataTable dt = bll_TRC_ROLL_WGD.GetList(whereSql).Tables[0];
            this.gc_WGDV.DataSource = dt;
            this.gv_WGDV.OptionsView.ColumnAutoWidth = false;

            gv_WGDV.Columns["C_PCLX"].ColumnEdit = GetCombox_TypeName();

            SetGridViewRowNum.SetRowNum(gv_WGDV);
        }

        /// <summary>
        /// 批次类型
        /// </summary>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetCombox_TypeName()
        {
            var repo = new RepositoryItemImageComboBox();

            var list1 = new ImageComboBoxItem("普通材", "0", -1);
            repo.Items.Add(list1);

            var list2 = new ImageComboBoxItem("出口材", "1", -1);
            repo.Items.Add(list2);

            return repo;
        }

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Confrim_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "确认完工", "确认完工", "确认完工");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认完工吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedHandle = this.gv_WGD.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_WGD.DataSource = null;
                this.gv_WGD.BestFitColumns();
                MessageBox.Show("无记录！");
                return;
            }

            int selectedHandleItem = this.gv_WGDITEM.FocusedRowHandle;//获取焦点行索引
            if (selectedHandleItem < 0)
            {
                this.gc_WGDITEM.DataSource = null;
                this.gv_WGDITEM.BestFitColumns();
                MessageBox.Show("无记录！");
                return;
            }

            //获取焦点行ID
            string id = this.gv_WGD.GetRowCellValue(selectedHandle, "C_ID").ToString();
            //获取焦点行工位
            string staID = this.gv_WGD.GetRowCellValue(selectedHandle, "C_STA_ID").ToString();
            //获取焦点行炉号
            string stove = this.gv_WGD.GetRowCellValue(selectedHandle, "C_STOVE").ToString();
            //获取焦点行批次
            string batchNo = this.gv_WGD.GetRowCellValue(selectedHandle, "C_BATCH_NO").ToString();
            //获取焦点行计划号
            string planID = this.gv_WGD.GetRowCellValue(selectedHandle, "C_PLAN_ID").ToString();
            //获取焦点行钢种
            string grd = this.gv_WGD.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
            //获取焦点行执行标准
            string std = this.gv_WGD.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();
            //获取焦点行规格
            string spec = this.gv_WGD.GetRowCellValue(selectedHandle, "C_SPEC").ToString();
            //获取焦点行包装要求
            string pack = this.gv_WGD.GetRowCellValue(selectedHandle, "C_PACK").ToString();
            //获取焦点行自由项
            string zyx = this.gv_WGD.GetRowCellValue(selectedHandle, "C_FREE_TERM").ToString();
            //获取焦点行自由项2
            string zyx2 = this.gv_WGD.GetRowCellValue(selectedHandle, "C_FREE_TERM2").ToString();
            //获取焦点行物料编码
            string matCode = this.gv_WGD.GetRowCellValue(selectedHandle, "C_MAT_CODE").ToString();
            //获取焦点行物料名称
            string matDesc = this.gv_WGD.GetRowCellValue(selectedHandle, "C_MAT_DESC").ToString();
            //获取焦点批次属性
            string mrsx = this.gv_WGD.GetRowCellValue(selectedHandle, "C_MRSX").ToString();
            //获取焦点批次类型
            string pclx = this.gv_WGD.GetRowCellValue(selectedHandle, "C_PCLX").ToString();
            //获取批次属性
            string newMrsx = cbo_BatchAttr.Text;
            //批次类型
            string newPclx = this.image_Type.EditValue.ToString();
            //属性
            string sx = cbo_Sx.Text;
            //
            string itemID = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_ID").ToString();

            string result = bll_TRC_ROLL_WGD.WgdHandler(id, staID, stove, batchNo, planID, grd, std, spec, pack, zyx, zyx2, mrsx, matCode
                , matDesc, pclx, newMrsx, newPclx, "", "", "", "", "", "", "", "", dt_ExecStart.DateTime, 1, sx, itemID);
            if (result == "1")
            {
                BindWgdData();
                BindWgdVData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                BindWgdData();
                BindWgdVData();
                MessageBox.Show("操作失败!");
            }

        }

        /// <summary>
        /// 改判
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "确认改判", "确认改判", "确认改判");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认改判吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedHandle = this.gv_WGD.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_WGD.DataSource = null;
                this.gv_WGD.BestFitColumns();
                MessageBox.Show("无记录！");
                return;
            }

            int selectedHandleItem = this.gv_WGDITEM.FocusedRowHandle;//获取焦点行索引
            if (selectedHandleItem < 0)
            {
                this.gc_WGDITEM.DataSource = null;
                this.gv_WGDITEM.BestFitColumns();
                MessageBox.Show("无记录！");
                return;
            }

            //获取焦点行ID
            string id = this.gv_WGD.GetRowCellValue(selectedHandle, "C_ID").ToString();
            //获取焦点行工位
            string staID = this.gv_WGD.GetRowCellValue(selectedHandle, "C_STA_ID").ToString();
            //获取焦点行炉号
            string stove = this.gv_WGD.GetRowCellValue(selectedHandle, "C_STOVE").ToString();
            //获取焦点行批次
            string batchNo = this.gv_WGD.GetRowCellValue(selectedHandle, "C_BATCH_NO").ToString();
            //获取焦点行计划号
            string planID = this.gv_WGD.GetRowCellValue(selectedHandle, "C_PLAN_ID").ToString();
            //获取焦点行钢种
            string grd = this.gv_WGD.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
            //获取焦点行执行标准
            string std = this.gv_WGD.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();
            //获取焦点行规格
            string spec = this.gv_WGD.GetRowCellValue(selectedHandle, "C_SPEC").ToString();
            //获取焦点行包装要求
            string pack = this.gv_WGD.GetRowCellValue(selectedHandle, "C_PACK").ToString();
            //获取焦点行自由项
            string zyx = this.gv_WGD.GetRowCellValue(selectedHandle, "C_FREE_TERM").ToString();
            //获取焦点行自由项2
            string zyx2 = this.gv_WGD.GetRowCellValue(selectedHandle, "C_FREE_TERM2").ToString();
            //获取焦点行物料编码
            string matCode = this.gv_WGD.GetRowCellValue(selectedHandle, "C_MAT_CODE").ToString();
            //获取焦点行物料名称
            string matDesc = this.gv_WGD.GetRowCellValue(selectedHandle, "C_MAT_DESC").ToString();
            //获取焦点批次属性
            string mrsx = this.gv_WGD.GetRowCellValue(selectedHandle, "C_MRSX").ToString();
            //获取焦点批次类型
            string pclx = this.gv_WGD.GetRowCellValue(selectedHandle, "C_PCLX").ToString();
            //获取批次属性
            string newMrsx = cbo_BatchAttr.Text;
            //批次类型
            string newPclx = this.image_Type.EditValue.ToString();

            //完工执行标准
            string itemID = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_ID").ToString();
            //完工执行标准
            string newStd = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_STD_CODE").ToString();
            //完工钢种
            string newGrd = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_STL_GRD").ToString();
            //完工规格
            string newSpec = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_SPEC").ToString();
            //完工物料编码
            string newMatCode = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_MAT_CODE").ToString();
            //完工物料名称
            string newMatDesc = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_MAT_DESC").ToString();
            //完工自由项
            string newZyx = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_ZYX1").ToString();
            //完工自由项2
            string newZyx2 = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_ZYX2").ToString();
            //完工包装标准
            string newPack = this.gv_WGDITEM.GetRowCellValue(selectedHandleItem, "C_BZYQ").ToString();
            //属性
            string sx = cbo_Sx.Text;
            string result = bll_TRC_ROLL_WGD.WgdHandler(id, staID, stove, batchNo, planID, grd, std, spec, pack, zyx, zyx2, mrsx, matCode
              , matDesc, pclx, newMrsx, newPclx, newStd, newGrd, newSpec, newMatCode, newMatDesc, newZyx, newZyx2, newPack, dt_ExecStart.DateTime, 2, sx, itemID);
            if (result == "1")
            {
                BindWgdData();
                BindWgdVData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                BindWgdData();
                BindWgdVData();
                MessageBox.Show("操作失败!");
            }
        }

        /// <summary>
        /// 撤回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "撤回", "撤回", "撤回");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认撤回吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedHandle = this.gv_WGDV.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_WGDV.DataSource = null;
                this.gv_WGDV.BestFitColumns();
                MessageBox.Show("无记录！");
                return;
            }

            //获取焦点行ID
            string id = this.gv_WGDV.GetRowCellValue(selectedHandle, "C_ID").ToString();

            string result = bll_TRC_ROLL_WGD.WgdBackHandler(id, 3);
            if (result == "1")
            {
                BindWgdData();
                BindWgdVData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                BindWgdData();
                BindWgdVData();
                MessageBox.Show("操作失败!");
            }

        }

        private void btn_AsseQuery_Click(object sender, EventArgs e)
        {
            BindWgdData();
            BindWgdVData();
        }

        private void gv_WGD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_WGD.GetDataRow(gv_WGD.FocusedRowHandle);
            if (dr != null)
            {
                //this.cbo_BatchAttr.Text = dr["C_MRSX"].ToString();
                this.cbo_Sx.Text = dr["C_MRSX"].ToString();

                if (dr["C_AREA"].ToString() == "国际贸易部" || dr["C_AREA"].ToString() == "XS出口材XS")
                {
                    image_Type.EditValue = "1";

                    cbo_Sx.Text = "CK";
                }
                else
                {
                    image_Type.EditValue = "0";

                    cbo_Sx.Text = "A";
                }
                //this.image_Type.EditValue = dr["C_PCLX"].ToString();
                string whereSql = "   C_ROLL_WGD_ID='" + dr["C_ID"].ToString() + "' ";
                DataTable dt = bll_TRC_ROLL_WGD_ITEM.GetList(whereSql).Tables[0];
                this.gc_WGDITEM.DataSource = dt;
                this.gv_WGDITEM.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gv_WGDITEM);
            }
            else
            {
                this.gc_WGDITEM.DataSource = null;
            }
        }

        /// <summary>
        /// 上传条码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UpLoad_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "下发条码", "下发条码", "下发条码");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认下发条码吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedHandle = this.gv_WGDV.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_WGDV.DataSource = null;
                this.gv_WGDV.BestFitColumns();
                MessageBox.Show("无记录！");
                return;
            }

            //获取焦点行ID
            string id = this.gv_WGDV.GetRowCellValue(selectedHandle, "C_ID").ToString();
            string result = bll_TRC_ROLL_WGD.UpLoadCodeSys(id);
            if (result == "1")
            {
                BindWgdData();
                BindWgdVData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                BindWgdData();
                BindWgdVData();
                MessageBox.Show("操作失败!");
            }
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_WGDV, "完工记录" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_WGD, "完工单" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
        /// <summary>
        /// 出库材选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void image_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (image_Type.Text == "出口材")
            {
                cbo_Sx.Text = "CK";
            }
            if (image_Type.Text == "普通材")
            {
                cbo_Sx.Text = "A";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (num_wgd > 0)
                {
                    TipsForm frm = new TipsForm("有新的完工单需要确认，请处理！！！");
                    frm.Show();
                }

                BindWgdData();
                BindWgdVData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
