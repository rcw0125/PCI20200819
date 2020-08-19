using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_ROLL_PRODCUT
    /// </summary>
    public partial class Dal_TRC_ROLL_PRODCUT
    {
        public Dal_TRC_ROLL_PRODCUT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_PRODCUT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PH, string GH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_PRODCUT ");
            strSql.Append(" where C_BATCH_NO='" + PH + "' and  C_TICK_NO ='" + GH + "'");
            return DbHelperOra.Exists(strSql.ToString());
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_PRODCUT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_PRODCUT(");
            strSql.Append("C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_REASON_NAME,C_IS_PD,C_ORDER_NO1,C_WWBATCH_NO,C_FRFLAG,N_SFOB,C_STL_GRD_TYPE,C_SFJK,C_PROD_NAME,C_PROD_KIND,C_QGP_STATE,C_COMMUTE_REASON,C_PCINFO,C_DEPOT_TYPE)");
            strSql.Append(" values (");
            strSql.Append(":C_EMP_ID,:D_MOD_DT,:C_TRC_ROLL_MAIN_ID,:C_STOVE,:C_BATCH_NO,:C_TICK_NO,:C_STL_GRD,:C_STL_GRD_BEFORE,:N_WGT,:C_STD_CODE,:C_STD_CODE_BEFORE,:C_MOVE_TYPE,:C_SPEC,:C_SHIFT,:C_GROUP,:C_STA_ID,:C_JUDGE_LEV_BP,:C_DP_SHIFT,:C_DP_GROUP,:C_DP_EMP_ID,:D_DP_DT,:C_PLANT_ID,:C_PLANT_DESC,:C_MAT_CODE,:C_MAT_CODE_BEFORE,:C_MAT_DESC,:C_MAT_DESC_BEFORE,:C_IS_DEPOT,:C_PLAN_ID,:C_ORDER_NO,:C_CON_NO,:C_CUST_NO,:C_CUST_NAME,:C_ISFREE,:C_LINEWH_CODE,:C_LINEWH_AREA_CODE,:C_LINEWH_LOC_CODE,:C_FLOOR,:C_CUST_AREA,:C_SALE_AREA,:C_JUDGE_LEV_CF,:C_JUDGE_LEV_XN,:C_JUDGE_LEV_XN_RE,:C_JUDGE_LEV_ZH_PEOPLE,:D_JUDGE_DATE,:C_IS_QR,:C_QR_USER,:D_QR_DATE,:C_DESIGN_NO,:C_JUDGE_LEV_ZH,:C_IS_TB,:C_SCUTCHEON,:C_GP_TYPE,:C_BARCODE,:C_RKDH,:C_FYDH,:C_CKDH,:C_MOVE_DESC,:C_CKRY,:D_CKRQ,:C_RKRY,:D_RKRQ,:C_BZYQ,:D_WEIGHT_DT,:D_PRODUCE_DATE,:C_ZYX1,:C_ZYX2,:C_ZKD_NO,:C_QTCKD_NO,:C_MASTER_ID,:C_GP_BEFORE_ID,:C_GP_AFTER_ID,:C_REASON_NAME,:C_IS_PD,:C_ORDER_NO1,:C_WWBATCH_NO,:C_FRFLAG,:N_SFOB,:C_STL_GRD_TYPE,:C_SFJK,:C_PROD_NAME,:C_PROD_KIND,:C_QGP_STATE,:C_COMMUTE_REASON,:C_PCINFO,:C_DEPOT_TYPE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DP_DT", OracleDbType.Date),
                    new OracleParameter(":C_PLANT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN_RE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BARCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CKRY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CKRQ", OracleDbType.Date),
                    new OracleParameter(":C_RKRY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RKRQ", OracleDbType.Date),
                    new OracleParameter(":C_BZYQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WEIGHT_DT", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QTCKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ORDER_NO1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WWBATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FRFLAG", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_SFOB", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SFJK", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCINFO", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_DEPOT_TYPE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_EMP_ID;
            parameters[1].Value = model.D_MOD_DT;
            parameters[2].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_TICK_NO;
            parameters[6].Value = model.C_STL_GRD;
            parameters[7].Value = model.C_STL_GRD_BEFORE;
            parameters[8].Value = model.N_WGT;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_STD_CODE_BEFORE;
            parameters[11].Value = model.C_MOVE_TYPE;
            parameters[12].Value = model.C_SPEC;
            parameters[13].Value = model.C_SHIFT;
            parameters[14].Value = model.C_GROUP;
            parameters[15].Value = model.C_STA_ID;
            parameters[16].Value = model.C_JUDGE_LEV_BP;
            parameters[17].Value = model.C_DP_SHIFT;
            parameters[18].Value = model.C_DP_GROUP;
            parameters[19].Value = model.C_DP_EMP_ID;
            parameters[20].Value = model.D_DP_DT;
            parameters[21].Value = model.C_PLANT_ID;
            parameters[22].Value = model.C_PLANT_DESC;
            parameters[23].Value = model.C_MAT_CODE;
            parameters[24].Value = model.C_MAT_CODE_BEFORE;
            parameters[25].Value = model.C_MAT_DESC;
            parameters[26].Value = model.C_MAT_DESC_BEFORE;
            parameters[27].Value = model.C_IS_DEPOT;
            parameters[28].Value = model.C_PLAN_ID;
            parameters[29].Value = model.C_ORDER_NO;
            parameters[30].Value = model.C_CON_NO;
            parameters[31].Value = model.C_CUST_NO;
            parameters[32].Value = model.C_CUST_NAME;
            parameters[33].Value = model.C_ISFREE;
            parameters[34].Value = model.C_LINEWH_CODE;
            parameters[35].Value = model.C_LINEWH_AREA_CODE;
            parameters[36].Value = model.C_LINEWH_LOC_CODE;
            parameters[37].Value = model.C_FLOOR;
            parameters[38].Value = model.C_CUST_AREA;
            parameters[39].Value = model.C_SALE_AREA;
            parameters[40].Value = model.C_JUDGE_LEV_CF;
            parameters[41].Value = model.C_JUDGE_LEV_XN;
            parameters[42].Value = model.C_JUDGE_LEV_XN_RE;
            parameters[43].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
            parameters[44].Value = model.D_JUDGE_DATE;
            parameters[45].Value = model.C_IS_QR;
            parameters[46].Value = model.C_QR_USER;
            parameters[47].Value = model.D_QR_DATE;
            parameters[48].Value = model.C_DESIGN_NO;
            parameters[49].Value = model.C_JUDGE_LEV_ZH;
            parameters[50].Value = model.C_IS_TB;
            parameters[51].Value = model.C_SCUTCHEON;
            parameters[52].Value = model.C_GP_TYPE;
            parameters[53].Value = model.C_BARCODE;
            parameters[54].Value = model.C_RKDH;
            parameters[55].Value = model.C_FYDH;
            parameters[56].Value = model.C_CKDH;
            parameters[57].Value = model.C_MOVE_DESC;
            parameters[58].Value = model.C_CKRY;
            parameters[59].Value = model.D_CKRQ;
            parameters[60].Value = model.C_RKRY;
            parameters[61].Value = model.D_RKRQ;
            parameters[62].Value = model.C_BZYQ;
            parameters[63].Value = model.D_WEIGHT_DT;
            parameters[64].Value = model.D_PRODUCE_DATE;
            parameters[65].Value = model.C_ZYX1;
            parameters[66].Value = model.C_ZYX2;
            parameters[67].Value = model.C_ZKD_NO;
            parameters[68].Value = model.C_QTCKD_NO;
            parameters[69].Value = model.C_MASTER_ID;
            parameters[70].Value = model.C_GP_BEFORE_ID;
            parameters[71].Value = model.C_GP_AFTER_ID;
            parameters[72].Value = model.C_REASON_NAME;
            parameters[73].Value = model.C_IS_PD;
            parameters[74].Value = model.C_ORDER_NO1;
            parameters[75].Value = model.C_WWBATCH_NO;
            parameters[76].Value = model.C_FRFLAG;
            parameters[77].Value = model.N_SFOB;
            parameters[78].Value = model.C_STL_GRD_TYPE;
            parameters[79].Value = model.C_SFJK;
            parameters[80].Value = model.C_PROD_NAME;
            parameters[81].Value = model.C_PROD_KIND;
            parameters[82].Value = model.C_QGP_STATE;
            parameters[83].Value = model.C_COMMUTE_REASON;
            parameters[84].Value = model.C_PCINFO;
            parameters[85].Value = model.C_DEPOT_TYPE;
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
        public bool Update(Mod_TRC_ROLL_PRODCUT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_PRODCUT set ");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_TRC_ROLL_MAIN_ID=:C_TRC_ROLL_MAIN_ID,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STL_GRD_BEFORE=:C_STL_GRD_BEFORE,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STD_CODE_BEFORE=:C_STD_CODE_BEFORE,");
            strSql.Append("C_MOVE_TYPE=:C_MOVE_TYPE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_JUDGE_LEV_BP=:C_JUDGE_LEV_BP,");
            strSql.Append("C_DP_SHIFT=:C_DP_SHIFT,");
            strSql.Append("C_DP_GROUP=:C_DP_GROUP,");
            strSql.Append("C_DP_EMP_ID=:C_DP_EMP_ID,");
            strSql.Append("D_DP_DT=:D_DP_DT,");
            strSql.Append("C_PLANT_ID=:C_PLANT_ID,");
            strSql.Append("C_PLANT_DESC=:C_PLANT_DESC,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_CODE_BEFORE=:C_MAT_CODE_BEFORE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC,");
            strSql.Append("C_MAT_DESC_BEFORE=:C_MAT_DESC_BEFORE,");
            strSql.Append("C_IS_DEPOT=:C_IS_DEPOT,");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("C_CUST_NO=:C_CUST_NO,");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME,");
            strSql.Append("C_ISFREE=:C_ISFREE,");
            strSql.Append("C_LINEWH_CODE=:C_LINEWH_CODE,");
            strSql.Append("C_LINEWH_AREA_CODE=:C_LINEWH_AREA_CODE,");
            strSql.Append("C_LINEWH_LOC_CODE=:C_LINEWH_LOC_CODE,");
            strSql.Append("C_FLOOR=:C_FLOOR,");
            strSql.Append("C_CUST_AREA=:C_CUST_AREA,");
            strSql.Append("C_SALE_AREA=:C_SALE_AREA,");
            strSql.Append("C_JUDGE_LEV_CF=:C_JUDGE_LEV_CF,");
            strSql.Append("C_JUDGE_LEV_XN=:C_JUDGE_LEV_XN,");
            strSql.Append("C_JUDGE_LEV_XN_RE=:C_JUDGE_LEV_XN_RE,");
            strSql.Append("C_JUDGE_LEV_ZH_PEOPLE=:C_JUDGE_LEV_ZH_PEOPLE,");
            strSql.Append("D_JUDGE_DATE=:D_JUDGE_DATE,");
            strSql.Append("C_IS_QR=:C_IS_QR,");
            strSql.Append("C_QR_USER=:C_QR_USER,");
            strSql.Append("D_QR_DATE=:D_QR_DATE,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("C_JUDGE_LEV_ZH=:C_JUDGE_LEV_ZH,");
            strSql.Append("C_IS_TB=:C_IS_TB,");
            strSql.Append("C_SCUTCHEON=:C_SCUTCHEON,");
            strSql.Append("C_GP_TYPE=:C_GP_TYPE,");
            strSql.Append("C_BARCODE=:C_BARCODE,");
            strSql.Append("C_RKDH=:C_RKDH,");
            strSql.Append("C_FYDH=:C_FYDH,");
            strSql.Append("C_CKDH=:C_CKDH,");
            strSql.Append("C_MOVE_DESC=:C_MOVE_DESC,");
            strSql.Append("C_CKRY=:C_CKRY,");
            strSql.Append("D_CKRQ=:D_CKRQ,");
            strSql.Append("C_RKRY=:C_RKRY,");
            strSql.Append("D_RKRQ=:D_RKRQ,");
            strSql.Append("C_BZYQ=:C_BZYQ,");
            strSql.Append("D_WEIGHT_DT=:D_WEIGHT_DT,");
            strSql.Append("D_PRODUCE_DATE=:D_PRODUCE_DATE,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_ZKD_NO=:C_ZKD_NO,");
            strSql.Append("C_QTCKD_NO=:C_QTCKD_NO,");
            strSql.Append("C_MASTER_ID=:C_MASTER_ID,");
            strSql.Append("C_GP_BEFORE_ID=:C_GP_BEFORE_ID,");
            strSql.Append("C_GP_AFTER_ID=:C_GP_AFTER_ID,");
            strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
            strSql.Append("C_IS_PD=:C_IS_PD,");
            strSql.Append("C_ORDER_NO1=:C_ORDER_NO1,");
            strSql.Append("C_WWBATCH_NO=:C_WWBATCH_NO,");
            strSql.Append("C_FRFLAG=:C_FRFLAG,");
            strSql.Append("N_SFOB=:N_SFOB,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_SFJK=:C_SFJK,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_QGP_STATE=:C_QGP_STATE,");
            strSql.Append("C_COMMUTE_REASON=:C_COMMUTE_REASON,");
            strSql.Append("C_PCINFO=:C_PCINFO,");
            strSql.Append("C_DEPOT_TYPE=:C_DEPOT_TYPE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DP_DT", OracleDbType.Date),
                    new OracleParameter(":C_PLANT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN_RE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BARCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CKRY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CKRQ", OracleDbType.Date),
                    new OracleParameter(":C_RKRY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RKRQ", OracleDbType.Date),
                    new OracleParameter(":C_BZYQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WEIGHT_DT", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QTCKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ORDER_NO1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WWBATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FRFLAG", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_SFOB", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SFJK", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_PCINFO", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_DEPOT_TYPE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_EMP_ID;
            parameters[1].Value = model.D_MOD_DT;
            parameters[2].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_TICK_NO;
            parameters[6].Value = model.C_STL_GRD;
            parameters[7].Value = model.C_STL_GRD_BEFORE;
            parameters[8].Value = model.N_WGT;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_STD_CODE_BEFORE;
            parameters[11].Value = model.C_MOVE_TYPE;
            parameters[12].Value = model.C_SPEC;
            parameters[13].Value = model.C_SHIFT;
            parameters[14].Value = model.C_GROUP;
            parameters[15].Value = model.C_STA_ID;
            parameters[16].Value = model.C_JUDGE_LEV_BP;
            parameters[17].Value = model.C_DP_SHIFT;
            parameters[18].Value = model.C_DP_GROUP;
            parameters[19].Value = model.C_DP_EMP_ID;
            parameters[20].Value = model.D_DP_DT;
            parameters[21].Value = model.C_PLANT_ID;
            parameters[22].Value = model.C_PLANT_DESC;
            parameters[23].Value = model.C_MAT_CODE;
            parameters[24].Value = model.C_MAT_CODE_BEFORE;
            parameters[25].Value = model.C_MAT_DESC;
            parameters[26].Value = model.C_MAT_DESC_BEFORE;
            parameters[27].Value = model.C_IS_DEPOT;
            parameters[28].Value = model.C_PLAN_ID;
            parameters[29].Value = model.C_ORDER_NO;
            parameters[30].Value = model.C_CON_NO;
            parameters[31].Value = model.C_CUST_NO;
            parameters[32].Value = model.C_CUST_NAME;
            parameters[33].Value = model.C_ISFREE;
            parameters[34].Value = model.C_LINEWH_CODE;
            parameters[35].Value = model.C_LINEWH_AREA_CODE;
            parameters[36].Value = model.C_LINEWH_LOC_CODE;
            parameters[37].Value = model.C_FLOOR;
            parameters[38].Value = model.C_CUST_AREA;
            parameters[39].Value = model.C_SALE_AREA;
            parameters[40].Value = model.C_JUDGE_LEV_CF;
            parameters[41].Value = model.C_JUDGE_LEV_XN;
            parameters[42].Value = model.C_JUDGE_LEV_XN_RE;
            parameters[43].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
            parameters[44].Value = model.D_JUDGE_DATE;
            parameters[45].Value = model.C_IS_QR;
            parameters[46].Value = model.C_QR_USER;
            parameters[47].Value = model.D_QR_DATE;
            parameters[48].Value = model.C_DESIGN_NO;
            parameters[49].Value = model.C_JUDGE_LEV_ZH;
            parameters[50].Value = model.C_IS_TB;
            parameters[51].Value = model.C_SCUTCHEON;
            parameters[52].Value = model.C_GP_TYPE;
            parameters[53].Value = model.C_BARCODE;
            parameters[54].Value = model.C_RKDH;
            parameters[55].Value = model.C_FYDH;
            parameters[56].Value = model.C_CKDH;
            parameters[57].Value = model.C_MOVE_DESC;
            parameters[58].Value = model.C_CKRY;
            parameters[59].Value = model.D_CKRQ;
            parameters[60].Value = model.C_RKRY;
            parameters[61].Value = model.D_RKRQ;
            parameters[62].Value = model.C_BZYQ;
            parameters[63].Value = model.D_WEIGHT_DT;
            parameters[64].Value = model.D_PRODUCE_DATE;
            parameters[65].Value = model.C_ZYX1;
            parameters[66].Value = model.C_ZYX2;
            parameters[67].Value = model.C_ZKD_NO;
            parameters[68].Value = model.C_QTCKD_NO;
            parameters[69].Value = model.C_MASTER_ID;
            parameters[70].Value = model.C_GP_BEFORE_ID;
            parameters[71].Value = model.C_GP_AFTER_ID;
            parameters[72].Value = model.C_REASON_NAME;
            parameters[73].Value = model.C_IS_PD;
            parameters[74].Value = model.C_ORDER_NO1;
            parameters[75].Value = model.C_WWBATCH_NO;
            parameters[76].Value = model.C_FRFLAG;
            parameters[77].Value = model.N_SFOB;
            parameters[78].Value = model.C_STL_GRD_TYPE;
            parameters[79].Value = model.C_SFJK;
            parameters[80].Value = model.C_PROD_NAME;
            parameters[81].Value = model.C_PROD_KIND;
            parameters[82].Value = model.C_QGP_STATE;
            parameters[83].Value = model.C_COMMUTE_REASON;
            parameters[84].Value = model.C_PCINFO;
            parameters[85].Value = model.C_DEPOT_TYPE;
            parameters[86].Value = model.C_ID;

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
		public bool Update_Trans(Mod_TRC_ROLL_PRODCUT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_PRODCUT set ");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_TRC_ROLL_MAIN_ID=:C_TRC_ROLL_MAIN_ID,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STL_GRD_BEFORE=:C_STL_GRD_BEFORE,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STD_CODE_BEFORE=:C_STD_CODE_BEFORE,");
            strSql.Append("C_MOVE_TYPE=:C_MOVE_TYPE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_JUDGE_LEV_BP=:C_JUDGE_LEV_BP,");
            strSql.Append("C_DP_SHIFT=:C_DP_SHIFT,");
            strSql.Append("C_DP_GROUP=:C_DP_GROUP,");
            strSql.Append("C_DP_EMP_ID=:C_DP_EMP_ID,");
            strSql.Append("D_DP_DT=:D_DP_DT,");
            strSql.Append("C_PLANT_ID=:C_PLANT_ID,");
            strSql.Append("C_PLANT_DESC=:C_PLANT_DESC,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_CODE_BEFORE=:C_MAT_CODE_BEFORE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC,");
            strSql.Append("C_MAT_DESC_BEFORE=:C_MAT_DESC_BEFORE,");
            strSql.Append("C_IS_DEPOT=:C_IS_DEPOT,");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("C_CUST_NO=:C_CUST_NO,");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME,");
            strSql.Append("C_ISFREE=:C_ISFREE,");
            strSql.Append("C_LINEWH_CODE=:C_LINEWH_CODE,");
            strSql.Append("C_LINEWH_AREA_CODE=:C_LINEWH_AREA_CODE,");
            strSql.Append("C_LINEWH_LOC_CODE=:C_LINEWH_LOC_CODE,");
            strSql.Append("C_FLOOR=:C_FLOOR,");
            strSql.Append("C_CUST_AREA=:C_CUST_AREA,");
            strSql.Append("C_SALE_AREA=:C_SALE_AREA,");
            strSql.Append("C_JUDGE_LEV_CF=:C_JUDGE_LEV_CF,");
            strSql.Append("C_JUDGE_LEV_XN=:C_JUDGE_LEV_XN,");
            strSql.Append("C_JUDGE_LEV_XN_RE=:C_JUDGE_LEV_XN_RE,");
            strSql.Append("C_JUDGE_LEV_ZH_PEOPLE=:C_JUDGE_LEV_ZH_PEOPLE,");
            strSql.Append("D_JUDGE_DATE=:D_JUDGE_DATE,");
            strSql.Append("C_IS_QR=:C_IS_QR,");
            strSql.Append("C_QR_USER=:C_QR_USER,");
            strSql.Append("D_QR_DATE=:D_QR_DATE,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("C_JUDGE_LEV_ZH=:C_JUDGE_LEV_ZH,");
            strSql.Append("C_IS_TB=:C_IS_TB,");
            strSql.Append("C_SCUTCHEON=:C_SCUTCHEON,");
            strSql.Append("C_GP_TYPE=:C_GP_TYPE,");
            strSql.Append("C_BARCODE=:C_BARCODE,");
            strSql.Append("C_RKDH=:C_RKDH,");
            strSql.Append("C_FYDH=:C_FYDH,");
            strSql.Append("C_CKDH=:C_CKDH,");
            strSql.Append("C_MOVE_DESC=:C_MOVE_DESC,");
            strSql.Append("C_CKRY=:C_CKRY,");
            strSql.Append("D_CKRQ=:D_CKRQ,");
            strSql.Append("C_RKRY=:C_RKRY,");
            strSql.Append("D_RKRQ=:D_RKRQ,");
            strSql.Append("C_BZYQ=:C_BZYQ,");
            strSql.Append("D_WEIGHT_DT=:D_WEIGHT_DT,");
            strSql.Append("D_PRODUCE_DATE=:D_PRODUCE_DATE,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_ZKD_NO=:C_ZKD_NO,");
            strSql.Append("C_QTCKD_NO=:C_QTCKD_NO,");
            strSql.Append("C_MASTER_ID=:C_MASTER_ID,");
            strSql.Append("C_GP_BEFORE_ID=:C_GP_BEFORE_ID,");
            strSql.Append("C_GP_AFTER_ID=:C_GP_AFTER_ID,");
            strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
            strSql.Append("C_IS_PD=:C_IS_PD,");
            strSql.Append("C_ORDER_NO1=:C_ORDER_NO1,");
            strSql.Append("C_WWBATCH_NO=:C_WWBATCH_NO,");
            strSql.Append("C_FRFLAG=:C_FRFLAG,");
            strSql.Append("N_SFOB=:N_SFOB,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_SFJK=:C_SFJK,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_QGP_STATE=:C_QGP_STATE,");
            strSql.Append("C_COMMUTE_REASON=:C_COMMUTE_REASON,");
            strSql.Append("C_PCINFO=:C_PCINFO,");
            strSql.Append("C_DEPOT_TYPE=:C_DEPOT_TYPE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DP_DT", OracleDbType.Date),
                    new OracleParameter(":C_PLANT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN_RE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BARCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CKRY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CKRQ", OracleDbType.Date),
                    new OracleParameter(":C_RKRY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RKRQ", OracleDbType.Date),
                    new OracleParameter(":C_BZYQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WEIGHT_DT", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QTCKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ORDER_NO1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WWBATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FRFLAG", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_SFOB", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SFJK", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_PCINFO", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_DEPOT_TYPE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_EMP_ID;
            parameters[1].Value = model.D_MOD_DT;
            parameters[2].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_TICK_NO;
            parameters[6].Value = model.C_STL_GRD;
            parameters[7].Value = model.C_STL_GRD_BEFORE;
            parameters[8].Value = model.N_WGT;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_STD_CODE_BEFORE;
            parameters[11].Value = model.C_MOVE_TYPE;
            parameters[12].Value = model.C_SPEC;
            parameters[13].Value = model.C_SHIFT;
            parameters[14].Value = model.C_GROUP;
            parameters[15].Value = model.C_STA_ID;
            parameters[16].Value = model.C_JUDGE_LEV_BP;
            parameters[17].Value = model.C_DP_SHIFT;
            parameters[18].Value = model.C_DP_GROUP;
            parameters[19].Value = model.C_DP_EMP_ID;
            parameters[20].Value = model.D_DP_DT;
            parameters[21].Value = model.C_PLANT_ID;
            parameters[22].Value = model.C_PLANT_DESC;
            parameters[23].Value = model.C_MAT_CODE;
            parameters[24].Value = model.C_MAT_CODE_BEFORE;
            parameters[25].Value = model.C_MAT_DESC;
            parameters[26].Value = model.C_MAT_DESC_BEFORE;
            parameters[27].Value = model.C_IS_DEPOT;
            parameters[28].Value = model.C_PLAN_ID;
            parameters[29].Value = model.C_ORDER_NO;
            parameters[30].Value = model.C_CON_NO;
            parameters[31].Value = model.C_CUST_NO;
            parameters[32].Value = model.C_CUST_NAME;
            parameters[33].Value = model.C_ISFREE;
            parameters[34].Value = model.C_LINEWH_CODE;
            parameters[35].Value = model.C_LINEWH_AREA_CODE;
            parameters[36].Value = model.C_LINEWH_LOC_CODE;
            parameters[37].Value = model.C_FLOOR;
            parameters[38].Value = model.C_CUST_AREA;
            parameters[39].Value = model.C_SALE_AREA;
            parameters[40].Value = model.C_JUDGE_LEV_CF;
            parameters[41].Value = model.C_JUDGE_LEV_XN;
            parameters[42].Value = model.C_JUDGE_LEV_XN_RE;
            parameters[43].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
            parameters[44].Value = model.D_JUDGE_DATE;
            parameters[45].Value = model.C_IS_QR;
            parameters[46].Value = model.C_QR_USER;
            parameters[47].Value = model.D_QR_DATE;
            parameters[48].Value = model.C_DESIGN_NO;
            parameters[49].Value = model.C_JUDGE_LEV_ZH;
            parameters[50].Value = model.C_IS_TB;
            parameters[51].Value = model.C_SCUTCHEON;
            parameters[52].Value = model.C_GP_TYPE;
            parameters[53].Value = model.C_BARCODE;
            parameters[54].Value = model.C_RKDH;
            parameters[55].Value = model.C_FYDH;
            parameters[56].Value = model.C_CKDH;
            parameters[57].Value = model.C_MOVE_DESC;
            parameters[58].Value = model.C_CKRY;
            parameters[59].Value = model.D_CKRQ;
            parameters[60].Value = model.C_RKRY;
            parameters[61].Value = model.D_RKRQ;
            parameters[62].Value = model.C_BZYQ;
            parameters[63].Value = model.D_WEIGHT_DT;
            parameters[64].Value = model.D_PRODUCE_DATE;
            parameters[65].Value = model.C_ZYX1;
            parameters[66].Value = model.C_ZYX2;
            parameters[67].Value = model.C_ZKD_NO;
            parameters[68].Value = model.C_QTCKD_NO;
            parameters[69].Value = model.C_MASTER_ID;
            parameters[70].Value = model.C_GP_BEFORE_ID;
            parameters[71].Value = model.C_GP_AFTER_ID;
            parameters[72].Value = model.C_REASON_NAME;
            parameters[73].Value = model.C_IS_PD;
            parameters[74].Value = model.C_ORDER_NO1;
            parameters[75].Value = model.C_WWBATCH_NO;
            parameters[76].Value = model.C_FRFLAG;
            parameters[77].Value = model.N_SFOB;
            parameters[78].Value = model.C_STL_GRD_TYPE;
            parameters[79].Value = model.C_SFJK;
            parameters[80].Value = model.C_PROD_NAME;
            parameters[81].Value = model.C_PROD_KIND;
            parameters[82].Value = model.C_QGP_STATE;
            parameters[83].Value = model.C_COMMUTE_REASON;
            parameters[84].Value = model.C_PCINFO;
            parameters[85].Value = model.C_DEPOT_TYPE;
            parameters[86].Value = model.C_ID;

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
		public bool Update_Trans_XL(Mod_TRC_ROLL_PRODCUT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_PRODCUT set ");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_TRC_ROLL_MAIN_ID=:C_TRC_ROLL_MAIN_ID,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STL_GRD_BEFORE=:C_STL_GRD_BEFORE,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STD_CODE_BEFORE=:C_STD_CODE_BEFORE,");
            strSql.Append("C_MOVE_TYPE=:C_MOVE_TYPE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_JUDGE_LEV_BP=:C_JUDGE_LEV_BP,");
            strSql.Append("C_DP_SHIFT=:C_DP_SHIFT,");
            strSql.Append("C_DP_GROUP=:C_DP_GROUP,");
            strSql.Append("C_DP_EMP_ID=:C_DP_EMP_ID,");
            strSql.Append("D_DP_DT=:D_DP_DT,");
            strSql.Append("C_PLANT_ID=:C_PLANT_ID,");
            strSql.Append("C_PLANT_DESC=:C_PLANT_DESC,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_CODE_BEFORE=:C_MAT_CODE_BEFORE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC,");
            strSql.Append("C_MAT_DESC_BEFORE=:C_MAT_DESC_BEFORE,");
            strSql.Append("C_IS_DEPOT=:C_IS_DEPOT,");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("C_CUST_NO=:C_CUST_NO,");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME,");
            strSql.Append("C_ISFREE=:C_ISFREE,");
            strSql.Append("C_LINEWH_CODE=:C_LINEWH_CODE,");
            strSql.Append("C_LINEWH_AREA_CODE=:C_LINEWH_AREA_CODE,");
            strSql.Append("C_LINEWH_LOC_CODE=:C_LINEWH_LOC_CODE,");
            strSql.Append("C_FLOOR=:C_FLOOR,");
            strSql.Append("C_CUST_AREA=:C_CUST_AREA,");
            strSql.Append("C_SALE_AREA=:C_SALE_AREA,");
            strSql.Append("C_JUDGE_LEV_CF=:C_JUDGE_LEV_CF,");
            strSql.Append("C_JUDGE_LEV_XN=:C_JUDGE_LEV_XN,");
            strSql.Append("C_JUDGE_LEV_XN_RE=:C_JUDGE_LEV_XN_RE,");
            strSql.Append("C_JUDGE_LEV_ZH_PEOPLE=:C_JUDGE_LEV_ZH_PEOPLE,");
            strSql.Append("D_JUDGE_DATE=:D_JUDGE_DATE,");
            strSql.Append("C_IS_QR=:C_IS_QR,");
            strSql.Append("C_QR_USER=:C_QR_USER,");
            strSql.Append("D_QR_DATE=:D_QR_DATE,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            // strSql.Append("C_JUDGE_LEV_ZH=:C_JUDGE_LEV_ZH,");
            strSql.Append("C_IS_TB=:C_IS_TB,");
            strSql.Append("C_SCUTCHEON=:C_SCUTCHEON,");
            strSql.Append("C_GP_TYPE=:C_GP_TYPE,");
            strSql.Append("C_BARCODE=:C_BARCODE,");
            strSql.Append("C_RKDH=:C_RKDH,");
            strSql.Append("C_FYDH=:C_FYDH,");
            strSql.Append("C_CKDH=:C_CKDH,");
            strSql.Append("C_MOVE_DESC=:C_MOVE_DESC,");
            strSql.Append("C_CKRY=:C_CKRY,");
            strSql.Append("D_CKRQ=:D_CKRQ,");
            strSql.Append("C_RKRY=:C_RKRY,");
            strSql.Append("D_RKRQ=:D_RKRQ,");
            strSql.Append("C_BZYQ=:C_BZYQ,");
            strSql.Append("D_WEIGHT_DT=:D_WEIGHT_DT,");
            strSql.Append("D_PRODUCE_DATE=:D_PRODUCE_DATE,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_ZKD_NO=:C_ZKD_NO,");
            strSql.Append("C_QTCKD_NO=:C_QTCKD_NO,");
            strSql.Append("C_MASTER_ID=:C_MASTER_ID,");
            strSql.Append("C_GP_BEFORE_ID=:C_GP_BEFORE_ID,");
            strSql.Append("C_GP_AFTER_ID=:C_GP_AFTER_ID,");
            strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
            strSql.Append("C_IS_PD=:C_IS_PD,");
            strSql.Append("C_ORDER_NO1=:C_ORDER_NO1,");
            strSql.Append("C_WWBATCH_NO=:C_WWBATCH_NO,");
            strSql.Append("C_FRFLAG=:C_FRFLAG,");
            strSql.Append("N_SFOB=:N_SFOB,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_SFJK=:C_SFJK,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_QGP_STATE=:C_QGP_STATE,");
            strSql.Append("C_COMMUTE_REASON=:C_COMMUTE_REASON,");
            strSql.Append("C_PCINFO=:C_PCINFO,");
            strSql.Append("C_DEPOT_TYPE=:C_DEPOT_TYPE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DP_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DP_DT", OracleDbType.Date),
                    new OracleParameter(":C_PLANT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN_RE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    //new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BARCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CKRY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CKRQ", OracleDbType.Date),
                    new OracleParameter(":C_RKRY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RKRQ", OracleDbType.Date),
                    new OracleParameter(":C_BZYQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WEIGHT_DT", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QTCKD_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ORDER_NO1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WWBATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FRFLAG", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_SFOB", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SFJK", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_PCINFO", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_DEPOT_TYPE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_EMP_ID;
            parameters[1].Value = model.D_MOD_DT;
            parameters[2].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_TICK_NO;
            parameters[6].Value = model.C_STL_GRD;
            parameters[7].Value = model.C_STL_GRD_BEFORE;
            parameters[8].Value = model.N_WGT;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_STD_CODE_BEFORE;
            parameters[11].Value = model.C_MOVE_TYPE;
            parameters[12].Value = model.C_SPEC;
            parameters[13].Value = model.C_SHIFT;
            parameters[14].Value = model.C_GROUP;
            parameters[15].Value = model.C_STA_ID;
            parameters[16].Value = model.C_JUDGE_LEV_BP;
            parameters[17].Value = model.C_DP_SHIFT;
            parameters[18].Value = model.C_DP_GROUP;
            parameters[19].Value = model.C_DP_EMP_ID;
            parameters[20].Value = model.D_DP_DT;
            parameters[21].Value = model.C_PLANT_ID;
            parameters[22].Value = model.C_PLANT_DESC;
            parameters[23].Value = model.C_MAT_CODE;
            parameters[24].Value = model.C_MAT_CODE_BEFORE;
            parameters[25].Value = model.C_MAT_DESC;
            parameters[26].Value = model.C_MAT_DESC_BEFORE;
            parameters[27].Value = model.C_IS_DEPOT;
            parameters[28].Value = model.C_PLAN_ID;
            parameters[29].Value = model.C_ORDER_NO;
            parameters[30].Value = model.C_CON_NO;
            parameters[31].Value = model.C_CUST_NO;
            parameters[32].Value = model.C_CUST_NAME;
            parameters[33].Value = model.C_ISFREE;
            parameters[34].Value = model.C_LINEWH_CODE;
            parameters[35].Value = model.C_LINEWH_AREA_CODE;
            parameters[36].Value = model.C_LINEWH_LOC_CODE;
            parameters[37].Value = model.C_FLOOR;
            parameters[38].Value = model.C_CUST_AREA;
            parameters[39].Value = model.C_SALE_AREA;
            parameters[40].Value = model.C_JUDGE_LEV_CF;
            parameters[41].Value = model.C_JUDGE_LEV_XN;
            parameters[42].Value = model.C_JUDGE_LEV_XN_RE;
            parameters[43].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
            parameters[44].Value = model.D_JUDGE_DATE;
            parameters[45].Value = model.C_IS_QR;
            parameters[46].Value = model.C_QR_USER;
            parameters[47].Value = model.D_QR_DATE;
            parameters[48].Value = model.C_DESIGN_NO;
            parameters[49].Value = model.C_IS_TB;
            parameters[50].Value = model.C_SCUTCHEON;
            parameters[51].Value = model.C_GP_TYPE;
            parameters[52].Value = model.C_BARCODE;
            parameters[53].Value = model.C_RKDH;
            parameters[54].Value = model.C_FYDH;
            parameters[55].Value = model.C_CKDH;
            parameters[56].Value = model.C_MOVE_DESC;
            parameters[57].Value = model.C_CKRY;
            parameters[58].Value = model.D_CKRQ;
            parameters[59].Value = model.C_RKRY;
            parameters[60].Value = model.D_RKRQ;
            parameters[61].Value = model.C_BZYQ;
            parameters[62].Value = model.D_WEIGHT_DT;
            parameters[63].Value = model.D_PRODUCE_DATE;
            parameters[64].Value = model.C_ZYX1;
            parameters[65].Value = model.C_ZYX2;
            parameters[66].Value = model.C_ZKD_NO;
            parameters[67].Value = model.C_QTCKD_NO;
            parameters[68].Value = model.C_MASTER_ID;
            parameters[69].Value = model.C_GP_BEFORE_ID;
            parameters[70].Value = model.C_GP_AFTER_ID;
            parameters[71].Value = model.C_REASON_NAME;
            parameters[72].Value = model.C_IS_PD;
            parameters[73].Value = model.C_ORDER_NO1;
            parameters[74].Value = model.C_WWBATCH_NO;
            parameters[75].Value = model.C_FRFLAG;
            parameters[76].Value = model.N_SFOB;
            parameters[77].Value = model.C_STL_GRD_TYPE;
            parameters[78].Value = model.C_SFJK;
            parameters[79].Value = model.C_PROD_NAME;
            parameters[80].Value = model.C_PROD_KIND;
            parameters[81].Value = model.C_QGP_STATE;
            parameters[82].Value = model.C_COMMUTE_REASON;
            parameters[83].Value = model.C_PCINFO;
            parameters[84].Value = model.C_DEPOT_TYPE;
            parameters[85].Value = model.C_ID;

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
        public bool Update_Batch_No(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_PRODCUT set ");
            strSql.Append(" C_IS_TB= 'N' ");
            strSql.Append(" where C_BATCH_NO= '" + C_BATCH_NO + "'");
            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
            strSql.Append("delete from TRC_ROLL_PRODCUT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
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
            strSql.Append("delete from TRC_ROLL_PRODCUT ");
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
        public Mod_TRC_ROLL_PRODCUT GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_REASON_NAME,C_IS_PD,C_ORDER_NO1,C_WWBATCH_NO,C_FRFLAG,N_SFOB,C_STL_GRD_TYPE,C_SFJK,C_PROD_NAME,C_PROD_KIND ,C_QGP_STATE,C_COMMUTE_REASON,C_PCINFO,C_DEPOT_TYPE from TRC_ROLL_PRODCUT  ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_PRODCUT model = new Mod_TRC_ROLL_PRODCUT();
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
        public Mod_TRC_ROLL_PRODCUT GetModelByBatch(string C_BATCH_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_REASON_NAME,C_IS_PD,C_ORDER_NO1,C_WWBATCH_NO,C_FRFLAG,N_SFOB,C_STL_GRD_TYPE,C_SFJK,C_PROD_NAME,C_PROD_KIND,C_QGP_STATE,C_COMMUTE_REASON,C_PCINFO,C_DEPOT_TYPE from TRC_ROLL_PRODCUT  ");
            strSql.Append(" where C_BATCH_NO=:C_BATCH_NO and rownum=1 ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_BATCH_NO;

            Mod_TRC_ROLL_PRODCUT model = new Mod_TRC_ROLL_PRODCUT();
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
        public Mod_TRC_ROLL_PRODCUT GetModel_Iterface_Trans(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_REASON_NAME,C_IS_PD,C_ORDER_NO1,C_WWBATCH_NO,C_FRFLAG,N_SFOB,C_STL_GRD_TYPE,C_SFJK,C_PROD_NAME,C_PROD_KIND,C_QGP_STATE,C_COMMUTE_REASON,C_PCINFO,C_DEPOT_TYPE from TRC_ROLL_PRODCUT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_PRODCUT model = new Mod_TRC_ROLL_PRODCUT();
            DataSet ds = TransactionHelper.Query(strSql.ToString(), parameters);
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
        public Mod_TRC_ROLL_PRODCUT GetModel(string PH, string GH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_REASON_NAME,C_IS_PD,C_ORDER_NO1,C_WWBATCH_NO,C_FRFLAG,N_SFOB,C_STL_GRD_TYPE,C_SFJK,C_PROD_NAME,C_PROD_KIND,C_QGP_STATE,C_COMMUTE_REASON,C_PCINFO,C_DEPOT_TYPE from TRC_ROLL_PRODCUT ");
            strSql.Append(" where C_BATCH_NO=:PH ");
            strSql.Append(" AND C_TICK_NO=:GH ");
            OracleParameter[] parameters = {
                    new OracleParameter(":PH", OracleDbType.Varchar2,100) ,
                     new OracleParameter(":GH", OracleDbType.Varchar2,100)};
            parameters[0].Value = PH;
            parameters[1].Value = GH;

            Mod_TRC_ROLL_PRODCUT model = new Mod_TRC_ROLL_PRODCUT();
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
		public Mod_TRC_ROLL_PRODCUT DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_PRODCUT model = new Mod_TRC_ROLL_PRODCUT();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_TRC_ROLL_MAIN_ID"] != null)
                {
                    model.C_TRC_ROLL_MAIN_ID = row["C_TRC_ROLL_MAIN_ID"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STL_GRD_BEFORE"] != null)
                {
                    model.C_STL_GRD_BEFORE = row["C_STL_GRD_BEFORE"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STD_CODE_BEFORE"] != null)
                {
                    model.C_STD_CODE_BEFORE = row["C_STD_CODE_BEFORE"].ToString();
                }
                if (row["C_MOVE_TYPE"] != null)
                {
                    model.C_MOVE_TYPE = row["C_MOVE_TYPE"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_JUDGE_LEV_BP"] != null)
                {
                    model.C_JUDGE_LEV_BP = row["C_JUDGE_LEV_BP"].ToString();
                }
                if (row["C_DP_SHIFT"] != null)
                {
                    model.C_DP_SHIFT = row["C_DP_SHIFT"].ToString();
                }
                if (row["C_DP_GROUP"] != null)
                {
                    model.C_DP_GROUP = row["C_DP_GROUP"].ToString();
                }
                if (row["C_DP_EMP_ID"] != null)
                {
                    model.C_DP_EMP_ID = row["C_DP_EMP_ID"].ToString();
                }
                if (row["D_DP_DT"] != null && row["D_DP_DT"].ToString() != "")
                {
                    model.D_DP_DT = DateTime.Parse(row["D_DP_DT"].ToString());
                }
                if (row["C_PLANT_ID"] != null)
                {
                    model.C_PLANT_ID = row["C_PLANT_ID"].ToString();
                }
                if (row["C_PLANT_DESC"] != null)
                {
                    model.C_PLANT_DESC = row["C_PLANT_DESC"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_CODE_BEFORE"] != null)
                {
                    model.C_MAT_CODE_BEFORE = row["C_MAT_CODE_BEFORE"].ToString();
                }
                if (row["C_MAT_DESC"] != null)
                {
                    model.C_MAT_DESC = row["C_MAT_DESC"].ToString();
                }
                if (row["C_MAT_DESC_BEFORE"] != null)
                {
                    model.C_MAT_DESC_BEFORE = row["C_MAT_DESC_BEFORE"].ToString();
                }
                if (row["C_IS_DEPOT"] != null)
                {
                    model.C_IS_DEPOT = row["C_IS_DEPOT"].ToString();
                }
                if (row["C_PLAN_ID"] != null)
                {
                    model.C_PLAN_ID = row["C_PLAN_ID"].ToString();
                }
                if (row["C_ORDER_NO"] != null)
                {
                    model.C_ORDER_NO = row["C_ORDER_NO"].ToString();
                }
                if (row["C_CON_NO"] != null)
                {
                    model.C_CON_NO = row["C_CON_NO"].ToString();
                }
                if (row["C_CUST_NO"] != null)
                {
                    model.C_CUST_NO = row["C_CUST_NO"].ToString();
                }
                if (row["C_CUST_NAME"] != null)
                {
                    model.C_CUST_NAME = row["C_CUST_NAME"].ToString();
                }
                if (row["C_ISFREE"] != null)
                {
                    model.C_ISFREE = row["C_ISFREE"].ToString();
                }
                if (row["C_LINEWH_CODE"] != null)
                {
                    model.C_LINEWH_CODE = row["C_LINEWH_CODE"].ToString();
                }
                if (row["C_LINEWH_AREA_CODE"] != null)
                {
                    model.C_LINEWH_AREA_CODE = row["C_LINEWH_AREA_CODE"].ToString();
                }
                if (row["C_LINEWH_LOC_CODE"] != null)
                {
                    model.C_LINEWH_LOC_CODE = row["C_LINEWH_LOC_CODE"].ToString();
                }
                if (row["C_FLOOR"] != null)
                {
                    model.C_FLOOR = row["C_FLOOR"].ToString();
                }
                if (row["C_CUST_AREA"] != null)
                {
                    model.C_CUST_AREA = row["C_CUST_AREA"].ToString();
                }
                if (row["C_SALE_AREA"] != null)
                {
                    model.C_SALE_AREA = row["C_SALE_AREA"].ToString();
                }
                if (row["C_JUDGE_LEV_CF"] != null)
                {
                    model.C_JUDGE_LEV_CF = row["C_JUDGE_LEV_CF"].ToString();
                }
                if (row["C_JUDGE_LEV_XN"] != null)
                {
                    model.C_JUDGE_LEV_XN = row["C_JUDGE_LEV_XN"].ToString();
                }
                if (row["C_JUDGE_LEV_XN_RE"] != null)
                {
                    model.C_JUDGE_LEV_XN_RE = row["C_JUDGE_LEV_XN_RE"].ToString();
                }
                if (row["C_JUDGE_LEV_ZH_PEOPLE"] != null)
                {
                    model.C_JUDGE_LEV_ZH_PEOPLE = row["C_JUDGE_LEV_ZH_PEOPLE"].ToString();
                }
                if (row["D_JUDGE_DATE"] != null && row["D_JUDGE_DATE"].ToString() != "")
                {
                    model.D_JUDGE_DATE = DateTime.Parse(row["D_JUDGE_DATE"].ToString());
                }
                if (row["C_IS_QR"] != null)
                {
                    model.C_IS_QR = row["C_IS_QR"].ToString();
                }
                if (row["C_QR_USER"] != null)
                {
                    model.C_QR_USER = row["C_QR_USER"].ToString();
                }
                if (row["D_QR_DATE"] != null && row["D_QR_DATE"].ToString() != "")
                {
                    model.D_QR_DATE = DateTime.Parse(row["D_QR_DATE"].ToString());
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["C_JUDGE_LEV_ZH"] != null)
                {
                    model.C_JUDGE_LEV_ZH = row["C_JUDGE_LEV_ZH"].ToString();
                }
                if (row["C_IS_TB"] != null)
                {
                    model.C_IS_TB = row["C_IS_TB"].ToString();
                }
                if (row["C_SCUTCHEON"] != null)
                {
                    model.C_SCUTCHEON = row["C_SCUTCHEON"].ToString();
                }
                if (row["C_GP_TYPE"] != null)
                {
                    model.C_GP_TYPE = row["C_GP_TYPE"].ToString();
                }
                if (row["C_BARCODE"] != null)
                {
                    model.C_BARCODE = row["C_BARCODE"].ToString();
                }
                if (row["C_RKDH"] != null)
                {
                    model.C_RKDH = row["C_RKDH"].ToString();
                }
                if (row["C_FYDH"] != null)
                {
                    model.C_FYDH = row["C_FYDH"].ToString();
                }
                if (row["C_CKDH"] != null)
                {
                    model.C_CKDH = row["C_CKDH"].ToString();
                }
                if (row["C_MOVE_DESC"] != null)
                {
                    model.C_MOVE_DESC = row["C_MOVE_DESC"].ToString();
                }
                if (row["C_CKRY"] != null)
                {
                    model.C_CKRY = row["C_CKRY"].ToString();
                }
                if (row["D_CKRQ"] != null && row["D_CKRQ"].ToString() != "")
                {
                    model.D_CKRQ = DateTime.Parse(row["D_CKRQ"].ToString());
                }
                if (row["C_RKRY"] != null)
                {
                    model.C_RKRY = row["C_RKRY"].ToString();
                }
                if (row["D_RKRQ"] != null && row["D_RKRQ"].ToString() != "")
                {
                    model.D_RKRQ = DateTime.Parse(row["D_RKRQ"].ToString());
                }
                if (row["C_BZYQ"] != null)
                {
                    model.C_BZYQ = row["C_BZYQ"].ToString();
                }
                if (row["D_WEIGHT_DT"] != null && row["D_WEIGHT_DT"].ToString() != "")
                {
                    model.D_WEIGHT_DT = DateTime.Parse(row["D_WEIGHT_DT"].ToString());
                }
                if (row["D_PRODUCE_DATE"] != null && row["D_PRODUCE_DATE"].ToString() != "")
                {
                    model.D_PRODUCE_DATE = DateTime.Parse(row["D_PRODUCE_DATE"].ToString());
                }
                if (row["C_ZYX1"] != null)
                {
                    model.C_ZYX1 = row["C_ZYX1"].ToString();
                }
                if (row["C_ZYX2"] != null)
                {
                    model.C_ZYX2 = row["C_ZYX2"].ToString();
                }
                if (row["C_ZKD_NO"] != null)
                {
                    model.C_ZKD_NO = row["C_ZKD_NO"].ToString();
                }
                if (row["C_QTCKD_NO"] != null)
                {
                    model.C_QTCKD_NO = row["C_QTCKD_NO"].ToString();
                }
                if (row["C_MASTER_ID"] != null)
                {
                    model.C_MASTER_ID = row["C_MASTER_ID"].ToString();
                }
                if (row["C_GP_BEFORE_ID"] != null)
                {
                    model.C_GP_BEFORE_ID = row["C_GP_BEFORE_ID"].ToString();
                }
                if (row["C_GP_AFTER_ID"] != null)
                {
                    model.C_GP_AFTER_ID = row["C_GP_AFTER_ID"].ToString();
                }
                if (row["C_REASON_NAME"] != null)
                {
                    model.C_REASON_NAME = row["C_REASON_NAME"].ToString();
                }
                if (row["C_IS_PD"] != null)
                {
                    model.C_IS_PD = row["C_IS_PD"].ToString();
                }
                if (row["C_ORDER_NO1"] != null)
                {
                    model.C_ORDER_NO1 = row["C_ORDER_NO1"].ToString();
                }
                if (row["C_WWBATCH_NO"] != null)
                {
                    model.C_WWBATCH_NO = row["C_WWBATCH_NO"].ToString();
                }
                if (row["C_FRFLAG"] != null)
                {
                    model.C_FRFLAG = row["C_FRFLAG"].ToString();
                }
                if (row["N_SFOB"] != null && row["N_SFOB"].ToString() != "")
                {
                    model.N_SFOB = decimal.Parse(row["N_SFOB"].ToString());
                }
                if (row["C_STL_GRD_TYPE"] != null)
                {
                    model.C_STL_GRD_TYPE = row["C_STL_GRD_TYPE"].ToString();
                }
                if (row["C_SFJK"] != null)
                {
                    model.C_SFJK = row["C_SFJK"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["C_QGP_STATE"] != null)
                {
                    model.C_QGP_STATE = row["C_QGP_STATE"].ToString();
                }
                if (row["C_COMMUTE_REASON"] != null)
                {
                    model.C_COMMUTE_REASON = row["C_COMMUTE_REASON"].ToString();
                }
                if (row["C_PCINFO"] != null)
                {
                    model.C_PCINFO = row["C_PCINFO"].ToString();
                }
                if (row["C_DEPOT_TYPE"] != null)
                {
                    model.C_DEPOT_TYPE = row["C_DEPOT_TYPE"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表-转库
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList_ZK(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE ='Z' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + strWhere + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-未入库
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList_WRK(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE ='N' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + strWhere + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-已入库
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList_RK(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2 ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE ='E' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + strWhere + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-已入库
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <param name="C_LINEWH_LOC_CODE">库位</param>
        /// <param name="C_LINEWH_AREA_CODE">区域</param>
        /// <param name="C_LINEWH_CODE">仓库</param>
        /// <returns></returns>
        public DataSet GetList_RK_KW(string strWhere, string C_LINEWH_LOC_CODE, string C_LINEWH_AREA_CODE, string C_LINEWH_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where  C_MOVE_TYPE ='E' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + strWhere + "%' ");
            }
            if (C_LINEWH_LOC_CODE.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_LOC_CODE ='" + C_LINEWH_LOC_CODE + "' ");
            }
            if (C_LINEWH_AREA_CODE.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_AREA_CODE ='" + C_LINEWH_AREA_CODE + "' ");
            }
            if (C_LINEWH_CODE.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_CODE ='" + C_LINEWH_CODE + "' ");
            }
            strSql.Append(" order by C_BATCH_NO,to_number(nvl(C_TICK_NO,'0')) ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-零星材已入库
        /// </summary>
        /// <param name="C_LINEWH_AREA_CODE">区域</param>
        /// <param name="begin">起始库位</param>
        /// <param name="end">截止库位</param>
        /// <returns></returns>
        public DataSet GetList_LXC(string C_LINEWH_AREA_CODE, string begin, string end)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE = 'E'  ");
            if (C_LINEWH_AREA_CODE.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_AREA_CODE = '" + C_LINEWH_AREA_CODE + "' ");
            }
            if (begin.Trim() != "" && end.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_LOC_CODE between  '" + begin + "' and '" + end + "'  ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-已入库-13库到21库
        /// </summary>        
        /// <returns></returns>
        public DataSet GetList_RK_KW_13_21()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE = 'E' and C_LINEWH_LOC_CODE between  6030112 and 6030121  ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE ='E' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + strWhere + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_Batch(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select t.C_ID,t.C_BATCH_NO,T.C_STD_CODE,T.C_STL_GRD,T.C_TICK_NO,T.C_SPEC  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT t where  1=1 ");
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO = '" + C_BATCH_NO + "' ");
            }
            strSql.Append(" ORDER BY to_number(T.C_TICK_NO) ASC ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_Tick_No(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID,t.C_BATCH_NO ,T.C_TICK_NO FROM TRC_ROLL_PRODCUT t ");
            strSql.Append(" where  1=1   and t.c_batch_no='" + C_BATCH_NO + "' ");
            strSql.Append(" ORDER BY to_number(T.C_TICK_NO)  ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_TickNo_Check(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t1.c_id,t1.c_batch_no,T1.C_TICK_NO, t.rowid from TQC_UPDATE_MATERIAL t  JOIN TRC_ROLL_PRODCUT T1 ON T.C_ROLL_PRODUCT_ID=T1.C_ID   WHERE T.N_STATUS=1  and  t1.c_batch_no='" + C_BATCH_NO + "' ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 条件获得数据列表
        /// </summary>
        /// <param name="begin">时间 开始</param>
        /// <param name="end">时间 结束</param>
        /// <param name="pland">车间</param>
        /// <param name="batch">批号</param>
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <returns></returns>
        public DataSet GetList_Query1(DateTime begin, DateTime end, string pland, string batch, string stl, string std)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.c_sta_desc,DECODE(T.C_MOVE_TYPE,'N','库存状态', 'E','已入库', 'S','已销售', 'O', '已占用', 'M','转库', 'QC','其他出库', 'QE','其他完成', 'QS','委外完成',' QM','委外转库状态', 'QD','委外已撤销')C_MOVE_TYPE,c.c_linewh_name, t.c_std_code,t.C_JUDGE_LEV_BP,t.C_DP_SHIFT,b.c_name,t.C_DP_GROUP,max(D_DP_DT) DT,t. C_MAT_CODE,t.C_MAT_DESC,t.C_LINEWH_CODE,t.C_BATCH_NO,t.C_JUDGE_LEV_ZH,t.C_STL_GRD,t.C_SPEC,t.C_STOVE,t.C_ZYX1,t.C_ZYX2,t.C_BZYQ,SUM(N_WGT) N_WGT,COUNT(1) N_NUM ,max(D_PRODUCE_DATE)AS D_PRODUCE_DATE  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT t left join tb_sta a on t.c_sta_id=a.c_id left join ts_user b on t.c_dp_emp_id=b.c_account left join tpb_linewh c on t.c_linewh_code=c.c_linewh_code WHERE T.C_MOVE_TYPE not in ('S')  ");
            if (begin != null && end != null)
            {
                strSql.Append("and t.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (pland != "全部")
            {
                strSql.Append(" and a.c_sta_desc ='" + pland + "' ");
            }
            if (batch.Trim() != "")
            {
                strSql.Append(" and t.C_BATCH_NO like '%" + batch + "%' ");
            }
            if (!string.IsNullOrEmpty(stl))
            {
                strSql.Append(" and t.C_STL_GRD like '%" + stl + "%' ");
            }
            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append(" and t.c_std_code like '%" + std + "%' ");
            }
            strSql.Append(" GROUP BY  a.c_sta_desc,c.c_linewh_name,t.C_MOVE_TYPE,t.c_std_code,b.c_name,t.C_MAT_CODE,t.C_MAT_DESC,t.C_LINEWH_CODE,t.C_BATCH_NO,t.C_JUDGE_LEV_ZH,t.C_STL_GRD,t.C_SPEC,t.C_STOVE,t.C_ZYX1,t.C_ZYX2,t.C_BZYQ,t. C_JUDGE_LEV_BP,t.C_DP_SHIFT,t.C_DP_EMP_ID,t.C_DP_GROUP,A.C_STA_CODE ORDER BY A.C_STA_CODE,t.C_BATCH_NO ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_ID">主键</param>
        /// <returns></returns>
        public DataSet GetList_ID(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2 ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT ");
            if (C_ID.Trim() != "")
            {
                strSql.Append(" where C_ID='" + C_ID + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_PLANT_DESC">工厂描述</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_SHIFT">班次</param>
        /// <param name="C_GROUP">班组</param>
        /// <returns></returns>
        public DataSet GetList_Tick_No(string C_PLANT_DESC, string c_batch_no, string C_STOVE, string C_STL_GRD, string C_STD_CODE, string C_SPEC, string C_SHIFT, string C_GROUP)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select c_id, c_tick_no  ");
            strSql.Append("from TRC_ROLL_PRODCUT  where C_JUDGE_LEV_BP IS NULL and c_batch_no = '" + c_batch_no + "'  ");
            if (!string.IsNullOrEmpty(C_PLANT_DESC))
            {
                strSql.Append(" and C_PLANT_DESC = '" + C_PLANT_DESC + "' ");
            }
            if (!string.IsNullOrEmpty(C_STOVE))
            {
                strSql.Append(" and C_STOVE = '" + C_STOVE + "' ");
            }
            if (!string.IsNullOrEmpty(C_STL_GRD))
            {
                strSql.Append(" and C_STL_GRD = '" + C_STL_GRD + "' ");
            }
            if (!string.IsNullOrEmpty(C_STD_CODE))
            {
                strSql.Append(" and C_STD_CODE = '" + C_STD_CODE + "' ");
            }
            if (!string.IsNullOrEmpty(C_SPEC))
            {
                strSql.Append(" and C_SPEC = '" + C_SPEC + "' ");
            }
            if (!string.IsNullOrEmpty(C_SHIFT))
            {
                strSql.Append(" and C_SHIFT = '" + C_SHIFT + "' ");
            }
            if (!string.IsNullOrEmpty(C_GROUP))
            {
                strSql.Append(" and C_GROUP = '" + C_GROUP + "' ");
            }
            strSql.Append(" order by c_tick_no");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_PLANT_DESC">工厂描述</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_SHIFT">班次</param>
        /// <param name="C_GROUP">班组</param>
        /// <returns></returns>
        public DataSet GetList_Tick_No_All(string C_PLANT_DESC, string c_batch_no, string C_STOVE, string C_STL_GRD, string C_STD_CODE, string C_SPEC, string C_SHIFT, string C_GROUP)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.c_id, t.c_tick_no  ");
            strSql.Append("from TRC_ROLL_PRODCUT t where 1=1");
            if (C_PLANT_DESC.Trim() != "" && c_batch_no.Trim() != "" && C_STOVE.Trim() != "" && C_STL_GRD.Trim() != "" && C_STD_CODE.Trim() != "" && C_SPEC.Trim() != "" && C_SHIFT.Trim() != "" && C_GROUP.Trim() != "")
            {
                strSql.Append("and t.C_PLANT_DESC = '" + C_PLANT_DESC + "' and t.c_batch_no = '" + c_batch_no + "' and t.C_STOVE = '" + C_STOVE + "'  and t.C_STL_GRD = '" + C_STL_GRD + "' and t.C_STD_CODE = '" + C_STD_CODE + "' and t.C_SPEC = '" + C_SPEC + "' and t.C_SHIFT = '" + C_SHIFT + "' and t.C_GROUP = '" + C_GROUP + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_PLANT_DESC">工厂描述</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_SHIFT">班次</param>
        /// <param name="C_GROUP">班组</param>
        /// <returns></returns>
        public DataSet GetList_WGT_All(string batchno, string strSTLGRD, string strSTDCode, string strDJ, string strMatCode, string strPack, string strLineWHCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select T.*  ");
            strSql.Append("from TRC_ROLL_PRODCUT t where  t.c_move_type='E' ");
            if (batchno.Trim() != "" && strSTLGRD.Trim() != "" && strSTDCode.Trim() != "" && strDJ.Trim() != "" && strMatCode.Trim() != "" && strPack.Trim() != "" && strLineWHCode.Trim() != "")
            {
                strSql.Append(" and t.C_BATCH_NO='" + batchno + "' and t.C_STL_GRD='" + strSTLGRD + "' and t.C_STD_CODE='" + strSTDCode + "' and t.C_JUDGE_LEV_ZH='" + strDJ + "' and t.C_MAT_CODE='" + strMatCode + "' and t.C_BZYQ='" + strPack + "' and t.C_LINEWH_CODE='" + strLineWHCode + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 条件获得数据列表
        /// </summary>
        /// <param name="begin">生产时间 开始</param>
        /// <param name="end">生产时间 结束</param>
        /// <param name="pland">车间</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string pland, string batch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.c_sta_desc,t.c_sta_id,t.c_batch_no,t.C_STOVE,t.C_STL_GRD,t.C_STD_CODE,t.C_SPEC,t.C_SHIFT,t.C_GROUP,count(1) COU,max(t.D_MOD_DT) DT  ");
            strSql.Append(" from TRC_ROLL_PRODCUT t join tb_sta a on t.c_sta_id=a.c_id  where C_JUDGE_LEV_BP IS NULL ");
            if (begin != null && end != null)
            {
                strSql.Append("and t.D_DP_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (pland != "全部")
            {
                strSql.Append(" and t.c_sta_id ='" + pland + "' ");
            }
            if (!string.IsNullOrEmpty(batch))
            {
                strSql.Append(" and t.C_BATCH_NO ='" + batch + "' ");
            }
            strSql.Append(" group by a.c_sta_desc,t.c_sta_id,t.c_batch_no,t.C_STOVE,t.C_STL_GRD,t.C_STD_CODE,t.C_SPEC,t.C_SHIFT,t.C_GROUP");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取线材实绩信息
        /// </summary>
        /// <param name="begin">生产时间 开始</param>
        /// <param name="end">生产时间 结束</param>
        /// <param name="pland">车间</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public DataSet GetProductList(DateTime begin, DateTime end, string pland, string batch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_STA_ID,t.c_batch_no,t.C_STOVE,t.C_STL_GRD,t.C_STD_CODE,t.C_SPEC,t.C_SHIFT,t.C_GROUP,count(1) COU,max(t.D_DP_DT) DT");
            strSql.Append(" from TRC_ROLL_PRODCUT t where 1=1 ");
            if (begin != null && end != null)
            {
                strSql.Append("and D_DP_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (pland != "全部")
            {
                strSql.Append(" and C_PLANT_DESC ='" + pland + "' ");
            }
            if (!string.IsNullOrEmpty(batch))
            {
                strSql.Append(" and C_BATCH_NO ='" + batch + "' ");
            }
            strSql.Append("group by t.C_STA_ID,t.c_batch_no,t.C_STOVE,t.C_STL_GRD,t.C_STD_CODE,t.C_SPEC,t.C_SHIFT,t.C_GROUP");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRC_ROLL_PRODCUT ");
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_PRODCUT T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询线材综合判定数据
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <returns></returns>
        public DataSet GetList(string batchNo, string stove, string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_STOVE AS 炉号, T.C_BATCH_NO AS 批号, T.C_STL_GRD AS 钢种, T.C_SPEC AS 规格, T.C_STD_CODE AS 执行标准, T.C_MAT_CODE AS 物料编码, T.C_MAT_NAME AS 物料名称, T.N_QUA AS 件数, T.N_WGT AS 重量, T.C_RESULT_FACE AS 表判结果, T.C_REASON_NAME AS 不合格原因, T.C_RESULT_ELE AS 成分结果, T.C_RESULT_PHY AS 性能初检结果, T.C_RESULT_PHYSEC AS 性能复检结果, T.C_RESULT_PHYFINAL AS 性能评审结果, T.C_RESULT_ALL AS 综合判定结果, T.C_RESULT_PEOPLE AS 人工判定结果, T.D_RESALL_DT AS 判定时间, T.C_QR_STATE AS 是否确认, T.C_EMP_ID AS 确认人, T.D_MOD_DT AS 确认时间, T.D_DP_DT AS 生产时间, T.C_DESIGN_NO AS 质量设计号  FROM TQC_COMPRE_ROLL T WHERE N_STATUS=1 ");

            if (batchNo.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO like '" + batchNo + "%' ");
            }

            if (stove.Trim() != "")
            {
                strSql.Append(" and T.C_STOVE like '" + stove + "%' ");
            }

            if (strTime1.Trim() != "" && strTime2.Trim() != "")
            {
                strSql.Append(" and T.D_DP_DT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            strSql.Append(" order by T.D_DP_DT desc");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataSet GetList_GP(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID, t2.c_linewh_name,t.C_EMP_ID,t.D_MOD_DT,t.C_TRC_ROLL_MAIN_ID,t.C_STOVE,t.C_BATCH_NO,t.C_TICK_NO,t.C_STL_GRD,t.C_STL_GRD_BEFORE,t.N_WGT,t.C_STD_CODE,t.C_STD_CODE_BEFORE,t.C_MOVE_TYPE,t.C_SPEC,t.C_SHIFT,t.C_GROUP,t.C_STA_ID,t.C_JUDGE_LEV_BP,t.C_DP_SHIFT,t.C_DP_GROUP,t.C_DP_EMP_ID,t.D_DP_DT,t.C_PLANT_ID,t.C_PLANT_DESC,t.C_MAT_CODE,t.C_MAT_CODE_BEFORE,t.C_MAT_DESC,t.C_MAT_DESC_BEFORE,t.C_IS_DEPOT,t.C_PLAN_ID,t.C_ORDER_NO,t.C_CON_NO,t.C_CUST_NO,t.C_CUST_NAME,t.C_ISFREE,t.C_LINEWH_CODE,t.C_LINEWH_AREA_CODE,t.C_LINEWH_LOC_CODE,t.C_FLOOR,t.C_CUST_AREA,t.C_SALE_AREA,t.C_JUDGE_LEV_CF,t.C_JUDGE_LEV_XN,t.C_JUDGE_LEV_XN_RE,t.C_JUDGE_LEV_ZH_PEOPLE,t.D_JUDGE_DATE,t.C_IS_QR,t.C_QR_USER,t.D_QR_DATE,t.C_DESIGN_NO,t.C_JUDGE_LEV_ZH,t.C_IS_TB,t.C_SCUTCHEON,t.C_GP_TYPE,t.C_BARCODE,t.C_RKDH,t.C_FYDH,t.C_CKDH,t.C_MOVE_DESC,t.C_CKRY,t.D_CKRQ,t.C_RKRY,t.D_RKRQ,t.C_BZYQ,t.D_WEIGHT_DT,t.D_PRODUCE_DATE,t.C_ZYX1,t.C_ZYX2,t.C_BZYQ ,(select max(t1.c_sta_desc) from tsc_slab_main t1 where t1.c_stove= t.c_stove )c_sta_desc FROM TRC_ROLL_PRODCUT t join tpb_linewh t2  on t.c_linewh_code = t2.c_linewh_code where t.C_MOVE_TYPE ='E'  ");

            if (begin != null && end != null)
            {
                strSql.Append("and t.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }

            strSql.Append(" order by C_BATCH_NO,to_number(nvl(c_tick_no,'0')) ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param> 
        /// <returns></returns>
        public DataSet GetList_XL(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  T.C_ID,t1.c_remark, T.C_STOVE,T.C_BATCH_NO,t.c_tick_no,T.C_STL_GRD,T.C_PCINFO,T.C_STD_CODE,T.C_SPEC, T.D_PRODUCE_DATE , T.N_WGT   ,T.C_MAT_CODE,T.C_MAT_DESC,T.C_JUDGE_LEV_BP, T.C_JUDGE_LEV_ZH,T.C_ZYX1, T.C_ZYX2   FROM TRC_ROLL_PRODCUT T  INNER JOIN tqc_upd_material_main t1 ON t1.c_batch_no=t.c_batch_no WHERE T.C_MOVE_TYPE = 'E' AND t1.n_status=1  ");

            if (begin != null && end != null)
            {
                strSql.Append("and t.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and t.C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }
            strSql.Append(" order by T.C_BATCH_NO ,to_number(nvl(t.c_tick_no,'0'))  ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param> 
        /// <returns></returns>
        public DataSet GetList_TSXX(string C_BATCH_NO, string strTime1, string strTime2, string strTsxx, string strLineCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID, t.C_PCINFO,ts.c_name,t.c_plant_desc, t.C_STOVE, t.C_BATCH_NO, t.C_TICK_NO, t.C_STL_GRD, t.N_WGT, t.C_STD_CODE, t.C_SPEC, t.C_JUDGE_LEV_BP, t.C_MAT_CODE, t.C_MAT_DESC, t.C_JUDGE_LEV_ZH, t.D_WEIGHT_DT, t.D_PRODUCE_DATE, t.C_ZYX1, t.C_ZYX2, t.C_BZYQ ");

            strSql.Append(" FROM TRC_ROLL_PRODCUT t left join ts_user ts on ts.c_id=t.c_emp_id where t.c_move_type<>'S' and C_BATCH_NO like '3%' ");

            if (!string.IsNullOrEmpty(C_BATCH_NO))
            {
                strSql.Append(" and C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }

            if (!string.IsNullOrEmpty(strTime1) && !string.IsNullOrEmpty(strTime2))
            {
                strSql.Append(" and t.d_produce_date between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            if (strTsxx != "全部")
            {
                if (string.IsNullOrEmpty(strTsxx))
                {
                    strSql.Append(" and t.c_pcinfo is null ");
                }
                else
                {
                    strSql.Append(" and t.c_pcinfo like '%" + strTsxx + "%' ");
                }
            }

            if (!string.IsNullOrEmpty(strLineCode))
            {
                strSql.Append(" and C_BATCH_NO like '3" + strLineCode.Substring(0, 1) + "%' ");
            }

            strSql.Append(" order by C_BATCH_NO,to_number(nvl(c_tick_no,'0')) ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataSet GetList_PJGX(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(T.C_ID) COU,   t.C_STOVE, t.C_BATCH_NO, t.c_Stl_Grd, t.c_std_code, t.C_SPEC, MAX( t.D_PRODUCE_DATE) AS D_PRODUCE_DATE,  SUM(t.n_wgt) AS n_wgt, t.C_MAT_CODE,  t.c_mat_desc,  t.C_JUDGE_LEV_BP,  t.C_JUDGE_LEV_ZH, t.C_ZYX1,  t.c_Zyx2,  T.C_BZYQ   FROM TRC_ROLL_PRODCUT T   WHERE T.C_MOVE_TYPE = 'E' AND t.c_is_qr='N' AND t.c_stl_grd IN ('GCr15','60Si2MnA','55SiCrA-1','XGM6-1')  AND t.c_judge_lev_bp LIKE 'A%'  ");

            if (begin != null && end != null)
            {
                strSql.Append("and t.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }
            strSql.Append(" GROUP BY   t.C_STOVE, t.C_BATCH_NO,  t.c_Stl_Grd, t.c_std_code, t.C_SPEC,  t.C_MAT_CODE,  t.c_mat_desc, t.C_JUDGE_LEV_BP, t.C_JUDGE_LEV_ZH,  t.C_ZYX1, t.c_Zyx2, T.C_BZYQ ");
            strSql.Append(" order by C_BATCH_NO  ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataSet GetList_XLSQ(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(T.C_ID) COU, T.C_STOVE,T.C_BATCH_NO,T.C_STL_GRD,T.C_PCINFO,T.C_STD_CODE,T.C_SPEC,MAX(T.D_PRODUCE_DATE) AS D_PRODUCE_DATE,SUM(T.N_WGT) AS N_WGT,T.C_MAT_CODE,T.C_MAT_DESC,T.C_ZYX1, T.C_ZYX2   FROM TRC_ROLL_PRODCUT T WHERE T.C_MOVE_TYPE = 'E'    ");

            if (begin != null && end != null)
            {
                strSql.Append("and t.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }
            strSql.Append("  GROUP BY T.C_STOVE,T.C_BATCH_NO,T.C_STL_GRD, T.C_PCINFO,T.C_STD_CODE, T.C_SPEC,  T.C_MAT_CODE,T.C_MAT_DESC, T.C_JUDGE_LEV_BP,  T.C_JUDGE_LEV_ZH, T.C_ZYX1, T.C_ZYX2  ");
            strSql.Append(" order by T.C_BATCH_NO  ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param> 
        /// <returns></returns>
        public DataSet GetList_XLSQ(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(T.C_ID) COU, T.C_STOVE,T.C_BATCH_NO,T.C_STL_GRD,T.C_PCINFO,T.C_STD_CODE,T.C_SPEC,MAX(T.D_PRODUCE_DATE) AS D_PRODUCE_DATE,SUM(T.N_WGT) AS N_WGT,T.C_MAT_CODE,T.C_MAT_DESC,T.C_JUDGE_LEV_BP, T.C_JUDGE_LEV_ZH,T.C_ZYX1, T.C_ZYX2   FROM TRC_ROLL_PRODCUT T WHERE T.C_MOVE_TYPE = 'E'    ");
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO = '" + C_BATCH_NO + "' ");
            }
            strSql.Append("  GROUP BY T.C_STOVE,T.C_BATCH_NO,T.C_STL_GRD, T.C_PCINFO,T.C_STD_CODE, T.C_SPEC,  T.C_MAT_CODE,T.C_MAT_DESC, T.C_JUDGE_LEV_BP,  T.C_JUDGE_LEV_ZH, T.C_ZYX1, T.C_ZYX2  ");
            strSql.Append(" order by T.C_BATCH_NO  ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="lenwhCode">仓库</param>
        /// <returns></returns>
        public DataSet GetList_WWGP(DateTime begin, DateTime end, string C_BATCH_NO, string lenwhCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID, t2.c_linewh_name,t.C_EMP_ID,t.D_MOD_DT,t.C_TRC_ROLL_MAIN_ID,t.C_STOVE,t.C_BATCH_NO,t.C_TICK_NO,t.C_STL_GRD,t.C_STL_GRD_BEFORE,t.N_WGT,t.C_STD_CODE,t.C_STD_CODE_BEFORE,t.C_MOVE_TYPE,t.C_SPEC,t.C_SHIFT,t.C_GROUP,t.C_STA_ID,t.C_JUDGE_LEV_BP,t.C_DP_SHIFT,t.C_DP_GROUP,t.C_DP_EMP_ID,t.D_DP_DT,t.C_PLANT_ID,t.C_PLANT_DESC,t.C_MAT_CODE,t.C_MAT_CODE_BEFORE,t.C_MAT_DESC,t.C_MAT_DESC_BEFORE,t.C_IS_DEPOT,t.C_PLAN_ID,t.C_ORDER_NO,t.C_CON_NO,t.C_CUST_NO,t.C_CUST_NAME,t.C_ISFREE,t.C_LINEWH_CODE,t.C_LINEWH_AREA_CODE,t.C_LINEWH_LOC_CODE,t.C_FLOOR,t.C_CUST_AREA,t.C_SALE_AREA,t.C_JUDGE_LEV_CF,t.C_JUDGE_LEV_XN,t.C_JUDGE_LEV_XN_RE,t.C_JUDGE_LEV_ZH_PEOPLE,t.D_JUDGE_DATE,t.C_IS_QR,t.C_QR_USER,t.D_QR_DATE,t.C_DESIGN_NO,t.C_JUDGE_LEV_ZH,t.C_IS_TB,t.C_SCUTCHEON,t.C_GP_TYPE,t.C_BARCODE,t.C_RKDH,t.C_FYDH,t.C_CKDH,t.C_MOVE_DESC,t.C_CKRY,t.D_CKRQ,t.C_RKRY,t.D_RKRQ,t.C_BZYQ,t.D_WEIGHT_DT,t.D_PRODUCE_DATE,t.C_ZYX1,t.C_ZYX2,t.C_BZYQ ,(select max(t1.c_sta_desc) from tsc_slab_main t1 where t1.c_stove= t.c_stove )c_sta_desc FROM TRC_ROLL_PRODCUT t join tpb_linewh t2  on t.c_linewh_code = t2.c_linewh_code where t.C_MOVE_TYPE ='E' and t.c_linewh_code = '" + lenwhCode + "'   ");

            if (begin != null && end != null)
            {
                strSql.Append("and t.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and t.C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }

            strSql.Append(" order by C_BATCH_NO,to_number(nvl(c_tick_no,'0')) ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_KJ(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE ='E'");
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + C_BATCH_NO + "%' ");
            }
            strSql.Append(" order by C_BATCH_NO,to_number(nvl(c_tick_no,'0')) ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取线材实绩库存数
        /// </summary>
        /// <param name="C_LINEWH_CODE">仓库编码</param>
        /// <returns></returns>
        public DataSet Get_KC_COUNt(string C_LINEWH_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_LINEWH_LOC_CODE,count(1) as N_NUM FROM TRC_ROLL_PRODCUT t where t.C_MOVE_TYPE = 'E'   and C_LINEWH_CODE = '" + C_LINEWH_CODE + "' group by C_LINEWH_LOC_CODE ");

            return DbHelperOra.Query(strSql.ToString());

        }
        /// <summary>
        /// 根据idstr获取数据列表
        /// </summary>
        /// <param name="idstr"></param>
        /// <returns></returns>
        public DataSet GetListbyIDORDERBY(string idstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_BATCH_NO,C_JUDGE_LEV_ZH,C_STL_GRD,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,SUM(N_WGT) N_WGT,COUNT(1) N_NUM FROM TRC_ROLL_PRODCUT WHERE C_MOVE_TYPE ='E' ");
            if (idstr.Trim() != "")
            {
                strSql.Append(" and C_ID in(" + idstr + ")");
            }
            strSql.Append(" GROUP BY C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_BATCH_NO,C_JUDGE_LEV_ZH,C_STL_GRD,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据批号获取数据列表
        /// </summary>
        /// <param name="idstr"></param>
        /// <returns></returns>
        public DataSet GetQueryBatch(string batch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT t.c_design_no,T1.C_STA_DESC,T.C_MAT_CODE,T.C_MAT_DESC,T.C_BATCH_NO,T.C_STL_GRD,t.c_std_code,T.C_SPEC,T.C_STOVE,T.C_ZYX1,T.C_ZYX2, SUM(N_WGT) N_WGT, COUNT(1) N_NUM  FROM TRC_ROLL_PRODCUT T JOIN TB_STA T1 ON T.C_STA_ID=T1.C_ID WHERE 1=1");
            strSql.Append(" and t.C_BATCH_NO = '" + batch + "' ");
            strSql.Append(" GROUP BY t.c_design_no,T1.C_STA_DESC,T.C_MAT_CODE,T.C_MAT_DESC,T.C_BATCH_NO,T.C_STL_GRD,t.c_std_code,T.C_SPEC,T.C_STOVE,T.C_ZYX1,T.C_ZYX2 ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="ph">批号</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="ck">仓库</param>
        /// <param name="qy">区域</param>
        /// <param name="kw">库位</param>
        /// <returns></returns>
        public DataSet GetXCKList(string ph, string grd, string std, string ck, string qy, string kw, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2  ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE ='" + status + "' ");
            if (ph.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + ph + "%' ");
            }
            if (grd.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD like '%" + grd + "%' ");
            }
            if (std.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE_BEFORE like '%" + std + "%' ");
            }
            if (ck.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_CODE ='" + ck + "' ");
            }
            if (qy.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_AREA_CODE ='" + qy + "' ");
            }
            if (kw.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_LOC_CODE ='" + kw + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_ROLL_PRODCUT GetModelByBARCODE(string C_BARCODE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID  from TRC_ROLL_PRODCUT  ");
            strSql.Append(" where C_BARCODE=:C_BARCODE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BARCODE", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_BARCODE;

            Mod_TRC_ROLL_PRODCUT model = new Mod_TRC_ROLL_PRODCUT();
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
		/// 更新一条数据
		/// </summary>
		public bool Update_Trans(string strResult, string strUserID, Mod_TQC_COMPRE_ROLL model, string C_GP_AFTER_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT T SET T.C_JUDGE_LEV_ZH = '" + strResult + "', T.C_IS_QR = 'Y', T.C_QR_USER = '" + strUserID + "', T.D_QR_DATE = sysdate,t.C_GP_AFTER_ID='" + C_GP_AFTER_ID + "',T.C_IS_TB='Y',T.C_IS_PD='Y'  WHERE T.C_DESIGN_NO = '" + model.C_DESIGN_NO + "' AND T.C_STL_GRD = '" + model.C_STL_GRD + "' AND nvl(T.C_SPEC,'0') = nvl('" + model.C_SPEC + "','0') AND T.C_STD_CODE = '" + model.C_STD_CODE + "' AND T.C_MAT_CODE = '" + model.C_MAT_CODE + "' AND T.c_judge_lev_bp = '" + model.C_RESULT_FACE + "' AND NVL(T.C_REASON_NAME,'0') = NVL('" + model.C_REASON_NAME + "','0')   AND T.C_BATCH_NO = '" + model.C_BATCH_NO + "' ");


            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
        public bool Update(string strUserID, Mod_TQC_COMPRE_ROLL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT T SET T.C_JUDGE_LEV_ZH = '', T.C_IS_QR = 'N', T.C_QR_USER = '', T.D_QR_DATE = null WHERE T.C_DESIGN_NO = '" + model.C_DESIGN_NO + "' AND T.C_STL_GRD = '" + model.C_STL_GRD + "' AND nvl(T.C_SPEC,'0') = nvl('" + model.C_SPEC + "','0') AND T.C_STD_CODE = '" + model.C_STD_CODE + "' AND T.C_MAT_CODE = '" + model.C_MAT_CODE + "' AND T.c_judge_lev_bp = '" + model.C_RESULT_FACE + "' AND NVL(T.C_REASON_NAME,'0') = NVL('" + model.C_REASON_NAME + "','0')   AND T.C_BATCH_NO = '" + model.C_BATCH_NO + "' AND T.C_STOVE = '" + model.C_STOVE + "' ");


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
        /// 获得数据列表-已入库
        /// </summary> 
        /// <param name="C_LINEWH_LOC_CODE">库位</param> 
        /// <returns></returns>
        public DataSet GetList_KW_Group(string C_LINEWH_LOC_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.c_linewh_loc_code , sum(t.n_wgt)wgt,a.c_sta_desc,T.C_MAT_CODE,T.C_MAT_DESC,t.C_STA_ID,t.c_batch_no,t.C_STOVE,t.C_STL_GRD,t.C_STD_CODE,t.C_SPEC,t.C_SHIFT,t.C_GROUP,count(1) COU,max(t.D_DP_DT) DT   ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT T left JOIN  Tb_Sta a on t.c_sta_id=a.c_id where  t.C_MOVE_TYPE ='E'");

            if (C_LINEWH_LOC_CODE.Trim() != "")
            {
                strSql.Append(" and t.c_linewh_loc_code ='" + C_LINEWH_LOC_CODE + "' ");
            }
            strSql.Append(" group by t.c_linewh_loc_code ,t.C_STA_ID,t.c_batch_no,t.C_STOVE,t.C_STL_GRD,t.C_STD_CODE,t.C_SPEC,t.C_SHIFT,t.C_GROUP,T.C_MAT_CODE,T.C_MAT_DESC, a.c_sta_desc ");
            strSql.Append(" order by t.c_linewh_loc_code");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet Get_All_ByBatch_Trans(string C_BATCH_NO, string C_MASTER_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_JUDGE_LEV_ZH,SUM(T.N_WGT)AS N_WGT,COUNT(1)AS QUA,max(t.C_ORDER_NO)as C_ORDER_NO,max(t.C_LINEWH_CODE)as C_LINEWH_CODE,T.C_STD_CODE, T.C_MAT_CODE, T.C_ZYX1, T.C_ZYX2,C_GP_AFTER_ID FROM TRC_ROLL_PRODCUT T WHERE T.C_BATCH_NO='" + C_BATCH_NO + "' AND T.C_IS_QR='Y' and C_MASTER_ID='" + C_MASTER_ID + "' GROUP BY T.C_JUDGE_LEV_ZH, T.C_STD_CODE, T.C_MAT_CODE, T.C_ZYX1, T.C_ZYX2,C_GP_AFTER_ID ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet Get_List_ByGroup(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_STD_CODE, T.C_MAT_CODE,T.C_STL_GRD,T.C_SPEC, T.C_ZYX1, T.C_ZYX2,sum(t.n_wgt)as N_WGT,COUNT(1)AS QUA  FROM TRC_ROLL_PRODCUT T WHERE T.C_BATCH_NO = '" + C_BATCH_NO + "' GROUP BY T.C_STD_CODE, T.C_MAT_CODE, T.C_ZYX1, T.C_ZYX2,T.C_STL_GRD,T.C_SPEC ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update_Trans(string C_MASTER_ID, string C_GP_BEFORE_ID, string C_STD_CODE, string C_MAT_CODE, string C_ZYX1, string C_ZYX2, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT T SET T.C_MASTER_ID = '" + C_MASTER_ID + "',t.C_GP_BEFORE_ID='" + C_GP_BEFORE_ID + "'  WHERE T.C_STD_CODE = '" + C_STD_CODE + "' AND T.C_MAT_CODE = '" + C_MAT_CODE + "'  AND T.C_ZYX1 = '" + C_ZYX1 + "' AND T.C_ZYX2 = '" + C_ZYX2 + "' AND T.C_BATCH_NO = '" + C_BATCH_NO + "' ");


            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
		public bool Update_Wgt_Trans(string c_batch_no, string c_tick_no, string n_wgt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT T SET t.n_wgt='" + n_wgt + "' where t.c_batch_no='" + c_batch_no + "' and t.c_tick_no='" + c_tick_no + "' ");

            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet Get_Details(string C_BATCH_NO, string C_STD_CODE, string C_MAT_CODE, string C_STL_GRD, string C_STOVE, string C_JUDGE_LEV_BP, string C_REASON_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_PCINFO  from TRC_ROLL_PRODCUT t ");
            strSql.Append(" WHERE T.C_BATCH_NO = '" + C_BATCH_NO + "' and t.C_STD_CODE = '" + C_STD_CODE + "' and T.C_MAT_CODE = '" + C_MAT_CODE + "' and T.C_STL_GRD = '" + C_STL_GRD + "' and t.C_STOVE='" + C_STOVE + "' and t.C_JUDGE_LEV_BP='" + C_JUDGE_LEV_BP + "' AND NVL(T.C_REASON_NAME, '0') = NVL('" + C_REASON_NAME + "', '0') ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet Get_Details(string C_BATCH_NO, string C_STD_CODE, string C_MAT_CODE, string C_ZYX1, string C_ZYX2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_ID,C_EMP_ID,D_MOD_DT,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_STL_GRD_BEFORE,N_WGT,C_STD_CODE,C_STD_CODE_BEFORE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_STA_ID,C_JUDGE_LEV_BP,C_DP_SHIFT,C_DP_GROUP,C_DP_EMP_ID,D_DP_DT,C_PLANT_ID,C_PLANT_DESC,C_MAT_CODE,C_MAT_CODE_BEFORE,C_MAT_DESC,C_MAT_DESC_BEFORE,C_IS_DEPOT,C_PLAN_ID,C_ORDER_NO,C_CON_NO,C_CUST_NO,C_CUST_NAME,C_ISFREE,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_FLOOR,C_CUST_AREA,C_SALE_AREA,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_XN_RE,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,C_DESIGN_NO,C_JUDGE_LEV_ZH,C_IS_TB,C_SCUTCHEON,C_GP_TYPE,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_RKRY,D_RKRQ,C_BZYQ,D_WEIGHT_DT,D_PRODUCE_DATE,C_ZYX1,C_ZYX2,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_PCINFO  from TRC_ROLL_PRODCUT t ");
            strSql.Append(" WHERE T.C_BATCH_NO = '" + C_BATCH_NO + "' and t.C_STD_CODE = '" + C_STD_CODE + "' and T.C_MAT_CODE = '" + C_MAT_CODE + "' and T.C_ZYX1 = '" + C_ZYX1 + "' and T.C_ZYX2 = '" + C_ZYX2 + "' ");

            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取库存信息
        /// </summary>
        /// <param name="ph">批号</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="ck">仓库</param>
        /// <param name="qy">区域</param>
        /// <param name="kw">库位</param>
        /// <returns></returns>
        public DataSet GetXCKC(string ph, string grd, string std, string ck, string qy, string kw, string status, string C_QTCKD, string C_ZKD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select COUNT(1) N_NUM, COUNT(1) N_SNUM,C_BATCH_NO,C_STL_GRD,SUM(N_WGT) N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)AS C_JUDGE_LEV_ZH,C_BZYQ,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE ='" + status + "' ");
            if (ph.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + ph + "%' ");
            }
            if (grd.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD like '%" + grd + "%' ");
            }
            if (std.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE like '%" + std + "%' ");
            }
            if (ck.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_CODE ='" + ck + "' ");
            }
            if (qy.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_AREA_CODE ='" + qy + "' ");
            }
            if (kw.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_LOC_CODE ='" + kw + "' ");
            }
            if (C_QTCKD.Trim() != "")
            {
                strSql.Append(" and C_QTCKD_NO ='" + C_QTCKD + "' ");
            }
            if (C_ZKD.Trim() != "")
            {
                strSql.Append(" and C_ZKD_NO ='" + C_ZKD + "' ");
            }
            strSql.Append(" GROUP BY  C_BATCH_NO,C_STL_GRD,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP,C_BZYQ,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO ");
            strSql.Append(" ORDER BY  C_BATCH_NO,C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取PCI库存差异数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetTMM()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_BATCH_NO,C_BARCODE,C_LINEWH_CODE,C_LINEWH_LOC_CODE,C_MAT_CODE,C_MAT_DESC,C_JUDGE_LEV_ZH,C_REASON_NAME,C_STL_GRD,C_SPEC,C_TICK_NO,N_WGT,C_STD_CODE,C_MOVE_DESC,C_RKRY,C_ZYX1,C_ZYX2,C_BZYQ,C_GROUP,C_PLANT_ID,C_STOVE,C_MOVE_TYPE,C_DESIGN_NO,C_IS_QR,C_IS_TB,C_IS_PD,C_JUDGE_LEV_BP,C_LINEWH_AREA_CODE,C_SALE_AREA FROM TRC_ROLL_PRODCUT MINUS SELECT C_BATCH_NO, C_BARCODE,C_LINEWH_CODE,C_LINEWH_LOC_CODE,C_MAT_CODE,C_MAT_DESC,C_JUDGE_LEV_ZH,C_REASON_NAME,C_STL_GRD,C_SPEC,C_TICK_NO,  N_WGT,C_STD_CODE,C_MOVE_DESC,C_RKRY,C_ZYX1,C_ZYX2,C_BZYQ,C_GROUP,C_PLANT_ID,C_STOVE,C_MOVE_TYPE,C_DESIGN_NO,C_IS_QR,C_IS_TB,C_IS_PD,C_JUDGE_LEV_BP,C_LINEWH_AREA_CODE,C_SALE_AREA  FROM TRC_ROLL_PRODUCT_TM ");

            strSql.Append(" ORDER BY  C_BATCH_NO,C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取条码库存差异数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetPCIM()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_BATCH_NO,C_BARCODE,C_LINEWH_CODE,C_LINEWH_LOC_CODE,C_MAT_CODE,C_MAT_DESC,C_JUDGE_LEV_ZH,C_REASON_NAME,C_STL_GRD,C_SPEC,C_TICK_NO,N_WGT,C_STD_CODE,C_MOVE_DESC,C_RKRY,C_ZYX1,C_ZYX2,C_BZYQ,C_GROUP,C_PLANT_ID,C_STOVE,C_MOVE_TYPE,C_DESIGN_NO,C_IS_QR,C_IS_TB,C_IS_PD,C_JUDGE_LEV_BP,C_LINEWH_AREA_CODE,C_SALE_AREA FROM TRC_ROLL_PRODUCT_TM  MINUS SELECT C_BATCH_NO,C_BARCODE,C_LINEWH_CODE,C_LINEWH_LOC_CODE,C_MAT_CODE,C_MAT_DESC,C_JUDGE_LEV_ZH,C_REASON_NAME,C_STL_GRD,C_SPEC,C_TICK_NO,  N_WGT,C_STD_CODE,C_MOVE_DESC,C_RKRY,C_ZYX1,C_ZYX2,C_BZYQ,C_GROUP,C_PLANT_ID,C_STOVE,C_MOVE_TYPE,C_DESIGN_NO,C_IS_QR,C_IS_TB,C_IS_PD,C_JUDGE_LEV_BP,C_LINEWH_AREA_CODE,C_SALE_AREA  FROM TRC_ROLL_PRODCUT ");

            strSql.Append(" ORDER BY  C_BATCH_NO,C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_TB(string begin, string end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_BATCH_NO,T.C_MAT_CODE,T.C_MAT_DESC,T.C_STL_GRD,T.C_STD_CODE,max(T.D_PRODUCE_DATE)AS D_PRODUCE_DATE FROM TRC_ROLL_PRODCUT T  ");
            strSql.Append(" where 1=1 ");

            if (!string.IsNullOrEmpty(begin) && !string.IsNullOrEmpty(end))
            {
                strSql.Append(" and t.d_dp_dt between to_date('" + begin + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + end + "','yyyy-mm-dd hh24:mi:ss')");
            }

            if (!string.IsNullOrEmpty(C_BATCH_NO))
            {
                strSql.Append(" and T.C_BATCH_NO LIKE  '" + C_BATCH_NO + "%' ");
            }


            strSql.Append(" GROUP BY T.C_BATCH_NO,T.C_MAT_CODE,T.C_MAT_DESC,T.C_STL_GRD,T.C_STD_CODE  ORDER BY T.C_BATCH_NO ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Design(string c_design_no, String C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("update trc_roll_prodcut t set t.c_design_no = '" + c_design_no + "'   WHERE T.C_STD_CODE = '" + C_STD_CODE + "' AND T.C_STL_GRD = '" + C_STL_GRD + "' AND T.C_IS_QR = 'N' ");

            strSql.Append("update trc_roll_prodcut t set t.c_design_no = '" + c_design_no + "'   WHERE T.C_STD_CODE = '" + C_STD_CODE + "' AND T.C_STL_GRD = '" + C_STL_GRD + "' ");

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
        /// 更新一条数据
        /// </summary>
        public bool Update_Order_Design(string c_design_no, String C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tmo_order t set t.c_design_no='" + c_design_no + "' WHERE T.C_STD_CODE = '" + C_STD_CODE + "' AND T.C_STL_GRD = '" + C_STL_GRD + "' ");

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
        /// 根据实际填写的重量，更新线材支数的重量
        /// </summary>
        /// <param name="batchInfo">线材批次数据集合</param>
        /// <param name="amt">重量</param>
        /// <param name="num">支数</param>
        public void UpdateInventory(List<Mod_TRC_ROLL_PRODCUT> batchInfo, decimal amt, int num)
        {
            decimal zpAmt = amt;//zpInfo.ZpAmt;

            // 组批临时总量，用于计算剩余的组批量，摊到最后一只
            decimal zpTotal = 0;
            // 组批平均值
            decimal zpAvg = Math.Round(zpAmt / num, 4);

            // 剩余总量，用于计算剩余库存量
            decimal lastTotal = (batchInfo.Sum(w => w.N_WGT ?? 0) - zpAmt);
            decimal lastTmpTotal = 0;
            decimal lastAvg = 0;

            if (batchInfo.Count > num)
            {
                lastAvg = Math.Round(lastTotal / (batchInfo.Count - num), 4);
            }

            for (int i = 1; i <= batchInfo.Count; i++)
            {
                if (i == num)
                {
                    // 组批最后一只
                    batchInfo[i - 1].N_WGT = zpAmt - zpTotal;
                }
                else if (i > num)
                {
                    // 剩余的库存
                    if (i == batchInfo.Count)
                    {
                        batchInfo[i - 1].N_WGT = lastTotal - lastTmpTotal;
                    }
                    else
                    {
                        batchInfo[i - 1].N_WGT = lastAvg;
                        lastTmpTotal += lastAvg;
                    }
                }
                else
                {
                    // 组批的支数等于平均值
                    batchInfo[i - 1].N_WGT = zpAvg;
                    zpTotal += zpAvg;
                }

                // 更新线材库存量
                string updateSql = $"UPDATE TRC_ROLL_PRODCUT SET N_WGT = {batchInfo[i - 1].N_WGT} WHERE C_ID='{batchInfo[i - 1].C_ID}'";

                TransactionHelper.ExecuteSql(updateSql);

            }
        }
        Dal_TQC_COMPRE_ITEM_RESULT dalItemResult = new Dal_TQC_COMPRE_ITEM_RESULT();
        /// <summary>
        /// 修改批号
        /// </summary>
        /// <param name="lineCode">仓库编码</param>
        /// <param name="stlGrd">钢种</param>
        /// <param name="stdCode">执行标准</param>
        /// <param name="sepc">规格</param>
        /// <param name="batchNo">批号</param>
        /// <param name="mtrlCode">物料编码</param>
        /// <param name="zldj">综判等级</param>
        /// <param name="bzyq">包装要求</param>
        /// <param name="batchInfos">改判数据ID</param>
        public void UpdateBatchSameToNc(
            string lineCode,
            string stlGrd,
            string stdCode,
            string sepc,
            string batchNo,
            string mtrlCode,
            string zldj,
            string bzyq,
            List<string> batchInfos,
             List<string> liststrid)
        {
            // 验证NC线材批号与组批批号是否一致，如果不一致则要求先修改批号后再上传NC
            var ncDatas = GetNCInventory(
                lineCode,//zpInfo.InventoryCode,
                stlGrd,//order.C_STL_GRD,
                stdCode,//order.C_STD_CODE,
                sepc,//order.C_SPEC,
                batchNo//zpInfo.CBatchNo
                ).Where(w =>
                w.MtrlCode == mtrlCode &&//zpInfo.MtrlCode &&
                w.ZLDJ == zldj//zpInfo.ZLDJ
                ).Where(w => w.BZYQ == bzyq).ToList();

            // 如果nc不存在
            if (ncDatas.Any() == false)
            {
                throw new Exception("NC不存在组批线材批号");
            }
            // 如果与NC批号一致，不处理
            if (ncDatas.Exists(w => w.BatchNo == batchNo)) { return; }

            var newBatchNo = ncDatas.Select(w => w.BatchNo).FirstOrDefault();
            foreach (var item in liststrid)//修改复制成分批号
            {
                Mod_TQC_COMPRE_ITEM_RESULT mod = dalItemResult.GetModel(item);
                Mod_TQC_COMPRE_ITEM_RESULT modAdd = new Mod_TQC_COMPRE_ITEM_RESULT();
                modAdd.C_STOVE = mod.C_STOVE;
                modAdd.C_BATCH_NO = newBatchNo;
                modAdd.C_STL_GRD = mod.C_STL_GRD;
                modAdd.C_SPEC = mod.C_SPEC;
                modAdd.C_STD_CODE = mod.C_STD_CODE;
                modAdd.C_CHARACTER_ID = mod.C_CHARACTER_ID;
                modAdd.C_ITEM_NAME = mod.C_ITEM_NAME;
                modAdd.C_TARGET_MIN = mod.C_TARGET_MIN;
                modAdd.C_TARGET_INTERVAL = mod.C_TARGET_INTERVAL;
                modAdd.C_TARGET_MAX = mod.C_TARGET_MAX;
                modAdd.C_TYPE = mod.C_TYPE;
                modAdd.C_UNIT = mod.C_UNIT;
                modAdd.C_QUANTITATIVE = mod.C_QUANTITATIVE;
                modAdd.C_VALUE = mod.C_VALUE;
                modAdd.C_RESULT = mod.C_RESULT;
                modAdd.C_CHECK_STATE = mod.C_CHECK_STATE;
                modAdd.N_STATUS = mod.N_STATUS;
                modAdd.C_REMARK = mod.C_REMARK;
                modAdd.C_EMP_ID = mod.C_EMP_ID;
                modAdd.D_MOD_DT = mod.D_MOD_DT;
                modAdd.C_DESIGN_NO = mod.C_DESIGN_NO;
                modAdd.N_PRINT_ORDER = mod.N_PRINT_ORDER;
                modAdd.C_TICK_NO = mod.C_TICK_NO;
                modAdd.C_IS_SHOW = mod.C_IS_SHOW;
                modAdd.C_IS_DECIDE = mod.C_IS_DECIDE;
                modAdd.C_GROUP = mod.C_GROUP;
                modAdd.C_TB = mod.C_TB;
                modAdd.C_SOURCE = mod.C_SOURCE;
                dalItemResult.Add(modAdd);

            }
            // 更新线材批号
            foreach (var item in batchInfos)
            {
                // 更新线材批号
                string updateSql = $"UPDATE TRC_ROLL_PRODCUT SET C_BATCH_NO = '{newBatchNo}' WHERE C_ID='{item}'";
                DbHelperOra.ExecuteSql(updateSql);
            }
        }

        /// <summary>
        /// 获取NC库存数据
        /// </summary>
        /// <param name="lineWhCode"></param>
        /// <param name="gz"></param>
        /// <param name="zxbz"></param>
        /// <param name="gg"></param>
        /// <param name="searchBatchNo"></param>
        /// <returns></returns>
        public List<NCInventoryDto> GetNCInventory(
            string lineWhCode,
            string gz,
            string zxbz,
            string gg,
            string searchBatchNo)
        {

            if (string.IsNullOrEmpty(lineWhCode) &&
                string.IsNullOrEmpty(gz) &&
                string.IsNullOrEmpty(zxbz) &&
                string.IsNullOrEmpty(gg) &&
                string.IsNullOrEmpty(searchBatchNo))
            {
                return new List<NCInventoryDto>();
            }

            string pcisqlWhere = string.Empty;
            if (string.IsNullOrEmpty(lineWhCode) == false)
            {
                pcisqlWhere += $"AND t.c_linewh_code = '{lineWhCode}'";
            }

            string ncsqlWhere = string.Empty;
            if (string.IsNullOrEmpty(lineWhCode) == false)
            {
                ncsqlWhere += $"AND t.storcode = '{lineWhCode}'";
            }

            string sql = $@"
with pciInventory as
 (select t.c_batch_no,
         t.c_stl_grd,
         t.c_std_code,
         t.c_zyx1,
         t.c_zyx2,
         t.c_mat_code,
         t.c_mat_desc,
         t.c_bzyq,
         t.c_spec,
         t.c_judge_lev_zh,
         count(1) as count,
         sum(t.n_wgt) as sum,
         t.c_linewh_code,
         t.c_sale_area
    from trc_roll_prodcut t
   where 1=1 {pcisqlWhere}
   and t.c_move_type in ('E','QE')
   group by t.c_batch_no,
            t.c_stl_grd,
            t.c_std_code,
            t.c_zyx1,
            t.c_zyx2,
            t.c_mat_code,
            t.c_mat_desc,
            t.c_bzyq,
            t.c_judge_lev_zh,
            t.c_linewh_code,
            t.c_sale_area,
            t.c_spec
            )
--select *from pciInventory
        select t.批次号          as BatchNo,
               t.INVTYPE         as StlGrd,
               t.INVSPEC         as Spec,
               t.辅数量          as Count,
               t.数量            as Wgt,
               t.INVCODE         as MtrlCode,
               t.INVNAME         as MtrlName,
               t.STORCODE        as InventoryCode,
               t.VFREE3          as BZYQ,
               t.CCHECKSTATENAME as ZLDJ,
               t.VFREE1          as zyx1,
               t.VFREE2          as zyx2,
               tt.count          as pciCount,
               tt.sum            as pciSum,
               t.连铸炉号        as LuHao,
               tt.c_sale_area as SaleArea,
               t.*
          from XGERP50.V_ONHAND_wwjg@CAP_ERP t
          left join pciInventory tt
            on (tt.c_batch_no = t.批次号 )--or tt.c_batch_no like t.批次号 || '%')
           and tt.c_stl_grd = t.INVTYPE
           and tt.c_zyx1 = t.VFREE1
           and tt.c_zyx2 = t.VFREE2
           and tt.c_mat_code = t.INVCODE
           and tt.c_judge_lev_zh = t.CCHECKSTATENAME
           and tt.c_linewh_code = t.STORCODE
           and (tt.c_spec || 'mm' = t.INVSPEC OR tt.c_spec = t.INVSPEC )
         where 1=1 {ncsqlWhere}
--select count(1) from  XGERP50.V_ONHAND_wwjg@CAP_ERP t ;
";

            if (string.IsNullOrEmpty(gz) == false)
            {
                sql += $" AND t.INVTYPE = '{gz}'";
            }
            if (string.IsNullOrEmpty(gg) == false)
            {
                sql += $" AND t.INVSPEC like '%{gg}%'";
            }
            if (string.IsNullOrEmpty(searchBatchNo) == false)
            {
                sql += $" AND t.批次号 like '%{searchBatchNo}%'";
            }

            sql += " order by t.批次号, T.INVTYPE, T.INVSPEC";

            return DbHelperOra.Query(sql).Tables[0].DataTableToList2<NCInventoryDto>();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetList_WGD()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_STA_ID,TO_CHAR(T.D_PRODUCE_DATE, 'yyyy-mm-dd') AS RQ,T.C_BATCH_NO,T.C_STL_GRD,T.C_SPEC FROM TRC_ROLL_WGD T WHERE 1 = 1 ORDER BY T.C_STA_ID, T.C_BATCH_NO ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_Details(string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE, string C_JUDGE_LEV_BP, string C_JUDGE_LEV_ZH, string C_MAT_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_BATCH_NO AS 批号, T.C_TICK_NO AS 钩号, T.N_WGT AS 重量, T.C_STL_GRD AS 钢种, T.C_STD_CODE AS 执行标准, T.C_SPEC AS 规格, T.C_MAT_CODE AS 物料编码, T.C_MAT_DESC AS 物料名称  FROM TRC_ROLL_PRODCUT T WHERE T.C_MOVE_TYPE not in ('S') AND T.C_BATCH_NO = '" + C_BATCH_NO + "' AND T.C_STL_GRD = '" + C_STL_GRD + "' AND T.C_STD_CODE = '" + C_STD_CODE + "' AND T.C_JUDGE_LEV_BP = '" + C_JUDGE_LEV_BP + "' AND NVL(T.C_JUDGE_LEV_ZH, ' ') = NVL('" + C_JUDGE_LEV_ZH + "', ' ') AND T.C_MAT_CODE = '" + C_MAT_CODE + "' ORDER BY TO_NUMBER(T.C_TICK_NO) ");

            return DbHelperOra.Query(strSql.ToString());
        }

        public class NCInventoryDto
        {
            /// <summary>
            /// 根据自由项1，2获取执行标准
            /// </summary>
            /// <param name="zyx1"></param>
            /// <param name="zyx2"></param>
            /// <returns></returns>
            public static string GetZXBZ(string zyx1, string zyx2)
            {
                string bz = (zyx1.Split('~')[1].Contains("协议") ?
                        zyx2.Split('~')[1] : zyx1.Split('~')[1]).Replace(" ", "").Replace('（', '(').Replace('）', ')');//执行标准//
                return bz;
            }


            /// <summary>
            /// 批号
            /// </summary>
            public string BatchNo { get; set; }

            /// <summary>
            /// 钢种
            /// </summary>
            public string StlGrd { get; set; }

            /// <summary>
            /// 规格
            /// </summary>
            public string Spec { get; set; }

            /// <summary>
            /// 执行标准
            /// </summary>
            public string StdCode
            {
                get
                {
                    return GetZXBZ(zyx1, zyx2);
                }
            }

            /// <summary>
            /// NC总支数
            /// </summary>
            public int Count { get; set; }

            /// <summary>
            /// NC总重量
            /// </summary>
            public decimal Wgt { get; set; }

            /// <summary>
            /// PCI总支数
            /// </summary>
            public int PciCount { get; set; }

            /// <summary>
            /// PCI总重量
            /// </summary>
            public decimal PciSum { get; set; }

            /// <summary>
            /// 四舍五入重量
            /// </summary>
            public decimal PciWgt
            {
                get { return Math.Round(PciSum, 4); }
            }

            /// <summary>
            /// 物料编码
            /// </summary>
            public string MtrlCode { get; set; }

            /// <summary>
            /// 物料描述
            /// </summary>
            public string MtrlName { get; set; }

            /// <summary>
            /// 仓库编码
            /// </summary>
            public string InventoryCode { get; set; }

            /// <summary>
            /// 包装要求
            /// </summary>
            public string BZYQ { get; set; }

            /// <summary>
            /// 质量等级
            /// </summary>
            public string ZLDJ { get; set; }

            public string zyx1 { get; set; }
            public string zyx2 { get; set; }

            /// <summary>
            /// 炉号
            /// </summary>
            public string LuHao { get; set; }

            /// <summary>
            /// 销售区域
            /// </summary>
            public string SaleArea { get; set; }
        }


        /// <summary>
        /// 获取在线改判信息列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">标准</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <returns></returns>
        public DataSet Get_ZXGP_List(string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE, string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT T.C_BATCH_NO  AS 批号,
                            T.C_STOVE     AS 炉号,
                            TC.C_PLANT    AS 开坯号,
                            T.C_SX as 质量等级,
                            T.C_STL_GRD   AS 钢种,
                            T.C_STD_CODE  AS 标准,
                            T.C_SPEC      AS 规格,
                            TR.COU_SC     AS 支数,
                            TR.WGT_SC     AS 重量,
                            TB.C_JUDGE_LEV_BP AS 改判后等级,
                            TB.C_STL_GRD  AS 改判后钢种,
                            TB.C_STD_CODE AS 改判后标准,
                            TB.COU_GP     AS 改判支数,
                            TB.WGT_GP     AS 改判重量,
                            t.d_produce_date as 生产时间
                            FROM TRC_ROLL_WGD T
                            INNER JOIN TRC_ROLL_MAIN TC
                            ON T.C_MAIN_ID = TC.C_ID
                            INNER JOIN(SELECT TT.C_BATCH_NO,
                            SUM(TT.N_WGT) AS WGT_SC,
                            COUNT(1) AS COU_SC
                            FROM TRC_ROLL_PRODCUT TT
                            WHERE TT.C_QGP_STATE IS NULL
                            GROUP BY TT.C_BATCH_NO) TR
                            ON T.C_BATCH_NO = TR.C_BATCH_NO
                            INNER JOIN(SELECT TT.C_BATCH_NO,
                            TT.C_STL_GRD,
                            TT.C_STD_CODE,
                            TT.C_JUDGE_LEV_BP,
                            SUM(TT.N_WGT) AS WGT_GP,
                            COUNT(1) AS COU_GP
                            FROM TRC_ROLL_PRODCUT TT
                            WHERE TT.C_QGP_STATE IS NULL
                            GROUP BY TT.C_BATCH_NO, TT.C_STL_GRD, TT.C_STD_CODE,TT.C_JUDGE_LEV_BP) TB
                            ON T.C_BATCH_NO = TB.C_BATCH_NO
                            AND(T.C_STD_CODE <> TB.C_STD_CODE OR T.C_STL_GRD <> TB.C_STL_GRD)  ");

            strSql.Append(" where t.d_produce_date between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");

            if (!string.IsNullOrEmpty(C_BATCH_NO))
            {
                strSql.Append(" and T.C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }

            if (!string.IsNullOrEmpty(C_STL_GRD))
            {
                strSql.Append(" and T.C_STL_GRD like '" + C_STL_GRD + "%' ");
            }

            if (!string.IsNullOrEmpty(C_STD_CODE))
            {
                strSql.Append(" and T.C_STD_CODE like '" + C_STD_CODE + "%' ");
            }

            strSql.Append(" order by T.C_BATCH_NO ");

            return DbHelperOra.Query(strSql.ToString());
        }

    }

}
#endregion  ExtensionMethod
