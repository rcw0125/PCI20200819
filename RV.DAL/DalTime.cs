using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace RV.DAL
{
    public partial class DalTime
    {
        /// <summary>
		/// 获取时间
		/// </summary>
		public string GetTime()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sysdate from dual");
            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
    }
}
