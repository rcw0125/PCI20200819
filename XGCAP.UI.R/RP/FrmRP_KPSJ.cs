using BLL;
using Common;
using MODEL;
using RV.UI;
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
    public partial class FrmRP_KPSJ : Form
    {
        public FrmRP_KPSJ()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            staCode = arr[0];
            if (arr.Length > 1)
                slbwhCode = arr[1];
        }

        string staID = "";//开坯工位ID
        string staCode = "";
        string slbwhCode = "";

        CommonSub sub = new CommonSub();
        Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();
        private readonly Bll_TB_MATRL_MAIN bll_TB_MATRL_MAIN = new Bll_TB_MATRL_MAIN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        Bll_TRP_PLAN_COGDOWN bll_TRP_PLAN_COGDOWN = new Bll_TRP_PLAN_COGDOWN();
        Bll_TB_BCBZ bll_TB_BCBZ = new Bll_TB_BCBZ();
        Bll_TB_BCBZGZ bll_TB_BCBZGZ = new Bll_TB_BCBZGZ();
            string sfys = "";

        private void FrmRP_KPSJ_Load(object sender, EventArgs e)
        {
            this.dt_Plan.DateTime = DateTime.Now.AddDays(-3);
            this.dt_PlanEnd.DateTime = DateTime.Now.AddDays(1);
            this.dt_ExecStart.DateTime = DateTime.Now;
            this.dt_ExecEnd.DateTime = DateTime.Now.AddDays(1);
            this.dt_QueryStart.DateTime = DateTime.Now.AddDays(-1);
            this.dt_QueryEnd.DateTime = DateTime.Now.AddDays(1);
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            sub.ImageComboBoxEditBindNCBC(cbo_Shift, staCode);
            sub.ImageComboBoxEditBindNCBZ(cbo_Group, staCode);
            sub.BCBZBindEdit(cbo_Shift, cbo_Group, staCode);
            Query1();
            Query2();
            Remind();
        }


        private DataTable Query1()
        {
            this.gc_GP1.DataSource = null;

            this.txt_ScrapNum.Text = "0";

            string whereSql = "   WHERE TCM.N_STATUS = 1 ";

            whereSql += " AND TCM.C_STA_ID='" + staID + "' ";

            if (this.dt_Plan.DateTime != DateTime.MinValue)
            {
                whereSql += " AND  TCM.D_MOD_DT>=to_date('" + dt_Plan.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
                whereSql += " AND  TCM.D_MOD_DT<=to_date('" + dt_PlanEnd.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            }
            else
            {
                whereSql += " AND  TCM.D_MOD_DT>=to_date('" + DateTime.Now.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
                whereSql += " AND  TCM.D_MOD_DT<=to_date('" + DateTime.Now.AddDays(1).ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            }

            DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownList(whereSql).Tables[0];
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (int.Parse(dt.Rows[i]["N_QUA_TOTAL_VIRTUAL"].ToString()) - int.Parse(dt.Rows[i]["N_ACCOM_TOTAL"].ToString()) == 0)
            //        {
            //            dt.Rows.RemoveAt(i);
            //            i--;
            //        }
            //    }
            //}
            this.gc_GP1.DataSource = dt;
            this.gv_GP1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_GP1);
            return dt;
        }

        private void Query2()
        {
            DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact(staID, this.dt_QueryStart.DateTime, this.dt_QueryEnd.DateTime).Tables[0];
            this.gc_GPKPSJ.DataSource = dt;
            this.gv_GPKPSJ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_GPKPSJ);
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            int compareDt = DateTime.Compare(this.dt_Plan.DateTime, this.dt_PlanEnd.DateTime);
            if (compareDt > 0)
            {
                MessageBox.Show("日期错误!");
                return;
            }
            Query1();
            Remind();
        }

        /// <summary>
        /// 提交实绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            if (DialogResult.No == MessageBox.Show("确认开坯吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }


            int compareDt = DateTime.Compare(this.dt_ExecStart.DateTime, this.dt_ExecEnd.DateTime);

            if (compareDt > 0)
            {
                MessageBox.Show("日期错误!");
                return;
            }

            int errorNum = 0;//TryParse 输出参数
            string planError = txt_PlanNum.Text.Trim();
            if (planError != null && planError != "" && !Int32.TryParse(planError, out errorNum))
            {
                MessageBox.Show("计划支数格式错误!");
                return;
            }

            string scrapError = txt_ScrapNum.Text.Trim();
            if (scrapError != null && scrapError != "" && !Int32.TryParse(scrapError, out errorNum))
            {
                MessageBox.Show("异常支数格式错误!");
                return;
            }
            DataRow dr = this.gv_GP1.GetDataRow(0);//获取计划焦点行索引
            if (dr == null)
            {
                MessageBox.Show("无可开坯数据!");
                return;
            }
            string gx= bll_TB_STA.GetproIdByCode(staCode);

            string gz = bll_TB_BCBZ.GetGZNEW(gx);
            sfys = bll_TB_BCBZGZ.GetSFYS(gz);
            var matrl = bll_TB_MATRL_MAIN.GetModel(dr["C_MAT_CODE"].ToString());
            var matrl2 = bll_TB_MATRL_MAIN.GetModel(img_MatCode.EditValue.ToString());
            if (matrl == null)
            {
                MessageBox.Show("请确定钢坯已出炉!");
                return;
            }
            Mod_TRC_COGDOWN_PRODUCT model = new Mod_TRC_COGDOWN_PRODUCT();
            model.C_COGDOWN_ID = dr["C_ID"].ToString();//获取焦点主键
            model.C_PLAN_ID = dr["C_PLAN_ID"].ToString();//获取焦点计划主键
            var planModel = bll_TRP_PLAN_COGDOWN.GetModel(model.C_PLAN_ID);
            model.C_BATCH_NO = dr["C_BATCH_NO"].ToString();//获取焦点批号
            model.C_STOVE = dr["C_STOVE"].ToString();//获取焦点炉号
            model.C_STL_GRD = dr["C_STL_GRD"].ToString();//获取焦点行钢种
            model.C_STD_CODE = dr["C_STD_CODE"].ToString();//获取焦点行执行标准 
            model.C_STA_ID = staID;
            model.C_SPEC = matrl2.C_SLAB_SIZE;//钢种规格
            model.N_LEN = matrl2.N_LTH;//长度
            model.C_MAT_CODE = img_MatCode.EditValue.ToString();//获取焦点物料编码
            model.C_MAT_NAME = matrl2.C_MAT_NAME;//获取焦点物料名称
            model.N_QUA = 1;
            model.N_WGT = matrl2.N_HSL;//获取焦点单重
            model.C_MOVE_TYPE = "M";//开坯待入库
            model.C_REMARK = this.txt_Remark.Text;//获取焦点备注
            model.C_QR_USER = UserInfo.userID;
            model.D_Q_DATE = DateTime.Now;
            object obj = bll_TRC_ROLL_WGD.GetOutTime(model.C_COGDOWN_ID);
            model.D_START_DATE = obj == null ? DateTime.Now : DateTime.Parse(obj.ToString());
            model.D_END_DATE = RV.UI.ServerTime.timeNow();
            DateTime productionTime = model.D_START_DATE.Value;
            if (sfys=="延时")
            {
                if (Convert.ToInt32(model.D_START_DATE.Value.ToString("HH")) >= 20)
                {
                    productionTime = productionTime.AddDays(1);
                }
            }

            model.D_QR_DATE = DateTime.Parse(productionTime.ToString("yyyy-MM-dd"));
            model.C_COGDOWN_SHIFT = this.cbo_Shift.EditValue.ToString();
            model.C_COGDOWN_GROUP = this.cbo_Group.EditValue.ToString();
            model.C_EXTEND1 = this.cbo_Shift.Text;
            model.C_EXTEND2 = this.cbo_Group.Text;

            model.N_STATUS = 1;
            model.C_STOCK_STATE = "F";
            model.C_QKP_STATE = "N";
            model.C_COG_STA_ID = staID;
            model.C_ZYX1 = planModel.C_FREE1;
            model.C_ZYX2 = planModel.C_FREE2;
            model.C_JUDGE_LEV_ZH = "合格品";
            model.C_MAT_TYPE = "Y";
            model.C_IS_QR = "Y";

            int planNum = Convert.ToInt32(this.txt_PlanNum.Text);//计划支数
            int cogDownNum = Convert.ToInt32(this.txt_CogDownNum.Text);//开坯支数
            if (this.txt_ScrapNum.Text == null || this.txt_ScrapNum.Text == "")
                this.txt_ScrapNum.Text = "0";
            int scrapNum = Convert.ToInt32(this.txt_ScrapNum.Text);//报废支数


            if (planNum == 0)
            {
                if (bll_TRC_COGDOWN_MAIN.UpdateCogDown(model.C_COGDOWN_ID) != 0)
                {
                    MessageBox.Show("操作成功！");
                    Query1();
                    Query2();

                }
                else
                    MessageBox.Show("操作失败!");
                return;
            }

            string result = bll_TRC_COGDOWN_MAIN.CogDownFactHandler(model, planNum, cogDownNum, scrapNum, decimal.Parse(model.N_WGT.ToString()), decimal.Parse(dr["N_PW"].ToString()), Application.StartupPath);
            if (result == "1")
            {
                MessageBox.Show("操作成功！");
                Query1();
                Query2();
                //#region 同步开坯实绩到NC
                //DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact(2, staID, 1).Tables[0];
                //if (dt == null || dt.Rows.Count == 0)
                //{
                //    return;
                //}
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    string re = bll_TRC_COGDOWN_MAIN.KpSyncNc(dt.Rows[i]["C_COGDOWN_ID"].ToString(), slbwhCode, staID, Application.StartupPath, dt.Rows[i]["C_COGDOWN_SHIFT"].ToString(), dt.Rows[i]["C_COGDOWN_GROUP"].ToString());
                //}
                //#endregion
            }
            else
                MessageBox.Show("操作失败!");
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 撤回实绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认撤回开坯吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact(staID, false).Tables[0];
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("无开坯实绩数据!");
                return;
            }

            string id = dt.Rows[0]["C_COGDOWN_ID"].ToString();//获取焦点组批主表主键
            string remark = this.txt_Remark.Text;
            string result = bll_TRC_COGDOWN_MAIN.CogDownBackFactHandler(id, remark);
            if (result == "1")
            {
                MessageBox.Show("操作成功!");
                Query1();
                Query2();
            }
            else
                MessageBox.Show("操作失败!");
        }

        private void gv_GP1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_GP1.GetDataRow(0);
            if (dr != null)
            {
                string grd = "【" + dr["C_STL_GRD"].ToString() + "】";
                var dt = bll_TB_MATRL_MAIN.GetKPMatrlList(dr["C_STL_GRD"].ToString()).Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        img_MatCode.Properties.Items.Add(grd + item["C_MAT_NAME"].ToString() + "~【" + item["C_SLAB_SIZE"].ToString() + "*" + item["N_LTH"].ToString() + "】", item["C_MAT_CODE"].ToString(), -1);
                    }
                }

                this.img_MatCode.EditValue = dr["C_MAT_CODE"].ToString();
                this.txt_PlanNum.Text = (Convert.ToInt32(dr["N_QUA_TOTAL_VIRTUAL"])).ToString();
                int cogNum = int.Parse(this.txt_PlanNum.Text.ToString());
                if (cogNum == 0)
                    this.txt_CogDownNum.Text = "0";
                else
                    this.txt_CogDownNum.Text = (cogNum * 2).ToString();
                object obj = bll_TRC_ROLL_WGD.GetOutTime(dr["C_ID"].ToString());
                dt_ExecStart.DateTime = obj == null ? DateTime.Now : DateTime.Parse(obj.ToString());
                this.dt_ExecEnd.DateTime = DateTime.Now;
            }
        }


        private void btn_FactQuery_Click(object sender, EventArgs e)
        {
            int compareDt = DateTime.Compare(this.dt_ExecStart.DateTime, this.dt_ExecEnd.DateTime);
            if (compareDt > 0)
            {
                MessageBox.Show("日期错误!");
                return;
            }
            Query2();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_GP1, "开坯组坯计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_GPKPSJ, "开坯实绩" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void txt_ScrapNum_Leave(object sender, EventArgs e)
        {
            DataRow dr = gv_GP1.GetDataRow(0);
            this.txt_PlanNum.Text = (Convert.ToInt32(dr["N_QUA_TOTAL_VIRTUAL"])).ToString();
            int pNum = int.Parse(this.txt_PlanNum.Text.ToString());
            int re = 0;
            if (pNum == 0)
                this.txt_CogDownNum.Text = "0";
            else
                re = (pNum * 2);
            int scrapNum = int.Parse(this.txt_ScrapNum.Text);
            int cogNum = int.Parse(this.txt_CogDownNum.Text);
            int reNum = (cogNum - scrapNum);
            if (reNum < 0)
            {
                txt_CogDownNum.Text = re.ToString();
                txt_ScrapNum.Text = "0";
            }
            else
                txt_CogDownNum.Text = reNum.ToString();

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Query2();
            Remind();
        }

        private void Remind()
        {
            string result = bll_TRC_COGDOWN_MAIN.GetNotUpLoadWgdCount(staID).ToString();
            if (result != "0")
            {
                this.sync_Info.Text = string.Format("有条完工单记录未上传NC，请联系系统管理员！", result);

            }
            else
            {
                this.sync_Info.Text = "";
            }
        }

    }
}
