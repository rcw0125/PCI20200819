using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using RV.MODEL;
using System.Collections;
using System.Collections.Generic;

namespace RV.DAL
{
	/// <summary>
	/// 数据访问类:TS_ROLE_FUN_PCI
	/// </summary>
	public partial class DalTS_ROLE_FUN_PCI
	{
		public DalTS_ROLE_FUN_PCI()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ModTS_ROLE_FUN_PCI model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TS_ROLE_FUN_PCI(");
			strSql.Append("C_ID,C_MODULE_ID,C_ROLE_ID,C_FUNCTION_TYPE,D_MOD_DT)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_MODULE_ID,:C_ROLE_ID,:C_FUNCTION_TYPE,:D_MOD_DT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_MODULE_ID", OracleDbType.Varchar2,20),
					new OracleParameter(":C_ROLE_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_FUNCTION_TYPE", OracleDbType.Varchar2,5),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_MODULE_ID;
			parameters[2].Value = model.C_ROLE_ID;
			parameters[3].Value = model.C_FUNCTION_TYPE;
			parameters[4].Value = model.D_MOD_DT;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ModTS_ROLE_FUN_PCI model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TS_ROLE_FUN_PCI set ");
			strSql.Append("C_ID=:C_ID,");
			strSql.Append("C_MODULE_ID=:C_MODULE_ID,");
			strSql.Append("C_ROLE_ID=:C_ROLE_ID,");
			strSql.Append("C_FUNCTION_TYPE=:C_FUNCTION_TYPE,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_MODULE_ID", OracleDbType.Varchar2,20),
					new OracleParameter(":C_ROLE_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_FUNCTION_TYPE", OracleDbType.Varchar2,5),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_MODULE_ID;
			parameters[2].Value = model.C_ROLE_ID;
			parameters[3].Value = model.C_FUNCTION_TYPE;
			parameters[4].Value = model.D_MOD_DT;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TS_ROLE_FUN_PCI ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ModTS_ROLE_FUN_PCI GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_MODULE_ID,C_ROLE_ID,C_FUNCTION_TYPE,D_MOD_DT from TS_ROLE_FUN_PCI ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			ModTS_ROLE_FUN_PCI model=new ModTS_ROLE_FUN_PCI();
			DataSet ds=DbHelperOra.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ModTS_ROLE_FUN_PCI DataRowToModel(DataRow row)
		{
			ModTS_ROLE_FUN_PCI model=new ModTS_ROLE_FUN_PCI();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_MODULE_ID"]!=null)
				{
					model.C_MODULE_ID=row["C_MODULE_ID"].ToString();
				}
				if(row["C_ROLE_ID"]!=null)
				{
					model.C_ROLE_ID=row["C_ROLE_ID"].ToString();
				}
				if(row["C_FUNCTION_TYPE"]!=null)
				{
					model.C_FUNCTION_TYPE=row["C_FUNCTION_TYPE"].ToString();
				}
				if(row["D_MOD_DT"]!=null && row["D_MOD_DT"].ToString()!="")
				{
					model.D_MOD_DT=DateTime.Parse(row["D_MOD_DT"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ta.C_ID,ta.C_MODULE_ID,ta.C_ROLE_ID,ta.C_FUNCTION_TYPE,ta.D_MOD_DT ");
			strSql.Append(" FROM TS_USER_FUN_PCI ta inner join ts_module tb on ta.c_module_id=tb.c_moduleid where tb.c_disable='1 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TS_ROLE_FUN_PCI ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperOra.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from TS_ROLE_FUN_PCI T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

        /// <summary>
        /// 保存角色权限
        /// </summary>
        /// <param name="lstCheckedID">按钮ID集合</param>
        /// <param name="dt">菜单ID集合</param>
        /// <param name="RoleID">角色ID</param>
        /// <returns></returns>
        public bool SaveFun(List<string> lstCheckedID, DataTable dt, string RoleID)
        {
            ArrayList SQLStringList = new ArrayList();

            SQLStringList.Add(" delete from TS_ROLE_FUN_PCI where C_ROLE_ID='" + RoleID + "' ");

            foreach (string id in lstCheckedID)
            {
                SQLStringList.Add(" insert into TS_ROLE_FUN_PCI(C_MODULE_ID, C_ROLE_ID, C_FUNCTION_TYPE)values('" + id + "','" + RoleID + "','2') ");
            }


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SQLStringList.Add(" insert into TS_ROLE_FUN_PCI(C_MODULE_ID, C_ROLE_ID, C_FUNCTION_TYPE)values('" + dt.Rows[i]["C_MODULEID"].ToString() + "','" + RoleID + "','1') ");
            }

            return DbHelperOra.ExecuteSqlTran(SQLStringList);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

