using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_LINEWH_LOC
    /// </summary>
    public partial class Dal_TPB_LINEWH_LOC
    {
        public Dal_TPB_LINEWH_LOC()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_LINEWH_LOC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_LINEWH_LOC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_LINEWH_LOC(");
            strSql.Append(" C_LINEWH_AREA_ID,C_LINEWH_LOC_CODE,C_LINEWH_LOC_NAME,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ISOUT,C_LOADING_MODE,N_QTY)");
            strSql.Append(" values (");
            strSql.Append(" :C_LINEWH_AREA_ID,:C_LINEWH_LOC_CODE,:C_LINEWH_LOC_NAME,:D_START_DATE,:D_END_DATE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_ISOUT,:C_LOADING_MODE,:N_QTY)");
            OracleParameter[] parameters = {
                     new OracleParameter(":C_LINEWH_AREA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ISOUT", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_LOADING_MODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QTY", OracleDbType.Decimal,3)};
            parameters[0].Value = model.C_LINEWH_AREA_ID;
            parameters[1].Value = model.C_LINEWH_LOC_CODE;
            parameters[2].Value = model.C_LINEWH_LOC_NAME;
            parameters[3].Value = model.D_START_DATE;
            parameters[4].Value = model.D_END_DATE;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_ISOUT;
            parameters[10].Value = model.C_LOADING_MODE;
            parameters[11].Value = model.N_QTY;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Mod_TPB_LINEWH_LOC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_LINEWH_LOC set ");
            strSql.Append("C_LINEWH_AREA_ID=:C_LINEWH_AREA_ID,");
            strSql.Append("C_LINEWH_LOC_CODE=:C_LINEWH_LOC_CODE,");
            strSql.Append("C_LINEWH_LOC_NAME=:C_LINEWH_LOC_NAME,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_ISOUT=:C_ISOUT,");
            strSql.Append("C_LOADING_MODE=:C_LOADING_MODE,");
            strSql.Append("N_QTY=:N_QTY");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_LINEWH_AREA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ISOUT", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_LOADING_MODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QTY", OracleDbType.Decimal,3),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_LINEWH_AREA_ID;
            parameters[1].Value = model.C_LINEWH_LOC_CODE;
            parameters[2].Value = model.C_LINEWH_LOC_NAME;
            parameters[3].Value = model.D_START_DATE;
            parameters[4].Value = model.D_END_DATE;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_ISOUT;
            parameters[10].Value = model.C_LOADING_MODE;
            parameters[11].Value = model.N_QTY;
            parameters[12].Value = model.C_ID;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(string C_LINEWH_AREA_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_LINEWH_LOC ");
            strSql.Append(" where C_LINEWH_AREA_ID=:C_LINEWH_AREA_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_LINEWH_AREA_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_LINEWH_AREA_ID;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_LINEWH_LOC ");
            strSql.Append(" where C_ID in (" + C_IDlist + ")  ");
            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        public Mod_TPB_LINEWH_LOC GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_AREA_ID,C_LINEWH_LOC_CODE,C_LINEWH_LOC_NAME,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ISOUT,C_LOADING_MODE,N_QTY from TPB_LINEWH_LOC ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_LINEWH_LOC model = new Mod_TPB_LINEWH_LOC();
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
        public Mod_TPB_LINEWH_LOC DataRowToModel(DataRow row)
        {
            Mod_TPB_LINEWH_LOC model = new Mod_TPB_LINEWH_LOC();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_LINEWH_AREA_ID"] != null)
                {
                    model.C_LINEWH_AREA_ID = row["C_LINEWH_AREA_ID"].ToString();
                }
                if (row["C_LINEWH_LOC_CODE"] != null)
                {
                    model.C_LINEWH_LOC_CODE = row["C_LINEWH_LOC_CODE"].ToString();
                }
                if (row["C_LINEWH_LOC_NAME"] != null)
                {
                    model.C_LINEWH_LOC_NAME = row["C_LINEWH_LOC_NAME"].ToString();
                }
                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_ISOUT"] != null)
                {
                    model.C_ISOUT = row["C_ISOUT"].ToString();
                }
                if (row["C_LOADING_MODE"] != null)
                {
                    model.C_LOADING_MODE = row["C_LOADING_MODE"].ToString();
                }
                if (row["N_QTY"] != null && row["N_QTY"].ToString() != "")
                {
                    model.N_QTY = decimal.Parse(row["N_QTY"].ToString());
                }
            }
            return model;
        }
        /// <summary>
        /// 获得数据列表-外键
        /// </summary>
        public DataSet GetList_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_AREA_ID,C_LINEWH_LOC_CODE,C_LINEWH_LOC_NAME,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ISOUT,C_LOADING_MODE,N_QTY ");
            strSql.Append(" FROM TPB_LINEWH_LOC ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_LINEWH_AREA_ID = '" + strWhere + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        ///// <summary>
        ///// 获得数据列表-库位号
        ///// </summary>
        ///// <param name="C_LINEWH_LOC_CODE">库位号</param>
        ///// <param name="C_LINEWH_AREA_ID">外键</param>
        ///// <returns></returns>
        //public DataSet GetList_KW(string C_LINEWH_LOC_CODE, string C_LINEWH_AREA_ID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select C_ID,C_LINEWH_AREA_ID,C_LINEWH_LOC_CODE,C_LINEWH_LOC_NAME,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ISOUT,C_LOADING_MODE,N_QTY ");
        //    strSql.Append(" FROM TPB_LINEWH_LOC where 1=1 ");

        //    if (C_LINEWH_LOC_CODE.Trim() != "")
        //    {
        //        strSql.Append(" and C_LINEWH_LOC_CODE = '" + C_LINEWH_LOC_CODE + "'");
        //    }
        //    if (C_LINEWH_AREA_ID.Trim() != "")
        //    {
        //        strSql.Append(" and C_LINEWH_AREA_ID = '" + C_LINEWH_AREA_ID + "'");
        //    }
        //    return DbHelperOra.Query(strSql.ToString());
        //}
        /// <summary>
        /// 获得数据列表-数量总和
        /// </summary>
        /// <param name="begin">起始库位</param>
        /// <param name="end">截止库位</param>
        /// <returns></returns>
        public int GetList_SUM(string begin, string end)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(N_QTY)  FROM TPB_LINEWH_LOC ");

            if (begin.Trim() != "" && end.Trim() != "")
            {
                strSql.Append(" where C_LINEWH_LOC_CODE  between " + begin + " and " + end + "   ");
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_AREA_ID,C_LINEWH_LOC_CODE,C_LINEWH_LOC_NAME,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ISOUT,C_LOADING_MODE,N_QTY ");
            strSql.Append(" FROM TPB_LINEWH_LOC ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_LINEWH_LOC ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByArea(string strAreaID, int iStatus)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_AREA_ID,C_LINEWH_LOC_CODE,C_LINEWH_LOC_NAME,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPB_LINEWH_LOC ");
            if (strAreaID.Trim() != "")
            {
                strSql.Append(" where C_LINEWH_AREA_ID=:C_LINEWH_AREA_ID");
            }

            if (iStatus.ToString().Trim() != "")
            {
                strSql.Append(" AND N_STATUS=:N_STATUS");
            }
            strSql.Append(" order by C_LINEWH_LOC_CODE");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_LINEWH_AREA_ID", OracleDbType.Varchar2,100) ,
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,3)         };
            parameters[0].Value = strAreaID;
            parameters[1].Value = iStatus;
            return DbHelperOra.Query(strSql.ToString(), parameters);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ID(string C_LINEWH_AREA_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT A.C_LINEWH_LOC_CODE,A.C_LINEWH_LOC_NAME");
            strSql.Append(" FROM TPB_LINEWH_LOC A ,TPB_LINEWH_AREA B  where A.C_LINEWH_AREA_ID=B.C_ID ");
            if (C_LINEWH_AREA_CODE.Trim() != "")
            {
                strSql.Append(" AND C_LINEWH_AREA_CODE ='" + C_LINEWH_AREA_CODE + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过区域获取数据列表
        /// </summary>
        /// <param name="c_linewh_code">仓库编码</param> 
        /// <param name="C_LINEWH_AREA_ID">库位编码</param>
        /// <returns></returns>
        public DataSet Get_List(string c_linewh_code, string C_LINEWH_AREA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DECODE(a.cou,'',0,a.cou)cou,(t.n_qty - to_number(DECODE(a.cou, '', 0, a.cou))) nu,c.c_linewh_code, c.c_linewh_name,b.c_linewh_area_code,b.c_linewh_area_name,t.C_LINEWH_LOC_CODE,t.C_LINEWH_LOC_NAME,DECODE(t.C_ISOUT, 'Y', '室内', '室外') C_ISOUT,t.C_LOADING_MODE,t.N_QTY ");
            strSql.Append("  FROM TPB_LINEWH_LOC t join tpb_linewh_area b on t.c_linewh_area_id = b.c_id join tpb_linewh c on b.c_linewh_id = c.c_id left join ( select count(1) cou, s.c_linewh_loc_code   from trc_roll_prodcut s  where s.c_move_type='E'  group by s.c_linewh_loc_code) a on t.c_linewh_loc_code = a.c_linewh_loc_code where t.n_status = 1  ");
            if (c_linewh_code.Trim() != "")
            {
                strSql.Append(" AND c.c_linewh_code='" + c_linewh_code + "'");
            }

            if (C_LINEWH_AREA_ID.Trim().Length > 0)
            {
                strSql.Append(" AND t.C_LINEWH_LOC_CODE not in (" + C_LINEWH_AREA_ID.Substring(0, C_LINEWH_AREA_ID.Length - 1) + ") ");
            }
            strSql.Append(" order by t.C_LINEWH_LOC_CODE ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public DataSet Get_CAP(string C_LINEWH_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_LINEWH_LOC_CODE,T.N_QTY  FROM TPB_LINEWH_LOC T INNER JOIN TPB_LINEWH_AREA TB ON T.C_LINEWH_AREA_ID=TB.C_ID INNER JOIN TPB_LINEWH TC ON TC.C_ID=TB.C_LINEWH_ID WHERE t.n_status = 1 AND TC.C_LINEWH_CODE='" + C_LINEWH_CODE + "'  ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_LINEWH_CODE">仓库编码</param>
        /// <param name="C_LINEWH_LOC_CODE">库位编码</param>
        /// <returns></returns>
        public DataSet GetList_KW(string C_LINEWH_CODE, string c_linewh_area_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DECODE(a.cou,'',0,a.cou)cou,(t.n_qty - to_number(DECODE(a.cou, '', 0, a.cou))) nu,c.c_linewh_code, c.c_linewh_name,b.c_linewh_area_code,b.c_linewh_area_name,t.C_LINEWH_LOC_CODE,t.C_LINEWH_LOC_NAME,DECODE(t.C_ISOUT, 'Y', '室内', '室外') C_ISOUT,t.C_LOADING_MODE,t.N_QTY ");
            strSql.Append("  FROM TPB_LINEWH_LOC t join tpb_linewh_area b on t.c_linewh_area_id = b.c_id join tpb_linewh c on b.c_linewh_id = c.c_id left join ( select count(1) cou, s.c_linewh_loc_code   from trc_roll_prodcut s  where s.c_move_type='E'  group by s.c_linewh_loc_code) a on t.c_linewh_loc_code = a.c_linewh_loc_code where t.n_status = 1  ");
            if (C_LINEWH_CODE.Trim() != "全部" )
            {
                strSql.Append(" and c.c_linewh_code='" + C_LINEWH_CODE + "' ");
            }

            if (c_linewh_area_code.Trim() != "全部")
            {
                strSql.Append(" and b.c_linewh_area_code='" + c_linewh_area_code + "' ");
            }

            strSql.Append("  order by t.c_linewh_loc_code");
            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  ExtensionMethod
    }
}

