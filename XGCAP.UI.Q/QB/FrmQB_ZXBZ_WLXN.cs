using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_ZXBZ_WLXN : Form
    {
        private Bll_TQB_PHYSICS_GROUP bllTqbPhysicsGroup = new Bll_TQB_PHYSICS_GROUP();
        private Bll_TQB_PHYSICS_GROUP_STD bllTqbPhysicsGroupStd = new Bll_TQB_PHYSICS_GROUP_STD();
        private Bll_TQB_STD_MAIN bllTqbStdMain = new Bll_TQB_STD_MAIN();

        private string strCode = "";
        private string strName = "";
        private string strMenuName;

        public FrmQB_ZXBZ_WLXN()
        {
            InitializeComponent();
        }

        private void FrmQB_ZXBZ_WLXN_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            BindWL();
        }

        /// <summary>
        /// 绑定物理性能分组信息
        /// </summary>
        private void BindWL()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Wl.DataSource = null;
                DataTable dt = bllTqbPhysicsGroup.GetAllList().Tables[0];

                gc_Wl.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Wl);

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 查询（物理性能分组信息）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_WL_Click(object sender, EventArgs e)
        {
            BindWL();
        }

        /// <summary>
        /// 物理性能分组选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Wl_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Wl.GetDataRow(e.FocusedRowHandle);
                if (dr != null)
                {
                    strCode = dr["C_CODE"].ToString();
                    strName = dr["C_NAME"].ToString();

                    BindWLBZ(strCode);
                }
                else
                {
                    gc_Wl_Bz.DataSource = null;
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 绑定物理性能分组和执行标准匹配信息
        /// </summary>
        private void BindWLBZ(string C_PHYSICS_CODE)
        {
            try
            {
                DataTable dt = bllTqbPhysicsGroupStd.Get_List(C_PHYSICS_CODE).Tables[0];
                gc_Wl_Bz.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Wl_Bz);
            }
            catch
            {

            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Wl_Bz.GetDataRow(gv_Wl_Bz.FocusedRowHandle);
                if (dr != null)
                {
                    DialogResult dialogResult = MessageBox.Show("执行标准：'" + dr["C_STD_CODE"].ToString() + "',钢种：'" + dr["C_STL_GRD"].ToString() + "',确认删除该信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (bllTqbPhysicsGroupStd.Delete(dr["C_ID"].ToString()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除物理性能" + strCode + strName + "与执行标准" + dr["C_STD_CODE"].ToString() + "钢种" + dr["C_STL_GRD"].ToString() + "的匹配关系 ");//添加操作日志

                            BindWLBZ(strCode);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要删除的数据！");
                    return;
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 查询执行标准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_STD_Click(object sender, EventArgs e)
        {
            BindStdMain();
        }

        /// <summary>
        /// 查询执行标准
        /// </summary>
        private void BindStdMain()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllTqbStdMain.Get_List(txt_ZXBZ.Text.Trim(), txt_GZ.Text.Trim()).Tables[0];

                gc_Bz.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Bz);

                gv_Bz.OptionsSelection.MultiSelect = true;
                gv_Bz.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 添加匹配关系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_Bz.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("确认添加吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        int num_Success = 0;
                        string strUserID = RV.UI.UserInfo.userID;

                        for (int i = 0; i < rownumber.Length; i++)
                        {
                            string strZXBZ = gv_Bz.GetRowCellValue(rownumber[i], "C_STD_CODE").ToString();
                            string strGZ = gv_Bz.GetRowCellValue(rownumber[i], "C_STL_GRD").ToString();

                            Mod_TQB_PHYSICS_GROUP_STD model = bllTqbPhysicsGroupStd.GetModel(strCode, strZXBZ, strGZ);

                            if (model == null)
                            {
                                model = new Mod_TQB_PHYSICS_GROUP_STD();
                                model.C_PHYSICS_CODE = strCode;
                                model.C_PHYSICS_NAME = strName;
                                model.C_STD_CODE = strZXBZ;
                                model.C_STL_GRD = strGZ;
                                model.C_EMP_ID = strUserID;

                                if (bllTqbPhysicsGroupStd.Add(model))
                                {
                                    num_Success++;

                                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加物理性能" + strCode + strName + "与执行标准" + strZXBZ + "钢种" + strGZ + "的匹配关系 ");//添加操作日志      
                                }
                            }
                        }

                        MessageBox.Show("共{" + rownumber.Length + "}条记录，添加成功{" + num_Success + "}条");

                        BindWLBZ(strCode);
                        BindStdMain();
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要添加的数据");
                    return;
                }
            }
            catch
            {

            }
        }
    }
}
