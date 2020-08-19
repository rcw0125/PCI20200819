using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PR
{
    public partial class Frm_PR_ORDER_MONITOR_ROLL : Form
    {
        public Frm_PR_ORDER_MONITOR_ROLL()
        {
            InitializeComponent();
        }


        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();

        private void btn_AllowGrdQuery_Click(object sender, EventArgs e)
        {
            if (dt_rq.DateTime == DateTime.MinValue)
            {
                MessageBox.Show("请选择日期");
                return;
            }

            DataTable dt = bll_order.GetOrderMonitor_Roll(dt_rq.DateTime, dt_rq2.DateTime, img_prodLine.EditValue.ToString());
            SetTableNullToZero(dt);
            this.gc_KDZGZ.DataSource = dt;
            this.gv_KDZGZ.OptionsView.ColumnAutoWidth = false;
            //SetGridViewRowNum.SetRowNum(gv_KDZGZ);
            gv_KDZGZ.BestFitColumns();
            SetGridViewStyle();
        }

        private void SetTableNullToZero(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (dr[i] == DBNull.Value)
                        {
                            dr[i] = 0;
                        };
                    }
                }
            }
        }

        private void SetGridViewStyle()
        {
            //gv_KDZGZ.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "C_ROLL_CODE", gridColumn1, "小计");
            gv_KDZGZ.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "N_WGT", gridColumn2, "{0}");
            gv_KDZGZ.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "N_PROD_WGT", gridColumn4, "{0}");
            gv_KDZGZ.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "EXEC_WGT", gridColumn3, "{0}");
            gv_KDZGZ.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "STAN_WGT", gridColumn5, "{0}");
            gv_KDZGZ.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "STAN_WGT2", gridColumn6, "{0}");
            gv_KDZGZ.OptionsBehavior.AutoExpandAllGroups = true;//展开所有分组
            //列字体对齐方式
            gv_KDZGZ.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //列字体设置
            gv_KDZGZ.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            //行字体对齐方式
            gv_KDZGZ.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //奇数行背景色
            gv_KDZGZ.Appearance.EvenRow.BackColor = Color.FromArgb(228, 243, 255);
        }

        private void Frm_PR_ORDER_MONITOR_ROLL_Load(object sender, EventArgs e)
        {
            dt_rq.DateTime = DateTime.Now.AddDays(-2);
            dt_rq2.DateTime = DateTime.Now.AddDays(1);
            LoadingProdLine();
        }

        /// <summary>
        /// 加载产线
        /// </summary>
        private void LoadingProdLine()
        {
            img_prodLine.Properties.Items.Clear();
            DataTable dt = bll_TRC_ROLL_WGD.GetProdLine("%#ZX");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    img_prodLine.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_CODE"].ToString(), -1);
                }
            }
            else
            {
                img_prodLine.Properties.Items.Clear();
            }
            img_prodLine.Properties.Items.Add("全部", "全部", -1);
        }

        private void gv_KDZGZ_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            int dx = e.Bounds.Height;
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.Wheat, Color.FloralWhite, LinearGradientMode.Vertical);
            Rectangle r = e.Bounds;
            ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
            r.Inflate(-1, -1);
            e.Graphics.FillRectangle(brush, r);
            r.Inflate(-2, 0);
            e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r);
            e.Handled = true;
        }

        private void gv_KDZGZ_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_KDZGZ.GetDataRow(e.RowHandle);
                var execWgt = decimal.Parse(dr["EXEC_WGT"].ToString());

                if (execWgt < 0)
                {
                    e.Appearance.ForeColor = Color.Orange;
                }
            }
        }

        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_KDZGZ, "订单线材监控-车间" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
