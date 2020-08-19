using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Reflection;
using System.Linq;

using RV.MODEL;
using RV.BLL;

namespace RV.UI
{
    public partial class Main : Form
    {
        //private static string namespaceString = MethodBase.GetCurrentMethod().DeclaringType.Namespace;
        private static string namespaceString = string.Empty;
        private int iconWidth = 16;
        private int iconHeight = 16;
        private Image icon = null;

        private BllTS_MODULE bllModule = new BllTS_MODULE();
        private BllTS_USER_FUN_PCI bllFun = new BllTS_USER_FUN_PCI();

        private DataTable dt = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            IS_RSET = false;

            //初始化窗体皮肤  
            //this.skinEngine1.SkinFile = "MSN.ssk";
            pictureBox1.Top = (panel4.Height - pictureBox1.Height) / 2;
            pictureBox1.Left = (panel4.Width - pictureBox1.Width) / 2;

            icon = Properties.Resources.close;
            iconWidth = icon.Width; iconHeight = icon.Height;

            MyFuncLib.TabList = new ArrayList();

            tabControl1.Visible = false;

            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss yyyy-MM-dd");


            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Start();

            DataTable dtMenuID = bllFun.GetList(" C_FUNCTION_TYPE='1' and C_USER_ID='" + UserInfo.userID + "' ").Tables[0];

            string idStr = string.Empty;

            for (int i = 0; i < dtMenuID.Rows.Count; i++)
            {
                idStr += "'" + dtMenuID.Rows[i]["C_MODULE_ID"].ToString() + "',";
            }

            if (idStr.Length > 0)
            {

                dt = bllModule.GetMenuList(" C_PARENTMODULEID !='0' ", "1", idStr.Substring(0, idStr.Length - 1)).Tables[0];

                //this.nodeList = ModelConvertList<ModTS_MODULE>.ConvertToModel(dt);

                DataTable dt_root = bllModule.GetMenuList(" C_PARENTMODULEID ='0' ", "1", idStr.Substring(0, idStr.Length - 1)).Tables[0];

                //创建根节点
                this.treeView1.Nodes.Clear();//清空节点

                for (int i = 0; i < dt_root.Rows.Count; i++)
                {
                    TreeNode rootNode = new TreeNode();
                    rootNode.Name = dt_root.Rows[i]["C_MODULECLASS"].ToString();
                    rootNode.Text = dt_root.Rows[i]["C_MODULENAME"].ToString();
                    rootNode.Tag = dt_root.Rows[i]["C_ASSEMBLYNAME"].ToString();
                    rootNode.ToolTipText = dt_root.Rows[i]["C_MODULEID"].ToString();

                    rootNode.ImageIndex = Convert.ToInt32(dt_root.Rows[i]["N_IMAGEINDEX"].ToString());
                    rootNode.SelectedImageIndex = Convert.ToInt32(dt_root.Rows[i]["N_IMAGEINDEX"].ToString());
                    this.treeView1.Nodes.Add(rootNode);

                    CreateChildNode(rootNode, dt_root.Rows[i]["C_MODULEID"].ToString());
                }
            }
            else
            {
                //创建根节点
                this.treeView1.Nodes.Clear();//清空节点
            }

            //this.tv.Nodes[0].Expand();//展开一级菜单
            //this.treeView1.ExpandAll();//展开所有菜单
        }


