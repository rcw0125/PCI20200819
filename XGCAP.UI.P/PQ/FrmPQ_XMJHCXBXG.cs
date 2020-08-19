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
using System.Windows.Forms;

namespace XGCAP.UI.P.PQ
{
    public partial class FrmPQ_XMJHCXBXG : Form
    {
        public FrmPQ_XMJHCXBXG()
        {
            InitializeComponent();
        }
        Bll_TSP_PLAN_SMS bll = new Bll_TSP_PLAN_SMS();
        Bll_TB_STA bll_sta = new Bll_TB_STA();
        private Bll_TQB_COPING_BASIC bll_xm = new Bll_TQB_COPING_BASIC();
        private List<Mod_TSP_PLAN_SMS> lst = null;
        CommonSub sub = new CommonSub();
        private void FrmPQ_XMJHCX_Load(object sender, EventArgs e)
        {
            dt_st.EditValue = DateTime.Now.AddYears(-2).ToShortDateString();
            dt_et.EditValue = DateTime.Now.AddDays(30).ToShortDateString();
            dt_KSSJ.EditValue = DateTime.Now;
            BindInfo();

            DataTable dtxm = bll_xm.GetBxgBZ();
            icbo_xm.Properties.Items.Clear();
            icbo_xm.Properties.Items.Add("", "", -1);
            for (int i = 0; i < dtxm.Rows.Count; i++)
            {

                icbo_xm.Properties.Items.Add(dtxm.Rows[i]["C_CRAFT_FLOW"].ToString(), dtxm.Rows[i]["C_COPING_CRAFT"].ToString(), -1);

            }
            icbo_xm.SelectedIndex = 0;

            InitDrop();
        }
        /// <summary>
        /// 查询生产影响记录
        /// </summary>
        public void BindInfo()
        {
            WaitingFrom.ShowWait("");
            lst = bll.GetModelList1(cbo_xmdd.Text.Trim(), txt_stove.Text.Trim(), txt_grd.Text, dt_st.DateTime, dt_et.DateTime, "不锈钢");
            this.gc_GP.DataSource = lst;
            this.gv_GP.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_GP.OptionsSelection.MultiSelect = true;//允许多选
            gv_GP.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            //gridColumn18.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_GP.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GP);
            WaitingFrom.CloseWait();
        }
        #region 浇次计划列表鼠标拖动方法
        /// <summary>
        /// 浇次计划 行托动方法
        /// </summary>
        /// <param name="lst">加载的数据</param>
        /// <param name="gvSource">gridview</param>
        private void InitDrop()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                this.gv_GP, gv_GP, (row1, row2) =>
                {
                    //DateTime st = Convert.ToDateTime(lst[0].D_XM_START_TIME);
                    DateTime st = dt_KSSJ.DateTime;
                    if (row1 == row2) return;
                    var plan1 = gv_GP.GetRow(row1) as Mod_TSP_PLAN_SMS;
                    if (row2 < lst.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gv_GP.RowCount)
                        {
                            row2 = gv_GP.RowCount - 1;
                        }
                        var plan2 = gv_GP.GetRow(row2) as Mod_TSP_PLAN_SMS;
                        if (plan2 == null)
                            return;
                        lst.Remove(plan1);
                        var left = lst.TakeWhile(x => x.N_XM_SORT < plan2.N_XM_SORT).ToList();
                        var right = lst.Where(x => left.Contains(x) == false).ToList();
                        lst.Clear();
                        lst.AddRange(left);
                        lst.Add(plan1);
                        lst.AddRange(right);
                    }
                    else
                    {
                        lst.Remove(plan1);
                        lst.Add(plan1);
                    }
                    //DateTime time = dt_KSSJ.DateTime;
                    for (int i = 0; i < lst.Count; i++)
                    {
                        lst[i].N_XM_SORT = i + 1;
                        if (i == 0)
                        {
                            lst[i].D_XM_START_TIME = st;
                            if (Convert.ToDateTime(lst[i].D_XM_CAN_START_TIME) > lst[i].D_XM_START_TIME)
                            {
                                lst[i].D_XM_START_TIME = lst[i].D_XM_CAN_START_TIME;
                            }
                        }
                        else
                        {
                            lst[i].D_XM_START_TIME = lst[i - 1].D_XM_END_TIME;
                            if (Convert.ToDateTime(lst[i].D_XM_CAN_START_TIME) > lst[i].D_XM_START_TIME)
                            {
                                lst[i].D_XM_START_TIME = lst[i].D_XM_CAN_START_TIME;
                            }

                        }
                        string length = (Convert.ToDecimal(lst[i].C_SLAB_LENGTH) / 1000).ToString();
                        string gz = lst[i].C_BXGGZ;
                        double jscn = 4.17;
                        string cn = bll.GetBXGXMJSCN(lst[i].C_STL_GRD, lst[i].C_SLAB_SIZE, Convert.ToInt32(lst[i].C_SLAB_LENGTH), gz);
                        if (cn == "")
                        {
                            if (gz.Contains("A"))
                            {
                                jscn = 2;
                            }
                            else if (gz.Contains("B"))
                            {
                                jscn = 4.2;
                            }
                            else if (gz.Contains("C"))
                            {
                                jscn = 6.7;
                            }
                            else if (gz.Contains("E"))
                            {
                                jscn = 2.2;
                            }
                            else
                            {
                                jscn = 4;
                            }
                        }
                        else
                        {
                            jscn = Convert.ToDouble(cn);
                        }
                        double sl = Convert.ToDouble(lst[i].N_XM_WGT) / jscn;
                        lst[i].D_XM_END_TIME = Convert.ToDateTime(lst[i].D_XM_START_TIME).AddHours(sl);
                    }
                    if (row2 > row1)//重置焦点行
                    {
                        gv_GP.ClearSelection();
                        gv_GP.FocusedRowHandle = row2 - 1;
                        gv_GP.SelectRow(row2 - 1);
                    }
                    else
                    {
                        gv_GP.ClearSelection();
                        gv_GP.FocusedRowHandle = row2;
                        gv_GP.SelectRow(row2);
                    }

