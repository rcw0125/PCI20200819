using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BLL;
namespace Common
{
    public class BindDropDown
    {
        Bll_TB_STD_CONFIG bll_TB_STD_CONFIG = new Bll_TB_STD_CONFIG();
        Bll_TB_MATRL_MAIN bll_TB_MATRL_MAIN = new Bll_TB_MATRL_MAIN();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        /// <summary>
        /// ComboBoxEdit根据钢种加载自由项
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindZYX1(string strGZ, int type, DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_STD_CONFIG.GetZYX(strGZ, type).Tables[0]; ;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["DOCNAME"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// 钢种
        /// </summary>
        /// <returns></returns>
        public DataTable GetGZList()
        {
            DataTable gzdt = bll_TB_MATRL_MAIN.GetGZList().Tables[0];
            return gzdt;
        }
        /// <summary>
        /// ComboBoxEdit加载钢种
        /// </summary>
        /// <param name="cbo">ComboBoxEdit控件</param>
        public void ComboBoxEditBindGZ(DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = GetGZList();
            //cbo.Properties.Items.Add("");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STL_GRD"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }

        }
        /// <summary>
        /// ComboBoxEdit根据钢种加载执行标准
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindBZ(string strGZ, DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = GetZXBZList(strGZ);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STD_CODE"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 执行标准
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DataTable GetZXBZList(string grd)
        {
            DataTable zxbzdt = bll_TQB_STD_MAIN.GetList_STD(grd).Tables[0];
            return zxbzdt;
        }
    }
}