        private void CreateChildNode(TreeNode parentNode, string parentId)
        {
            //找到该节点下的子项（父节点值等于该节点编号）
            var nodes = from dt in dt.AsEnumerable()
                        where dt.Field<string>("C_PARENTMODULEID") == parentId
                        select dt;
            //创建该节点子节点
            foreach (var item in nodes)
            {
                TreeNode node = new TreeNode();
                node.Name = item["C_MODULECLASS"].ToString();
                node.Text = item["C_MODULENAME"].ToString();
                node.Tag = item["C_ASSEMBLYNAME"].ToString();
                node.ToolTipText = item["C_MODULEID"].ToString();

                node.ImageIndex = Convert.ToInt32(item["N_IMAGEINDEX"].ToString());
                node.SelectedImageIndex = Convert.ToInt32(item["N_IMAGEINDEX"].ToString());

                //父节点添加子节点
                parentNode.Nodes.Add(node);
                //调用自身：递归
                CreateChildNode(node, item["C_MODULEID"].ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss yyyy-MM-dd");
        }

        /// <summary>
        /// 显示Form，并进行必要的设置
        /// </summary>
        /// <param name="frm"></param>
        private void showForm(Form frm, string name)
        {
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Parent = this.tabControl1.SelectedTab;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        /// <summary>
        /// 注册Form
        /// </summary>
        /// <param name="tag">是否是窗体</param>
        /// <param name="name">窗体名称</param>
        /// <param name="text">窗体标题</param>
        /// <param name="methodNames">方法名</param>
        private void OpenOrActiveForm(bool isForm, string name, string subName, string text, string methodNames, string strNameSpace, string strMenuID)
        {
            if (!isForm)
                return;
            Boolean isOpen = false;
            foreach (TabPage tabItem in MyFuncLib.TabList)
            {
                if (tabItem.Name.Equals(name) && tabItem.Text.Trim().Equals(text))
                {
                    isOpen = true;
                    this.tabControl1.SelectedTab = tabItem;
                    break;
                }
            }

            if (!isOpen)
            {
                try
                {
                    Form frm = null;
                    Assembly outerAsm = Assembly.LoadFrom(DllPath.strPath + "\\" + strNameSpace);
                    //Assembly outerAsm = Assembly.LoadFrom("E:\\XG\\XGPCI\\XGPCI\\bin\\Debug" + "\\" + strNameSpace);
                    Type outerForm = outerAsm.GetType(name, false);//找到指定窗口

                    string str_CS = bllModule.Get_CS(text, name);

                    UserInfo.menuID = strMenuID;
                    UserInfo.MenuName = text;
                    QueryString.Parameter = str_CS;

                    frm = Activator.CreateInstance(outerForm) as Form;

                    //if (str_CS == "")
                    //{
                    //    frm = Activator.CreateInstance(outerForm) as Form;
                    //}
                    //else
                    //{
                    //    frm = Activator.CreateInstance(outerForm, new string[] { str_CS }) as Form;
                    //}

                    if (frm == null)
                    {
                        MessageBox.Show("未找到指定的程序窗体");
                        return;
                    }

                    TabPage tabPage = new TabPage();
                    tabPage.Name = name;
                    tabPage.Text = text + "  ";
                    tabPage.ToolTipText = name;

                    this.tabControl1.TabPages.Add(tabPage);
                    this.tabControl1.SelectedTab = tabPage;
                    MyFuncLib.TabList.Add(tabPage);


                    frm.Name = name;// 这一行非常重要，当Form的名称不一致时，以菜单中设置的为准，此种情况适用于多级目录
                    frm.Tag = methodNames;
                    showForm(frm, name);// 显示表单
                }
                catch
                {
                    //BllTB_LOG bllLog = new BllTB_LOG();
                    //ModTB_LOG mod = new ModTB_LOG();
                    //mod.C_MENU_NAME = "菜单管理";
                    //mod.C_OPER_CONTEXT = ex.Message.ToString();

                    //bllLog.Add(mod);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tab = ((TabControl)sender).SelectedTab;

            if (tab == null)
            {
                return;
            }
            foreach (TabPage tabItem in MyFuncLib.TabList)
            {
                if (tabItem.Name.Equals(tab.Name) && tabItem.Text.Trim().Equals(tab.Text))
                {
                    this.tabControl1.SelectedTab = tabItem;
                    break;
                }
            }
        }

        private void 左ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;

            pictureBox1.Top = (panel4.Height - pictureBox1.Height) / 2;
            pictureBox1.Left = (panel4.Width - pictureBox1.Width) / 2;
        }

        private void 上下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;

            pictureBox1.Top = (panel4.Height - pictureBox1.Height) / 2;
            pictureBox1.Left = (panel4.Width - pictureBox1.Width) / 2;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                if (!string.IsNullOrEmpty(treeView1.SelectedNode.Name) && !string.IsNullOrEmpty(treeView1.SelectedNode.Tag.ToString()))
                {
                    OpenOrActiveForm(true, treeView1.SelectedNode.Name, string.Empty, treeView1.SelectedNode.Text, string.Empty, treeView1.SelectedNode.Tag.ToString(), treeView1.SelectedNode.ToolTipText);
                    tabControl1.Visible = true;
                }
            }
        }
        const int CLOSE_SIZE = 15;
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = tabControl1.GetTabRect(e.Index);
            if (e.Index == tabControl1.SelectedIndex)    //当前选中的Tab页，设置不同的样式以示选中
            {
                Brush selected_color = Brushes.White; //选中的项的背景色
                g.FillRectangle(selected_color, r); //改变选项卡标签的背景色 
                string title = tabControl1.TabPages[e.Index].Text + "   ";
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X + 3, r.Y + 6));//PointF选项卡标题的位置 
                r.Offset(r.Width - iconWidth - 3, 2);
                g.DrawImage(icon, new Point(r.X - 2, r.Y + 4));//选项卡上的图标的位置 fntTab = new System.Drawing.Font(e.Font, FontStyle.Bold);
            }
            else//非选中的
            {
                Brush selected_color = Brushes.LightGray;
                g.FillRectangle(selected_color, r); //改变选项卡标签的背景色 
                string title = tabControl1.TabPages[e.Index].Text + "   ";
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X + 3, r.Y + 6));//PointF选项卡标题的位置 
                r.Offset(r.Width - iconWidth - 3, 2);
                g.DrawImage(icon, new Point(r.X - 2, r.Y + 4));//选项卡上的图标的位置 
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = e.Location;
                Rectangle r = tabControl1.GetTabRect(tabControl1.SelectedIndex);
                r.Offset(r.Width - iconWidth - 3, 2);
                r.Width = iconWidth;
                r.Height = iconHeight;
                if (r.Contains(p)) //点击特定区域时才发生 
                {
                    MyFuncLib.TabList.Remove(tabControl1.SelectedTab);
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);

                    //MyFuncLib.FrmLsit.Remove(tabControl1.SelectedTab);

                    if (tabControl1.TabPages.Count == 0)
                    {
                        tabControl1.Visible = false;
                    }

                }
            }
        }

        private bool IS_RSET = false;

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IS_RSET = true;
            Application.Restart();
            this.Close();
        }

        private void 关闭所有页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定关闭所有打开的页面吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = tabControl1.TabPages.Count - 1; i >= 0; i--)
                {
                    MyFuncLib.TabList.Remove(tabControl1.TabPages[i]);
                    tabControl1.TabPages.Remove(tabControl1.TabPages[i]);
                }

                if (tabControl1.TabPages.Count == 0)
                {
                    tabControl1.Visible = false;
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IS_RSET)
            {
                if (MessageBox.Show("确定关闭系统吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //this.Close();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void 安全退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定关闭系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                IS_RSET = true;
                this.Close();
            }
            else
            {
                IS_RSET = false;
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditPwd frm = new FrmEditPwd();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void 问题反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://192.168.2.91:809");
        }
    }
}
