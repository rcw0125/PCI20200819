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
    /// <summary>
    /// 2018-04-19 zmc
    /// </summary>
    public partial class FrmQB_WLJYXMPZ : Form
    {

        public FrmQB_WLJYXMPZ()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB1101_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            btn_Query_Click(null, null);
        }
        Bll_TQB_PHYSICS_GROUP bll_PHYSICS_GROUP = new Bll_TQB_PHYSICS_GROUP();
        Bll_TQB_PHYSICS_CONFIGURE bll_PHYSICS_CONFIGURE = new Bll_TQB_PHYSICS_CONFIGURE();
        Bll_TQB_CHARACTER bll_CHARACTER = new Bll_TQB_CHARACTER();

        private string strMenuName;

        /// <summary>
        /// 物理检验项目分组查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                string str = txt_Name.Text.Trim();
                DataTable dt = bll_PHYSICS_GROUP.GetList(str).Tables[0];
                this.gc_wljyfz.DataSource = dt;
                gv_wljyfz.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_wljyfz);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 物理检验项目配置查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_wljyfz_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod();
        }
        /// <summary>
        /// 物理检验项目配置查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewMethod()
        {
            try
            {
                string str = "";
                DataRow dr_wljyfz = this.gv_wljyfz.GetDataRow(this.gv_wljyfz.FocusedRowHandle);
                if (dr_wljyfz != null)
                {
                    str = dr_wljyfz["C_ID"].ToString();
                }

                DataTable dt_wljyxmpz = bll_PHYSICS_CONFIGURE.GetList("a.C_PHYSICS_GROUP_ID = '" + str + "' and a.N_STATUS =1 ").Tables[0];

                string row = "";
                for (int i = 0; i < dt_wljyxmpz.Rows.Count; i++)
                {
                    row += "'" + dt_wljyxmpz.Rows[i]["C_CODE"].ToString() + "',";
                }

                DataTable dt_jcsj = new DataTable();
                if (row.Length > 0)
                {
                    row = row.Substring(0, row.Length - 1);
                    dt_jcsj = bll_CHARACTER.GetCharacterList(row, txt_Name1.Text.Trim()).Tables[0];
                }
                else
                {
                    dt_jcsj = bll_CHARACTER.GetCharacterList("", txt_Name1.Text.Trim()).Tables[0];
                }

                gc_wljyxmpz.DataSource = dt_wljyxmpz;
                gc_jcsj.DataSource = dt_jcsj;

                gv_wljyxmpz.BestFitColumns();
                gv_jcsj.BestFitColumns();

                SetGridViewRowNum.SetRowNum(gv_wljyxmpz);
                SetGridViewRowNum.SetRowNum(gv_jcsj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr_wljyfz = this.gv_wljyfz.GetDataRow(this.gv_wljyfz.FocusedRowHandle);
                DataRow dr_jcsj = this.gv_jcsj.GetDataRow(this.gv_jcsj.FocusedRowHandle);
                if (dr_wljyfz == null) return;
                if (dr_jcsj == null) return;
                Mod_TQB_PHYSICS_CONFIGURE mod = new Mod_TQB_PHYSICS_CONFIGURE();
                mod.C_ID = "";
                mod.C_CHARACTER_ID = dr_jcsj["C_ID"].ToString();
                mod.C_PHYSICS_GROUP_ID = dr_wljyfz["C_ID"].ToString();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                bll_PHYSICS_CONFIGURE.Add(mod);
                MessageBox.Show("添加成功！");
                NewMethod();

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加物理检验性能匹配关系");//添加操作日志
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 基础数据条件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_jcsjQuery_Click(object sender, EventArgs e)
        {
            NewMethod();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("是否取消？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    DataRow dr = this.gv_wljyxmpz.GetDataRow(this.gv_wljyxmpz.FocusedRowHandle);
                    Mod_TQB_PHYSICS_CONFIGURE mod = bll_PHYSICS_CONFIGURE.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll_PHYSICS_CONFIGURE.Update(mod);
                    MessageBox.Show("已取消！");
                    NewMethod();

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消物理检验性能匹配关系");//添加操作日志
                }
                else//如果点击“取消”按钮
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 保存顺序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_wljyxmpz.DataRowCount > 0)
                {
                    Mod_TQB_PHYSICS_CONFIGURE model = new Mod_TQB_PHYSICS_CONFIGURE();

                    for (int i = 0; i < gv_wljyxmpz.DataRowCount; i++)
                    {
                        DataRow dr = this.gv_wljyxmpz.GetDataRow(i);
                        if (!string.IsNullOrEmpty(dr["C_ORDER"].ToString()))
                        {
                            int result = 0;
                            if (!Int32.TryParse(dr["C_ORDER"].ToString(), out result))
                            {
                                MessageBox.Show("第" + (i + 1) + "行顺序号输入错误，只能输入整数！");
                                continue;
                            }
                        }

                        model = bll_PHYSICS_CONFIGURE.GetModel(gv_wljyxmpz.GetRowCellValue(i, "C_ID").ToString());
                        model.C_ORDER = dr["C_ORDER"].ToString();


                        bll_PHYSICS_CONFIGURE.Update(model);
                    }
                    MessageBox.Show("保存成功");
                    NewMethod();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
