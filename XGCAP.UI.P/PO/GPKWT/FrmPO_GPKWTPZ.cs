using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;
using Common;

namespace XGCAP.UI.P.PO.GPKWT
{
    public partial class FrmPO_GPKWTPZ : Form
    {
        private Bll_TPB_SLABWH bllTPB_SLABWH = new Bll_TPB_SLABWH();
        private Bll_TPB_SLABWH_AREA bllTPB_SLABWH_AREA = new Bll_TPB_SLABWH_AREA();
        private Bll_TPB_SLABWH_LOC bllTPB_SLABWH_LOC = new Bll_TPB_SLABWH_LOC();
        private Bll_TPB_SLABWH_TIER bllTPB_SLABWH_TIER = new Bll_TPB_SLABWH_TIER();
        private Bll_TPO_GPKWT_LAB bllTPO_GPKWT_LAB = new Bll_TPO_GPKWT_LAB();

        string strs = "";

        public FrmPO_GPKWTPZ()
        {
            InitializeComponent();
        }

        private void FrmPO_GPKWTPZ_Load(object sender, EventArgs e)
        {
            BindCK();
        }

        /// <summary>
        /// 加载标签
        /// </summary>
        private void BindLabel()
        {
            txt_KW.Text = "";
            strs = "";

            panel4.Controls.Clear();

            DataTable dt = bllTPO_GPKWT_LAB.GetList(icbo_CK.EditValue.ToString(), "").Tables[0];

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LabelModule lab = new LabelModule();
                    lab.Name = "labNum_" + dt.Rows[i]["C_LOC_CODE"].ToString();
                    lab.Text = dt.Rows[i]["C_REMARK"].ToString();
                    lab.AccessibleDescription = dt.Rows[i]["C_LOC_CODE"].ToString();
                    lab.Size = new Size(Convert.ToInt32(dt.Rows[i]["C_LAB_WIDTH"].ToString()), Convert.ToInt32(dt.Rows[i]["C_LAB_HEIGHT"].ToString()));
                    lab.Location = new Point(Convert.ToInt32(dt.Rows[i]["C_X_WIRE"].ToString()), Convert.ToInt32(dt.Rows[i]["C_Y_WIRE"].ToString()));
                    this.panel4.Controls.Add(lab);

                    lab.Click += new System.EventHandler(labModule_Click);

                    strs = strs + "'" + dt.Rows[i]["C_LOC_CODE"].ToString() + "',";
                }

            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(icbo_CK.EditValue.ToString()))
                {
                    MessageBox.Show("请选择仓库");
                    gc_KW.DataSource = null;
                    return;
                }
                int[] rownumber = gv_KW.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strCODE = gv_KW.GetRowCellValue(selectedHandle, "C_SLABWH_LOC_CODE").ToString();
                    string strName = gv_KW.GetRowCellValue(selectedHandle, "C_SLABWH_LOC_NAME").ToString();
                    strs = strs + "'" + strCODE + "',";

                    LabelModule lab = new LabelModule();
                    lab.Name = "labNum_" + strCODE;
                    lab.Text = strName;
                    lab.AccessibleDescription = strCODE;
                    lab.Size = new Size(Convert.ToInt32(txt_Width.Text.Trim()), Convert.ToInt32(txt_Height.Text.Trim()));
                    lab.Location = new Point(1, 1);

                    lab.Click += new System.EventHandler(labModule_Click);

