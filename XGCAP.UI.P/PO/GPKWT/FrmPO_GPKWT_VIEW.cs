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

namespace XGCAP.UI.P.PO.GPKWT
{
    public partial class FrmPO_GPKWT_VIEW : Form
    {
        private Bll_TPB_SLABWH bllTPB_SLABWH = new Bll_TPB_SLABWH();
        private Bll_TPB_SLABWH_AREA bllTPB_SLABWH_AREA = new Bll_TPB_SLABWH_AREA();
        private Bll_TPB_SLABWH_LOC bllTPB_SLABWH_LOC = new Bll_TPB_SLABWH_LOC();
        private Bll_TPB_SLABWH_TIER bllTPB_SLABWH_TIER = new Bll_TPB_SLABWH_TIER();
        private Bll_TPO_GPKWT_LAB bllTPO_GPKWT_LAB = new Bll_TPO_GPKWT_LAB();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();//钢坯实绩

        private DataTable dtSlabCount = null;
        private DataTable dtKwCount = null;

        public FrmPO_GPKWT_VIEW()
        {
            InitializeComponent();
        }

        private void FrmPO_GPKWT_VIEW_Load(object sender, EventArgs e)
        {
            CommonSub com = new CommonSub();
            com.ImageComboBoxEditBindGPK(icbo_CK);
        }

        /// <summary>
        /// 加载标签
        /// </summary>
        private void BindLabel()
        {
            try
            {
                panel4.Controls.Clear();
                if (string.IsNullOrEmpty(icbo_CK.EditValue?.ToString())) return;
                DataTable dt_Lab = bllTPO_GPKWT_LAB.GetList(icbo_CK.EditValue.ToString(), "").Tables[0];

                int slab_count = 0;
                int kw_cap = 0;

                if (dt_Lab.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_Lab.Rows.Count; i++)
                    {
                        LabelControl lab = new LabelControl();
                        lab.Name = "labNum_" + dt_Lab.Rows[i]["C_LOC_CODE"].ToString(); 
                        lab.AccessibleDescription = dt_Lab.Rows[i]["C_LOC_CODE"].ToString();
                        lab.Size = new Size(Convert.ToInt32(dt_Lab.Rows[i]["C_LAB_WIDTH"].ToString()), Convert.ToInt32(dt_Lab.Rows[i]["C_LAB_HEIGHT"].ToString()));
                        lab.Location = new Point(Convert.ToInt32(dt_Lab.Rows[i]["C_X_WIRE"].ToString()), Convert.ToInt32(dt_Lab.Rows[i]["C_Y_WIRE"].ToString()));

                        DataRow[] drsSlab = dtSlabCount.Select(" C_SLABWH_LOC_CODE = '" + dt_Lab.Rows[i]["C_LOC_CODE"].ToString() + "' ");
                        DataRow[] drs_Kw = dtKwCount.Select(" C_SLABWH_LOC_CODE = '" + dt_Lab.Rows[i]["C_LOC_CODE"].ToString() + "' ");

                        if (drs_Kw.Length > 0)
                        {
                            kw_cap = Convert.ToInt32(drs_Kw[0]["N_SLABWH_LOC_CAP"].ToString());
                        }
                        else
                        {
                            kw_cap = 0;
                        }

                        if (drsSlab.Length > 0)
                        {
                            slab_count = Convert.ToInt32(drsSlab[0]["SLAB_NUM"].ToString());

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

                        lab.Text = dt_Lab.Rows[i]["C_REMARK"].ToString() + "\r\n——\r\n" + slab_count + "/" + kw_cap;

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
        /// 仓库选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void icbo_CK_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtSlabCount = bll_TSC_SLAB_MAIN.Get_KC_COUNt(icbo_CK.EditValue.ToString()).Tables[0];
            dtKwCount = bllTPB_SLABWH_LOC.Get_CAP(icbo_CK.EditValue.ToString()).Tables[0];

            BindLabel();
        }


        private void labModule_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LabelControl lab_id = (DevExpress.XtraEditors.LabelControl)sender;
                DataTable dt_con = bll_TSC_SLAB_MAIN.GetList_KW(icbo_CK.EditValue.ToString().Trim(), lab_id.AccessibleDescription).Tables[0];
                gc_GPSJ.DataSource = dt_con;
                gv_GPSJ.BestFitColumns();

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
                            DataRow[] drsSlab = dtSlabCount.Select(" C_SLABWH_LOC_CODE = '" + item.AccessibleDescription + "' ");
                            DataRow[] drs_Kw = dtKwCount.Select(" C_SLABWH_LOC_CODE = '" + item.AccessibleDescription + "' ");

                            if (drs_Kw.Length > 0)
                            {
                                kw_cap = Convert.ToInt32(drs_Kw[0]["N_SLABWH_LOC_CAP"].ToString());
                            }
                            else
                            {
                                kw_cap = 0;
                            }

                            if (drsSlab.Length > 0)
                            {
                                slab_count = Convert.ToInt32(drsSlab[0]["SLAB_NUM"].ToString());

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
                SetGridViewRowNum.SetRowNum(gv_GPSJ);
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
        private void btn_Select_Click(object sender, EventArgs e)
        {
            BindLabel();
        }
        /// <summary>
        /// 打开实绩查询界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPO_GPSJ frm = new FrmPO_GPSJ();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
