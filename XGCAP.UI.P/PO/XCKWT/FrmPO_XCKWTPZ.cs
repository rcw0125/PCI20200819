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

namespace XGCAP.UI.P.PO.XCKWT
{
    public partial class FrmPO_XCKWTPZ : Form
    {


        private Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        private Bll_TPB_LINEWH bll_linewh = new Bll_TPB_LINEWH();//仓库
        private Bll_TPB_LINEWH_AREA bll_area = new Bll_TPB_LINEWH_AREA();//区域
        private Bll_TPB_LINEWH_LOC bll_loc = new Bll_TPB_LINEWH_LOC();//库位
        private Bll_TPB_LINEWH_TIER bll_tier = new Bll_TPB_LINEWH_TIER();//层
        private Bll_TPO_XCKWT_LAB bll_xckw_lab = new Bll_TPO_XCKWT_LAB();//线材库位图lab

        string strs = "";

        public FrmPO_XCKWTPZ()
        {
            InitializeComponent();
        }

        private void FrmPO_GPKWT_Load(object sender, EventArgs e)
        {
            txt_Width.Text = "80";
            txt_Height.Text = "60";
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

            DataTable dt = bll_xckw_lab.GetList_ID(icbo_CK.Text, "").Tables[0];

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LabelModule lab = new LabelModule();
                    lab.Name = "labNum_" + dt.Rows[i]["C_LOC_CODE"].ToString();
                    lab.Text = dt.Rows[i]["C_LOC_CODE"].ToString();
                    lab.AccessibleDescription = dt.Rows[i]["C_LOC_CODE"].ToString();
                    lab.Size = new Size(Convert.ToInt32(dt.Rows[i]["C_LAB_WIDTH"].ToString()), Convert.ToInt32(dt.Rows[i]["C_LAB_HEIGHT"].ToString()));
                    lab.Location = new Point(Convert.ToInt32(dt.Rows[i]["C_X_WIRE"].ToString()), Convert.ToInt32(dt.Rows[i]["C_Y_WIRE"].ToString()));
                    this.panel4.Controls.Add(lab);

                    lab.Click += new System.EventHandler(labModule_Click);
                    if (dt.Rows[i]["C_LOC_CODE"].ToString().Contains("至"))
                    {
                        string[] spt = dt.Rows[i]["C_LOC_CODE"].ToString().Split('至');


                        for (int kk = Convert.ToInt32(spt[0]); kk <= Convert.ToInt32(spt[1]); kk++)
                        {

                            strs = strs + "'" + kk + "',";
                        }
                    }
                    else
                    {
                        strs = strs + "'" + dt.Rows[i]["C_LOC_CODE"].ToString() + "',";
                    }


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

                if (icbo_CK.Text.Trim() == "")
                {
                    MessageBox.Show("请选择仓库");
                    gc_KW.DataSource = null;
                    return;
                }
                if (chk_LXC.Checked)
                {

                    string conta = "";
                    for (int kk = Convert.ToInt32(icbo_Begin.Text); kk <= Convert.ToInt32(icbo_End.Text); kk++)
                    {
                        if (strs.Contains(kk.ToString()))
                        {
                            conta += kk + ",";
                        }
                    }

                    if (conta.Length > 0)
                    {
                        MessageBox.Show("库位" + conta + "已存在，不能作为零星材添加！");
                        return;
                    }

                    LabelModule lab = new LabelModule();
                    lab.Name = "labNum_" + icbo_Begin.Text + ",labNum_" + icbo_End.Text;
                    lab.Text = icbo_Begin.Text + "至" + icbo_End.Text;
                    lab.AccessibleDescription = icbo_Begin.Text + "," + icbo_End.Text; ;
                    lab.Size = new Size(Convert.ToInt32(txt_Width.Text.Trim()), Convert.ToInt32(txt_Height.Text.Trim()));
                    lab.Location = new Point(1, 1);

                    lab.Click += new System.EventHandler(labModule_Click);

                    this.panel4.Controls.Add(lab);
                }
                else
                {
                    int[] rownumber = gv_KW.GetSelectedRows();//获取选中行号数组；
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        string strCODE = gv_KW.GetRowCellValue(selectedHandle, "C_LINEWH_LOC_CODE").ToString();

                        if (strCODE.Contains("至"))
                        {
                            string[] ss = strCODE.Split('至');

                            for (int kk = Convert.ToInt32(ss[0]); kk <= Convert.ToInt32(ss[1]); kk++)
                            {
                                strs = strs + "'" + kk + "',";
                            }
                        }
                        else
                        {
                            strs = strs + "'" + strCODE + "',";
                        }



                        LabelModule lab = new LabelModule();
                        lab.Name = "labNum_" + strCODE;
                        lab.Text = strCODE;
                        lab.AccessibleDescription = strCODE;
                        lab.Size = new Size(Convert.ToInt32(txt_Width.Text.Trim()), Convert.ToInt32(txt_Height.Text.Trim()));
                        lab.Location = new Point(1, 1);

                        lab.Click += new System.EventHandler(labModule_Click);

                        this.panel4.Controls.Add(lab);
                    }
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

            Mod_TPO_XCKWT_LAB model = new Mod_TPO_XCKWT_LAB();
            if (panel4.Controls.Count <= 0)
            {
                MessageBox.Show("请添加库位信息！");
                return;
            }
            try
            {
                foreach (Control item in panel4.Controls)
                {
                    if (item is LabelModule)
                    {
                        if (bll_xckw_lab.Exists(item.Text.Trim()))
                        {
                            string str = item.Text.Substring(0, item.Text.Length - 2);
                            model.C_CODE = icbo_CK.Text.ToString();
                            model.C_AREA_CODE = str;
                            model.C_LOC_CODE = item.Text;
                            model.C_X_WIRE = item.Left.ToString();
                            model.C_Y_WIRE = item.Top.ToString();
                            model.C_LAB_HEIGHT = item.Height.ToString();
                            model.C_LAB_WIDTH = item.Width.ToString();

                            bll_xckw_lab.Update(model);

                        }
                        else
                        {
                            string str = item.Text.Substring(0, item.Text.Length - 2);
                            model.C_CODE = icbo_CK.Text.ToString();
                            model.C_AREA_CODE = str;
                            model.C_LOC_CODE = item.Text;
                            model.C_X_WIRE = item.Left.ToString();
                            model.C_Y_WIRE = item.Top.ToString();
                            model.C_LAB_HEIGHT = item.Height.ToString();
                            model.C_LAB_WIDTH = item.Width.ToString();

                            bll_xckw_lab.Add(model);

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
            if (string.IsNullOrEmpty(txt_KW.Text.Trim()))
            {
                MessageBox.Show("请选择要删除的标签!");
                return;
            }
            else
            {
                try
                {
                    if (MessageBox.Show("确认删除库位 " + txt_KW.Text.Trim() + " 的标签吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (bll_xckw_lab.Delete(txt_KW.Text.Trim()))
                        {
                            BindLabel();
                            BindKW();

                            MessageBox.Show("删除成功!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            DataTable dt = bll_linewh.GetListByStatus(1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    icbo_CK.Properties.Items.Add(dt.Rows[i]["C_LINEWH_CODE"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
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
            try
            {
             BindLabel(); 
              BindKW();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BindKW()
        {
            icbo_Begin.Properties.Items.Clear();
            icbo_End.Properties.Items.Clear();

            gc_KW.DataSource = null;

            DataTable dt = bll_loc.Get_List(icbo_CK.Text.Trim(), strs).Tables[0];
            if (dt == null)
            {
                return;
            }
            if (chk_LXC.Checked)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        icbo_Begin.Properties.Items.Add(dt.Rows[i]["C_LINEWH_LOC_CODE"].ToString(), dt.Rows[i]["C_LINEWH_LOC_CODE"].ToString(), -1);
                        icbo_End.Properties.Items.Add(dt.Rows[i]["C_LINEWH_LOC_CODE"].ToString(), dt.Rows[i]["C_LINEWH_LOC_CODE"].ToString(), -1);
                    }

                    icbo_Begin.SelectedIndex = 0;
                    icbo_End.SelectedIndex = 1;
                }
            }
            else
            {
                gc_KW.DataSource = dt;
                gv_KW.BestFitColumns();
                gv_KW.OptionsSelection.MultiSelect = true;
                gv_KW.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                SetGridViewRowNum.SetRowNum(gv_KW);
            }


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
                        txt_KW.Text = ((LabelModule)sender).Text;
                        Mod_TPO_XCKWT_LAB mod = bll_xckw_lab.GetModel(txt_KW.Text.Trim());
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
        /// <summary>
        /// 修改标签大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TPO_XCKWT_LAB mod = bll_xckw_lab.GetModel(txt_KW.Text.Trim());
                if (mod != null)
                {
                    mod.C_LAB_WIDTH = txt_Width.Text.Trim();
                    mod.C_LAB_HEIGHT = txt_Height.Text.Trim();

                    bll_xckw_lab.Update(mod);

                    BindLabel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 零星材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_LXC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_LXC.Checked)
                {
                    txt_Width.Text = "150";
                    txt_Height.Text = "80";
                }
                else
                {
                    txt_Width.Text = "80";
                    txt_Height.Text = "60";
                }

                BindKW();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
