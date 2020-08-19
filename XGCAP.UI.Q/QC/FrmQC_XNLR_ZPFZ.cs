using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BLL;
using MODEL;
using Common;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XNLR_ZPFZ : Form
    {
        private Bll_TQC_PHYSICS_RESULT bllTqcPhysicsResult = new Bll_TQC_PHYSICS_RESULT();
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQC_PHYSICS_RESULT_MAIN bllTqcPhyResultMain = new Bll_TQC_PHYSICS_RESULT_MAIN();
        private Bll_TQB_PHYSICS_QUALITATIVE bllTqbPhysicsQualitative = new Bll_TQB_PHYSICS_QUALITATIVE();
        private Bll_TQB_PHYSICS_EQUIPMENT bll_TQB_PHYSICS_EQUIPMENT = new Bll_TQB_PHYSICS_EQUIPMENT();//实验室设备
        private Bll_TQB_PHYSICS_GROUP blltqbPhysicsGroup = new Bll_TQB_PHYSICS_GROUP();//物理检验项目分组维护
        private Bll_TQB_DESIGN_ITEM bllTqbDesignItem = new Bll_TQB_DESIGN_ITEM();


        private string strPhyCode;
        private string strMenuName;

        public FrmQC_XNLR_ZPFZ()
        {
            InitializeComponent();
        }

        private void FrmQC_XNLR_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;
                strPhyCode = RV.UI.QueryString.parameter;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                BindZYXX();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定制样主表信息
        /// </summary>
        private void BindZYXX()
        {
            DataTable dt = bllTqcPresentSamples.GetList_Copy(txt_BatchNo.Text.Trim()).Tables[0];

            gc_ZYXX.DataSource = dt;

            gv_ZYXX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZYXX);

            gv_ZYXX.Columns[10].Caption = "录入人";

        }
        private void BindItem(string strBatchNo)
        {
            DataTable dt = bllTqcPhysicsResult.Get_XNAllList(strBatchNo).Tables[0];

            gc_ITEM.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gv_ITEM);

        }

        /// <summary>
        /// 查询性能值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_ZYXX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gc_ITEM.DataSource = null;
            DataRow dr = this.gv_ZYXX.GetDataRow(this.gv_ZYXX.FocusedRowHandle);
            if (dr == null) return;//判断是否选中线材实绩信息        
            BindItem(dr["批号"].ToString());
            BindRowNum(dr["批号"].ToString());
        }
        /// <summary>
        /// 查询需要复制的批号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BindRowNum(string BatchNo)
        {
            try
            {
                int vs = -1;
                DataTable dt = bllTqcPresentSamples.GetList_Batch(BatchNo).Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i==0)
                    {
                        if (Convert.ToInt32(dt.Rows[i]["批号"]) == Convert.ToInt32(BatchNo))
                        {
                            vs = i;
                            break;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dt.Rows[i - 1]["批号"]) == Convert.ToInt32(dt.Rows[i]["批号"]))
                        {
                            vs = i;
                            break;
                        }
                    }
                }
                if (vs==0)
                {
                    for (int i = dt.Rows.Count - 1; i >= vs; i--)
                    {
                        dt.Rows.RemoveAt(i);
                    }
                }
                

                gc_Copy.DataSource = dt;

                gv_Copy.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Copy);

                gv_Copy.Columns[9].Caption = "录入人";
                gv_Copy.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Copy_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                gc_Item_Copy.DataSource = null;
                DataRow dr = this.gv_Copy.GetDataRow(this.gv_Copy.FocusedRowHandle);
                if (dr == null) return;//判断是否选中线材实绩信息       
                DataTable dt = bllTqcPhysicsResult.Get_XN(dr["取样主表主键"].ToString()).Tables[0];

                gc_Item_Copy.DataSource = dt;

                SetGridViewRowNum.SetRowNum(gv_Item_Copy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Copy_Click(object sender, EventArgs e)
        { 
            int[] number_tick_no = gv_Copy.GetSelectedRows();//获取选中行号数组；
            if (number_tick_no.Length == 0)
            {
                MessageBox.Show("请选择需要确认的信息！");
                return;
            }
            DataRow dr = this.gv_ZYXX.GetDataRow(this.gv_ZYXX.FocusedRowHandle);
            DataTable dt = ((DataView)gv_ZYXX.DataSource).ToTable();
            for (int i = 0; i < number_tick_no.Length; i++)
            { 
                DataRow dr_Num = gv_Copy.GetDataRow(number_tick_no[i]);
                Mod_TQC_PHYSICS_RESULT_MAIN mod = bllTqcPhyResultMain.GetModel(dr_Num["取样主表主键"].ToString());
                mod.C_EQ_NAME = dr["设备名称"].ToString();
                mod.C_TEMP = dr["温度"].ToString();
                mod.C_HUMIDITY = dr["湿度"].ToString();
                mod.N_IS_LR = 1;
                bllTqcPhyResultMain.Update(mod);  
                for (int s = 0; s < dt.Rows.Count; s++)
                {
                    Mod_TQC_PHYSICS_RESULT modResult = new Mod_TQC_PHYSICS_RESULT();
                    modResult.C_PHYSICS_GROUP_ID = dt.Rows[i]["C_PHYSICS_GROUP_ID"].ToString();
                    modResult.C_PRESENT_SAMPLES_ID = dr_Num["取样主表主键"].ToString();
                    modResult.C_CHARACTER_ID = dt.Rows[i]["C_CHARACTER_ID"].ToString();
                    modResult.C_CHARACTER_CODE = dt.Rows[i]["C_CODE"].ToString();
                    modResult.C_CHARACTER_NAME = dt.Rows[i]["C_NAME"].ToString();
                    modResult.C_VALUE = dt.Rows[i]["C_VALUE"].ToString();
                    modResult.C_EMP_ID =RV.UI.UserInfo.UserID;
                    modResult.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    modResult.N_SPLIT = 0;
                    modResult.N_TYPE = 1;
                    modResult.C_CHECK_STATE = "0";
                    modResult.C_TICK_NO = dr_Num["钩号"].ToString();
                    bllTqcPhysicsResult.Add(modResult);
                }
                 
            }
        }
    }
}
