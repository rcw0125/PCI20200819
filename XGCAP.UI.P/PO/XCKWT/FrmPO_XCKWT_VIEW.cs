using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;
using Common;
using DevExpress.XtraEditors;

namespace XGCAP.UI.P.PO.XCKWT
{
    public partial class FrmPO_XCKWT_VIEW : Form
    {
        private Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        private Bll_TPB_LINEWH bll_linewh = new Bll_TPB_LINEWH();//仓库
        private Bll_TPB_LINEWH_AREA bll_area = new Bll_TPB_LINEWH_AREA();//区域
        private Bll_TPB_LINEWH_LOC bll_loc = new Bll_TPB_LINEWH_LOC();//库位
        private Bll_TPB_LINEWH_TIER bll_tier = new Bll_TPB_LINEWH_TIER();//层
        private Bll_TPO_XCKWT_LAB bll_xckw_lab = new Bll_TPO_XCKWT_LAB();//线材库位图lab 
        private DataTable dtSlabCount = null;
        private DataTable dtKwCount = null;
        public FrmPO_XCKWT_VIEW()
        {
            InitializeComponent();
        }

        private void FrmPO_GPKWT_VIEW_Load(object sender, EventArgs e)
        {
            BindCK();
        }

        /// <summary>
        /// 加载标签
        /// </summary>
        private void BindLabel()
        {
            try
            {
                panel4.Controls.Clear();
                int slab_count = 0;
                int kw_cap = 0;
                DataTable dt_Lab = bll_xckw_lab.GetList_ID(icbo_CK.Text, "").Tables[0];

                if (dt_Lab.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_Lab.Rows.Count; i++)
                    {
                        DevExpress.XtraEditors.LabelControl lab = new DevExpress.XtraEditors.LabelControl();
                        lab.Name = "labNum_" + dt_Lab.Rows[i]["C_LOC_CODE"].ToString();
                        lab.Text = dt_Lab.Rows[i]["C_LOC_CODE"].ToString();
                        lab.AccessibleDescription = dt_Lab.Rows[i]["C_LOC_CODE"].ToString();
                        lab.Size = new Size(Convert.ToInt32(dt_Lab.Rows[i]["C_LAB_WIDTH"].ToString()), Convert.ToInt32(dt_Lab.Rows[i]["C_LAB_HEIGHT"].ToString()));
                        lab.Location = new Point(Convert.ToInt32(dt_Lab.Rows[i]["C_X_WIRE"].ToString()), Convert.ToInt32(dt_Lab.Rows[i]["C_Y_WIRE"].ToString()));
                        lab.BackColor = Color.LightGreen;


                        DataRow[] drsSlab = dtSlabCount.Select(" C_LINEWH_LOC_CODE = '" + dt_Lab.Rows[i]["C_LOC_CODE"].ToString() + "' ");
                        DataRow[] drs_Kw = dtKwCount.Select(" C_LINEWH_LOC_CODE = '" + dt_Lab.Rows[i]["C_LOC_CODE"].ToString() + "' ");

                        if (drs_Kw.Length > 0)
                        {
                            kw_cap = Convert.ToInt32(drs_Kw[0]["N_QTY"].ToString());
                        }
                        else
                        {
                            kw_cap = 0;
                        }

                        if (drsSlab.Length > 0)
                        {
                            slab_count = Convert.ToInt32(drsSlab[0]["N_NUM"].ToString());

                            if (slab_count > kw_cap)
                            {
                                lab.BackColor = Color.Red;
                            }
                            else
                            {
                                lab.BackColor = Color.LightGreen;
                            }
                        }
                        else
                        {
                            slab_count = 0;
                            lab.BackColor = Color.LightGray;
                        }
                        lab.Text = dt_Lab.Rows[i]["C_LOC_CODE"].ToString() + "\r\n——\r\n" + slab_count + "/" + kw_cap;
                        lab.Click += new System.EventHandler(labModule_Click);

                        lab.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        lab.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                        lab.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
                        lab.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

                        this.panel4.Controls.Add(lab);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定仓库信息
        /// </summary>
        private void BindCK()
        {

            icbo_CK.Properties.Items.Clear();
            DataTable dt = bll_linewh.GetListByStatus(1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    icbo_CK.Properties.Items.Add(dt.Rows[i]["C_LINEWH_CODE"].ToString(), dt.Rows[i]["C_LINEWH_CODE"].ToString(), -1);
                }

                icbo_CK.SelectedIndex = 0;
            }
            else
            {
                icbo_CK.Properties.Items.Clear();
            }

        }

        /// <summary>
        /// 仓库选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void icbo_CK_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtSlabCount = bll_roll_product.Get_KC_COUNt(icbo_CK.EditValue.ToString()).Tables[0];
            dtKwCount = bll_loc.Get_CAP(icbo_CK.EditValue.ToString()).Tables[0];
            BindLabel();
        }
        private void labModule_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LabelControl lab_id = (DevExpress.XtraEditors.LabelControl)sender;
                DataTable dt_con = bll_roll_product.GetList_RK_KW("", lab_id.AccessibleDescription, "", icbo_CK.Text.Trim()).Tables[0];
                gc_SJXX.DataSource = dt_con;
                gv_SJXX.BestFitColumns();
                int slab_count = 0;
                int kw_cap = 0;
                foreach (Control item in panel4.Controls)
                {
                    if (item is LabelControl)
                    {
                        if (((LabelControl)sender).Text == item.Text)
                        {
                            ((LabelControl)sender).BackColor = Color.Yellow;
                        }
                        else
                        {

                            DataRow[] drsSlab = dtSlabCount.Select(" C_LINEWH_LOC_CODE =  '" + item.AccessibleDescription + "' ");
                            DataRow[] drs_Kw = dtKwCount.Select(" C_LINEWH_LOC_CODE =  '" + item.AccessibleDescription + "' ");

                            if (drs_Kw.Length > 0)
                            {
                                kw_cap = Convert.ToInt32(drs_Kw[0]["N_QTY"].ToString());
                            }
                            else
                            {
                                kw_cap = 0;
                            }

                            if (drsSlab.Length > 0)
                            {
                                slab_count = Convert.ToInt32(drsSlab[0]["N_NUM"].ToString());

                                if (slab_count > kw_cap)
                                {
                                    item.BackColor = Color.Red;
                                }
                                else
                                {
                                    item.BackColor = Color.LightGreen;
                                }
                            }
                            else
                            {
                                slab_count = 0;
                                item.BackColor = Color.LightGray;
                            }

                        }
                    }
                }
                SetGridViewRowNum.SetRowNum(gv_SJXX);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询仓库LAB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Select_Click(object sender, EventArgs e)
        {
            BindLabel();
        }
    }
}
