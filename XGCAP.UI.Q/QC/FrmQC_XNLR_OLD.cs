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
    public partial class FrmQC_XNLR_OLD : Form
    {
        private Bll_TQC_PHYSICS_RESULT bllTqcPhysicsResult = new Bll_TQC_PHYSICS_RESULT();//性能结果
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();//性能结果

        private string strPhyCode;
        private string strMenuName;

        private DataTable dtXN;

        private string str_PHYSICS_GROUP_ID;



        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox_Name = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();


        Bll_TQB_PHYSICS_EQUIPMENT bll_TQB_PHYSICS_EQUIPMENT = new Bll_TQB_PHYSICS_EQUIPMENT();//实验室设备
        Bll_TQB_PHYSICS_GROUP blltqbPhysicsGroup = new Bll_TQB_PHYSICS_GROUP();//物理检验项目分组维护
        public FrmQC_XNLR_OLD()
        {
            InitializeComponent();
        }

        private void FrmQC_XNLR_OLD_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;
                strPhyCode = RV.UI.QueryString.parameter;

                dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

                dt_Start_Result.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dt_End_Result.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

                dtXN = bllTqcPhysicsResult.Get_List(strPhyCode).Tables["ds"];

                if (dtXN.Rows.Count > 0)
                {
                    str_PHYSICS_GROUP_ID = dtXN.Rows[0]["C_PHYSICS_GROUP_ID"].ToString();
                }

                DataTable dt = blltqbPhysicsGroup.GetList_Code(strPhyCode).Tables[0];
                DataTable dt_name = bll_TQB_PHYSICS_EQUIPMENT.GetList_Fid(dt.Rows[0]["C_ID"].ToString()).Tables[0];

                repositoryItemImageComboBox_Name.Items.Clear();
                foreach (DataRow item in dt_name.Rows)//设备名称
                {
                    repositoryItemImageComboBox_Name.Items.Add(item["C_EQ_NAME"].ToString(), item["C_EQ_NAME"], -1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定列表中下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_ZYXX_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                string fieldName = e.Column.FieldName;
                DataRow selectRow = gv_Result.GetDataRow(e.RowHandle);

                if (fieldName == "设备信息")
                {
                    e.RepositoryItem = repositoryItemImageComboBox_Name;
                }
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
            DataTable dt = bllTqcPhysicsResult.Get_List(strPhyCode, txt_BatchNo.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), "0").Tables["ds"];

            gc_ZYXX.DataSource = dt;
            gv_ZYXX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZYXX);
            gv_ZYXX.Columns[9].Width = 300;

            gv_ZYXX.Columns[0].Visible = false;

            gv_ZYXX.OptionsSelection.MultiSelect = true;
            gv_ZYXX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }

        /// <summary>
        /// 查询录入结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Result_Click(object sender, EventArgs e)
        {
            try
            {
                BindResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定性能结果信息
        /// </summary>
        private void BindResult()
        {
            DataTable dt = bllTqcPhysicsResult.Get_List(strPhyCode, txt_BatchNo.Text.Trim(), dt_Start_Result.Text.Trim(), dt_End_Result.Text.Trim(), "1").Tables["ds"];

            gc_Result.DataSource = dt;
            gv_Result.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Result);
            gv_Result.Columns[0].Visible = false;
        }

        /// <summary>
        /// 保存性能录入结果信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = RV.UI.UserInfo.userID;

                int[] rownumber = gv_ZYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    ArrayList SQLStringList = new ArrayList();

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string C_PRESENT_SAMPLES_ID = gv_ZYXX.GetRowCellValue(selectedHandle, "取样主表主键").ToString();

                        Mod_TQC_PRESENT_SAMPLES mod = bllTqcPresentSamples.GetModel(C_PRESENT_SAMPLES_ID);
                        if (mod != null)
                        {
                            mod.C_EQ_NAME = gv_ZYXX.GetRowCellValue(selectedHandle, "设备信息").ToString();
                            bllTqcPresentSamples.Update(mod);
                        }

                        bllTqcPhysicsResult.Delete(str_PHYSICS_GROUP_ID, C_PRESENT_SAMPLES_ID);

                        for (int k = 10; k < gv_ZYXX.Columns.Count; k++)
                        {
                            string strType = "";

                            if (dtXN.Rows[k - 10]["C_CODE"].ToString().Contains("000GCL"))
                            {
                                strType = "0";
                            }
                            else
                            {
                                strType = "1";
                            }

                            if (gv_ZYXX.GetRowCellValue(selectedHandle, gv_ZYXX.Columns[k].FieldName).ToString() != "")
                            {
                                SQLStringList.Add("insert into TQC_PHYSICS_RESULT(C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,C_EMP_ID,N_TYPE)values('" + str_PHYSICS_GROUP_ID + "','" + C_PRESENT_SAMPLES_ID + "','" + dtXN.Rows[k - 10]["C_CHARACTER_ID"].ToString() + "','" + dtXN.Rows[k - 10]["C_CODE"].ToString() + "','" + gv_ZYXX.Columns[k].FieldName + "','" + gv_ZYXX.GetRowCellValue(selectedHandle, gv_ZYXX.Columns[k].FieldName).ToString() + "','" + userID + "','" + strType + "') ");
                            }
                        }
                    }


                    if (bllTqcPhysicsResult.SaveResult(SQLStringList))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存性能信息");//添加操作日志

                        MessageBox.Show("保存成功！");
                        BindZYXX();
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要保存的信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
