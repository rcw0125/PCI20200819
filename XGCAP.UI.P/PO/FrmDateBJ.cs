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
using MODEL;

namespace XGCAP.UI.P.PO
{
    public partial class FrmDateBJ : Form
    {
        public FrmDateBJ()
        {
            InitializeComponent();
        }

        private Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();
        private Bll_TB_MATRL_MAIN bll_matrl = new Bll_TB_MATRL_MAIN();
        private Bll_TQB_STD_MAIN bll_bz = new Bll_TQB_STD_MAIN();
        DataTable dt1 = null;//NC增量
        DataTable dt2 = null;//本地增量
        private void FrmDateBJ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            NewMethod();
        }

        private void NewMethod()
        {
            WaitingFrom.ShowWait("正在加载。。。");
            dt1 = bll_slab.Get_MINUS1();

            this.gridControl2.DataSource = dt1;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsSelection.MultiSelect = true;
            SetGridViewRowNum.SetRowNum(gridView3);
            this.gridView3.BestFitColumns();

            dt2 = bll_slab.Get_MINUS2();

            this.gridControl3.DataSource = dt2;
            this.gridView4.OptionsView.ColumnAutoWidth = false;
            this.gridView4.OptionsSelection.MultiSelect = true;
            SetGridViewRowNum.SetRowNum(gridView4);
            this.gridView4.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_kctb_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text.Trim()=="")
            {
                MessageBox.Show("请输入炉号！");
                return;
            }
            List<Mod_TSC_SLAB_MAIN> lstnc = Get_GPKNCZS("NC正式库");

            List<Mod_TSC_SLAB_MAIN> lst = lstnc.Where(a => a.C_BATCH_NO == textEdit2.Text.Trim() && a.C_STOVE == textEdit1.Text.Trim()).ToList();
            if (lst != null)
            {
                for (int j = 0; j < lst.Count; j++)
                {
                    bll_slab.Add(lst[j]);
                }
            }

            //同步NC增量数据
            //if (dt1 != null)
            //{
            //    for (int i = 0; i < dt1.Rows.Count; i++)
            //    {
            //        List<Mod_TSC_SLAB_MAIN> lst = lstnc.Where(a=>a.C_BATCH_NO== dt1.Rows[i]["C_BATCH_NO"].ToString()&&a.C_STOVE== dt1.Rows[i]["C_STOVE"].ToString()&&a.C_STL_GRD== dt1.Rows[i]["C_STL_GRD"].ToString()&&a.C_MAT_CODE== dt1.Rows[i]["C_MAT_CODE"].ToString()&&a.C_SLABWH_CODE== dt1.Rows[i]["C_SLABWH_CODE"].ToString()&&a.C_ZYX1== dt1.Rows[i]["C_ZYX1"].ToString()&&a.C_ZYX2== dt1.Rows[i]["C_ZYX2"].ToString()).ToList();
            //        if (lst!=null)
            //        {
            //            for (int j = 0; j < lst.Count; j++)
            //            {
            //                bll_slab.Add(lst[j]);
            //            }
            //        }

