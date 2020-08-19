using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TSC_SLAB_NC
	/// </summary>
	public partial class Dal_TSC_SLAB_NC
    {
		public Dal_TSC_SLAB_NC()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TSC_SLAB_NC");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TSC_SLAB_NC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TSC_SLAB_NC(");
			strSql.Append("C_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,C_IS_TB,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,D_STACK_DATE,C_STACK_USER,C_STACK_SHIFT,C_STACK_GROUP,C_IS_PD,C_REASON_NAME,C_FYDH,C_SLAB_STATUS,C_ZKDH,C_ZKDHID,C_LGJH,C_MES_FLOOR,N_JZ,C_HL,N_HL_TIME,C_HLYQ,C_DFP_HL,N_DFP_HL_TIME,C_ROUTE,C_ZYX1,C_ZYX2)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_PLAN_ID,:C_BATCH_NO,:C_ORD_NO,:C_STOVE,:C_STA_ID,:C_STA_CODE,:C_STA_DESC,:C_STL_GRD,:C_STL_GRD_PRE,:C_MAT_CODE,:C_MAT_NAME,:C_SPEC,:N_LEN,:N_QUA,:N_WGT,:C_STD_CODE,:C_SLAB_TYPE,:D_CCM_DATE,:C_CCM_SHIFT,:C_CCM_GROUP,:C_CCM_EMP_ID,:C_MOVE_TYPE,:C_SC_STATE,:D_ESC_DATE,:D_LSC_DATE,:C_QKP_STATE,:C_KP_ID,:C_CON_NO,:C_CUS_NO,:C_CUS_NAME,:D_WL_DATE,:C_WL_SHIFT,:C_WL_GROUP,:C_WL_EMP_ID,:D_WE_DATE,:C_WE_SHIFT,:C_WE_GROUP,:C_WE_EMP_ID,:C_STOCK_STATE,:C_MAT_TYPE,:C_QGP_STATE,:C_SLABWH_CODE,:C_SLABWH_AREA_CODE,:C_SLABWH_LOC_CODE,:C_SLABWH_TIER_CODE,:N_WGT_METER,:C_QF_NAME,:C_DESIGN_NO,:C_ZRBM,:C_IS_DEPOT,:C_ISXM,:C_XMGX,:C_ISFREE,:C_JUDGE_LEV_CF,:C_JUDGE_LEV_XN,:C_JUDGE_LEV_ZH,:C_JUDGE_LEV_ZH_PEOPLE,:D_JUDGE_DATE,:C_IS_QR,:C_QR_USER,:D_QR_DATE,:D_Q_DATE,:C_SCUTCHEON,:C_GP_TYPE,:C_REMARK,:C_IS_TB,:C_MASTER_ID,:C_GP_BEFORE_ID,:C_GP_AFTER_ID,:D_STACK_DATE,:C_STACK_USER,:C_STACK_SHIFT,:C_STACK_GROUP,:C_IS_PD,:C_REASON_NAME,:C_FYDH,:C_SLAB_STATUS,:C_ZKDH,:C_ZKDHID,:C_LGJH,:C_MES_FLOOR,:N_JZ,:C_HL,:N_HL_TIME,:C_HLYQ,:C_DFP_HL,:N_DFP_HL_TIME,:C_ROUTE,:C_ZYX1,:C_ZYX2)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ORD_NO", OracleDbType.Varchar2,500),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD_PRE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
					new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CCM_DATE", OracleDbType.Date),
					new OracleParameter(":C_CCM_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CCM_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CCM_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SC_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":D_ESC_DATE", OracleDbType.Date),
					new OracleParameter(":D_LSC_DATE", OracleDbType.Date),
					new OracleParameter(":C_QKP_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CUS_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CUS_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":D_WL_DATE", OracleDbType.Date),
					new OracleParameter(":C_WL_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WL_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WL_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_WE_DATE", OracleDbType.Date),
					new OracleParameter(":C_WE_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WE_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WE_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOCK_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_WGT_METER", OracleDbType.Decimal,5),
					new OracleParameter(":C_QF_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZRBM", OracleDbType.Varchar2,100),
					new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ISXM", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
					new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
					new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
					new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
					new OracleParameter(":D_QR_DATE", OracleDbType.Date),
					new OracleParameter(":D_Q_DATE", OracleDbType.Date),
					new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,10),
					new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_STACK_DATE", OracleDbType.Date),
					new OracleParameter(":C_STACK_USER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STACK_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STACK_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
					new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_STATUS", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZKDH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZKDHID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MES_FLOOR", OracleDbType.Varchar2,100),
					new OracleParameter(":N_JZ", OracleDbType.Decimal,15),
					new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
					new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,15),
					new OracleParameter(":C_HLYQ", OracleDbType.Varchar2,400),
					new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
					new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
					new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_PLAN_ID;
			parameters[2].Value = model.C_BATCH_NO;
			parameters[3].Value = model.C_ORD_NO;
			parameters[4].Value = model.C_STOVE;
			parameters[5].Value = model.C_STA_ID;
			parameters[6].Value = model.C_STA_CODE;
			parameters[7].Value = model.C_STA_DESC;
			parameters[8].Value = model.C_STL_GRD;
			parameters[9].Value = model.C_STL_GRD_PRE;
			parameters[10].Value = model.C_MAT_CODE;
			parameters[11].Value = model.C_MAT_NAME;
			parameters[12].Value = model.C_SPEC;
			parameters[13].Value = model.N_LEN;
			parameters[14].Value = model.N_QUA;
			parameters[15].Value = model.N_WGT;
			parameters[16].Value = model.C_STD_CODE;
			parameters[17].Value = model.C_SLAB_TYPE;
			parameters[18].Value = model.D_CCM_DATE;
			parameters[19].Value = model.C_CCM_SHIFT;
			parameters[20].Value = model.C_CCM_GROUP;
			parameters[21].Value = model.C_CCM_EMP_ID;
			parameters[22].Value = model.C_MOVE_TYPE;
			parameters[23].Value = model.C_SC_STATE;
			parameters[24].Value = model.D_ESC_DATE;
			parameters[25].Value = model.D_LSC_DATE;
			parameters[26].Value = model.C_QKP_STATE;
			parameters[27].Value = model.C_KP_ID;
			parameters[28].Value = model.C_CON_NO;
			parameters[29].Value = model.C_CUS_NO;
			parameters[30].Value = model.C_CUS_NAME;
			parameters[31].Value = model.D_WL_DATE;
			parameters[32].Value = model.C_WL_SHIFT;
			parameters[33].Value = model.C_WL_GROUP;
			parameters[34].Value = model.C_WL_EMP_ID;
			parameters[35].Value = model.D_WE_DATE;
			parameters[36].Value = model.C_WE_SHIFT;
			parameters[37].Value = model.C_WE_GROUP;
			parameters[38].Value = model.C_WE_EMP_ID;
			parameters[39].Value = model.C_STOCK_STATE;
			parameters[40].Value = model.C_MAT_TYPE;
			parameters[41].Value = model.C_QGP_STATE;
			parameters[42].Value = model.C_SLABWH_CODE;
			parameters[43].Value = model.C_SLABWH_AREA_CODE;
			parameters[44].Value = model.C_SLABWH_LOC_CODE;
			parameters[45].Value = model.C_SLABWH_TIER_CODE;
			parameters[46].Value = model.N_WGT_METER;
			parameters[47].Value = model.C_QF_NAME;
			parameters[48].Value = model.C_DESIGN_NO;
			parameters[49].Value = model.C_ZRBM;
			parameters[50].Value = model.C_IS_DEPOT;
			parameters[51].Value = model.C_ISXM;
			parameters[52].Value = model.C_XMGX;
			parameters[53].Value = model.C_ISFREE;
			parameters[54].Value = model.C_JUDGE_LEV_CF;
			parameters[55].Value = model.C_JUDGE_LEV_XN;
			parameters[56].Value = model.C_JUDGE_LEV_ZH;
			parameters[57].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
			parameters[58].Value = model.D_JUDGE_DATE;
			parameters[59].Value = model.C_IS_QR;
			parameters[60].Value = model.C_QR_USER;
			parameters[61].Value = model.D_QR_DATE;
			parameters[62].Value = model.D_Q_DATE;
			parameters[63].Value = model.C_SCUTCHEON;
			parameters[64].Value = model.C_GP_TYPE;
			parameters[65].Value = model.C_REMARK;
			parameters[66].Value = model.C_IS_TB;
			parameters[67].Value = model.C_MASTER_ID;
			parameters[68].Value = model.C_GP_BEFORE_ID;
			parameters[69].Value = model.C_GP_AFTER_ID;
			parameters[70].Value = model.D_STACK_DATE;
			parameters[71].Value = model.C_STACK_USER;
			parameters[72].Value = model.C_STACK_SHIFT;
			parameters[73].Value = model.C_STACK_GROUP;
			parameters[74].Value = model.C_IS_PD;
			parameters[75].Value = model.C_REASON_NAME;
			parameters[76].Value = model.C_FYDH;
			parameters[77].Value = model.C_SLAB_STATUS;
			parameters[78].Value = model.C_ZKDH;
			parameters[79].Value = model.C_ZKDHID;
			parameters[80].Value = model.C_LGJH;
			parameters[81].Value = model.C_MES_FLOOR;
			parameters[82].Value = model.N_JZ;
			parameters[83].Value = model.C_HL;
			parameters[84].Value = model.N_HL_TIME;
			parameters[85].Value = model.C_HLYQ;
			parameters[86].Value = model.C_DFP_HL;
			parameters[87].Value = model.N_DFP_HL_TIME;
			parameters[88].Value = model.C_ROUTE;
			parameters[89].Value = model.C_ZYX1;
			parameters[90].Value = model.C_ZYX2;

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
		public bool Update(Mod_TSC_SLAB_NC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TSC_SLAB_NC set ");
			strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
			strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
			strSql.Append("C_ORD_NO=:C_ORD_NO,");
			strSql.Append("C_STOVE=:C_STOVE,");
			strSql.Append("C_STA_ID=:C_STA_ID,");
			strSql.Append("C_STA_CODE=:C_STA_CODE,");
			strSql.Append("C_STA_DESC=:C_STA_DESC,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_STL_GRD_PRE=:C_STL_GRD_PRE,");
			strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
			strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
			strSql.Append("C_SPEC=:C_SPEC,");
			strSql.Append("N_LEN=:N_LEN,");
			strSql.Append("N_QUA=:N_QUA,");
			strSql.Append("N_WGT=:N_WGT,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
			strSql.Append("D_CCM_DATE=:D_CCM_DATE,");
			strSql.Append("C_CCM_SHIFT=:C_CCM_SHIFT,");
			strSql.Append("C_CCM_GROUP=:C_CCM_GROUP,");
			strSql.Append("C_CCM_EMP_ID=:C_CCM_EMP_ID,");
			strSql.Append("C_MOVE_TYPE=:C_MOVE_TYPE,");
			strSql.Append("C_SC_STATE=:C_SC_STATE,");
			strSql.Append("D_ESC_DATE=:D_ESC_DATE,");
			strSql.Append("D_LSC_DATE=:D_LSC_DATE,");
			strSql.Append("C_QKP_STATE=:C_QKP_STATE,");
			strSql.Append("C_KP_ID=:C_KP_ID,");
			strSql.Append("C_CON_NO=:C_CON_NO,");
			strSql.Append("C_CUS_NO=:C_CUS_NO,");
			strSql.Append("C_CUS_NAME=:C_CUS_NAME,");
			strSql.Append("D_WL_DATE=:D_WL_DATE,");
			strSql.Append("C_WL_SHIFT=:C_WL_SHIFT,");
			strSql.Append("C_WL_GROUP=:C_WL_GROUP,");
			strSql.Append("C_WL_EMP_ID=:C_WL_EMP_ID,");
			strSql.Append("D_WE_DATE=:D_WE_DATE,");
			strSql.Append("C_WE_SHIFT=:C_WE_SHIFT,");
			strSql.Append("C_WE_GROUP=:C_WE_GROUP,");
			strSql.Append("C_WE_EMP_ID=:C_WE_EMP_ID,");
			strSql.Append("C_STOCK_STATE=:C_STOCK_STATE,");
			strSql.Append("C_MAT_TYPE=:C_MAT_TYPE,");
			strSql.Append("C_QGP_STATE=:C_QGP_STATE,");
			strSql.Append("C_SLABWH_CODE=:C_SLABWH_CODE,");
			strSql.Append("C_SLABWH_AREA_CODE=:C_SLABWH_AREA_CODE,");
			strSql.Append("C_SLABWH_LOC_CODE=:C_SLABWH_LOC_CODE,");
			strSql.Append("C_SLABWH_TIER_CODE=:C_SLABWH_TIER_CODE,");
			strSql.Append("N_WGT_METER=:N_WGT_METER,");
			strSql.Append("C_QF_NAME=:C_QF_NAME,");
			strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
			strSql.Append("C_ZRBM=:C_ZRBM,");
			strSql.Append("C_IS_DEPOT=:C_IS_DEPOT,");
			strSql.Append("C_ISXM=:C_ISXM,");
			strSql.Append("C_XMGX=:C_XMGX,");
			strSql.Append("C_ISFREE=:C_ISFREE,");
			strSql.Append("C_JUDGE_LEV_CF=:C_JUDGE_LEV_CF,");
			strSql.Append("C_JUDGE_LEV_XN=:C_JUDGE_LEV_XN,");
			strSql.Append("C_JUDGE_LEV_ZH=:C_JUDGE_LEV_ZH,");
			strSql.Append("C_JUDGE_LEV_ZH_PEOPLE=:C_JUDGE_LEV_ZH_PEOPLE,");
			strSql.Append("D_JUDGE_DATE=:D_JUDGE_DATE,");
			strSql.Append("C_IS_QR=:C_IS_QR,");
			strSql.Append("C_QR_USER=:C_QR_USER,");
			strSql.Append("D_QR_DATE=:D_QR_DATE,");
			strSql.Append("D_Q_DATE=:D_Q_DATE,");
			strSql.Append("C_SCUTCHEON=:C_SCUTCHEON,");
			strSql.Append("C_GP_TYPE=:C_GP_TYPE,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_IS_TB=:C_IS_TB,");
			strSql.Append("C_MASTER_ID=:C_MASTER_ID,");
			strSql.Append("C_GP_BEFORE_ID=:C_GP_BEFORE_ID,");
			strSql.Append("C_GP_AFTER_ID=:C_GP_AFTER_ID,");
			strSql.Append("D_STACK_DATE=:D_STACK_DATE,");
			strSql.Append("C_STACK_USER=:C_STACK_USER,");
			strSql.Append("C_STACK_SHIFT=:C_STACK_SHIFT,");
			strSql.Append("C_STACK_GROUP=:C_STACK_GROUP,");
			strSql.Append("C_IS_PD=:C_IS_PD,");
			strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
			strSql.Append("C_FYDH=:C_FYDH,");
			strSql.Append("C_SLAB_STATUS=:C_SLAB_STATUS,");
			strSql.Append("C_ZKDH=:C_ZKDH,");
			strSql.Append("C_ZKDHID=:C_ZKDHID,");
			strSql.Append("C_LGJH=:C_LGJH,");
			strSql.Append("C_MES_FLOOR=:C_MES_FLOOR,");
			strSql.Append("N_JZ=:N_JZ,");
			strSql.Append("C_HL=:C_HL,");
			strSql.Append("N_HL_TIME=:N_HL_TIME,");
			strSql.Append("C_HLYQ=:C_HLYQ,");
			strSql.Append("C_DFP_HL=:C_DFP_HL,");
			strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
			strSql.Append("C_ROUTE=:C_ROUTE,");
			strSql.Append("C_ZYX1=:C_ZYX1,");
			strSql.Append("C_ZYX2=:C_ZYX2");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ORD_NO", OracleDbType.Varchar2,500),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD_PRE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
					new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CCM_DATE", OracleDbType.Date),
					new OracleParameter(":C_CCM_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CCM_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CCM_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SC_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":D_ESC_DATE", OracleDbType.Date),
					new OracleParameter(":D_LSC_DATE", OracleDbType.Date),
					new OracleParameter(":C_QKP_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CUS_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CUS_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":D_WL_DATE", OracleDbType.Date),
					new OracleParameter(":C_WL_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WL_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WL_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_WE_DATE", OracleDbType.Date),
					new OracleParameter(":C_WE_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WE_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WE_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOCK_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_WGT_METER", OracleDbType.Decimal,5),
					new OracleParameter(":C_QF_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZRBM", OracleDbType.Varchar2,100),
					new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ISXM", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
					new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
					new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
					new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
					new OracleParameter(":D_QR_DATE", OracleDbType.Date),
					new OracleParameter(":D_Q_DATE", OracleDbType.Date),
					new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,10),
					new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_STACK_DATE", OracleDbType.Date),
					new OracleParameter(":C_STACK_USER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STACK_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STACK_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
					new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_STATUS", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZKDH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZKDHID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MES_FLOOR", OracleDbType.Varchar2,100),
					new OracleParameter(":N_JZ", OracleDbType.Decimal,15),
					new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
					new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,15),
					new OracleParameter(":C_HLYQ", OracleDbType.Varchar2,400),
					new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
					new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
					new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_PLAN_ID;
			parameters[1].Value = model.C_BATCH_NO;
			parameters[2].Value = model.C_ORD_NO;
			parameters[3].Value = model.C_STOVE;
			parameters[4].Value = model.C_STA_ID;
			parameters[5].Value = model.C_STA_CODE;
			parameters[6].Value = model.C_STA_DESC;
			parameters[7].Value = model.C_STL_GRD;
			parameters[8].Value = model.C_STL_GRD_PRE;
			parameters[9].Value = model.C_MAT_CODE;
			parameters[10].Value = model.C_MAT_NAME;
			parameters[11].Value = model.C_SPEC;
			parameters[12].Value = model.N_LEN;
			parameters[13].Value = model.N_QUA;
			parameters[14].Value = model.N_WGT;
			parameters[15].Value = model.C_STD_CODE;
			parameters[16].Value = model.C_SLAB_TYPE;
			parameters[17].Value = model.D_CCM_DATE;
			parameters[18].Value = model.C_CCM_SHIFT;
			parameters[19].Value = model.C_CCM_GROUP;
			parameters[20].Value = model.C_CCM_EMP_ID;
			parameters[21].Value = model.C_MOVE_TYPE;
			parameters[22].Value = model.C_SC_STATE;
			parameters[23].Value = model.D_ESC_DATE;
			parameters[24].Value = model.D_LSC_DATE;
			parameters[25].Value = model.C_QKP_STATE;
			parameters[26].Value = model.C_KP_ID;
			parameters[27].Value = model.C_CON_NO;
			parameters[28].Value = model.C_CUS_NO;
			parameters[29].Value = model.C_CUS_NAME;
			parameters[30].Value = model.D_WL_DATE;
			parameters[31].Value = model.C_WL_SHIFT;
			parameters[32].Value = model.C_WL_GROUP;
			parameters[33].Value = model.C_WL_EMP_ID;
			parameters[34].Value = model.D_WE_DATE;
			parameters[35].Value = model.C_WE_SHIFT;
			parameters[36].Value = model.C_WE_GROUP;
			parameters[37].Value = model.C_WE_EMP_ID;
			parameters[38].Value = model.C_STOCK_STATE;
			parameters[39].Value = model.C_MAT_TYPE;
			parameters[40].Value = model.C_QGP_STATE;
			parameters[41].Value = model.C_SLABWH_CODE;
			parameters[42].Value = model.C_SLABWH_AREA_CODE;
			parameters[43].Value = model.C_SLABWH_LOC_CODE;
			parameters[44].Value = model.C_SLABWH_TIER_CODE;
			parameters[45].Value = model.N_WGT_METER;
			parameters[46].Value = model.C_QF_NAME;
			parameters[47].Value = model.C_DESIGN_NO;
			parameters[48].Value = model.C_ZRBM;
			parameters[49].Value = model.C_IS_DEPOT;
			parameters[50].Value = model.C_ISXM;
			parameters[51].Value = model.C_XMGX;
			parameters[52].Value = model.C_ISFREE;
			parameters[53].Value = model.C_JUDGE_LEV_CF;
			parameters[54].Value = model.C_JUDGE_LEV_XN;
			parameters[55].Value = model.C_JUDGE_LEV_ZH;
			parameters[56].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
			parameters[57].Value = model.D_JUDGE_DATE;
			parameters[58].Value = model.C_IS_QR;
			parameters[59].Value = model.C_QR_USER;
			parameters[60].Value = model.D_QR_DATE;
			parameters[61].Value = model.D_Q_DATE;
			parameters[62].Value = model.C_SCUTCHEON;
			parameters[63].Value = model.C_GP_TYPE;
			parameters[64].Value = model.C_REMARK;
			parameters[65].Value = model.C_IS_TB;
			parameters[66].Value = model.C_MASTER_ID;
			parameters[67].Value = model.C_GP_BEFORE_ID;
			parameters[68].Value = model.C_GP_AFTER_ID;
			parameters[69].Value = model.D_STACK_DATE;
			parameters[70].Value = model.C_STACK_USER;
			parameters[71].Value = model.C_STACK_SHIFT;
			parameters[72].Value = model.C_STACK_GROUP;
			parameters[73].Value = model.C_IS_PD;
			parameters[74].Value = model.C_REASON_NAME;
			parameters[75].Value = model.C_FYDH;
			parameters[76].Value = model.C_SLAB_STATUS;
			parameters[77].Value = model.C_ZKDH;
			parameters[78].Value = model.C_ZKDHID;
			parameters[79].Value = model.C_LGJH;
			parameters[80].Value = model.C_MES_FLOOR;
			parameters[81].Value = model.N_JZ;
			parameters[82].Value = model.C_HL;
			parameters[83].Value = model.N_HL_TIME;
			parameters[84].Value = model.C_HLYQ;
			parameters[85].Value = model.C_DFP_HL;
			parameters[86].Value = model.N_DFP_HL_TIME;
			parameters[87].Value = model.C_ROUTE;
			parameters[88].Value = model.C_ZYX1;
			parameters[89].Value = model.C_ZYX2;
			parameters[90].Value = model.C_ID;

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
			strSql.Append("delete from TSC_SLAB_NC ");
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
        /// 删除库存同步表数据
        /// </summary>
        /// <param name="type">测试/正式</param>
        /// <returns></returns>
        public bool DeleteByType(string type)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TSC_SLAB_NC ");
            if (type=="测试")
            {
                strSql.Append(" where C_PLAN_ID IS NULL ");
            }
            else
            {
                strSql.Append(" where C_PLAN_ID IS NOT NULL ");
            }

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TSC_SLAB_NC ");
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
		public Mod_TSC_SLAB_NC GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,C_IS_TB,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,D_STACK_DATE,C_STACK_USER,C_STACK_SHIFT,C_STACK_GROUP,C_IS_PD,C_REASON_NAME,C_FYDH,C_SLAB_STATUS,C_ZKDH,C_ZKDHID,C_LGJH,C_MES_FLOOR,N_JZ,C_HL,N_HL_TIME,C_HLYQ,C_DFP_HL,N_DFP_HL_TIME,C_ROUTE,C_ZYX1,C_ZYX2 from TSC_SLAB_NC ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TSC_SLAB_NC model=new Mod_TSC_SLAB_NC();
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
		public Mod_TSC_SLAB_NC DataRowToModel(DataRow row)
		{
			Mod_TSC_SLAB_NC model=new Mod_TSC_SLAB_NC();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_PLAN_ID"]!=null)
				{
					model.C_PLAN_ID=row["C_PLAN_ID"].ToString();
				}
				if(row["C_BATCH_NO"]!=null)
				{
					model.C_BATCH_NO=row["C_BATCH_NO"].ToString();
				}
				if(row["C_ORD_NO"]!=null)
				{
					model.C_ORD_NO=row["C_ORD_NO"].ToString();
				}
				if(row["C_STOVE"]!=null)
				{
					model.C_STOVE=row["C_STOVE"].ToString();
				}
				if(row["C_STA_ID"]!=null)
				{
					model.C_STA_ID=row["C_STA_ID"].ToString();
				}
				if(row["C_STA_CODE"]!=null)
				{
					model.C_STA_CODE=row["C_STA_CODE"].ToString();
				}
				if(row["C_STA_DESC"]!=null)
				{
					model.C_STA_DESC=row["C_STA_DESC"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_STL_GRD_PRE"]!=null)
				{
					model.C_STL_GRD_PRE=row["C_STL_GRD_PRE"].ToString();
				}
				if(row["C_MAT_CODE"]!=null)
				{
					model.C_MAT_CODE=row["C_MAT_CODE"].ToString();
				}
				if(row["C_MAT_NAME"]!=null)
				{
					model.C_MAT_NAME=row["C_MAT_NAME"].ToString();
				}
				if(row["C_SPEC"]!=null)
				{
					model.C_SPEC=row["C_SPEC"].ToString();
				}
				if(row["N_LEN"]!=null && row["N_LEN"].ToString()!="")
				{
					model.N_LEN=decimal.Parse(row["N_LEN"].ToString());
				}
				if(row["N_QUA"]!=null && row["N_QUA"].ToString()!="")
				{
					model.N_QUA=decimal.Parse(row["N_QUA"].ToString());
				}
				if(row["N_WGT"]!=null && row["N_WGT"].ToString()!="")
				{
					model.N_WGT=decimal.Parse(row["N_WGT"].ToString());
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_SLAB_TYPE"]!=null)
				{
					model.C_SLAB_TYPE=row["C_SLAB_TYPE"].ToString();
				}
				if(row["D_CCM_DATE"]!=null && row["D_CCM_DATE"].ToString()!="")
				{
					model.D_CCM_DATE=DateTime.Parse(row["D_CCM_DATE"].ToString());
				}
				if(row["C_CCM_SHIFT"]!=null)
				{
					model.C_CCM_SHIFT=row["C_CCM_SHIFT"].ToString();
				}
				if(row["C_CCM_GROUP"]!=null)
				{
					model.C_CCM_GROUP=row["C_CCM_GROUP"].ToString();
				}
				if(row["C_CCM_EMP_ID"]!=null)
				{
					model.C_CCM_EMP_ID=row["C_CCM_EMP_ID"].ToString();
				}
				if(row["C_MOVE_TYPE"]!=null)
				{
					model.C_MOVE_TYPE=row["C_MOVE_TYPE"].ToString();
				}
				if(row["C_SC_STATE"]!=null)
				{
					model.C_SC_STATE=row["C_SC_STATE"].ToString();
				}
				if(row["D_ESC_DATE"]!=null && row["D_ESC_DATE"].ToString()!="")
				{
					model.D_ESC_DATE=DateTime.Parse(row["D_ESC_DATE"].ToString());
				}
				if(row["D_LSC_DATE"]!=null && row["D_LSC_DATE"].ToString()!="")
				{
					model.D_LSC_DATE=DateTime.Parse(row["D_LSC_DATE"].ToString());
				}
				if(row["C_QKP_STATE"]!=null)
				{
					model.C_QKP_STATE=row["C_QKP_STATE"].ToString();
				}
				if(row["C_KP_ID"]!=null)
				{
					model.C_KP_ID=row["C_KP_ID"].ToString();
				}
				if(row["C_CON_NO"]!=null)
				{
					model.C_CON_NO=row["C_CON_NO"].ToString();
				}
				if(row["C_CUS_NO"]!=null)
				{
					model.C_CUS_NO=row["C_CUS_NO"].ToString();
				}
				if(row["C_CUS_NAME"]!=null)
				{
					model.C_CUS_NAME=row["C_CUS_NAME"].ToString();
				}
				if(row["D_WL_DATE"]!=null && row["D_WL_DATE"].ToString()!="")
				{
					model.D_WL_DATE=DateTime.Parse(row["D_WL_DATE"].ToString());
				}
				if(row["C_WL_SHIFT"]!=null)
				{
					model.C_WL_SHIFT=row["C_WL_SHIFT"].ToString();
				}
				if(row["C_WL_GROUP"]!=null)
				{
					model.C_WL_GROUP=row["C_WL_GROUP"].ToString();
				}
				if(row["C_WL_EMP_ID"]!=null)
				{
					model.C_WL_EMP_ID=row["C_WL_EMP_ID"].ToString();
				}
				if(row["D_WE_DATE"]!=null && row["D_WE_DATE"].ToString()!="")
				{
					model.D_WE_DATE=DateTime.Parse(row["D_WE_DATE"].ToString());
				}
				if(row["C_WE_SHIFT"]!=null)
				{
					model.C_WE_SHIFT=row["C_WE_SHIFT"].ToString();
				}
				if(row["C_WE_GROUP"]!=null)
				{
					model.C_WE_GROUP=row["C_WE_GROUP"].ToString();
				}
				if(row["C_WE_EMP_ID"]!=null)
				{
					model.C_WE_EMP_ID=row["C_WE_EMP_ID"].ToString();
				}
				if(row["C_STOCK_STATE"]!=null)
				{
					model.C_STOCK_STATE=row["C_STOCK_STATE"].ToString();
				}
				if(row["C_MAT_TYPE"]!=null)
				{
					model.C_MAT_TYPE=row["C_MAT_TYPE"].ToString();
				}
				if(row["C_QGP_STATE"]!=null)
				{
					model.C_QGP_STATE=row["C_QGP_STATE"].ToString();
				}
				if(row["C_SLABWH_CODE"]!=null)
				{
					model.C_SLABWH_CODE=row["C_SLABWH_CODE"].ToString();
				}
				if(row["C_SLABWH_AREA_CODE"]!=null)
				{
					model.C_SLABWH_AREA_CODE=row["C_SLABWH_AREA_CODE"].ToString();
				}
				if(row["C_SLABWH_LOC_CODE"]!=null)
				{
					model.C_SLABWH_LOC_CODE=row["C_SLABWH_LOC_CODE"].ToString();
				}
				if(row["C_SLABWH_TIER_CODE"]!=null)
				{
					model.C_SLABWH_TIER_CODE=row["C_SLABWH_TIER_CODE"].ToString();
				}
				if(row["N_WGT_METER"]!=null && row["N_WGT_METER"].ToString()!="")
				{
					model.N_WGT_METER=decimal.Parse(row["N_WGT_METER"].ToString());
				}
				if(row["C_QF_NAME"]!=null)
				{
					model.C_QF_NAME=row["C_QF_NAME"].ToString();
				}
				if(row["C_DESIGN_NO"]!=null)
				{
					model.C_DESIGN_NO=row["C_DESIGN_NO"].ToString();
				}
				if(row["C_ZRBM"]!=null)
				{
					model.C_ZRBM=row["C_ZRBM"].ToString();
				}
				if(row["C_IS_DEPOT"]!=null)
				{
					model.C_IS_DEPOT=row["C_IS_DEPOT"].ToString();
				}
				if(row["C_ISXM"]!=null)
				{
					model.C_ISXM=row["C_ISXM"].ToString();
				}
				if(row["C_XMGX"]!=null)
				{
					model.C_XMGX=row["C_XMGX"].ToString();
				}
				if(row["C_ISFREE"]!=null)
				{
					model.C_ISFREE=row["C_ISFREE"].ToString();
				}
				if(row["C_JUDGE_LEV_CF"]!=null)
				{
					model.C_JUDGE_LEV_CF=row["C_JUDGE_LEV_CF"].ToString();
				}
				if(row["C_JUDGE_LEV_XN"]!=null)
				{
					model.C_JUDGE_LEV_XN=row["C_JUDGE_LEV_XN"].ToString();
				}
				if(row["C_JUDGE_LEV_ZH"]!=null)
				{
					model.C_JUDGE_LEV_ZH=row["C_JUDGE_LEV_ZH"].ToString();
				}
				if(row["C_JUDGE_LEV_ZH_PEOPLE"]!=null)
				{
					model.C_JUDGE_LEV_ZH_PEOPLE=row["C_JUDGE_LEV_ZH_PEOPLE"].ToString();
				}
				if(row["D_JUDGE_DATE"]!=null && row["D_JUDGE_DATE"].ToString()!="")
				{
					model.D_JUDGE_DATE=DateTime.Parse(row["D_JUDGE_DATE"].ToString());
				}
				if(row["C_IS_QR"]!=null)
				{
					model.C_IS_QR=row["C_IS_QR"].ToString();
				}
				if(row["C_QR_USER"]!=null)
				{
					model.C_QR_USER=row["C_QR_USER"].ToString();
				}
				if(row["D_QR_DATE"]!=null && row["D_QR_DATE"].ToString()!="")
				{
					model.D_QR_DATE=DateTime.Parse(row["D_QR_DATE"].ToString());
				}
				if(row["D_Q_DATE"]!=null && row["D_Q_DATE"].ToString()!="")
				{
					model.D_Q_DATE=DateTime.Parse(row["D_Q_DATE"].ToString());
				}
				if(row["C_SCUTCHEON"]!=null)
				{
					model.C_SCUTCHEON=row["C_SCUTCHEON"].ToString();
				}
				if(row["C_GP_TYPE"]!=null)
				{
					model.C_GP_TYPE=row["C_GP_TYPE"].ToString();
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["C_IS_TB"]!=null)
				{
					model.C_IS_TB=row["C_IS_TB"].ToString();
				}
				if(row["C_MASTER_ID"]!=null)
				{
					model.C_MASTER_ID=row["C_MASTER_ID"].ToString();
				}
				if(row["C_GP_BEFORE_ID"]!=null)
				{
					model.C_GP_BEFORE_ID=row["C_GP_BEFORE_ID"].ToString();
				}
				if(row["C_GP_AFTER_ID"]!=null)
				{
					model.C_GP_AFTER_ID=row["C_GP_AFTER_ID"].ToString();
				}
				if(row["D_STACK_DATE"]!=null && row["D_STACK_DATE"].ToString()!="")
				{
					model.D_STACK_DATE=DateTime.Parse(row["D_STACK_DATE"].ToString());
				}
				if(row["C_STACK_USER"]!=null)
				{
					model.C_STACK_USER=row["C_STACK_USER"].ToString();
				}
				if(row["C_STACK_SHIFT"]!=null)
				{
					model.C_STACK_SHIFT=row["C_STACK_SHIFT"].ToString();
				}
				if(row["C_STACK_GROUP"]!=null)
				{
					model.C_STACK_GROUP=row["C_STACK_GROUP"].ToString();
				}
				if(row["C_IS_PD"]!=null)
				{
					model.C_IS_PD=row["C_IS_PD"].ToString();
				}
				if(row["C_REASON_NAME"]!=null)
				{
					model.C_REASON_NAME=row["C_REASON_NAME"].ToString();
				}
				if(row["C_FYDH"]!=null)
				{
					model.C_FYDH=row["C_FYDH"].ToString();
				}
				if(row["C_SLAB_STATUS"]!=null)
				{
					model.C_SLAB_STATUS=row["C_SLAB_STATUS"].ToString();
				}
				if(row["C_ZKDH"]!=null)
				{
					model.C_ZKDH=row["C_ZKDH"].ToString();
				}
				if(row["C_ZKDHID"]!=null)
				{
					model.C_ZKDHID=row["C_ZKDHID"].ToString();
				}
				if(row["C_LGJH"]!=null)
				{
					model.C_LGJH=row["C_LGJH"].ToString();
				}
				if(row["C_MES_FLOOR"]!=null)
				{
					model.C_MES_FLOOR=row["C_MES_FLOOR"].ToString();
				}
				if(row["N_JZ"]!=null && row["N_JZ"].ToString()!="")
				{
					model.N_JZ=decimal.Parse(row["N_JZ"].ToString());
				}
				if(row["C_HL"]!=null)
				{
					model.C_HL=row["C_HL"].ToString();
				}
				if(row["N_HL_TIME"]!=null && row["N_HL_TIME"].ToString()!="")
				{
					model.N_HL_TIME=decimal.Parse(row["N_HL_TIME"].ToString());
				}
				if(row["C_HLYQ"]!=null)
				{
					model.C_HLYQ=row["C_HLYQ"].ToString();
				}
				if(row["C_DFP_HL"]!=null)
				{
					model.C_DFP_HL=row["C_DFP_HL"].ToString();
				}
				if(row["N_DFP_HL_TIME"]!=null && row["N_DFP_HL_TIME"].ToString()!="")
				{
					model.N_DFP_HL_TIME=decimal.Parse(row["N_DFP_HL_TIME"].ToString());
				}
				if(row["C_ROUTE"]!=null)
				{
					model.C_ROUTE=row["C_ROUTE"].ToString();
				}
				if(row["C_ZYX1"]!=null)
				{
					model.C_ZYX1=row["C_ZYX1"].ToString();
				}
				if(row["C_ZYX2"]!=null)
				{
					model.C_ZYX2=row["C_ZYX2"].ToString();
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
			strSql.Append("select C_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,C_IS_TB,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,D_STACK_DATE,C_STACK_USER,C_STACK_SHIFT,C_STACK_GROUP,C_IS_PD,C_REASON_NAME,C_FYDH,C_SLAB_STATUS,C_ZKDH,C_ZKDHID,C_LGJH,C_MES_FLOOR,N_JZ,C_HL,N_HL_TIME,C_HLYQ,C_DFP_HL,N_DFP_HL_TIME,C_ROUTE,C_ZYX1,C_ZYX2 ");
			strSql.Append(" FROM TSC_SLAB_NC ");
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
			strSql.Append("select count(1) FROM TSC_SLAB_NC ");
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
			strSql.Append(")AS Row, T.*  from TSC_SLAB_NC T ");
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
			parameters[0].Value = "TSC_SLAB_NC";
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

