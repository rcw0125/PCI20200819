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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_CFLR : Form
    {
        private Bll_TQC_QUA_RESULT bllTqcQuaResult = new Bll_TQC_QUA_RESULT();
        private Bll_TQB_CHARACTER bllTqbCharacter = new Bll_TQB_CHARACTER();

        private string C_STOVE = "";
        private string C_ANANO = "";
        private string C_COMMISSIONID = "";
        private string C_SAMPID = "";

        private DataTable dt_Item;

        public FrmQC_CFLR()
        {
            InitializeComponent();
        }

        private void FrmQC_CFLR_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Stove.Text.Trim()))
            {
                MessageBox.Show("请输入需要查询的炉号！");
                return;
            }

            BindMain();
        }

        /// <summary>
        /// 绑定钢坯样品主信息
        /// </summary>
        private void BindMain()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Main.DataSource = null;

                DataTable dt = bllTqcQuaResult.Get_Main_List(txt_Stove.Text.Trim()).Tables[0];
                gc_Main.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Main);

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        private void gv_Main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Main.GetDataRow(e.FocusedRowHandle);
                if (dr != null)
                {
                    C_STOVE = dr["C_STOVE"].ToString();
                    C_ANANO = dr["C_ANANO"].ToString();
                    C_COMMISSIONID = dr["C_COMMISSIONID"].ToString();
                    C_SAMPID = dr["C_SAMPID"].ToString();

                    //string sType = dr["N_TYPE"].ToString();//0检化验数据；1同步NC数据
                    //if (sType == "0")
                    //{
                    //    btn_Save.Enabled = false;
                    //    btn_Add.Enabled = false;
                    //}
                    //else if (sType == "1")
                    //{
                    //    btn_Save.Enabled = true;
                    //    btn_Add.Enabled = true;
                    //}

                    //btn_Save.Enabled = true;
                    //btn_Add.Enabled = true;


                    BindItem(C_STOVE, C_ANANO, C_COMMISSIONID, C_SAMPID);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 绑定成分
        /// </summary>
        /// <param name="C_STOVE"></param>
        /// <param name="C_ANANO"></param>
        /// <param name="C_COMMISSIONID"></param>
        /// <param name="C_SAMPID"></param>  
        private void BindItem(string str_STOVE, string str_ANANO, string str_COMMISSIONID, string str_SAMPID)
        {
            dt_Item = bllTqcQuaResult.Get_Item_List(str_STOVE, str_ANANO, str_COMMISSIONID, str_SAMPID).Tables[0];
            gc_Item.DataSource = dt_Item;
            SetGridViewRowNum.SetRowNum(gv_Item);
        }

        /// <summary>
        /// 保存成分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataView)gv_Item.DataSource).ToTable();

            string result = bllTqcQuaResult.Save_CF(dt, C_STOVE, C_ANANO, C_COMMISSIONID, C_SAMPID);

            if (result == "1")
            {
                MessageBox.Show("成分保存成功！");
            }
            else
            {
                MessageBox.Show(result);
                return;
            }
        }

        /// <summary>
        /// 查询所有成分基础数据信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_CF_Click(object sender, EventArgs e)
        {
            DataTable dt = bllTqbCharacter.GetList_CF(txt_CF.Text.Trim()).Tables[0];

            gc_CF.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_CF);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr_CF = gv_CF.GetDataRow(gv_CF.FocusedRowHandle);

                if (dr_CF != null)
                {
                    DataRow[] arrRows = dt_Item.Select("C_ANAITEM = '" + dr_CF["C_NAME"] + "' ");

                    if (arrRows.Length > 0)
                    {
                        MessageBox.Show("该成分已存在，不能重复添加！");
                        return;
                    }

                    DataRow dr = dt_Item.NewRow();
                    dr["C_ANAITEM"] = dr_CF["C_NAME"];

                    dt_Item.Rows.Add(dr);

                    gc_Item.DataSource = dt_Item;
                    SetGridViewRowNum.SetRowNum(gv_Item);
                }
                else
                {
                    MessageBox.Show("请选择需要添加的成分！");
                    return;
                }
            }
            catch
            {

            }
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);
                if (dr != null)
                {
                    if (DialogResult.No == MessageBox.Show("确认取消这条记录作为炉号：" + dr["C_STOVE"].ToString() + " 的成分判定样！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    else
                    {
                        if (bllTqcQuaResult.Update(dr["C_STOVE"].ToString(), dr["C_ANANO"].ToString(), dr["C_COMMISSIONID"].ToString(), dr["C_SAMPID"].ToString(), "1"))
                        {
                            MessageBox.Show("操作成功!");
                            BindMain();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请选择需要操作的数据!");
                    return;
                }
            }
            catch
            {

            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);
                if (dr != null)
                {
                    if (DialogResult.No == MessageBox.Show("确认取消这条记录作为炉号：" + dr["C_STOVE"].ToString() + " 的成分判定样！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    else
                    {
                        if (bllTqcQuaResult.Update(dr["C_STOVE"].ToString(), dr["C_ANANO"].ToString(), dr["C_COMMISSIONID"].ToString(), dr["C_SAMPID"].ToString(), "0"))
                        {
                            MessageBox.Show("操作成功!");
                            BindMain();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请选择需要操作的数据!");
                    return;
                }
            }
            catch
            {

            }
        }

        private void gv_Main_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                string strResult = gv_Main.GetRowCellValue(e.RowHandle, "判定样").ToString();
                if (strResult == "是")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
                else
                {

                }
            }
            catch
            {

            }
        }
    }
}