            //    }
            //}
            MessageBox.Show("同步完成！");
            NewMethod();
        }



        /// <summary>
        /// 获取NC正式库数据列表
        /// </summary>
        /// <param name="type">NC正式库/测试</param>
        /// <returns></returns>
        public List<Mod_TSC_SLAB_MAIN> Get_GPKNCZS(string type)
        {
            DataTable dtnc = null;

            if (type == "NC正式库")
            {
                dtnc = bll_slab.GetNCGPK();
            }
            else
            {
                dtnc = bll_slab.GetNCCSGPK();
            }
            List<Mod_TSC_SLAB_MAIN> lst = new List<Mod_TSC_SLAB_MAIN>();
            if (dtnc.Rows.Count > 0)
            {
                for (int i = 0; i < dtnc.Rows.Count; i++)
                {
                    string dd = dtnc.Rows[i]["辅数量"].ToString();
                    int num = 0;
                    try
                    {
                        num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(dtnc.Rows[i]["辅数量"].ToString())));//支数
                    }
                    catch (Exception)
                    {
                        num = 10;
                    }
                    string lh = "";
                    string pch = "";
                    if (dtnc.Rows[i]["连铸炉号"].ToString().Trim() != "")
                    {
                        lh = dtnc.Rows[i]["连铸炉号"].ToString();
                        pch = dtnc.Rows[i]["批次号"].ToString();
                    }
                    else
                    {
                        lh = dtnc.Rows[i]["批次号"].ToString();
                        pch = "";
                    }
                    decimal wgt = Convert.ToDecimal(Convert.ToDouble(dtnc.Rows[i]["数量"].ToString())) / Convert.ToDecimal(dtnc.Rows[i]["辅数量"].ToString());//单重
                    Mod_TB_MATRL_MAIN motral = bll_matrl.GetModel(dtnc.Rows[i]["INVCODE"].ToString());
                    string zyx1 = dtnc.Rows[i]["VFREE1"].ToString();//自由项1
                    string zyx2 = dtnc.Rows[i]["VFREE2"].ToString();//自由项2
                    string bz = zyx1.Split('~')[1].Contains("协议") ? zyx2.Split('~')[1] : zyx1.Split('~')[1];//执行标准//
                    string zyx3 = dtnc.Rows[i]["VFREE3"].ToString();//自由项3
                    DateTime wedate = Convert.ToDateTime(dtnc.Rows[i]["生产入库日期"].ToString());//生产入库时间
                    string wlid = dtnc.Rows[i]["INVCODE"].ToString();//物料编码
                    string wumc = dtnc.Rows[i]["INVNAME"].ToString();//物料名称
                    string hw = dtnc.Rows[i]["STORCODE"].ToString();//仓库
                    Mod_TQB_STD_MAIN modbz = bll_bz.GetModel(motral.C_STL_GRD, zyx1, zyx2);
                    for (int j = 0; j < num; j++)
                    {
                        Mod_TSC_SLAB_MAIN mod = new Mod_TSC_SLAB_MAIN();
                        mod.C_PLAN_ID = type;
                        mod.C_STOVE = lh;
                        mod.C_ID = System.Guid.NewGuid().ToString();
                        mod.C_BATCH_NO = pch;

                        if (mod.C_STOVE == "24")
                        {
                            mod.C_STA_ID = "890EAA2949E743AFB26C06B8D4209B17";
                            mod.C_STA_CODE = "3#CC";
                            mod.C_STA_DESC = "3#铸机";
                        }
                        else if (mod.C_STOVE == "23")
                        {
                            mod.C_STA_ID = "5263048C90B44B4D9934C513CE028250";
                            mod.C_STA_CODE = "4#CC";
                            mod.C_STA_DESC = "4#铸机";
                        }
                        else if (mod.C_STOVE == "61")
                        {
                            mod.C_STA_ID = "01C145B259E740F6A258AF313DD9268C";
                            mod.C_STA_CODE = "6#CC";
                            mod.C_STA_DESC = "6#铸机";
                        }
                        else
                        {
                            mod.C_STA_ID = "77B9FDA79B884D07AA2B3601D1DA11A2";
                            mod.C_STA_CODE = "5#CC";
                            mod.C_STA_DESC = "5#铸机";
                        }
                        mod.D_WE_DATE = wedate;
                        mod.C_MAT_CODE = wlid;
                        mod.C_MAT_NAME = wumc;
                        mod.C_SPEC = motral.C_SLAB_SIZE; ;
                        mod.N_LEN = motral.N_LTH;
                        mod.C_STL_GRD = motral.C_STL_GRD;
                        mod.N_WGT = wgt;
                        mod.C_SCUTCHEON = "白牌";
                        mod.N_QUA = 1;
                        if (modbz != null)
                        {
                            mod.C_STD_CODE = modbz.C_STD_CODE;
                        }
                        if (mod.C_STD_CODE == "")
                        {
                            mod.C_STD_CODE = bz.Replace(" ", "").Replace("（", "(").Replace("）", ")");
                        }
                        mod.C_MOVE_TYPE = "M";
                        mod.D_CCM_DATE = wedate.AddHours(-2);
                        mod.C_STOCK_STATE = "F";
                        mod.C_MAT_TYPE = "合格品";
                        mod.C_JUDGE_LEV_ZH = "合格品";
                        //mod.C_ISXM = "N";
                        mod.C_ZYX1 = zyx1;
                        mod.C_ZYX2 = zyx2;
                        mod.C_IS_QR = "Y";
                        mod.C_SLABWH_CODE = hw;
                        lst.Add(mod);
                    }
                }

                return lst;
            }
            return null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //删除本地增量数据
            if (dt2 != null)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    bll_slab.deletebywhere(dt2.Rows[i]["C_BATCH_NO"].ToString(), dt2.Rows[i]["C_STOVE"].ToString(), dt2.Rows[i]["C_STL_GRD"].ToString(), dt2.Rows[i]["C_MAT_CODE"].ToString(), dt2.Rows[i]["C_SLABWH_CODE"].ToString(), dt2.Rows[i]["C_ZYX1"].ToString(), dt2.Rows[i]["C_ZYX2"].ToString());
                }
            }

            NewMethod();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_order_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gridControl2);
        }

        private void btn_out_right_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gridControl3);
        }
    }
}