                    gv_GP.RefreshData();

                });
            dropPlanToReq.AllowDrop = true;
        }
        #endregion

        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            DateTime st = dt_KSSJ.DateTime;
            DateTime time = dt_KSSJ.DateTime;
            for (int i = 0; i < lst.Count; i++)
            {
                Mod_TSP_PLAN_SMS mod = bll.GetModel(lst[i].C_ID);
                mod.N_XM_SORT = i + 1;
                mod.D_XM_START_TIME = lst[i].D_XM_START_TIME;
                if (Convert.ToDateTime(mod.D_XM_CAN_START_TIME) > mod.D_XM_START_TIME)
                {
                    MessageBox.Show("序号(" + lst[i].N_XM_SORT + ")" + "修磨开始时间不能在钢坯可修磨时间之前");
                    return;
                }
                //if (mod.C_HL == "N")
                //{
                //    if (mod.D_KP_END_TIME == null)
                //    {
                //        if (Convert.ToDateTime(mod.D_P_END_TIME).AddHours(26) > mod.D_XM_START_TIME)
                //        {
                //            MessageBox.Show("序号(" + lst[i].N_XM_SORT + ")" + "修磨开始时间不能在连铸生产时间后26小时之前");
                //            return;
                //        }
                //    }
                //    else
                //    {
                //        if (Convert.ToDateTime(mod.D_KP_END_TIME).AddHours(26) > mod.D_XM_START_TIME)
                //        {
                //            MessageBox.Show( ",序号(" + lst[i].N_XM_SORT + ")" + "修磨开始时间不能在开坯结束时间后26小时之前");
                //            return;
                //        }
                //    }
                //}
                //else
                //{
                //    if (Convert.ToDateTime(mod.D_HL_END_TIME).AddHours(2) > mod.D_XM_START_TIME)
                //    {
                //        MessageBox.Show(",序号(" + lst[i].N_XM_SORT + ")" + "修磨时间不能在热轧坯缓冷结束时间后2个小时之前");
                //        return;
                //    }
                //}
                //double sl = Convert.ToDouble(lst[i].N_SLAB_WGT) / 16.7;
                //lst[i].D_XM_END_TIME = Convert.ToDateTime(lst[i].D_XM_START_TIME).AddHours(sl);
                //time = Convert.ToDateTime(mod.D_XM_END_TIME);
                mod.D_XM_END_TIME = lst[i].D_XM_END_TIME;
                bll.Update(mod);
            }
            string result = bll.P_SLAB_CAN_USETIMEG();
            BindInfo();
            WaitingFrom.CloseWait();
        }

        //private void btn_QR_Click(object sender, EventArgs e)
        //{
        //    WaitingFrom.ShowWait("");
        //    int[] row = gv_GP.GetSelectedRows();
        //    foreach (var item in row)
        //    {
        //        string id = gv_GP.GetRowCellValue(item, "C_ID").ToString();
        //        Mod_TSP_PLAN_SMS mod = bll.GetModel(id);
        //        mod.C_XM_ID = cbo_KP.EditValue.ToString();
        //        bll.Update(mod);
        //    }
        //    MessageBox.Show("确认成功");
        //    WaitingFrom.CloseWait();
        //    BindInfo();
        //}

        private void btn_SX_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            DateTime st = dt_KSSJ.DateTime;
            DateTime time = dt_KSSJ.DateTime;
            lst = lst.OrderBy(x => x.D_XM_CAN_START_TIME).ToList();
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].N_XM_SORT = i + 1;
                if (i == 0)
                {
                    lst[i].D_XM_START_TIME = st;
                    if (Convert.ToDateTime(lst[i].D_XM_CAN_START_TIME) > lst[i].D_XM_START_TIME)
                    {
                        lst[i].D_XM_START_TIME = lst[i].D_XM_CAN_START_TIME;
                    }
                }
                else
                {
                    lst[i].D_XM_START_TIME = time;
                    if (Convert.ToDateTime(lst[i].D_XM_CAN_START_TIME) > lst[i].D_XM_START_TIME)
                    {
                        lst[i].D_XM_START_TIME = lst[i].D_XM_CAN_START_TIME;
                    }

                }
                string length = (Convert.ToDecimal(lst[i].C_SLAB_LENGTH) / 1000).ToString();
                string gz = lst[i].C_BXGGZ;
                double jscn = 4.17;
                string cn = bll.GetBXGXMJSCN(lst[i].C_STL_GRD, lst[i].C_SLAB_SIZE, Convert.ToInt32(lst[i].C_SLAB_LENGTH), gz);
                if (cn == "")
                {
                    if (gz.Contains("A"))
                    {
                        jscn = 2;
                    }
                    else if (gz.Contains("B"))
                    {
                        jscn = 4.2;
                    }
                    else if (gz.Contains("C"))
                    {
                        jscn = 6.7;
                    }
                    else if (gz.Contains("E"))
                    {
                        jscn = 2.2;
                    }
                    else
                    {
                        jscn = 4;
                    }
                }
                else
                {
                    jscn = Convert.ToDouble(cn);
                }
                double sl = Convert.ToDouble(lst[i].N_XM_WGT) / jscn;
                lst[i].D_XM_END_TIME = Convert.ToDateTime(lst[i].D_XM_START_TIME).AddHours(sl);
                time = Convert.ToDateTime(lst[i].D_XM_END_TIME);
            }
            WaitingFrom.CloseWait();
            this.gc_GP.DataSource = lst;
            gv_GP.RefreshData();
        }

        private void btn_SXHLSJ_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bll.GetListByXM("", "不锈钢").Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                Mod_TSP_PLAN_SMS mod = bll.GetModel(item["C_ID"].ToString());
                if (mod.C_HL == "Y")
                {
                    if (mod.D_KP_END_TIME == null)
                    {
                        mod.D_HL_START_TIME = Convert.ToDateTime(mod.D_P_END_TIME).AddHours(2);
                        mod.D_HL_END_TIME = Convert.ToDateTime(mod.D_HL_START_TIME).AddHours(Convert.ToDouble(mod.N_HL_TIME));
                    }
                    else
                    {
                        mod.D_HL_START_TIME = Convert.ToDateTime(mod.D_KP_END_TIME).AddHours(2);
                        mod.D_HL_END_TIME = Convert.ToDateTime(mod.D_HL_START_TIME).AddHours(Convert.ToDouble(mod.N_HL_TIME));
                    }

                    bll.Update(mod);
                }
            }
            WaitingFrom.CloseWait();
            BindInfo();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            if (txt_HH.Text == "" || txt_HH.Text.Trim() == "0")
            {
                MessageBox.Show("行号不能为空或为0");
                return;
            }
            int[] row = gv_GP.GetSelectedRows();
            //DateTime st = Convert.ToDateTime(lst[0].D_XM_START_TIME);
            DateTime st = dt_KSSJ.DateTime;
            int bj1 = 0;
            int bj2 = 0;
            foreach (var item in row.Reverse())
            {
                int hang = item;
                if (item >= Convert.ToInt32(txt_HH.Text) - 1)
                {
                    if (bj1 != 0)
                    {
                        hang = hang + bj1;
                    }
                    bj1++;
                }
                else
                {
                    bj2++;
                }


                var plan1 = gv_GP.GetRow(hang) as Mod_TSP_PLAN_SMS;
                if (item < lst.Count)
                {
                    //hang = hang < 0 ? 0 : hang;
                    if (hang >= gv_GP.RowCount)
                    {
                        hang = gv_GP.RowCount - 1;
                    }
                    var plan2 = gv_GP.GetRow(Convert.ToInt32(txt_HH.Text) - bj2) as Mod_TSP_PLAN_SMS;
                    if (plan2 == null)
                        return;
                    lst.Remove(plan1);
                    var left = lst.TakeWhile(x => x.N_XM_SORT < plan2.N_XM_SORT).ToList();
                    var right = lst.Where(x => left.Contains(x) == false).ToList();
                    if (bj2 == 0)
                    {
                        plan2 = gv_GP.GetRow(Convert.ToInt32(txt_HH.Text) - 1) as Mod_TSP_PLAN_SMS;
                        left = lst.TakeWhile(x => x.N_XM_SORT < plan2.N_XM_SORT).ToList();
                        right = lst.Where(x => left.Contains(x) == false).ToList();
                    }
                    else
                    {
                        left = lst.TakeWhile(x => x.N_XM_SORT <= plan2.N_XM_SORT).ToList();
                        right = lst.Where(x => left.Contains(x) == false).ToList();
                    }
                    lst.Clear();
                    lst.AddRange(left);
                    lst.Add(plan1);
                    lst.AddRange(right);
                }
                else
                {
                    lst.Remove(plan1);
                    lst.Add(plan1);
                }

                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i].N_XM_SORT = i + 1;
                    if (i == 0)
                    {
                        lst[i].D_XM_START_TIME = st;
                        if (Convert.ToDateTime(lst[i].D_XM_CAN_START_TIME) > lst[i].D_XM_START_TIME)
                        {
                            lst[i].D_XM_START_TIME = lst[i].D_XM_CAN_START_TIME;
                        }

                    }
                    else
                    {
                        lst[i].D_XM_START_TIME = lst[i - 1].D_XM_END_TIME;
                        if (Convert.ToDateTime(lst[i].D_XM_CAN_START_TIME) > lst[i].D_XM_START_TIME)
                        {
                            lst[i].D_XM_START_TIME = lst[i].D_XM_CAN_START_TIME;
                        }

                    }
                    string length = (Convert.ToDecimal(lst[i].C_SLAB_LENGTH) / 1000).ToString();
                    string gz = lst[i].C_BXGGZ;
                    double jscn = 4.17;
                    string cn = bll.GetBXGXMJSCN(lst[i].C_STL_GRD, lst[i].C_SLAB_SIZE, Convert.ToInt32(lst[i].C_SLAB_LENGTH), gz); ;
                    if (cn == "")
                    {
                        if (gz.Contains("A"))
                        {
                            jscn = 2;
                        }
                        else if (gz.Contains("B"))
                        {
                            jscn = 4.2;
                        }
                        else if (gz.Contains("C"))
                        {
                            jscn = 6.7;
                        }
                        else if (gz.Contains("E"))
                        {
                            jscn = 2.2;
                        }
                        else
                        {
                            jscn = 4;
                        }
                    }
                    else
                    {
                        jscn = Convert.ToDouble(cn);
                    }
                    double sl = Convert.ToDouble(lst[i].N_XM_WGT) / jscn;
                    lst[i].D_XM_END_TIME = Convert.ToDateTime(lst[i].D_XM_START_TIME).AddHours(sl);
                }
            }
            gv_GP.RefreshData();
            gv_GP.ClearSelection();
        }

        private void btn_bcGZ_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            int[] row = gv_GP.GetSelectedRows();
            foreach (var item in row)
            {
                string id = gv_GP.GetRowCellValue(item, "C_ID").ToString();
                Mod_TSP_PLAN_SMS mod = bll.GetModel(id);
                mod.C_BXGGZ = icbo_xm.Properties.Items[this.icbo_xm.SelectedIndex].Value.ToString();
                bll.Update(mod);
            }
            MessageBox.Show("已成功修改计划修磨要求！");
            WaitingFrom.CloseWait();
            this.icbo_xm.SelectedIndex = 0;
            BindInfo();
        }

        private void btn_tz_dd_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            int[] row = gv_GP.GetSelectedRows();
            foreach (var item in row)
            {
                string id = gv_GP.GetRowCellValue(item, "C_ID").ToString();
                Mod_TSP_PLAN_SMS mod = bll.GetModel(id);
                mod.C_XM_ID = this.cbo_xmdd2.Text.Trim();
                bll.Update(mod);
            }
            MessageBox.Show("计划修磨地点已调整！");
            WaitingFrom.CloseWait();
            BindInfo();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_GP, "不锈钢修磨计划" + DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
