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
    public partial class FrmQC_CFXN_ADD : Form
    {
        Bll_TQC_COMPRE_ITEM_RESULT bllTqcCompreItemResult = new Bll_TQC_COMPRE_ITEM_RESULT();
        Bll_TQB_DESIGN_ITEM bllTqbDesignItem = new Bll_TQB_DESIGN_ITEM();

        string str_CHARACTER_ID = "";//项目主键

        string strBatch = "";//批号
        string strGZ = "";//钢种
        string strBZ = "";//标准

        public FrmQC_CFXN_ADD(string str_batch, string str_std_code, string str_stl_grd)
        {
            InitializeComponent();

            strBatch = str_batch;
            strGZ = str_stl_grd;
            strBZ = str_std_code;
        }

        private void FrmQC_CFXN_ADD_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Mod_TQC_COMPRE_ITEM_RESULT modResult = bllTqcCompreItemResult.GetModel(strBatch, strGZ, strBZ);
            if (modResult != null)
            {
                Mod_TQB_DESIGN_ITEM modDesign = bllTqbDesignItem.GetModel(modResult.C_DESIGN_NO, str_CHARACTER_ID);

                if (modDesign == null)
                {
                    MessageBox.Show("标准中没有找到正要添加的这项！");
                    return;
                }
                else
                {
                    Mod_TQC_COMPRE_ITEM_RESULT model = new Mod_TQC_COMPRE_ITEM_RESULT();
                    model.C_STOVE = modResult.C_STOVE;
                    model.C_BATCH_NO = modResult.C_BATCH_NO;
                    model.C_STL_GRD = modResult.C_STL_GRD;
                    model.C_SPEC = modResult.C_SPEC;
                    model.C_STD_CODE = modResult.C_STD_CODE;
                    model.C_CHARACTER_ID = str_CHARACTER_ID;
                    model.C_ITEM_NAME = btn_Name.Text;
                    model.C_TYPE = modDesign.C_TYPE;
                    model.C_UNIT = modDesign.C_UNIT;
                    model.C_QUANTITATIVE = modDesign.C_QUANTITATIVE;
                    model.C_VALUE = txt_Value.Text;
                    model.C_CHECK_STATE = "0";
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.C_DESIGN_NO = modResult.C_DESIGN_NO;
                    model.N_PRINT_ORDER = modDesign.N_PRINT_ORDER;
                    model.C_IS_SHOW = modDesign.C_IS_PRINT;
                    model.C_IS_DECIDE = modDesign.C_IS_DECIDE;

                    if (modDesign.C_TYPE == "成分")
                    {
                        model.C_GROUP = "1";
                    }
                    else
                    {
                        int i_Group = bllTqcCompreItemResult.Get_Max_Group(modResult.C_BATCH_NO, modResult.C_STOVE, modResult.C_STL_GRD, modResult.C_STD_CODE, str_CHARACTER_ID);

                        model.C_GROUP = (i_Group + 1).ToString();
                    }

                    model.C_SOURCE = "1";

                    if (bllTqcCompreItemResult.Add(model))
                    {
                        MessageBox.Show("添加成功！");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("没有找到质量设计信息！");
                return;
            }
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQC_SELECT_CFXN frm = new FrmQC_SELECT_CFXN();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    str_CHARACTER_ID = frm.str_CHARACTER_ID;
                    btn_Name.Text = frm.str_ITEM_NAME;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
