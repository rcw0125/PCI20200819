using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Data;

namespace Common
{
    public class UserButtonRight
    {
        /// <summary>
        /// 获取按钮权限
        /// </summary>
        /// <param name="frm">窗体</param>
        public static void GetBtnFun(Form frm, string strMenuID)
        {
            if (RV.UI.UserInfo.userAccount == "system")
            {
                return;
            }

            Bll_TS_MODULE bll = new Bll_TS_MODULE();

            DataTable dt = bll.GetBtnList(frm.Name, RV.UI.UserInfo.userID, strMenuID).Tables[0];

            foreach (Control item in frm.Controls)
            {
                if (item.Controls.Count > 0)
                {
                    GetControls(item, dt);
                }
                else
                {
                    if (item is Button || item is DevExpress.XtraEditors.SimpleButton)
                    {
                        if (item.Text.Trim() == "查询")
                        {
                            item.Enabled = true;
                            continue;
                        }

                        bool ISView = false;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (item.Name == dt.Rows[i]["C_MODULECLASS"].ToString())
                            {
                                ISView = true;

                                break;
                            }
                        }

                        if (ISView)
                        {
                            item.Enabled = true;
                        }
                        else
                        {
                            item.Enabled = false;
                        }

                    }
                }
            }
        }

        private static void GetControls(Control fatherControl, DataTable dt)
        {
            //遍历所有控件
            foreach (Control item in fatherControl.Controls)
            {

                if (item.Controls.Count > 0)
                {
                    GetControls(item, dt);
                }
                else
                {
                    if (item is Button || item is DevExpress.XtraEditors.SimpleButton)
                    {
                        if (item.Text.Trim() == "查询")
                        {
                            item.Enabled = true;
                            continue;
                        }

                        bool ISView = false;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (item.Name == dt.Rows[i]["C_MODULECLASS"].ToString())
                            {
                                ISView = true;

                                break;
                            }
                        }

                        if (ISView)
                        {
                            item.Enabled = true;
                        }
                        else
                        {
                            item.Enabled = false;
                        }

                    }
                }

            }
        }

    }
}
