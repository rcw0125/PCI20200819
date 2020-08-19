using BLL;
using Common;
using IDAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.TM
{
    public partial class FrmFR_ZKD : Form
    {
        public FrmFR_ZKD()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_TRC_ROLL_PRODCUT = new Bll_TRC_ROLL_PRODCUT();
        Bll_Interface_FR bll_Interface_FR = new Bll_Interface_FR();
        CommonSub commonSub = new CommonSub(); 
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
            ZKQuery();
        }
        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TRC_ROLL_PRODCUT.GetXCKC(txt_PH1.Text.Trim(), txt_Grd.Text.Trim(), txt_Std.Text.Trim(), cbo_CK.EditValue.ToString(), "", "", "E", "", "").Tables[0];
                this.gc_ZGSJ.DataSource = dt;
                this.gv_ZGSJ.OptionsView.ColumnAutoWidth = false;
                this.gv_ZGSJ.OptionsSelection.MultiSelect = true;
                gv_ZGSJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.gv_ZGSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZGSJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_SCZKD_Click(object sender, EventArgs e)
        {
            int[] rows = gv_ZGSJ.GetSelectedRows();//获取选中行
            if (rows .Count()==0)
            {
                MessageBox.Show("请勾选线材信息！");
                return;
            }
            string zkd = RV.UI.ServerTime.timeNow().Year.ToString() + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Month) > 9 ? RV.UI.ServerTime.timeNow().Month.ToString() : ("0" + RV.UI.ServerTime.timeNow().Month.ToString())) + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Day) > 9 ? RV.UI.ServerTime.timeNow().Day.ToString() : ("0" + RV.UI.ServerTime.timeNow().Day.ToString()));//转库单号
            string maxzkd = bll_Interface_FR.GetZKDNO(zkd);//查询当天最大转库单号
            long no = 0;
            if (maxzkd=="0")
            {
                no = Convert.ToInt64(zkd + "0001");
            }
            else
            {
                no = Convert.ToInt64(maxzkd.Substring(2, maxzkd.Length - 2))+1;
            }
            zkd = "ZK" + no;
            List<CommonKC> list = new List<CommonKC>();
            foreach (var item in rows)
            {
                int num = Convert.ToInt32(gv_ZGSJ.GetRowCellValue(item, "N_NUM"));//获取当前选中行数量
                int zs = Convert.ToInt32(gv_ZGSJ.GetRowCellValue(item, "N_SNUM"));//获取当前选中行计划支数
                string mat= gv_ZGSJ.GetRowCellValue(item, "C_MAT_CODE").ToString();//获取当前选中行物料号;
                string yck= gv_ZGSJ.GetRowCellValue(item, "C_LINEWH_CODE").ToString();//获取当前选中行仓库
                string batch= gv_ZGSJ.GetRowCellValue(item, "C_BATCH_NO").ToString();//获取当前选中行批号
                string  zldj= gv_ZGSJ.GetRowCellValue(item, "C_JUDGE_LEV_ZH").ToString();//获取当前选中行质量等级
                string bzyq= gv_ZGSJ.GetRowCellValue(item, "C_BZYQ").ToString();//获取当前选中行包装要求
                int sjzs = bll_Interface_FR.CKKC(mat, yck, batch,zldj,bzyq);
                if (num != sjzs)//验证数量
                {
                    MessageBox.Show("批号：" + batch + "库存数量已变更！");
                    Query();
                    return;
                }
                if (num < zs)
                {
                    MessageBox.Show("数量超出请修改！");
                    return;
                }
                CommonKC model = new CommonKC();
                model.mat = mat;
                model.ck = yck;
                model.zldj = zldj;
                model.bzyq = bzyq;
                model.batch = batch;
                model.num = zs;
                list.Add(model);
            }
            string message = bll_Interface_FR.SENDZKD1(list, cbo_CK1.EditValue.ToString(), zkd);

            if (message=="1")
            {
                MessageBox.Show("发送成功！");
            }
            else
            {
                MessageBox.Show(message);
            }
            Query();
            ZKQuery();
        }
        private void ZKQuery()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TRC_ROLL_PRODCUT.GetXCKC(txt_PH2.Text.Trim(), txt_grd2.Text.Trim(), txt_std2.Text.Trim(), cbo_CK.EditValue.ToString(), "", "", "M", txt_ZKDH.Text.Trim(), "").Tables[0];
                this.gc_ZK.DataSource = dt;
                this.gv_ZK.OptionsView.ColumnAutoWidth = false;
                this.gv_ZK.OptionsSelection.MultiSelect = true;
                this.gv_ZK.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmFR_ZKD_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindXCK(cbo_CK1);
            cbo_CK1.SelectedIndex = 0;
            commonSub.ImageComboBoxEditBindXCK(cbo_CK);
            cbo_CK.SelectedIndex = 0;
            Query();
            ZKQuery();
        }

        private void gv_ZGSJ_Click(object sender, EventArgs e)
        {
            int Handle = gv_ZGSJ.FocusedRowHandle;
            if (Handle<0)
            {
                return;
            }
            string num = gv_ZGSJ.GetRowCellValue(gv_ZGSJ.FocusedRowHandle, "N_NUM").ToString();//获取当前选中行数量
        }

        private void gv_ZGSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int Handle = gv_ZGSJ.FocusedRowHandle;
            if (Handle < 0)
            {
                return;
            }
            string num = gv_ZGSJ.GetRowCellValue(gv_ZGSJ.FocusedRowHandle, "N_NUM").ToString();//获取当前选中行数量
        }

        private void btn_ZKQuery_Click(object sender, EventArgs e)
        {
            ZKQuery();
        }

        private void btn_OutBack_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = gv_ZK.FocusedRowHandle;
                if (rows < 0)
                {
                    return;
                }
                string idstr = gv_ZK.GetRowCellValue(rows, "C_ZKD_NO").ToString();
                if (bll_Interface_FR.CXZKDByDH(idstr) > 0)
                {
                    MessageBox.Show("撤销成功！");
                }
                else
                {
                    MessageBox.Show("撤销失败,条码已读取！");
                }
                Query();
                ZKQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
