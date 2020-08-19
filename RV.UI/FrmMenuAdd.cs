using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using RV.MODEL;
using RV.BLL;

namespace RV.UI
{
    public partial class FrmMenuAdd : Form
    {
        private string strModuleID = "0";
        private bool IsEdit = false;

        private BllTS_MODULE bllModule = new BllTS_MODULE();

        private ModTS_MODULE modModule = null;
        private ModTS_MODULE modPar = null;

        public FrmMenuAdd(string strID, bool bl)
        {
            InitializeComponent();

            strModuleID = strID;

            IsEdit = bl;
        }

        private void FrmMenuAdd_Load(object sender, EventArgs e)
        {
            ShowBll();

            BindInfo();
        }

        private void BindInfo()
        {
            try
            {
                modModule = bllModule.GetModel(strModuleID);

                if (IsEdit)//修改
                {
                    if (modModule != null)
                    {
                        modPar = bllModule.GetModel(modModule.C_PARENTMODULEID);
                        if (modPar != null)
                        {
                            lbl_ParentName.Text = modPar.C_MODULENAME;
                        }
                        else
                        {
                            lbl_ParentName.Text = "";
                        }

                        icbo_ImgIndex.Text = modModule.N_IMAGEINDEX.ToString();
                        txt_ModuleName.Text = modModule.C_MODULENAME.ToString();
                        cbo_BllName.Text = modModule.C_ASSEMBLYNAME.ToString();

                        ShowForm(cbo_BllName.Text);

                        cbo_FrmName.Text = modModule.C_MODULECLASS.ToString();
                        icbo_State.Text = modModule.C_DISABLE.ToString();
                        txt_Parameter.Text = modModule.C_QUERY_STR.ToString();
                    }
                    else
                    {
                        lbl_ParentName.Text = "";
                    }

                }
                else//新增
                {
                    if (modModule != null)
                    {
                        lbl_ParentName.Text = modModule.C_MODULENAME;
                    }
                    else
                    {
                        lbl_ParentName.Text = "";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowBll()
        {
            try
            {
                if (!string.IsNullOrEmpty(DllPath.strPath))
                {
                    string windowsPath = Path.GetFullPath(DllPath.strPath);

                    if (Directory.Exists(windowsPath))
                    {
                        DirectoryInfo folder = new DirectoryInfo(windowsPath);

                        FileInfo[] file = folder.GetFiles("*.dll");

                        if (file.Length > 0)
                        {
                            for (int i = 0; i < file.Length; i++)
                            {
                                if (file[i].Name.Contains("XGCAP.UI"))
                                {
                                    this.cbo_BllName.Properties.Items.Add(file[i].Name);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowForm(string strBllName)
        {
            try
            {
                this.cbo_FrmName.Properties.Items.Clear();
                this.cbo_FrmName.SelectedIndex = -1;

                Assembly assembly = null;
                string windowsPath = DllPath.strPath;
                if (!string.IsNullOrEmpty(windowsPath))
                {
                    if (Directory.Exists(windowsPath))
                    {
                        foreach (string dllFile in Directory.GetFiles(windowsPath, strBllName))
                        {
                            assembly = Assembly.LoadFile(dllFile);
                            Type[] types = assembly.GetTypes();

                            foreach (Type t in types)
                            {
                                if (t.BaseType == typeof(Form))
                                {
                                    this.cbo_FrmName.Properties.Items.Add(t.FullName);
                                }
                            }
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
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)//修改
                {
                    modModule.C_MODULENAME = txt_ModuleName.Text.Trim();
                    modModule.C_ASSEMBLYNAME = cbo_BllName.Text;
                    modModule.C_MODULECLASS = cbo_FrmName.Text;
                    modModule.C_DISABLE = icbo_State.EditValue.ToString();
                    modModule.N_IMAGEINDEX = Convert.ToInt32(icbo_ImgIndex.EditValue.ToString());
                    modModule.C_EMP_ID = UserInfo.userID;
                    modModule.D_MOD_DT = ServerTime.timeNow();
                    modModule.C_QUERY_STR = txt_Parameter.Text.Trim();

                    if (bllModule.Update(modModule))
                    {
                        bllModule.Update(modModule.C_MODULEID, modModule.C_DISABLE);

                        this.Close();
                    }
                }
                else//新增
                {
                    ModTS_MODULE modNew = new ModTS_MODULE();

                    if (modModule != null)
                    {
                        modNew.C_PARENTMODULEID = modModule.C_MODULEID;
                    }
                    else
                    {
                        modNew.C_PARENTMODULEID = "0";
                    }


                    int MaxID = bllModule.GetMaxID();
                    if (MaxID == 0)
                    {
                        MessageBox.Show("无法添加信息！");
                        return;
                    }
                    else
                    {
                        modNew.C_MODULEID = (MaxID + 1).ToString();
                    }

                    modNew.C_MODULENAME = txt_ModuleName.Text.Trim();
                    modNew.C_ASSEMBLYNAME = cbo_BllName.SelectedText;
                    modNew.C_MODULECLASS = cbo_FrmName.SelectedText;
                    modNew.C_DISABLE = icbo_State.EditValue.ToString();
                    modNew.N_IMAGEINDEX = Convert.ToInt32(icbo_ImgIndex.EditValue.ToString());
                    modNew.N_ORDER = bllModule.GetOrder(strModuleID) + 1;
                    modNew.C_EMP_ID = UserInfo.userID;
                    modNew.D_MOD_DT = ServerTime.timeNow();
                    modNew.C_QUERY_STR = txt_Parameter.Text.Trim();

                    if (bllModule.Add(modNew))
                    {
                        MessageBox.Show("添加成功！");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                BllTB_LOG bllLog = new BllTB_LOG();
                ModTB_LOG mod = new ModTB_LOG();
                mod.C_MENU_NAME = "菜单管理";
                mod.C_OPER_CONTEXT = ex.Message.ToString();

                bllLog.Add(mod);
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowForm(cbo_BllName.SelectedText);
        }

        private void FrmMenuAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenuManage frmMenu;
            frmMenu = (FrmMenuManage)this.Owner;
            frmMenu.BindTreeList();
        }
    }
}
