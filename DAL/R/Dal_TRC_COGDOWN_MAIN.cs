using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    public partial class Dal_TRC_COGDOWN_MAIN
    {
        public Dal_TRC_COGDOWN_MAIN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_COGDOWN_MAIN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_COGDOWN_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_COGDOWN_MAIN(");
            strSql.Append("C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_TOTAL,N_WGT_TOTAL,C_STL_GRD_SLAB,C_SPEC_SLAB,C_EMP_ID,C_SHIFT,C_GROUP,D_MOD_DT,N_QUA_REMOVE,N_WGT_REMOVE,N_QUA_RETRUN,N_WGT_RETRUN,N_QUA_JOIN,N_WGT_JOIN,N_QUA_EXIT,N_WGT_EXIT,N_QUA_CPHALF,N_WGT_HALF,N_QUA_CPWHOLE,N_WGT_CPWHOLE,C_ROLL_STATE,C_FUR_TYPE,N_QUA_ELIM,N_WGT_ELIM,C_MAT_SLAB_CODE,C_MAT_SLAB_NAME,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_SLAB_NUM,N_QUA_TOTAL_VIRTUAL,N_WGT_TOTAL_VIRTUAL)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_STA_ID,:C_PLANT,:C_STOVE,:C_BATCH_NO,:C_PLAN_ID,:N_QUA_TOTAL,:N_WGT_TOTAL,:C_STL_GRD_SLAB,:C_SPEC_SLAB,:C_EMP_ID,:C_SHIFT,:C_GROUP,:D_MOD_DT,:N_QUA_REMOVE,:N_WGT_REMOVE,:N_QUA_RETRUN,:N_WGT_RETRUN,:N_QUA_JOIN,:N_WGT_JOIN,:N_QUA_EXIT,:N_WGT_EXIT,:N_QUA_CPHALF,:N_WGT_HALF,:N_QUA_CPWHOLE,:N_WGT_CPWHOLE,:C_ROLL_STATE,:C_FUR_TYPE,:N_QUA_ELIM,:N_WGT_ELIM,:C_MAT_SLAB_CODE,:C_MAT_SLAB_NAME,:C_REMARK,:N_STATUS,:C_STD_CODE,:C_STL_GRD,:C_SPEC,:C_SLAB_NUM,:N_QUA_TOTAL_VIRTUAL,:N_WGT_TOTAL_VIRTUAL)");
            OracleParameter[] parameters = {
                 new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_TOTAL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_TOTAL", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_QUA_REMOVE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_REMOVE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_RETRUN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_RETRUN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_JOIN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_JOIN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_EXIT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_EXIT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_CPHALF", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_HALF", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_CPWHOLE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_CPWHOLE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_STATE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_FUR_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_ELIM", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_ELIM", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_SLAB_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_SLAB_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_NUM", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_TOTAL_VIRTUAL",  OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_TOTAL_VIRTUAL",  OracleDbType.Decimal,15)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_PLANT;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_PLAN_ID;
            parameters[6].Value = model.N_QUA_TOTAL;
            parameters[7].Value = model.N_WGT_TOTAL;
            parameters[8].Value = model.C_STL_GRD_SLAB;
            parameters[9].Value = model.C_SPEC_SLAB;
            parameters[10].Value = model.C_EMP_ID;
            parameters[11].Value = model.C_SHIFT;
            parameters[12].Value = model.C_GROUP;
            parameters[13].Value = model.D_MOD_DT;
            parameters[14].Value = model.N_QUA_REMOVE;
            parameters[15].Value = model.N_WGT_REMOVE;
            parameters[16].Value = model.N_QUA_RETRUN;
            parameters[17].Value = model.N_WGT_RETRUN;
            parameters[18].Value = model.N_QUA_JOIN;
            parameters[19].Value = model.N_WGT_JOIN;
            parameters[20].Value = model.N_QUA_EXIT;
            parameters[21].Value = model.N_WGT_EXIT;
            parameters[22].Value = model.N_QUA_CPHALF;
            parameters[23].Value = model.N_WGT_HALF;
            parameters[24].Value = model.N_QUA_CPWHOLE;
            parameters[25].Value = model.N_WGT_CPWHOLE;
            parameters[26].Value = model.C_ROLL_STATE;
            parameters[27].Value = model.C_FUR_TYPE;
            parameters[28].Value = model.N_QUA_ELIM;
            parameters[29].Value = model.N_WGT_ELIM;
            parameters[30].Value = model.C_MAT_SLAB_CODE;
            parameters[31].Value = model.C_MAT_SLAB_NAME;
            parameters[32].Value = model.C_REMARK;
            parameters[33].Value = model.N_STATUS;
            parameters[34].Value = model.C_STD_CODE;
            parameters[35].Value = model.C_STL_GRD;
            parameters[36].Value = model.C_SPEC;
            parameters[37].Value = model.C_SLAB_NUM;
            parameters[38].Value = model.N_QUA_TOTAL_VIRTUAL;
            parameters[39].Value = model.N_WGT_TOTAL_VIRTUAL;
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
        public bool Update(Mod_TRC_COGDOWN_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_COGDOWN_MAIN set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_PLANT=:C_PLANT,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("N_QUA_TOTAL=:N_QUA_TOTAL,");
            strSql.Append("N_WGT_TOTAL=:N_WGT_TOTAL,");
            strSql.Append("C_STL_GRD_SLAB=:C_STL_GRD_SLAB,");
            strSql.Append("C_SPEC_SLAB=:C_SPEC_SLAB,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_QUA_REMOVE=:N_QUA_REMOVE,");
            strSql.Append("N_WGT_REMOVE=:N_WGT_REMOVE,");
            strSql.Append("N_QUA_RETRUN=:N_QUA_RETRUN,");
            strSql.Append("N_WGT_RETRUN=:N_WGT_RETRUN,");
            strSql.Append("N_QUA_JOIN=:N_QUA_JOIN,");
            strSql.Append("N_WGT_JOIN=:N_WGT_JOIN,");
            strSql.Append("N_QUA_EXIT=:N_QUA_EXIT,");
            strSql.Append("N_WGT_EXIT=:N_WGT_EXIT,");
            strSql.Append("N_QUA_CPHALF=:N_QUA_CPHALF,");
            strSql.Append("N_WGT_HALF=:N_WGT_HALF,");
            strSql.Append("N_QUA_CPWHOLE=:N_QUA_CPWHOLE,");
            strSql.Append("N_WGT_CPWHOLE=:N_WGT_CPWHOLE,");
            strSql.Append("C_ROLL_STATE=:C_ROLL_STATE,");
            strSql.Append("C_FUR_TYPE=:C_FUR_TYPE,");
            strSql.Append("N_QUA_ELIM=:N_QUA_ELIM,");
            strSql.Append("N_WGT_ELIM=:N_WGT_ELIM,");
            strSql.Append("C_MAT_SLAB_CODE=:C_MAT_SLAB_CODE,");
            strSql.Append("C_MAT_SLAB_NAME=:C_MAT_SLAB_NAME,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_SLAB_NUM=:C_SLAB_NUM");
            strSql.Append("N_QUA_TOTAL_VIRTUAL=:N_QUA_TOTAL_VIRTUAL,");
            strSql.Append("N_WGT_TOTAL_VIRTUAL=:N_WGT_TOTAL_VIRTUAL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_TOTAL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_TOTAL", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_QUA_REMOVE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_REMOVE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_RETRUN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_RETRUN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_JOIN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_JOIN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_EXIT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_EXIT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_CPHALF", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_HALF", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_CPWHOLE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_CPWHOLE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_STATE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_FUR_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_ELIM", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_ELIM", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_SLAB_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_SLAB_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_NUM", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_TOTAL_VIRTUAL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_TOTAL_VIRTUAL", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_PLANT;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_BATCH_NO;
            parameters[4].Value = model.C_PLAN_ID;
            parameters[5].Value = model.N_QUA_TOTAL;
            parameters[6].Value = model.N_WGT_TOTAL;
            parameters[7].Value = model.C_STL_GRD_SLAB;
            parameters[8].Value = model.C_SPEC_SLAB;
            parameters[9].Value = model.C_EMP_ID;
            parameters[10].Value = model.C_SHIFT;
            parameters[11].Value = model.C_GROUP;
            parameters[12].Value = model.D_MOD_DT;
            parameters[13].Value = model.N_QUA_REMOVE;
            parameters[14].Value = model.N_WGT_REMOVE;
            parameters[15].Value = model.N_QUA_RETRUN;
            parameters[16].Value = model.N_WGT_RETRUN;
            parameters[17].Value = model.N_QUA_JOIN;
            parameters[18].Value = model.N_WGT_JOIN;
            parameters[19].Value = model.N_QUA_EXIT;
            parameters[20].Value = model.N_WGT_EXIT;
            parameters[21].Value = model.N_QUA_CPHALF;
            parameters[22].Value = model.N_WGT_HALF;
            parameters[23].Value = model.N_QUA_CPWHOLE;
            parameters[24].Value = model.N_WGT_CPWHOLE;
            parameters[25].Value = model.C_ROLL_STATE;
            parameters[26].Value = model.C_FUR_TYPE;
            parameters[27].Value = model.N_QUA_ELIM;
            parameters[28].Value = model.N_WGT_ELIM;
            parameters[29].Value = model.C_MAT_SLAB_CODE;
            parameters[30].Value = model.C_MAT_SLAB_NAME;
            parameters[31].Value = model.C_REMARK;
            parameters[32].Value = model.N_STATUS;
            parameters[33].Value = model.C_STD_CODE;
            parameters[34].Value = model.C_STL_GRD;
            parameters[35].Value = model.C_SPEC;
            parameters[36].Value = model.C_SLAB_NUM;
            parameters[37].Value = model.N_QUA_TOTAL_VIRTUAL;
            parameters[38].Value = model.N_WGT_TOTAL_VIRTUAL;
            parameters[39].Value = model.C_ID;

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
        public bool UpdateTran(Mod_TRC_COGDOWN_MAIN m)
        {
            string sql = @"UPDATE TRC_COGDOWN_MAIN T SET T.N_QUA_TOTAL_VIRTUAL=" + m.N_QUA_TOTAL_VIRTUAL + "  ,T.N_WGT_TOTAL_VIRTUAL=" + m.N_WGT_TOTAL_VIRTUAL + " ,T.N_QUA_EXIT=" + m.N_QUA_EXIT + "  ,T.N_WGT_EXIT=" + m.N_WGT_EXIT + " WHERE T.C_ID='" + m.C_ID + "'";

            int rows = TransactionHelper.ExecuteSql(sql);
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
            strSql.Append("delete from TRC_COGDOWN_MAIN ");
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
            strSql.Append("delete from TRC_COGDOWN_MAIN ");
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
        public Mod_TRC_COGDOWN_MAIN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_TOTAL,N_WGT_TOTAL,C_STL_GRD_SLAB,C_SPEC_SLAB,C_EMP_ID,C_SHIFT,C_GROUP,D_MOD_DT,N_QUA_REMOVE,N_WGT_REMOVE,N_QUA_RETRUN,N_WGT_RETRUN,N_QUA_JOIN,N_WGT_JOIN,N_QUA_EXIT,N_WGT_EXIT,N_QUA_CPHALF,N_WGT_HALF,N_QUA_CPWHOLE,N_WGT_CPWHOLE,C_ROLL_STATE,C_FUR_TYPE,N_QUA_ELIM,N_WGT_ELIM,C_MAT_SLAB_CODE,C_MAT_SLAB_NAME,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_SLAB_NUM,N_QUA_TOTAL_VIRTUAL,N_WGT_TOTAL_VIRTUAL,N_ACCOM_TOTAL,N_ACCOM_WGT_TOTAL from TRC_COGDOWN_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_COGDOWN_MAIN model = new Mod_TRC_COGDOWN_MAIN();
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
        public Mod_TRC_COGDOWN_MAIN GetModels(string batchNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from TRC_COGDOWN_MAIN ");
            strSql.Append(" where C_BATCH_NO=:batchNo ");
            OracleParameter[] parameters = {
                    new OracleParameter(":batchNo", OracleDbType.Varchar2,100)            };
            parameters[0].Value = batchNo;

            Mod_TRC_COGDOWN_MAIN model = new Mod_TRC_COGDOWN_MAIN();
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
        public Mod_TRC_COGDOWN_MAIN DataRowToModel(DataRow row)
        {
            Mod_TRC_COGDOWN_MAIN model = new Mod_TRC_COGDOWN_MAIN();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_PLANT"] != null)
                {
                    model.C_PLANT = row["C_PLANT"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_PLAN_ID"] != null)
                {
                    model.C_PLAN_ID = row["C_PLAN_ID"].ToString();
                }
                if (row["N_QUA_TOTAL"] != null && row["N_QUA_TOTAL"].ToString() != "")
                {
                    model.N_QUA_TOTAL = decimal.Parse(row["N_QUA_TOTAL"].ToString());
                }
                if (row["N_WGT_TOTAL"] != null && row["N_WGT_TOTAL"].ToString() != "")
                {
                    model.N_WGT_TOTAL = decimal.Parse(row["N_WGT_TOTAL"].ToString());
                }
                if (row["C_STL_GRD_SLAB"] != null)
                {
                    model.C_STL_GRD_SLAB = row["C_STL_GRD_SLAB"].ToString();
                }
                if (row["C_SPEC_SLAB"] != null)
                {
                    model.C_SPEC_SLAB = row["C_SPEC_SLAB"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["N_QUA_REMOVE"] != null && row["N_QUA_REMOVE"].ToString() != "")
                {
                    model.N_QUA_REMOVE = decimal.Parse(row["N_QUA_REMOVE"].ToString());
                }
                if (row["N_WGT_REMOVE"] != null && row["N_WGT_REMOVE"].ToString() != "")
                {
                    model.N_WGT_REMOVE = decimal.Parse(row["N_WGT_REMOVE"].ToString());
                }
                if (row["N_QUA_RETRUN"] != null && row["N_QUA_RETRUN"].ToString() != "")
                {
                    model.N_QUA_RETRUN = decimal.Parse(row["N_QUA_RETRUN"].ToString());
                }
                if (row["N_WGT_RETRUN"] != null && row["N_WGT_RETRUN"].ToString() != "")
                {
                    model.N_WGT_RETRUN = decimal.Parse(row["N_WGT_RETRUN"].ToString());
                }
                if (row["N_QUA_JOIN"] != null && row["N_QUA_JOIN"].ToString() != "")
                {
                    model.N_QUA_JOIN = decimal.Parse(row["N_QUA_JOIN"].ToString());
                }
                if (row["N_WGT_JOIN"] != null && row["N_WGT_JOIN"].ToString() != "")
                {
                    model.N_WGT_JOIN = decimal.Parse(row["N_WGT_JOIN"].ToString());
                }
                if (row["N_QUA_EXIT"] != null && row["N_QUA_EXIT"].ToString() != "")
                {
                    model.N_QUA_EXIT = decimal.Parse(row["N_QUA_EXIT"].ToString());
                }
                if (row["N_WGT_EXIT"] != null && row["N_WGT_EXIT"].ToString() != "")
                {
                    model.N_WGT_EXIT = decimal.Parse(row["N_WGT_EXIT"].ToString());
                }
                if (row["N_QUA_CPHALF"] != null && row["N_QUA_CPHALF"].ToString() != "")
                {
                    model.N_QUA_CPHALF = decimal.Parse(row["N_QUA_CPHALF"].ToString());
                }
                if (row["N_WGT_HALF"] != null && row["N_WGT_HALF"].ToString() != "")
                {
                    model.N_WGT_HALF = decimal.Parse(row["N_WGT_HALF"].ToString());
                }
                if (row["N_QUA_CPWHOLE"] != null && row["N_QUA_CPWHOLE"].ToString() != "")
                {
                    model.N_QUA_CPWHOLE = decimal.Parse(row["N_QUA_CPWHOLE"].ToString());
                }
                if (row["N_WGT_CPWHOLE"] != null && row["N_WGT_CPWHOLE"].ToString() != "")
                {
                    model.N_WGT_CPWHOLE = decimal.Parse(row["N_WGT_CPWHOLE"].ToString());
                }
                if (row["C_ROLL_STATE"] != null && row["C_ROLL_STATE"].ToString() != "")
                {
                    model.C_ROLL_STATE = decimal.Parse(row["C_ROLL_STATE"].ToString());
                }
                if (row["C_FUR_TYPE"] != null)
                {
                    model.C_FUR_TYPE = row["C_FUR_TYPE"].ToString();
                }
                if (row["N_QUA_ELIM"] != null && row["N_QUA_ELIM"].ToString() != "")
                {
                    model.N_QUA_ELIM = decimal.Parse(row["N_QUA_ELIM"].ToString());
                }
                if (row["N_WGT_ELIM"] != null && row["N_WGT_ELIM"].ToString() != "")
                {
                    model.N_WGT_ELIM = decimal.Parse(row["N_WGT_ELIM"].ToString());
                }
                if (row["C_MAT_SLAB_CODE"] != null)
                {
                    model.C_MAT_SLAB_CODE = row["C_MAT_SLAB_CODE"].ToString();
                }
                if (row["C_MAT_SLAB_NAME"] != null)
                {
                    model.C_MAT_SLAB_NAME = row["C_MAT_SLAB_NAME"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_SLAB_NUM"] != null)
                {
                    model.C_SLAB_NUM = row["C_SLAB_NUM"].ToString();
                }
                if (row["N_QUA_TOTAL_VIRTUAL"] != null && row["N_QUA_TOTAL_VIRTUAL"].ToString() != "")
                {
                    model.N_QUA_TOTAL_VIRTUAL = decimal.Parse(row["N_QUA_TOTAL_VIRTUAL"].ToString());
                }
                if (row["N_WGT_TOTAL_VIRTUAL"] != null && row["N_WGT_TOTAL_VIRTUAL"].ToString() != "")
                {
                    model.N_WGT_TOTAL_VIRTUAL = decimal.Parse(row["N_WGT_TOTAL_VIRTUAL"].ToString());
                }
                if (row["N_ACCOM_TOTAL"] != null && row["N_ACCOM_TOTAL"].ToString() != "")
                {
                    model.N_ACCOM_TOTAL = decimal.Parse(row["N_ACCOM_TOTAL"].ToString());
                }
                if (row["N_ACCOM_WGT_TOTAL"] != null && row["N_ACCOM_WGT_TOTAL"].ToString() != "")
                {
                    model.N_ACCOM_WGT_TOTAL = decimal.Parse(row["N_ACCOM_WGT_TOTAL"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="IsOrderDesc">排序 </param>
        /// <returns></returns>
        public DataSet GetListMain(string strWhere, bool IsOrderDesc)
        {
            string sql = @"SELECT
                                    TRM.C_ID,
                                    TPC.C_ORDER_NO,
                                   ( SELECT TTT.C_ORDER_NO FROM TMO_ORDER TTT WHERE TTT.C_ID=  ( SELECT TT.C_ORDER_NO FROM TSP_PLAN_SMS TT WHERE TT.C_ID=TPC.C_ORDER_NO ) ) ORDER_NO,
                                    TRM.C_STA_ID,
                                    TRM.C_PLANT,
                                    TRM.C_STOVE,
                                    TRM.C_BATCH_NO,
                                    TRM.C_PLAN_ID,
                                    TRM.N_QUA_TOTAL,
                                    TRM.N_WGT_TOTAL,
                                    TRM.C_STL_GRD_SLAB,
                                    TRM.C_SPEC_SLAB,
                                    TU.C_NAME C_EMP_ID,
                                    TRM.C_SHIFT,
                                    TRM.C_GROUP,
                                    TRM.D_MOD_DT,
                                    TRM.N_QUA_REMOVE,
                                    TRM.N_WGT_REMOVE,
                                    TRM.N_QUA_RETRUN,
                                    TRM.N_WGT_RETRUN,
                                    TRM.N_QUA_JOIN,
                                    TRM.N_WGT_JOIN,
                                    TRM.N_QUA_EXIT,
                                    TRM.N_WGT_EXIT,
                                    TRM.N_QUA_CPHALF,
                                    TRM.N_WGT_HALF,
                                    TRM.N_QUA_CPWHOLE,
                                    TRM.N_WGT_CPWHOLE,
                                    TRM.C_ROLL_STATE,
                                    TRM.C_FUR_TYPE,
                                    TRM.N_QUA_ELIM,
                                    TRM.N_WGT_ELIM,
                                    TRM.C_MAT_SLAB_CODE,
                                    TRM.C_MAT_SLAB_NAME,
                                    TRM.C_REMARK,
                                    TRM.N_STATUS,
                                    TRM.C_STD_CODE,
                                    TRM.C_STL_GRD,
                                    TRM.C_SPEC,
                                    TA.C_STA_CODE,
                                    TA.C_STA_DESC,
                                    TRM.N_QUA_TOTAL_VIRTUAL,
                                    TRM.N_WGT_TOTAL_VIRTUAL,
                                    TRM.N_ACCOM_TOTAL ,   
                                    TPC.N_PW,
                                    TPC.N_LENTH,
                                    TPC.C_MAT_CODE
                                    FROM TRC_COGDOWN_MAIN TRM
                                    LEFT JOIN TS_USER TU ON TU.C_ID=TRM.C_EMP_ID
                                    LEFT JOIN TB_STA TA ON TA.C_ID=TRM.C_STA_ID
                                    LEFT JOIN TRP_PLAN_COGDOWN TPC    ON TPC.C_ID=TRM.C_PLAN_ID
                                    WHERE 1 = 1  ";

            if (strWhere.Trim() != "")
            {
                sql += strWhere;
            }

            if (IsOrderDesc)
                sql += "  ORDER BY TRM.C_BATCH_NO ";
            else
                sql += "  ORDER BY TRM.C_BATCH_NO   DESC ";

            return DbHelperOra.Query(sql);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="IsOrderDesc">排序 </param>
        /// <returns></returns>
        public DataSet GetList(string strWhere, bool IsOrderDesc, int status)
        {
            string sql = @"SELECT MAX(TRM.C_ID) C_ID,
                       MAX(TTTT.C_ORDER_NO)C_ORDER_NO,
                       MAX(TWF.C_TRC_ROLL_MAIN_ID) C_TRC_ROLL_MAIN_ID,
                       MAX(TRM.C_STOVE) C_STOVE,
                       TRM.C_BATCH_NO,
                       MAX(TRM.C_STA_ID) C_STA_ID,
                       MAX(TA.C_STA_DESC) C_STA_DESC,
                       MAX(TRM.C_STL_GRD_SLAB) C_STL_GRD_SLAB,
                       MAX(TRM.C_SPEC_SLAB) C_SPEC_SLAB,
                       MAX(TRM.C_MAT_SLAB_CODE) C_MAT_SLAB_CODE,
                       MAX(TRM.C_STL_GRD) C_STL_GRD,
                       MAX(TRM.C_SPEC) C_SPEC， MAX(TPR.C_MAT_CODE) C_MAT_CODE,
                       MAX(TRM.C_STD_CODE) C_STD_CODE,
                       MAX(TWF.C_EMP_ID) C_EMP_ID,
                       MAX(TWF.D_MOD_DT) D_MOD_DT,
                       MAX(TWF.C_SHIFT) C_SHIFT,
                       MAX(TWF.C_GROUP) C_GROUP,
                       MAX(TRM.C_REMARK) C_REMARK,
                       MAX(TRM.C_PLAN_ID) C_PLAN_ID,  ";
            sql += " (SELECT COUNT(C_ID)   FROM TRC_WARM_FURNACE TWF1  WHERE TWF1.C_BATCH_NO = TRM.C_BATCH_NO  AND TWF1.N_STATUS = 0  AND TWF1.N_ROLL_STATE=" + status + " ) N_QUA_JOIN,";
            sql += " (SELECT MAX(TWF1.N_WGT_JOIN)   FROM TRC_WARM_FURNACE TWF1  WHERE TWF1.C_BATCH_NO = TRM.C_BATCH_NO  AND TWF1.N_STATUS = 0  AND TWF1.N_ROLL_STATE=" + status + " )*  (SELECT COUNT(C_ID)   FROM TRC_WARM_FURNACE TWF1 WHERE TWF1.C_BATCH_NO = TRM.C_BATCH_NO  AND TWF1.N_STATUS = 0  AND TWF1.N_ROLL_STATE = " + status + ") N_WGT_JOIN ";
            sql += @" FROM TRC_COGDOWN_MAIN TRM
             LEFT JOIN TRP_PLAN_COGDOWN TT ON TT.C_ID=TRM.C_PLAN_ID
    LEFT JOIN TSP_PLAN_SMS TTT ON TTT.C_ID=TT.C_ORDER_NO
    LEFT JOIN TMO_ORDER TTTT ON TTTT.C_ID=TTT.C_ORDER_NO
            LEFT JOIN TRC_WARM_FURNACE TWF
              ON TWF.C_TRC_ROLL_MAIN_ID = TRM.C_ID
                  LEFT JOIN TB_STA TA
                    ON TA.C_ID = TRM.C_STA_ID
                  LEFT JOIN TRP_PLAN_ROLL_ITEM TPR
                    ON TPR.C_ID = TRM.C_PLAN_ID
                                     ";

            if (strWhere.Trim() != "")
            {
                sql += strWhere;
            }

            sql += "    GROUP BY TRM.C_BATCH_NO    ";

            if (IsOrderDesc)
                sql += "  ORDER BY TRM.C_BATCH_NO  ";
            else
                sql += "  ORDER BY TRM.C_BATCH_NO   DESC ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="IsOrderDesc">排序 </param>
        /// <returns></returns>
        public DataSet GetCogDownList(string strWhere)
        {
            string sql = @"SELECT 
                           TCM.C_ID
                          ,TCM.C_PLAN_ID
                          ,TCM.C_STA_ID
                          ,(SELECT TS.C_STA_DESC FROM TB_STA TS WHERE TS.C_ID=TCM.C_STA_ID)C_STA_DESC
                          ,(SELECT TS.C_STA_CODE FROM TB_STA TS WHERE TS.C_ID=TCM.C_STA_ID)C_STA_CODE
                          ,(SELECT TPC.N_PW FROM TRP_PLAN_COGDOWN TPC WHERE TPC.C_ID=TCM.C_PLAN_ID) N_PW
                          ,(SELECT TPC.N_LENTH FROM TRP_PLAN_COGDOWN TPC WHERE TPC.C_ID=TCM.C_PLAN_ID) N_LENTH
                          ,TCM.C_BATCH_NO
                          ,TCM.C_STOVE
                          ,TCM.N_QUA_TOTAL_VIRTUAL
                          ,TCM.N_QUA_ELIM
                          ,TCM.C_STD_CODE
                          ,TCM.C_STL_GRD
                          ,TCM.C_SPEC
                          ,TCM.C_STL_GRD_SLAB
                          ,TCM.C_SPEC_SLAB  
                          ,NVL(TCM.N_ACCOM_TOTAL, 0) N_ACCOM_TOTAL
                          ,NVL(TCM.N_ACCOM_WGT_TOTAL, 0) N_ACCOM_WGT_TOTAL
                          ,(SELECT MAX(TWF.C_SHIFT) FROM TRC_WARM_FURNACE TWF WHERE TWF.C_TRC_ROLL_MAIN_ID=TCM.C_ID) C_SHIFT
                          ,(SELECT MAX(TWF.C_GROUP) FROM TRC_WARM_FURNACE TWF WHERE TWF.C_TRC_ROLL_MAIN_ID=TCM.C_ID) C_GROUP
                          ,(SELECT MAX(TWF.N_LEN) FROM TRC_WARM_FURNACE TWF WHERE TWF.C_TRC_ROLL_MAIN_ID=TCM.C_ID) N_LEN
                          ,(SELECT MAX(TWF.C_MAT_CODE) FROM TRC_WARM_FURNACE TWF WHERE TWF.C_TRC_ROLL_MAIN_ID=TCM.C_ID) C_MAT_CODE
                          ,(SELECT MAX(TWF.C_MAT_NAME) FROM TRC_WARM_FURNACE TWF WHERE TWF.C_TRC_ROLL_MAIN_ID=TCM.C_ID) C_MAT_NAME
                          ,(SELECT MAX(TWF.C_EMP_ID) FROM TRC_WARM_FURNACE TWF WHERE TWF.C_TRC_ROLL_MAIN_ID=TCM.C_ID) C_EMP_ID
                          ,(SELECT MAX(TWF.D_MOD_DT) FROM TRC_WARM_FURNACE TWF WHERE TWF.C_TRC_ROLL_MAIN_ID=TCM.C_ID) D_MOD_DT
                    FROM TRC_COGDOWN_MAIN TCM
                                     ";


            if (strWhere.Trim() != "")
            {
                sql += strWhere;
            }

            sql += " ORDER BY TCM.C_BATCH_NO ";


            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取开坯实绩
        /// </summary>
        /// <param name="staID">工位</param>
        /// <returns></returns>
        public DataSet GetCogDownFact(string staID, DateTime start, DateTime end)
        {
            string sql = @"SELECT MAX(TS.C_STA_DESC)C_STA_DESC,
                                    TCP.C_BATCH_NO,
                                    MAX(TCP.C_STOVE)C_STOVE,
                                    MAX(TCP.C_SPEC)C_SPEC,
                                    MAX(TCP.N_LEN)N_LEN,
                                    SUM(TCP.N_WGT)N_WGT,
                                    COUNT(TCP.C_ID) N_QUA,
                                    COUNT(TCP2.C_ID) SCRAP,
                                    MAX(TCP.D_START_DATE)D_START_DATE,
                                    MAX(TCP.D_END_DATE) D_END_DATE,
                                    MAX(TCP.C_COGDOWN_SHIFT) C_COGDOWN_SHIFT,
                                    MAX(TCP.C_COGDOWN_GROUP)C_COGDOWN_GROUP,
                                    MAX(TCP.C_COGDOWN_SHIFT) C_SHIFT,
                                    MAX(TCP.C_COGDOWN_GROUP)C_GROUP,
                                    MAX(TCP.D_Q_DATE)D_Q_DATE,
                                    MAX(TCP.C_WE_EMP_ID)C_WE_EMP_ID, 
                                    MAX(TCP.C_REMARK)C_REMARK,
                                    MAX(TCP.C_WE_EMP_ID)C_WE_EMP_ID,        
                                    MAX(TCP.C_PLAN_ID) C_PLAN_ID,
                                    MAX(TCP.C_REMARK) C_REMARK,
                                    MAX(TCP.C_STL_GRD) C_STL_GRD,
                                    MAX(TCP.C_STD_CODE) C_STD_CODE,
                                    TCP.C_COGDOWN_ID
                               FROM TRC_COGDOWN_PRODUCT TCP
                               LEFT JOIN TB_STA TS  ON TS.C_ID = TCP.C_STA_ID
                               LEFT JOIN TRC_COGDOWN_PRODUCT TCP2 ON TCP2.C_BATCH_NO=TCP.C_BATCH_NO AND TCP2.C_MAT_TYPE='不合格品'
                               WHERE  TCP.C_COG_STA_ID='" + staID + "'  AND TCP.D_END_DATE BETWEEN TO_DATE('" + start.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD ')  AND   TO_DATE('" + end.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD ')    AND TCP.C_MAT_TYPE = '合格品' GROUP BY TCP.C_COGDOWN_ID,TCP.C_BATCH_NO   ORDER BY TCP.C_BATCH_NO  ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取开坯实绩
        /// </summary>
        /// <param name="staID">工位</param>
        /// <param name="desc">排序</param>
        /// <returns></returns>
        public DataSet GetCogDownFact(string staID, bool desc)
        {
            string sql = @" SELECT C_STA_DESC
                                       ,C_BATCH_NO
                                       ,C_STOVE
                                       ,C_SPEC
                                       ,N_LEN
                                       ,N_WGT
                                       ,N_QUA
                                       ,SCRAP
                                       ,D_START_DATE
                                       ,D_END_DATE
                                       ,C_COGDOWN_SHIFT
                                       ,C_COGDOWN_GROUP
                                       ,D_Q_DATE
                                       ,C_WE_EMP_ID
                                       ,C_PLAN_ID
                                        ,C_COGDOWN_ID
                                 FROM 
                                (SELECT MAX(TS.C_STA_DESC) C_STA_DESC,
                                       MAX(TCP.C_BATCH_NO) C_BATCH_NO,
                                       MAX(TCP.C_STOVE) C_STOVE,
                                       MAX(TCP.C_SPEC) C_SPEC,
                                       MAX(TCP.N_LEN) N_LEN,
                                       SUM(TCP.N_WGT) N_WGT,
                                       NVL((SELECT COUNT(C_COGDOWN_ID)
                                             FROM TRC_COGDOWN_PRODUCT
                                            WHERE C_MAT_TYPE = '合格品'
                                              AND C_COGDOWN_ID = TCP.C_COGDOWN_ID
                                            GROUP BY C_COGDOWN_ID),
                                           0) N_QUA,
                                       NVL((SELECT COUNT(C_COGDOWN_ID)
                                             FROM TRC_COGDOWN_PRODUCT
                                            WHERE C_MAT_TYPE = '不合格品'
                                              AND C_COGDOWN_ID = TCP.C_COGDOWN_ID
                                            GROUP BY C_COGDOWN_ID),
                                           0) SCRAP,
                                       MAX(TCP.D_START_DATE) D_START_DATE,
                                       MAX(TCP.D_END_DATE) D_END_DATE,
                                       MAX(TCP.C_COGDOWN_SHIFT) C_COGDOWN_SHIFT,
                                       MAX(TCP.C_COGDOWN_GROUP) C_COGDOWN_GROUP,
                                       MAX(TCP.D_Q_DATE) D_Q_DATE,
                                       MAX(TCP.C_WE_EMP_ID) C_WE_EMP_ID,
                                       MAX(TCP.C_REMARK) C_REMARK,
                                       MAX(TCP.C_PLAN_ID) C_PLAN_ID,
                                       C_COGDOWN_ID
                                  FROM TRC_COGDOWN_PRODUCT TCP
                                  LEFT JOIN TB_STA TS
                                    ON TS.C_ID = TCP.C_STA_ID
                                 WHERE TCP.C_COG_STA_ID = '" + staID + "' AND TCP.N_STATUS=1  GROUP BY TCP.C_COGDOWN_ID  ) T ";
            if (desc)
                sql += " ORDER BY  C_BATCH_NO  ";
            else
                sql += " ORDER BY  C_BATCH_NO DESC ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取开坯计划支数(根据组批主表id)
        /// </summary>
        /// <returns></returns>
        public object GetCogDownPlanNum(string id)
        {
            string sql = @"SELECT COUNT(TCP.C_ID) NUM  FROM TRC_COGDOWN_PRODUCT TCP WHERE TCP.C_COGDOWN_ID=:id ";
            OracleParameter[] parameters = {
                    new OracleParameter(":id", OracleDbType.Varchar2,100),
               };
            parameters[0].Value = id;
            return DbHelperOra.GetSingle(sql, parameters);
        }

        /// <summary>
        /// 获取开坯组批信息和计划信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetCogDownInfo(string id)
        {
            string sql = @"SELECT TPC.N_PW,TCM.* FROM TRC_COGDOWN_MAIN TCM
                                    LEFT JOIN TRP_PLAN_COGDOWN TPC ON TPC.C_ID=TCM.C_PLAN_ID
                                    WHERE TCM.C_ID='" + id + "'";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRC_COGDOWN_MAIN ");
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
            strSql.Append(")AS Row, T.*  from TRC_COGDOWN_MAIN T ");
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
        /// 获取自动同步执行人
        /// </summary>
        /// <returns></returns>
        public string GetUser()
        {
            string sql = @"SELECT T.C_USERACCOUNT FROM TB_AUTO_SYNC_USER T WHERE t.c_id='83E33914642705A9E055000000000001' ";
            return DbHelperOra.GetSingle(sql).ToString();
        }
        /// <summary>
        /// 获取出炉时间
        /// </summary>
        /// <returns></returns>
        public object GetOutTimeKp(string id)
        {
            string sql = @"SELECT MAX(TWF.D_MOD_DT) FROM TRC_WARM_FURNACE TWF
                                    WHERE TWF.C_TRC_ROLL_MAIN_ID='" + id + "'  ";
            sql += "  AND TWF.N_ROLL_STATE = 3  ";
            return DbHelperOra.GetSingle(sql);
        }
        /// <summary>
        /// A3是否已传
        /// </summary>
        /// <param name="batchNO">批次号</param>
        /// <param name="commpany">公司编码</param>
        /// <returns></returns>
        public int IsA3Repeat(string batchNO, string commpany)
        {
            string sql = @" SELECT COUNT(*) FROM XGERP50.IC_GENERAL_B@cap_erp  WHERE IC_GENERAL_B.DR = 0 AND PK_CORP = '1001' AND IC_GENERAL_B.CBODYBILLTYPECODE = '4D' AND IC_GENERAL_B.VUSERDEF20 = '" + batchNO + "' ";
            return Convert.ToInt32(DbHelperOra.GetSingle(sql).ToString());
        }
        /// <summary>
        /// 修改开坯实绩中间表状态
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateIfStatusCogDown(int status, string batchNo, string remark)
        {
            string sql = @"UPDATE TRC_COGDOWN_PRODUCT TCP SET TCP.N_IF_EXEC_STATUS=" + status + ", TCP.N_IF_EXEC_REMARK='" + remark + "' WHERE TCP.C_BATCH_NO='" + batchNo + "'  AND    TCP.N_STATUS=2  ";
            return DbHelperOra.ExecuteSql(sql);
        }
        public void InsertLog(string wgdId, string error)
        {
            string sql = @"INSERT INTO tb_auto_sync_log (c_error,c_wgd_id) VALUES('" + error + "','" + wgdId + "')";
            DbHelperOra.ExecuteSql(sql);
        }
        /// <summary>
        /// 获取开坯实绩合计
        /// </summary>
        /// <returns></returns>
        public DataSet GetCogDownFactSum(int status,string batchstr)
        {
            string sql = @"SELECT 
                                    C_MAT_TYPE
                                    ,TCP.C_STOVE
                                    ,TCP.C_STL_GRD
                                    ,TCP.C_SPEC
                                    ,TCP.N_LEN
                                    ,COUNT(C_ID) N_QUA
                                    ,SUM(TCP.N_WGT) N_WGT
                                    ,TCP.C_STD_CODE
                                    ,TCP.C_MAT_CODE
                                    ,TCP.C_MAT_NAME
                                    ,TCP.D_Q_DATE
                                    ,MAX(TCP.C_COGDOWN_SHIFT)C_COGDOWN_SHIFT
                                    ,MAX(TCP.C_COGDOWN_GROUP)C_COGDOWN_GROUP
                                    ,MAX(TCP.C_MOVE_SHIFT)C_MOVE_SHIFT
                                    ,MAX(TCP.C_MOVE_GROUP)C_MOVE_GROUP
                                    ,MAX(TCP.C_MOVE_SHIFT)C_SHIFT
                                    ,MAX(TCP.C_MOVE_GROUP)C_GROUP
                                    ,MAX(TCP.C_MOVE_ID)C_MOVE_ID
                                    ,MAX(TCP.C_MOVE_START)C_MOVE_START
                                    ,MAX(TCP.C_MOVE_END)C_MOVE_END
                                    ,MAX(TCP.C_STA_DESC)C_STA_DESC
                                    ,MAX(TCP.C_QR_USER)C_QR_USER
                                    ,TCP.C_COGDOWN_ID
                                    ,TCP.C_BATCH_NO
                                    ,TCP.C_SLABWH_CODE
                                    , (SELECT MAX(TT.D_CCM_DATE) FROM TSC_SLAB_MAIN TT WHERE TT.C_STOVE=TCP.C_STOVE)D_CCM_DATE
                                     ,MAX(TCP.N_IF_EXEC_STATUS) N_IF_EXEC_STATUS
                                     ,MAX(TCP.N_IF_EXEC_REMARK)N_IF_EXEC_REMARK
                                     ,TCP.C_REMARK
                                    FROM TRC_COGDOWN_PRODUCT TCP
                                    WHERE 1=1 AND  TCP.C_COG_STA_ID IN('" + batchstr+"') ";
            if (status != 0)
            {
                sql += "    AND TCP.N_STATUS = " + status + " ";
            }

            sql += "    AND TCP.N_IF_EXEC_STATUS   IS not  NULL ";


            sql += @"    GROUP BY TCP.C_MAT_TYPE,TCP.C_STOVE,TCP.C_STD_CODE,TCP.C_STL_GRD,TCP.C_SPEC,TCP.N_LEN,TCP.C_BATCH_NO,                               TCP.C_MAT_CODE,TCP.C_MAT_NAME,TCP.D_Q_DATE,TCP.C_COGDOWN_ID,TCP.C_SLABWH_CODE,TCP.C_REMARK  ";
            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 生成批号
        /// </summary>
        /// <param name="staID"></param>
        /// <returns></returns>
        public string CreateBranchNo(string staID)
        {
            string querySql = @"SELECT  T.N_FLAG from TB_STA T
                                               WHERE T.C_ID='" + staID + "'";
            object lineObj = DbHelperOra.GetSingle(querySql);


            string sql = @"SELECT * FROM 
                                    (
                                    SELECT  TRM.C_BATCH_NO FROM TRC_COGDOWN_MAIN TRM 
                                    WHERE   TRM.C_STA_ID='" + staID + "' ";
            sql += @" ORDER BY TRM.C_BATCH_NO DESC
                                    )
                                    WHERE rownum=1";
            var obj = DbHelperOra.GetSingle(sql);
            string no = "";

            if (obj != null)
                no = obj.ToString();

            int year = DateTime.Now.Year;
            if (!string.IsNullOrWhiteSpace(no))
            {
                no = string.Format("4{2}{0}{1}", year.ToString().Substring(2), ReCombine(no), lineObj.ToString());
            }
            else
            {
                no = string.Format("4{1}{0}00001", year.ToString().Substring(2), lineObj.ToString());
            }
            return no;
        }

        /// <summary>
        /// 重组批号
        /// </summary>
        /// <param name="no">最大批号</param>
        /// <returns></returns>
        public string ReCombine(string no)
        {
            string result = "";
            string str = no.Substring(4);
            int count = str.Length;
            int re = 0;
            re = Convert.ToInt32(str) + 1;
            int reCount = re.ToString().Length;
            for (int i = 0; i < count - reCount; i++)
            {
                result += "0";
            }
            result += re;
            return result;
        }

        /// <summary>
        /// 更新钢坯入炉状态
        /// </summary>
        /// <returns></returns>
        public int UpdatePutFurnaceType(string id, int putNum, out DataTable outSlabDt)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT * FROM 
                                    (SELECT TSM.C_ID C_SLAB_MAIN_ID FROM TRC_COGDOWN_MAIN TRM
                                    LEFT JOIN TRC_COGDOWN_MAIN_ITEM TRMI ON TRM.C_ID=TRMI.C_COGDOWN_MAIN_ID
                                    LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=TRMI.C_SLAB_MAIN_ID
                                    WHERE TSM.C_MOVE_TYPE='NP'
                                    AND TRM.C_ID=:id
                                    )
                                    WHERE ROWNUM<=:putNum ";
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            paras.Add(new OracleParameter() { ParameterName = ":putNum", Value = putNum });

            DataTable slabDt = DbHelperOra.Query(sql, paras.ToArray()).Tables[0];
            outSlabDt = slabDt;

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='R'
                                                    WHERE  TSM.C_ID IN( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += "'" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "'" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "',";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE='NP'   ";
            int resultCount = TransactionHelper.ExecuteSql(sqlExec);
            return resultCount;
        }

        /// <summary>
        /// 获取入炉信息
        /// </summary>
        /// <param name="staID">工位ID</param>
        /// <param name="staID">支数</param>
        /// <param name="staID">状态</param>
        /// <returns></returns>
        public DataSet GetFurnace(string staID, int num, int rollStatus)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT *
  FROM (SELECT *
          FROM TRC_WARM_FURNACE TWF
         WHERE TWF.N_ROLL_STATE = :rollStatus
           AND TWF.C_STA_ID = :staID
           AND TWF.N_STATUS=0
         ORDER BY TWF.C_BATCH_NO DESC) t
 WHERE ROWNUM <= :num
                                     ";
            paras.Add(new OracleParameter() { ParameterName = ":rollStatus", Value = rollStatus });
            paras.Add(new OracleParameter() { ParameterName = ":staID", Value = staID });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = num });
            return DbHelperOra.Query(sql, paras.ToArray());
        }


        /// <summary>
        /// 获取加热炉支数
        /// </summary>
        /// <param name="rollMainId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public int GetFurnaceNum(string rollMainId, int status)
        {
            string sql = @"SELECT  COUNT(T.C_ID) FROM TRC_WARM_FURNACE T  WHERE T.C_TRC_ROLL_MAIN_ID='" + rollMainId + "'  AND T.N_ROLL_STATE=" + status + " AND T.N_STATUS=0 ";
            object obj = DbHelperOra.GetSingle(sql);
            int result = obj == null ? 0 : int.Parse(obj.ToString());
            return result;
        }

        /// <summary>
        /// 更新钢坯状态
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <param name="newType">新状态</param>
        /// <param name="type">原状态</param>
        /// <param name="slabStatus">钢坯状态</param>
        /// <returns></returns>
        public int UpdateSlabMoveType(DataTable slabDt, string newType, string type, string slabStatus)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE=:newType ";
            if (!string.IsNullOrWhiteSpace(slabStatus))
                sqlExec += "   ,TSM.C_SLAB_STATUS='" + slabStatus + "' ";
            sqlExec += "  WHERE  TSM.C_ID IN( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += "'" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "'" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "',";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE=:type  ";

            paras.Add(new OracleParameter() { ParameterName = ":newType", Value = newType });
            paras.Add(new OracleParameter() { ParameterName = ":type", Value = type });

            int resultCount = TransactionHelper.ExecuteSql(sqlExec, paras.ToArray());
            return resultCount;
        }

        /// <summary>
        /// 更新钢坯状态
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <param name="newType">新状态</param>
        /// <param name="type">原状态</param>
        /// <param name="slabStatus">钢坯状态</param>
        /// <returns></returns>
        public int UpdateSlabMoveType(DataTable slabDt, string newType, string type, string slabStatus, string slabwhCode, string shift, string group, string userID)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE=:newType,TSM.C_SLABWH_AREA_CODE='' ";
            if (!string.IsNullOrWhiteSpace(slabStatus))
                sqlExec += "   ,TSM.C_SLAB_STATUS='" + slabStatus + "' ";

            if (!string.IsNullOrWhiteSpace(slabwhCode))
            {
                sqlExec += "   ,TSM.C_SLABWH_CODE='" + slabwhCode + "' ";
            }

            if (!string.IsNullOrWhiteSpace(shift))
                sqlExec += "   ,TSM.C_WE_SHIFT='" + shift + "' ";

            if (!string.IsNullOrWhiteSpace(group))
                sqlExec += "   ,TSM.C_WE_GROUP='" + group + "' ";

            if (!string.IsNullOrWhiteSpace(userID))
                sqlExec += "   ,TSM.C_WE_EMP_ID='" + userID + "' ";

            sqlExec += "  WHERE  TSM.C_ID IN( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += "'" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "'" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "',";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE=:type  ";

            paras.Add(new OracleParameter() { ParameterName = ":newType", Value = newType });
            paras.Add(new OracleParameter() { ParameterName = ":type", Value = type });

            int resultCount = TransactionHelper.ExecuteSql(sqlExec, paras.ToArray());
            return resultCount;
        }

        /// <summary>
        /// 更新入炉信息(入炉)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <returns></returns>
        public int UpdatePut(string id, int putNum, decimal pw, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            decimal wgt = putNum * pw;
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET TRM.N_QUA_JOIN=NVL(TRM.N_QUA_JOIN,0)+:num ,
                                        TRM.N_WGT_JOIN=NVL(TRM.N_WGT_JOIN,0)+:wgt ,
                                        TRM.N_QUA_TOTAL=TRM.N_QUA_TOTAL-:num,
                                        TRM.N_WGT_TOTAL=TRM.N_WGT_TOTAL-:wgt,
                                        TRM.C_REMARK=:remark
                                    WHERE TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":remark", Value = remark });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新入炉信息(入炉撤回)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <param name="putWgt">入炉重量</param>
        /// <param name="putWgt">备注</param>
        /// <returns></returns>
        public int BackPut(string id, int putNum, decimal wgt, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET     TRM.N_QUA_TOTAL=NVL(TRM.N_QUA_TOTAL,0)+:num
                                           ,TRM.N_WGT_TOTAL=NVL(TRM.N_WGT_TOTAL,0)+:wgt
                                           ,TRM.N_QUA_JOIN=TRM.N_QUA_JOIN-:num
                                           ,TRM.N_WGT_JOIN=TRM.N_WGT_JOIN-:wgt
                                           ,TRM.C_REMARK=:remark
                                    WHERE   TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":remark", Value = remark });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// (入炉剔除)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">支数</param>
        /// <param name="putWgt">重量</param>
        /// <param name="putWgt">备注</param>
        /// <returns></returns>
        public int ElimPut(string id, int putNum, decimal wgt, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET     TRM.N_QUA_ELIM=NVL(TRM.N_QUA_ELIM,0)+:num
                                           ,TRM.N_WGT_ELIM=NVL(TRM.N_WGT_ELIM,0)+:wgt
                                           ,TRM.N_QUA_TOTAL_VIRTUAL=TRM.N_QUA_TOTAL_VIRTUAL-:num
                                           ,TRM.N_WGT_TOTAL_VIRTUAL=TRM.N_WGT_TOTAL_VIRTUAL-:wgt
                                           ,TRM.N_QUA_TOTAL=TRM.N_QUA_TOTAL-:num
                                           ,TRM.N_WGT_TOTAL=TRM.N_WGT_TOTAL-:wgt
                                           ,TRM.C_REMARK=:remark
                                    WHERE   TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":remark", Value = remark });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新钢坯出炉状态
        /// </summary>
        /// <returns></returns>
        public int UpdateOutFurnaceType(string id, int putNum, out DataTable outSlabDt)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT * FROM 
                                    (SELECT TSM.C_ID C_SLAB_MAIN_ID FROM TRC_COGDOWN_MAIN TRM
                                    LEFT JOIN TRC_COGDOWN_MAIN_ITEM TRMI ON TRM.C_ID=TRMI.C_COGDOWN_MAIN_ID
                                    LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=TRMI.C_SLAB_MAIN_ID
                                    WHERE TSM.C_MOVE_TYPE='R'
                                    AND TRM.C_ID=:id
                                    )
                                    WHERE ROWNUM<=:putNum ";
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            paras.Add(new OracleParameter() { ParameterName = ":putNum", Value = putNum });

            DataTable slabDt = DbHelperOra.Query(sql, paras.ToArray()).Tables[0];
            outSlabDt = slabDt;

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='C'
                                                    WHERE  TSM.C_ID IN( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += "'" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "'" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "',";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE='R'   ";
            int resultCount = TransactionHelper.ExecuteSql(sqlExec);
            return resultCount;
        }

        /// <summary>
        /// 更新出炉信息(出炉)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        public int UpdateOut(string id, int putNum, decimal pw, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            decimal wgt = putNum * pw;
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET TRM.N_QUA_EXIT =NVL(TRM.N_QUA_EXIT,0)+:num ,
                                    TRM.N_WGT_EXIT =NVL(TRM.N_WGT_EXIT,0)+:wgt,
                                    TRM.N_QUA_JOIN=TRM.N_QUA_JOIN-:num,
                                    TRM.N_WGT_JOIN=TRM.N_WGT_JOIN-:wgt,
                                    TRM.C_REMARK=:remark
                                    WHERE TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":remark", Value = remark });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新出炉信息(撤回出炉)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <param name="putWgt">入炉重量</param>
        /// <param name="putWgt">备注</param>
        /// <returns></returns>
        public int BackOut(string id, int putNum, decimal putWgt, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET     TRM.N_QUA_JOIN=NVL(TRM.N_QUA_JOIN,0)+:num
                                           ,TRM.N_WGT_JOIN=NVL(TRM.N_WGT_JOIN,0)+:wgt
                                           ,TRM.N_QUA_EXIT=TRM.N_QUA_EXIT-:num
                                           ,TRM.N_WGT_EXIT=TRM.N_WGT_EXIT-:wgt
                                           ,TRM.C_REMARK=:remark
                                    WHERE   TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = putWgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = putWgt });
            paras.Add(new OracleParameter() { ParameterName = ":remark", Value = remark });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// (剔除出炉)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">支数</param>
        /// <param name="putWgt">重量</param>
        /// <param name="putWgt">备注</param>
        /// <returns></returns>
        public int ElimOut(string id, int putNum, decimal putWgt, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET     TRM.N_QUA_ELIM=NVL(TRM.N_QUA_ELIM,0)+:num
                                           ,TRM.N_WGT_ELIM=NVL(TRM.N_WGT_ELIM,0)+:wgt
                                           ,TRM.N_QUA_EXIT=TRM.N_QUA_EXIT-:num
                                           ,TRM.N_WGT_EXIT=TRM.N_WGT_EXIT-:wgt
                                           ,TRM.N_QUA_TOTAL_VIRTUAL=TRM.N_QUA_TOTAL_VIRTUAL-:num
                                           ,TRM.N_WGT_TOTAL_VIRTUAL=TRM.N_WGT_TOTAL_VIRTUAL-:wgt
                                           ,TRM.C_REMARK=:remark
                                    WHERE   TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = putWgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = putWgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = putWgt });
            paras.Add(new OracleParameter() { ParameterName = ":remark", Value = remark });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新开坯实绩
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <returns></returns>
        public int UpdateCogDownFact(string id, int putNum, decimal wgt, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            decimal factWgt = putNum * wgt;
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET TRM.N_QUA_EXIT=TRM.N_QUA_EXIT-:num,
                                        TRM.N_WGT_EXIT=TRM.N_WGT_EXIT-:wgt,
                                        TRM.N_ACCOM_TOTAL=NVL(TRM.N_ACCOM_TOTAL,0)+:num,
                                        TRM.N_ACCOM_WGT_TOTAL=NVL(TRM.N_ACCOM_WGT_TOTAL,0)+:wgt,
                                        TRM.C_REMARK=:remark
                                    WHERE TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = factWgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = factWgt });
            paras.Add(new OracleParameter() { ParameterName = ":remark", Value = remark });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新开坯组坯计划状态
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <returns></returns>
        public int UpdateCogDown(string id)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET TRM.N_STATUS=0
                                    WHERE TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return DbHelperOra.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新开坯组坯计划状态
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <returns></returns>
        public int UpdateCogDownTran(string id, int status)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET TRM.N_STATUS=" + status + "  WHERE TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新开坯计划
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <returns></returns>
        public int UpdatePlanSms(string stove, int putNum, decimal wgt, DateTime? start, DateTime? end, int type)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            decimal factWgt = putNum * wgt;
            string sql = @"UPDATE TSP_PLAN_SMS TRM 
                                    SET TRM.N_KP_WGT=TRM.N_KP_WGT" + (type == 1 ? "+" : "-") + ":wgt ";
            sql += "  ,TRM.D_KP_START_TIME=to_date('" + start.Value.Date.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            sql += "   ,TRM.D_KP_END_TIME=to_date('" + end.Value.Date.ToString("yyyyMMdd") + "','yyyy-mm-dd')  ";
            sql += "  WHERE TRM.C_STOVE_NO=:id";
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = factWgt });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = stove });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新钢坯消耗实绩
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <param name="putNum">出炉支数</param>
        /// <param name="putNum"></param>
        /// <param name="ccID">ccID</param>
        /// <returns></returns>
        public int UpdateExpendFact(string id, int putNum, out string slabID, out DataTable slabD)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT * FROM 
                                    (SELECT TSM.C_ID,TSM.C_STA_ID,TSM.C_STA_CODE,TSM.C_STA_DESC FROM TRC_COGDOWN_MAIN TRM
                                    LEFT JOIN TRC_COGDOWN_MAIN_ITEM TRMI ON TRM.C_ID=TRMI.C_COGDOWN_MAIN_ID
                                    LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=TRMI.C_SLAB_MAIN_ID
                                    WHERE TSM.C_MOVE_TYPE='C'
                                    AND TRM.C_ID=:id
                                    )
                                    WHERE ROWNUM<=:putNum ";
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            paras.Add(new OracleParameter() { ParameterName = ":putNum", Value = putNum });

            slabID = "";
            DataTable slabDt = DbHelperOra.Query(sql, paras.ToArray()).Tables[0];
            slabD = slabDt;
            for (int i = 0; i < slabDt.Rows.Count; i++)
            {
                slabID += slabDt.Rows[i]["C_ID"].ToString() + ",";
            }

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='EX'
                                                    ,TSM.C_QKP_STATE='N'
                                                    WHERE  TSM.C_ID IN( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += "'" + slabDt.Rows[i]["C_ID"] + "'";
                    else
                        sqlExec += "'" + slabDt.Rows[i]["C_ID"] + "',";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE='C'   ";
            int resultCount = TransactionHelper.ExecuteSql(sqlExec);
            return resultCount;
        }

        /// <summary>
        /// 撤回钢坯消耗实绩
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <param name="putNum">出炉支数</param>
        /// <returns></returns>
        public int BackExpendFact(string id, int putNum, out string slabID)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT * FROM 
                                    (SELECT TSM.C_ID FROM TRC_COGDOWN_MAIN TRM
                                    LEFT JOIN TRC_COGDOWN_MAIN_ITEM TRMI ON TRM.C_ID=TRMI.C_COGDOWN_MAIN_ID
                                    LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=TRMI.C_SLAB_MAIN_ID
                                    WHERE TSM.C_MOVE_TYPE='EX'
                                    AND TRM.C_ID=:id
                                    )
                                    WHERE ROWNUM<=:putNum ";
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            paras.Add(new OracleParameter() { ParameterName = ":putNum", Value = putNum });

            slabID = "";
            DataTable slabDt = DbHelperOra.Query(sql, paras.ToArray()).Tables[0];
            for (int i = 0; i < slabDt.Rows.Count; i++)
            {
                slabID += slabDt.Rows[i]["C_ID"].ToString() + ",";
            }


            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='C'
                                                    ,TSM.C_QKP_STATE='Y'
                                                    WHERE  ( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += " TSM.C_ID ='" + slabDt.Rows[i]["C_ID"] + "'";
                    else
                        sqlExec += "  TSM.C_ID ='" + slabDt.Rows[i]["C_ID"] + "' OR ";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE='EX'   ";
            int resultCount = TransactionHelper.ExecuteSql(sqlExec);
            return resultCount;
        }

        /// <summary>
        ///撤回开坯实绩
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <returns></returns>
        public int BackCogDownFact(string id, int putNum, decimal wgt, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_COGDOWN_MAIN TRM 
                                    SET TRM.N_QUA_EXIT=TRM.N_QUA_EXIT+:num,
                                        TRM.N_WGT_EXIT=TRM.N_WGT_EXIT+:wgt,
                                        TRM.N_ACCOM_TOTAL=TRM.N_ACCOM_TOTAL-:num,
                                        TRM.N_ACCOM_WGT_TOTAL=TRM.N_ACCOM_WGT_TOTAL-:wgt,
                                        TRM.C_REMARK=:remark
                                    WHERE TRM.C_ID=:id";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = putNum });
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = wgt });
            paras.Add(new OracleParameter() { ParameterName = ":remark", Value = remark });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 删除钢坯实绩
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCogDownFact(string id)
        {
            string sql = @"DELETE TRC_COGDOWN_PRODUCT TCP WHERE TCP.C_COGDOWN_ID='" + id + "' AND  TCP.N_STATUS=1 ";
            return TransactionHelper.ExecuteSql(sql);
        }

     
        /// <summary>
        /// 获取开坯实绩合计
        /// </summary>
        /// <returns></returns>
        public DataSet GetCogDownFactSum(int status, string staID, int type)
        {
            string sql = @"SELECT 
                                    C_MAT_TYPE
                                    ,TCP.C_STOVE
                                    ,TCP.C_STL_GRD
                                    ,TCP.C_SPEC
                                    ,TCP.N_LEN
                                    ,COUNT(C_ID) N_QUA
                                    ,SUM(TCP.N_WGT) N_WGT
                                    ,TCP.C_STD_CODE
                                    ,TCP.C_MAT_CODE
                                    ,TCP.C_MAT_NAME
                                    ,TCP.D_Q_DATE
                                    ,MAX(TCP.C_COGDOWN_SHIFT)C_COGDOWN_SHIFT
                                    ,MAX(TCP.C_COGDOWN_GROUP)C_COGDOWN_GROUP
                                    ,MAX(TCP.C_MOVE_SHIFT)C_MOVE_SHIFT
                                    ,MAX(TCP.C_MOVE_GROUP)C_MOVE_GROUP
                                    ,MAX(TCP.C_MOVE_SHIFT)C_SHIFT
                                    ,MAX(TCP.C_MOVE_GROUP)C_GROUP
                                    ,MAX(TCP.C_MOVE_ID)C_MOVE_ID
                                    ,MAX(TCP.C_MOVE_START)C_MOVE_START
                                    ,MAX(TCP.C_MOVE_END)C_MOVE_END
                                    ,MAX(TCP.C_STA_DESC)C_STA_DESC
                                    ,MAX(TCP.C_QR_USER)C_QR_USER
                                    ,TCP.C_COGDOWN_ID
                                    ,TCP.C_BATCH_NO
                                    ,TCP.C_SLABWH_CODE
                                    , (SELECT MAX(TT.D_CCM_DATE) FROM TSC_SLAB_MAIN TT WHERE TT.C_STOVE=TCP.C_STOVE)D_CCM_DATE
                                     ,MAX(TCP.N_IF_EXEC_STATUS) N_IF_EXEC_STATUS
                                     ,MAX(TCP.N_IF_EXEC_REMARK)N_IF_EXEC_REMARK
                                     ,TCP.C_REMARK
                                    FROM TRC_COGDOWN_PRODUCT TCP
                                    WHERE 1=1   AND  TCP.C_COG_STA_ID='" + staID + "' ";
            if (status != 0)
            {
                sql += "    AND TCP.N_STATUS = " + status + " ";
            }

            sql += "    AND TCP.N_IF_EXEC_STATUS   IS   NULL ";


            sql += @"    GROUP BY TCP.C_MAT_TYPE,TCP.C_STOVE,TCP.C_STD_CODE,TCP.C_STL_GRD,TCP.C_SPEC,TCP.N_LEN,TCP.C_BATCH_NO,                               TCP.C_MAT_CODE,TCP.C_MAT_NAME,TCP.D_Q_DATE,TCP.C_COGDOWN_ID,TCP.C_SLABWH_CODE,TCP.C_REMARK  ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取开坯实绩合计
        /// </summary>
        /// <param name="status">启用状态</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <param name="staID">组批主键</param>
        /// <param name="stove">炉号</param>
        /// <param name="stlgrd">钢种</param>
        /// <param name="spec">规格</param>
        /// <returns></returns>
        public DataSet GetCogDownFact_Stove(int status, string staID, string strTimeStart, string strTimeEnd, string stove, string stlgrd, string spec)
        {
            string sql = @"SELECT 
                                    C_MAT_TYPE
                                    ,TCP.C_STOVE
                                    ,TCP.C_STL_GRD
                                    ,TCP.C_SPEC
                                    ,TCP.N_LEN
                                    ,COUNT(C_ID) N_QUA
                                    ,SUM(TCP.N_WGT) N_WGT
                                    ,TCP.C_STD_CODE
                                    ,TCP.C_MAT_CODE
                                    ,TCP.C_MAT_NAME
                                    ,TCP.D_Q_DATE
                                    ,MAX(TCP.C_COGDOWN_SHIFT)C_COGDOWN_SHIFT
                                    ,MAX(TCP.C_COGDOWN_GROUP)C_COGDOWN_GROUP
                                    ,MAX(TCP.C_MOVE_SHIFT)C_MOVE_SHIFT
                                    ,MAX(TCP.C_MOVE_GROUP)C_MOVE_GROUP
                                    ,MAX(TCP.C_MOVE_SHIFT)C_SHIFT
                                    ,MAX(TCP.C_MOVE_GROUP)C_GROUP
                                    ,MAX(TCP.C_MOVE_ID)C_MOVE_ID
                                    ,MAX(TCP.C_MOVE_START)C_MOVE_START
                                    ,MAX(TCP.C_MOVE_END)C_MOVE_END
                                    ,MAX(TCP.C_STA_DESC)C_STA_DESC
                                    ,MAX(TCP.C_QR_USER) C_EMP_ID
                                    ,TCP.C_COGDOWN_ID
                                    ,TCP.C_BATCH_NO
                                    ,TCP.C_SLABWH_CODE
                                    , (SELECT MAX(TT.D_CCM_DATE) FROM TSC_SLAB_MAIN TT WHERE TT.C_STOVE=TCP.C_STOVE)D_CCM_DATE
                                     ,MAX(TCP.N_IF_EXEC_STATUS) N_IF_EXEC_STATUS
                                     ,MAX(TCP.N_IF_EXEC_REMARK)N_IF_EXEC_REMARK
                                     ,TCP.C_REMARK
                                    ,(SELECT OTST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC OTST   WHERE OTST.C_SLABWH_LOC_CODE = TCP.C_SLABWH_LOC_CODE   AND OTST.N_STATUS = 1) C_KW_CODE_NAME
                                     ,tcp.C_SLABWH_TIER_CODE 
                                    FROM TRC_COGDOWN_PRODUCT TCP
                                    WHERE 1=1   AND  TCP.C_COG_STA_ID='" + staID + "' ";
            if (status != 0)
            {
                if (status == 2) sql += "    AND TCP.N_STATUS >= " + status + " ";
                else sql += "    AND TCP.N_STATUS = " + status + " ";
            }
            else
            {
                sql += "    AND TCP.N_IF_EXEC_STATUS   IS  NOT  NULL ";
            }
            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                sql += " AND TCP.C_MOVE_START BETWEEN TO_DATE('" + strTimeStart + "', 'YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + strTimeEnd + "', 'YYYY-MM-DD HH24:MI:SS') ";
            }
            if (!string.IsNullOrEmpty(stove.Trim()))
            {
                sql += " and tcp.c_stove like '%" + stove + "%' ";
            }
            if (!string.IsNullOrEmpty(stlgrd.Trim()))
            {
                sql += " and upper(tcp.c_stl_grd) like upper('%" + stlgrd + "%') ";
            }
            if (!string.IsNullOrEmpty(spec.Trim()))
            {
                sql += " and tcp.c_spec like '%" + spec + "%' ";
            }

            sql += @"    GROUP BY TCP.C_MAT_TYPE,TCP.C_STOVE,TCP.C_STD_CODE,TCP.C_STL_GRD,TCP.C_SPEC,TCP.N_LEN,TCP.C_BATCH_NO,                               TCP.C_MAT_CODE,TCP.C_MAT_NAME,TCP.D_Q_DATE,TCP.C_COGDOWN_ID,TCP.C_SLABWH_CODE,TCP.C_REMARK,tcp.C_SLABWH_TIER_CODE,C_SLABWH_LOC_CODE  ";
            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 获取开坯实绩合计
        /// </summary>
        /// <returns></returns>
        public DataSet GetCogDownFactSum(int status, string staID, string sqlWhere)
        {
            string sql = @"SELECT 
                                    C_MAT_TYPE
                                    ,TCP.C_STOVE
                                    ,TCP.C_STL_GRD
                                    ,TCP.C_SPEC
                                    ,TCP.N_LEN
                                    ,COUNT(C_ID) N_QUA
                                    ,SUM(TCP.N_WGT) N_WGT
                                    ,TCP.C_STD_CODE
                                    ,TCP.C_MAT_CODE
                                    ,TCP.C_MAT_NAME
                                    ,TCP.D_Q_DATE
                                    ,MAX(TCP.C_COGDOWN_SHIFT)C_COGDOWN_SHIFT
                                    ,MAX(TCP.C_COGDOWN_GROUP)C_COGDOWN_GROUP
                                    ,MAX(TCP.C_MOVE_SHIFT)C_MOVE_SHIFT
                                    ,MAX(TCP.C_MOVE_GROUP)C_MOVE_GROUP
                                    ,MAX(TCP.C_MOVE_ID)C_MOVE_ID
                                    ,MAX(TCP.C_MOVE_START)C_MOVE_START
                                    ,MAX(TCP.C_MOVE_END)C_MOVE_END
                                    ,MAX(TCP.C_STA_DESC)C_STA_DESC
                                    ,MAX(TCP.C_QR_USER)C_QR_USER
                                    ,MAX(TCP.D_QR_DATE)D_QR_DATE
                                    ,MAX(TCP.D_START_DATE)D_START_DATE
                                    ,MAX(TCP.C_ZYX1)C_ZYX1
                                    ,MAX(TCP.C_ZYX2)C_ZYX2
                                    ,TCP.C_COGDOWN_ID
                                    ,TCP.C_BATCH_NO
                                    ,TCP.C_SLABWH_CODE
                                    , (SELECT MAX(TT.D_CCM_DATE) FROM TSC_SLAB_MAIN TT WHERE TT.C_STOVE=TCP.C_STOVE)D_CCM_DATE
                                     ,MAX(TCP.N_IF_EXEC_STATUS) N_IF_EXEC_STATUS
                                     ,MAX(TCP.N_IF_EXEC_REMARK)N_IF_EXEC_REMARK
                                    FROM TRC_COGDOWN_PRODUCT TCP
                                    WHERE 1=1   ";
            if (status != 0)
            {
                sql += "    AND TCP.N_STATUS = " + status + " ";
            }
            else
            {
                sql += "    AND TCP.N_STATUS   IS  NOT  NULL ";
            }

            if (sqlWhere.Trim() != "")
            {
                sql += "  "+ sqlWhere;
            }

            sql += @"    GROUP BY TCP.C_MAT_TYPE,TCP.C_STOVE,TCP.C_STD_CODE,TCP.C_STL_GRD,TCP.C_SPEC,TCP.N_LEN,TCP.C_BATCH_NO,                               TCP.C_MAT_CODE,TCP.C_MAT_NAME,TCP.D_Q_DATE,TCP.C_COGDOWN_ID,TCP.C_SLABWH_CODE
              ORDER BY  TCP.D_Q_DATE   ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取开坯实绩
        /// </summary>
        /// <returns></returns>
        public DataSet GetCogDownData(string id, string staID, int num)
        {
            string sql = @"SELECT * FROM TRC_COGDOWN_PRODUCT TCP
WHERE TCP.C_COGDOWN_ID='" + id + "'   AND TCP.C_COG_STA_ID='" + staID + "'   ";
            sql += "  AND ROWNUM<='" + num + "'  AND TCP.N_STATUS=1 ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 修改开坯实绩状态
        /// </summary>
        /// <param name="id">组批ID</param>
        /// <param name="num">支数</param>
        /// <param name="shift">班次</param>
        /// <param name="group">班组</param>
        /// <param name="start">调拨开始时间</param>
        /// <param name="end">调拨结束时间</param>
        /// <param name="empID">操作人</param>
        /// <returns></returns>
        public int UpCogDownStatus(string id, int num, string shift, string group, DateTime start, DateTime end, string empID, string slabwhCode, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_COGDOWN_PRODUCT TCP
                                    SET  TCP.N_STATUS=2  ";
            sql += "  , TCP.C_MOVE_SHIFT='" + shift + "'   ";
            sql += "  ,TCP.C_MOVE_GROUP ='" + group + "' ";
            sql += "  ,TCP.C_MOVE_START=to_date('" + start.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            sql += "   ,TCP.C_MOVE_END=to_date('" + end.ToString("yyyyMMdd") + "','yyyy-mm-dd')  ";
            sql += @" ,TCP.C_MOVE_ID='" + empID + "'  ";
            sql += @" ,TCP.C_SLABWH_CODE='" + slabwhCode + "'  ";
            sql += @" ,TCP.C_REMARK='" + remark + "'  ";
            sql += "  WHERE TCP.C_COGDOWN_ID = '" + id + "'  AND TCP.N_STATUS = 1 AND ROWNUM<= '" + num + "'  ";
            return TransactionHelper.ExecuteSql(sql);
        }

        /// <summary>
        /// 更新加热炉状态
        /// </summary>
        /// <param name="id">钢坯主键</param>
        /// <param name="rollStatus">状态1入炉 2出炉</param>
        /// <returns></returns>
        public int UpdateWarmFurnaceStatus(DataTable slabDt, int rollStatus, string shift, string group, string rollMainID)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_WARM_FURNACE TWF 
                                    SET TWF.N_ROLL_STATE=:rollStatus ";
            if (!string.IsNullOrWhiteSpace(shift))
                sql += "  ,TWF.C_SHIFT = '" + shift + "'   ";
            if (!string.IsNullOrWhiteSpace(group))
                sql += "  ,TWF.C_GROUP='" + group + "'  ";
            sql += " WHERE   ";

            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                sql += "(";
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sql += " TWF.C_SLAB_MAIN_ID='" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "' ";
                    else
                        sql += " TWF.C_SLAB_MAIN_ID='" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'  or  ";
                }
                sql += ")";
            }

            sql += "AND TWF.C_TRC_ROLL_MAIN_ID='" + rollMainID + "'";

            paras.Add(new OracleParameter() { ParameterName = ":rollStatus", Value = rollStatus });

            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }


        /// <summary>
        /// 创建ID
        /// </summary>
        /// <returns></returns>
        public string CreateID()
        {
            try
            {
                string id = string.Empty;
                string year = DateTime.Now.Year.ToString().Substring(2);
                string month = DateTime.Now.Month.ToString();
                id += "KP" + year + month;
                id += FillVacancy(DbHelperOra.GetSingle("  select   SEQ_COGDOWNID.NEXTVAL No   from  sys.dual  ").ToString());
                return id;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string FillVacancy(string serNum)
        {
            if (serNum.Length == 1)
                serNum = "0000" + serNum;
            else if (serNum.Length == 2)
                serNum = "000" + serNum;
            else if (serNum.Length == 3)
                serNum = "00" + serNum;
            else if (serNum.Length == 4)
                serNum = "0" + serNum;
            return serNum;
        }


        /// <summary>
        /// 获取开坯入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <returns></returns>
        public DataSet GetCogFact(string batchNo)
        {
            string sql = @"        SELECT TRP.C_SLABWH_CODE,             
                                             COUNT(TRP.C_ID) QUA,
                                             SUM(TRP.N_WGT) WGT,
                                             TRP.C_JUDGE_LEV_ZH
                                        FROM TSC_SLAB_MAIN TRP
                                       WHERE TRP.C_BATCH_NO = '" + batchNo + "'    GROUP BY TRP.C_SLABWH_CODE,TRP.C_JUDGE_LEV_ZH";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 修改开坯实绩中间表状态
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateProductStatus(int status, string batchNo)
        {
            string sql = @"UPDATE TRC_COGDOWN_PRODUCT TCP SET TCP.N_STATUS=" + status + "  WHERE TCP.C_BATCH_NO='" + batchNo + "'   ";
            return DbHelperOra.ExecuteSql(sql);
        }

        /// <summary>
        /// 修改开坯实绩中间表状态
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateIfStatus(int status, string batchNo, string remark)
        {
            string sql = @"UPDATE TRC_COGDOWN_PRODUCT TCP SET TCP.N_IF_EXEC_STATUS=" + status + ", TCP.N_IF_EXEC_REMARK='" + remark + "' WHERE TCP.C_BATCH_NO='" + batchNo + "'  AND    TCP.N_STATUS=2  ";
            return DbHelperOra.ExecuteSql(sql);
        }

        /// <summary>
        /// 关闭计划
        /// </summary>
        /// <returns></returns>
        public bool ClosePlan(string planID)
        {
            string sql = @"Delete TRP_PLAN_COGDOWN T WHERE T.C_ID='" + planID + "'";
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 完成计划
        /// </summary>
        /// <returns></returns>
        public bool SuccessPlan(string planID)
        {
            string sql = @"UPDATE TRP_PLAN_COGDOWN T
                                    SET T.N_STATUS=2
                                    WHERE T.C_ID='" + planID + "'";
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 完成计划
        /// </summary>
        /// <returns></returns>
        public bool UpdatePlanWgt(string planID, decimal wgt)
        {
            string sql = @"UPDATE TRP_PLAN_COGDOWN T  SET T.N_PROD_WGT=T.N_PROD_WGT+" + wgt + "  WHERE T.C_ID='" + planID + "'";
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 获取组坯相关钢坯主键
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetCogMainSlabIds(string id, int num)
        {
            string sql = @"SELECT *  FROM TRC_COGDOWN_MAIN_ITEM T  WHERE T.C_COGDOWN_MAIN_ID='" + id + "'  AND ROWNUM<=" + num + "  ";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 删除组坯钢坯关系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelCogMainItem(string id, string slabMainID)
        {
            string sql = @"DELETE TRC_COGDOWN_MAIN_ITEM T WHERE T.C_COGDOWN_MAIN_ID='" + id + "' AND T.C_SLAB_MAIN_ID='" + slabMainID + "' ";
            return TransactionHelper.ExecuteSql(sql);
        }

        public bool UpdateFurnaceTime(string rollMainId, DateTime dateTime)
        {
            string sql = @"UPDATE TRC_WARM_FURNACE T
                           SET T.D_MOD_DT=to_date('" + dateTime.ToString() + "','yyyy-mm-dd hh24:mi:ss')  WHERE T.C_TRC_ROLL_MAIN_ID='" + rollMainId + "' ";
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// wgd未上传NC条数
        /// </summary>
        /// <returns></returns>
        public object GetNotUpLoadWgdCount(string staID)
        {
            string sql = @"SELECT COUNT(T.C_ID) FROM TRC_COGDOWN_PRODUCT T WHERE 
                        T.C_COG_STA_ID='" + staID + "'";
            sql += " AND T.N_STATUS = 2 ";
            sql += "  AND ceil((To_date(to_char(SYSDATE,'yyyy-mm-dd hh24-mi-ss'), 'yyyy-mm-dd hh24-mi-ss') - To_date(to_char(t.d_Start_Date,'yyyy-mm-dd hh24-mi-ss') , 'yyyy-mm-dd hh24-mi-ss')) * 24)>5   ";
            return DbHelperOra.GetSingle(sql);
        }


        /// <summary>
        /// 获取开坯可组批钢坯
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public DataSet GetStl(string stove)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"SELECT 
                                    TSM.C_STOVE
                                    ,COUNT(TSM.C_STOVE) N_QUA
                                    ,MAX(TSM.C_STL_GRD)  C_STL_GRD
                                    ,MAX(TSM.C_SPEC) C_SPEC
                                    ,MAX(TSM.N_LEN) N_LEN
                                    ,MAX(TSM.C_REMARK) C_REMARK
                                    ,MAX(TSM.C_STD_CODE) C_STD_CODE
                                    ,SUM(TSM.N_WGT) WGTSUM
                                    ,MIN(TSM.N_WGT) N_WGT
                                    ,TSM.C_MAT_CODE
                                    ,TSM.C_MAT_NAME  ";

            sql += @"  FROM TSC_SLAB_MAIN TSM 
                                    WHERE   TSM.c_qkp_state ='Y'
                                      AND     TSM.c_Move_Type='E'  
                                    ";

            sql += "  AND  TSM.C_STOVE NOT IN (SELECT T.C_STOVE FROM TQC_SLAB_YC T ) ";


            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += @"  AND TSM.C_STOVE = :C_STOVE ";
                paras.Add(new OracleParameter() { ParameterName = ":C_STOVE", Value = stove });
            }

            sql += " GROUP BY TSM.C_STOVE,TSM.C_MAT_CODE,TSM.C_MAT_NAME ";
            sql += "  ORDER BY TSM.C_STOVE  ";

            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 获取开坯可组批钢坯
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public DataSet GetStlIds(string stove)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"SELECT 
                                    TSM.C_ID
                                    ,TSM.C_STOVE
                                    ,TSM.C_MAT_CODE
                                    ,TSM.C_MAT_NAME  ";

            sql += @"  FROM TSC_SLAB_MAIN TSM 
                                    WHERE   TSM.c_qkp_state ='Y'
                                      AND     TSM.c_Move_Type='E'  
                                    ";

            sql += "  AND  TSM.C_STOVE NOT IN (SELECT T.C_STOVE FROM TQC_SLAB_YC T ) ";


            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += @"  AND TSM.C_STOVE = :C_STOVE ";
                paras.Add(new OracleParameter() { ParameterName = ":C_STOVE", Value = stove });
            }


            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 获取开坯中间表
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <returns></returns>
        public DataTable GetCogdownMainItem(string id)
        {
            string sql = @" SELECT * FROM TRC_COGDOWN_MAIN_ITEM T WHERE T.C_COGDOWN_MAIN_ID='" + id + "' ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 修改钢坯状态
        /// </summary>
        /// <returns></returns>
        public bool UpdateSlabType(string sql)
        {
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 获取轧钢中间表
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <returns></returns>
        public DataTable GetCogdownMainItem(string id,int asseNum)
        {
            string sql = @" SELECT * FROM TRC_COGDOWN_MAIN_ITEM T WHERE T.C_COGDOWN_MAIN_ID='" + id + "' AND ROWNUM<=" + asseNum + " ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        #endregion  ExtensionMethod
    }
}