                    this.panel4.Controls.Add(lab);
                }

                BindKW();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TPO_GPKWT_LAB model = new Mod_TPO_GPKWT_LAB();
                if (panel4.Controls.Count <= 0)
                {
                    MessageBox.Show("请添加库位信息！");
                    return;
                }
                foreach (Control item in panel4.Controls)
                {
                    if (item is LabelModule)
                    {
                        if (bllTPO_GPKWT_LAB.Exists(item.AccessibleDescription.Trim()))
                        { 
                            model.C_CODE = icbo_CK.EditValue.ToString();
                            model.C_LOC_CODE = item.AccessibleDescription;
                            string str = model.C_LOC_CODE.Substring(0,  model.C_LOC_CODE.Length - 2);
                            model.C_AREA_CODE = str;
                            model.C_REMARK = item.Text;
                            model.C_X_WIRE = item.Left.ToString();
                            model.C_Y_WIRE = item.Top.ToString();
                            model.C_LAB_HEIGHT = item.Height.ToString();
                            model.C_LAB_WIDTH = item.Width.ToString();

                            bllTPO_GPKWT_LAB.Update(model);
                        }
                        else
                        {
                            model.C_LOC_CODE = item.AccessibleDescription;
                            string str = model.C_LOC_CODE.Substring(0,  model.C_LOC_CODE.Length - 2);
                            model.C_CODE = icbo_CK.EditValue.ToString();
                            model.C_AREA_CODE = str;
                            model.C_REMARK = item.Text;
                            model.C_X_WIRE = item.Left.ToString();
                            model.C_Y_WIRE = item.Top.ToString();
                            model.C_LAB_HEIGHT = item.Height.ToString();
                            model.C_LAB_WIDTH = item.Width.ToString();

                            bllTPO_GPKWT_LAB.Add(model);
                        }
                    }
                }
                BindLabel();
                BindKW();
                MessageBox.Show("保存成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (string.IsNullOrEmpty(txt_KW.Text.Trim()))
                {
                    MessageBox.Show("请选择要删除的标签!");
                    return;
                }
                else
                {
                    if (MessageBox.Show("确认删除库位 " + txt_KW.Text.Trim() + " 的标签吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (bllTPO_GPKWT_LAB.Delete(txt_KW.Text.Trim()))
                        {
                            BindLabel();
                            BindKW();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定仓库信息
        /// </summary>
        private void BindCK()
        {
            txt_KW.Text = "";
            strs = "";
            icbo_CK.Properties.Items.Clear();
            DataTable dt = bllTPB_SLABWH.GetListByStatus(1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    icbo_CK.Properties.Items.Add("(" + dt.Rows[i]["C_SLABWH_CODE"].ToString() + ")" + dt.Rows[i]["C_SLABWH_NAME"].ToString(), dt.Rows[i]["C_SLABWH_CODE"].ToString(), -1);
                }

                icbo_CK.SelectedIndex = 0;
            }
            else
            {
                icbo_CK.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 仓库选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void icbo_CK_SelectedIndexChanged(object sender, EventArgs e)
        { 
            BindLabel();
            BindKW();
        }



        private void BindKW()
        {
            DataTable dt = bllTPB_SLABWH_LOC.Get_List(icbo_CK.EditValue.ToString(), strs).Tables[0];
            gc_KW.DataSource = null;
            if (dt == null)
            {
                return;
            }
            gc_KW.DataSource = dt;

            gv_KW.BestFitColumns();
            gv_KW.OptionsSelection.MultiSelect = true;
            gv_KW.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            SetGridViewRowNum.SetRowNum(gv_KW);
        }

        private void labModule_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel4.Controls)
            {
                if (item is LabelModule)
                {
                    if (((LabelModule)sender).Text == item.Text)
                    {
                        ((LabelModule)sender).BackColor = Color.Yellow;
                        txt_KW.Text = ((LabelModule)sender).AccessibleDescription;

                        Mod_TPO_GPKWT_LAB mod = bllTPO_GPKWT_LAB.GetModel(txt_KW.Text.Trim());
                        if (mod != null)
                        {
                            txt_Width.Text = mod.C_LAB_WIDTH;
                            txt_Height.Text = mod.C_LAB_HEIGHT;
                        }
                    }
                    else
                    {
                        item.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void btn_EditLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TPO_GPKWT_LAB mod = bllTPO_GPKWT_LAB.GetModel(txt_KW.Text.Trim());
                if (mod != null)
                {
                    mod.C_LAB_WIDTH = txt_Width.Text.Trim();
                    mod.C_LAB_HEIGHT = txt_Height.Text.Trim();

                    bllTPO_GPKWT_LAB.Update(mod);

                    BindLabel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
