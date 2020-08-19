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

namespace XGCAP.UI.R.RC
{
    public partial class FrmRC_GZGG : Form
    {
        private Bll_TRC_ROLL_PRODCUT bllTrcRollProduct = new Bll_TRC_ROLL_PRODCUT();
        private Bll_TRC_ROLL_TIME bllTrcRollTime = new Bll_TRC_ROLL_TIME();
        private Bll_TPB_CHANGESPEC_TIME bllTpbChangSpecTime = new Bll_TPB_CHANGESPEC_TIME();

        public FrmRC_GZGG()
        {
            InitializeComponent();
        }

        private void FrmRC_GZGG_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            DataTable dt = bllTrcRollTime.Get_List().Tables[0];
            gridControl1.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gridView1);
        }

        /// <summary>
        /// 同步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TB_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bllTrcRollProduct.GetList_WGD().Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Mod_TRC_ROLL_TIME model = bllTrcRollTime.Get_Model(dt.Rows[i]["C_STA_ID"].ToString(), dt.Rows[i]["RQ"].ToString());

                    if (model == null)
                    {
                        model = new Mod_TRC_ROLL_TIME();
                        model.C_STA_ID = dt.Rows[i]["C_STA_ID"].ToString();
                        model.C_RQ = dt.Rows[i]["RQ"].ToString();
                        model.N_NUM_GRD = 1;
                        model.N_NUM_SPEC = 1;
                        model.C_TIME_SPEC = "0";

                        if (!bllTrcRollTime.Add(model))
                        {
                            MessageBox.Show("操作失败！");
                            return;
                        }
                    }
                    else
                    {
                        if (dt.Rows[i]["C_STA_ID"].ToString() == dt.Rows[i - 1]["C_STA_ID"].ToString())
                        {
                            if (dt.Rows[i]["C_STL_GRD"].ToString() != dt.Rows[i - 1]["C_STL_GRD"].ToString())
                            {
                                model.N_NUM_GRD = model.N_NUM_GRD + 1;
                            }

                            if (dt.Rows[i]["C_SPEC"].ToString() != dt.Rows[i - 1]["C_SPEC"].ToString())
                            {
                                model.N_NUM_SPEC = model.N_NUM_SPEC + 1;

                                int time = bllTpbChangSpecTime.Get_Time2(dt.Rows[i]["C_STA_ID"].ToString(), dt.Rows[i - 1]["C_SPEC"].ToString(), dt.Rows[i]["C_SPEC"].ToString());

                                model.C_TIME_SPEC = (Convert.ToInt32(model.C_TIME_SPEC) + time).ToString();
                            }

                            if (!bllTrcRollTime.Update(model))
                            {
                                MessageBox.Show("操作失败！");
                                return;
                            }
                        }
                        else
                        {
                            model.N_NUM_GRD = 1;
                            model.N_NUM_SPEC = 1;
                            model.C_TIME_SPEC = "0";

                            if (!bllTrcRollTime.Update(model))
                            {
                                MessageBox.Show("操作失败！");
                                return;
                            }
                        }
                    }
                }

                MessageBox.Show("操作成功！");
                btn_Query_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
