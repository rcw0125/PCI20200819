using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XGCAP.UI.R.RC
{
    public partial class FrmRF_TBRFWGT : Form
    {
        public FrmRF_TBRFWGT()
        {
            InitializeComponent();
        }
        private Bll_Interface_FR bll = new Bll_Interface_FR();
        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (this.txt_PCH.Text.Trim()=="")
            {
                MessageBox.Show("请输入批号信息进行查询！");
                return;
            }
            DataTable dt = bll.GetRFListByPCH(this.txt_PCH.Text);

            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gridView1);
        }
        private Bll_TRC_ROLL_PRODCUT bll_pro = new Bll_TRC_ROLL_PRODCUT();
        private void btn_tb_Click(object sender, EventArgs e)
        {

            if (DialogResult.No == MessageBox.Show("是否确定同步选中的数据", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int[] grdrow = gridView1.GetSelectedRows();
            if (grdrow.Count() > 0)
            {
                int res = 0;
                foreach (var grditem in grdrow)
                {
                    string PCH = gridView1.GetRowCellValue(grditem, "PCH").ToString();
                    string GH = gridView1.GetRowCellValue(grditem, "GH").ToString();

                     Mod_TRC_ROLL_PRODCUT mod_pro = bll_pro.GetModel(PCH, GH);
                    if (mod_pro.C_MOVE_TYPE=="E"|| mod_pro.C_MOVE_TYPE == "M")
                    {
                        //mod_pro.C_LINEWH_CODE= gridView1.GetRowCellValue(grditem, "CK").ToString();
                        //mod_pro.C_LINEWH_LOC_CODE = gridView1.GetRowCellValue(grditem, "HW").ToString();
                        //mod_pro.C_LINEWH_AREA_CODE = mod_pro.C_LINEWH_LOC_CODE.Substring(0, 5);
                        mod_pro.N_WGT = Convert.ToDecimal(gridView1.GetRowCellValue(grditem, "ZL").ToString());
                        mod_pro.D_DP_DT =Convert.ToDateTime( gridView1.GetRowCellValue(grditem, "WeightRQ").ToString());
                       // mod_pro.C_MOVE_TYPE = "E";
                        bll_pro.Update(mod_pro);
                        res = res + 1;
                        Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "同步条码重量，同步批号："+ PCH+"；钩号："+ GH+"！");//添加操作日志
                    }



                }
                MessageBox.Show("选中："+ grdrow.Count()+"条数据，同步成功："+ res+"条数据！");
            }
            else
            {
              
                MessageBox.Show("请选择需要同步行！");
                return;
            }
        }
        string str_meunname = "";
        private void FrmRF_TBTKXX_Load(object sender, EventArgs e)
        {
            str_meunname = RV.UI.UserInfo.menuName;
        }
    }
}
