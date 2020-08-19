using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TSC_STOVE_TIME
    /// </summary>
    public partial class Dal_TSC_STOVE_TIME
    {
        public Dal_TSC_STOVE_TIME()
        { }
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TSC_STOVE_TIME model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TSC_STOVE_TIME(");
			strSql.Append("PREHEATID,HEATID,LF_TREATNO,RH_TREATNO,CASTER_TREATNO,ACT_TIME_IRONPREPARED,ACT_TIME_BOFSTART,ACT_TIME_BOFTAPPED,ACT_TIME_TAPPEDSIDEEND,ACT_TIME_LFARRIVAL,ACT_TIME_LFSTART,ACT_TIME_LFEND,ACT_TIME_LFLEAVE,ACT_TIME_RHARRIVAL,ACT_TIME_RHSTART,ACT_TIME_RHEND,ACT_TIME_RHLEAVE,ACT_TIME_CASTERARRIVAL,ACT_TIME_CASTINGSTART,ACT_TIME_CASTINGEND,CREATEDATE,C_ZL_ID,C_ZL_CODE,C_ZL_DESC,C_LF_ID,C_LF_CODE,C_LF_DESC,C_RH_ID,C_RH_CODE,C_RH_DESC,C_CC_ID,C_CC_CODE,C_CC_DESC,C_PLAN_SMS_ID)");
			strSql.Append(" values (");
			strSql.Append(":PREHEATID,:HEATID,:LF_TREATNO,:RH_TREATNO,:CASTER_TREATNO,:ACT_TIME_IRONPREPARED,:ACT_TIME_BOFSTART,:ACT_TIME_BOFTAPPED,:ACT_TIME_TAPPEDSIDEEND,:ACT_TIME_LFARRIVAL,:ACT_TIME_LFSTART,:ACT_TIME_LFEND,:ACT_TIME_LFLEAVE,:ACT_TIME_RHARRIVAL,:ACT_TIME_RHSTART,:ACT_TIME_RHEND,:ACT_TIME_RHLEAVE,:ACT_TIME_CASTERARRIVAL,:ACT_TIME_CASTINGSTART,:ACT_TIME_CASTINGEND,:CREATEDATE,:C_ZL_ID,:C_ZL_CODE,:C_ZL_DESC,:C_LF_ID,:C_LF_CODE,:C_LF_DESC,:C_RH_ID,:C_RH_CODE,:C_RH_DESC,:C_CC_ID,:C_CC_CODE,:C_CC_DESC,:C_PLAN_SMS_ID)");
			OracleParameter[] parameters = {
					new OracleParameter(":PREHEATID", OracleDbType.Varchar2,250),
					new OracleParameter(":HEATID", OracleDbType.Varchar2,250),
					new OracleParameter(":LF_TREATNO", OracleDbType.Varchar2,250),
					new OracleParameter(":RH_TREATNO", OracleDbType.Varchar2,250),
					new OracleParameter(":CASTER_TREATNO", OracleDbType.Varchar2,250),
					new OracleParameter(":ACT_TIME_IRONPREPARED", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_BOFSTART", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_BOFTAPPED", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_TAPPEDSIDEEND", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_LFARRIVAL", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_LFSTART", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_LFEND", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_LFLEAVE", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_RHARRIVAL", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_RHSTART", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_RHEND", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_RHLEAVE", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_CASTERARRIVAL", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_CASTINGSTART", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_CASTINGEND", OracleDbType.Date),
					new OracleParameter(":CREATEDATE", OracleDbType.Date),
					new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,250),
					new OracleParameter(":C_ZL_CODE", OracleDbType.Varchar2,250),
					new OracleParameter(":C_ZL_DESC", OracleDbType.Varchar2,250),
					new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,250),
					new OracleParameter(":C_LF_CODE", OracleDbType.Varchar2,250),
					new OracleParameter(":C_LF_DESC", OracleDbType.Varchar2,250),
					new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,250),
					new OracleParameter(":C_RH_CODE", OracleDbType.Varchar2,250),
					new OracleParameter(":C_RH_DESC", OracleDbType.Varchar2,250),
					new OracleParameter(":C_CC_ID", OracleDbType.Varchar2,250),
					new OracleParameter(":C_CC_CODE", OracleDbType.Varchar2,250),
					new OracleParameter(":C_CC_DESC", OracleDbType.Varchar2,250),
					new OracleParameter(":C_PLAN_SMS_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.PREHEATID;
			parameters[1].Value = model.HEATID;
			parameters[2].Value = model.LF_TREATNO;
			parameters[3].Value = model.RH_TREATNO;
			parameters[4].Value = model.CASTER_TREATNO;
			parameters[5].Value = model.ACT_TIME_IRONPREPARED;
			parameters[6].Value = model.ACT_TIME_BOFSTART;
			parameters[7].Value = model.ACT_TIME_BOFTAPPED;
			parameters[8].Value = model.ACT_TIME_TAPPEDSIDEEND;
			parameters[9].Value = model.ACT_TIME_LFARRIVAL;
			parameters[10].Value = model.ACT_TIME_LFSTART;
			parameters[11].Value = model.ACT_TIME_LFEND;
			parameters[12].Value = model.ACT_TIME_LFLEAVE;
			parameters[13].Value = model.ACT_TIME_RHARRIVAL;
			parameters[14].Value = model.ACT_TIME_RHSTART;
			parameters[15].Value = model.ACT_TIME_RHEND;
			parameters[16].Value = model.ACT_TIME_RHLEAVE;
			parameters[17].Value = model.ACT_TIME_CASTERARRIVAL;
			parameters[18].Value = model.ACT_TIME_CASTINGSTART;
			parameters[19].Value = model.ACT_TIME_CASTINGEND;
			parameters[20].Value = model.CREATEDATE;
			parameters[21].Value = model.C_ZL_ID;
			parameters[22].Value = model.C_ZL_CODE;
			parameters[23].Value = model.C_ZL_DESC;
			parameters[24].Value = model.C_LF_ID;
			parameters[25].Value = model.C_LF_CODE;
			parameters[26].Value = model.C_LF_DESC;
			parameters[27].Value = model.C_RH_ID;
			parameters[28].Value = model.C_RH_CODE;
			parameters[29].Value = model.C_RH_DESC;
			parameters[30].Value = model.C_CC_ID;
			parameters[31].Value = model.C_CC_CODE;
			parameters[32].Value = model.C_CC_DESC;
			parameters[33].Value = model.C_PLAN_SMS_ID;

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
		public bool Update(Mod_TSC_STOVE_TIME model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TSC_STOVE_TIME set ");
			strSql.Append("PREHEATID=:PREHEATID,");
			strSql.Append("HEATID=:HEATID,");
			strSql.Append("LF_TREATNO=:LF_TREATNO,");
			strSql.Append("RH_TREATNO=:RH_TREATNO,");
			strSql.Append("CASTER_TREATNO=:CASTER_TREATNO,");
			strSql.Append("ACT_TIME_IRONPREPARED=:ACT_TIME_IRONPREPARED,");
			strSql.Append("ACT_TIME_BOFSTART=:ACT_TIME_BOFSTART,");
			strSql.Append("ACT_TIME_BOFTAPPED=:ACT_TIME_BOFTAPPED,");
			strSql.Append("ACT_TIME_TAPPEDSIDEEND=:ACT_TIME_TAPPEDSIDEEND,");
			strSql.Append("ACT_TIME_LFARRIVAL=:ACT_TIME_LFARRIVAL,");
			strSql.Append("ACT_TIME_LFSTART=:ACT_TIME_LFSTART,");
			strSql.Append("ACT_TIME_LFEND=:ACT_TIME_LFEND,");
			strSql.Append("ACT_TIME_LFLEAVE=:ACT_TIME_LFLEAVE,");
			strSql.Append("ACT_TIME_RHARRIVAL=:ACT_TIME_RHARRIVAL,");
			strSql.Append("ACT_TIME_RHSTART=:ACT_TIME_RHSTART,");
			strSql.Append("ACT_TIME_RHEND=:ACT_TIME_RHEND,");
			strSql.Append("ACT_TIME_RHLEAVE=:ACT_TIME_RHLEAVE,");
			strSql.Append("ACT_TIME_CASTERARRIVAL=:ACT_TIME_CASTERARRIVAL,");
			strSql.Append("ACT_TIME_CASTINGSTART=:ACT_TIME_CASTINGSTART,");
			strSql.Append("ACT_TIME_CASTINGEND=:ACT_TIME_CASTINGEND,");
			strSql.Append("CREATEDATE=:CREATEDATE,");
			strSql.Append("C_ZL_ID=:C_ZL_ID,");
			strSql.Append("C_ZL_CODE=:C_ZL_CODE,");
			strSql.Append("C_ZL_DESC=:C_ZL_DESC,");
			strSql.Append("C_LF_ID=:C_LF_ID,");
			strSql.Append("C_LF_CODE=:C_LF_CODE,");
			strSql.Append("C_LF_DESC=:C_LF_DESC,");
			strSql.Append("C_RH_ID=:C_RH_ID,");
			strSql.Append("C_RH_CODE=:C_RH_CODE,");
			strSql.Append("C_RH_DESC=:C_RH_DESC,");
			strSql.Append("C_CC_ID=:C_CC_ID,");
			strSql.Append("C_CC_CODE=:C_CC_CODE,");
			strSql.Append("C_CC_DESC=:C_CC_DESC,");
			strSql.Append("C_PLAN_SMS_ID=:C_PLAN_SMS_ID");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":PREHEATID", OracleDbType.Varchar2,250),
					new OracleParameter(":HEATID", OracleDbType.Varchar2,250),
					new OracleParameter(":LF_TREATNO", OracleDbType.Varchar2,250),
					new OracleParameter(":RH_TREATNO", OracleDbType.Varchar2,250),
					new OracleParameter(":CASTER_TREATNO", OracleDbType.Varchar2,250),
					new OracleParameter(":ACT_TIME_IRONPREPARED", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_BOFSTART", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_BOFTAPPED", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_TAPPEDSIDEEND", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_LFARRIVAL", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_LFSTART", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_LFEND", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_LFLEAVE", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_RHARRIVAL", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_RHSTART", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_RHEND", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_RHLEAVE", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_CASTERARRIVAL", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_CASTINGSTART", OracleDbType.Date),
					new OracleParameter(":ACT_TIME_CASTINGEND", OracleDbType.Date),
					new OracleParameter(":CREATEDATE", OracleDbType.Date),
					new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,250),
					new OracleParameter(":C_ZL_CODE", OracleDbType.Varchar2,250),
					new OracleParameter(":C_ZL_DESC", OracleDbType.Varchar2,250),
					new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,250),
					new OracleParameter(":C_LF_CODE", OracleDbType.Varchar2,250),
					new OracleParameter(":C_LF_DESC", OracleDbType.Varchar2,250),
					new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,250),
					new OracleParameter(":C_RH_CODE", OracleDbType.Varchar2,250),
					new OracleParameter(":C_RH_DESC", OracleDbType.Varchar2,250),
					new OracleParameter(":C_CC_ID", OracleDbType.Varchar2,250),
					new OracleParameter(":C_CC_CODE", OracleDbType.Varchar2,250),
					new OracleParameter(":C_CC_DESC", OracleDbType.Varchar2,250),
					new OracleParameter(":C_PLAN_SMS_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.PREHEATID;
			parameters[1].Value = model.HEATID;
			parameters[2].Value = model.LF_TREATNO;
			parameters[3].Value = model.RH_TREATNO;
			parameters[4].Value = model.CASTER_TREATNO;
			parameters[5].Value = model.ACT_TIME_IRONPREPARED;
			parameters[6].Value = model.ACT_TIME_BOFSTART;
			parameters[7].Value = model.ACT_TIME_BOFTAPPED;
			parameters[8].Value = model.ACT_TIME_TAPPEDSIDEEND;
			parameters[9].Value = model.ACT_TIME_LFARRIVAL;
			parameters[10].Value = model.ACT_TIME_LFSTART;
			parameters[11].Value = model.ACT_TIME_LFEND;
			parameters[12].Value = model.ACT_TIME_LFLEAVE;
			parameters[13].Value = model.ACT_TIME_RHARRIVAL;
			parameters[14].Value = model.ACT_TIME_RHSTART;
			parameters[15].Value = model.ACT_TIME_RHEND;
			parameters[16].Value = model.ACT_TIME_RHLEAVE;
			parameters[17].Value = model.ACT_TIME_CASTERARRIVAL;
			parameters[18].Value = model.ACT_TIME_CASTINGSTART;
			parameters[19].Value = model.ACT_TIME_CASTINGEND;
			parameters[20].Value = model.CREATEDATE;
			parameters[21].Value = model.C_ZL_ID;
			parameters[22].Value = model.C_ZL_CODE;
			parameters[23].Value = model.C_ZL_DESC;
			parameters[24].Value = model.C_LF_ID;
			parameters[25].Value = model.C_LF_CODE;
			parameters[26].Value = model.C_LF_DESC;
			parameters[27].Value = model.C_RH_ID;
			parameters[28].Value = model.C_RH_CODE;
			parameters[29].Value = model.C_RH_DESC;
			parameters[30].Value = model.C_CC_ID;
			parameters[31].Value = model.C_CC_CODE;
			parameters[32].Value = model.C_CC_DESC;
			parameters[33].Value = model.C_PLAN_SMS_ID;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TSC_STOVE_TIME ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Mod_TSC_STOVE_TIME GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PREHEATID,HEATID,LF_TREATNO,RH_TREATNO,CASTER_TREATNO,ACT_TIME_IRONPREPARED,ACT_TIME_BOFSTART,ACT_TIME_BOFTAPPED,ACT_TIME_TAPPEDSIDEEND,ACT_TIME_LFARRIVAL,ACT_TIME_LFSTART,ACT_TIME_LFEND,ACT_TIME_LFLEAVE,ACT_TIME_RHARRIVAL,ACT_TIME_RHSTART,ACT_TIME_RHEND,ACT_TIME_RHLEAVE,ACT_TIME_CASTERARRIVAL,ACT_TIME_CASTINGSTART,ACT_TIME_CASTINGEND,CREATEDATE,C_ZL_ID,C_ZL_CODE,C_ZL_DESC,C_LF_ID,C_LF_CODE,C_LF_DESC,C_RH_ID,C_RH_CODE,C_RH_DESC,C_CC_ID,C_CC_CODE,C_CC_DESC,C_PLAN_SMS_ID from TSC_STOVE_TIME ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Mod_TSC_STOVE_TIME model=new Mod_TSC_STOVE_TIME();
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
		public Mod_TSC_STOVE_TIME DataRowToModel(DataRow row)
		{
			Mod_TSC_STOVE_TIME model=new Mod_TSC_STOVE_TIME();
			if (row != null)
			{
				if(row["PREHEATID"]!=null)
				{
					model.PREHEATID=row["PREHEATID"].ToString();
				}
				if(row["HEATID"]!=null)
				{
					model.HEATID=row["HEATID"].ToString();
				}
				if(row["LF_TREATNO"]!=null)
				{
					model.LF_TREATNO=row["LF_TREATNO"].ToString();
				}
				if(row["RH_TREATNO"]!=null)
				{
					model.RH_TREATNO=row["RH_TREATNO"].ToString();
				}
				if(row["CASTER_TREATNO"]!=null)
				{
					model.CASTER_TREATNO=row["CASTER_TREATNO"].ToString();
				}
				if(row["ACT_TIME_IRONPREPARED"]!=null && row["ACT_TIME_IRONPREPARED"].ToString()!="")
				{
					model.ACT_TIME_IRONPREPARED=DateTime.Parse(row["ACT_TIME_IRONPREPARED"].ToString());
				}
				if(row["ACT_TIME_BOFSTART"]!=null && row["ACT_TIME_BOFSTART"].ToString()!="")
				{
					model.ACT_TIME_BOFSTART=DateTime.Parse(row["ACT_TIME_BOFSTART"].ToString());
				}
				if(row["ACT_TIME_BOFTAPPED"]!=null && row["ACT_TIME_BOFTAPPED"].ToString()!="")
				{
					model.ACT_TIME_BOFTAPPED=DateTime.Parse(row["ACT_TIME_BOFTAPPED"].ToString());
				}
				if(row["ACT_TIME_TAPPEDSIDEEND"]!=null && row["ACT_TIME_TAPPEDSIDEEND"].ToString()!="")
				{
					model.ACT_TIME_TAPPEDSIDEEND=DateTime.Parse(row["ACT_TIME_TAPPEDSIDEEND"].ToString());
				}
				if(row["ACT_TIME_LFARRIVAL"]!=null && row["ACT_TIME_LFARRIVAL"].ToString()!="")
				{
					model.ACT_TIME_LFARRIVAL=DateTime.Parse(row["ACT_TIME_LFARRIVAL"].ToString());
				}
				if(row["ACT_TIME_LFSTART"]!=null && row["ACT_TIME_LFSTART"].ToString()!="")
				{
					model.ACT_TIME_LFSTART=DateTime.Parse(row["ACT_TIME_LFSTART"].ToString());
				}
				if(row["ACT_TIME_LFEND"]!=null && row["ACT_TIME_LFEND"].ToString()!="")
				{
					model.ACT_TIME_LFEND=DateTime.Parse(row["ACT_TIME_LFEND"].ToString());
				}
				if(row["ACT_TIME_LFLEAVE"]!=null && row["ACT_TIME_LFLEAVE"].ToString()!="")
				{
					model.ACT_TIME_LFLEAVE=DateTime.Parse(row["ACT_TIME_LFLEAVE"].ToString());
				}
				if(row["ACT_TIME_RHARRIVAL"]!=null && row["ACT_TIME_RHARRIVAL"].ToString()!="")
				{
					model.ACT_TIME_RHARRIVAL=DateTime.Parse(row["ACT_TIME_RHARRIVAL"].ToString());
				}
				if(row["ACT_TIME_RHSTART"]!=null && row["ACT_TIME_RHSTART"].ToString()!="")
				{
					model.ACT_TIME_RHSTART=DateTime.Parse(row["ACT_TIME_RHSTART"].ToString());
				}
				if(row["ACT_TIME_RHEND"]!=null && row["ACT_TIME_RHEND"].ToString()!="")
				{
					model.ACT_TIME_RHEND=DateTime.Parse(row["ACT_TIME_RHEND"].ToString());
				}
				if(row["ACT_TIME_RHLEAVE"]!=null && row["ACT_TIME_RHLEAVE"].ToString()!="")
				{
					model.ACT_TIME_RHLEAVE=DateTime.Parse(row["ACT_TIME_RHLEAVE"].ToString());
				}
				if(row["ACT_TIME_CASTERARRIVAL"]!=null && row["ACT_TIME_CASTERARRIVAL"].ToString()!="")
				{
					model.ACT_TIME_CASTERARRIVAL=DateTime.Parse(row["ACT_TIME_CASTERARRIVAL"].ToString());
				}
				if(row["ACT_TIME_CASTINGSTART"]!=null && row["ACT_TIME_CASTINGSTART"].ToString()!="")
				{
					model.ACT_TIME_CASTINGSTART=DateTime.Parse(row["ACT_TIME_CASTINGSTART"].ToString());
				}
				if(row["ACT_TIME_CASTINGEND"]!=null && row["ACT_TIME_CASTINGEND"].ToString()!="")
				{
					model.ACT_TIME_CASTINGEND=DateTime.Parse(row["ACT_TIME_CASTINGEND"].ToString());
				}
				if(row["CREATEDATE"]!=null && row["CREATEDATE"].ToString()!="")
				{
					model.CREATEDATE=DateTime.Parse(row["CREATEDATE"].ToString());
				}
				if(row["C_ZL_ID"]!=null)
				{
					model.C_ZL_ID=row["C_ZL_ID"].ToString();
				}
				if(row["C_ZL_CODE"]!=null)
				{
					model.C_ZL_CODE=row["C_ZL_CODE"].ToString();
				}
				if(row["C_ZL_DESC"]!=null)
				{
					model.C_ZL_DESC=row["C_ZL_DESC"].ToString();
				}
				if(row["C_LF_ID"]!=null)
				{
					model.C_LF_ID=row["C_LF_ID"].ToString();
				}
				if(row["C_LF_CODE"]!=null)
				{
					model.C_LF_CODE=row["C_LF_CODE"].ToString();
				}
				if(row["C_LF_DESC"]!=null)
				{
					model.C_LF_DESC=row["C_LF_DESC"].ToString();
				}
				if(row["C_RH_ID"]!=null)
				{
					model.C_RH_ID=row["C_RH_ID"].ToString();
				}
				if(row["C_RH_CODE"]!=null)
				{
					model.C_RH_CODE=row["C_RH_CODE"].ToString();
				}
				if(row["C_RH_DESC"]!=null)
				{
					model.C_RH_DESC=row["C_RH_DESC"].ToString();
				}
				if(row["C_CC_ID"]!=null)
				{
					model.C_CC_ID=row["C_CC_ID"].ToString();
				}
				if(row["C_CC_CODE"]!=null)
				{
					model.C_CC_CODE=row["C_CC_CODE"].ToString();
				}
				if(row["C_CC_DESC"]!=null)
				{
					model.C_CC_DESC=row["C_CC_DESC"].ToString();
				}
				if(row["C_PLAN_SMS_ID"]!=null)
				{
					model.C_PLAN_SMS_ID=row["C_PLAN_SMS_ID"].ToString();
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
			strSql.Append("select PREHEATID,HEATID,LF_TREATNO,RH_TREATNO,CASTER_TREATNO,ACT_TIME_IRONPREPARED,ACT_TIME_BOFSTART,ACT_TIME_BOFTAPPED,ACT_TIME_TAPPEDSIDEEND,ACT_TIME_LFARRIVAL,ACT_TIME_LFSTART,ACT_TIME_LFEND,ACT_TIME_LFLEAVE,ACT_TIME_RHARRIVAL,ACT_TIME_RHSTART,ACT_TIME_RHEND,ACT_TIME_RHLEAVE,ACT_TIME_CASTERARRIVAL,ACT_TIME_CASTINGSTART,ACT_TIME_CASTINGEND,CREATEDATE,C_ZL_ID,C_ZL_CODE,C_ZL_DESC,C_LF_ID,C_LF_CODE,C_LF_DESC,C_RH_ID,C_RH_CODE,C_RH_DESC,C_CC_ID,C_CC_CODE,C_CC_DESC,C_PLAN_SMS_ID ");
			strSql.Append(" FROM TSC_STOVE_TIME ");
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
			strSql.Append("select count(1) FROM TSC_STOVE_TIME ");
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
        
        #endregion  BasicMethod


    }
}

