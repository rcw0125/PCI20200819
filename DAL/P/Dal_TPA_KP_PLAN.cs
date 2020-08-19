using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPA_KP_PLAN
    /// </summary>
    public partial class Dal_TPA_KP_PLAN
	{
		public Dal_TPA_KP_PLAN()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPA_KP_PLAN");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPA_KP_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPA_KP_PLAN(");
			strSql.Append("C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,N_WGT,D_START_TIME,D_END_TIME,N_CN,D_PLAN_DATE,C_REMARK,N_STATUS,C_CCM,D_START_TIME_SJ,D_END_TIME_SJ,C_KP_CODE,N_SORT,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,N_SLAB_LENGTH,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,C_DHL,D_CAN_START_TIME,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_SLAB_SIZE)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_FK,:C_STOVE_NO,:C_STL_GRD,:C_STD_CODE,:N_WGT,:D_START_TIME,:D_END_TIME,:N_CN,:D_PLAN_DATE,:C_REMARK,:N_STATUS,:C_CCM,:D_START_TIME_SJ,:D_END_TIME_SJ,:C_KP_CODE,:N_SORT,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:N_SLAB_LENGTH,:N_SLAB_PW,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:C_DHL,:D_CAN_START_TIME,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:C_SLAB_SIZE)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_FK", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
					new OracleParameter(":D_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_END_TIME", OracleDbType.Date),
					new OracleParameter(":N_CN", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
					new OracleParameter(":C_CCM", OracleDbType.Varchar2,50),
					new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":C_KP_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
					new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
					new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
					new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
					new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
					new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
					new OracleParameter(":C_DHL", OracleDbType.Varchar2,50),
					new OracleParameter(":D_CAN_START_TIME", OracleDbType.Date),
					new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_FK;
			parameters[2].Value = model.C_STOVE_NO;
			parameters[3].Value = model.C_STL_GRD;
			parameters[4].Value = model.C_STD_CODE;
			parameters[5].Value = model.N_WGT;
			parameters[6].Value = model.D_START_TIME;
			parameters[7].Value = model.D_END_TIME;
			parameters[8].Value = model.N_CN;
			parameters[9].Value = model.D_PLAN_DATE;
			parameters[10].Value = model.C_REMARK;
			parameters[11].Value = model.N_STATUS;
			parameters[12].Value = model.C_CCM;
			parameters[13].Value = model.D_START_TIME_SJ;
			parameters[14].Value = model.D_END_TIME_SJ;
			parameters[15].Value = model.C_KP_CODE;
			parameters[16].Value = model.N_SORT;
			parameters[17].Value = model.C_MATRL_CODE_SLAB;
			parameters[18].Value = model.C_MATRL_NAME_SLAB;
			parameters[19].Value = model.N_SLAB_LENGTH;
			parameters[20].Value = model.N_SLAB_PW;
			parameters[21].Value = model.C_MATRL_CODE_KP;
			parameters[22].Value = model.C_MATRL_NAME_KP;
			parameters[23].Value = model.C_KP_SIZE;
			parameters[24].Value = model.N_KP_LENGTH;
			parameters[25].Value = model.N_KP_PW;
			parameters[26].Value = model.C_DHL;
			parameters[27].Value = model.D_CAN_START_TIME;
			parameters[28].Value = model.C_DFP_RZ;
			parameters[29].Value = model.C_RZP_RZ;
			parameters[30].Value = model.C_DFP_YQ;
			parameters[31].Value = model.C_RZP_YQ; 
            parameters[32].Value = model.C_SLAB_SIZE;

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
		/// 增加一条数据
		/// </summary>
		public bool TranAdd(Mod_TPA_KP_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPA_KP_PLAN(");
            strSql.Append("C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,N_WGT,D_START_TIME,D_END_TIME,N_CN,D_PLAN_DATE,C_REMARK,N_STATUS,C_CCM,D_START_TIME_SJ,D_END_TIME_SJ,C_KP_CODE,N_SORT,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,N_SLAB_LENGTH,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,C_DHL,D_CAN_START_TIME,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_SLAB_SIZE)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_FK,:C_STOVE_NO,:C_STL_GRD,:C_STD_CODE,:N_WGT,:D_START_TIME,:D_END_TIME,:N_CN,:D_PLAN_DATE,:C_REMARK,:N_STATUS,:C_CCM,:D_START_TIME_SJ,:D_END_TIME_SJ,:C_KP_CODE,:N_SORT,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:N_SLAB_LENGTH,:N_SLAB_PW,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:C_DHL,:D_CAN_START_TIME,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:C_SLAB_SIZE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_CN", OracleDbType.Decimal,10),
                    new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
                    new OracleParameter(":C_CCM", OracleDbType.Varchar2,50),
                    new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":C_KP_CODE", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":C_DHL", OracleDbType.Varchar2,50),
                    new OracleParameter(":D_CAN_START_TIME", OracleDbType.Date),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_FK;
            parameters[2].Value = model.C_STOVE_NO;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.N_WGT;
            parameters[6].Value = model.D_START_TIME;
            parameters[7].Value = model.D_END_TIME;
            parameters[8].Value = model.N_CN;
            parameters[9].Value = model.D_PLAN_DATE;
            parameters[10].Value = model.C_REMARK;
            parameters[11].Value = model.N_STATUS;
            parameters[12].Value = model.C_CCM;
            parameters[13].Value = model.D_START_TIME_SJ;
            parameters[14].Value = model.D_END_TIME_SJ;
            parameters[15].Value = model.C_KP_CODE;
            parameters[16].Value = model.N_SORT;
            parameters[17].Value = model.C_MATRL_CODE_SLAB;
            parameters[18].Value = model.C_MATRL_NAME_SLAB;
            parameters[19].Value = model.N_SLAB_LENGTH;
            parameters[20].Value = model.N_SLAB_PW;
            parameters[21].Value = model.C_MATRL_CODE_KP;
            parameters[22].Value = model.C_MATRL_NAME_KP;
            parameters[23].Value = model.C_KP_SIZE;
            parameters[24].Value = model.N_KP_LENGTH;
            parameters[25].Value = model.N_KP_PW;
            parameters[26].Value = model.C_DHL;
            parameters[27].Value = model.D_CAN_START_TIME;
            parameters[28].Value = model.C_DFP_RZ;
            parameters[29].Value = model.C_RZP_RZ;
            parameters[30].Value = model.C_DFP_YQ;
            parameters[31].Value = model.C_RZP_YQ;
            parameters[32].Value = model.C_SLAB_SIZE;
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
        public bool Update(Mod_TPA_KP_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPA_KP_PLAN set ");
			strSql.Append("C_FK=:C_FK,");
			strSql.Append("C_STOVE_NO=:C_STOVE_NO,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("N_WGT=:N_WGT,");
			strSql.Append("D_START_TIME=:D_START_TIME,");
			strSql.Append("D_END_TIME=:D_END_TIME,");
			strSql.Append("N_CN=:N_CN,");
			strSql.Append("D_PLAN_DATE=:D_PLAN_DATE,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_CCM=:C_CCM,");
			strSql.Append("D_START_TIME_SJ=:D_START_TIME_SJ,");
			strSql.Append("D_END_TIME_SJ=:D_END_TIME_SJ,");
			strSql.Append("C_KP_CODE=:C_KP_CODE,");
			strSql.Append("N_SORT=:N_SORT,");
			strSql.Append("C_MATRL_CODE_SLAB=:C_MATRL_CODE_SLAB,");
			strSql.Append("C_MATRL_NAME_SLAB=:C_MATRL_NAME_SLAB,");
			strSql.Append("N_SLAB_LENGTH=:N_SLAB_LENGTH,");
			strSql.Append("N_SLAB_PW=:N_SLAB_PW,");
			strSql.Append("C_MATRL_CODE_KP=:C_MATRL_CODE_KP,");
			strSql.Append("C_MATRL_NAME_KP=:C_MATRL_NAME_KP,");
			strSql.Append("C_KP_SIZE=:C_KP_SIZE,");
			strSql.Append("N_KP_LENGTH=:N_KP_LENGTH,");
			strSql.Append("N_KP_PW=:N_KP_PW,");
			strSql.Append("C_DHL=:C_DHL,");
			strSql.Append("D_CAN_START_TIME=:D_CAN_START_TIME,");
			strSql.Append("C_DFP_RZ=:C_DFP_RZ,");
			strSql.Append("C_RZP_RZ=:C_RZP_RZ,");
			strSql.Append("C_DFP_YQ=:C_DFP_YQ,");
			strSql.Append("C_RZP_YQ=:C_RZP_YQ,");
            strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE ");
            strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_FK", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
					new OracleParameter(":D_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_END_TIME", OracleDbType.Date),
					new OracleParameter(":N_CN", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
					new OracleParameter(":C_CCM", OracleDbType.Varchar2,50),
					new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":C_KP_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
					new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
					new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
					new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
					new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
					new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
					new OracleParameter(":C_DHL", OracleDbType.Varchar2,50),
					new OracleParameter(":D_CAN_START_TIME", OracleDbType.Date),
					new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
			parameters[0].Value = model.C_FK;
			parameters[1].Value = model.C_STOVE_NO;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_STD_CODE;
			parameters[4].Value = model.N_WGT;
			parameters[5].Value = model.D_START_TIME;
			parameters[6].Value = model.D_END_TIME;
			parameters[7].Value = model.N_CN;
			parameters[8].Value = model.D_PLAN_DATE;
			parameters[9].Value = model.C_REMARK;
			parameters[10].Value = model.N_STATUS;
			parameters[11].Value = model.C_CCM;
			parameters[12].Value = model.D_START_TIME_SJ;
			parameters[13].Value = model.D_END_TIME_SJ;
			parameters[14].Value = model.C_KP_CODE;
			parameters[15].Value = model.N_SORT;
			parameters[16].Value = model.C_MATRL_CODE_SLAB;
			parameters[17].Value = model.C_MATRL_NAME_SLAB;
			parameters[18].Value = model.N_SLAB_LENGTH;
			parameters[19].Value = model.N_SLAB_PW;
			parameters[20].Value = model.C_MATRL_CODE_KP;
			parameters[21].Value = model.C_MATRL_NAME_KP;
			parameters[22].Value = model.C_KP_SIZE;
			parameters[23].Value = model.N_KP_LENGTH;
			parameters[24].Value = model.N_KP_PW;
			parameters[25].Value = model.C_DHL;
			parameters[26].Value = model.D_CAN_START_TIME;
			parameters[27].Value = model.C_DFP_RZ;
			parameters[28].Value = model.C_RZP_RZ;
			parameters[29].Value = model.C_DFP_YQ;
			parameters[30].Value = model.C_RZP_YQ;
            parameters[31].Value = model.C_SLAB_SIZE; 
             parameters[32].Value = model.C_ID;

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
			strSql.Append("delete from TPA_KP_PLAN ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
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
        /// 根据浇次主键删除对应的工序计划
        /// </summary>
        /// <param name="C_FK">浇次主键</param>
        /// <returns></returns>

            StringBuilder strSql = new StringBuilder();
        public bool DeleteByJcID(string C_FK)
        {
            strSql.Append("delete from TPA_KP_PLAN ");
            strSql.Append(" where C_FK=:C_FK ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,50)          };
            parameters[0].Value = C_FK;

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
        public bool DeleteList(string C_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPA_KP_PLAN ");
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
		public Mod_TPA_KP_PLAN GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,N_WGT,D_START_TIME,D_END_TIME,N_CN,D_PLAN_DATE,C_REMARK,N_STATUS,C_CCM,D_START_TIME_SJ,D_END_TIME_SJ,C_KP_CODE,N_SORT,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,N_SLAB_LENGTH,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,C_DHL,D_CAN_START_TIME,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_SLAB_SIZE from TPA_KP_PLAN ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			Mod_TPA_KP_PLAN model=new Mod_TPA_KP_PLAN();
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
		public Mod_TPA_KP_PLAN DataRowToModel(DataRow row)
		{
			Mod_TPA_KP_PLAN model=new Mod_TPA_KP_PLAN();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_FK"]!=null)
				{
					model.C_FK=row["C_FK"].ToString();
				}
				if(row["C_STOVE_NO"]!=null)
				{
					model.C_STOVE_NO=row["C_STOVE_NO"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["N_WGT"]!=null && row["N_WGT"].ToString()!="")
				{
					model.N_WGT=decimal.Parse(row["N_WGT"].ToString());
				}
				if(row["D_START_TIME"]!=null && row["D_START_TIME"].ToString()!="")
				{
					model.D_START_TIME=DateTime.Parse(row["D_START_TIME"].ToString());
				}
				if(row["D_END_TIME"]!=null && row["D_END_TIME"].ToString()!="")
				{
					model.D_END_TIME=DateTime.Parse(row["D_END_TIME"].ToString());
				}
				if(row["N_CN"]!=null && row["N_CN"].ToString()!="")
				{
					model.N_CN=decimal.Parse(row["N_CN"].ToString());
				}
				if(row["D_PLAN_DATE"]!=null && row["D_PLAN_DATE"].ToString()!="")
				{
					model.D_PLAN_DATE=DateTime.Parse(row["D_PLAN_DATE"].ToString());
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["C_CCM"]!=null)
				{
					model.C_CCM=row["C_CCM"].ToString();
				}
				if(row["D_START_TIME_SJ"]!=null && row["D_START_TIME_SJ"].ToString()!="")
				{
					model.D_START_TIME_SJ=DateTime.Parse(row["D_START_TIME_SJ"].ToString());
				}
				if(row["D_END_TIME_SJ"]!=null && row["D_END_TIME_SJ"].ToString()!="")
				{
					model.D_END_TIME_SJ=DateTime.Parse(row["D_END_TIME_SJ"].ToString());
				}
				if(row["C_KP_CODE"]!=null)
				{
					model.C_KP_CODE=row["C_KP_CODE"].ToString();
				}
				if(row["N_SORT"]!=null && row["N_SORT"].ToString()!="")
				{
					model.N_SORT=decimal.Parse(row["N_SORT"].ToString());
				}
				if(row["C_MATRL_CODE_SLAB"]!=null)
				{
					model.C_MATRL_CODE_SLAB=row["C_MATRL_CODE_SLAB"].ToString();
				}
				if(row["C_MATRL_NAME_SLAB"]!=null)
				{
					model.C_MATRL_NAME_SLAB=row["C_MATRL_NAME_SLAB"].ToString();
				}
				if(row["N_SLAB_LENGTH"]!=null && row["N_SLAB_LENGTH"].ToString()!="")
				{
					model.N_SLAB_LENGTH=decimal.Parse(row["N_SLAB_LENGTH"].ToString());
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
				if(row["C_DHL"]!=null)
				{
					model.C_DHL=row["C_DHL"].ToString();
				}
				if(row["D_CAN_START_TIME"]!=null && row["D_CAN_START_TIME"].ToString()!="")
				{
					model.D_CAN_START_TIME=DateTime.Parse(row["D_CAN_START_TIME"].ToString());
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
                if (row["C_SLAB_SIZE"] != null)
                {
                    model.C_RZP_YQ = row["C_SLAB_SIZE"].ToString();
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
			strSql.Append("select C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,N_WGT,D_START_TIME,D_END_TIME,N_CN,D_PLAN_DATE,C_REMARK,N_STATUS,C_CCM,D_START_TIME_SJ,D_END_TIME_SJ,C_KP_CODE,N_SORT,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,N_SLAB_LENGTH,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,C_DHL,D_CAN_START_TIME,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_SLAB_SIZE ");
			strSql.Append(" FROM TPA_KP_PLAN ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where 1=1  "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TPA_KP_PLAN ");
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
			strSql.Append(")AS Row, T.*  from TPA_KP_PLAN T ");
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
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TPA_KP_PLAN";
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

