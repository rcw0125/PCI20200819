using Common;
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
    /// <summary>
    /// 2018-04-25 zmc
    /// </summary>
    public partial class FrmQB_BZWDSC : Form
    {
        public FrmQB_BZWDSC()
        {
            InitializeComponent();
        }
        Bll_TQB_STD_FILE bll_file = new Bll_TQB_STD_FILE();
        Bll_TQB_STD_FILE_TYPE bll_type = new Bll_TQB_STD_FILE_TYPE();

        private string strMenuName;


        string Fil_Name = "";

        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB_BZWDSC_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;

            try
            {
                ItemButtonEdit_Preview.ButtonClick += ItemButtonEdit_Preview_ButtonClick;

                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                DataSet dt = bll_type.GetList("");
                imgcbo_type.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)
                {
                    imgcbo_type.Properties.Items.Add(item["C_FILE_TYPE_NAME"].ToString(), item["C_ID"], -1);
                }
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 选择要上传的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fil_nm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = false;
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "所有PDF|*.pdf;*.PDF";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = fileDialog.FileName;
                    string strName = file.Substring(file.LastIndexOf("\\") + 1);//获取文件名
                    Fil_nm.Text = file;
                    Fil_Name = strName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.Fil_nm.Text.Trim() == "")
            {
                MessageBox.Show("请选择需要上传的PDF文档！");
                return;
            }
            if (this.imgcbo_type.EditValue == null)
            {
                MessageBox.Show("请选择文档类型！");
                return;
            }
            try
            {
                //获取上传文件名称
                string code = FTPUploadAndDown.GetNewFileName(Fil_nm.Text.Trim());
                string newfileName = Fil_Name;
                //上传pdf文件到FTP服务器
                FTPUploadAndDown.ftpUploadFile(Fil_nm.Text, code + ".pdf");
                string ftpPath = "ftp://192.168.2.96/Pdf" + newfileName;
                Mod_TQB_STD_FILE mod = new Mod_TQB_STD_FILE(); 
                mod.C_STD_FILE_TYPE_ID = imgcbo_type.EditValue.ToString();
                mod.C_FILE_NAME = Fil_Name;
                mod.C_STD_FILE_CODE = code;
                mod.C_STD_FILE_PATH = ftpPath;
                
                if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
                {
                    mod.C_STD_FILE_NAME = Fil_Name;
                }
                else
                {
                    mod.C_STD_FILE_NAME = txt_Name.Text.Trim();
                }

                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserName;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll_file.Add(mod);
                NewMethod();

                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);

                MessageBox.Show("上传成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "上传标准文档");//添加操作日志
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
        private void btn_query_Click(object sender, EventArgs e)
        {
            try
            {
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void NewMethod()
        {
            WaitingFrom.ShowWait("");
            string queryName = txt_queryDes.Text;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(txt_queryDes.Text))
            {
                dt = bll_file.GetList("").Tables[0];
            }
            else
            {
                dt = bll_file.GetList("C_FILE_NAME like '%" + queryName + "%'").Tables[0];
            }
            this.gc_StdFileb.DataSource = dt;
            gv_StdFileb.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdFileb);
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {

            // MessageBoxButtons.OKCancel, MessageBoxIcon.Information,MessageBoxIcon.Information

            DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    DataRow dr = this.gv_StdFileb.GetDataRow(this.gv_StdFileb.FocusedRowHandle);
                    if (dr == null) return;
                    Mod_TQB_STD_FILE mod = bll_file.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll_file.Update(mod);
                    NewMethod();
                    MessageBox.Show("已停用！");

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用标准文档信息");//添加操作日志
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else//如果点击“取消”按钮
            {
                return;
            }

        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ItemButtonEdit_Preview_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Bll_TS_SERVER_CONFIG bllConfig = new Bll_TS_SERVER_CONFIG();

            DataRow dr = gv_StdFileb.GetDataRow(gv_StdFileb.FocusedRowHandle);

            if (dr != null)
            {
                Mod_TQB_STD_FILE model = bll_file.GetModel(dr["C_ID"].ToString());
                if (model != null)
                {
                    DataTable dt = bllConfig.GetList(" c_no='N03' ").Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        string strPath = dt.Rows[0]["C_FILE"].ToString() + "\\" + model.C_STD_FILE_CODE + ".pdf";
                        System.Diagnostics.Process.Start(dt.Rows[0]["C_URL"].ToString() + "/index.aspx?inFilePath=" + strPath);
                    }
                }
            }
        }
    }
}
