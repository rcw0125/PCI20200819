﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
	/// 数据访问类:TRC_ROLL_QTCKD_ITEM
	/// </summary>
	public partial class Dal_TRC_ROLL_QTCKD_ITEM
    {
        public Dal_TRC_ROLL_QTCKD_ITEM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_QTCKD_ITEM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_QTCKD_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_QTCKD_ITEM(");
            strSql.Append("C_QTCKD_NO,C_BATCH_NO,C_JUDGE_LEV_ZH,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_SPEC,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,C_ZYX4,N_STATUS,C_LINEWH_CODE)");
            strSql.Append(" values (");
            strSql.Append(":C_QTCKD_NO,:C_BATCH_NO,:C_JUDGE_LEV_ZH,:C_MAT_CODE,:C_MAT_DESC,:C_STL_GRD,:C_SPEC,:N_NUM,:N_WGT,:C_Z_DW,:C_F_DW,:C_STOVE,:C_ZYX1,:C_ZYX2,:C_BZYQ,:C_ZYX4,:N_STATUS,:C_LINEWH_CODE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_QTCKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NUM", OracleDbType.Int16,15),
                    new OracleParameter(":N_WGT", OracleDbType.Int16,15),
                    new OracleParameter(":C_Z_DW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_F_DW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX4", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
                    new OracleParameter(":C_LINEWH_CODE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_QTCKD_NO;
            parameters[1].Value =  model.C_BATCH_NO;
            parameters[2].Value =  model.C_JUDGE_LEV_ZH;
            parameters[3].Value =  model.C_MAT_CODE;
            parameters[4].Value =  model.C_MAT_DESC;
            parameters[5].Value =  model.C_STL_GRD;
            parameters[6].Value =  model.C_SPEC;
            parameters[7].Value =  model.N_NUM;
            parameters[8].Value =  model.N_WGT;
            parameters[9].Value =   model.C_Z_DW;
            parameters[10].Value =  model.C_F_DW;
            parameters[11].Value =  model.C_STOVE;
            parameters[12].Value =  model.C_ZYX1;
            parameters[13].Value =  model.C_ZYX2;
            parameters[14].Value =  model.C_BZYQ;
            parameters[15].Value =  model.C_ZYX4;
            parameters[16].Value =  model.N_STATUS;
            parameters[17].Value =  model.C_LINEWH_CODE;
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
        public bool Update(Mod_TRC_ROLL_QTCKD_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_QTCKD_ITEM set ");
            strSql.Append("C_QTCKD_NO=:C_QTCKD_NO,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_JUDGE_LEV_ZH=:C_JUDGE_LEV_ZH,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_NUM=:N_NUM,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_Z_DW=:C_Z_DW,");
            strSql.Append("C_F_DW=:C_F_DW,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_BZYQ=:C_BZYQ,");
            strSql.Append("C_ZYX4=:C_ZYX4,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_LINEWH_CODE=:C_LINEWH_CODE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_QTCKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NUM", OracleDbType.Int16,15),
                    new OracleParameter(":N_WGT", OracleDbType.Int16,15),
                    new OracleParameter(":C_Z_DW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_F_DW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX4", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
                    new OracleParameter(":C_LINEWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_QTCKD_NO;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_JUDGE_LEV_ZH;
            parameters[3].Value = model.C_MAT_CODE;
            parameters[4].Value = model.C_MAT_DESC;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.N_NUM;
            parameters[8].Value = model.N_WGT;
            parameters[9].Value = model.C_Z_DW;
            parameters[10].Value = model.C_F_DW;
            parameters[11].Value = model.C_STOVE;
            parameters[12].Value = model.C_ZYX1;
            parameters[13].Value = model.C_ZYX2;
            parameters[14].Value = model.C_BZYQ;
            parameters[15].Value = model.C_ZYX4;
            parameters[16].Value = model.N_STATUS;
            parameters[17].Value = model.C_LINEWH_CODE;
            parameters[18].Value = model.C_ID;

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
            strSql.Append("delete from TRC_ROLL_QTCKD_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
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
            strSql.Append("delete from TRC_ROLL_QTCKD_ITEM ");
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
        public Mod_TRC_ROLL_QTCKD_ITEM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_QTCKD_NO,C_BATCH_NO,C_JUDGE_LEV_ZH,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_SPEC,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,C_ZYX4,N_STATUS,C_LINEWH_CODE from TRC_ROLL_QTCKD_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_QTCKD_ITEM model = new Mod_TRC_ROLL_QTCKD_ITEM();
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
        public Mod_TRC_ROLL_QTCKD_ITEM DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_QTCKD_ITEM model = new Mod_TRC_ROLL_QTCKD_ITEM();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_QTCKD_NO"] != null)
                {
                    model.C_QTCKD_NO = row["C_QTCKD_NO"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_JUDGE_LEV_ZH"] != null)
                {
                    model.C_JUDGE_LEV_ZH = row["C_JUDGE_LEV_ZH"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_DESC"] != null)
                {
                    model.C_MAT_DESC = row["C_MAT_DESC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["N_NUM"] != null && row["N_NUM"].ToString() != "")
                {
                    model.N_NUM = decimal.Parse(row["N_NUM"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_Z_DW"] != null)
                {
                    model.C_Z_DW = row["C_Z_DW"].ToString();
                }
                if (row["C_F_DW"] != null)
                {
                    model.C_F_DW = row["C_F_DW"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_ZYX1"] != null)
                {
                    model.C_ZYX1 = row["C_ZYX1"].ToString();
                }
                if (row["C_ZYX2"] != null)
                {
                    model.C_ZYX2 = row["C_ZYX2"].ToString();
                }
                if (row["C_BZYQ"] != null)
                {
                    model.C_BZYQ = row["C_BZYQ"].ToString();
                }
                if (row["C_ZYX4"] != null)
                {
                    model.C_ZYX4 = row["C_ZYX4"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_LINEWH_CODE"] != null)
                {
                    model.C_LINEWH_CODE = row["C_LINEWH_CODE"].ToString();
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
            strSql.Append("select C_ID,C_QTCKD_NO,C_BATCH_NO,C_JUDGE_LEV_ZH,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_SPEC,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,C_ZYX4,N_STATUS,C_LINEWH_CODE ");
            strSql.Append(" FROM TRC_ROLL_QTCKD_ITEM ");
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
            strSql.Append("select count(1) FROM TRC_ROLL_QTCKD_ITEM ");
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_QTCKD_ITEM T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 通过出库单号获得出库单详情数据
        /// </summary>
        /// <param name="dh">出库单号</param>
        /// <returns></returns>
        public DataSet GetQTCKXQByDH(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_QTCKD_NO,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_JUDGE_LEV_ZH,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_BATCH_NO,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,C_ZYX4,N_STATUS,C_LINEWH_CODE ");
            strSql.Append(" FROM TRC_ROLL_QTCKD_ITEM WHERE N_STATUS=1");

            if (dh.Trim() != "")
            {
                strSql.Append(" AND C_QTCKD_NO ='" + dh + "' ");
            }
            return TransactionHelper.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}
