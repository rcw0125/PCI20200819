using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_ROLL_MAIN
    /// </summary>
    public partial class Dal_TRC_ROLL_MAIN
    {
        public Dal_TRC_ROLL_MAIN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_MAIN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add_Tran(Mod_TRC_ROLL_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_MAIN(");
            strSql.Append("C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_TOTAL,N_WGT_TOTAL,C_STL_GRD_SLAB,C_SPEC_SLAB,C_EMP_ID,C_SHIFT,C_GROUP,D_MOD_DT,N_QUA_REMOVE,N_WGT_REMOVE,N_QUA_RETRUN,N_WGT_RETRUN,N_QUA_JOIN,N_WGT_JOIN,N_QUA_EXIT,N_WGT_EXIT,N_QUA_CPHALF,N_WGT_HALF,N_QUA_CPWHOLE,N_WGT_CPWHOLE,C_ROLL_STATE,C_FUR_TYPE,N_QUA_ELIM,N_WGT_ELIM,C_MAT_SLAB_CODE,C_MAT_SLAB_NAME,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_SLAB_NUM,D_PRODUCE_DATE_B,C_PRODUCE_EMP_ID,C_PRODUCE_SHIFT,C_PRODUCE_GROUP,D_PRODUCE_DATE_E,N_QUA_TOTAL_VIRTUAL,N_WGT_TOTAL_VIRTUAL,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_IS_MERGE,C_STD_CODE_SLAB)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_STA_ID,:C_PLANT,:C_STOVE,:C_BATCH_NO,:C_PLAN_ID,:N_QUA_TOTAL,:N_WGT_TOTAL,:C_STL_GRD_SLAB,:C_SPEC_SLAB,:C_EMP_ID,:C_SHIFT,:C_GROUP,:D_MOD_DT,:N_QUA_REMOVE,:N_WGT_REMOVE,:N_QUA_RETRUN,:N_WGT_RETRUN,:N_QUA_JOIN,:N_WGT_JOIN,:N_QUA_EXIT,:N_WGT_EXIT,:N_QUA_CPHALF,:N_WGT_HALF,:N_QUA_CPWHOLE,:N_WGT_CPWHOLE,:C_ROLL_STATE,:C_FUR_TYPE,:N_QUA_ELIM,:N_WGT_ELIM,:C_MAT_SLAB_CODE,:C_MAT_SLAB_NAME,:C_REMARK,:N_STATUS,:C_STD_CODE,:C_STL_GRD,:C_SPEC,:C_SLAB_NUM,:D_PRODUCE_DATE_B,:C_PRODUCE_EMP_ID,:C_PRODUCE_SHIFT,:C_PRODUCE_GROUP,:D_PRODUCE_DATE_E,:N_QUA_TOTAL_VIRTUAL,:N_WGT_TOTAL_VIRTUAL,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_IS_MERGE,:C_STD_CODE_SLAB)");
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
                    new OracleParameter(":D_PRODUCE_DATE_B", OracleDbType.Date),
                    new OracleParameter(":C_PRODUCE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PRODUCE_DATE_E", OracleDbType.Date),
                    new OracleParameter(":N_QUA_TOTAL_VIRTUAL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_TOTAL_VIRTUAL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_IS_MERGE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100)};
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
            parameters[38].Value = model.D_PRODUCE_DATE_B;
            parameters[39].Value = model.C_PRODUCE_EMP_ID;
            parameters[40].Value = model.C_PRODUCE_SHIFT;
            parameters[41].Value = model.C_PRODUCE_GROUP;
            parameters[42].Value = model.D_PRODUCE_DATE_E;
            parameters[43].Value = model.N_QUA_TOTAL_VIRTUAL;
            parameters[44].Value = model.N_WGT_TOTAL_VIRTUAL;
            parameters[45].Value = model.N_PROD_WGT;
            parameters[46].Value = model.N_WARE_WGT;
            parameters[47].Value = model.N_WARE_OUT_WGT;
            parameters[48].Value = model.N_IS_MERGE;
            parameters[49].Value = model.C_STD_CODE_SLAB;
            

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
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_MAIN(");
            strSql.Append("C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_TOTAL,N_WGT_TOTAL,C_STL_GRD_SLAB,C_SPEC_SLAB,C_EMP_ID,C_SHIFT,C_GROUP,D_MOD_DT,N_QUA_REMOVE,N_WGT_REMOVE,N_QUA_RETRUN,N_WGT_RETRUN,N_QUA_JOIN,N_WGT_JOIN,N_QUA_EXIT,N_WGT_EXIT,N_QUA_CPHALF,N_WGT_HALF,N_QUA_CPWHOLE,N_WGT_CPWHOLE,C_ROLL_STATE,C_FUR_TYPE,N_QUA_ELIM,N_WGT_ELIM,C_MAT_SLAB_CODE,C_MAT_SLAB_NAME,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_SLAB_NUM,D_PRODUCE_DATE_B,C_PRODUCE_EMP_ID,C_PRODUCE_SHIFT,C_PRODUCE_GROUP,D_PRODUCE_DATE_E,N_QUA_TOTAL_VIRTUAL,N_WGT_TOTAL_VIRTUAL,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_IS_MERGE,C_STD_CODE_SLAB)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_STA_ID,:C_PLANT,:C_STOVE,:C_BATCH_NO,:C_PLAN_ID,:N_QUA_TOTAL,:N_WGT_TOTAL,:C_STL_GRD_SLAB,:C_SPEC_SLAB,:C_EMP_ID,:C_SHIFT,:C_GROUP,:D_MOD_DT,:N_QUA_REMOVE,:N_WGT_REMOVE,:N_QUA_RETRUN,:N_WGT_RETRUN,:N_QUA_JOIN,:N_WGT_JOIN,:N_QUA_EXIT,:N_WGT_EXIT,:N_QUA_CPHALF,:N_WGT_HALF,:N_QUA_CPWHOLE,:N_WGT_CPWHOLE,:C_ROLL_STATE,:C_FUR_TYPE,:N_QUA_ELIM,:N_WGT_ELIM,:C_MAT_SLAB_CODE,:C_MAT_SLAB_NAME,:C_REMARK,:N_STATUS,:C_STD_CODE,:C_STL_GRD,:C_SPEC,:C_SLAB_NUM,:D_PRODUCE_DATE_B,:C_PRODUCE_EMP_ID,:C_PRODUCE_SHIFT,:C_PRODUCE_GROUP,:D_PRODUCE_DATE_E,:N_QUA_TOTAL_VIRTUAL,:N_WGT_TOTAL_VIRTUAL,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_IS_MERGE,:C_STD_CODE_SLAB)");
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
                    new OracleParameter(":D_PRODUCE_DATE_B", OracleDbType.Date),
                    new OracleParameter(":C_PRODUCE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PRODUCE_DATE_E", OracleDbType.Date),
                    new OracleParameter(":N_QUA_TOTAL_VIRTUAL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_TOTAL_VIRTUAL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_IS_MERGE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100)};
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
            parameters[38].Value = model.D_PRODUCE_DATE_B;
            parameters[39].Value = model.C_PRODUCE_EMP_ID;
            parameters[40].Value = model.C_PRODUCE_SHIFT;
            parameters[41].Value = model.C_PRODUCE_GROUP;
            parameters[42].Value = model.D_PRODUCE_DATE_E;
            parameters[43].Value = model.N_QUA_TOTAL_VIRTUAL;
            parameters[44].Value = model.N_WGT_TOTAL_VIRTUAL;
            parameters[45].Value = model.N_PROD_WGT;
            parameters[46].Value = model.N_WARE_WGT;
            parameters[47].Value = model.N_WARE_OUT_WGT;
            parameters[48].Value = model.N_IS_MERGE;
            parameters[49].Value = model.C_STD_CODE_SLAB;

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
        public bool Update(Mod_TRC_ROLL_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_MAIN set ");
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
            strSql.Append("C_SLAB_NUM=:C_SLAB_NUM,");
            strSql.Append("D_PRODUCE_DATE_B=:D_PRODUCE_DATE_B,");
            strSql.Append("C_PRODUCE_EMP_ID=:C_PRODUCE_EMP_ID,");
            strSql.Append("C_PRODUCE_SHIFT=:C_PRODUCE_SHIFT,");
            strSql.Append("C_PRODUCE_GROUP=:C_PRODUCE_GROUP,");
            strSql.Append("D_PRODUCE_DATE_E=:D_PRODUCE_DATE_E,");
            strSql.Append("N_QUA_TOTAL_VIRTUAL=:N_QUA_TOTAL_VIRTUAL,");
            strSql.Append("N_WGT_TOTAL_VIRTUAL=:N_WGT_TOTAL_VIRTUAL");
            strSql.Append("N_PROD_WGT=:N_PROD_WGT,");
            strSql.Append("N_WARE_WGT=:N_WARE_WGT,");
            strSql.Append("N_WARE_OUT_WGT=:N_WARE_OUT_WGT,");
            strSql.Append("N_IS_MERGE=:N_IS_MERGE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_TOTAL",OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_TOTAL",OracleDbType.Decimal,15),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_QUA_REMOVE",OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_REMOVE",OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_RETRUN",OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_RETRUN",OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_JOIN",OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_JOIN",OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_EXIT",OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_EXIT",OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_CPHALF",OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_HALF",OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_CPWHOLE",OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_CPWHOLE",OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_STATE",OracleDbType.Decimal,15),
                    new OracleParameter(":C_FUR_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_ELIM",OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_ELIM",OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_SLAB_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_SLAB_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS",OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_NUM", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PRODUCE_DATE_B", OracleDbType.Date),
                    new OracleParameter(":C_PRODUCE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PRODUCE_DATE_E", OracleDbType.Date),
                    new OracleParameter(":N_QUA_TOTAL_VIRTUAL",OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_TOTAL_VIRTUAL",OracleDbType.Decimal,15),
                        new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_IS_MERGE", OracleDbType.Decimal,1),
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
            parameters[37].Value = model.D_PRODUCE_DATE_B;
            parameters[38].Value = model.C_PRODUCE_EMP_ID;
            parameters[39].Value = model.C_PRODUCE_SHIFT;
            parameters[40].Value = model.C_PRODUCE_GROUP;
            parameters[41].Value = model.D_PRODUCE_DATE_E;
            parameters[42].Value = model.N_QUA_TOTAL_VIRTUAL;
            parameters[43].Value = model.N_WGT_TOTAL_VIRTUAL;
            parameters[44].Value = model.N_PROD_WGT;
            parameters[45].Value = model.N_WARE_WGT;
            parameters[46].Value = model.N_WARE_OUT_WGT;
            parameters[47].Value = model.N_IS_MERGE;
            parameters[48].Value = model.C_ID;

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
            strSql.Append("delete from TRC_ROLL_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRC_ROLL_MAIN ");
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
        public Mod_TRC_ROLL_MAIN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *   from TRC_ROLL_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_MAIN model = new Mod_TRC_ROLL_MAIN();
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
        /// <param name="batchNO"></param>
        /// <returns></returns>
        public Mod_TRC_ROLL_MAIN GetModels(string batchNO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *   from TRC_ROLL_MAIN ");
            strSql.Append(" where C_BATCH_NO=:batchNO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":batchNO", OracleDbType.Varchar2,100)         };
            parameters[0].Value = batchNO;

            Mod_TRC_ROLL_MAIN model = new Mod_TRC_ROLL_MAIN();
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
        public Mod_TRC_ROLL_MAIN DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_MAIN model = new Mod_TRC_ROLL_MAIN();
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
                if (row["D_PRODUCE_DATE_B"] != null && row["D_PRODUCE_DATE_B"].ToString() != "")
                {
                    model.D_PRODUCE_DATE_B = DateTime.Parse(row["D_PRODUCE_DATE_B"].ToString());
                }
                if (row["C_PRODUCE_EMP_ID"] != null)
                {
                    model.C_PRODUCE_EMP_ID = row["C_PRODUCE_EMP_ID"].ToString();
                }
                if (row["C_PRODUCE_SHIFT"] != null)
                {
                    model.C_PRODUCE_SHIFT = row["C_PRODUCE_SHIFT"].ToString();
                }
                if (row["C_PRODUCE_GROUP"] != null)
                {
                    model.C_PRODUCE_GROUP = row["C_PRODUCE_GROUP"].ToString();
                }
                if (row["D_PRODUCE_DATE_E"] != null && row["D_PRODUCE_DATE_E"].ToString() != "")
                {
                    model.D_PRODUCE_DATE_E = DateTime.Parse(row["D_PRODUCE_DATE_E"].ToString());
                }
                if (row["N_QUA_TOTAL_VIRTUAL"] != null && row["N_QUA_TOTAL_VIRTUAL"].ToString() != "")
                {
                    model.N_QUA_TOTAL_VIRTUAL = decimal.Parse(row["N_QUA_TOTAL_VIRTUAL"].ToString());
                }
                if (row["N_WGT_TOTAL_VIRTUAL"] != null && row["N_WGT_TOTAL_VIRTUAL"].ToString() != "")
                {
                    model.N_WGT_TOTAL_VIRTUAL = decimal.Parse(row["N_WGT_TOTAL_VIRTUAL"].ToString());
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
        public DataSet GetList(string strWhere, bool IsOrderDesc, int status)
        {
            string sql = @"SELECT 
                           MAX(TRM.C_ID) C_ID,
                           MAX(TPR.C_ORDER_NO)C_ORDER_NO,
                           MAX(TPR.C_CUST_NAME)C_CUST_NAME,
                           MAX(TPR.C_PACK)C_PACK,
                           MAX(TWF.C_TRC_ROLL_MAIN_ID) C_TRC_ROLL_MAIN_ID,
                           MAX(TRM.C_STOVE) C_STOVE,
                           TRM.C_BATCH_NO,
                           MAX(TRM.C_PLANT)C_PLANT,
                           MAX(TRM.C_STA_ID) C_STA_ID,
                           MAX(TA.C_STA_DESC) C_STA_DESC,
                           MAX(TRM.C_STL_GRD_SLAB) C_STL_GRD_SLAB,
                           MAX(TRM.C_SPEC_SLAB) C_SPEC_SLAB,
                           MAX(TRM.C_MAT_SLAB_CODE) C_MAT_SLAB_CODE,
                           MAX(TRM.C_STL_GRD) C_STL_GRD,
                           MAX(TRM.C_SPEC) C_SPEC，
                           MAX(TPR.C_MAT_CODE) C_MAT_CODE,
                           MAX(TRM.C_STD_CODE) C_STD_CODE,
                           MAX(TWF.C_EMP_ID) C_EMP_ID,
                           MAX(TWF.D_MOD_DT) D_MOD_DT,
                           MAX(TWF.C_SHIFT) C_SHIFT,
                           MAX(TWF.C_GROUP) C_GROUP,
                           MAX(TRM.C_REMARK) C_REMARK, 
                           MAX(TPR.C_FREE_TERM) C_FREE_TERM,
       MAX(TPR.C_FREE_TERM2) C_FREE_TERM2,";
            sql += "    (SELECT COUNT(C_ID) FROM TRC_WARM_FURNACE TWF1 WHERE TWF1.C_BATCH_NO=TRM.C_BATCH_NO AND TWF1.N_STATUS=0  AND TWF1.N_ROLL_STATE=" + status + " )N_QUA_JOIN, ";
            sql += "     (SELECT MAX(TWF1.N_WGT_JOIN) FROM TRC_WARM_FURNACE TWF1 WHERE TWF1.C_BATCH_NO=TRM.C_BATCH_NO AND TWF1.N_STATUS=0  AND TWF1.N_ROLL_STATE=" + status + " )*  (SELECT COUNT(C_ID)  FROM TRC_WARM_FURNACE TWF1  WHERE TWF1.C_BATCH_NO = TRM.C_BATCH_NO  AND TWF1.N_STATUS = 0  AND TWF1.N_ROLL_STATE = " + status + ")  N_WGT_JOIN ";
            sql += @"   FROM TRC_ROLL_MAIN TRM
            LEFT JOIN TRC_WARM_FURNACE TWF ON TWF.C_TRC_ROLL_MAIN_ID = TRM.C_ID
                           LEFT JOIN TB_STA TA ON TA.C_ID = TRM.C_STA_ID
                           LEFT JOIN TRP_PLAN_ROLL_ITEM TPR ON TPR.C_ID = TRM.C_PLAN_ID
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
        public DataSet GetListMain(string strWhere, bool IsOrderDesc)
        {
            string sql = @"SELECT
                                    TRM.C_ID,
                                    TRM.C_STA_ID,
                                    TRM.C_PLANT,
                                    TRM.C_STOVE,
                                    TRM.C_BATCH_NO,
                                    TRM.C_PLAN_ID,
                                    TRM.N_QUA_TOTAL,
                                    TRM.N_WGT_TOTAL,
                                    TRM.C_STL_GRD_SLAB,
                                    TRM.C_STD_CODE_SLAB,
                                    TRM.C_SPEC_SLAB,
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
                                    TPR.C_MAT_CODE,
                                    TRM.N_QUA_TOTAL_VIRTUAL,
                                    TRM.N_WGT_TOTAL_VIRTUAL,
                                    TPR.C_FREE_TERM,
                                    TPR.C_FREE_TERM2,
                                    TPR.C_ORDER_NO,
                                    TRM.C_EMP_ID,
                                    (SELECT TT.C_STA_DESC FROM TB_STA  TT WHERE TT.C_ID=TRM.C_STA_ID)C_STA_DESC,
                                    TPR.C_CUST_NAME,
                                    TPR.C_PACK,
                                     DECODE(TPR.C_AREA, '国际贸易部', '出口材', '') C_AREA
                                    FROM TRC_ROLL_MAIN TRM
                                    LEFT JOIN TS_USER TU ON TU.C_ID=TRM.C_EMP_ID
                                    LEFT JOIN TB_STA TA ON TA.C_ID=TRM.C_STA_ID
                                    LEFT JOIN TRP_PLAN_ROLL_ITEM TPR    ON TPR.C_ID=TRM.C_PLAN_ID
                                    WHERE TRM.N_STATUS = 1 ";

            if (strWhere.Trim() != "")
            {
                sql += strWhere;
            }

            if (IsOrderDesc)
                sql += "  ORDER BY TRM.C_BATCH_NO   ";
            else
                sql += "  ORDER BY TRM.C_BATCH_NO  DESC ";

            return DbHelperOra.Query(sql);
        }



        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRC_ROLL_MAIN ");
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_MAIN T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取最大批号
        /// </summary>
        public string GetMaxPH(string c_sta_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.c_batch_no)+1 as c_batch_no from trc_roll_main t where t.c_sta_id='" + c_sta_id + "' ");

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

        #endregion  BasicMethod

        #region  ExtensionMethod

        /// <summary>
        ///根据计划id，批号获取数据列表
        /// </summary>
        public DataSet GetListByPidAndBid(string C_PLAN_ID, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_TOTAL,N_WGT_TOTAL,C_STL_GRD_SLAB,C_SPEC_SLAB,C_EMP_ID,C_SHIFT,C_GROUP,D_MOD_DT,N_QUA_REMOVE,N_WGT_REMOVE,N_QUA_RETRUN,N_WGT_RETRUN,N_QUA_JOIN,N_WGT_JOIN,N_QUA_EXIT,N_WGT_EXIT,N_QUA_CPHALF,N_WGT_HALF,N_QUA_CPWHOLE,N_WGT_CPWHOLE,C_ROLL_STATE,C_FUR_TYPE,N_QUA_ELIM,N_WGT_ELIM,C_MAT_SLAB_CODE,C_MAT_SLAB_NAME,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC");
            strSql.Append(" FROM TRC_ROLL_MAIN WHERE 1=1");

            if (C_PLAN_ID != "")
            {
                strSql.Append(" AND C_PLAN_ID='" + C_PLAN_ID + "' ");
            }
            if (C_BATCH_NO != "")
            {
                strSql.Append(" AND C_BATCH_NO='" + C_BATCH_NO + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        ///根据 批号获取数据列表
        /// </summary>
        public DataSet GetList_Batch(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_TOTAL,N_WGT_TOTAL,C_STL_GRD_SLAB,C_SPEC_SLAB,C_EMP_ID,C_SHIFT,C_GROUP,D_MOD_DT,N_QUA_REMOVE,N_WGT_REMOVE,N_QUA_RETRUN,N_WGT_RETRUN,N_QUA_JOIN,N_WGT_JOIN,N_QUA_EXIT,N_WGT_EXIT,N_QUA_CPHALF,N_WGT_HALF,N_QUA_CPWHOLE,N_WGT_CPWHOLE,C_ROLL_STATE,C_FUR_TYPE,N_QUA_ELIM,N_WGT_ELIM,C_MAT_SLAB_CODE,C_MAT_SLAB_NAME,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC");
            strSql.Append(" FROM TRC_ROLL_MAIN WHERE 1=1");

            if (C_BATCH_NO != "")
            {
                strSql.Append(" AND C_BATCH_NO='" + C_BATCH_NO + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取线材实绩信息
        /// </summary>
        /// <param name="begin">组批时间 开始</param>
        /// <param name="end">组批时间 结束</param>
        /// <param name="pland">车间</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public DataSet GetProductList(DateTime begin, DateTime end, string pland, string batch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.c_sta_id,a.c_sta_desc,T.N_STATUS, t.N_QUA_TOTAL_VIRTUAL, t.n_wgt_total_virtual , t.C_STOVE, t.C_BATCH_NO,  t.C_STL_GRD, t.C_STD_CODE, t.C_SPEC, t.C_SHIFT, t.C_GROUP, t.C_ID , t.D_MOD_DT,t.C_REMARK,(SELECT COUNT(1) FROM TQC_PRESENT_SAMPLES TT WHERE TT.N_STATUS=1 AND TT.C_BATCH_NO=T.C_BATCH_NO)AS ADDNUM,TT.C_FREE_TERM,TT.C_FREE_TERM2  ");
            strSql.Append(" from TRC_ROLL_MAIN t JOIN TB_STA a on t.c_sta_id=a.c_id LEFT JOIN TRC_ROLL_WGD TT  ON TT.C_MAIN_ID = T.C_ID where T.N_STATUS=1 ");
            if (begin != null && end != null)
            {
                strSql.Append("and t.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (pland != "全部")
            {
                strSql.Append(" and a.c_sta_desc ='" + pland + "' ");
            }
            if (!string.IsNullOrEmpty(batch))
            {
                strSql.Append(" and t.C_BATCH_NO like '" + batch + "%' ");
            }
            strSql.Append("  order by t.D_MOD_DT ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 生成批号
        /// </summary>
        /// <returns></returns>
        public string CreateBranchNo(string staID)
        {
            string querySql = @"SELECT  T.N_FLAG from TB_STA T
                                               WHERE T.C_ID='" + staID + "'";
            object lineObj = DbHelperOra.GetSingle(querySql);


            string sql = @"SELECT * FROM 
                                    (
                                    SELECT  TRM.C_BATCH_NO FROM TRC_ROLL_MAIN TRM 
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
                no = string.Format("3{2}{0}{1}", year.ToString().Substring(2), ReCombine(no), lineObj.ToString());
            }
            else
            {
                no = string.Format("3{1}{0}00001", year.ToString().Substring(2), lineObj.ToString());
            }
            return no;
        }

        /// <summary>
        /// 生成批号(撤回)
        /// </summary>
        /// <returns></returns>
        public string CreateBranchNo(int type)
        {
            string sql = @"SELECT * FROM 
                                    (
                                    SELECT  TRM.C_BATCH_NO FROM TRC_ROLL_MAIN TRM                         
                                    ORDER BY TRM.C_BATCH_NO DESC
                                    )
                                    WHERE rownum=1";
            var obj = DbHelperOra.GetSingle(sql);
            string no = "";
            if (obj == null)
            {
                int year = DateTime.Now.Year;
                no = string.Format("31{0}00001", year.ToString().Substring(2));
            }
            else
            {
                no = obj.ToString();
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
                                    (SELECT TSM.C_ID C_SLAB_MAIN_ID FROM TRC_ROLL_MAIN TRM
                                    LEFT JOIN TRC_ROLL_MAIN_ITEM TRMI ON TRM.C_ID=TRMI.C_ROLL_MAIN_ID
                                    LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=TRMI.C_SLAB_MAIN_ID
                                    WHERE TSM.C_MOVE_TYPE='DZ'
                                    AND TRM.C_ID=:id
                                    )
                                    WHERE ROWNUM<=:putNum ";
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            paras.Add(new OracleParameter() { ParameterName = ":putNum", Value = putNum });

            DataTable slabDt = DbHelperOra.Query(sql, paras.ToArray()).Tables[0];
            outSlabDt = slabDt;

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='R'
                                                    WHERE  ( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += " TSM.C_ID= '" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "   TSM.C_ID='" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "' OR ";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE='DZ'   ";
            int resultCount = TransactionHelper.ExecuteSql(sqlExec);
            return resultCount;
        }

        /// <summary>
        /// 更新钢坯出炉状态
        /// </summary>
        /// <param name="id">组坯表主键</param>
        /// <param name="putNum">支数</param>
        /// <param name="outSlabDt">钢坯Dt</param>
        /// <returns></returns>
        public int UpdateOutFurnaceType(string id, int putNum, out DataTable outSlabDt)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = "";
            if (putNum == 0)
            {
                sql += @"SELECT * FROM 
                                    (SELECT TSM.C_ID C_SLAB_MAIN_ID FROM TRC_ROLL_MAIN TRM
                                    LEFT JOIN TRC_ROLL_MAIN_ITEM TRMI ON TRM.C_ID=TRMI.C_ROLL_MAIN_ID
                                    LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=TRMI.C_SLAB_MAIN_ID
                                    WHERE TRM.C_ID=:id
                                    )";
                paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
            }
            else
            {
                sql = @"SELECT * FROM 
                                    (SELECT TSM.C_ID C_SLAB_MAIN_ID FROM TRC_ROLL_MAIN TRM
                                    LEFT JOIN TRC_ROLL_MAIN_ITEM TRMI ON TRM.C_ID=TRMI.C_ROLL_MAIN_ID
                                    LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=TRMI.C_SLAB_MAIN_ID
                                    WHERE TSM.C_MOVE_TYPE='R'
                                    AND TRM.C_ID=:id
                                    )
                                    WHERE ROWNUM<=:putNum ";
                paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });
                paras.Add(new OracleParameter() { ParameterName = ":putNum", Value = putNum });
            }

            DataTable slabDt = DbHelperOra.Query(sql, paras.ToArray()).Tables[0];
            outSlabDt = slabDt;

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='C'
                                                    WHERE   ( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += " TSM.C_ID=  '" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += " TSM.C_ID=  '" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "' OR ";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE='R'   ";
            int resultCount = TransactionHelper.ExecuteSql(sqlExec);
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
        public int UpdateSlabMoveType(DataTable slabDt, string newType, string type, string slabStatus)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE=:newType ";
            if (!string.IsNullOrWhiteSpace(slabStatus))
                sqlExec += "   ,TSM.C_SLAB_STATUS='" + slabStatus + "' ";
            sqlExec += "  WHERE   ( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += "   TSM.C_ID= '" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "   TSM.C_ID= '" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "' OR ";
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
        public int UpdateSlabMoveType(DataTable slabDt, string newType, string type, string slabStatus, DataTable unQualifiedDt, string shift, string group, string userID)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE=:newType ";
            if (!string.IsNullOrWhiteSpace(slabStatus))
                sqlExec += "   ,TSM.C_SLAB_STATUS='" + slabStatus + "' ";

            //if (unQualifiedDt != null && unQualifiedDt.Rows.Count > 0)
            //{
            //    sqlExec += "   ,TSM.C_SLABWH_AREA_CODE='" + unQualifiedDt.Rows[0]["C_SLABWH_AREA_CODE"].ToString() + "' ";
            //}

            if (!string.IsNullOrWhiteSpace(shift))
                sqlExec += "   ,TSM.C_WE_SHIFT='" + shift + "' ";

            if (!string.IsNullOrWhiteSpace(group))
                sqlExec += "   ,TSM.C_WE_GROUP='" + group + "' ";

            if (!string.IsNullOrWhiteSpace(userID))
                sqlExec += "   ,TSM.C_WE_EMP_ID='" + userID + "' ";

            sqlExec += "  WHERE   ( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += "  TSM.C_ID= '" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "  TSM.C_ID= '" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "' OR ";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE=:type  ";

            paras.Add(new OracleParameter() { ParameterName = ":newType", Value = newType });
            paras.Add(new OracleParameter() { ParameterName = ":type", Value = type });

            int resultCount = TransactionHelper.ExecuteSql(sqlExec, paras.ToArray());
            return resultCount;
        }

        /// <summary>
        /// 更新钢坯撤回出炉状态
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <param name="putNum">出炉支数</param>
        /// <returns></returns>
        public int UpdateBackOutFurnaceType(DataTable slabDt)
        {

            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='R'
                                                    WHERE (  ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += " TSM.C_ID= '" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "  TSM.C_ID=  '" + slabDt.Rows[i]["C_SLAB_MAIN_ID"] + "'   or  ";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE='C'   ";
            int resultCount = TransactionHelper.ExecuteSql(sqlExec);
            return resultCount;
        }

        /// <summary>
        /// 更新入炉信息(入炉)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <param name="remark">入炉支数</param>
        /// <param name="pw">单重</param>
        /// <returns></returns>
        public int UpdatePut(string id, int putNum, string remark, decimal pw)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            decimal wgt = putNum * pw;
            string sql = @"UPDATE TRC_ROLL_MAIN TRM 
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
        /// 更新出炉信息(出炉)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        public int UpdateOut(string id, int putNum, string remark, decimal pw)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            decimal wgt = putNum * pw;
            string sql = @"UPDATE TRC_ROLL_MAIN TRM 
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
        /// 更新入炉信息(撤回入炉)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <param name="putWgt">入炉重量</param>
        /// <param name="putWgt">备注</param>
        /// <returns></returns>
        public int BackPut(string id, int putNum, decimal putWgt, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            decimal wgt = putNum * putWgt;
            string sql = @"UPDATE TRC_ROLL_MAIN TRM 
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
            decimal wgt = putNum * putWgt;
            string sql = @"UPDATE TRC_ROLL_MAIN TRM 
                                    SET     TRM.N_QUA_JOIN=NVL(TRM.N_QUA_JOIN,0)+:num
                                           ,TRM.N_WGT_JOIN=NVL(TRM.N_WGT_JOIN,0)+:wgt
                                           ,TRM.N_QUA_EXIT=TRM.N_QUA_EXIT-:num
                                           ,TRM.N_WGT_EXIT=TRM.N_WGT_EXIT-:wgt
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
        /// (剔除入炉)
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">支数</param>
        /// <param name="putWgt">重量</param>
        /// <param name="putWgt">备注</param>
        /// <returns></returns>
        public int ElimPut(string id, int putNum, decimal putWgt, string remark)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_ROLL_MAIN TRM 
                                    SET     TRM.N_QUA_ELIM=NVL(TRM.N_QUA_ELIM,0)+:num
                                           ,TRM.N_WGT_ELIM=NVL(TRM.N_WGT_ELIM,0)+:wgt
                                           ,TRM.N_QUA_TOTAL_VIRTUAL=TRM.N_QUA_TOTAL_VIRTUAL-:num
                                           ,TRM.N_WGT_TOTAL_VIRTUAL=TRM.N_WGT_TOTAL_VIRTUAL-:wgt
                                           ,TRM.N_QUA_TOTAL=TRM.N_QUA_TOTAL-:num
                                           ,TRM.N_WGT_TOTAL=TRM.N_WGT_TOTAL-:wgt
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
            string sql = @"UPDATE TRC_ROLL_MAIN TRM 
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
        /// 获取加热炉信息
        /// </summary>
        /// <param name="staID">工位ID</param>
        /// <param name="num">支数</param>
        /// <param name="roll_status">状态</param>
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
        /// 更新加热炉状态
        /// </summary>
        /// <param name="id">钢坯主键</param>
        /// <param name="rollStatus">状态1入炉 2出炉</param>
        /// <returns></returns>
        public int UpdateWarmFurnaceStatus(DataTable slabDt, int rollStatus, string shift, string group, DateTime time, string rollMainID)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"UPDATE TRC_WARM_FURNACE TWF 
                                    SET TWF.N_ROLL_STATE=:rollStatus
                                    ,TWF.C_SHIFT='" + shift + "'   ";
            sql += " ,  TWF.D_MOD_DT=to_date('" + time.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
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

            sql += " AND TWF.C_TRC_ROLL_MAIN_ID='" + rollMainID + "'  ";

            paras.Add(new OracleParameter() { ParameterName = ":rollStatus", Value = rollStatus });

            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 获取不合格库位
        /// </summary>
        /// <returns></returns>
        public DataTable GetUnqualifiedSlabwhCode(string slabwhCode)
        {
            string sql = @"SELECT * FROM TPB_SLABWH_AREA T  WHERE T.C_SLABWH_AREA_CODE LIKE  '" + slabwhCode + "%'   AND T.C_SLABWH_AREA_NAME='不合格区'";
            return DbHelperOra.Query(sql).Tables[0];
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
                id += "WG" + year + month;
                id += FillVacancy(DbHelperOra.GetSingle("  select   SEQ_ROLLID.NEXTVAL No   from  sys.dual  ").ToString());
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
        /// 关闭计划
        /// </summary>
        /// <param name="planID"></param>
        /// <returns></returns>
        public bool ClosePlan(string planID, string remark)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL_ITEM T  SET T.N_STATUS=4  WHERE T.C_ID='" + planID + "'";
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
        /// 关闭计划
        /// </summary>
        /// <param name="planID"></param>
        /// <returns></returns>
        public bool UpdatePlanWgt(string planID, decimal wgt)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL T  SET T.N_ISSUE_WGT=" + wgt + " ,T.N_STATUS=0 WHERE T.C_ID = '" + planID + "'";
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
        /// 关闭计划
        /// </summary>
        /// <param name="planID"></param>
        /// <returns></returns>
        public bool UpdatePlanWgts(string planID, decimal wgt)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL T  SET T.N_ISSUE_WGT=T.N_ISSUE_WGT-" + wgt + " ,T.N_STATUS=0 WHERE T.C_ID = '" + planID + "'";
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
        /// 关闭合并订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ClosePlanRollItemInfo(string id)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL_ITEM_INFO T
                            SET T.N_STATUS=5
                            WHERE T.C_ID='" + id + "'  ";

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
        /// <param name="planID"></param>
        /// <returns></returns>
        public bool SuccessPlan(string planID)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL_ITEM T
                                     SET T.N_STATUS=3
                                     WHERE T.C_ID='" + planID + "'";
            int rows = DbHelperOra.ExecuteSql(sql);
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
        /// 获取钢坯库存
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="spec">断面</param>
        /// <param name="std">执行标准</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public DataTable GetSlabInventory(string grd, string spec, string std, string slabwhCode, string matCode, string length, DataTable replaceStl)
        {

            string sql = @"SELECT TSM.C_STOVE,
                                       TSM.C_BATCH_NO,
                                     COUNT(TSM.C_STOVE) N_QUA,
                                     MAX(TSM.C_STL_GRD) C_STL_GRD,
                                     MAX(TSM.C_SPEC) C_SPEC,
                                     MAX(TSM.N_LEN) N_LEN,
                                     TSM.C_STD_CODE C_STD_CODE,
                                     SUM(TSM.N_WGT) WGTSUM,
                                     MIN(TSM.N_WGT) N_WGT,
                                     TSM.C_SLABWH_CODE,
                                    (SELECT TS.C_SLABWH_NAME FROM   TPB_SLABWH TS WHERE TS.C_SLABWH_CODE=TSM.C_SLABWH_CODE AND TS.N_STATUS=1)C_SLABWH_CODE_NAME,
                                    (SELECT TSA.C_SLABWH_AREA_NAME FROM TPB_SLABWH_AREA TSA  WHERE TSA.C_SLABWH_AREA_CODE = TSM.C_SLABWH_AREA_CODE  AND TSA.N_STATUS = 1)C_SLABWH_AREA_CODE_NAME,
                                    (SELECT TST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC TST WHERE TST.C_SLABWH_LOC_CODE = TSM.C_SLABWH_LOC_CODE AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME,
                                    TSM.C_SLABWH_TIER_CODE ,
                                    (SELECT MAX(TT.C_SLABWH_TIER_CODE) FROM TSC_SLAB_MAIN TT WHERE TT.C_SLABWH_LOC_CODE=TSM.C_SLABWH_LOC_CODE AND TT.C_MOVE_TYPE='E') MAXTIER,
                                     MAX(TSM.C_SLABWH_LOC_CODE) C_SLABWH_LOC_CODE,
                                     MAX(TSM.C_SLABWH_AREA_CODE) C_SLABWH_AREA_CODE,
                                     MAX(TSA.C_STA_DESC) C_STA_ID,
                                     TSM.C_MAT_CODE,
                                     TSM.C_MAT_NAME,
                                     TSM.C_REMARK,
                                     TSM.C_MOVE_TYPE
                                FROM TSC_SLAB_MAIN TSM
                                LEFT JOIN TB_STA TSA
                                  ON TSA.C_ID = TSM.C_STA_ID
                               WHERE 1=1  AND  (TSM.C_MOVE_TYPE='E' OR  TSM.C_MOVE_TYPE='M')  ";

            if (!string.IsNullOrWhiteSpace(slabwhCode))
            {
                sql += " AND TSM.C_SLABWH_CODE ='" + slabwhCode + "'";
            }

            sql += "  AND TSM.C_SPEC = '" + spec + "'  ";

            sql += "  AND TSM.C_MAT_CODE = '" + matCode + "'  ";

            if (!string.IsNullOrWhiteSpace(length))
                sql += "  AND TSM.N_LEN = '" + length + "'  ";

            if (!string.IsNullOrWhiteSpace(grd))
            {
                sql += "  AND   (  ";
                sql += "  (TSM.C_STL_GRD='" + grd + "' AND TSM.C_STD_CODE='" + std + "')  ";
                if (replaceStl != null && replaceStl.Rows.Count > 0)
                {
                    for (int i = 0; i < replaceStl.Rows.Count; i++)
                    {
                        sql += "OR  (TSM.C_STL_GRD='" + replaceStl.Rows[i]["C_REPLACE_GRD"] + "' AND TSM.C_STD_CODE='" + replaceStl.Rows[i]["C_REPLACE_STD_CODE"] + "')  ";
                    }
                }
                sql += ") ";
            }
            else
            {
                sql += "  AND TSM.C_STD_CODE = '" + std + "'  ";
            }

            sql += @"  GROUP BY TSM.C_BATCH_NO,
                                        TSM.C_STOVE,
                                        TSM.C_STD_CODE,
                                        TSM.C_MAT_CODE,
                                        TSM.C_MAT_NAME,
                                        TSM.C_REMARK,
                                        TSM.C_SLABWH_CODE,
                                        TSM.C_MOVE_TYPE ,
                                        TSM.C_SLABWH_CODE,
                                        TSM.C_SLABWH_AREA_CODE,
                                        TSM.C_SLABWH_LOC_CODE,
                                        TSM.C_SLABWH_TIER_CODE 
                                            ";

            sql += "  ORDER BY TSM.C_SLABWH_TIER_CODE ";

            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 获取钢坯库存
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="matCode">物料编码</param>
        /// <returns></returns>
        public DataTable GetSlabInventory(string grd, string std, string slabwhCode, DataTable replaceStl)
        {

            string sql = @"SELECT TSM.C_STOVE,
                                    TSM.C_BATCH_NO,
                                     COUNT(TSM.C_STOVE) N_QUA,
                                     MAX(TSM.C_STL_GRD) C_STL_GRD,
                                     MAX(TSM.C_SPEC) C_SPEC,
                                     MAX(TSM.N_LEN) N_LEN,
                                     TSM.C_STD_CODE C_STD_CODE,
                                     SUM(TSM.N_WGT) WGTSUM,
                                     MIN(TSM.N_WGT) N_WGT,
                                     TSM.C_SLABWH_CODE,
                                    (SELECT TS.C_SLABWH_NAME FROM   TPB_SLABWH TS WHERE TS.C_SLABWH_CODE=TSM.C_SLABWH_CODE AND TS.N_STATUS=1)C_SLABWH_CODE_NAME,
                                    (SELECT TSA.C_SLABWH_AREA_NAME FROM TPB_SLABWH_AREA TSA  WHERE TSA.C_SLABWH_AREA_CODE = TSM.C_SLABWH_AREA_CODE  AND TSA.N_STATUS = 1) C_SLABWH_AREA_CODE_NAME,
                                    (SELECT TST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC TST WHERE TST.C_SLABWH_LOC_CODE = TSM.C_SLABWH_LOC_CODE AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME,
                                     TSM.C_SLABWH_TIER_CODE ,
                                     (SELECT MAX(TT.C_SLABWH_TIER_CODE) FROM TSC_SLAB_MAIN TT WHERE TT.C_SLABWH_LOC_CODE=TSM.C_SLABWH_LOC_CODE AND TT.C_MOVE_TYPE='E') MAXTIER,
                                     MAX(TSM.C_SLABWH_LOC_CODE) C_SLABWH_LOC_CODE,
                                     MAX(TSM.C_SLABWH_AREA_CODE) C_SLABWH_AREA_CODE,
                                     MAX(TSA.C_STA_DESC) C_STA_ID,
                                     TSM.C_MAT_CODE,
                                     TSM.C_MAT_NAME,
                                     TSM.C_REMARK,
                                     TSM.C_MOVE_TYPE
                                FROM TSC_SLAB_MAIN TSM
                                LEFT JOIN TB_STA TSA
                                  ON TSA.C_ID = TSM.C_STA_ID
                               WHERE 1=1   AND TSM.C_SPEC!='280*325'  AND (TSM.C_MOVE_TYPE='E' OR TSM.C_MOVE_TYPE='M') ";

            if (!string.IsNullOrWhiteSpace(slabwhCode))
            {
                sql += " AND TSM.C_SLABWH_CODE ='" + slabwhCode + "'";
            }


            if (!string.IsNullOrWhiteSpace(grd))
            {
                sql += "  AND   (  ";
                sql += "  (TSM.C_STL_GRD='" + grd + "' AND TSM.C_STD_CODE='" + std + "')  ";
                if (replaceStl != null && replaceStl.Rows.Count > 0)
                {
                    for (int i = 0; i < replaceStl.Rows.Count; i++)
                    {
                        sql += "OR  (TSM.C_STL_GRD='" + replaceStl.Rows[i]["C_REPLACE_GRD"] + "' AND TSM.C_STD_CODE='" + replaceStl.Rows[i]["C_REPLACE_STD_CODE"] + "')  ";
                    }
                }
                sql += ") ";
            }
            else
            {
                sql += "  AND TSM.C_STD_CODE = '" + std + "'  ";
            }

            sql += @"  GROUP BY TSM.C_BATCH_NO,
                                        TSM.C_STOVE,
                                        TSM.C_STD_CODE,
                                        TSM.C_MAT_CODE,
                                        TSM.C_MAT_NAME,
                                        TSM.C_REMARK,
                                        TSM.C_SLABWH_CODE,
                                        TSM.C_MOVE_TYPE ,
                                        TSM.C_SLABWH_CODE,
                                        TSM.C_SLABWH_AREA_CODE,
                                        TSM.C_SLABWH_LOC_CODE,
                                        TSM.C_SLABWH_TIER_CODE 
                                            ";

            sql += "  ORDER BY  TSM.C_SLABWH_TIER_CODE  DESC ";

            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取钢坯单重
        /// </summary>
        /// <returns></returns>
        public DataTable GetSlabInfo(string id)
        {
            string sql = "SELECT * FROM TSC_SLAB_MAIN T WHERE T.C_ID = '" + id + "'";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取组坯相关钢坯主键
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetRollMainSlabIds(string id, int num)
        {
            string sql = @"SELECT *  FROM TRC_ROLL_MAIN_ITEM T  WHERE T.C_ROLL_MAIN_ID='" + id + "'  AND ROWNUM<=" + num + "  ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 删除组坯钢坯关系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelRollMainItem(string id, string slabMainID)
        {
            string sql = @"DELETE TRC_ROLL_MAIN_ITEM T WHERE T.C_ROLL_MAIN_ID='" + id + "' AND T.C_SLAB_MAIN_ID='" + slabMainID + "' ";
            return TransactionHelper.ExecuteSql(sql);
        }

        public bool UpdateFurnaceTime(string rollMainId, DateTime Date)
        {
            string sql = @"UPDATE TRC_WARM_FURNACE T
                           SET T.D_MOD_DT=to_date('" + Date.ToString() + "','yyyy-mm-dd hh24:mi:ss')  WHERE T.C_TRC_ROLL_MAIN_ID='" + rollMainId + "' ";
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
        /// 获取组批信息
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="strTime1">组批时间</param>
        /// <param name="strTime2">组批时间</param>
        /// <param name="C_STA_ID">轧线</param>
        /// <returns></returns>
        public DataSet GetList(string C_BATCH_NO, string strTime1, string strTime2, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TRM.C_ID, TRM.C_STA_ID, TA.C_STA_CODE, TA.C_STA_DESC, TRM.C_PLANT, TRM.C_STOVE, TRM.C_BATCH_NO, TRM.C_PLAN_ID, TRM.C_STL_GRD_SLAB, TRM.C_SPEC_SLAB, TU.C_NAME, TRM.C_SHIFT, TRM.C_GROUP, TRM.D_MOD_DT, DECODE(TRM.C_ROLL_STATE,'0','未轧制','') as C_ROLL_STATE,TRM.C_MAT_SLAB_CODE, TRM.C_MAT_SLAB_NAME, TRM.C_REMARK, TRM.N_STATUS, TRM.C_STD_CODE, TRM.C_STL_GRD, TRM.C_SPEC, TPR.C_MAT_CODE, TRM.N_QUA_TOTAL_VIRTUAL, TRM.N_WGT_TOTAL_VIRTUAL, TPR.C_FREE_TERM, TPR.C_FREE_TERM2, TPR.C_ORDER_NO, TPR.C_PACK  FROM TRC_ROLL_MAIN TRM  LEFT JOIN TS_USER TU ON TU.C_ID = TRM.C_EMP_ID  LEFT JOIN TB_STA TA ON TA.C_ID = TRM.C_STA_ID  LEFT JOIN TRP_PLAN_ROLL_ITEM TPR ON TPR.C_ID = TRM.C_PLAN_ID ");

            strSql.Append(" WHERE TRM.N_STATUS = 1 ");

            if (!string.IsNullOrEmpty(C_BATCH_NO))
            {
                strSql.Append(" and TRM.C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }

            if (!string.IsNullOrEmpty(strTime1) && !string.IsNullOrEmpty(strTime2))
            {
                strSql.Append(" and TRM.D_MOD_DT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            if (!string.IsNullOrEmpty(C_STA_ID))
            {
                strSql.Append(" and TRM.C_STA_ID = '" + C_STA_ID + "' ");
            }

            strSql.Append(" ORDER BY TA.C_STA_CODE ASC,TRM.C_BATCH_NO DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取最后一个组坯信息
        /// </summary>
        /// <param name="staId">工位ID</param>
        /// <returns></returns>
        public DataTable GetLastRoll(string staID, string smallBatchNo)
        {
            string sql = @"SELECT * FROM 
                                    (
                                    SELECT  TRM.* FROM TRC_ROLL_MAIN TRM 
                                    WHERE   TRM.C_STA_ID='" + staID + "'   AND TRM.C_BATCH_NO='" + smallBatchNo + "'  ";
            sql += @" ORDER BY TRM.C_BATCH_NO DESC
                                    )
                                    WHERE rownum=1";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取今天TRC_ROLL_TIME记录
        /// </summary>
        /// <param name="staId">工位ID</param>
        /// <returns></returns>
        public DataTable GetRollTime_Today(string staID)
        {
            string sql = @"SELECT * FROM TRC_ROLL_TIME  TRT  WHERE TRT.C_STA_ID='" + staID + "' AND TRT.C_RQ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取换规格时间
        /// </summary>
        /// <returns></returns>
        public DataTable GetChangeSpecTime(string staID, string bSpec, string spec)
        {
            string sql = @"SELECT * FROM TPB_CHANGESPEC_TIME TCT WHERE  TCT.C_STA_ID='" + staID + "' AND TCT.C_B_SPEC='" + bSpec + "'  AND TCT.C_L_SPEC='" + spec + "'";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取出炉记录条数
        /// </summary>
        /// <returns></returns>
        public int GetOutFurnaceCount(string batchNo)
        {
            int re = 0;
            string sql = @"SELECT COUNT(TWF.C_ID) FROM TRC_WARM_FURNACE TWF
                           WHERE TWF.C_BATCH_NO='" + batchNo + "'  AND TWF.N_ROLL_STATE=3  ";
            object obj = DbHelperOra.GetSingle(sql);
            re = obj == null ? 0 : int.Parse(obj.ToString());
            return re;
        }

        /// <summary>
        /// 修改计划时间
        /// </summary>
        /// <param name="id">计划主键</param>
        /// <param name="start">计划开始时间</param>
        /// <param name="end">计划结束时间</param>
        /// <returns></returns>
        public bool UpdatePlanTime(string id, DateTime start, DateTime end)
        {
            string sql = @"UPDATE  TRP_PLAN_ROLL_ITEM T 
                         SET T.D_P_START_TIME=to_date('" + start.ToString() + "','yyyy-mm-dd hh24:mi:ss') ";
            sql += "   , T.D_P_END_TIME=to_date('" + end.ToString() + "','yyyy-mm-dd hh24:mi:ss') ";
            sql += "     WHERE T.C_ID='" + id + "'    ";
            int rows = DbHelperOra.ExecuteSql(sql);
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
        /// 获取用户名称
        /// </summary>
        /// <returns></returns>
        public string GetUserName(string id)
        {
            string sql = @"SELECT T.C_NAME FROM  TS_USER T WHERE T.C_ID='" + id + "' ";
            return DbHelperOra.GetSingle(sql).ToString();
        }

        /// <summary>
        /// 获取钢坯长度
        /// </summary>
        /// <returns></returns>
        public DataTable GetSlab(string stove)
        {
            string sql = @" SELECT * from tsc_slab_main t WHERE t.c_stove='" + stove + "'  AND t.c_spec!='280*325'  ";
            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 获取钢坯长度
        /// </summary>
        /// <returns></returns>
        public DataTable GetSlabs(string stove)
        {
            string sql = @" SELECT * from tsc_slab_main t WHERE t.c_stove='" + stove + "'  AND t.c_spec='280*325'  ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        ///获取剔除记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetTCJL(DateTime start)
        {
            string sql = @"SELECT 
                           O.* ,
                           (SELECT A.C_STL_GRD FROM TSC_SLAB_MAIN A WHERE A.C_ID=O.C_SLAB_MAIN_ID)C_STL_GRD,
                           (SELECT A.C_SPEC FROM TSC_SLAB_MAIN A WHERE A.C_ID=O.C_SLAB_MAIN_ID)C_SPEC,
                           (SELECT A.C_STD_CODE FROM TSC_SLAB_MAIN A WHERE A.C_ID=O.C_SLAB_MAIN_ID)C_STD_CODE
                           FROM 
                           (
                           SELECT T.C_BATCH_NO,
                           COUNT(T.C_BATCH_NO) N_QUA,
                           MIN(T.C_SLAB_MAIN_ID)C_SLAB_MAIN_ID,
                           MIN(T.C_EMP_ID)C_EMP_ID
                           FROM TRC_WARM_FURNACE_LOG T WHERE T.N_ROLL_STATE=3 AND T.D_MOD_DT>TO_DATE('" + start.Date.ToString("yyyy-MM-dd") + " 00:00:00','yyyy-mm-dd hh24:mi:ss')   GROUP BY T.C_BATCH_NO,T.C_TRC_ROLL_MAIN_ID   )O ORDER BY O.C_BATCH_NO            ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 根据炉号获取钢坯
        /// </summary>
        /// <param name="stove"></param>
        /// <returns></returns>
        public DataTable GetStl(string stove)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"SELECT 
                                    TSM.C_STOVE
                                    ,TSM.C_BATCH_NO
                                    ,COUNT(TSM.C_STOVE) N_QUA
                                    ,MAX(TSM.C_STL_GRD)  C_STL_GRD
                                    ,MAX(TSM.C_SPEC) C_SPEC
                                    ,MAX(TSM.N_LEN) N_LEN
                                    ,TSM.C_STD_CODE C_STD_CODE
                                    ,SUM(TSM.N_WGT) WGTSUM
                                    ,MIN(TSM.N_WGT) N_WGT                                 
                                    ,TSM.C_MAT_CODE
                                    ,TSM.C_MAT_NAME
                                    ,TSM.C_REMARK
                                    FROM TSC_SLAB_MAIN TSM 
                                    LEFT JOIN  TB_STA TSA ON TSA.C_ID=TSM.C_STA_ID
                                    WHERE TSM.c_Move_Type='E'   AND TSM.C_SPEC!='280*325'                                                            
                                    ";



            sql += "  AND  TSM.C_STOVE NOT IN (SELECT T.C_STOVE FROM TQC_SLAB_YC T ) ";

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += @"  AND TSM.C_STOVE = :C_STOVE ";
                paras.Add(new OracleParameter() { ParameterName = ":C_STOVE", Value = stove });
            }

            sql += " GROUP BY TSM.C_BATCH_NO,TSM.C_STOVE ,TSM.C_STD_CODE,TSM.C_MAT_CODE,TSM.C_MAT_NAME,TSM.C_REMARK ";
            sql += " ORDER BY TSM.C_BATCH_NO  DESC ";

            return DbHelperOra.Query(sql, paras.ToArray()).Tables[0];
        }

        /// <summary>
        /// 根据炉号获取钢坯主键
        /// </summary>
        /// <param name="stove"></param>
        /// <returns></returns>
        public DataTable GetStlIds(string stove, int asseNum)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"SELECT 
                                    TSM.C_ID
                                    ,TSM.C_STOVE
                                    ,TSM.C_BATCH_NO
                                    ,TSM.C_STD_CODE C_STD_CODE                      
                                    ,TSM.C_MAT_CODE
                                    ,TSM.C_MAT_NAME
                                    ,TSM.C_REMARK
                                    FROM TSC_SLAB_MAIN TSM 
                                    LEFT JOIN  TB_STA TSA ON TSA.C_ID=TSM.C_STA_ID
                                    WHERE TSM.c_Move_Type='E'   AND TSM.C_SPEC!='280*325'                                                            
                                    ";

            sql += "  AND  TSM.C_STOVE NOT IN (SELECT T.C_STOVE FROM TQC_SLAB_YC T ) ";

            if (asseNum != 0)
            {
                sql += @" AND ROWNUM<=" + asseNum + " ";
            }

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += @"  AND TSM.C_STOVE = :C_STOVE ";
                paras.Add(new OracleParameter() { ParameterName = ":C_STOVE", Value = stove });
            }
            return DbHelperOra.Query(sql, paras.ToArray()).Tables[0];
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
        public DataTable GetRollMainItem(string id)
        {
            string sql = @" SELECT * FROM TRC_ROLL_MAIN_ITEM T WHERE T.C_ROLL_MAIN_ID='" + id + "' ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取钢坯中间表
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <returns></returns>
        public DataTable GetRollMainItem(string id, int asseNum)
        {
            string sql = @" SELECT * FROM TRC_ROLL_MAIN_ITEM T WHERE T.C_ROLL_MAIN_ID='" + id + "'  AND ROWNUM<=" + asseNum + " ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 补批时修改量
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool UpdateSupWgt(Mod_TRC_ROLL_MAIN m)
        {
            string sql = @" UPDATE TRC_ROLL_MAIN T SET T.N_QUA_TOTAL_VIRTUAL=" + m.N_QUA_TOTAL_VIRTUAL + "  ,T.N_WGT_TOTAL_VIRTUAL=" + m.N_WGT_TOTAL_VIRTUAL + " ,T.N_QUA_EXIT=" + m.N_QUA_EXIT + "  ,T.N_WGT_EXIT=" + m.N_WGT_EXIT + " WHERE T.C_ID='" + m.C_ID + "' ";

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

        #endregion  ExtensionMethod
    }
}

