using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.RC
{
    public partial class FrmRC_TBKPSJ : Form
    {
        public FrmRC_TBKPSJ()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            slbwhCode = arr[1];
        }

        string staID = "";//工位ID
        string slbwhCode = "";//合格坯仓库库位编码

        private Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        private Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();



        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindToSlabList();
        }

        private void btn_SyncNC_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, slbwhCode + "开坯同步NC", "开坯同步NC", "开坯同步NC");//添加操作日志

            int result = 0;

            DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact(2, staID, 1).Tables[0];
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("开坯完工实绩数据为空");
                return;
            }
            WaitingFrom.ShowWait("");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string re = bll_TRC_COGDOWN_MAIN.KpSyncNc(dt.Rows[i]["C_COGDOWN_ID"].ToString(), slbwhCode, staID, Application.StartupPath, dt.Rows[i]["C_COGDOWN_SHIFT"].ToString(), dt.Rows[i]["C_COGDOWN_GROUP"].ToString());
                if (re == "0")
                    result++;
            }
            WaitingFrom.CloseWait();
            MessageBox.Show("同步成功" + result + "条");
            BindToSlabList();
        }

        private void FrmRC_TBKPSJ_Load(object sender, EventArgs e)
        {
            BindToSlabList();
        }

        /// <summary>
        /// 绑定已调拨钢坯数据
        /// </summary>
        public void BindToSlabList()
        {
            try
            {
                DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact(2, staID, 1).Tables[0];
                this.gc_TBKPSJ.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_TBKPSJ);
            }
            catch
            { 

            }
        }

    }
}
