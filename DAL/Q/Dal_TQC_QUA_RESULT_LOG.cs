﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_QUA_RESULT_LOG
    /// </summary>
    public partial class Dal_TQC_QUA_RESULT_LOG
    {
        public Dal_TQC_QUA_RESULT_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_QUA_RESULT_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_QUA_RESULT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_QUA_RESULT_LOG(");
            strSql.Append("N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SPLIT,N_TYPE,C_STOVE,D_CREATETIME,C_ANANO,C_COMMISSIONID,C_ANAITEM,N_ORIGINALVALUE,C_GROUP,C_SHIFT,D_SHIFTDATE,C_SAMPID,C_SAMPSORT,C_IS_PD,C_EDIT_NUM)");
            strSql.Append(" values (");
            strSql.Append(":N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:N_SPLIT,:N_TYPE,:C_STOVE,:D_CREATETIME,:C_ANANO,:C_COMMISSIONID,:C_ANAITEM,:N_ORIGINALVALUE,:C_GROUP,:C_SHIFT,:D_SHIFTDATE,:C_SAMPID,:C_SAMPSORT,:C_IS_PD,:C_EDIT_NUM)");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SPLIT", OracleDbType.Decimal,1),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CREATETIME", OracleDbType.Date),
                    new OracleParameter(":C_ANANO", OracleDbType.Decimal,10),
                    new OracleParameter(":C_COMMISSIONID", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_ANAITEM", OracleDbType.Varchar2,250),
                    new OracleParameter(":N_ORIGINALVALUE", OracleDbType.Decimal,8),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,250),
                    new OracleParameter(":D_SHIFTDATE", OracleDbType.Date),
                    new OracleParameter(":C_SAMPID", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_SAMPSORT", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_EDIT_NUM", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_REMARK;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.N_SPLIT;
            parameters[5].Value = model.N_TYPE;
            parameters[6].Value = model.C_STOVE;
            parameters[7].Value = model.D_CREATETIME;
            parameters[8].Value = model.C_ANANO;
            parameters[9].Value = model.C_COMMISSIONID;
            parameters[10].Value = model.C_ANAITEM;
            parameters[11].Value = model.N_ORIGINALVALUE;
            parameters[12].Value = model.C_GROUP;
            parameters[13].Value = model.C_SHIFT;
            parameters[14].Value = model.D_SHIFTDATE;
            parameters[15].Value = model.C_SAMPID;
            parameters[16].Value = model.C_SAMPSORT;
            parameters[17].Value = model.C_IS_PD;
            parameters[18].Value = model.C_EDIT_NUM;

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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TQC_QUA_RESULT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_QUA_RESULT_LOG(");
            strSql.Append("N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SPLIT,N_TYPE,C_STOVE,D_CREATETIME,C_ANANO,C_COMMISSIONID,C_ANAITEM,N_ORIGINALVALUE,C_GROUP,C_SHIFT,D_SHIFTDATE,C_SAMPID,C_SAMPSORT,C_IS_PD,C_EDIT_NUM)");
            strSql.Append(" values (");
            strSql.Append(":N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:N_SPLIT,:N_TYPE,:C_STOVE,:D_CREATETIME,:C_ANANO,:C_COMMISSIONID,:C_ANAITEM,:N_ORIGINALVALUE,:C_GROUP,:C_SHIFT,:D_SHIFTDATE,:C_SAMPID,:C_SAMPSORT,:C_IS_PD,:C_EDIT_NUM)");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SPLIT", OracleDbType.Decimal,1),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CREATETIME", OracleDbType.Date),
                    new OracleParameter(":C_ANANO", OracleDbType.Decimal,10),
                    new OracleParameter(":C_COMMISSIONID", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_ANAITEM", OracleDbType.Varchar2,250),
                    new OracleParameter(":N_ORIGINALVALUE", OracleDbType.Decimal,8),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,250),
                    new OracleParameter(":D_SHIFTDATE", OracleDbType.Date),
                    new OracleParameter(":C_SAMPID", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_SAMPSORT", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_EDIT_NUM", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_REMARK;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.N_SPLIT;
            parameters[5].Value = model.N_TYPE;
            parameters[6].Value = model.C_STOVE;
            parameters[7].Value = model.D_CREATETIME;
            parameters[8].Value = model.C_ANANO;
            parameters[9].Value = model.C_COMMISSIONID;
            parameters[10].Value = model.C_ANAITEM;
            parameters[11].Value = model.N_ORIGINALVALUE;
            parameters[12].Value = model.C_GROUP;
            parameters[13].Value = model.C_SHIFT;
            parameters[14].Value = model.D_SHIFTDATE;
            parameters[15].Value = model.C_SAMPID;
            parameters[16].Value = model.C_SAMPSORT;
            parameters[17].Value = model.C_IS_PD;
            parameters[18].Value = model.C_EDIT_NUM;

            int rows = TransactionHelper.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Mod_TQC_QUA_RESULT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_QUA_RESULT_LOG set ");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_SPLIT=:N_SPLIT,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("D_CREATETIME=:D_CREATETIME,");
            strSql.Append("C_ANANO=:C_ANANO,");
            strSql.Append("C_COMMISSIONID=:C_COMMISSIONID,");
            strSql.Append("C_ANAITEM=:C_ANAITEM,");
            strSql.Append("N_ORIGINALVALUE=:N_ORIGINALVALUE,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("D_SHIFTDATE=:D_SHIFTDATE,");
            strSql.Append("C_SAMPID=:C_SAMPID,");
            strSql.Append("C_SAMPSORT=:C_SAMPSORT,");
            strSql.Append("C_IS_PD=:C_IS_PD,");
            strSql.Append("C_EDIT_NUM=:C_EDIT_NUM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SPLIT", OracleDbType.Decimal,1),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CREATETIME", OracleDbType.Date),
                    new OracleParameter(":C_ANANO", OracleDbType.Decimal,10),
                    new OracleParameter(":C_COMMISSIONID", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_ANAITEM", OracleDbType.Varchar2,250),
                    new OracleParameter(":N_ORIGINALVALUE", OracleDbType.Decimal,8),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,250),
                    new OracleParameter(":D_SHIFTDATE", OracleDbType.Date),
                    new OracleParameter(":C_SAMPID", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_SAMPSORT", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_EDIT_NUM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_REMARK;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.N_SPLIT;
            parameters[5].Value = model.N_TYPE;
            parameters[6].Value = model.C_STOVE;
            parameters[7].Value = model.D_CREATETIME;
            parameters[8].Value = model.C_ANANO;
            parameters[9].Value = model.C_COMMISSIONID;
            parameters[10].Value = model.C_ANAITEM;
            parameters[11].Value = model.N_ORIGINALVALUE;
            parameters[12].Value = model.C_GROUP;
            parameters[13].Value = model.C_SHIFT;
            parameters[14].Value = model.D_SHIFTDATE;
            parameters[15].Value = model.C_SAMPID;
            parameters[16].Value = model.C_SAMPSORT;
            parameters[17].Value = model.C_IS_PD;
            parameters[18].Value = model.C_EDIT_NUM;
            parameters[19].Value = model.C_ID;

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
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_QUA_RESULT_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

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
            strSql.Append("delete from TQC_QUA_RESULT_LOG ");
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
        public Mod_TQC_QUA_RESULT_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SPLIT,N_TYPE,C_STOVE,D_CREATETIME,C_ANANO,C_COMMISSIONID,C_ANAITEM,N_ORIGINALVALUE,C_GROUP,C_SHIFT,D_SHIFTDATE,C_SAMPID,C_SAMPSORT,C_IS_PD,C_EDIT_NUM from TQC_QUA_RESULT_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_QUA_RESULT_LOG model = new Mod_TQC_QUA_RESULT_LOG();
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
        public Mod_TQC_QUA_RESULT_LOG DataRowToModel(DataRow row)
        {
            Mod_TQC_QUA_RESULT_LOG model = new Mod_TQC_QUA_RESULT_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
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
                if (row["N_SPLIT"] != null && row["N_SPLIT"].ToString() != "")
                {
                    model.N_SPLIT = decimal.Parse(row["N_SPLIT"].ToString());
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["D_CREATETIME"] != null && row["D_CREATETIME"].ToString() != "")
                {
                    model.D_CREATETIME = DateTime.Parse(row["D_CREATETIME"].ToString());
                }
                if (row["C_ANANO"] != null && row["C_ANANO"].ToString() != "")
                {
                    model.C_ANANO = decimal.Parse(row["C_ANANO"].ToString());
                }
                if (row["C_COMMISSIONID"] != null)
                {
                    model.C_COMMISSIONID = row["C_COMMISSIONID"].ToString();
                }
                if (row["C_ANAITEM"] != null)
                {
                    model.C_ANAITEM = row["C_ANAITEM"].ToString();
                }
                if (row["N_ORIGINALVALUE"] != null && row["N_ORIGINALVALUE"].ToString() != "")
                {
                    model.N_ORIGINALVALUE = decimal.Parse(row["N_ORIGINALVALUE"].ToString());
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["D_SHIFTDATE"] != null && row["D_SHIFTDATE"].ToString() != "")
                {
                    model.D_SHIFTDATE = DateTime.Parse(row["D_SHIFTDATE"].ToString());
                }
                if (row["C_SAMPID"] != null)
                {
                    model.C_SAMPID = row["C_SAMPID"].ToString();
                }
                if (row["C_SAMPSORT"] != null)
                {
                    model.C_SAMPSORT = row["C_SAMPSORT"].ToString();
                }
                if (row["C_IS_PD"] != null)
                {
                    model.C_IS_PD = row["C_IS_PD"].ToString();
                }
                if (row["C_EDIT_NUM"] != null)
                {
                    model.C_EDIT_NUM = row["C_EDIT_NUM"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SPLIT,N_TYPE,C_STOVE,D_CREATETIME,C_ANANO,C_COMMISSIONID,C_ANAITEM,N_ORIGINALVALUE,C_GROUP,C_SHIFT,D_SHIFTDATE,C_SAMPID,C_SAMPSORT,C_IS_PD,C_EDIT_NUM ");
            strSql.Append(" FROM TQC_QUA_RESULT_LOG ");
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
            strSql.Append("select count(1) FROM TQC_QUA_RESULT_LOG ");
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.C_ID desc");
            }
            strSql.Append(")AS Row, T.*  from TQC_QUA_RESULT_LOG T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int Get_Max_EditNum(string C_STOVE, string C_ANANO, string C_COMMISSIONID, string C_SAMPID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(to_number(C_EDIT_NUM)) FROM TQC_QUA_RESULT_LOG t where 1=1 ");

            if (!string.IsNullOrEmpty(C_STOVE))
            {
                strSql.Append(" AND T.C_STOVE='" + C_STOVE + "' ");
            }

            if (!string.IsNullOrEmpty(C_ANANO))
            {
                strSql.Append(" AND T.C_ANANO='" + C_ANANO + "' ");
            }

            if (!string.IsNullOrEmpty(C_COMMISSIONID))
            {
                strSql.Append(" AND T.C_COMMISSIONID='" + C_COMMISSIONID + "' ");
            }

            if (!string.IsNullOrEmpty(C_SAMPID))
            {
                strSql.Append(" AND T.C_SAMPID='" + C_SAMPID + "' ");
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


        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

