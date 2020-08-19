using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL;

namespace XGCAP.UI.Q.QR
{
    public partial class Form1 : Form
    {
        private Bll_TPP_LG_PLAN bllLG = new Bll_TPP_LG_PLAN();
        private Bll_TSP_PLAN_SMS bllSms = new Bll_TSP_PLAN_SMS();
        private Bll_TMO_ORDER bllOrder = new Bll_TMO_ORDER();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int a = 201900000;
            textEdit1.Text = "0";

            DataTable dt = bllSms.Get_List().Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string result = "0";

                a = a + i;

                DataTable dtOrder = bllOrder.GetList_ByOrderNO(dt.Rows[i]["C_ORDER_NO"].ToString()).Tables[0];
                for (int kk = 0; kk <dtOrder.Rows.Count; kk++)
                {
                    result = bllLG.SendNC(Application.StartupPath, dt.Rows[i]["C_ID"].ToString(), a.ToString(), dtOrder.Rows[kk]["C_ID"].ToString());

                    if(result=="1")
                    {
                        textEdit1.Text = (Convert.ToInt32(textEdit1.Text) + 1).ToString() ;
                    }
                }
            }
        }
    }
}
