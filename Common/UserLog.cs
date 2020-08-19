using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using MODEL;
using System.Net;
using System.Net.Sockets;

namespace Common
{
    public class UserLog
    {
        /// <summary>
        /// 添加操作日志
        /// </summary>
        /// <param name="C_MENU_NAME">菜单名</param>
        /// <param name="C_FORMS_NAME">窗体名</param>
        /// <param name="C_FORMS_DESC">窗体描述</param>
        /// <param name="C_OPER_CONTEXT">操作内容</param>
        public static void AddLog(string C_MENU_NAME,string C_FORMS_NAME, string C_FORMS_DESC, string C_OPER_CONTEXT)
        {
            Bll_TB_LOG bllLog = new Bll_TB_LOG();

            Mod_TB_LOG model = new Mod_TB_LOG();

            model.C_IP = GetLocalIP();
            model.C_MENU_NAME = C_MENU_NAME;
            model.C_FORMS_NAME = C_FORMS_NAME;
            model.C_FORMS_DESC = C_FORMS_DESC;
            model.C_OPER_CONTEXT = C_OPER_CONTEXT;
            model.C_EMP_ID = RV.UI.UserInfo.userID;

            bllLog.Add(model);
        }


        /// <summary>
        /// 添加操作日志
        /// </summary>
        /// <param name="C_MENU_NAME">菜单名</param>
        /// <param name="C_FORMS_NAME">窗体名</param>
        /// <param name="C_FORMS_DESC">窗体描述</param>
        /// <param name="C_OPER_CONTEXT">操作内容</param>
        /// <param name="C_REMARK">备注</param>
        public static void AddLog(string C_MENU_NAME, string C_FORMS_NAME, string C_FORMS_DESC, string C_OPER_CONTEXT,string C_REMARK)
        {
            Bll_TB_LOG bllLog = new Bll_TB_LOG();

            Mod_TB_LOG model = new Mod_TB_LOG();

            model.C_IP = GetLocalIP();
            model.C_MENU_NAME = C_MENU_NAME;
            model.C_FORMS_NAME = C_FORMS_NAME;
            model.C_FORMS_DESC = C_FORMS_DESC;
            model.C_OPER_CONTEXT = C_OPER_CONTEXT;
            model.C_EMP_ID = RV.UI.UserInfo.userID;
            model.C_REMARK = C_REMARK;
            bllLog.Add(model);
        }

        /// <summary>
        /// 获取本机IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        return IpEntry.AddressList[i].ToString();
                    }
                }
                return "";
            }
            catch
            {
                return "";
            }

        }
    }
}
