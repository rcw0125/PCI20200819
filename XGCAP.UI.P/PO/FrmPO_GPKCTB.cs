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
    public partial class FrmPO_GPKCTB : Form
    {
        public FrmPO_GPKCTB()
        {
            InitializeComponent();
        }

        private Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();
        private Bll_TB_STA bll_sta = new Bll_TB_STA();
        private Bll_TB_MATRL_MAIN bll_matrl = new Bll_TB_MATRL_MAIN();
        private Bll_TQB_STD_MAIN bll_bz = new Bll_TQB_STD_MAIN();
        private DataTable dt = null;//NC钢坯库数据
        private Bll_TSC_SLAB_NC bll_nc = new Bll_TSC_SLAB_NC();
        /// <summary>
        /// 数据同步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string stype = "";
            if (this.radioGroup1.SelectedIndex == 1)
            {
                stype = "NC正式库";
            }
            else
            {
                stype = "";
            }
            WaitingFrom.ShowWait("钢坯数据正在同步到本地库存，请稍候...");
            var lst = Get_GPKNCZS(stype);
            for (int i = 0; i < lst.Count; i++)
            {
                bll_slab.Add(lst[i]);
            }
            WaitingFrom.CloseWait();
        }
        List<Mod_TSC_SLAB_MAIN> lstslab = new List<Mod_TSC_SLAB_MAIN>();//本地钢坯库列表
        List<Mod_TSC_SLAB_NC> lstncslab = new List<Mod_TSC_SLAB_NC>();//NC钢坯库数据列表


        /// <summary>
        /// 同步NC测试库钢坯库方法
        /// </summary>
        /// <param name="dt">NC钢坯库数据表单</param>
        public void TBGPK(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string dd = dt.Rows[i]["辅数量"].ToString();
                    int num = 0;
                    try
                    {
                        num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(dt.Rows[i]["辅数量"].ToString())));//支数
                    }
                    catch (Exception)
                    {
                        num = 10;
                    }
                    string lh = dt.Rows[i]["连铸炉号"].ToString();
                    string pch = dt.Rows[i]["批次号"].ToString();

                    decimal wgt = Convert.ToDecimal(Convert.ToDouble(dt.Rows[i]["数量"].ToString())) / Convert.ToDecimal(dt.Rows[i]["辅数量"].ToString());//单重
                    Mod_TB_MATRL_MAIN motral = bll_matrl.GetModel(dt.Rows[i]["INVCODE"].ToString());
                    string zyx1 = dt.Rows[i]["VFREE1"].ToString().Replace(" ", "").Replace("（", "(").Replace("）", ")");//自由项1
                    string zyx2 = dt.Rows[i]["VFREE2"].ToString().Replace(" ", "").Replace("（", "(").Replace("）", ")");//自由项2
                    string bz = zyx1.Split('~')[1].Contains("协议") ? zyx2.Split('~')[1] : zyx1.Split('~')[1];//执行标准//
                    string zyx3 = dt.Rows[i]["VFREE3"].ToString();//自由项3
                    DateTime wedate = Convert.ToDateTime(dt.Rows[i]["生产入库日期"].ToString());//生产入库时间
                    string wlid = dt.Rows[i]["INVCODE"].ToString();//物料编码
                    string wumc = dt.Rows[i]["INVNAME"].ToString();//物料名称
                    string hw = dt.Rows[i]["STORCODE"].ToString();//仓库

                    Mod_TQB_STD_MAIN modbz = bll_bz.GetModel(motral.C_STL_GRD, zyx1, zyx2);
                    for (int j = 0; j < num; j++)
                    {
                        Mod_TSC_SLAB_MAIN mod = new Mod_TSC_SLAB_MAIN();
                        //  mod.C_PLAN_ID = type;
                        mod.C_ID = System.Guid.NewGuid().ToString();
                        if (lh.Trim() != "")
                        {
                            mod.C_STOVE = lh;
                            mod.C_BATCH_NO = dt.Rows[i]["批次号"].ToString();
                        }
                        else
                        {
                            mod.C_STOVE = dt.Rows[i]["批次号"].ToString();
                        }
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
                        mod.D_WE_DATE = Convert.ToDateTime(dt.Rows[i]["生产入库日期"].ToString());
                        mod.C_MAT_CODE = dt.Rows[i]["INVCODE"].ToString();
                        mod.C_MAT_NAME = dt.Rows[i]["INVNAME"].ToString();
                        mod.C_SPEC = motral.C_SLAB_SIZE; ;
                        mod.N_LEN = motral.N_LTH;
                        mod.C_STL_GRD = motral.C_STL_GRD;
                        mod.N_WGT = Convert.ToDecimal(motral.N_HSL);
                        mod.C_SCUTCHEON = "白牌";
                        mod.N_QUA = 1;
                        if (modbz != null)
                        {
                            mod.C_STD_CODE = modbz.C_STD_CODE;
                        }
                        else
                        {
                            mod.C_STD_CODE = bz.Replace("（", "(").Replace("）", ")");
                        }

                        mod.C_MOVE_TYPE = "M";
                        mod.D_CCM_DATE = Convert.ToDateTime(dt.Rows[i]["生产入库日期"].ToString()).AddHours(-2);
                        mod.C_STOCK_STATE = "F";
                        mod.C_MAT_TYPE = "合格品";
                        //mod.C_ISXM = "N";
                        mod.C_ZYX1 = zyx1;
                        mod.C_ZYX2 = zyx2;

                        mod.C_IS_QR = "Y";
                        mod.C_SLABWH_CODE = dt.Rows[i]["STORCODE"].ToString();
                        bll_slab.Add(mod);
                    }


                }
                MessageBox.Show("同步完成！");
            }

        }

        //  var lstlh = lst.Where(a => a.C_STOVE == lh && a.C_BATCH_NO == pch && a.C_SLABWH_LOC_CODE == hw && a.C_ZYX1 == zyx1 && a.C_ZYX2 == zyx2 && a.C_MAT_CODE == wlid && a.C_MAT_NAME == wumc);



        /// <summary>
        /// 查询钢坯库数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在加载库存数据，请稍候...");
            //NC钢坯库数据
            if (this.radioGroup1.SelectedIndex == 0)
            {
                lstncslab = Get_NC_Slab_List("");
            }
            else
            {
                lstncslab = Get_NC_Slab_List("NC正式库");
            }
            this.modTSCSLABMAINBindingSource.DataSource = null;
            this.modTSCSLABMAINBindingSource.DataSource = lstncslab.OrderBy(a => a.C_STOVE);
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsSelection.MultiSelect = true;
            //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView3);
            this.gridView3.BestFitColumns();
            WaitingFrom.CloseWait();

        }


        /// <summary>
        /// 获取本地钢坯库数据
        /// </summary>
        /// <param name="type">1正式库数据，0测试库数据</param>
        /// <returns></returns>
        public List<Mod_TSC_SLAB_MAIN> GetGPK(int type)
        {
            if (type == 1)
            {
                return bll_slab.GetModelList(" C_PLAN_ID IS NOT NULL ");
            }
            else
            {
                return bll_slab.GetModelList(" C_PLAN_ID IS NULL ");
            }

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

                    if(motral==null)
                    {
                        continue;
                    }

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
                        if (modbz!=null)
                        {
                            mod.C_STD_CODE = modbz.C_STD_CODE;
                        }
                        if (mod.C_STD_CODE == "")
                        {
                            mod.C_STD_CODE = bz.Replace(" ", "").Replace("（", "(").Replace("）", ")");
                        }
                        mod.C_MOVE_TYPE = "E";
                        mod.D_CCM_DATE = System.DateTime.Now.AddHours(-2);
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


        /// <summary>
        /// 获取NC正式库数据列表
        /// </summary>
        /// <param name="dt">nc库存数据</param>
        /// <returns></returns>
        public List<Mod_TSC_SLAB_NC> Get_NC_Slab_List(string type)
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
            List<Mod_TSC_SLAB_NC> lst = new List<Mod_TSC_SLAB_NC>();
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

                    if(motral==null)
                    {
                        string ss = dtnc.Rows[i]["INVCODE"].ToString();
                        continue;
                    }

                    string zyx1 = dtnc.Rows[i]["VFREE1"].ToString();//自由项1
                    string zyx2 = dtnc.Rows[i]["VFREE2"].ToString();//自由项2
                    string bz = zyx1.Split('~')[1].Contains("协议") ? zyx2.Split('~')[1] : zyx1.Split('~')[1];//执行标准//
                    string zyx3 = dtnc.Rows[i]["VFREE3"].ToString();//自由项3
                   DateTime wedate = Convert.ToDateTime(dtnc.Rows[i]["生产入库日期"].ToString());//生产入库时间
                    string wlid = dtnc.Rows[i]["INVCODE"].ToString();//物料编码
                    string wumc = dtnc.Rows[i]["INVNAME"].ToString();//物料名称
                    string hw = dtnc.Rows[i]["STORCODE"].ToString();//仓库

                    Mod_TSC_SLAB_NC mod = new Mod_TSC_SLAB_NC();
                    mod.C_PLAN_ID = type;
                    mod.C_STOVE = lh;
                    mod.N_QUA = num;
                    // mod.C_ID = lh;
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
                    mod.N_WGT = Convert.ToDecimal(dtnc.Rows[i]["数量"].ToString());
                    mod.C_SCUTCHEON = "白牌";
                    mod.C_MOVE_TYPE = "M";
                    //mod.D_CCM_DATE = wedate.AddHours(-2);
                    mod.D_CCM_DATE = System.DateTime.Now.AddHours(-2);
                    mod.C_STOCK_STATE = "F";
                    mod.C_MAT_TYPE = "合格品";
                    //mod.C_ISXM = "N";
                    mod.C_ZYX1 = zyx1;
                    mod.C_ZYX2 = zyx2;
                    mod.C_IS_QR = "Y";
                    mod.C_SLABWH_CODE = hw;
                    lst.Add(mod);

                }

                return lst;
            }
            return null;
        }



        /// <summary>
        /// 保存本地
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.radioGroup1.SelectedIndex == 0)//测试库
            {
                bll_nc.DeleteByType("测试");

            }
            else//正式库
            {
                bll_nc.DeleteByType("正式");
            }

            if (lstncslab != null)
            {
                for (int i = 0; i < lstncslab.Count; i++)
                {
                    bll_nc.Add(lstncslab[i]);
                }
            }
        }

        private void btn_query_local_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("数据加载中，请稍候...");
            //本地钢坯库数据
            this.modTSCSLABMAINBindingSource1.DataSource = null;
            lstslab = GetGPK(this.radioGroup1.SelectedIndex);
            this.modTSCSLABMAINBindingSource1.DataSource = lstslab.OrderBy(a => a.C_STOVE);
            this.gridView4.OptionsView.ColumnAutoWidth = false;
            this.gridView4.OptionsSelection.MultiSelect = true;
            //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView4);
            this.gridView4.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            btn_save_Click(null,null);
            FrmDateBJ frm = new FrmDateBJ();
            frm.ShowDialog();
        }

        private void FrmPO_GPKCTB_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }
    }
}
