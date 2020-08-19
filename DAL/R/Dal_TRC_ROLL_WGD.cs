using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_ROLL_WGD
    /// </summary>
    public partial class Dal_TRC_ROLL_WGD
    {
        public Dal_TRC_ROLL_WGD()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_WGD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsWgd(string C_ID)
        {
            bool bol = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_WGD ");
            strSql.Append(" where C_MAIN_ID=:C_ID  ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            object obj = DbHelperOra.GetSingle(strSql.ToString(), parameters);
            int re = int.Parse(obj.ToString());
            if (re > 0)
            {
                bol = true;
            }
            return bol;
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsWgdSecond(string C_ID)
        {
            bool bol = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_WGD ");
            strSql.Append(" where C_MAIN_ID=:C_ID  and  N_SCRF!=0  ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            object obj = DbHelperOra.GetSingle(strSql.ToString(), parameters);
            int re = int.Parse(obj.ToString());
            if (re > 0)
            {
                bol = true;
            }
            return bol;
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_WGD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_WGD(");
            strSql.Append("C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_PRODUCE,N_WGT_PRODUCE,D_MOD_DT,C_ROLL_STATE,C_FUR_TYPE,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,D_PRODUCE_DATE,C_PRODUCE_EMP_ID,C_PRODUCE_SHIFT,C_PRODUCE_GROUP,C_SX,C_PCLX,C_MAIN_ID,C_SCX_NC,C_PACK,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_ZPDJBZ,N_SCRF,C_MRSX,D_PRODUCE_DATE_B,D_PRODUCE_DATE_E,C_MAT_CODE,C_MAT_DESC,C_PRODUCE_SHIFT_NAME,C_PRODUCE_GROUP_NAME,N_IF_EXEC_STATUS,N_IF_EXEC_REMARK,N_QUA_CASTOFF,N_QUA_CUTTING,C_EMP_ID,N_QUA_SUCCESS,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_HG_WGT,N_DP_WGT,N_GP_WGT,N_XY_WGT,N_TW_WGT,N_BHG_WGT,N_HG_WGT_IN,N_GP_WGT_IN,N_XY_WGT_IN,N_TW_WGT_IN,N_BHG_WGT_IN,N_HG_WGT_OUT,N_GP_WGT_OUT,N_XY_WGT_OUT,N_TW_WGT_OUT,N_BHG_WGT_OUT,D_SALE_TIME_MIN,D_SALE_TIME_MAX,N_SLAB_XH_WGT,C_SLAB_TYPE,D_SWEEP_START,D_SWEEP_END,N_IS_MERGE)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_STA_ID,:C_PLANT,:C_STOVE,:C_BATCH_NO,:C_PLAN_ID,:N_QUA_PRODUCE,:N_WGT_PRODUCE,:D_MOD_DT,:C_ROLL_STATE,:C_FUR_TYPE,:C_REMARK,:N_STATUS,:C_STD_CODE,:C_STL_GRD,:C_SPEC,:D_PRODUCE_DATE,:C_PRODUCE_EMP_ID,:C_PRODUCE_SHIFT,:C_PRODUCE_GROUP,:C_SX,:C_PCLX,:C_MAIN_ID,:C_SCX_NC,:C_PACK,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_ZPDJBZ,:N_SCRF,:C_MRSX,:D_PRODUCE_DATE_B,:D_PRODUCE_DATE_E,:C_MAT_CODE,:C_MAT_DESC,:C_PRODUCE_SHIFT_NAME,:C_PRODUCE_GROUP_NAME,:N_IF_EXEC_STATUS,:N_IF_EXEC_REMARK,:N_QUA_CASTOFF,:N_QUA_CUTTING,:C_EMP_ID,:N_QUA_SUCCESS,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_HG_WGT,:N_DP_WGT,:N_GP_WGT,:N_XY_WGT,:N_TW_WGT,:N_BHG_WGT,:N_HG_WGT_IN,:N_GP_WGT_IN,:N_XY_WGT_IN,:N_TW_WGT_IN,:N_BHG_WGT_IN,:N_HG_WGT_OUT,:N_GP_WGT_OUT,:N_XY_WGT_OUT,:N_TW_WGT_OUT,:N_BHG_WGT_OUT,:D_SALE_TIME_MIN,:D_SALE_TIME_MAX,:N_SLAB_XH_WGT,:C_SLAB_TYPE,:D_SWEEP_START,:D_SWEEP_END,:N_IS_MERGE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_PRODUCE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_PRODUCE", OracleDbType.Decimal,15),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ROLL_STATE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_FUR_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PRODUCE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PRODUCE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SCX_NC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZPDJBZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SCRF", OracleDbType.Decimal),
                    new OracleParameter(":C_MRSX", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_PRODUCE_DATE_B", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_E", OracleDbType.Date),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_SHIFT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_GROUP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IF_EXEC_STATUS", OracleDbType.Decimal),
                    new OracleParameter(":N_IF_EXEC_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_QUA_CASTOFF", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_CUTTING", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_SUCCESS", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_SALE_TIME_MIN", OracleDbType.Date),
                    new OracleParameter(":D_SALE_TIME_MAX", OracleDbType.Date),
                    new OracleParameter(":N_SLAB_XH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SWEEP_START", OracleDbType.Date),
                    new OracleParameter(":D_SWEEP_END", OracleDbType.Date),
                    new OracleParameter(":N_IS_MERGE", OracleDbType.Decimal,1)};

            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_PLANT;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_PLAN_ID;
            parameters[6].Value = model.N_QUA_PRODUCE;
            parameters[7].Value = model.N_WGT_PRODUCE;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_ROLL_STATE;
            parameters[10].Value = model.C_FUR_TYPE;
            parameters[11].Value = model.C_REMARK;
            parameters[12].Value = model.N_STATUS;
            parameters[13].Value = model.C_STD_CODE;
            parameters[14].Value = model.C_STL_GRD;
            parameters[15].Value = model.C_SPEC;
            parameters[16].Value = model.D_PRODUCE_DATE;
            parameters[17].Value = model.C_PRODUCE_EMP_ID;
            parameters[18].Value = model.C_PRODUCE_SHIFT;
            parameters[19].Value = model.C_PRODUCE_GROUP;
            parameters[20].Value = model.C_SX;
            parameters[21].Value = model.C_PCLX;
            parameters[22].Value = model.C_MAIN_ID;
            parameters[23].Value = model.C_SCX_NC;
            parameters[24].Value = model.C_PACK;
            parameters[25].Value = model.C_FREE_TERM;
            parameters[26].Value = model.C_FREE_TERM2;
            parameters[27].Value = model.C_AREA;
            parameters[28].Value = model.C_ZPDJBZ;
            parameters[29].Value = model.N_SCRF;
            parameters[30].Value = model.C_MRSX;
            parameters[31].Value = model.D_PRODUCE_DATE_B;
            parameters[32].Value = model.D_PRODUCE_DATE_E;
            parameters[33].Value = model.C_MAT_CODE;
            parameters[34].Value = model.C_MAT_DESC;
            parameters[35].Value = model.C_PRODUCE_SHIFT_NAME;
            parameters[36].Value = model.C_PRODUCE_GROUP_NAME;
            parameters[37].Value = model.N_IF_EXEC_STATUS;
            parameters[38].Value = model.N_IF_EXEC_REMARK;
            parameters[39].Value = model.N_QUA_CASTOFF;
            parameters[40].Value = model.N_QUA_CUTTING;
            parameters[41].Value = model.C_EMP_ID;
            parameters[42].Value = model.N_QUA_SUCCESS;
            parameters[43].Value = model.N_PROD_WGT;
            parameters[44].Value = model.N_WARE_WGT;
            parameters[45].Value = model.N_WARE_OUT_WGT;
            parameters[46].Value = model.N_HG_WGT;
            parameters[47].Value = model.N_DP_WGT;
            parameters[48].Value = model.N_GP_WGT;
            parameters[49].Value = model.N_XY_WGT;
            parameters[50].Value = model.N_TW_WGT;
            parameters[51].Value = model.N_BHG_WGT;
            parameters[52].Value = model.N_HG_WGT_IN;
            parameters[53].Value = model.N_GP_WGT_IN;
            parameters[54].Value = model.N_XY_WGT_IN;
            parameters[55].Value = model.N_TW_WGT_IN;
            parameters[56].Value = model.N_BHG_WGT_IN;
            parameters[57].Value = model.N_HG_WGT_OUT;
            parameters[58].Value = model.N_GP_WGT_OUT;
            parameters[59].Value = model.N_XY_WGT_OUT;
            parameters[60].Value = model.N_TW_WGT_OUT;
            parameters[61].Value = model.N_BHG_WGT_OUT;
            parameters[62].Value = model.D_SALE_TIME_MIN;
            parameters[63].Value = model.D_SALE_TIME_MAX;
            parameters[64].Value = model.N_SLAB_XH_WGT;
            parameters[65].Value = model.C_SLAB_TYPE;
            parameters[66].Value = model.D_SWEEP_START;
            parameters[67].Value = model.D_SWEEP_END;
            parameters[68].Value = model.N_IS_MERGE;

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
        public bool Update(Mod_TRC_ROLL_WGD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_WGD set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_PLANT=:C_PLANT,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("N_QUA_PRODUCE=:N_QUA_PRODUCE,");
            strSql.Append("N_WGT_PRODUCE=:N_WGT_PRODUCE,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_ROLL_STATE=:C_ROLL_STATE,");
            strSql.Append("C_FUR_TYPE=:C_FUR_TYPE,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("D_PRODUCE_DATE=:D_PRODUCE_DATE,");
            strSql.Append("C_PRODUCE_EMP_ID=:C_PRODUCE_EMP_ID,");
            strSql.Append("C_PRODUCE_SHIFT=:C_PRODUCE_SHIFT,");
            strSql.Append("C_PRODUCE_GROUP=:C_PRODUCE_GROUP,");
            strSql.Append("C_SX=:C_SX,");
            strSql.Append("C_PCLX=:C_PCLX,");
            strSql.Append("C_MAIN_ID=:C_MAIN_ID,");
            strSql.Append("C_SCX_NC=:C_SCX_NC,");
            strSql.Append("C_PACK=:C_PACK,");
            strSql.Append("C_FREE_TERM=:C_FREE_TERM,");
            strSql.Append("C_FREE_TERM2=:C_FREE_TERM2,");
            strSql.Append("C_AREA=:C_AREA,");
            strSql.Append("C_ZPDJBZ=:C_ZPDJBZ,");
            strSql.Append("N_SCRF=:N_SCRF,");
            strSql.Append("C_MRSX=:C_MRSX,");
            strSql.Append("D_PRODUCE_DATE_B=:D_PRODUCE_DATE_B,");
            strSql.Append("D_PRODUCE_DATE_E=:D_PRODUCE_DATE_E,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC,");
            strSql.Append("C_PRODUCE_SHIFT_NAME=:C_PRODUCE_SHIFT_NAME,");
            strSql.Append("C_PRODUCE_GROUP_NAME=:C_PRODUCE_GROUP_NAME,");
            strSql.Append("N_IF_EXEC_STATUS=:N_IF_EXEC_STATUS,");
            strSql.Append("N_IF_EXEC_REMARK=:N_IF_EXEC_REMARK,");
            strSql.Append("N_QUA_CASTOFF=:N_QUA_CASTOFF,");
            strSql.Append("N_QUA_CUTTING=:N_QUA_CUTTING");
            strSql.Append("C_EMP_ID=:C_EMP_ID");
            strSql.Append("N_QUA_SUCCESS=:N_QUA_SUCCESS,");
            strSql.Append("N_PROD_WGT=:N_PROD_WGT,");
            strSql.Append("N_WARE_WGT=:N_WARE_WGT,");
            strSql.Append("N_WARE_OUT_WGT=:N_WARE_OUT_WGT,");
            strSql.Append("N_HG_WGT=:N_HG_WGT,");
            strSql.Append("N_DP_WGT=:N_DP_WGT,");
            strSql.Append("N_GP_WGT=:N_GP_WGT,");
            strSql.Append("N_XY_WGT=:N_XY_WGT,");
            strSql.Append("N_TW_WGT=:N_TW_WGT,");
            strSql.Append("N_BHG_WGT=:N_BHG_WGT,");
            strSql.Append("N_HG_WGT_IN=:N_HG_WGT_IN,");
            strSql.Append("N_GP_WGT_IN=:N_GP_WGT_IN,");
            strSql.Append("N_XY_WGT_IN=:N_XY_WGT_IN,");
            strSql.Append("N_TW_WGT_IN=:N_TW_WGT_IN,");
            strSql.Append("N_BHG_WGT_IN=:N_BHG_WGT_IN,");
            strSql.Append("N_HG_WGT_OUT=:N_HG_WGT_OUT,");
            strSql.Append("N_GP_WGT_OUT=:N_GP_WGT_OUT,");
            strSql.Append("N_XY_WGT_OUT=:N_XY_WGT_OUT,");
            strSql.Append("N_TW_WGT_OUT=:N_TW_WGT_OUT,");
            strSql.Append("N_BHG_WGT_OUT=:N_BHG_WGT_OUT,");
            strSql.Append("D_SALE_TIME_MIN=:D_SALE_TIME_MIN,");
            strSql.Append("D_SALE_TIME_MAX=:D_SALE_TIME_MAX,");
            strSql.Append("N_SLAB_XH_WGT=:N_SLAB_XH_WGT,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("D_SWEEP_START=:D_SWEEP_START,");
            strSql.Append("D_SWEEP_END=:D_SWEEP_END,");
            strSql.Append("N_IS_MERGE=:N_IS_MERGE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_PRODUCE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_PRODUCE", OracleDbType.Decimal,15),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ROLL_STATE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_FUR_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PRODUCE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PRODUCE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SCX_NC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZPDJBZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SCRF", OracleDbType.Decimal,4),
                    new OracleParameter(":C_MRSX", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_PRODUCE_DATE_B", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_E", OracleDbType.Date),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_SHIFT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCE_GROUP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IF_EXEC_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_IF_EXEC_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_QUA_CASTOFF", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA_CUTTING", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_SUCCESS", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_SALE_TIME_MIN", OracleDbType.Date),
                    new OracleParameter(":D_SALE_TIME_MAX", OracleDbType.Date),
                    new OracleParameter(":N_SLAB_XH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SWEEP_START", OracleDbType.Date),
                    new OracleParameter(":D_SWEEP_END", OracleDbType.Date),
                    new OracleParameter(":N_IS_MERGE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_PLANT;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_BATCH_NO;
            parameters[4].Value = model.C_PLAN_ID;
            parameters[5].Value = model.N_QUA_PRODUCE;
            parameters[6].Value = model.N_WGT_PRODUCE;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_ROLL_STATE;
            parameters[9].Value = model.C_FUR_TYPE;
            parameters[10].Value = model.C_REMARK;
            parameters[11].Value = model.N_STATUS;
            parameters[12].Value = model.C_STD_CODE;
            parameters[13].Value = model.C_STL_GRD;
            parameters[14].Value = model.C_SPEC;
            parameters[15].Value = model.D_PRODUCE_DATE;
            parameters[16].Value = model.C_PRODUCE_EMP_ID;
            parameters[17].Value = model.C_PRODUCE_SHIFT;
            parameters[18].Value = model.C_PRODUCE_GROUP;
            parameters[19].Value = model.C_SX;
            parameters[20].Value = model.C_PCLX;
            parameters[21].Value = model.C_MAIN_ID;
            parameters[22].Value = model.C_SCX_NC;
            parameters[23].Value = model.C_PACK;
            parameters[24].Value = model.C_FREE_TERM;
            parameters[25].Value = model.C_FREE_TERM2;
            parameters[26].Value = model.C_AREA;
            parameters[27].Value = model.C_ZPDJBZ;
            parameters[28].Value = model.N_SCRF;
            parameters[29].Value = model.C_MRSX;
            parameters[30].Value = model.D_PRODUCE_DATE_B;
            parameters[31].Value = model.D_PRODUCE_DATE_E;
            parameters[32].Value = model.C_MAT_CODE;
            parameters[33].Value = model.C_MAT_DESC;
            parameters[34].Value = model.C_PRODUCE_SHIFT_NAME;
            parameters[35].Value = model.C_PRODUCE_GROUP_NAME;
            parameters[36].Value = model.N_IF_EXEC_STATUS;
            parameters[37].Value = model.N_IF_EXEC_REMARK;
            parameters[38].Value = model.N_QUA_CASTOFF;
            parameters[39].Value = model.N_QUA_CUTTING;
            parameters[40].Value = model.C_EMP_ID;
            parameters[41].Value = model.C_ID;


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
            strSql.Append("delete from TRC_ROLL_WGD ");
            strSql.Append(" where C_ID=:C_ID AND N_SCRF=0 ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
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
            strSql.Append("delete from TRC_ROLL_WGD ");
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
        public Mod_TRC_ROLL_WGD GetModelByC_BATCH_NO(string C_BATCH_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  * from TRC_ROLL_WGD ");
            strSql.Append(" where C_BATCH_NO=:C_BATCH_NO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_BATCH_NO;

            Mod_TRC_ROLL_WGD model = new Mod_TRC_ROLL_WGD();
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
        public Mod_TRC_ROLL_WGD GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TRC_ROLL_WGD ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_WGD model = new Mod_TRC_ROLL_WGD();
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
        public Mod_TRC_ROLL_WGD GetModel(string C_MAIN_ID, int type)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from TRC_ROLL_WGD ");
            strSql.Append(" where C_MAIN_ID=:C_MAIN_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MAIN_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_MAIN_ID;

            Mod_TRC_ROLL_WGD model = new Mod_TRC_ROLL_WGD();
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
        public Mod_TRC_ROLL_WGD DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_WGD model = new Mod_TRC_ROLL_WGD();
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
                if (row["N_QUA_PRODUCE"] != null && row["N_QUA_PRODUCE"].ToString() != "")
                {
                    model.N_QUA_PRODUCE = decimal.Parse(row["N_QUA_PRODUCE"].ToString());
                }
                if (row["N_WGT_PRODUCE"] != null && row["N_WGT_PRODUCE"].ToString() != "")
                {
                    model.N_WGT_PRODUCE = decimal.Parse(row["N_WGT_PRODUCE"].ToString());
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_ROLL_STATE"] != null && row["C_ROLL_STATE"].ToString() != "")
                {
                    model.C_ROLL_STATE = decimal.Parse(row["C_ROLL_STATE"].ToString());
                }
                if (row["C_FUR_TYPE"] != null)
                {
                    model.C_FUR_TYPE = row["C_FUR_TYPE"].ToString();
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
                if (row["D_PRODUCE_DATE"] != null && row["D_PRODUCE_DATE"].ToString() != "")
                {
                    model.D_PRODUCE_DATE = DateTime.Parse(row["D_PRODUCE_DATE"].ToString());
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
                if (row["C_SX"] != null)
                {
                    model.C_SX = row["C_SX"].ToString();
                }
                if (row["C_PCLX"] != null)
                {
                    model.C_PCLX = row["C_PCLX"].ToString();
                }
                if (row["C_MAIN_ID"] != null)
                {
                    model.C_MAIN_ID = row["C_MAIN_ID"].ToString();
                }
                if (row["C_SCX_NC"] != null)
                {
                    model.C_SCX_NC = row["C_SCX_NC"].ToString();
                }
                if (row["C_PACK"] != null)
                {
                    model.C_PACK = row["C_PACK"].ToString();
                }
                if (row["C_FREE_TERM"] != null)
                {
                    model.C_FREE_TERM = row["C_FREE_TERM"].ToString();
                }
                if (row["C_FREE_TERM2"] != null)
                {
                    model.C_FREE_TERM2 = row["C_FREE_TERM2"].ToString();
                }
                if (row["C_AREA"] != null)
                {
                    model.C_AREA = row["C_AREA"].ToString();
                }
                if (row["C_ZPDJBZ"] != null)
                {
                    model.C_ZPDJBZ = row["C_ZPDJBZ"].ToString();
                }
                if (row["N_SCRF"] != null && row["N_SCRF"].ToString() != "")
                {
                    model.N_SCRF = decimal.Parse(row["N_SCRF"].ToString());
                }
                if (row["C_MRSX"] != null)
                {
                    model.C_MRSX = row["C_MRSX"].ToString();
                }
                if (row["D_PRODUCE_DATE_B"] != null && row["D_PRODUCE_DATE_B"].ToString() != "")
                {
                    model.D_PRODUCE_DATE_B = DateTime.Parse(row["D_PRODUCE_DATE_B"].ToString());
                }
                if (row["D_PRODUCE_DATE_E"] != null && row["D_PRODUCE_DATE_E"].ToString() != "")
                {
                    model.D_PRODUCE_DATE_E = DateTime.Parse(row["D_PRODUCE_DATE_E"].ToString());
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_DESC"] != null)
                {
                    model.C_MAT_DESC = row["C_MAT_DESC"].ToString();
                }
                if (row["C_PRODUCE_SHIFT_NAME"] != null)
                {
                    model.C_PRODUCE_SHIFT_NAME = row["C_PRODUCE_SHIFT_NAME"].ToString();
                }
                if (row["C_PRODUCE_GROUP_NAME"] != null)
                {
                    model.C_PRODUCE_GROUP_NAME = row["C_PRODUCE_GROUP_NAME"].ToString();
                }
                if (row["N_IF_EXEC_STATUS"] != null && row["N_IF_EXEC_STATUS"].ToString() != "")
                {
                    model.N_IF_EXEC_STATUS = decimal.Parse(row["N_IF_EXEC_STATUS"].ToString());
                }
                if (row["N_IF_EXEC_REMARK"] != null)
                {
                    model.N_IF_EXEC_REMARK = row["N_IF_EXEC_REMARK"].ToString();
                }
                if (row["N_QUA_CASTOFF"] != null && row["N_QUA_CASTOFF"].ToString() != "")
                {
                    model.N_QUA_CASTOFF = decimal.Parse(row["N_QUA_CASTOFF"].ToString());
                }
                if (row["N_QUA_CUTTING"] != null && row["N_QUA_CUTTING"].ToString() != "")
                {
                    model.N_QUA_CUTTING = decimal.Parse(row["N_QUA_CUTTING"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["N_QUA_SUCCESS"] != null && row["N_QUA_SUCCESS"].ToString() != "")
                {
                    model.N_QUA_SUCCESS = decimal.Parse(row["N_QUA_SUCCESS"].ToString());
                }
                if (row["N_PROD_WGT"] != null && row["N_PROD_WGT"].ToString() != "")
                {
                    model.N_PROD_WGT = decimal.Parse(row["N_PROD_WGT"].ToString());
                }
                if (row["N_WARE_WGT"] != null && row["N_WARE_WGT"].ToString() != "")
                {
                    model.N_WARE_WGT = decimal.Parse(row["N_WARE_WGT"].ToString());
                }
                if (row["N_WARE_OUT_WGT"] != null && row["N_WARE_OUT_WGT"].ToString() != "")
                {
                    model.N_WARE_OUT_WGT = decimal.Parse(row["N_WARE_OUT_WGT"].ToString());
                }
                if (row["N_HG_WGT"] != null && row["N_HG_WGT"].ToString() != "")
                {
                    model.N_HG_WGT = decimal.Parse(row["N_HG_WGT"].ToString());
                }
                if (row["N_DP_WGT"] != null && row["N_DP_WGT"].ToString() != "")
                {
                    model.N_DP_WGT = decimal.Parse(row["N_DP_WGT"].ToString());
                }
                if (row["N_GP_WGT"] != null && row["N_GP_WGT"].ToString() != "")
                {
                    model.N_GP_WGT = decimal.Parse(row["N_GP_WGT"].ToString());
                }
                if (row["N_XY_WGT"] != null && row["N_XY_WGT"].ToString() != "")
                {
                    model.N_XY_WGT = decimal.Parse(row["N_XY_WGT"].ToString());
                }
                if (row["N_TW_WGT"] != null && row["N_TW_WGT"].ToString() != "")
                {
                    model.N_TW_WGT = decimal.Parse(row["N_TW_WGT"].ToString());
                }
                if (row["N_BHG_WGT"] != null && row["N_BHG_WGT"].ToString() != "")
                {
                    model.N_BHG_WGT = decimal.Parse(row["N_BHG_WGT"].ToString());
                }
                if (row["N_HG_WGT_IN"] != null && row["N_HG_WGT_IN"].ToString() != "")
                {
                    model.N_HG_WGT_IN = decimal.Parse(row["N_HG_WGT_IN"].ToString());
                }
                if (row["N_GP_WGT_IN"] != null && row["N_GP_WGT_IN"].ToString() != "")
                {
                    model.N_GP_WGT_IN = decimal.Parse(row["N_GP_WGT_IN"].ToString());
                }
                if (row["N_XY_WGT_IN"] != null && row["N_XY_WGT_IN"].ToString() != "")
                {
                    model.N_XY_WGT_IN = decimal.Parse(row["N_XY_WGT_IN"].ToString());
                }
                if (row["N_TW_WGT_IN"] != null && row["N_TW_WGT_IN"].ToString() != "")
                {
                    model.N_TW_WGT_IN = decimal.Parse(row["N_TW_WGT_IN"].ToString());
                }
                if (row["N_BHG_WGT_IN"] != null && row["N_BHG_WGT_IN"].ToString() != "")
                {
                    model.N_BHG_WGT_IN = decimal.Parse(row["N_BHG_WGT_IN"].ToString());
                }
                if (row["N_HG_WGT_OUT"] != null && row["N_HG_WGT_OUT"].ToString() != "")
                {
                    model.N_HG_WGT_OUT = decimal.Parse(row["N_HG_WGT_OUT"].ToString());
                }
                if (row["N_GP_WGT_OUT"] != null && row["N_GP_WGT_OUT"].ToString() != "")
                {
                    model.N_GP_WGT_OUT = decimal.Parse(row["N_GP_WGT_OUT"].ToString());
                }
                if (row["N_XY_WGT_OUT"] != null && row["N_XY_WGT_OUT"].ToString() != "")
                {
                    model.N_XY_WGT_OUT = decimal.Parse(row["N_XY_WGT_OUT"].ToString());
                }
                if (row["N_TW_WGT_OUT"] != null && row["N_TW_WGT_OUT"].ToString() != "")
                {
                    model.N_TW_WGT_OUT = decimal.Parse(row["N_TW_WGT_OUT"].ToString());
                }
                if (row["N_BHG_WGT_OUT"] != null && row["N_BHG_WGT_OUT"].ToString() != "")
                {
                    model.N_BHG_WGT_OUT = decimal.Parse(row["N_BHG_WGT_OUT"].ToString());
                }
                if (row["D_SALE_TIME_MIN"] != null && row["D_SALE_TIME_MIN"].ToString() != "")
                {
                    model.D_SALE_TIME_MIN = DateTime.Parse(row["D_SALE_TIME_MIN"].ToString());
                }
                if (row["D_SALE_TIME_MAX"] != null && row["D_SALE_TIME_MAX"].ToString() != "")
                {
                    model.D_SALE_TIME_MAX = DateTime.Parse(row["D_SALE_TIME_MAX"].ToString());
                }
                if (row["N_SLAB_XH_WGT"] != null && row["N_SLAB_XH_WGT"].ToString() != "")
                {
                    model.N_SLAB_XH_WGT = decimal.Parse(row["N_SLAB_XH_WGT"].ToString());
                }
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
                }
                if (row["D_SWEEP_START"] != null && row["D_SWEEP_START"].ToString() != "")
                {
                    model.D_SWEEP_START = DateTime.Parse(row["D_SWEEP_START"].ToString());
                }
                if (row["D_SWEEP_END"] != null && row["D_SWEEP_END"].ToString() != "")
                {
                    model.D_SWEEP_END = DateTime.Parse(row["D_SWEEP_END"].ToString());
                }
                if (row["N_IS_MERGE"] != null && row["N_IS_MERGE"].ToString() != "")
                {
                    model.N_IS_MERGE = decimal.Parse(row["N_IS_MERGE"].ToString());
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
            strSql.Append(@"select TRW.C_ID,
       TRW.C_STA_ID,
       TRW.C_STOVE,
       TRW.C_BATCH_NO,
       TRW.C_PLAN_ID,
       TRW.N_QUA_PRODUCE,
       TRW.N_WGT_PRODUCE,
       TRW.D_MOD_DT,
       TRW.C_ROLL_STATE,
       TRW.C_FUR_TYPE,
       TRW.C_REMARK,
       TRW.N_STATUS,
       TRW.C_STD_CODE,
       TRW.C_STL_GRD,
       TRW.C_SPEC,
       TRW.D_PRODUCE_DATE,
       TRW.C_PRODUCE_EMP_ID,
       TRW.C_PRODUCE_SHIFT,
       TRW.C_PRODUCE_GROUP,
       TRW.C_SX,
       TRW.C_PCLX,
       TRW.C_MAIN_ID,
       TRW.C_SCX_NC,
       TRW.C_PACK,
       TRW.C_FREE_TERM,
       TRW.C_FREE_TERM2,
       TRW.C_AREA,
       TRW.C_ZPDJBZ,
       TRW.N_SCRF,
       TRW.C_MRSX,
       TRW.D_PRODUCE_DATE_B,
       TRW.D_PRODUCE_DATE_E,
       TRW.C_MAT_CODE,
       TRW.C_MAT_DESC,
       TRW.C_PRODUCE_SHIFT_NAME,
       TRW.C_PRODUCE_GROUP_NAME,
       TRW.N_IF_EXEC_STATUS,
       TRW.N_IF_EXEC_REMARK,
       TRW.N_QUA_CASTOFF,
       TRW.N_QUA_CUTTING,    
       TRW.D_SWEEP_START,    
        (SELECT MAX(TNL.D_MOD_DT) FROM TB_NCIF_LOG TNL WHERE  TNL.C_RELATIONSHIP_ID=TRW.C_BATCH_NO) SYNC,
      (SELECT TT.C_PLANT FROM TRC_ROLL_MAIN TT WHERE TT.C_BATCH_NO=TRW.C_BATCH_NO)C_PLANT,  
 (SELECT  SUM(TRP.N_WGT)  FROM TRC_ROLL_PRODCUT TRP WHERE TRP.C_BATCH_NO=TRW.C_BATCH_NO)WGTS,
       (SELECT  SUM(TRP.N_QUA)  FROM TRC_ROLL_PRODCUT TRP WHERE TRP.C_BATCH_NO=TRW.C_BATCH_NO)QUA,
       TRW.C_EMP_ID");
            strSql.Append(" FROM TRC_ROLL_WGD TRW");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append(" ORDER BY  TRW.D_MOD_DT  ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRC_ROLL_WGD ");
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_WGD T ");
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
        /// 获取联产品改判信息
        /// </summary>
        /// <param name="C_MAT_CODE_PLAN">物料编码</param>
        /// <returns></returns>
        public DataSet Get_Item_List(string C_MAT_CODE_PLAN)
        {
            string sql = @"
SELECT TA.C_MAT_CODE_GP AS 物料编码,
       TB.C_MAT_NAME AS 物料名称,
       TA.C_STL_GRD AS 钢种,
       TB.C_SPEC AS 规格,
       TA.C_STD_CODE AS 执行标准,
       MAX(TD.C_ZYX1) AS 自由项1,
       MAX(TD.C_ZYX2) AS 自由项2
  FROM TQB_GP_LCP_BASIS TA
 INNER JOIN TB_MATRL_MAIN TB
    ON TA.C_MAT_CODE_GP = TB.C_MAT_CODE
 INNER JOIN TQB_STD_MAIN TC
    ON TC.C_STL_GRD = TA.C_STL_GRD
   AND TC.C_STD_CODE = TA.C_STD_CODE
  LEFT JOIN TB_STD_CONFIG TD
    ON TD.C_STD_CODE = TC.C_STD_CODE
   AND TD.C_STL_GRD = TC.C_STL_GRD
 WHERE TA.N_STATUS = 1
  AND TC.N_IS_CHECK = 1
   AND TC.N_STATUS = 1
   AND NVL(TC.N_STATUS, 1) = 1
   AND NVL(TD.N_STATUS, 1) = 1
   AND TC.C_STD_CODE IS NOT NULL
   AND TD.C_ZYX1 IS NOT NULL
   AND TD.C_ZYX2 IS NOT NULL ";
            sql += "  AND TA.C_MAT_CODE_PLAN = '" + C_MAT_CODE_PLAN + "' ";
            sql += @"          GROUP BY TA.C_MAT_CODE_GP,
          TB.C_MAT_NAME,
          TA.C_STL_GRD,
          TB.C_SPEC,
          TA.C_STD_CODE,
          TD.C_ZYX1,
          TD.C_ZYX2
 ORDER BY TA.C_MAT_CODE_GP
";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 更新轧制状态
        /// </summary>
        /// <returns></returns>
        public bool UpdateRollStatus(string id, int status)
        {
            string sql = @"UPDATE TRC_ROLL_MAIN TRM
                                    SET TRM.C_ROLL_STATE=" + status + "";
            sql += "  WHERE TRM.C_ID = '" + id + "'";
            int row = TransactionHelper.ExecuteSql(sql);
            if (row > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 更新完工单
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="mrsx">批次属性</param>
        /// <param name="pclx">批次类型</param>
        /// <param name="pclx">状态0轧钢确认1质控部确认</param>
        /// <returns></returns>
        public bool UpdateWgd(string id, string mrsx, string pclx, int status, string sx, string zpdjbz)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @" UPDATE TRC_ROLL_WGD TRW
                                    SET TRW.C_MRSX=:mrsx,
                                        TRW.C_PCLX=:pclx,
                                        TRW.C_SX=:sx,
                                        TRW.N_STATUS=" + status + "  ";
            if (!string.IsNullOrWhiteSpace(zpdjbz))
            {
                sql += ", TRW.C_ZPDJBZ='" + zpdjbz + "' ";
            }
            sql += "   WHERE TRW.C_ID=:id  ";

            paras.Add(new OracleParameter() { ParameterName = ":mrsx", Value = mrsx });
            paras.Add(new OracleParameter() { ParameterName = ":pclx", Value = pclx });
            paras.Add(new OracleParameter() { ParameterName = ":sx", Value = sx });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });

            int row = TransactionHelper.ExecuteSql(sql, paras.ToArray());
            if (row > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 更新完工单
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="mrsx">批次属性</param>
        /// <param name="pclx">批次类型</param>
        /// <param name="pclx">状态0轧钢确认1质控部确认</param>
        /// <returns></returns>
        public bool UpdateWgd(string id, string mrsx, string pclx, string grd, string spec, string std,
            string matCode, string matDesc, string zyx, string zyx2, int status, string sx, string zpdjbz)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @" UPDATE TRC_ROLL_WGD TRW
                                    SET TRW.C_MRSX=:mrsx,
                                        TRW.C_PCLX=:pclx,
                                        TRW.C_STL_GRD=:grd,
                                        TRW.C_SPEC=:spec,
                                        TRW.C_STD_CODE=:std,
                                        TRW.C_MAT_CODE=:matCode,
                                        TRW.C_MAT_DESC=:matDesc,
                                        TRW.C_FREE_TERM=:zyx,
                                        TRW.C_FREE_TERM2=:zyx2,
                                        TRW.C_SX=:sx,
                                        TRW.N_STATUS=" + status + "   ";
            if (!string.IsNullOrWhiteSpace(zpdjbz))
            {
                sql += " ,TRW.C_ZPDJBZ='" + zpdjbz + "' ";
            }
            sql += "   WHERE TRW.C_ID=:id  ";

            paras.Add(new OracleParameter() { ParameterName = ":mrsx", Value = mrsx });
            paras.Add(new OracleParameter() { ParameterName = ":pclx", Value = pclx });
            paras.Add(new OracleParameter() { ParameterName = ":grd", Value = grd });
            paras.Add(new OracleParameter() { ParameterName = ":spec", Value = spec });
            paras.Add(new OracleParameter() { ParameterName = ":std", Value = std });
            paras.Add(new OracleParameter() { ParameterName = ":matCode", Value = matCode });
            paras.Add(new OracleParameter() { ParameterName = ":matDesc", Value = matDesc });
            paras.Add(new OracleParameter() { ParameterName = ":zyx", Value = zyx });
            paras.Add(new OracleParameter() { ParameterName = ":zyx2", Value = zyx2 });
            paras.Add(new OracleParameter() { ParameterName = ":sx", Value = sx });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });

            int row = TransactionHelper.ExecuteSql(sql, paras.ToArray());
            if (row > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 更新完工单子表
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="mrsx">批次属性</param>
        /// <returns></returns>
        public bool UpdateWgdItem(string id, string mrsx, int status)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @" UPDATE TRC_ROLL_WGD_ITEM TRWI
                                     SET TRWI.C_MRSX=:mrsx
                                           ,TRWI.N_STATUS=" + status + " ";
            sql += "   WHERE TRWI.C_ID=:id  ";

            paras.Add(new OracleParameter() { ParameterName = ":mrsx", Value = mrsx });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });

            int row = TransactionHelper.ExecuteSql(sql, paras.ToArray());
            if (row > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 更新完工单子表
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="mrsx">批次属性</param>
        /// <returns></returns>
        public bool UpdateWgdItemSecond(string id, string mrsx, int status)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @" UPDATE TRC_ROLL_WGD_ITEM TRWI
                                     SET TRWI.C_MRSX=:mrsx
                                     ,TRWI.N_STATUS=" + status + " ";
            sql += "  WHERE TRWI.C_ROLL_WGD_ID=:id    ";

            paras.Add(new OracleParameter() { ParameterName = ":mrsx", Value = mrsx });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = id });

            int row = DbHelperOra.ExecuteSql(sql, paras.ToArray());
            if (row > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 获取完工单操作记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetWgdHandler(string id)
        {
            string sql = @"SELECT * FROM TRC_ROLL_WGD_HANDLER TRWH
                                     WHERE TRWH.C_WGD_ID='" + id + "'";
            return DbHelperOra.Query(sql);
        }


        /// <summary>
        /// 获取完工单记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetWgdData(string staID, DateTime start, DateTime end, string stove)
        {
            string sql = @"SELECT TRW.*,TRM.C_PLANT PLANT,(SELECT TT.C_ORDER_NO FROM TRP_PLAN_ROLL_ITEM TT WHERE TT.C_ID=TRM.C_PLAN_ID)C_ORDER_NO
                                    --,(SELECT TT.C_FREE_TERM FROM TRP_PLAN_ROLL_ITEM TT WHERE TT.C_ID=TRM.C_PLAN_ID)C_FREE_TERM
                                    --,(SELECT TT.C_FREE_TERM2 FROM TRP_PLAN_ROLL_ITEM TT WHERE TT.C_ID=TRM.C_PLAN_ID)C_FREE_TERM2
                                    FROM TRC_ROLL_WGD TRW
                                    LEFT JOIN TRC_ROLL_MAIN  TRM   ON TRM.C_ID=TRW.C_MAIN_ID
                                    WHERE TRW.C_STA_ID= '" + staID + "' ";

            if (start != DateTime.MinValue)
            {
                sql += " AND  TRW.D_PRODUCE_DATE>=to_date('" + start.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
                //sql += " AND  TRW.D_PRODUCE_DATE<=to_date('" + end.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            }

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += " AND TRW.C_BATCH_NO LIKE '%" + stove + "%' ";
            }

            sql += " ORDER BY TRW.C_BATCH_NO DESC ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// wgd未上传NC条数
        /// </summary>
        /// <returns></returns>
        public object GetNotUpLoadWgdCount(string staID)
        {
            string sql = @"SELECT COUNT(T.C_ID) FROM TRC_ROLL_WGD T
                           WHERE T.C_STA_ID='" + staID + "'";
            sql += " AND T.N_SCRF = 2 ";
            //sql += " AND ceil((To_date(to_char(SYSDATE,'yyyy-mm-dd hh24-mi-ss'), 'yyyy-mm-dd hh24-mi-ss') - To_date(to_char(t.d_produce_date_b,'yyyy-mm-dd hh24-mi-ss') , 'yyyy-mm-dd hh24-mi-ss')) * 24)>5   ";
            return DbHelperOra.GetSingle(sql);
        }

        /// <summary>
        /// 获取组坯已出炉轧钢记录
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="IsOrderDesc">排序 </param>
        /// <returns></returns>
        public DataSet GetAssePutStoreData(string strWhere, bool IsOrderDesc)
        {
            string sql = @"SELECT TRM.C_ID,
       TRM.C_STA_ID,
       (SELECT TT.C_ORDER_NO
          FROM TRP_PLAN_ROLL_ITEM TT
         WHERE TT.C_ID = TRM.C_PLAN_ID) C_ORDER_NO,
       (SELECT TT.C_FREE_TERM
          FROM TRP_PLAN_ROLL_ITEM TT
         WHERE TT.C_ID = TRM.C_PLAN_ID) C_FREE_TERM,
       (SELECT TT.C_FREE_TERM2
          FROM TRP_PLAN_ROLL_ITEM TT
         WHERE TT.C_ID = TRM.C_PLAN_ID) C_FREE_TERM2,
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
       TPR.C_PACK,
       DECODE(TPR.C_AREA, '国际贸易部', '出口材', '') C_AREA
  FROM TRC_ROLL_MAIN TRM
  LEFT JOIN TS_USER TU
    ON TU.C_ID = TRM.C_EMP_ID
  LEFT JOIN TB_STA TA
    ON TA.C_ID = TRM.C_STA_ID
  LEFT JOIN TRP_PLAN_ROLL_ITEM TPR
    ON TPR.C_ID = TRM.C_PLAN_ID
 WHERE TRM.C_ROLL_STATE = 0
   AND TRM.N_STATUS = 1  ";

            if (strWhere.Trim() != "")
            {
                sql += strWhere;
            }

            if (IsOrderDesc)
                sql += "  ORDER BY TRM.C_BATCH_NO   ";
            else
                sql += "  ORDER BY TRM.C_BATCH_NO   DESC";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取组坯已出炉轧钢记录
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="IsOrderDesc">排序 </param>
        /// <returns></returns>
        public DataSet GetAssePutStoreData(string strWhere, bool IsOrderDesc, int status)
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
                                    TRM.N_WGT_TOTAL_VIRTUAL
                                    FROM TRC_ROLL_MAIN TRM
                                    LEFT JOIN TS_USER TU ON TU.C_ID=TRM.C_EMP_ID
                                    LEFT JOIN TB_STA TA ON TA.C_ID=TRM.C_STA_ID
                                    WHERE 1=1 
                                   ";

            if (strWhere.Trim() != "")
            {
                sql += strWhere;
            }

            if (IsOrderDesc)
                sql += "  ORDER BY TRM.C_BATCH_NO   ";
            else
                sql += "  ORDER BY TRM.C_BATCH_NO   DESC";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 更新上传状态(C_ID)
        /// </summary>
        /// <returns></returns>
        public int UpdateUpLoadStatus(string id, int status)
        {
            string sql = @"UPDATE TRC_ROLL_WGD TRW
                                    SET TRW.n_Scrf=" + status;
            sql += "  , TRW.C_EMP_ID='" + RV.UI.UserInfo.userID + "' ";
            sql += "  where TRW.C_ID='" + id + "'";
            return DbHelperOra.ExecuteSql(sql);
        }

        /// <summary>
        /// 更新上传状态(C_MAIN_ID)
        /// </summary>
        /// <returns></returns>
        public int UpdateUpLoadStatus(int status, string id)
        {
            string sql = @"UPDATE TRC_ROLL_WGD TRW
                                    SET TRW.n_Scrf=" + status;
            sql += "  where TRW.C_MAIN_ID='" + id + "'";
            return DbHelperOra.ExecuteSql(sql);
        }

        /// <summary>
        /// 更新上传状态
        /// </summary>
        /// <returns></returns>
        public int UpdateIfStatus(int status, string id, string remark)
        {
            string sql = @"UPDATE TRC_ROLL_WGD TRW
                                    SET TRW.N_IF_EXEC_STATUS=" + status;
            sql += "  ,TRW.N_IF_EXEC_REMARK='" + remark + "' ";
            sql += "  where TRW.C_MAIN_ID='" + id + "'";
            return DbHelperOra.ExecuteSql(sql);
        }

        /// <summary>
        ///完工单条码回传信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetWgdFinished(int status)
        {
            string sql = @"SELECT * FROM SeZJB_WGD_Finished
                                    where ZJBstatus=" + status;
            return DbHelper_SQL.Query(sql);
        }

        /// <summary>
        ///完工单条码回传信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetWgdFinishedLoc(string staID, DataTable ids)
        {
            string sql = @"  SELECT TRW.*,TRW.C_MAIN_ID wgdh FROM  TRC_ROLL_WGD TRW WHERE TRW.C_STA_ID='" + staID + "'    ";

            if (ids == null || ids.Rows.Count < 1)
            {
                return new DataTable();
            }
            else
            {
                sql += "AND (";
                for (int i = 0; i < ids.Rows.Count; i++)
                {
                    if (i == ids.Rows.Count - 1)
                    {
                        sql += "  TRW.C_MAIN_ID='" + ids.Rows[i]["wgdh"].ToString() + "' ";
                    }
                    else
                    {
                        sql += "  TRW.c_main_id='" + ids.Rows[i]["wgdh"].ToString() + "' OR ";
                    }
                }
                sql += " )  ";
            }

            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <returns></returns>
        public DataSet GetWgdFact(string batchNo)
        {
            string sql = @"SELECT TRP.C_LINEWH_CODE,
                                    MAX(TRP.D_RKRQ) D_RKRQ,
                                    MAX(TRP.C_RKRY) C_RKRY,
                                    TRP.C_JUDGE_LEV_BP,
                                    COUNT(TRP.C_ID) QUA,
                                    SUM(TRP.N_WGT) WGT,
                                    TRP.C_MAT_CODE,
                                    TRP.C_STL_GRD,
                                    TRP.C_ZYX1,
                                    TRP.C_ZYX2,
                                    TRP.C_BZYQ
                                    FROM TRC_ROLL_PRODCUT TRP
                                    WHERE TRP.C_BATCH_NO='" + batchNo + "'   ";
            sql += " GROUP BY " +
                "TRP.C_LINEWH_CODE" +
                ",TRP.C_JUDGE_LEV_BP" +
                ",TRP.C_MAT_CODE" +
                ",TRP.C_STL_GRD" +
                ",TRP.C_ZYX1" +
                ",TRP.C_ZYX2" +
                ",TRP.C_BZYQ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <returns></returns>
        public DataSet GetWgdFactAttrDP(string batchNo)
        {
            string sql = @"SELECT TRP.C_LINEWH_CODE,
                                    MAX(TRP.D_RKRQ) D_RKRQ,
                                    MAX(TRP.C_RKRY) C_RKRY,
                                    COUNT(TRP.C_ID) QUA,
                                    SUM(TRP.N_WGT) WGT,
                                    TRP.C_MAT_CODE,
                                    TRP.C_STL_GRD,
                                    TRP.C_ZYX1,
                                    TRP.C_ZYX2,
                                    TRP.C_BZYQ
                                    FROM TRC_ROLL_PRODCUT TRP
                                    WHERE TRP.C_BATCH_NO='" + batchNo + "'   ";

            sql += " GROUP BY " +
                "TRP.C_LINEWH_CODE" +
                ",TRP.C_MAT_CODE" +
                ",TRP.C_STL_GRD" +
                ",TRP.C_ZYX1" +
                ",TRP.C_ZYX2" +
                ",TRP.C_BZYQ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <returns></returns>
        public DataSet GetWgdFactAttrDP(string batchNo, List<string> ids)
        {
            string sql = @"SELECT TRP.C_LINEWH_CODE,
                                    MAX(TRP.D_RKRQ) D_RKRQ,
                                    MAX(TRP.C_RKRY) C_RKRY,
                                    COUNT(TRP.C_ID) QUA,
                                    SUM(TRP.N_WGT) WGT,
                                    TRP.C_MAT_CODE,
                                    TRP.C_STL_GRD,
                                    TRP.C_ZYX1,
                                    TRP.C_ZYX2,
                                    TRP.C_BZYQ
                                    FROM TRC_ROLL_PRODCUT TRP
                                    WHERE TRP.C_BATCH_NO='" + batchNo + "'   ";

            if (ids.Count > 0)
            {
                sql += " AND ( ";
                for (int i = 0; i < ids.Count; i++)
                {
                    if (i == ids.Count - 1)
                        sql += "  TRP.C_ID!='" + ids[i] + "'  ";
                    else
                    {
                        sql += "  TRP.C_ID!='" + ids[i] + "' OR ";
                    }
                }
                sql += " ) ";
            }

            sql += " GROUP BY " +
                "TRP.C_LINEWH_CODE" +
                ",TRP.C_MAT_CODE" +
                ",TRP.C_STL_GRD" +
                ",TRP.C_ZYX1" +
                ",TRP.C_ZYX2" +
                ",TRP.C_BZYQ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <returns></returns>
        public DataSet GetWgdFactAttrDPTran(string batchNo, List<string> ids)
        {
            string sql = @"SELECT TRP.C_LINEWH_CODE,
                                    MAX(TRP.D_RKRQ) D_RKRQ,
                                    MAX(TRP.C_RKRY) C_RKRY,
                                    COUNT(TRP.C_ID) QUA,
                                    SUM(TRP.N_WGT) WGT,
                                    TRP.C_MAT_CODE,
                                    TRP.C_STL_GRD,
                                    TRP.C_ZYX1,
                                    TRP.C_ZYX2,
                                    TRP.C_BZYQ
                                    FROM TRC_ROLL_PRODCUT TRP
                                    WHERE TRP.C_BATCH_NO='" + batchNo + "'   ";

            if (ids.Count > 0)
            {
                sql += " AND ( ";
                for (int i = 0; i < ids.Count; i++)
                {
                    if (i == ids.Count - 1)
                        sql += "  TRP.C_ID!='" + ids[i] + "'  ";
                    else
                    {
                        sql += "  TRP.C_ID!='" + ids[i] + "' OR ";
                    }
                }
                sql += " ) ";
            }

            sql += " GROUP BY " +
                "TRP.C_LINEWH_CODE" +
                ",TRP.C_MAT_CODE" +
                ",TRP.C_STL_GRD" +
                ",TRP.C_ZYX1" +
                ",TRP.C_ZYX2" +
                ",TRP.C_BZYQ";

            return TransactionHelper.Query(sql);
        }

        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <param name="type"></param>
        /// <returns></returns>
        public DataSet GetWgdFact(string batchNo, int type)
        {
            string sql = @"SELECT 

                                    COUNT(TRP.C_ID) QUA
                                    ,SUM(TRP.N_WGT) WGT
                                    FROM TRC_ROLL_PRODCUT TRP
                                    WHERE TRP.C_BATCH_NO='" + batchNo + "'  ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <param name="type"></param>
        /// <returns></returns>
        public DataSet GetWgdFact(string batchNo, int type, List<string> ids)
        {
            string sql = @"SELECT 

                                    COUNT(TRP.C_ID) QUA
                                    ,SUM(TRP.N_WGT) WGT
                                    FROM TRC_ROLL_PRODCUT TRP
                                    WHERE TRP.C_BATCH_NO='" + batchNo + "'  ";
            if (ids.Count > 0)
            {
                sql += " AND ( ";
                for (int i = 0; i < ids.Count; i++)
                {
                    if (i == ids.Count - 1)
                        sql += "  TRP.C_ID!='" + ids[i] + "'  ";
                    else
                    {
                        sql += "  TRP.C_ID!='" + ids[i] + "' OR ";
                    }
                }
                sql += " ) ";
            }
            return DbHelperOra.Query(sql);
        }


        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <param name="type"></param>
        /// <returns></returns>
        public DataSet GetWgdFactTran(string batchNo, int type, List<string> ids)
        {
            string sql = @"SELECT 

                                    COUNT(TRP.C_ID) QUA
                                    ,SUM(TRP.N_WGT) WGT
                                    FROM TRC_ROLL_PRODCUT TRP
                                    WHERE TRP.C_BATCH_NO='" + batchNo + "'  ";
            if (ids.Count > 0)
            {
                sql += " AND ( ";
                for (int i = 0; i < ids.Count; i++)
                {
                    if (i == ids.Count - 1)
                        sql += "  TRP.C_ID!='" + ids[i] + "'  ";
                    else
                    {
                        sql += "  TRP.C_ID!='" + ids[i] + "' OR ";
                    }
                }
                sql += " ) ";
            }
            return TransactionHelper.Query(sql);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public Mod_TRC_ROLL_WGD Get_WGD_Modle(string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TB.* from TRC_ROLL_MAIN TA INNER JOIN TRC_ROLL_WGD tB ON TA.C_ID=TB.C_MAIN_ID WHERE TA.C_BATCH_NO='" + strBatchNo + "' ");

            Mod_TRC_ROLL_WGD model = new Mod_TRC_ROLL_WGD();
            DataSet ds = DbHelperOra.Query(strSql.ToString());
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
        /// 获取出炉时间
        /// </summary>
        /// <returns></returns>
        public object GetOutTime(string id)
        {
            string sql = @"SELECT MAX(TWF.D_MOD_DT) FROM TRC_WARM_FURNACE TWF
                                    WHERE TWF.C_TRC_ROLL_MAIN_ID='" + id + "'  ";
            return DbHelperOra.GetSingle(sql);
        }

        /// <summary>
        /// 修改完工单支输
        /// </summary>
        /// <param name="id"></param>
        /// <param name="qua"></param>
        /// <returns></returns>
        public bool UpdateWgdQua(string id, int qua)
        {
            string sql = @"UPDATE TRC_ROLL_WGD TRW  SET TRW.N_QUA_PRODUCE=TRW.N_QUA_PRODUCE+" + qua + "      WHERE TRW.c_main_id='" + id + "'   ";
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
        /// 修改完工单支输
        /// </summary>
        /// <param name="id"></param>
        /// <param name="qua"></param>
        /// <returns></returns>
        public bool UpdateWgdQua(string id, int qua, int type)
        {
            string sql = @"UPDATE TRC_ROLL_WGD TRW  SET TRW.N_QUA_PRODUCE=TRW.N_QUA_PRODUCE-" + qua + "      WHERE TRW.c_main_id='" + id + "'   ";
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
        /// 修改组坯轧钢状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="qua"></param>
        /// <returns></returns>
        public bool UpdateRollMainRollStatus(string id)
        {
            string sql = @"UPDATE TRC_ROLL_MAIN T
                           SET T.C_ROLL_STATE=0
                           WHERE T.C_ID='" + id + "' ";
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
        /// 修改完工单支输
        /// </summary>
        /// <param name="id"></param>
        /// <param name="qua"></param>
        /// <returns></returns>
        public bool ReduceWgdQua(string id, int qua)
        {
            string sql = @"UPDATE TRC_ROLL_WGD TRW  SET TRW.N_QUA_PRODUCE=TRW.N_QUA_PRODUCE-" + qua + "      WHERE TRW.c_main_id='" + id + "'   ";
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
        /// 删除完工单
        /// </summary>
        /// <returns></returns>
        public bool DelWgd(string mainid)
        {
            string sql = @"DELETE TRC_ROLL_WGD WHERE C_MAIN_ID='" + mainid + "' AND N_SCRF=0 ";
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
        /// 删除完工单子表
        /// </summary>
        /// <returns></returns>
        public bool DelWgdItem(string mainid)
        {
            string sql = @"DELETE TRC_ROLL_WGD_ITEM WHERE C_MAIN_ID='" + mainid + "'";
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

        public bool UpdateWgd(DateTime start, DateTime end, int qua, string id, int castOffQua, int cuttingQua)
        {
            string sql = @" UPDATE TRC_ROLL_WGD t  SET T.N_QUA_PRODUCE=" + qua + "  ,T.D_PRODUCE_DATE=to_date('" + start + "', 'yyyy-mm-dd hh24:mi:ss')   ,T.D_PRODUCE_DATE_B=to_date('" + start + "', 'yyyy-mm-dd hh24:mi:ss')    ,T.D_PRODUCE_DATE_E=to_date('" + end + "', 'yyyy-mm-dd hh24:mi:ss'),T.N_QUA_CASTOFF=" + castOffQua + " ,T.N_QUA_CUTTING=" + cuttingQua + "  WHERE T.C_MAIN_ID='" + id + "'";
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

        public bool UpdateWgd(DateTime start, DateTime end, int qua, string id, decimal castOffQua, decimal cuttingQua, decimal successQua, string shift, string group
            , string shiftName, string groupName)
        {
            DateTime productionTime = start;
            //if (Convert.ToInt32(start.ToString("HH")) >= 20)
            //{
            //    productionTime = productionTime.AddDays(1);
            //}
            string sql = @" UPDATE TRC_ROLL_WGD t  SET T.N_QUA_PRODUCE=" + qua + "   ,T.N_QUA_CASTOFF=" + castOffQua + " ,T.N_QUA_CUTTING=" + cuttingQua + ",T.N_QUA_SUCCESS=" + successQua + " ,T.C_PRODUCE_SHIFT='" + shift + "',T.C_PRODUCE_GROUP='" + group + "',T.C_PRODUCE_SHIFT_NAME='" + shiftName + "',T.C_PRODUCE_GROUP_NAME='" + groupName + "' ,T.D_PRODUCE_DATE_E=to_date('" + RV.UI.ServerTime.timeNow() + "', 'yyyy-mm-dd hh24:mi:ss') WHERE T.C_MAIN_ID='" + id + "'";
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
        /// 更新计划完工量
        /// </summary>
        /// <param name="id"></param>
        /// <param name="wgt"></param>
        /// <returns></returns>
        public bool UpdateRollPlanItemWgt(string id, decimal wgt)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL_ITEM  TPRI
                           SET TPRI.N_PROD_WGT=TPRI.N_PROD_WGT+" + wgt + " WHERE TPRI.C_ID='" + id + "'";
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
        /// 更新计划完工量
        /// </summary>
        /// <param name="id"></param>
        /// <param name="wgt"></param>
        /// <returns></returns>
        public bool UpdateRollPlanItemWgt(string id, decimal wgt, int type)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL_ITEM  TPRI
                           SET TPRI.N_PROD_WGT=TPRI.N_PROD_WGT-" + wgt + " WHERE TPRI.C_ID='" + id + "'";
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

        public bool UpdateWgdQua(string id, decimal qua, decimal castOffQua, decimal CuttingQua, string userID, DateTime start, DateTime end)
        {
            //DateTime productionTime = start;
            //if (Convert.ToInt32(start.ToString("HH")) >= 20)
            //{
            //    productionTime = productionTime.AddDays(1);
            //}

            // ,T.D_MOD_DT=to_date('" + productionTime.ToString("yyyy-MM-dd") + "', 'yyyy-mm-dd') ,TRW.D_PRODUCE_DATE_B=to_date('" + start + "', 'yyyy-mm-dd hh24:mi:ss')   ,TRW.D_PRODUCE_DATE_E=to_date('" + end + "', 'yyyy-mm-dd hh24:mi:ss') 
            string sql = @" UPDATE TRC_ROLL_WGD TRW SET TRW.N_QUA_SUCCESS=" + qua + " ,TRW.N_QUA_CASTOFF=" + castOffQua + " ,TRW.N_QUA_CUTTING=" + CuttingQua + ",TRW.C_EMP_ID='" + userID + "'  WHERE TRW.C_MAIN_ID='" + id + "' ";
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
        /// 查询完工单信息
        /// </summary>
        /// <param name="strTime1">开始时间</param>
        /// <param name="strTime2">结束时间</param>
        /// <param name="strBatch">批号</param>
        /// <param name="strStaID">轧线ID</param>
        /// <returns></returns>
        public DataSet Get_WGD_List(string strTime1, string strTime2, string strBatch, string strStaID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TB.C_STA_DESC as 轧线, TA.C_BATCH_NO as 批号, TA.C_STOVE as 炉号, DECODE(TA.C_PCLX, '0', '普通材', '1', '出口材', '') as 批次类型, TA.C_MRSX as 批次属性, TA.C_SX as 默认属性, DECODE(TA.N_SCRF,'0','未传条码','1','已传条码','2','已同步条码','3','已上传NC','') as 状态,TA.C_STL_GRD as 钢种,TA.C_STD_CODE as 执行标准,TA.C_SPEC as 规格,TA.C_MAT_CODE as 物料编码,TA.C_MAT_DESC as 物料名称,TA.C_FREE_TERM as 自由项1,TA.C_FREE_TERM2 as 自由项2,TA.C_PACK as 包装要求,TA.C_AREA as 区域,to_char(ta.d_mod_dt,'yyyy-mm-dd hh24:mi:ss')as 创建时间  FROM TRC_ROLL_WGD TA  LEFT JOIN TB_STA TB ON TA.C_STA_ID = TB.C_ID WHERE TB.N_STATUS = 1 AND TA.N_STATUS = 1 ");

            if (!string.IsNullOrEmpty(strTime1) && !string.IsNullOrEmpty(strTime2))
            {
                strSql.Append(" AND TA.D_MOD_DT BETWEEN to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ");
            }

            if (!string.IsNullOrEmpty(strBatch))
            {
                strSql.Append(" and TA.C_BATCH_NO like '%" + strBatch + "%' ");
            }

            if (!string.IsNullOrEmpty(strStaID))
            {
                strSql.Append(" and TA.C_STA_ID ='" + strStaID + "' ");
            }

            strSql.Append(" ORDER BY TB.C_STA_CODE, TA.C_BATCH_NO ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 撤销完工单状态
        /// </summary>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        public bool BackWgd(string batchNo)
        {
            string sql = @" UPDATE TRC_ROLL_WGD T 
                            SET T.N_SCRF='0'
                               ,T.N_IF_EXEC_STATUS=1
                            WHERE T.C_BATCH_NO='" + batchNo + "' ";
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
        /// 完工单班次记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetWgdBCJL(string rqStart, string rqEnd, string shift, string prodLine)
        {

            string sql = @"SELECT   
                           TPRI.C_ORDER_NO,
                           TPRI.C_SPEC,
                           TPRI.C_STL_GRD,
                           TPRI.C_STD_CODE,
                           TRW.C_BATCH_NO,
                           TRW.C_STOVE,
                          (SELECT SUM(TSM.N_WGT)  FROM TRC_ROLL_MAIN_ITEM TRMI  LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=TRMI.C_SLAB_MAIN_ID WHERE TRMI.C_ROLL_MAIN_ID = TRW.C_MAIN_ID) CONSUME,
                           TRW.N_HG_WGT,
                           TRW.N_PROD_WGT,
                           TRW.N_BHG_WGT,
                           TRW.N_XY_WGT,
                           TRW.N_TW_WGT,
                           TRW.N_DP_WGT,
                          TRW.D_PRODUCE_DATE_B,
                          TRW.D_MOD_DT,
                          TRW.C_FREE_TERM,
                          TRW.C_FREE_TERM2,
                           ROUND( (TRW.N_HG_WGT /(SELECT SUM(TSM.N_WGT)
                            FROM TRC_ROLL_MAIN_ITEM TRMI
                            LEFT JOIN TSC_SLAB_MAIN TSM
                              ON TSM.C_ID = TRMI.C_SLAB_MAIN_ID
                           WHERE TRMI.C_ROLL_MAIN_ID = TRW.C_MAIN_ID)),3)*100 R
                           FROM TRC_ROLL_WGD TRW
                           LEFT JOIN TRP_PLAN_ROLL_ITEM TPRI ON TPRI.C_ID = TRW.C_PLAN_ID
                           WHERE TRW.D_PRODUCE_DATE_B >=  TO_DATE('" + rqStart + "', 'yyyy-mm-dd hh24:mi:ss') ";
            sql += @" AND TRW.D_PRODUCE_DATE_B <= TO_DATE('" + rqEnd + "', 'yyyy-mm-dd hh24:mi:ss')";

            if (shift != "全部" && !string.IsNullOrWhiteSpace(shift))
                sql += "  AND TRW.C_PRODUCE_SHIFT_NAME='" + shift + "'  ";

            if (prodLine != "全部" && !string.IsNullOrWhiteSpace(prodLine))
                sql += " AND TRW.C_STA_ID='" + prodLine + "' ";

            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取产线
        /// </summary>
        /// <param name="codeLike">模糊查询产线编码字符串</param>
        /// <returns>获取工位表格</returns>
        public DataTable GetProdLine(string codeLike)
        {
            string sql = @" SELECT * FROM TB_STA T WHERE T.C_STA_CODE LIKE '" + codeLike + "' ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// A2是否已传
        /// </summary>
        /// <param name="batchNO">批次号</param>
        /// <param name="commpany">公司编码</param>
        /// <returns></returns>
        public int IsA2Repeat(string batchNO, string commpany)
        {
            string sql = @" select count(*) from XGERP50.mm_mo@CAP_ERP where mm_mo.dr=0 and pk_corp='1001' and mm_mo.pch='" + batchNO + "' ";
            return Convert.ToInt32(DbHelperOra.GetSingle(sql).ToString());
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
        /// A4是否已传
        /// </summary>
        /// <param name="batchNO">批次号</param>
        /// <param name="commpany">公司编码</param>
        /// <returns></returns>
        public int IsA4Repeat(string batchNO, string commpany)
        {
            string sql = @" SELECT COUNT(*)  FROM  XGERP50.MM_WR_B@cap_erp t WHERE t.DR = 0 AND t.PK_CORP = '1001'  AND t.PCH = '" + batchNO + "' ";
            return Convert.ToInt32(DbHelperOra.GetSingle(sql).ToString());
        }

        /// <summary>
        /// 46是否已传
        /// </summary>
        /// <param name="batchNO">批次号</param>
        /// <param name="commpany">公司编码</param>
        /// <returns></returns>
        public int Is46Repeat(string batchNO, string commpany)
        {
            string sql = @" SELECT COUNT(*)  FROM  XGERP50.IC_GENERAL_B@cap_erp t WHERE t.DR = 0 AND t.CBODYBILLTYPECODE = '46'  AND t.PK_CORP = '1001' AND t.VBATCHCODE = '" + batchNO + "' ";
            return Convert.ToInt32(DbHelperOra.GetSingle(sql).ToString());
        }

        /// <summary>
        /// 删除线材
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public int DelRollProduct(List<string> ids)
        {
            string sql = @" DELETE TRC_ROLL_PRODCUT T  WHERE ";
            if (ids.Count > 0)
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    if (i == ids.Count - 1)
                        sql += "  T.C_ID='" + ids[i] + "'  ";
                    else
                    {
                        sql += "  T.C_ID='" + ids[i] + "' OR ";
                    }
                }
                return TransactionHelper.ExecuteSql(sql);
            }
            else
                return 0;
        }

        /// <summary>
        /// 获取线材重量
        /// </summary>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        public decimal GetRollProductWgt(string batchNo)
        {
            string sql = @"SELECT SUM(T.N_WGT) FROM TRC_ROLL_PRODCUT  T WHERE  T.C_BATCH_NO='" + batchNo + "' ";
            return Convert.ToDecimal(DbHelperOra.GetSingle(sql));
        }

        /// <summary>
        /// 获取组坯主键
        /// </summary>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        public string GetRollMain(string batchNo)
        {
            string sql = @" SELECT C_MAIN_ID FROM TRC_ROLL_WGD T WHERE T.C_BATCH_NO='" + batchNo + "'  ";
            return DbHelperOra.GetSingle(sql).ToString();
        }

        /// <summary>
        /// 获取上传NC明细
        /// </summary>
        /// <returns></returns>
        public DataTable GetSyncDetail(string id)
        {
            string sql = @"SELECT * FROM   TB_AUTO_SYNC_LOG T WHERE T.C_WGD_ID='" + id + "' ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 未同步A3批次号
        /// </summary>
        /// <returns></returns>
        public DataTable GetNotA3(string status)
        {
            string sql = @"select a.pch
                           from xgerp50.mm_mo@cap_erp a
                           left join xgerp50.ic_general_b@cap_erp b
                             on a.pch = b.vuserdef20
                            and a.dr = 0 and a.pk_corp='1001'
                            and b.dr = 0
                          where a.sjkgrq >= to_char(sysdate-15,'YYYY-MM-DD') and a.pch like '"+ status + "%' and b.vuserdef20 is null";
            return DbHelperOra.Query(sql).Tables[0];
        }


        #endregion  ExtensionMethod
    }
}

