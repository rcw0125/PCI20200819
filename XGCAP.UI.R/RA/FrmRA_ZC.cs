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

namespace XGCAP.UI.R.RA
{
    public partial class FrmRA_ZC : Form
    {
        private Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();
        private Bll_TSC_SLAB_MOVE bllTscSlabMove = new Bll_TSC_SLAB_MOVE();
        private Bll_TB_STA bllTbSta = new Bll_TB_STA();
        private Bll_TPB_SLABWH bllTpbSlabWh = new Bll_TPB_SLABWH();
        private Bll_TPB_SLABWH_LOC bllSlabLoc = new Bll_TPB_SLABWH_LOC();
        CommonSub commonSub = new CommonSub();

        string slabwhCode = "";//仓库
        string stacode = "";

        public FrmRA_ZC()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            slabwhCode = arr[0];
            stacode = arr[1];
        }

        private void FrmRA_ZC_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindNCBC(icbo_Shift, stacode);
            commonSub.ImageComboBoxEditBindNCBZ(icbo_Group, stacode);
            commonSub.BCBZBindEdit(icbo_Shift, icbo_Group, stacode);
            BindSlabList();
        }


        /// <summary>
        /// 绑定库存钢坯数据
        /// </summary>
        public void BindSlabList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Slab.DataSource = null;

                DataTable dt = bllTscSlabMain.Get_KC_List(slabwhCode, txt_Grd.Text.Trim(), txt_Stove.Text.Trim(), txt_Spec.Text.Trim(), "", "").Tables[0];

                this.gc_Slab.DataSource = dt;

                SetGridViewRowNum.SetRowNum(gv_Slab);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_ZC_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认装车吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            DataRow dr = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);

            if (dr == null)
            {
                MessageBox.Show("请选择需要调拨的数据!");
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

            int errorNum = 0;//TryParse 输出参数
            string allotNum = txt_AllotNum.Text.Trim();
            if (!Int32.TryParse(allotNum, out errorNum))
            {
                MessageBox.Show("装车支数只能是整数!");
                return;
            }

            if (Convert.ToInt32(allotNum) > Convert.ToInt32(dr["N_QUA"].ToString()))
            {
                MessageBox.Show("装车支数不能超过钢坯总数!");
                return;
            }

            string shift = this.icbo_Shift.EditValue.ToString();//班次
            string group = this.icbo_Group.EditValue.ToString();//班组
            string remark = this.txt_Remark.Text;//备注
            WaitingFrom.ShowWait("");

            string result = bllTscSlabMove.Loading(dr, Convert.ToInt32(allotNum), slabwhCode, shift, group, remark);
            if (result == "1")
            {
                BindSlabList();
                MessageBox.Show("操作成功!");
            }
            else
            {
                MessageBox.Show(result);
            }

            WaitingFrom.CloseWait();

        }

        private void gv_Slab_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Slab.GetDataRow(e.FocusedRowHandle);
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

        private void btn_QuerySlab_Click(object sender, EventArgs e)
        {
            BindSlabList();
        }
    }
}
