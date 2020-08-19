using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_ZLSJBG : Form
    {
        private Bll_TQB_DESIGN_ORDER bllDesignOrder = new Bll_TQB_DESIGN_ORDER();
        private Bll_TQD_DESIGN bllDesign = new Bll_TQD_DESIGN();

        public FrmQB_ZLSJBG()
        {
            InitializeComponent();
        }

        private void FrmQB_ZLSJBG_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

        }

        /// <summary>
        /// 根据订单号查询质量设计信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QueryDesign_ByOrder_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                BindDesignByOrder();
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDesignByOrder()
        {
            DataTable dt = bllDesignOrder.GetDesignByOrder(txt_Order_No.Text.Trim()).Tables[0];

            gc_DesignOrder.DataSource = dt;
            gv_DesignOrder.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_DesignOrder);
        }

        /// <summary>
        /// 根据执行标准和钢种查询质量设计信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QueryDesign_ByStdGrd_Click(object sender, EventArgs e)
        {
            try
            {
                BindDesignByOrder(txt_Stdcode.Text.Trim(), txt_Grd.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDesignByOrder(string strStdcode, string strGrd)
        {
            
            DataTable dt = bllDesignOrder.GetDesignByStdGrd(strStdcode, strGrd).Tables[0];
            if (dt==null) return;
            gc_DesignStdcodeGrd.DataSource = dt;      
            gv_DesignStdcodeGrd.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_DesignStdcodeGrd);
        }

        private void gv_DesignOrder_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_DesignOrder.GetDataRow(e.FocusedRowHandle);
                if (dr == null)
                {
                    gc_DesignStdcodeGrd.DataSource = null;
                    return;
                }
                BindDesignByOrder(dr["执行标准"].ToString(), dr["钢种"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_DesignStdcodeGrd_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_DesignStdcodeGrd.GetDataRow(e.FocusedRowHandle);
                if (dr == null) return;
                BindDesignItemRoll(dr["质量设计号"].ToString(), dr["执行标准"].ToString(), dr["钢种"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询质量设计结果明细
        /// </summary>
        private void BindDesignItemRoll(string strDesignNo, string strStdCode, string strGrd)
        {
            try
            {
                gc_DesignItem.DataSource = null;
                DataTable dt = bllDesign.GetDesignItemRoll(strDesignNo, strStdCode, strGrd, "1").Tables[0];
                if (dt==null) return;
                gc_DesignItem.DataSource = dt;
                gv_DesignItem.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_DesignItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 质量设计变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr_Old = gv_DesignOrder.GetDataRow(gv_DesignOrder.FocusedRowHandle);
                if (dr_Old == null)
                {
                    MessageBox.Show("请选中需要变更质量设计的数据！");
                    return;
                }

                DataRow dr_New = gv_DesignStdcodeGrd.GetDataRow(gv_DesignStdcodeGrd.FocusedRowHandle);
                if (dr_New == null)
                {
                    MessageBox.Show("请选中新的质量设计信息！");
                    return;
                }

                Mod_TQB_DESIGN_ORDER model = new Mod_TQB_DESIGN_ORDER();
                model.C_ORDER_ID = dr_Old["订单号"].ToString();
                model.C_DESIGN_ID = dr_New["C_ID"].ToString();
                model.C_DELIVERY_STATE = dr_Old["C_DELIVERY_STATE"].ToString();
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                model.C_EMP_ID_BG = RV.UI.UserInfo.userID;
                model.D_MOD_DT_BG = RV.UI.ServerTime.timeNow();
                model.N_STATUS = 2;

                if (bllDesignOrder.Add(model))
                {
                    Bll_Common bllCommon = new Bll_Common();

                    if (bllCommon.DataDisabled("TQB_DESIGN_ORDER", dr_Old["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                    {
                        MessageBox.Show("质量设计变更成功！");

                        BindDesignByOrder();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr_Old = gv_DesignOrder.GetDataRow(gv_DesignOrder.FocusedRowHandle);
                if (dr_Old == null)
                {
                    MessageBox.Show("请选需要审核的数据！");
                    return;
                }

                Mod_TQB_DESIGN_ORDER model = bllDesignOrder.GetModel(dr_Old["C_ID"].ToString());
                model.N_STATUS = 1;

                if (bllDesignOrder.Update(model))
                {
                    MessageBox.Show("审核成功！");

                    BindDesignByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
