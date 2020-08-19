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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_CFPD_TP : Form
    {
        Bll_TQB_STD_CFXN bllTqbStdCfxn = new Bll_TQB_STD_CFXN();
        Bll_TQC_QUA_RESULT bllTqcQuaResult = new Bll_TQC_QUA_RESULT();
        
        string strStove = "";
        string strStdCode = "";
        string strStlGrd = "";

        public FrmQC_CFPD_TP( string lh, string bz, string gz)
        {
            InitializeComponent();
            
            strStove = lh;
            strStdCode = bz;
            strStlGrd = gz;
        }

        private void FrmQC_CFPD_Load(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void BindInfo()
        {
            try
            {
                txt_LH.Text = strStove;
                txt_BZ.Text = strStdCode;
                txt_GZ.Text = strStlGrd;

                List<Mod_TQB_STD_CFXN> lstStdCf = bllTqbStdCfxn.DataTableToList(bllTqbStdCfxn.Get_CF_List(strStdCode, strStlGrd).Tables[0]);

                int count_cf = bllTqcQuaResult.Get_CF_Count(strStove);
                if (count_cf == 0)
                {
                    MessageBox.Show("没有成分信息！");
                    return;
                }
                else if (count_cf > 1)
                {
                    MessageBox.Show("有多个成分样！");
                    return;
                }

                List<CfInfo> lst = new List<CfInfo>();

                for (int i = 0; i < lstStdCf.Count; i++)
                {
                    double d_value = 0;

                    #region 计算成分值

                    if (lstStdCf[i].C_ITEM_NAME.Contains("+"))
                    {
                        string[] strs = lstStdCf[i].C_ITEM_NAME.Split('+');

                        string s_val = "";

                        for (int m = 0; m < strs.Length; m++)
                        {
                            s_val = bllTqcQuaResult.Get_CF_Value(strStove, strs[m]);
                            if (string.IsNullOrEmpty(s_val))
                            {
                                d_value = double.NaN;
                            }
                            else
                            {
                                d_value = d_value + Convert.ToDouble(s_val);
                            }
                        }

                    }
                    else if (lstStdCf[i].C_ITEM_NAME.Contains("/"))
                    {
                        string[] strs = lstStdCf[i].C_ITEM_NAME.Split('/');

                        string s_val1 = "";
                        string s_val2 = "";
                        double d_val1 = 0;
                        double d_val2 = 0;

                        s_val1 = bllTqcQuaResult.Get_CF_Value(strStove, strs[0]);
                        if (string.IsNullOrEmpty(s_val1))
                        {
                            d_val1= double.NaN;
                        }
                        else
                        {
                            d_val1 = Convert.ToDouble(s_val1);
                        }

                        s_val2 = bllTqcQuaResult.Get_CF_Value(strStove, strs[1]);
                        if (string.IsNullOrEmpty(s_val2))
                        {
                            d_val2 = double.NaN;
                        }
                        else
                        {
                            d_val2 = Convert.ToDouble(s_val2);
                        }

                        if (d_val2 == 0)
                        {
                            d_value = 0;
                        }
                        else
                        {
                            d_value = d_val1 / d_val2;
                        }

                    }
                    else
                    {

                        if (lstStdCf[i].C_ITEM_NAME.ToUpper() == "SIEQ")
                        {
                            double d_val_c = Convert.ToDouble(bllTqcQuaResult.Get_CF_Value(strStove, "C"));
                            double d_val_Si = Convert.ToDouble(bllTqcQuaResult.Get_CF_Value(strStove, "Si"));
                            double d_val_Mn = Convert.ToDouble(bllTqcQuaResult.Get_CF_Value(strStove, "Mn"));
                            double d_val_P = Convert.ToDouble(bllTqcQuaResult.Get_CF_Value(strStove, "P"));
                            double d_val_S = Convert.ToDouble(bllTqcQuaResult.Get_CF_Value(strStove, "S"));

                            d_value = (32.5 * d_val_c + 13.3 * d_val_Si + 6.25 * d_val_Mn +
                     16 * d_val_P + 12 * d_val_S) / 13.3;
                        }
                        else
                        {
                            string s_val1 = "";

                            s_val1 = bllTqcQuaResult.Get_CF_Value(strStove, lstStdCf[i].C_ITEM_NAME);
                            if (string.IsNullOrEmpty(s_val1))
                            {
                                d_value = double.NaN;
                            }
                            else
                            {
                                d_value = Convert.ToDouble(s_val1);
                            }
                        }
                    }

                    #endregion


                    string V_RESULT = "";

                    if (d_value.ToString() == "NaN")
                    {
                        V_RESULT = "没有值";
                    }
                    else
                    {
                        #region 计算小数位数

                        d_value = Math.Round(d_value, Convert.ToInt32(string.IsNullOrEmpty(lstStdCf[i].N_DIGIT.ToString()) ? "0" : lstStdCf[i].N_DIGIT.ToString()));

                        #endregion


                        #region 判断是否合格

                        if (lstStdCf[i].C_IS_DECIDE == "是")
                        {
                            string strTargetMin = string.IsNullOrEmpty(lstStdCf[i].C_TARGET_MIN) ? "0" : lstStdCf[i].C_TARGET_MIN;
                            string strTargetMax = string.IsNullOrEmpty(lstStdCf[i].C_TARGET_MAX) ? "0" : lstStdCf[i].C_TARGET_MAX;

                            if (string.IsNullOrEmpty(d_value.ToString()))
                            {
                                V_RESULT = "数据有误";
                            }
                            else
                            {
                                if (lstStdCf[i].C_TARGET_INTERVAL == "<E<")
                                {
                                    if (Convert.ToDouble(d_value) > Convert.ToDouble(strTargetMin) && Convert.ToDouble(d_value) < Convert.ToDouble(strTargetMax))
                                    {
                                        V_RESULT = "合格";
                                    }
                                    else
                                    {
                                        V_RESULT = "不合格";
                                    }
                                }

                                if (lstStdCf[i].C_TARGET_INTERVAL == "≤E≤")
                                {
                                    if (Convert.ToDouble(d_value) >= Convert.ToDouble(strTargetMin) && Convert.ToDouble(d_value) <= Convert.ToDouble(strTargetMax))
                                    {
                                        V_RESULT = "合格";
                                    }
                                    else
                                    {
                                        V_RESULT = "不合格";
                                    }
                                }


                                if (lstStdCf[i].C_TARGET_INTERVAL == "≤E<")
                                {
                                    if (Convert.ToDouble(d_value) >= Convert.ToDouble(strTargetMin) &&
                      Convert.ToDouble(d_value) < Convert.ToDouble(strTargetMax))
                                    {
                                        V_RESULT = "合格";
                                    }
                                    else
                                    {
                                        V_RESULT = "不合格";
                                    }

                                }

                                if (lstStdCf[i].C_TARGET_INTERVAL == "<E≤")
                                {
                                    if (Convert.ToDouble(d_value) > Convert.ToDouble(strTargetMin) &&
                      Convert.ToDouble(d_value) <= Convert.ToDouble(strTargetMax))
                                    {
                                        V_RESULT = "合格";
                                    }
                                    else
                                    {
                                        V_RESULT = "不合格";
                                    }
                                }

                                if (lstStdCf[i].C_TARGET_INTERVAL == "≤E")
                                {
                                    if (Convert.ToDouble(d_value) >= Convert.ToDouble(strTargetMin))
                                    {
                                        V_RESULT = "合格";
                                    }
                                    else
                                    {
                                        V_RESULT = "不合格";
                                    }
                                }

                                if (lstStdCf[i].C_TARGET_INTERVAL == "<E")
                                {
                                    if (Convert.ToDouble(d_value) > Convert.ToDouble(strTargetMin))
                                    {
                                        V_RESULT = "合格";
                                    }
                                    else
                                    {
                                        V_RESULT = "不合格";
                                    }
                                }

                                if (lstStdCf[i].C_TARGET_INTERVAL == "E≤")
                                {
                                    if (Convert.ToDouble(d_value) <= Convert.ToDouble(strTargetMax))
                                    {
                                        V_RESULT = "合格";
                                    }
                                    else
                                    {
                                        V_RESULT = "不合格";
                                    }
                                }

                                if (lstStdCf[i].C_TARGET_INTERVAL == "E<")
                                {
                                    if (Convert.ToDouble(d_value) < Convert.ToDouble(strTargetMax))
                                    {
                                        V_RESULT = "合格";
                                    }
                                    else
                                    {
                                        V_RESULT = "不合格";
                                    }
                                }
                            }
                        }
                        else
                        {
                            V_RESULT = "不判定";
                        }

                        #endregion
                    }

                    CfInfo modcf = new CfInfo();
                    modcf.C_ITEM_NAME = lstStdCf[i].C_ITEM_NAME;
                    modcf.C_VALUE = d_value.ToString();
                    modcf.C_RESULT = V_RESULT;
                    modcf.C_INTERVAL = lstStdCf[i].C_TARGET_MIN + lstStdCf[i].C_TARGET_INTERVAL + lstStdCf[i].C_TARGET_MAX;

                    lst.Add(modcf);
                }

                gc_CF.DataSource = lst;
                SetGridViewRowNum.SetRowNum(gv_CF);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 浇次基本信息类
        /// </summary>
        class CfInfo
        {
            /// <summary>
            /// 项目名称
            /// </summary>
            public string C_ITEM_NAME { get; set; }

            /// <summary>
            /// 项目值
            /// </summary>
            public string C_VALUE { get; set; }

            /// <summary>
            /// 项目结果
            /// </summary>
            public string C_RESULT { get; set; }

            /// <summary>
            /// 区间
            /// </summary>
            public string C_INTERVAL { get; set; }
        }

        DevExpress.Utils.AppearanceDefault appNotPass1 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Red, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
        DevExpress.Utils.AppearanceDefault appNotPass2 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Yellow, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

        private void gv_CF_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                string strResult = gv_CF.GetRowCellValue(e.RowHandle, "C_RESULT").ToString();

                if (strResult == "不合格")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass1);
                }
                else if (strResult == "数据有误"|| strResult == "没有值")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                }
            }
            catch
            {

            }
        }
    }
}
