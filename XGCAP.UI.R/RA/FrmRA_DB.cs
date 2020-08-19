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

namespace XGCAP.UI.R.RA
{
    public partial class FrmRA_DB : Form
    {
        private Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();
        private Bll_TSC_SLAB_MOVE bllTscSlabMove = new Bll_TSC_SLAB_MOVE();
        private Bll_TB_STA bllTbSta = new Bll_TB_STA();
        private Bll_TPB_SLABWH bllTpbSlabWh = new Bll_TPB_SLABWH();
        private Bll_TPB_SLABWH_LOC bllSlabLoc = new Bll_TPB_SLABWH_LOC();
        CommonSub commonSub = new CommonSub();

        string slabwhCode = "";//仓库
        string strMenuName = "";
        string stacode = "";
        public FrmRA_DB()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            slabwhCode = arr[0];
            stacode = arr[1];
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRA_DB_Load(object sender, EventArgs e)
        {
            //UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            dt_Fk_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_Fk_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            commonSub.ImageComboBoxEditBindNCBC(icbo_Shift, stacode);
            commonSub.ImageComboBoxEditBindNCBZ(icbo_Group, stacode);
            commonSub.BCBZBindEdit(icbo_Shift, icbo_Group, stacode);
            BindStore();
            BindSlabList();
        }

        /// <summary>
        /// 绑定库存钢坯数据
        /// </summary>
        public void BindSlabList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Slab.DataSource = null;

                DataTable dt = bllTscSlabMain.Get_KC_List(slabwhCode, txt_Grd.Text.Trim(), txt_Stove.Text.Trim(), txt_Spec.Text.Trim(), "", "").Tables[0];

                this.gc_Slab.DataSource = dt;

                SetGridViewRowNum.SetRowNum(gv_Slab);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定仓库
        /// </summary>
        public void BindStore()
        {
            DataTable dt = bllTpbSlabWh.GetList().Tables[0];
            image_Store.Properties.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                image_Store.Properties.Items.Add(item["C_SLABWH_CODE"].ToString() + item["C_SLABWH_NAME"].ToString(), item["C_SLABWH_CODE"], -1);
            }
        }

        /// <summary>
        /// 调拨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Fk_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("确认调拨吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                DataRow dr = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);

                if (dr == null)
                {
                    MessageBox.Show("请选择需要调拨的数据!");
                    return;
                }

                if (string.IsNullOrEmpty(this.image_Store.Text))
                {
                    MessageBox.Show("请选择仓库!");
                    return;
                }
                else
                {
                    if (image_Store.EditValue.ToString() == dr["C_SLABWH_CODE"].ToString())
                    {
                        MessageBox.Show("要调拨的仓库和原仓库相同，无法调拨!");
                        return;
                    }
                }

                if (string.IsNullOrEmpty(icbo_Shift.Text))
                {
                    MessageBox.Show("请选择班次!");
                    return;
                }

                if (string.IsNullOrEmpty(icbo_Group.Text))
                {
                    MessageBox.Show("请选择班组!");
                    return;
                }
                if (!string.IsNullOrEmpty(dr["C_SLABWH_LOC_CODE"].ToString()))
                {
                    DataTable dt = bllSlabLoc.GetList_LocCode(dr["C_SLABWH_LOC_CODE"].ToString()).Tables[0];
                    if (dt.Rows[0]["C_SLABWH_TYPE"].ToString() == "缓冷坑")
                    {
                        DataTable dt_hl = bllTscSlabMain.Get_DB_HL_TIME(dt.Rows[0]["C_SLABWH_LOC_CODE"].ToString()).Tables[0];
                        if (!string.IsNullOrEmpty(dt_hl.Rows[0]["HL_TIME"].ToString()))
                        {
                            if (Convert.ToDateTime(dt_hl.Rows[0]["HL_TIME"]) > RV.UI.ServerTime.timeNow())
                            {
                                MessageBox.Show("未达最佳缓冷时间");
                                return;
                            }
                        }

                    }
                }

                string store = this.image_Store.EditValue.ToString();//仓库
                string shift = this.icbo_Shift.EditValue.ToString();//班次
                string group = this.icbo_Group.EditValue.ToString();//班组
                string remark = this.txt_Remark.Text.ToString();//备注

                int errorNum = 0;//TryParse 输出参数
                string allotNum = txt_AllotNum.Text.Trim();
                if (!Int32.TryParse(allotNum, out errorNum))
                {
                    MessageBox.Show("调拨支数只能是整数!");
                    return;
                }

                if (Convert.ToInt32(allotNum) > Convert.ToInt32(dr["N_QUA"].ToString()))
                {
                    MessageBox.Show("调拨支数不能超过可调拨钢坯总数!");
                    return;
                }

                WaitingFrom.ShowWait("");

                string result = bllTscSlabMove.Add_DB(dr, Convert.ToInt32(allotNum), store, shift, group, Application.StartupPath, remark);
                if (result == "1")
                {
                    BindSlabList();
                    BindSlabDB();

                    MessageBox.Show("操作成功!");
                }
                else
                {
                    MessageBox.Show(result);
                }

                WaitingFrom.CloseWait();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txt_AllotNum_Leave(object sender, EventArgs e)
        {
            DataRow dr = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);
            if (dr != null)
            {
                if (Convert.ToInt32(this.txt_AllotNum.Text) > Convert.ToInt32(dr["N_QUA"]))
                {
                    this.txt_AllotNum.Text = (Convert.ToInt32(dr["N_QUA"])).ToString();
                }
            }
        }

        private void btn_QuerySlab_Click(object sender, EventArgs e)
        {
            BindSlabList();
        }

        private void btn_QuerySlabFk_Click(object sender, EventArgs e)
        {
            BindSlabDB();
        }

        /// <summary>
        /// 绑定调拨记录
        /// </summary>
        private void BindSlabDB()
        {
            WaitingFrom.ShowWait("");

            DataTable dt = bllTscSlabMove.Get_DB_Log(slabwhCode, txt_Stove_Fk.Text.Trim(), dt_Fk_Start.Text.Trim(), dt_Fk_End.Text.Trim()).Tables[0];

            gc_Move.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gv_Move);

            WaitingFrom.CloseWait();
        }

        private void gv_Slab_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Slab.GetDataRow(e.FocusedRowHandle);
                if (dr != null)
                {
                    txt_AllotNum.Text = dr["N_QUA"].ToString();
                    txt_Remark.Text = dr["C_REMARK"].ToString();
                }
                else
                {
                    txt_AllotNum.Text = "";
                    txt_Remark.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_Slab_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_Slab.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_Slab.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_Slab_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_Slab.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_Move_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_Move.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_Move_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_Move.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_Move.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gc_Slab);
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_min_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gc_Move);
        }
    }
}
