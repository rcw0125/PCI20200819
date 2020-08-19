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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_NC_EDIT : Form
    {
        private Bll_TS_SERVER_CONFIG bllConfig = new Bll_TS_SERVER_CONFIG();
        private Mod_TS_SERVER_CONFIG model = null;

        private string strID = "";

        public FrmQB_NC_EDIT(string str)
        {
            InitializeComponent();

            strID = str;

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void FrmQB_NC_EDIT_Load(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void BindInfo()
        {
            model = bllConfig.GetModel(strID);
            if (model != null)
            {
                txt_Use.Text = model.C_USE;
                txt_Path.Text = model.C_URL;
                txt_DataName.Text = model.C_FILE;
                txt_Name.Text = model.C_USERNAME;
                txt_PassWord.Text = model.C_PASSWORD;
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (model != null)
            {
                model.C_USE = txt_Use.Text;
                model.C_URL = txt_Path.Text;
                model.C_FILE = txt_DataName.Text;
                model.C_USERNAME = txt_Name.Text;
                model.C_PASSWORD = txt_PassWord.Text;

                if (bllConfig.Update(model))
                {
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
