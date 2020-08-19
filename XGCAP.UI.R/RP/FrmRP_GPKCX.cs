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

namespace XGCAP.UI.R.RP
{
    public partial class FrmRP_GPKCX : Form
    {
        public FrmRP_GPKCX()
        {
            InitializeComponent();
        }
        private Bll_TPB_SLABWH bllTpbSlabWh = new Bll_TPB_SLABWH();
        private Bll_TB_STA bll_sta = new Bll_TB_STA();

        private void FrmRP_GPKCX_Load(object sender, EventArgs e)
        {
            BindStore();
            BindCC();
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
        /// 绑定连铸
        /// </summary>
        public void BindCC()
        {
            icbo_lz.Properties.Items.Clear();
            DataTable dt = bll_sta.GetListByStatus(1, "CC", "").Tables[0];
            if (dt.Rows.Count > 0)
            {
                icbo_lz.Properties.Items.Add("全部", "", -1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    icbo_lz.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                icbo_lz.Properties.Items.Clear();
            }
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
          
        }


       
    }
}
