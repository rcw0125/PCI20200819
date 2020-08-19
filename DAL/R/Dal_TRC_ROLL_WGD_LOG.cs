using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_ROLL_WGD_LOG
    /// </summary>
    public partial class Dal_TRC_ROLL_WGD_LOG
    {
        public Dal_TRC_ROLL_WGD_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  TRC_ROLL_WGD_LOG  ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_WGD_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into  TRC_ROLL_WGD_LOG(");
            strSql.Append("C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_PRODUCE,N_WGT_PRODUCE,D_MOD_DT,C_ROLL_STATE,C_FUR_TYPE,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,D_PRODUCE_DATE,C_PRODUCE_EMP_ID,C_PRODUCE_SHIFT,C_PRODUCE_GROUP,C_SX,C_PCLX,C_MAIN_ID,C_SCX_NC,C_PACK,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_MRSX,D_PRODUCE_DATE_B,D_PRODUCE_DATE_E,C_MAT_CODE,C_MAT_DESC)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_PLANT,:C_STOVE,:C_BATCH_NO,:C_PLAN_ID,:N_QUA_PRODUCE,:N_WGT_PRODUCE,:D_MOD_DT,:C_ROLL_STATE,:C_FUR_TYPE,:C_REMARK,:N_STATUS,:C_STD_CODE,:C_STL_GRD,:C_SPEC,:D_PRODUCE_DATE,:C_PRODUCE_EMP_ID,:C_PRODUCE_SHIFT,:C_PRODUCE_GROUP,:C_SX,:C_PCLX,:C_MAIN_ID,:C_SCX_NC,:C_PACK,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_MRSX,:D_PRODUCE_DATE_B,:D_PRODUCE_DATE_E,:C_MAT_CODE,:C_MAT_DESC)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_PRODUCE", OracleDbType.Int32,15),
                    new OracleParameter(":N_WGT_PRODUCE", OracleDbType.Int32,15),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ROLL_STATE", OracleDbType.Int32,15),
                    new OracleParameter(":C_FUR_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Int32,15),
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
                        new OracleParameter(":C_MRSX", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PRODUCE_DATE_B", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_E", OracleDbType.Date),
                   new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100)};
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
            parameters[27].Value = model.C_MRSX;
            parameters[28].Value = model.D_PRODUCE_DATE_B;
            parameters[29].Value =  model.D_PRODUCE_DATE_E;
            parameters[30].Value = model.C_MAT_CODE;
            parameters[31].Value = model.C_MAT_DESC;

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
        public bool Update(Mod_TRC_ROLL_WGD_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update  TRC_ROLL_WGD_LOG set ");
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
            strSql.Append("D_PRODUCE_DATE_E=:D_PRODUCE_DATE_E");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_PRODUCE", OracleDbType.Int32,15),
                    new OracleParameter(":N_WGT_PRODUCE", OracleDbType.Int32,15),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ROLL_STATE", OracleDbType.Int32,15),
                    new OracleParameter(":C_FUR_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Int32,15),
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
                    new OracleParameter(":N_SCRF", OracleDbType.Int32,4),
                    new OracleParameter(":C_MRSX", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_PRODUCE_DATE_B", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_E", OracleDbType.Date),
                      new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
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
            parameters[34].Value = model.C_ID;

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
            strSql.Append("delete from  TRC_ROLL_WGD_LOG ");
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
            strSql.Append("delete from  TRC_ROLL_WGD_LOG ");
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
        public Mod_TRC_ROLL_WGD_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_PRODUCE,N_WGT_PRODUCE,D_MOD_DT,C_ROLL_STATE,C_FUR_TYPE,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,D_PRODUCE_DATE,C_PRODUCE_EMP_ID,C_PRODUCE_SHIFT,C_PRODUCE_GROUP,C_SX,C_PCLX,C_MAIN_ID,C_SCX_NC,C_PACK,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_ZPDJBZ,N_SCRF,C_MRSX,D_PRODUCE_DATE_B,D_PRODUCE_DATE_E,C_MAT_CODE,C_MAT_DESC from  TRC_ROLL_WGD_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_WGD_LOG model = new Mod_TRC_ROLL_WGD_LOG();
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
		public Mod_TRC_ROLL_WGD_LOG GetModel(string C_PLAN_ID, int type)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_PRODUCE,N_WGT_PRODUCE,D_MOD_DT,C_ROLL_STATE,C_FUR_TYPE,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,D_PRODUCE_DATE,C_PRODUCE_EMP_ID,C_PRODUCE_SHIFT,C_PRODUCE_GROUP,C_SX,C_PCLX,C_MAIN_ID,C_SCX_NC,C_PACK,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_ZPDJBZ,N_SCRF,C_MRSX,D_PRODUCE_DATE_B,D_PRODUCE_DATE_E,C_MAT_CODE,C_MAT_DESC from  TRC_ROLL_WGD_LOG ");
            strSql.Append(" where C_PLAN_ID=:C_PLAN_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_PLAN_ID;

            Mod_TRC_ROLL_WGD_LOG model = new Mod_TRC_ROLL_WGD_LOG();
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
        public Mod_TRC_ROLL_WGD_LOG DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_WGD_LOG model = new Mod_TRC_ROLL_WGD_LOG();
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_PLANT,C_STOVE,C_BATCH_NO,C_PLAN_ID,N_QUA_PRODUCE,N_WGT_PRODUCE,D_MOD_DT,C_ROLL_STATE,C_FUR_TYPE,C_REMARK,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,D_PRODUCE_DATE,C_PRODUCE_EMP_ID,C_PRODUCE_SHIFT,C_PRODUCE_GROUP,C_SX,C_PCLX,C_MAIN_ID,C_SCX_NC,C_PACK,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_ZPDJBZ,N_SCRF,C_MRSX,D_PRODUCE_DATE_B,D_PRODUCE_DATE_E,C_MAT_CODE,C_MAT_DESC ");
            strSql.Append(" FROM  TRC_ROLL_WGD_LOG ");
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
            strSql.Append("select count(1) FROM  TRC_ROLL_WGD_LOG ");
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
            strSql.Append(")AS Row, T.*  from  TRC_ROLL_WGD_LOG T ");
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_MAT_CODE_GP AS 物料编码, TB.C_MAT_NAME AS 物料名称, TB.C_STL_GRD AS 钢种, TB.C_SPEC AS 规格,       TC.C_STD_CODE AS 执行标准, TD.C_ZYX1 AS 自由项1, TD.C_ZYX2 AS 自由项2  FROM TQB_GP_LCP_BASIS TA INNER JOIN TB_MATRL_MAIN TB ON TA.C_MAT_CODE_GP = TB.C_MAT_CODE LEFT JOIN TQB_STD_MAIN TC ON TC.C_STL_GRD = TB.C_STL_GRD  LEFT JOIN TB_STD_CONFIG TD ON TD.C_STD_ID = TC.C_ID WHERE TA.N_STATUS = 1 AND NVL(TC.N_STATUS, 1) = 1 AND NVL(TD.N_STATUS, 1) = 1  ");

            if (C_MAT_CODE_PLAN.Trim() != "")
            {
                strSql.Append(" AND TA.C_MAT_CODE_PLAN = '" + C_MAT_CODE_PLAN + "'   AND  TC.C_STD_CODE  IS NOT NULL  AND    TD.C_ZYX1    IS NOT NULL   AND   TD.C_ZYX2   IS NOT NULL    ");
            }


            strSql.Append("  ORDER BY TA.C_MAT_CODE_GP ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新轧制状态
        /// </summary>
        /// <returns></returns>
        public bool UpdateRollStatus(string id)
        {
            string sql = @"UPDATE TRC_ROLL_MAIN TRM
                                    SET TRM.C_ROLL_STATE=1
                                    WHERE TRM.C_ID='" + id + "'";
            int row = DbHelperOra.ExecuteSql(sql);
            if (row > 0)
                return true;
            else
                return false;
        }

        #endregion  ExtensionMethod
    }
}

