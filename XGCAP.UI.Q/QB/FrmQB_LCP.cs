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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_LCP : Form
    {
        private Bll_TQB_GP_LCP_BASIS bllTqbGpLcpBasis = new Bll_TQB_GP_LCP_BASIS();

        private string str_Plan_Code = "";

        public FrmQB_LCP()
        {
            InitializeComponent();
        }

        private void FrmQB_LCP_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询联产品计划信息
        /// </summary>
        private void BindPlanInfo()
        {
            WaitingFrom.ShowWait("");

            str_Plan_Code = "";

            gc_Main.DataSource = null;

            DataTable dt = bllTqbGpLcpBasis.GetList(txt_Grd.Text.Trim(), txt_MatCode.Text.Trim()).Tables[0];

            gc_Main.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_Main);

            WaitingFrom.CloseWait();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindPlanInfo();
        }

        private void gv_Main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_Main.GetDataRow(e.FocusedRowHandle);
            if (dr != null)
            {
                str_Plan_Code = dr["物料编码"].ToString();

                BindItems(str_Plan_Code);
            }
            else
            {
                gc_Item.DataSource = null;
            }
        }

        private void BindItems(string strGpCode)
        {
            DataTable dt = bllTqbGpLcpBasis.Get_Item_List(strGpCode, "", "", "").Tables[0];

            gc_Item.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_Item);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                FrmQB_SELECT_WL frm = new FrmQB_SELECT_WL();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string str_Mat_Code = frm.mat_code;
                    frm.Close();

                    bool IsExists = bllTqbGpLcpBasis.Exists(str_Mat_Code);

                    if (IsExists)
                    {
                        MessageBox.Show("该物料已存在！");
                    }
                    else
                    {
                        Mod_TQB_GP_LCP_BASIS model = new Mod_TQB_GP_LCP_BASIS();

                        model.C_MAT_CODE_PLAN = str_Mat_Code;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;

                        if (bllTqbGpLcpBasis.Add(model))
                        {
                            MessageBox.Show("添加成功！");
                            BindPlanInfo();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加联产品子信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);
                if (dr != null)
                {
                    FrmQB_SELECT_WL_ZXBZ frm = new FrmQB_SELECT_WL_ZXBZ(dr["物料编码"].ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        frm.Close();

                        MessageBox.Show("添加成功！");

                        BindItems(dr["物料编码"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("请选择要添加联产品的物料信息！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除主信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Main_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);
                if (dr != null)
                {
                    DialogResult dialogResult = MessageBox.Show("是否删除物料" + dr["物料编码"] + "的联产品信息？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (bllTqbGpLcpBasis.Update_Status(dr["物料编码"].ToString()))
                        {
                            MessageBox.Show("删除成功！");
                            BindPlanInfo();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择要删除的数据！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除子信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Item_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Item.GetDataRow(gv_Item.FocusedRowHandle);
                if (dr != null)
                {
                    DialogResult dialogResult = MessageBox.Show("是否删除物料" + dr["物料编码"] + "的联产品信息？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (bllTqbGpLcpBasis.Update_Status(str_Plan_Code, dr["物料编码"].ToString()))
                        {
                            MessageBox.Show("删除成功！");
                            BindItems(str_Plan_Code);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择要删除的数据！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Tb_Click(object sender, EventArgs e)
        {
            try
            {
                string result = bllTqbGpLcpBasis.UPDATE_LCP_CODE();

                MessageBox.Show(result);

                BindPlanInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
