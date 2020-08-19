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
using IDAL;
using MODEL;

namespace XGCAP.UI.R.TM
{
    public partial class FrmPB_GPFYD : Form
    {
        public FrmPB_GPFYD()
        {
            InitializeComponent();
        }
        Bll_TMD_DISPATCH bll_TMD_DISPATCH = new Bll_TMD_DISPATCH();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_Interface_WL bll_Interface_WL = new Bll_Interface_WL();
        Bll_TSC_SLAB_MAIN_LOG bll_TSC_SLAB_MAIN_LOG = new Bll_TSC_SLAB_MAIN_LOG();
        Dal_Interface_FR dal_Interface_FR = new Dal_Interface_FR();
        CommonSub commonSub = new CommonSub();
        private void FrmPB_GPFYD_Load(object sender, EventArgs e)
        {
            dt_start.DateTime = RV.UI.ServerTime.timeNow().AddDays(-1);
            dt_end.DateTime = RV.UI.ServerTime.timeNow().AddDays(1);
            de_SJ.DateTime = RV.UI.ServerTime.timeNow();
            commonSub.ImageComboBoxEditBindGPK(cbo_CK2);
            cbo_CK2.SelectedIndex = 0;
        }

        private void btn_FYDQuery_Click(object sender, EventArgs e)
        {
            FYDQuery();
        }
        public void FYDQuery()
        {
            try
            {
                string status = "";
                if (rb_SFSJ.SelectedIndex == 0)
                {
                    btn_FY.Enabled = true;
                    btn_FSNC.Enabled = false;
                    status = "4";
                }
                else
                {
                    btn_FSNC.Enabled = true;
                    btn_FY.Enabled = false;
                    status = "7";
                }
                DataTable dt = null;
                dt = bll_TMD_DISPATCH.GetFYDList(txt_FYDH.Text, dt_start.DateTime, dt_end.DateTime, status).Tables[0];
                this.gc_FYD.DataSource = dt;
                this.gv_FYD.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_FYD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void gv_FYD_Click(object sender, EventArgs e)
        {
            GPQuery();
        }

        private void gv_FYD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GPQuery();
        }

        private void btn_GPQuery_Click(object sender, EventArgs e)
        {
            GPQuery();
        }

        private void GPQuery()
        {
            try
            {
                if (gv_FYD.FocusedRowHandle < 0)
                {
                    return;
                }
                string grd = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "C_STL_GRD").ToString();
                string code = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "C_STD_CODE").ToString();
                string ck = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "C_SEND_STOCK_CODE").ToString();
                string zldj = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "C_JUDGE_LEV_ZH").ToString();
                string mat = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "C_MAT_CODE").ToString();
                DataTable dt = null;
                dt = bll_TSC_SLAB_MAIN.GetList("E", txt_LH.Text, mat, code, ck, txt_KPH.Text.Trim(),zldj).Tables[0];
                this.gc_GP.DataSource = dt;
                this.gv_GP.OptionsView.ColumnAutoWidth = false;
                this.gv_GP.OptionsSelection.MultiSelect = true;
                gv_GP.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.gv_GP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_FY_Click(object sender, EventArgs e)
        {

            if (gv_FYD.FocusedRowHandle < 0)
            {
                MessageBox.Show("未选中发运单！");
                return;
            }
            string fydstr = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "C_ID").ToString();
            string num = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "N_NUM").ToString();
            string sjnum = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "SJSL").ToString();
            if (bll_Interface_WL.GetFYDZT(fydstr) != "4")
            {
                MessageBox.Show("该发运单状态已变更！");
                FYDQuery();
                return;
            }
            if (sjnum == "")
            {
                sjnum = "0";
            }
            int[] row = gv_GP.GetSelectedRows();
            ///判断选中库存支数是否超出发运单支数
            int sjzs = 0;
            foreach (var item in row)
            {
                sjzs += Convert.ToInt32(gv_GP.GetRowCellValue(item, "N_SNUM"));//获取当前选中行计划支数
            }
            int yxzs = Convert.ToInt32(num) - Convert.ToInt32(sjnum);
            if (sjzs > yxzs)
            {
                MessageBox.Show("选中数量超出！当前选中" + sjzs + "条,应选中" + yxzs + "条!");
                return;
            }
            List<CommonKC> list = new List<CommonKC>();
            foreach (var item in row)
            {
                int qua = Convert.ToInt32(gv_GP.GetRowCellValue(item, "N_QUA"));//获取当前选中行数量
                int zs = Convert.ToInt32(gv_GP.GetRowCellValue(item, "N_SNUM"));//获取当前选中行计划支数
                string mat = gv_GP.GetRowCellValue(item, "C_MAT_CODE").ToString();//获取当前选中行物料号;
                string ck = gv_GP.GetRowCellValue(item, "C_SLABWH_CODE").ToString();//获取当前选中行仓库
                string qy = gv_GP.GetRowCellValue(item, "C_SLABWH_AREA_CODE").ToString();//获取当前选中行仓库
                string kw = gv_GP.GetRowCellValue(item, "C_SLABWH_LOC_CODE").ToString();//获取当前选中行仓库
                string stove = gv_GP.GetRowCellValue(item, "C_STOVE").ToString();//获取当前选中行批号
                string batch = gv_GP.GetRowCellValue(item, "C_BATCH_NO").ToString();//获取当前选中行批号
                string zldj = gv_GP.GetRowCellValue(item, "C_JUDGE_LEV_ZH").ToString();//获取当前选中行质量等级
                int szs = bll_TSC_SLAB_MAIN.CKKC(mat, ck, stove, batch);
                if (qua != szs)//验证数量
                {
                    MessageBox.Show("批号：" + batch + "库存数量已变更！");
                    GPQuery();
                    return;
                }
                if (qua < zs)
                {
                    MessageBox.Show("数量超出请修改！");
                    return;
                }
                CommonKC commonKC = new CommonKC();
                commonKC.batch = batch;
                commonKC.ck = ck;
                commonKC.kw = kw;
                commonKC.mat = mat;
                commonKC.num = zs;
                commonKC.qy = qy;
                commonKC.stove = stove;
                commonKC.zldj = zldj;
                list.Add(commonKC);
            }
            if (bll_TSC_SLAB_MAIN.UPSLABSTATUS(list,fydstr,"1")!= 1)
            {
                MessageBox.Show("实绩标记失败！");
                return;
            }

            if (bll_TSC_SLAB_MAIN.GetSJCount(fydstr) == Convert.ToInt32(num))
            {
                Mod_TMD_DISPATCH mod_TMD_DISPATCH = bll_TMD_DISPATCH.GetModel(fydstr);
                mod_TMD_DISPATCH.C_STATUS = "7";//实绩已标记状态
                bll_TMD_DISPATCH.Update(mod_TMD_DISPATCH);
                if (bll_Interface_WL.ADDFYDToZJB(fydstr,de_SJ.DateTime) == "1")
                {
                    MessageBox.Show("实绩已全部标记！");
                    GPQuery();
                    FYDQuery();
                    SJQuery();
                    return;
                }
            }
            MessageBox.Show("实绩标记成功！");
            GPQuery();
            FYDQuery();
            SJQuery();
        }

        private void btn_FSNC_Click(object sender, EventArgs e)
        {
            if (gv_FYD.FocusedRowHandle < 0)
            {
                MessageBox.Show("未选中发运单！");
                return;
            }
            string fydstr = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "C_ID").ToString();//发运单号
            string jz = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "N_JWGT").ToString();//净重
            string num = gv_FYD.GetRowCellValue(gv_FYD.FocusedRowHandle, "N_NUM").ToString();//数量
            if (jz == null || jz == "")
            {
                MessageBox.Show("该发运单净重未导入！");
                return;
            }
            if (bll_Interface_WL.GetFYDZT(fydstr) != "7")
            {
                MessageBox.Show("该发运单未做实绩或发运单状态已改变！");
                FYDQuery();
                return;
            }
            decimal wgt = Convert.ToDecimal(jz) / Convert.ToDecimal(num);
            DataTable dt = bll_TSC_SLAB_MAIN.GetListByFYDH(fydstr, "1", "", "", "").Tables[0];
            if (dt.Rows.Count != Convert.ToDecimal(num))
            {
                MessageBox.Show("异常！钢坯实绩数量与计划数量不符！");
                FYDQuery();
                SJQuery();
                return;
            }
     
            string message = bll_Interface_WL.SENDFYD(fydstr, Application.StartupPath);
            if (message != "1")
            {
                MessageBox.Show(message);
                return;
            }
            MessageBox.Show("上传成功！");
            FYDQuery();
            GPQuery();
            SJQuery();
        }

        private void btn_SJQuery_Click(object sender, EventArgs e)
        {
            SJQuery();
        }
        private void SJQuery()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TSC_SLAB_MAIN.GetListByFYDH(txt_FYDH2.Text.Trim(), "1", txt_LH1.Text.Trim(), txt_KPH1.Text.Trim(), cbo_CK2.EditValue.ToString()).Tables[0];
                this.gc_FYGP.DataSource = dt;
                this.gv_FYGP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_FYGP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_CH_Click(object sender, EventArgs e)
        {
            if (gv_FYGP.FocusedRowHandle < 0)
            {
                MessageBox.Show("未选择取消标记实绩！");
                return;
            }
            string fydstr = gv_FYGP.GetRowCellValue(gv_FYGP.FocusedRowHandle, "C_FYDH").ToString();
            if (bll_Interface_WL.GetFYDZT(fydstr) == "9")
            {
                MessageBox.Show("发运单已发NC，不能取消！");
                return;
            }
            bll_Interface_WL.UPFYDSTATUS(fydstr, "4");
            bll_Interface_WL.UPSLABSTATUS(fydstr, "1", "E");
            bll_Interface_WL.DELFYD(fydstr);
            MessageBox.Show("取消标记成功！");
            FYDQuery();
            GPQuery();
            SJQuery();
        }


    }
}
