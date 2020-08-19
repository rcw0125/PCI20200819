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
    public partial class FrmFR_QTCK : Form
    {
        public FrmFR_QTCK()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_TRC_ROLL_PRODCUT = new Bll_TRC_ROLL_PRODCUT();
        Bll_Interface_FR bll_Interface_FR = new Bll_Interface_FR();
        CommonSub commonSub = new CommonSub();
        private void FrmFR_QTCK_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindXCK(cbo_CK1);
            cbo_CK1.SelectedIndex = 0;
            commonSub.ImageComboBoxEditBindXCK(cbo_MBCK);
            cbo_MBCK.SelectedIndex = 0;
            de_SLSJ.DateTime = RV.UI.ServerTime.timeNow();
            Query();
            QCQuery();
        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
            QCQuery();
        }
        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TRC_ROLL_PRODCUT.GetXCKC(txt_PH1.Text.Trim(), txt_Grd.Text.Trim(), txt_Std.Text.Trim(), cbo_CK1.EditValue.ToString(), "","", "E","","").Tables[0];
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
        private void QCQuery()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TRC_ROLL_PRODCUT.GetXCKC(txt_PH2.Text.Trim(), txt_Grd1.Text.Trim(), txt_Std1.Text.Trim(), cbo_CK1.EditValue.ToString(), "","", "QC",txt_QTCKD.Text.Trim(),"").Tables[0];
                this.gc_QC.DataSource = dt; 
                this.gv_QC.OptionsView.ColumnAutoWidth = false;
                this.gv_QC.OptionsSelection.MultiSelect = true;
                //gv_QC.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.gv_ZGSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZGSJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //private void cbo_CK1_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    commonSub.ImageComboBoxEditBindXCKQY(cbo_CK1.EditValue.ToString(), cbo_QY);
        //    cbo_QY.Properties.Items.Add("全部", "", 0);
        //    cbo_QY.SelectedIndex = cbo_QY.Properties.Items.Count - 1;
        //}

        //private void cbo_QY_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    cbo_KW.Properties.Items.Clear();
        //    if (cbo_QY.EditValue.ToString() == "")
        //    {
        //        cbo_KW.Properties.Items.Add("全部", "", 0);
        //        cbo_KW.SelectedIndex = cbo_KW.Properties.Items.Count - 1;
        //    }
        //    else
        //    {
        //        commonSub.ImageComboBoxEditBindXCKKW(cbo_QY.EditValue.ToString(), cbo_KW);
        //        cbo_KW.Properties.Items.Add("全部", "", 0);
        //        cbo_KW.SelectedIndex = cbo_KW.Properties.Items.Count - 1;
        //    }
        //}

        private void btn_QueryQC_Click(object sender, EventArgs e)
        {
            QCQuery();
        }

        private void btn_QTCK_Click(object sender, EventArgs e)
        {
            int[] rows = gv_ZGSJ.GetSelectedRows();//获取选中行
            if (rows.Count() == 0)
            {
                MessageBox.Show("请勾选线材信息！");
                return;
            }
            string qtckd = RV.UI.ServerTime.timeNow().Year.ToString() + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Month) > 9 ? RV.UI.ServerTime.timeNow().Month.ToString() : ("0" + RV.UI.ServerTime.timeNow().Month.ToString())) + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Day) > 9 ? RV.UI.ServerTime.timeNow().Day.ToString() : ("0" + RV.UI.ServerTime.timeNow().Day.ToString()));//转库单号
            string maxqtckd = bll_Interface_FR.GetQTCKNO(qtckd);//查询当天最大转库单号
            long no = 0;
            if (maxqtckd == "0")
            {
                no = Convert.ToInt64(qtckd + "0001");
            }
            else
            {
                no = Convert.ToInt64(maxqtckd.Substring(2, maxqtckd.Length - 2)) + 1;
            }
            qtckd = "QC" + no;
            List<CommonKC> list = new List<CommonKC>();
            foreach (var item in rows)
            {
                int num = Convert.ToInt32(gv_ZGSJ.GetRowCellValue(item, "N_NUM"));//获取当前选中行数量
                string mat = gv_ZGSJ.GetRowCellValue(item, "C_MAT_CODE").ToString();//获取当前选中行物料号
                string ck = gv_ZGSJ.GetRowCellValue(item, "C_LINEWH_CODE").ToString();//获取当前选中行仓库
                string zldj = gv_ZGSJ.GetRowCellValue(item, "C_JUDGE_LEV_ZH").ToString();//获取当前选中行区域
                string bzyq = gv_ZGSJ.GetRowCellValue(item, "C_BZYQ").ToString();//获取当前选中行库位
                string batch = gv_ZGSJ.GetRowCellValue(item, "C_BATCH_NO").ToString();//获取当前选中行批号
                int zs = Convert.ToInt32(gv_ZGSJ.GetRowCellValue(item, "N_SNUM"));
                int sjzs = bll_Interface_FR.CKKC(mat, ck, batch,zldj,bzyq);
                if (num != sjzs)//验证数量
                {
                    MessageBox.Show("库存数量已变更！");
                    Query();
                    return;
                }
                if (num < zs)
                {

                    MessageBox.Show("数量超出请修改！");
                    return;
                }
                CommonKC commonKC = new CommonKC();
                commonKC.batch = batch;
                commonKC.bzyq = bzyq;
                commonKC.ck = ck;
                commonKC.mat = mat;
                commonKC.num = zs;
                commonKC.zldj = zldj;
                list.Add(commonKC);
            }
            string message = bll_Interface_FR.SENDQTCKD1(list,qtckd,txt_CPH.Text, txt_Adderss.Text, RV.UI.UserInfo.userID, txt_TYPE.Text, txt_SHDW.Text, de_SLSJ.DateTime, txt_CYS.Text, cbo_MBCK.EditValue.ToString(), cbo_MBCK.Text);
            if (message == "1")
            {
                MessageBox.Show("发送条码成功！");
            }
            else
            {
                MessageBox.Show(message);
            }

            Query();
            QCQuery();
        }

        private void gv_ZGSJ_Click(object sender, EventArgs e)
        {
            int Handle = gv_ZGSJ.FocusedRowHandle;
            string num = gv_ZGSJ.GetRowCellValue(gv_ZGSJ.FocusedRowHandle, "N_NUM").ToString();//获取当前选中行数量
        }

        private void gv_ZGSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int Handle = gv_ZGSJ.FocusedRowHandle;
            string num = gv_ZGSJ.GetRowCellValue(gv_ZGSJ.FocusedRowHandle, "N_NUM").ToString();//获取当前选中行数量
        }

        private void btn_OutBack_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = gv_QC.FocusedRowHandle;
                if (rows<0)
                {
                    return;
                }
                string idstr = gv_QC.GetRowCellValue(rows,"C_QTCKD_NO").ToString();
                if (bll_Interface_FR.CXQTCKDByDH(idstr) > 0)
                {
                    MessageBox.Show("撤销成功！");
                }
                else
                {
                    MessageBox.Show("撤销失败,条码已读取！");
                }
                Query();
                QCQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
