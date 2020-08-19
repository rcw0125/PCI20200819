using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using RV.MODEL;

namespace RV.DAL
{
	/// <summary>
	/// 数据访问类:TS_USER
	/// </summary>
	public partial class DalTS_USER
	{
		public DalTS_USER()
		{}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ACCOUNT)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TS_USER");
			strSql.Append(" where N_TYPE=3 and C_ACCOUNT=:C_ACCOUNT ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ACCOUNT", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ACCOUNT;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ModTS_USER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TS_USER(");
			strSql.Append("C_NAME,C_ACCOUNT,C_PASSWORD,C_EMAIL,C_MOBILE,N_STATUS,N_TYPE,C_DESC,D_LASTLOGINTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_MOBILE2,C_PHONE,C_SHORTNAME)");
			strSql.Append(" values (");
			strSql.Append(":C_NAME,:C_ACCOUNT,:C_PASSWORD,:C_EMAIL,:C_MOBILE,:N_STATUS,:N_TYPE,:C_DESC,:D_LASTLOGINTIME,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:C_MOBILE2,:C_PHONE,:C_SHORTNAME)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_NAME", OracleDbType.Varchar2,200),
					new OracleParameter(":C_ACCOUNT", OracleDbType.Varchar2,50),
					new OracleParameter(":C_PASSWORD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_EMAIL", OracleDbType.Varchar2,50),
					new OracleParameter(":C_MOBILE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
					new OracleParameter(":N_TYPE", OracleDbType.Int16,1),
					new OracleParameter(":C_DESC", OracleDbType.Varchar2,50),
					new OracleParameter(":D_LASTLOGINTIME", OracleDbType.Date),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,20),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_MOBILE2", OracleDbType.Varchar2,50),
					new OracleParameter(":C_PHONE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_SHORTNAME", OracleDbType.Varchar2,200)};
			parameters[0].Value = model.C_NAME;
			parameters[1].Value = model.C_ACCOUNT;
			parameters[2].Value = model.C_PASSWORD;
			parameters[3].Value = model.C_EMAIL;
			parameters[4].Value = model.C_MOBILE;
			parameters[5].Value = model.N_STATUS;
			parameters[6].Value = model.N_TYPE;
			parameters[7].Value = model.C_DESC;
			parameters[8].Value = model.D_LASTLOGINTIME;
			parameters[9].Value = model.C_EMP_ID;
			parameters[10].Value = model.C_EMP_NAME;
			parameters[11].Value = model.D_MOD_DT;
			parameters[12].Value = model.C_MOBILE2;
			parameters[13].Value = model.C_PHONE;
			parameters[14].Value = model.C_SHORTNAME;

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
		public bool Update(ModTS_USER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TS_USER set ");
			strSql.Append("C_NAME=:C_NAME,");
			strSql.Append("C_ACCOUNT=:C_ACCOUNT,");
			strSql.Append("C_PASSWORD=:C_PASSWORD,");
			strSql.Append("C_EMAIL=:C_EMAIL,");
			strSql.Append("C_MOBILE=:C_MOBILE,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("N_TYPE=:N_TYPE,");
			strSql.Append("C_DESC=:C_DESC,");
			strSql.Append("D_LASTLOGINTIME=:D_LASTLOGINTIME,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_MOBILE2=:C_MOBILE2,");
			strSql.Append("C_PHONE=:C_PHONE,");
			strSql.Append("C_SHORTNAME=:C_SHORTNAME");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_NAME", OracleDbType.Varchar2,200),
					new OracleParameter(":C_ACCOUNT", OracleDbType.Varchar2,50),
					new OracleParameter(":C_PASSWORD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_EMAIL", OracleDbType.Varchar2,50),
					new OracleParameter(":C_MOBILE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
					new OracleParameter(":N_TYPE", OracleDbType.Int16,1),
					new OracleParameter(":C_DESC", OracleDbType.Varchar2,50),
					new OracleParameter(":D_LASTLOGINTIME", OracleDbType.Date),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,20),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_MOBILE2", OracleDbType.Varchar2,50),
					new OracleParameter(":C_PHONE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_SHORTNAME", OracleDbType.Varchar2,200),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
			parameters[0].Value = model.C_NAME;
			parameters[1].Value = model.C_ACCOUNT;
			parameters[2].Value = model.C_PASSWORD;
			parameters[3].Value = model.C_EMAIL;
			parameters[4].Value = model.C_MOBILE;
			parameters[5].Value = model.N_STATUS;
			parameters[6].Value = model.N_TYPE;
			parameters[7].Value = model.C_DESC;
			parameters[8].Value = model.D_LASTLOGINTIME;
			parameters[9].Value = model.C_EMP_ID;
			parameters[10].Value = model.C_EMP_NAME;
			parameters[11].Value = model.D_MOD_DT;
			parameters[12].Value = model.C_MOBILE2;
			parameters[13].Value = model.C_PHONE;
			parameters[14].Value = model.C_SHORTNAME;
			parameters[15].Value = model.C_ID;

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
		public bool Delete(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TS_USER ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string C_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TS_USER ");
			strSql.Append(" where C_ID in ("+C_IDlist + ")  ");
			int rows=DbHelperOra.ExecuteSql(strSql.ToString());
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
        public ModTS_USER GetModel(string C_ACCOUNT, string C_PASSWORD)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_NAME,C_ACCOUNT,C_PASSWORD,C_EMAIL,C_MOBILE,N_STATUS,N_TYPE,C_DESC,D_LASTLOGINTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_MOBILE2,C_PHONE,C_SHORTNAME from TS_USER ");
			strSql.Append(" where N_TYPE=2 and  C_ACCOUNT=:C_ACCOUNT and C_PASSWORD=:C_PASSWORD ");
			OracleParameter[] parameters = {
                    new OracleParameter(":C_ACCOUNT", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_PASSWORD", OracleDbType.Varchar2,50)            };
            parameters[0].Value = C_ACCOUNT;
            parameters[1].Value = C_PASSWORD;

            ModTS_USER model=new ModTS_USER();
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
        public ModTS_USER GetModel(string C_ACCOUNT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_NAME,C_ACCOUNT,C_PASSWORD,C_EMAIL,C_MOBILE,N_STATUS,N_TYPE,C_DESC,D_LASTLOGINTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_MOBILE2,C_PHONE,C_SHORTNAME from TS_USER ");
            strSql.Append(" where N_TYPE=3 and  C_ACCOUNT=:C_ACCOUNT  ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ACCOUNT", OracleDbType.Varchar2,50)           };
            parameters[0].Value = C_ACCOUNT;

            ModTS_USER model = new ModTS_USER();
            DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public ModTS_USER DataRowToModel(DataRow row)
		{
			ModTS_USER model=new ModTS_USER();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_NAME"]!=null)
				{
					model.C_NAME=row["C_NAME"].ToString();
				}
				if(row["C_ACCOUNT"]!=null)
				{
					model.C_ACCOUNT=row["C_ACCOUNT"].ToString();
				}
				if(row["C_PASSWORD"]!=null)
				{
					model.C_PASSWORD=row["C_PASSWORD"].ToString();
				}
				if(row["C_EMAIL"]!=null)
				{
					model.C_EMAIL=row["C_EMAIL"].ToString();
				}
				if(row["C_MOBILE"]!=null)
				{
					model.C_MOBILE=row["C_MOBILE"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["N_TYPE"]!=null && row["N_TYPE"].ToString()!="")
				{
					model.N_TYPE=decimal.Parse(row["N_TYPE"].ToString());
				}
				if(row["C_DESC"]!=null)
				{
					model.C_DESC=row["C_DESC"].ToString();
				}
				if(row["D_LASTLOGINTIME"]!=null && row["D_LASTLOGINTIME"].ToString()!="")
				{
					model.D_LASTLOGINTIME=DateTime.Parse(row["D_LASTLOGINTIME"].ToString());
				}
				if(row["C_EMP_ID"]!=null)
				{
					model.C_EMP_ID=row["C_EMP_ID"].ToString();
				}
				if(row["C_EMP_NAME"]!=null)
				{
					model.C_EMP_NAME=row["C_EMP_NAME"].ToString();
				}
				if(row["D_MOD_DT"]!=null && row["D_MOD_DT"].ToString()!="")
				{
					model.D_MOD_DT=DateTime.Parse(row["D_MOD_DT"].ToString());
				}
				if(row["C_MOBILE2"]!=null)
				{
					model.C_MOBILE2=row["C_MOBILE2"].ToString();
				}
				if(row["C_PHONE"]!=null)
				{
					model.C_PHONE=row["C_PHONE"].ToString();
				}
				if(row["C_SHORTNAME"]!=null)
				{
					model.C_SHORTNAME=row["C_SHORTNAME"].ToString();
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
			strSql.Append("select C_ID,C_NAME,C_ACCOUNT,C_PASSWORD,C_EMAIL,C_MOBILE,N_STATUS,N_TYPE,C_DESC,D_LASTLOGINTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_MOBILE2,C_PHONE,C_SHORTNAME ");
			strSql.Append(" FROM TS_USER ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TS_USER ");
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
				strSql.Append("order by T.C_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TS_USER T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}


        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetUserList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.c_name as 姓名,t.c_account as 用户名,t.c_email as 邮箱,t.c_mobile as 手机号码,(select tt.c_name from ts_user tt where tt.c_account=t.c_emp_id and tt.n_type=3) as 操作人,t.d_mod_dt as 添加时间,tc.角色名称,decode(t.n_status,1,'正常','冻结')as 状态,(select td.c_name from ts_dept td inner join ts_user_dept tsd on td.c_id=tsd.c_dept_id where tsd.c_user_id=t.c_account)as 部门 from TS_USER t left join (select WMSYS.WM_CONCAT(tb.c_role_name)as 角色名称,ta.c_user_id from ts_user_role_pci ta inner join ts_role_pci tb on ta.c_role_id=tb.c_id group by ta.c_user_id)tc on t.c_account=tc.c_user_id where t.n_type=3 ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_NAME,C_ACCOUNT ");
            strSql.Append(" FROM TS_USER where n_type=3 and N_STATUS not in ('4') ");

            return DbHelperOra.Query(strSql.ToString());
        }
    }
}

