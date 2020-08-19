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
    public partial class FrmRA_FK : Form
    {
        private Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();
        private Bll_TSC_SLAB_MOVE bllTscSlabMove = new Bll_TSC_SLAB_MOVE();
        private Bll_TB_STA bllTbSta = new Bll_TB_STA();
        private Bll_TPB_SLABWH bllTpbSlabWh = new Bll_TPB_SLABWH();
        CommonSub commonSub = new CommonSub();
        string staID = "";//工位ID
        string strMenuName = "";
        string stacode = "";
        public FrmRA_FK()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = arr[0];
            stacode = arr[1];
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRA_FK_Load(object sender, EventArgs e)
        {
            //UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;
            dt_Start.EditValue = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            dt_Fk_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_Fk_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            commonSub.ImageComboBoxEditBindNCBC(icbo_Shift, stacode);
            commonSub.ImageComboBoxEditBindNCBZ(icbo_Group, stacode);
            commonSub.BCBZBindEdit(icbo_Shift, icbo_Group, stacode);
            BindStore();

            BindSlabList();
        }

        /// <summary>
        /// 绑定可调拨钢坯数据
        /// </summary>
        public void BindSlabList()
        {
            try
            {
                DataTable dt = bllTscSlabMain.Get_FK_List(staID, txt_Grd.Text.Trim(), txt_Stove.Text.Trim(), txt_Spec.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

                this.gc_Fk.DataSource = dt;

                SetGridViewRowNum.SetRowNum(gv_Fk);
            }
            catch
            {

            }
        }

        /// <summary>
        /// 分库列表点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Fk_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Fk.GetDataRow(gv_Fk.FocusedRowHandle);
                if (dr != null)
                {
                    txt_AllotNum.Text = dr["N_QUA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
        /// 分库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Fk_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("确认分库吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                DataRow dr = gv_Fk.GetDataRow(gv_Fk.FocusedRowHandle);

                if (dr == null)
                {
                    MessageBox.Show("请选择需要分库的数据!");
                    return;
                }

                if (string.IsNullOrEmpty(this.image_Store.Text))
                {
                    MessageBox.Show("请选择仓库!");
                    return;
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

                string store = this.image_Store.EditValue.ToString();//仓库
                string shift = this.icbo_Shift.Text.ToString();//班次
                string group = this.icbo_Group.Text.ToString();//班组
                string remark = this.txt_Remark.Text.ToLower();

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

                string result = bllTscSlabMove.Add_FK(dr, Convert.ToInt32(allotNum), store, shift, group, Application.StartupPath,remark);
                if (result == "1")
                {
                    BindSlabList();
                    BindSlabFk();

                    MessageBox.Show("操作成功!");
                }
                else
                {
                    MessageBox.Show("操作失败!");
                }

            }
            catch (Exception ex)
            {

            }
        }


        private void txt_AllotNum_Leave(object sender, EventArgs e)
        {
            DataRow dr = gv_Fk.GetDataRow(gv_Fk.FocusedRowHandle);
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
            BindSlabFk();
        }

        /// <summary>
        /// 绑定分库记录
        /// </summary>
        private void BindSlabFk()
        {
            DataTable dt = bllTscSlabMove.Get_FK_Log(staID, txt_Stove_Fk.Text.Trim(), dt_Fk_Start.Text.Trim(), dt_Fk_End.Text.Trim()).Tables[0];

            gc_Move.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gv_Move);
        }
    }
}
