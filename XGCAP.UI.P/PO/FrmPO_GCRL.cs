using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_GCRL : Form
    {
        public FrmPO_GCRL()
        {
            InitializeComponent();
        }
        private Bll_TPP_INITIALIZE_STA bll_TPP_INITIALIZE_STA = new Bll_TPP_INITIALIZE_STA();//方案初始化工序工位

        private Bll_TPP_INITIALIZE_LINE bll_INI_LINE = new Bll_TPP_INITIALIZE_LINE();//方案初始化的炼钢工艺路线

        private Bll_TB_PRO bllPro = new Bll_TB_PRO();//工序表
        private Bll_TB_STA bllSta = new Bll_TB_STA();//工位表
        private void btn_save_fagw_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认保存当前编辑的工位信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            //清楚当前方案已配置的工位信息
            bool clear1 = bll_TPP_INITIALIZE_STA.DeleteByItemID("");
            //清楚当前方案配置的炼钢工序信息
            bool clear2 = bll_INI_LINE.DeleteByFa("");

            foreach (var c in panel1.Controls)
            {
                if (c is DevExpress.XtraEditors.GroupControl)
                {
                    foreach (var d in ((DevExpress.XtraEditors.GroupControl)c).Controls)
                    {
                        if (d is DevExpress.XtraEditors.CheckedListBoxControl)
                        {
                            DevExpress.XtraEditors.CheckedListBoxControl a = (DevExpress.XtraEditors.CheckedListBoxControl)d;
                            string strGX = a.Tag.ToString();//工序代码
                            string strGXID = bllPro.GetIDByProCode(strGX);//工序主键
                            for (int i = 0; i < a.Items.Count; i++)
                            {
                                if (a.Items[i].CheckState == CheckState.Checked)
                                {
                                    //添加排产工位信息
                                    Mod_TPP_INITIALIZE_STA mod = new Mod_TPP_INITIALIZE_STA();
                                    mod.C_INITIALIZE_ITEM_ID = "";
                                    mod.C_PRO_ID = strGXID;
                                    mod.C_PRO_CODE = strGX;
                                    mod.C_STA_CODE = a.Items[i].Value.ToString();
                                    mod.C_STA_DESC = a.Items[i].Description.ToString();
                                    mod.C_STA_ID = bllSta.GetStaIdByCode(mod.C_STA_CODE);
                                    mod.C_EMP_ID = RV.UI.UserInfo.userName;
                                    bool res = bll_TPP_INITIALIZE_STA.Add(mod);

                                }

                            }

                        }
                    }
                }

                        
            }
            MessageBox.Show("保存成功！");

        }



        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        public void BindIcbo(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByIni(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                cbo.Properties.Items.Add("", "", -1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 加载所有工位信息
        /// </summary>
        /// <param name="cbolst"></param>
        public void BindCbolst(DevExpress.XtraEditors.CheckedListBoxControl cbolst)
        {
            DataTable dt = bllSta.GetListByGXDM(cbolst.Tag.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                cbolst.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbolst.Items.Add(dt.Rows[i]["C_STA_CODE"].ToString(), dt.Rows[i]["C_STA_DESC"].ToString());
                }

            }
        }

        /// <summary>
        /// 页面加载CheckedListBoxControl信息
        /// </summary>
        /// <param name="dd"></param>
        public void BindCbolstInfo(System.Windows.Forms.Panel.ControlCollection dd)
        {
            foreach (var c in dd)
            {
                if (c is DevExpress.XtraEditors.GroupControl)
                {
                    foreach (var d in ((DevExpress.XtraEditors.GroupControl)c).Controls)
                    {
                        if (d is DevExpress.XtraEditors.CheckedListBoxControl)
                        {
                            DevExpress.XtraEditors.CheckedListBoxControl a = (DevExpress.XtraEditors.CheckedListBoxControl)d;
                            BindCbolst(a);
                        }
                    }
                }

               

            }

        }


        /// <summary>
        /// 绑定工位
        /// </summary>
        /// <param name="strInitID">方案主键</param>
        public void BindGWToCheckList(string strInitID)
        {
            foreach (var c in panel1.Controls)
            {
                if (c is DevExpress.XtraEditors.GroupControl)
                {
                    foreach (var d in ((DevExpress.XtraEditors.GroupControl)c).Controls)
                    {
                        if (d is DevExpress.XtraEditors.CheckedListBoxControl)
                        {
                            DevExpress.XtraEditors.CheckedListBoxControl a = (DevExpress.XtraEditors.CheckedListBoxControl)d;
                            string strGX = a.Tag.ToString();
                            DataTable dt = null;
                            dt = bll_TPP_INITIALIZE_STA.GetListByFaid(strGX, strInitID).Tables[0];
                            string idList = "";
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                idList = idList + dt.Rows[i]["C_STA_CODE"].ToString();
                            }
                            for (int i = 0; i < a.Items.Count; i++)
                            {
                                if (idList.Contains(a.Items[i].Value.ToString()))
                                {
                                    a.Items[i].CheckState = CheckState.Checked;

                                }
                                else
                                {
                                    a.Items[i].CheckState = CheckState.Unchecked;
                                }
                            }

                        }
                    }
                }
            }
        }





        private void FrmPO_GCRL_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            BindCbolstInfo(panel1.Controls);

            //根据方案主键加载配置工位信息
            BindGWToCheckList("");


        }



    }
}
