using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
	/// <summary>
	/// 数据访问类:TSP_PLAN_SMS_LOG
	/// </summary>
	public partial class Dal_TSP_PLAN_SMS_LOG
	{
		public Dal_TSP_PLAN_SMS_LOG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TSP_PLAN_SMS_LOG");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TSP_PLAN_SMS_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TSP_PLAN_SMS_LOG(");
			strSql.Append("C_ID,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE1,C_FREE2,N_GROUP,C_FK,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_LF,C_KP,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,N_KP_SORT,N_XM_SORT,C_KP_ID,C_XM_ID,C_LOG_ID,C_LOG_REMARK,C_LOG_EMP,D_LOG_DT,C_LOG_IP)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_ORDER_NO,:C_DESIGN_NO,:N_SLAB_WGT,:C_CTRL_NO,:C_CCM_ID,:C_CCM_DESC,:C_PROD_NAME,:C_STL_GRD,:C_SPEC_CODE,:C_LENGTH,:C_MATRL_NO,:C_MATRL_NAME,:C_SLAB_SIZE,:C_SLAB_LENGTH,:C_STATE,:C_STD_CODE,:C_INITIALIZE_ITEM_ID,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:C_CAST_NO,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_CREAT_PLAN,:N_CREAT_ZG_PLAN,:N_PRODUCE_TIME,:C_ZL_ID,:C_LF_ID,:C_RH_ID,:C_LGJH,:C_QUA,:D_ARRIVE_ZG_TIME,:C_BY1,:C_BY2,:C_BY3,:C_RH,:C_DFP_HL,:C_HL,:C_XM,:D_DFPHL_START_TIME,:D_DFPHL_END_TIME,:D_KP_START_TIME,:D_KP_END_TIME,:D_HL_START_TIME,:D_HL_END_TIME,:D_PLAN_KY_TIME,:C_PLAN_ROLL,:D_ZZ_START_TIME,:D_ZZ_END_TIME,:D_XM_START_TIME,:D_XM_END_TIME,:C_STOVE_NO,:D_DFPHL_START_TIME_SJ,:D_DFPHL_END_TIME_SJ,:D_KP_START_TIME_SJ,:D_KP_END_TIME_SJ,:D_HL_START_TIME_SJ,:D_HL_END_TIME_SJ,:D_XM_START_TIME_SJ,:D_XM_END_TIME_SJ,:N_SJ_WGT,:D_START_TIME_SJ,:D_END_TIME_SJ,:N_DFP_HL_TIME,:N_HL_TIME,:C_ROUTE,:N_SLAB_PW,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:N_USE_WGT,:D_USE_START_TIME_SJ,:D_USE_END_TIME_SJ,:D_CAN_USE_TIME,:N_RH_NUM,:N_KP_WGT,:N_XM_WGT,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:C_STL_GRD_TYPE,:C_PROD_KIND,:C_TL,:N_JSCN,:C_FREE1,:C_FREE2,:N_GROUP,:C_FK,:N_ZJCLS,:N_ZJCLS_MIN,:N_ZJCLS_MAX,:C_SL,:C_WL,:C_SLAB_TYPE,:N_JC_SORT,:C_LF,:C_KP,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5,:N_KP_SORT,:N_XM_SORT,:C_KP_ID,:C_XM_ID,:C_LOG_ID,:C_LOG_REMARK,:C_LOG_EMP,:D_LOG_DT,:C_LOG_IP)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":N_SLAB_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":C_CTRL_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LENGTH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_LENGTH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
					new OracleParameter(":N_PROD_TIME", OracleDbType.Decimal,5),
					new OracleParameter(":N_SORT", OracleDbType.Decimal,20),
					new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_CREAT_PLAN", OracleDbType.Decimal,5),
					new OracleParameter(":N_CREAT_ZG_PLAN", OracleDbType.Decimal,5),
					new OracleParameter(":N_PRODUCE_TIME", OracleDbType.Decimal,5),
					new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":D_ARRIVE_ZG_TIME", OracleDbType.Date),
					new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
					new OracleParameter(":D_DFPHL_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_DFPHL_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_KP_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_KP_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_HL_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_HL_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_PLAN_KY_TIME", OracleDbType.Date),
					new OracleParameter(":C_PLAN_ROLL", OracleDbType.Varchar2,100),
					new OracleParameter(":D_ZZ_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_ZZ_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_XM_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_XM_END_TIME", OracleDbType.Date),
					new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":D_DFPHL_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_DFPHL_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_KP_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_KP_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_HL_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_HL_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_XM_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_XM_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":N_SJ_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
					new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
					new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
					new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
					new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
					new OracleParameter(":N_USE_WGT", OracleDbType.Decimal,5),
					new OracleParameter(":D_USE_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_USE_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_CAN_USE_TIME", OracleDbType.Date),
					new OracleParameter(":N_RH_NUM", OracleDbType.Decimal,5),
					new OracleParameter(":N_KP_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":N_XM_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
					new OracleParameter(":N_JSCN", OracleDbType.Decimal,5),
					new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
					new OracleParameter(":N_GROUP", OracleDbType.Decimal,5),
					new OracleParameter(":C_FK", OracleDbType.Varchar2,100),
					new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
					new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
					new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
					new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_JC_SORT", OracleDbType.Decimal,20),
					new OracleParameter(":C_LF", OracleDbType.Varchar2,10),
					new OracleParameter(":C_KP", OracleDbType.Varchar2,10),
					new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,100),
					new OracleParameter(":N_KP_SORT", OracleDbType.Decimal,20),
					new OracleParameter(":N_XM_SORT", OracleDbType.Decimal,20),
					new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_XM_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_LOG_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_LOG_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_LOG_EMP", OracleDbType.Varchar2,50),
					new OracleParameter(":D_LOG_DT", OracleDbType.Date),
					new OracleParameter(":C_LOG_IP", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_ORDER_NO;
			parameters[2].Value = model.C_DESIGN_NO;
			parameters[3].Value = model.N_SLAB_WGT;
			parameters[4].Value = model.C_CTRL_NO;
			parameters[5].Value = model.C_CCM_ID;
			parameters[6].Value = model.C_CCM_DESC;
			parameters[7].Value = model.C_PROD_NAME;
			parameters[8].Value = model.C_STL_GRD;
			parameters[9].Value = model.C_SPEC_CODE;
			parameters[10].Value = model.C_LENGTH;
			parameters[11].Value = model.C_MATRL_NO;
			parameters[12].Value = model.C_MATRL_NAME;
			parameters[13].Value = model.C_SLAB_SIZE;
			parameters[14].Value = model.C_SLAB_LENGTH;
			parameters[15].Value = model.C_STATE;
			parameters[16].Value = model.C_STD_CODE;
			parameters[17].Value = model.C_INITIALIZE_ITEM_ID;
			parameters[18].Value = model.D_P_START_TIME;
			parameters[19].Value = model.D_P_END_TIME;
			parameters[20].Value = model.N_PROD_TIME;
			parameters[21].Value = model.N_SORT;
			parameters[22].Value = model.C_CAST_NO;
			parameters[23].Value = model.N_STATUS;
			parameters[24].Value = model.C_EMP_ID;
			parameters[25].Value = model.D_MOD_DT;
			parameters[26].Value = model.C_REMARK;
			parameters[27].Value = model.N_CREAT_PLAN;
			parameters[28].Value = model.N_CREAT_ZG_PLAN;
			parameters[29].Value = model.N_PRODUCE_TIME;
			parameters[30].Value = model.C_ZL_ID;
			parameters[31].Value = model.C_LF_ID;
			parameters[32].Value = model.C_RH_ID;
			parameters[33].Value = model.C_LGJH;
			parameters[34].Value = model.C_QUA;
			parameters[35].Value = model.D_ARRIVE_ZG_TIME;
			parameters[36].Value = model.C_BY1;
			parameters[37].Value = model.C_BY2;
			parameters[38].Value = model.C_BY3;
			parameters[39].Value = model.C_RH;
			parameters[40].Value = model.C_DFP_HL;
			parameters[41].Value = model.C_HL;
			parameters[42].Value = model.C_XM;
			parameters[43].Value = model.D_DFPHL_START_TIME;
			parameters[44].Value = model.D_DFPHL_END_TIME;
			parameters[45].Value = model.D_KP_START_TIME;
			parameters[46].Value = model.D_KP_END_TIME;
			parameters[47].Value = model.D_HL_START_TIME;
			parameters[48].Value = model.D_HL_END_TIME;
			parameters[49].Value = model.D_PLAN_KY_TIME;
			parameters[50].Value = model.C_PLAN_ROLL;
			parameters[51].Value = model.D_ZZ_START_TIME;
			parameters[52].Value = model.D_ZZ_END_TIME;
			parameters[53].Value = model.D_XM_START_TIME;
			parameters[54].Value = model.D_XM_END_TIME;
			parameters[55].Value = model.C_STOVE_NO;
			parameters[56].Value = model.D_DFPHL_START_TIME_SJ;
			parameters[57].Value = model.D_DFPHL_END_TIME_SJ;
			parameters[58].Value = model.D_KP_START_TIME_SJ;
			parameters[59].Value = model.D_KP_END_TIME_SJ;
			parameters[60].Value = model.D_HL_START_TIME_SJ;
			parameters[61].Value = model.D_HL_END_TIME_SJ;
			parameters[62].Value = model.D_XM_START_TIME_SJ;
			parameters[63].Value = model.D_XM_END_TIME_SJ;
			parameters[64].Value = model.N_SJ_WGT;
			parameters[65].Value = model.D_START_TIME_SJ;
			parameters[66].Value = model.D_END_TIME_SJ;
			parameters[67].Value = model.N_DFP_HL_TIME;
			parameters[68].Value = model.N_HL_TIME;
			parameters[69].Value = model.C_ROUTE;
			parameters[70].Value = model.N_SLAB_PW;
			parameters[71].Value = model.C_MATRL_CODE_KP;
			parameters[72].Value = model.C_MATRL_NAME_KP;
			parameters[73].Value = model.C_KP_SIZE;
			parameters[74].Value = model.N_KP_LENGTH;
			parameters[75].Value = model.N_KP_PW;
			parameters[76].Value = model.N_USE_WGT;
			parameters[77].Value = model.D_USE_START_TIME_SJ;
			parameters[78].Value = model.D_USE_END_TIME_SJ;
			parameters[79].Value = model.D_CAN_USE_TIME;
			parameters[80].Value = model.N_RH_NUM;
			parameters[81].Value = model.N_KP_WGT;
			parameters[82].Value = model.N_XM_WGT;
			parameters[83].Value = model.C_DFP_RZ;
			parameters[84].Value = model.C_RZP_RZ;
			parameters[85].Value = model.C_DFP_YQ;
			parameters[86].Value = model.C_RZP_YQ;
			parameters[87].Value = model.C_STL_GRD_TYPE;
			parameters[88].Value = model.C_PROD_KIND;
			parameters[89].Value = model.C_TL;
			parameters[90].Value = model.N_JSCN;
			parameters[91].Value = model.C_FREE1;
			parameters[92].Value = model.C_FREE2;
			parameters[93].Value = model.N_GROUP;
			parameters[94].Value = model.C_FK;
			parameters[95].Value = model.N_ZJCLS;
			parameters[96].Value = model.N_ZJCLS_MIN;
			parameters[97].Value = model.N_ZJCLS_MAX;
			parameters[98].Value = model.C_SL;
			parameters[99].Value = model.C_WL;
			parameters[100].Value = model.C_SLAB_TYPE;
			parameters[101].Value = model.N_JC_SORT;
			parameters[102].Value = model.C_LF;
			parameters[103].Value = model.C_KP;
			parameters[104].Value = model.C_REMARK1;
			parameters[105].Value = model.C_REMARK2;
			parameters[106].Value = model.C_REMARK3;
			parameters[107].Value = model.C_REMARK4;
			parameters[108].Value = model.C_REMARK5;
			parameters[109].Value = model.N_KP_SORT;
			parameters[110].Value = model.N_XM_SORT;
			parameters[111].Value = model.C_KP_ID;
			parameters[112].Value = model.C_XM_ID;
			parameters[113].Value = model.C_LOG_ID;
			parameters[114].Value = model.C_LOG_REMARK;
			parameters[115].Value = model.C_LOG_EMP;
			parameters[116].Value = model.D_LOG_DT;
			parameters[117].Value = model.C_LOG_IP;

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
		public bool Update(Mod_TSP_PLAN_SMS_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TSP_PLAN_SMS_LOG set ");
			strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
			strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
			strSql.Append("N_SLAB_WGT=:N_SLAB_WGT,");
			strSql.Append("C_CTRL_NO=:C_CTRL_NO,");
			strSql.Append("C_CCM_ID=:C_CCM_ID,");
			strSql.Append("C_CCM_DESC=:C_CCM_DESC,");
			strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_SPEC_CODE=:C_SPEC_CODE,");
			strSql.Append("C_LENGTH=:C_LENGTH,");
			strSql.Append("C_MATRL_NO=:C_MATRL_NO,");
			strSql.Append("C_MATRL_NAME=:C_MATRL_NAME,");
			strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
			strSql.Append("C_SLAB_LENGTH=:C_SLAB_LENGTH,");
			strSql.Append("C_STATE=:C_STATE,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID,");
			strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
			strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
			strSql.Append("N_PROD_TIME=:N_PROD_TIME,");
			strSql.Append("N_SORT=:N_SORT,");
			strSql.Append("C_CAST_NO=:C_CAST_NO,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("N_CREAT_PLAN=:N_CREAT_PLAN,");
			strSql.Append("N_CREAT_ZG_PLAN=:N_CREAT_ZG_PLAN,");
			strSql.Append("N_PRODUCE_TIME=:N_PRODUCE_TIME,");
			strSql.Append("C_ZL_ID=:C_ZL_ID,");
			strSql.Append("C_LF_ID=:C_LF_ID,");
			strSql.Append("C_RH_ID=:C_RH_ID,");
			strSql.Append("C_LGJH=:C_LGJH,");
			strSql.Append("C_QUA=:C_QUA,");
			strSql.Append("D_ARRIVE_ZG_TIME=:D_ARRIVE_ZG_TIME,");
			strSql.Append("C_BY1=:C_BY1,");
			strSql.Append("C_BY2=:C_BY2,");
			strSql.Append("C_BY3=:C_BY3,");
			strSql.Append("C_RH=:C_RH,");
			strSql.Append("C_DFP_HL=:C_DFP_HL,");
			strSql.Append("C_HL=:C_HL,");
			strSql.Append("C_XM=:C_XM,");
			strSql.Append("D_DFPHL_START_TIME=:D_DFPHL_START_TIME,");
			strSql.Append("D_DFPHL_END_TIME=:D_DFPHL_END_TIME,");
			strSql.Append("D_KP_START_TIME=:D_KP_START_TIME,");
			strSql.Append("D_KP_END_TIME=:D_KP_END_TIME,");
			strSql.Append("D_HL_START_TIME=:D_HL_START_TIME,");
			strSql.Append("D_HL_END_TIME=:D_HL_END_TIME,");
			strSql.Append("D_PLAN_KY_TIME=:D_PLAN_KY_TIME,");
			strSql.Append("C_PLAN_ROLL=:C_PLAN_ROLL,");
			strSql.Append("D_ZZ_START_TIME=:D_ZZ_START_TIME,");
			strSql.Append("D_ZZ_END_TIME=:D_ZZ_END_TIME,");
			strSql.Append("D_XM_START_TIME=:D_XM_START_TIME,");
			strSql.Append("D_XM_END_TIME=:D_XM_END_TIME,");
			strSql.Append("C_STOVE_NO=:C_STOVE_NO,");
			strSql.Append("D_DFPHL_START_TIME_SJ=:D_DFPHL_START_TIME_SJ,");
			strSql.Append("D_DFPHL_END_TIME_SJ=:D_DFPHL_END_TIME_SJ,");
			strSql.Append("D_KP_START_TIME_SJ=:D_KP_START_TIME_SJ,");
			strSql.Append("D_KP_END_TIME_SJ=:D_KP_END_TIME_SJ,");
			strSql.Append("D_HL_START_TIME_SJ=:D_HL_START_TIME_SJ,");
			strSql.Append("D_HL_END_TIME_SJ=:D_HL_END_TIME_SJ,");
			strSql.Append("D_XM_START_TIME_SJ=:D_XM_START_TIME_SJ,");
			strSql.Append("D_XM_END_TIME_SJ=:D_XM_END_TIME_SJ,");
			strSql.Append("N_SJ_WGT=:N_SJ_WGT,");
			strSql.Append("D_START_TIME_SJ=:D_START_TIME_SJ,");
			strSql.Append("D_END_TIME_SJ=:D_END_TIME_SJ,");
			strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
			strSql.Append("N_HL_TIME=:N_HL_TIME,");
			strSql.Append("C_ROUTE=:C_ROUTE,");
			strSql.Append("N_SLAB_PW=:N_SLAB_PW,");
			strSql.Append("C_MATRL_CODE_KP=:C_MATRL_CODE_KP,");
			strSql.Append("C_MATRL_NAME_KP=:C_MATRL_NAME_KP,");
			strSql.Append("C_KP_SIZE=:C_KP_SIZE,");
			strSql.Append("N_KP_LENGTH=:N_KP_LENGTH,");
			strSql.Append("N_KP_PW=:N_KP_PW,");
			strSql.Append("N_USE_WGT=:N_USE_WGT,");
			strSql.Append("D_USE_START_TIME_SJ=:D_USE_START_TIME_SJ,");
			strSql.Append("D_USE_END_TIME_SJ=:D_USE_END_TIME_SJ,");
			strSql.Append("D_CAN_USE_TIME=:D_CAN_USE_TIME,");
			strSql.Append("N_RH_NUM=:N_RH_NUM,");
			strSql.Append("N_KP_WGT=:N_KP_WGT,");
			strSql.Append("N_XM_WGT=:N_XM_WGT,");
			strSql.Append("C_DFP_RZ=:C_DFP_RZ,");
			strSql.Append("C_RZP_RZ=:C_RZP_RZ,");
			strSql.Append("C_DFP_YQ=:C_DFP_YQ,");
			strSql.Append("C_RZP_YQ=:C_RZP_YQ,");
			strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
			strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
			strSql.Append("C_TL=:C_TL,");
			strSql.Append("N_JSCN=:N_JSCN,");
			strSql.Append("C_FREE1=:C_FREE1,");
			strSql.Append("C_FREE2=:C_FREE2,");
			strSql.Append("N_GROUP=:N_GROUP,");
			strSql.Append("C_FK=:C_FK,");
			strSql.Append("N_ZJCLS=:N_ZJCLS,");
			strSql.Append("N_ZJCLS_MIN=:N_ZJCLS_MIN,");
			strSql.Append("N_ZJCLS_MAX=:N_ZJCLS_MAX,");
			strSql.Append("C_SL=:C_SL,");
			strSql.Append("C_WL=:C_WL,");
			strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
			strSql.Append("N_JC_SORT=:N_JC_SORT,");
			strSql.Append("C_LF=:C_LF,");
			strSql.Append("C_KP=:C_KP,");
			strSql.Append("C_REMARK1=:C_REMARK1,");
			strSql.Append("C_REMARK2=:C_REMARK2,");
			strSql.Append("C_REMARK3=:C_REMARK3,");
			strSql.Append("C_REMARK4=:C_REMARK4,");
			strSql.Append("C_REMARK5=:C_REMARK5,");
			strSql.Append("N_KP_SORT=:N_KP_SORT,");
			strSql.Append("N_XM_SORT=:N_XM_SORT,");
			strSql.Append("C_KP_ID=:C_KP_ID,");
			strSql.Append("C_XM_ID=:C_XM_ID,");
			strSql.Append("C_LOG_ID=:C_LOG_ID,");
			strSql.Append("C_LOG_REMARK=:C_LOG_REMARK,");
			strSql.Append("C_LOG_EMP=:C_LOG_EMP,");
			strSql.Append("D_LOG_DT=:D_LOG_DT,");
			strSql.Append("C_LOG_IP=:C_LOG_IP");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":N_SLAB_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":C_CTRL_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LENGTH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_LENGTH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
					new OracleParameter(":N_PROD_TIME", OracleDbType.Decimal,5),
					new OracleParameter(":N_SORT", OracleDbType.Decimal,20),
					new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_CREAT_PLAN", OracleDbType.Decimal,5),
					new OracleParameter(":N_CREAT_ZG_PLAN", OracleDbType.Decimal,5),
					new OracleParameter(":N_PRODUCE_TIME", OracleDbType.Decimal,5),
					new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":D_ARRIVE_ZG_TIME", OracleDbType.Date),
					new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
					new OracleParameter(":D_DFPHL_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_DFPHL_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_KP_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_KP_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_HL_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_HL_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_PLAN_KY_TIME", OracleDbType.Date),
					new OracleParameter(":C_PLAN_ROLL", OracleDbType.Varchar2,100),
					new OracleParameter(":D_ZZ_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_ZZ_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_XM_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_XM_END_TIME", OracleDbType.Date),
					new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":D_DFPHL_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_DFPHL_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_KP_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_KP_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_HL_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_HL_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_XM_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_XM_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":N_SJ_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
					new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
					new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
					new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
					new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
					new OracleParameter(":N_USE_WGT", OracleDbType.Decimal,5),
					new OracleParameter(":D_USE_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_USE_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_CAN_USE_TIME", OracleDbType.Date),
					new OracleParameter(":N_RH_NUM", OracleDbType.Decimal,5),
					new OracleParameter(":N_KP_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":N_XM_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
					new OracleParameter(":N_JSCN", OracleDbType.Decimal,5),
					new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
					new OracleParameter(":N_GROUP", OracleDbType.Decimal,5),
					new OracleParameter(":C_FK", OracleDbType.Varchar2,100),
					new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
					new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
					new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
					new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_JC_SORT", OracleDbType.Decimal,20),
					new OracleParameter(":C_LF", OracleDbType.Varchar2,10),
					new OracleParameter(":C_KP", OracleDbType.Varchar2,10),
					new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,100),
					new OracleParameter(":N_KP_SORT", OracleDbType.Decimal,20),
					new OracleParameter(":N_XM_SORT", OracleDbType.Decimal,20),
					new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_XM_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_LOG_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_LOG_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_LOG_EMP", OracleDbType.Varchar2,50),
					new OracleParameter(":D_LOG_DT", OracleDbType.Date),
					new OracleParameter(":C_LOG_IP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ORDER_NO;
			parameters[1].Value = model.C_DESIGN_NO;
			parameters[2].Value = model.N_SLAB_WGT;
			parameters[3].Value = model.C_CTRL_NO;
			parameters[4].Value = model.C_CCM_ID;
			parameters[5].Value = model.C_CCM_DESC;
			parameters[6].Value = model.C_PROD_NAME;
			parameters[7].Value = model.C_STL_GRD;
			parameters[8].Value = model.C_SPEC_CODE;
			parameters[9].Value = model.C_LENGTH;
			parameters[10].Value = model.C_MATRL_NO;
			parameters[11].Value = model.C_MATRL_NAME;
			parameters[12].Value = model.C_SLAB_SIZE;
			parameters[13].Value = model.C_SLAB_LENGTH;
			parameters[14].Value = model.C_STATE;
			parameters[15].Value = model.C_STD_CODE;
			parameters[16].Value = model.C_INITIALIZE_ITEM_ID;
			parameters[17].Value = model.D_P_START_TIME;
			parameters[18].Value = model.D_P_END_TIME;
			parameters[19].Value = model.N_PROD_TIME;
			parameters[20].Value = model.N_SORT;
			parameters[21].Value = model.C_CAST_NO;
			parameters[22].Value = model.N_STATUS;
			parameters[23].Value = model.C_EMP_ID;
			parameters[24].Value = model.D_MOD_DT;
			parameters[25].Value = model.C_REMARK;
			parameters[26].Value = model.N_CREAT_PLAN;
			parameters[27].Value = model.N_CREAT_ZG_PLAN;
			parameters[28].Value = model.N_PRODUCE_TIME;
			parameters[29].Value = model.C_ZL_ID;
			parameters[30].Value = model.C_LF_ID;
			parameters[31].Value = model.C_RH_ID;
			parameters[32].Value = model.C_LGJH;
			parameters[33].Value = model.C_QUA;
			parameters[34].Value = model.D_ARRIVE_ZG_TIME;
			parameters[35].Value = model.C_BY1;
			parameters[36].Value = model.C_BY2;
			parameters[37].Value = model.C_BY3;
			parameters[38].Value = model.C_RH;
			parameters[39].Value = model.C_DFP_HL;
			parameters[40].Value = model.C_HL;
			parameters[41].Value = model.C_XM;
			parameters[42].Value = model.D_DFPHL_START_TIME;
			parameters[43].Value = model.D_DFPHL_END_TIME;
			parameters[44].Value = model.D_KP_START_TIME;
			parameters[45].Value = model.D_KP_END_TIME;
			parameters[46].Value = model.D_HL_START_TIME;
			parameters[47].Value = model.D_HL_END_TIME;
			parameters[48].Value = model.D_PLAN_KY_TIME;
			parameters[49].Value = model.C_PLAN_ROLL;
			parameters[50].Value = model.D_ZZ_START_TIME;
			parameters[51].Value = model.D_ZZ_END_TIME;
			parameters[52].Value = model.D_XM_START_TIME;
			parameters[53].Value = model.D_XM_END_TIME;
			parameters[54].Value = model.C_STOVE_NO;
			parameters[55].Value = model.D_DFPHL_START_TIME_SJ;
			parameters[56].Value = model.D_DFPHL_END_TIME_SJ;
			parameters[57].Value = model.D_KP_START_TIME_SJ;
			parameters[58].Value = model.D_KP_END_TIME_SJ;
			parameters[59].Value = model.D_HL_START_TIME_SJ;
			parameters[60].Value = model.D_HL_END_TIME_SJ;
			parameters[61].Value = model.D_XM_START_TIME_SJ;
			parameters[62].Value = model.D_XM_END_TIME_SJ;
			parameters[63].Value = model.N_SJ_WGT;
			parameters[64].Value = model.D_START_TIME_SJ;
			parameters[65].Value = model.D_END_TIME_SJ;
			parameters[66].Value = model.N_DFP_HL_TIME;
			parameters[67].Value = model.N_HL_TIME;
			parameters[68].Value = model.C_ROUTE;
			parameters[69].Value = model.N_SLAB_PW;
			parameters[70].Value = model.C_MATRL_CODE_KP;
			parameters[71].Value = model.C_MATRL_NAME_KP;
			parameters[72].Value = model.C_KP_SIZE;
			parameters[73].Value = model.N_KP_LENGTH;
			parameters[74].Value = model.N_KP_PW;
			parameters[75].Value = model.N_USE_WGT;
			parameters[76].Value = model.D_USE_START_TIME_SJ;
			parameters[77].Value = model.D_USE_END_TIME_SJ;
			parameters[78].Value = model.D_CAN_USE_TIME;
			parameters[79].Value = model.N_RH_NUM;
			parameters[80].Value = model.N_KP_WGT;
			parameters[81].Value = model.N_XM_WGT;
			parameters[82].Value = model.C_DFP_RZ;
			parameters[83].Value = model.C_RZP_RZ;
			parameters[84].Value = model.C_DFP_YQ;
			parameters[85].Value = model.C_RZP_YQ;
			parameters[86].Value = model.C_STL_GRD_TYPE;
			parameters[87].Value = model.C_PROD_KIND;
			parameters[88].Value = model.C_TL;
			parameters[89].Value = model.N_JSCN;
			parameters[90].Value = model.C_FREE1;
			parameters[91].Value = model.C_FREE2;
			parameters[92].Value = model.N_GROUP;
			parameters[93].Value = model.C_FK;
			parameters[94].Value = model.N_ZJCLS;
			parameters[95].Value = model.N_ZJCLS_MIN;
			parameters[96].Value = model.N_ZJCLS_MAX;
			parameters[97].Value = model.C_SL;
			parameters[98].Value = model.C_WL;
			parameters[99].Value = model.C_SLAB_TYPE;
			parameters[100].Value = model.N_JC_SORT;
			parameters[101].Value = model.C_LF;
			parameters[102].Value = model.C_KP;
			parameters[103].Value = model.C_REMARK1;
			parameters[104].Value = model.C_REMARK2;
			parameters[105].Value = model.C_REMARK3;
			parameters[106].Value = model.C_REMARK4;
			parameters[107].Value = model.C_REMARK5;
			parameters[108].Value = model.N_KP_SORT;
			parameters[109].Value = model.N_XM_SORT;
			parameters[110].Value = model.C_KP_ID;
			parameters[111].Value = model.C_XM_ID;
			parameters[112].Value = model.C_LOG_ID;
			parameters[113].Value = model.C_LOG_REMARK;
			parameters[114].Value = model.C_LOG_EMP;
			parameters[115].Value = model.D_LOG_DT;
			parameters[116].Value = model.C_LOG_IP;
			parameters[117].Value = model.C_ID;

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
			strSql.Append("delete from TSP_PLAN_SMS_LOG ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
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
			strSql.Append("delete from TSP_PLAN_SMS_LOG ");
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
		public Mod_TSP_PLAN_SMS_LOG GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE1,C_FREE2,N_GROUP,C_FK,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_LF,C_KP,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,N_KP_SORT,N_XM_SORT,C_KP_ID,C_XM_ID,C_LOG_ID,C_LOG_REMARK,C_LOG_EMP,D_LOG_DT,C_LOG_IP from TSP_PLAN_SMS_LOG ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TSP_PLAN_SMS_LOG model=new Mod_TSP_PLAN_SMS_LOG();
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
		public Mod_TSP_PLAN_SMS_LOG DataRowToModel(DataRow row)
		{
			Mod_TSP_PLAN_SMS_LOG model=new Mod_TSP_PLAN_SMS_LOG();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_ORDER_NO"]!=null)
				{
					model.C_ORDER_NO=row["C_ORDER_NO"].ToString();
				}
				if(row["C_DESIGN_NO"]!=null)
				{
					model.C_DESIGN_NO=row["C_DESIGN_NO"].ToString();
				}
				if(row["N_SLAB_WGT"]!=null && row["N_SLAB_WGT"].ToString()!="")
				{
					model.N_SLAB_WGT=decimal.Parse(row["N_SLAB_WGT"].ToString());
				}
				if(row["C_CTRL_NO"]!=null)
				{
					model.C_CTRL_NO=row["C_CTRL_NO"].ToString();
				}
				if(row["C_CCM_ID"]!=null)
				{
					model.C_CCM_ID=row["C_CCM_ID"].ToString();
				}
				if(row["C_CCM_DESC"]!=null)
				{
					model.C_CCM_DESC=row["C_CCM_DESC"].ToString();
				}
				if(row["C_PROD_NAME"]!=null)
				{
					model.C_PROD_NAME=row["C_PROD_NAME"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_SPEC_CODE"]!=null)
				{
					model.C_SPEC_CODE=row["C_SPEC_CODE"].ToString();
				}
				if(row["C_LENGTH"]!=null)
				{
					model.C_LENGTH=row["C_LENGTH"].ToString();
				}
				if(row["C_MATRL_NO"]!=null)
				{
					model.C_MATRL_NO=row["C_MATRL_NO"].ToString();
				}
				if(row["C_MATRL_NAME"]!=null)
				{
					model.C_MATRL_NAME=row["C_MATRL_NAME"].ToString();
				}
				if(row["C_SLAB_SIZE"]!=null)
				{
					model.C_SLAB_SIZE=row["C_SLAB_SIZE"].ToString();
				}
				if(row["C_SLAB_LENGTH"]!=null)
				{
					model.C_SLAB_LENGTH=row["C_SLAB_LENGTH"].ToString();
				}
				if(row["C_STATE"]!=null)
				{
					model.C_STATE=row["C_STATE"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_INITIALIZE_ITEM_ID"]!=null)
				{
					model.C_INITIALIZE_ITEM_ID=row["C_INITIALIZE_ITEM_ID"].ToString();
				}
				if(row["D_P_START_TIME"]!=null && row["D_P_START_TIME"].ToString()!="")
				{
					model.D_P_START_TIME=DateTime.Parse(row["D_P_START_TIME"].ToString());
				}
				if(row["D_P_END_TIME"]!=null && row["D_P_END_TIME"].ToString()!="")
				{
					model.D_P_END_TIME=DateTime.Parse(row["D_P_END_TIME"].ToString());
				}
				if(row["N_PROD_TIME"]!=null && row["N_PROD_TIME"].ToString()!="")
				{
					model.N_PROD_TIME=decimal.Parse(row["N_PROD_TIME"].ToString());
				}
				if(row["N_SORT"]!=null && row["N_SORT"].ToString()!="")
				{
					model.N_SORT=decimal.Parse(row["N_SORT"].ToString());
				}
				if(row["C_CAST_NO"]!=null)
				{
					model.C_CAST_NO=row["C_CAST_NO"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["C_EMP_ID"]!=null)
				{
					model.C_EMP_ID=row["C_EMP_ID"].ToString();
				}
				if(row["D_MOD_DT"]!=null && row["D_MOD_DT"].ToString()!="")
				{
					model.D_MOD_DT=DateTime.Parse(row["D_MOD_DT"].ToString());
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["N_CREAT_PLAN"]!=null && row["N_CREAT_PLAN"].ToString()!="")
				{
					model.N_CREAT_PLAN=decimal.Parse(row["N_CREAT_PLAN"].ToString());
				}
				if(row["N_CREAT_ZG_PLAN"]!=null && row["N_CREAT_ZG_PLAN"].ToString()!="")
				{
					model.N_CREAT_ZG_PLAN=decimal.Parse(row["N_CREAT_ZG_PLAN"].ToString());
				}
				if(row["N_PRODUCE_TIME"]!=null && row["N_PRODUCE_TIME"].ToString()!="")
				{
					model.N_PRODUCE_TIME=decimal.Parse(row["N_PRODUCE_TIME"].ToString());
				}
				if(row["C_ZL_ID"]!=null)
				{
					model.C_ZL_ID=row["C_ZL_ID"].ToString();
				}
				if(row["C_LF_ID"]!=null)
				{
					model.C_LF_ID=row["C_LF_ID"].ToString();
				}
				if(row["C_RH_ID"]!=null)
				{
					model.C_RH_ID=row["C_RH_ID"].ToString();
				}
				if(row["C_LGJH"]!=null)
				{
					model.C_LGJH=row["C_LGJH"].ToString();
				}
				if(row["C_QUA"]!=null)
				{
					model.C_QUA=row["C_QUA"].ToString();
				}
				if(row["D_ARRIVE_ZG_TIME"]!=null && row["D_ARRIVE_ZG_TIME"].ToString()!="")
				{
					model.D_ARRIVE_ZG_TIME=DateTime.Parse(row["D_ARRIVE_ZG_TIME"].ToString());
				}
				if(row["C_BY1"]!=null)
				{
					model.C_BY1=row["C_BY1"].ToString();
				}
				if(row["C_BY2"]!=null)
				{
					model.C_BY2=row["C_BY2"].ToString();
				}
				if(row["C_BY3"]!=null)
				{
					model.C_BY3=row["C_BY3"].ToString();
				}
				if(row["C_RH"]!=null)
				{
					model.C_RH=row["C_RH"].ToString();
				}
				if(row["C_DFP_HL"]!=null)
				{
					model.C_DFP_HL=row["C_DFP_HL"].ToString();
				}
				if(row["C_HL"]!=null)
				{
					model.C_HL=row["C_HL"].ToString();
				}
				if(row["C_XM"]!=null)
				{
					model.C_XM=row["C_XM"].ToString();
				}
				if(row["D_DFPHL_START_TIME"]!=null && row["D_DFPHL_START_TIME"].ToString()!="")
				{
					model.D_DFPHL_START_TIME=DateTime.Parse(row["D_DFPHL_START_TIME"].ToString());
				}
				if(row["D_DFPHL_END_TIME"]!=null && row["D_DFPHL_END_TIME"].ToString()!="")
				{
					model.D_DFPHL_END_TIME=DateTime.Parse(row["D_DFPHL_END_TIME"].ToString());
				}
				if(row["D_KP_START_TIME"]!=null && row["D_KP_START_TIME"].ToString()!="")
				{
					model.D_KP_START_TIME=DateTime.Parse(row["D_KP_START_TIME"].ToString());
				}
				if(row["D_KP_END_TIME"]!=null && row["D_KP_END_TIME"].ToString()!="")
				{
					model.D_KP_END_TIME=DateTime.Parse(row["D_KP_END_TIME"].ToString());
				}
				if(row["D_HL_START_TIME"]!=null && row["D_HL_START_TIME"].ToString()!="")
				{
					model.D_HL_START_TIME=DateTime.Parse(row["D_HL_START_TIME"].ToString());
				}
				if(row["D_HL_END_TIME"]!=null && row["D_HL_END_TIME"].ToString()!="")
				{
					model.D_HL_END_TIME=DateTime.Parse(row["D_HL_END_TIME"].ToString());
				}
				if(row["D_PLAN_KY_TIME"]!=null && row["D_PLAN_KY_TIME"].ToString()!="")
				{
					model.D_PLAN_KY_TIME=DateTime.Parse(row["D_PLAN_KY_TIME"].ToString());
				}
				if(row["C_PLAN_ROLL"]!=null)
				{
					model.C_PLAN_ROLL=row["C_PLAN_ROLL"].ToString();
				}
				if(row["D_ZZ_START_TIME"]!=null && row["D_ZZ_START_TIME"].ToString()!="")
				{
					model.D_ZZ_START_TIME=DateTime.Parse(row["D_ZZ_START_TIME"].ToString());
				}
				if(row["D_ZZ_END_TIME"]!=null && row["D_ZZ_END_TIME"].ToString()!="")
				{
					model.D_ZZ_END_TIME=DateTime.Parse(row["D_ZZ_END_TIME"].ToString());
				}
				if(row["D_XM_START_TIME"]!=null && row["D_XM_START_TIME"].ToString()!="")
				{
					model.D_XM_START_TIME=DateTime.Parse(row["D_XM_START_TIME"].ToString());
				}
				if(row["D_XM_END_TIME"]!=null && row["D_XM_END_TIME"].ToString()!="")
				{
					model.D_XM_END_TIME=DateTime.Parse(row["D_XM_END_TIME"].ToString());
				}
				if(row["C_STOVE_NO"]!=null)
				{
					model.C_STOVE_NO=row["C_STOVE_NO"].ToString();
				}
				if(row["D_DFPHL_START_TIME_SJ"]!=null && row["D_DFPHL_START_TIME_SJ"].ToString()!="")
				{
					model.D_DFPHL_START_TIME_SJ=DateTime.Parse(row["D_DFPHL_START_TIME_SJ"].ToString());
				}
				if(row["D_DFPHL_END_TIME_SJ"]!=null && row["D_DFPHL_END_TIME_SJ"].ToString()!="")
				{
					model.D_DFPHL_END_TIME_SJ=DateTime.Parse(row["D_DFPHL_END_TIME_SJ"].ToString());
				}
				if(row["D_KP_START_TIME_SJ"]!=null && row["D_KP_START_TIME_SJ"].ToString()!="")
				{
					model.D_KP_START_TIME_SJ=DateTime.Parse(row["D_KP_START_TIME_SJ"].ToString());
				}
				if(row["D_KP_END_TIME_SJ"]!=null && row["D_KP_END_TIME_SJ"].ToString()!="")
				{
					model.D_KP_END_TIME_SJ=DateTime.Parse(row["D_KP_END_TIME_SJ"].ToString());
				}
				if(row["D_HL_START_TIME_SJ"]!=null && row["D_HL_START_TIME_SJ"].ToString()!="")
				{
					model.D_HL_START_TIME_SJ=DateTime.Parse(row["D_HL_START_TIME_SJ"].ToString());
				}
				if(row["D_HL_END_TIME_SJ"]!=null && row["D_HL_END_TIME_SJ"].ToString()!="")
				{
					model.D_HL_END_TIME_SJ=DateTime.Parse(row["D_HL_END_TIME_SJ"].ToString());
				}
				if(row["D_XM_START_TIME_SJ"]!=null && row["D_XM_START_TIME_SJ"].ToString()!="")
				{
					model.D_XM_START_TIME_SJ=DateTime.Parse(row["D_XM_START_TIME_SJ"].ToString());
				}
				if(row["D_XM_END_TIME_SJ"]!=null && row["D_XM_END_TIME_SJ"].ToString()!="")
				{
					model.D_XM_END_TIME_SJ=DateTime.Parse(row["D_XM_END_TIME_SJ"].ToString());
				}
				if(row["N_SJ_WGT"]!=null && row["N_SJ_WGT"].ToString()!="")
				{
					model.N_SJ_WGT=decimal.Parse(row["N_SJ_WGT"].ToString());
				}
				if(row["D_START_TIME_SJ"]!=null && row["D_START_TIME_SJ"].ToString()!="")
				{
					model.D_START_TIME_SJ=DateTime.Parse(row["D_START_TIME_SJ"].ToString());
				}
				if(row["D_END_TIME_SJ"]!=null && row["D_END_TIME_SJ"].ToString()!="")
				{
					model.D_END_TIME_SJ=DateTime.Parse(row["D_END_TIME_SJ"].ToString());
				}
				if(row["N_DFP_HL_TIME"]!=null && row["N_DFP_HL_TIME"].ToString()!="")
				{
					model.N_DFP_HL_TIME=decimal.Parse(row["N_DFP_HL_TIME"].ToString());
				}
				if(row["N_HL_TIME"]!=null && row["N_HL_TIME"].ToString()!="")
				{
					model.N_HL_TIME=decimal.Parse(row["N_HL_TIME"].ToString());
				}
				if(row["C_ROUTE"]!=null)
				{
					model.C_ROUTE=row["C_ROUTE"].ToString();
				}
				if(row["N_SLAB_PW"]!=null && row["N_SLAB_PW"].ToString()!="")
				{
					model.N_SLAB_PW=decimal.Parse(row["N_SLAB_PW"].ToString());
				}
				if(row["C_MATRL_CODE_KP"]!=null)
				{
					model.C_MATRL_CODE_KP=row["C_MATRL_CODE_KP"].ToString();
				}
				if(row["C_MATRL_NAME_KP"]!=null)
				{
					model.C_MATRL_NAME_KP=row["C_MATRL_NAME_KP"].ToString();
				}
				if(row["C_KP_SIZE"]!=null)
				{
					model.C_KP_SIZE=row["C_KP_SIZE"].ToString();
				}
				if(row["N_KP_LENGTH"]!=null && row["N_KP_LENGTH"].ToString()!="")
				{
					model.N_KP_LENGTH=decimal.Parse(row["N_KP_LENGTH"].ToString());
				}
				if(row["N_KP_PW"]!=null && row["N_KP_PW"].ToString()!="")
				{
					model.N_KP_PW=decimal.Parse(row["N_KP_PW"].ToString());
				}
				if(row["N_USE_WGT"]!=null && row["N_USE_WGT"].ToString()!="")
				{
					model.N_USE_WGT=decimal.Parse(row["N_USE_WGT"].ToString());
				}
				if(row["D_USE_START_TIME_SJ"]!=null && row["D_USE_START_TIME_SJ"].ToString()!="")
				{
					model.D_USE_START_TIME_SJ=DateTime.Parse(row["D_USE_START_TIME_SJ"].ToString());
				}
				if(row["D_USE_END_TIME_SJ"]!=null && row["D_USE_END_TIME_SJ"].ToString()!="")
				{
					model.D_USE_END_TIME_SJ=DateTime.Parse(row["D_USE_END_TIME_SJ"].ToString());
				}
				if(row["D_CAN_USE_TIME"]!=null && row["D_CAN_USE_TIME"].ToString()!="")
				{
					model.D_CAN_USE_TIME=DateTime.Parse(row["D_CAN_USE_TIME"].ToString());
				}
				if(row["N_RH_NUM"]!=null && row["N_RH_NUM"].ToString()!="")
				{
					model.N_RH_NUM=decimal.Parse(row["N_RH_NUM"].ToString());
				}
				if(row["N_KP_WGT"]!=null && row["N_KP_WGT"].ToString()!="")
				{
					model.N_KP_WGT=decimal.Parse(row["N_KP_WGT"].ToString());
				}
				if(row["N_XM_WGT"]!=null && row["N_XM_WGT"].ToString()!="")
				{
					model.N_XM_WGT=decimal.Parse(row["N_XM_WGT"].ToString());
				}
				if(row["C_DFP_RZ"]!=null)
				{
					model.C_DFP_RZ=row["C_DFP_RZ"].ToString();
				}
				if(row["C_RZP_RZ"]!=null)
				{
					model.C_RZP_RZ=row["C_RZP_RZ"].ToString();
				}
				if(row["C_DFP_YQ"]!=null)
				{
					model.C_DFP_YQ=row["C_DFP_YQ"].ToString();
				}
				if(row["C_RZP_YQ"]!=null)
				{
					model.C_RZP_YQ=row["C_RZP_YQ"].ToString();
				}
				if(row["C_STL_GRD_TYPE"]!=null)
				{
					model.C_STL_GRD_TYPE=row["C_STL_GRD_TYPE"].ToString();
				}
				if(row["C_PROD_KIND"]!=null)
				{
					model.C_PROD_KIND=row["C_PROD_KIND"].ToString();
				}
				if(row["C_TL"]!=null)
				{
					model.C_TL=row["C_TL"].ToString();
				}
				if(row["N_JSCN"]!=null && row["N_JSCN"].ToString()!="")
				{
					model.N_JSCN=decimal.Parse(row["N_JSCN"].ToString());
				}
				if(row["C_FREE1"]!=null)
				{
					model.C_FREE1=row["C_FREE1"].ToString();
				}
				if(row["C_FREE2"]!=null)
				{
					model.C_FREE2=row["C_FREE2"].ToString();
				}
				if(row["N_GROUP"]!=null && row["N_GROUP"].ToString()!="")
				{
					model.N_GROUP=decimal.Parse(row["N_GROUP"].ToString());
				}
				if(row["C_FK"]!=null)
				{
					model.C_FK=row["C_FK"].ToString();
				}
				if(row["N_ZJCLS"]!=null && row["N_ZJCLS"].ToString()!="")
				{
					model.N_ZJCLS=decimal.Parse(row["N_ZJCLS"].ToString());
				}
				if(row["N_ZJCLS_MIN"]!=null && row["N_ZJCLS_MIN"].ToString()!="")
				{
					model.N_ZJCLS_MIN=decimal.Parse(row["N_ZJCLS_MIN"].ToString());
				}
				if(row["N_ZJCLS_MAX"]!=null && row["N_ZJCLS_MAX"].ToString()!="")
				{
					model.N_ZJCLS_MAX=decimal.Parse(row["N_ZJCLS_MAX"].ToString());
				}
				if(row["C_SL"]!=null)
				{
					model.C_SL=row["C_SL"].ToString();
				}
				if(row["C_WL"]!=null)
				{
					model.C_WL=row["C_WL"].ToString();
				}
				if(row["C_SLAB_TYPE"]!=null)
				{
					model.C_SLAB_TYPE=row["C_SLAB_TYPE"].ToString();
				}
				if(row["N_JC_SORT"]!=null && row["N_JC_SORT"].ToString()!="")
				{
					model.N_JC_SORT=decimal.Parse(row["N_JC_SORT"].ToString());
				}
				if(row["C_LF"]!=null)
				{
					model.C_LF=row["C_LF"].ToString();
				}
				if(row["C_KP"]!=null)
				{
					model.C_KP=row["C_KP"].ToString();
				}
				if(row["C_REMARK1"]!=null)
				{
					model.C_REMARK1=row["C_REMARK1"].ToString();
				}
				if(row["C_REMARK2"]!=null)
				{
					model.C_REMARK2=row["C_REMARK2"].ToString();
				}
				if(row["C_REMARK3"]!=null)
				{
					model.C_REMARK3=row["C_REMARK3"].ToString();
				}
				if(row["C_REMARK4"]!=null)
				{
					model.C_REMARK4=row["C_REMARK4"].ToString();
				}
				if(row["C_REMARK5"]!=null)
				{
					model.C_REMARK5=row["C_REMARK5"].ToString();
				}
				if(row["N_KP_SORT"]!=null && row["N_KP_SORT"].ToString()!="")
				{
					model.N_KP_SORT=decimal.Parse(row["N_KP_SORT"].ToString());
				}
				if(row["N_XM_SORT"]!=null && row["N_XM_SORT"].ToString()!="")
				{
					model.N_XM_SORT=decimal.Parse(row["N_XM_SORT"].ToString());
				}
				if(row["C_KP_ID"]!=null)
				{
					model.C_KP_ID=row["C_KP_ID"].ToString();
				}
				if(row["C_XM_ID"]!=null)
				{
					model.C_XM_ID=row["C_XM_ID"].ToString();
				}
				if(row["C_LOG_ID"]!=null)
				{
					model.C_LOG_ID=row["C_LOG_ID"].ToString();
				}
				if(row["C_LOG_REMARK"]!=null)
				{
					model.C_LOG_REMARK=row["C_LOG_REMARK"].ToString();
				}
				if(row["C_LOG_EMP"]!=null)
				{
					model.C_LOG_EMP=row["C_LOG_EMP"].ToString();
				}
				if(row["D_LOG_DT"]!=null && row["D_LOG_DT"].ToString()!="")
				{
					model.D_LOG_DT=DateTime.Parse(row["D_LOG_DT"].ToString());
				}
				if(row["C_LOG_IP"]!=null)
				{
					model.C_LOG_IP=row["C_LOG_IP"].ToString();
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
			strSql.Append("select C_ID,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE1,C_FREE2,N_GROUP,C_FK,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_LF,C_KP,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,N_KP_SORT,N_XM_SORT,C_KP_ID,C_XM_ID,C_LOG_ID,C_LOG_REMARK,C_LOG_EMP,D_LOG_DT,C_LOG_IP ");
			strSql.Append(" FROM TSP_PLAN_SMS_LOG ");
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
			strSql.Append("select count(1) FROM TSP_PLAN_SMS_LOG ");
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
			strSql.Append(")AS Row, T.*  from TSP_PLAN_SMS_LOG T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleDbType.Varchar2, 255),
					new OracleParameter(":fldName", OracleDbType.Varchar2, 255),
					new OracleParameter(":PageSize", OracleDbType.Decimal),
					new OracleParameter(":PageIndex", OracleDbType.Decimal),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TSP_PLAN_SMS_LOG";
			parameters[1].Value = "C_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

