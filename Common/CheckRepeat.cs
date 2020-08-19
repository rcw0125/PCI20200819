using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using BLL;

namespace Common
{
    public class CheckRepeat
    {
        /// <summary>
        /// 检测重复
        /// </summary>
        /// <param name="C_MENU_NAME">表名</param>
        /// <param name="C_FORMS_NAME">字段+值</param>
        /// <returns>0没有重复;>0有重复</returns>
        public static int CheckTable(string tableName, Hashtable ht)
        {
            Bll_Common bll = new Bll_Common();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + tableName + " where 1=1 ");

            foreach (DictionaryEntry de in ht)
            {
                if (de.Key.ToString() == "C_ID")
                {
                    strSql.Append(" and nvl(" + de.Key + ",' ') <>nvl('" + de.Value + "',' ')  ");
                }
                else
                {
                    strSql.Append(" and nvl(" + de.Key + ",'-2018') =nvl('" + de.Value + "','-2018')  ");
                }
            }

            return bll.CheckTable(strSql.ToString());
        }
        ///// <summary>
        ///// 检测重复
        ///// </summary>
        ///// <param name="C_MENU_NAME">表名</param>
        ///// <param name="C_FORMS_NAME">字段+值</param>
        ///// <returns>0没有重复;>0有重复</returns>
        //public static int CheckTableBynvl(string tableName, Hashtable ht)
        //{
        //    Bll_Common bll = new Bll_Common();

        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select count(1) from " + tableName + " where N_STATUS=1 ");

        //    foreach (DictionaryEntry de in ht)
        //    {
        //        strSql.Append(" and  nvl(" + de.Key + ",' ') ='" + de.Value + "'  ");
        //    }

        //    return bll.CheckTable(strSql.ToString());
        //}
    }
}
