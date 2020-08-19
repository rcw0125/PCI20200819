using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;
using Common;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_SELECT_WL_ZXBZ : Form
    {
        string strPlanMatCode = "";
        private Bll_TQB_GP_LCP_BASIS bllTqbGpLcpBasis = new Bll_TQB_GP_LCP_BASIS();
        Bll_TB_MATRL_MAIN bll = new Bll_TB_MATRL_MAIN();

        public FrmQB_SELECT_WL_ZXBZ(string strCode)
        {
            InitializeComponent();

            strPlanMatCode = strCode;
        }

        private void FrmQB_SELECT_WL_ZXBZ_Load(object sender, EventArgs e)
        {
            BindSpec();
        }

        private void BindSpec()
        {
            Mod_TB_MATRL_MAIN model = bll.GetModel(strPlanMatCode);
            if(model!=null)
            {
                txt_spec.Text = model.C_SPEC;
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
                WaitingFrom.ShowWait("");

                DataTable dt = bll.GetList_WL_BZ(txt_Mat_Code.Text, txt_Mat_Name.Text, txt_GRD.Text, txt_spec.Text).Tables[0];
                gc_Matrl.DataSource = dt;
                gv_Matrl.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Matrl);

                gv_Matrl.OptionsSelection.MultiSelect = true;
                gv_Matrl.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_Matrl.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        DataRow dr = gv_Matrl.GetDataRow(selectedHandle);

                        if (dr != null)
                        {
                            bool IsExists = bllTqbGpLcpBasis.Exists(strPlanMatCode, dr["物料编码"].ToString(), dr["钢种"].ToString(), dr["执行标准"].ToString());

                            if (!IsExists)
                            {
                                Mod_TQB_GP_LCP_BASIS model = bllTqbGpLcpBasis.Get_Model(strPlanMatCode);

                                if (model == null)
                                {
                                    model = new Mod_TQB_GP_LCP_BASIS();
                                    model.C_MAT_CODE_PLAN = strPlanMatCode;
                                    model.C_MAT_CODE_GP = dr["物料编码"].ToString();
                                    model.C_STL_GRD = dr["钢种"].ToString();
                                    model.C_STD_CODE = dr["执行标准"].ToString();
                                    model.C_EMP_ID = RV.UI.UserInfo.userID;

                                    bllTqbGpLcpBasis.Add(model);
                                }
                                else
                                {
                                    model.C_MAT_CODE_PLAN = strPlanMatCode;
                                    model.C_MAT_CODE_GP = dr["物料编码"].ToString();
                                    model.C_STL_GRD = dr["钢种"].ToString();
                                    model.C_STD_CODE = dr["执行标准"].ToString();
                                    model.C_EMP_ID = RV.UI.UserInfo.userID;

                                    bllTqbGpLcpBasis.Update(model);
                                }

                            }
                        }
                    }

                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
