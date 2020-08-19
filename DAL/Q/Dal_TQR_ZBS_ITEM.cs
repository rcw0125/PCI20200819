using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQR_ZBS_ITEM
    /// </summary>
    public partial class Dal_TQR_ZBS_ITEM
    {
        public Dal_TQR_ZBS_ITEM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQR_ZBS_ITEM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQR_ZBS_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQR_ZBS_ITEM(");
            strSql.Append("C_BATCH_NO,C_STOVE,C_SPEC,C_STL_GRD,C_STD_CODE,C_CF1,C_CF2,C_CF3,C_CF4,C_CF5,C_CF6,C_CF7,C_CF8,C_CF9,C_CF10,C_CF11,C_CF12,C_XN01,C_XN02,C_XN03,C_XN04,C_XN05,C_XN06,C_XN07,C_XN08,C_XN09,C_XN10,C_XN11,C_XN12,C_XN13,C_XN14,C_XN15,C_XN16,C_XN17,C_XN18,C_XN19,C_XN20,C_XN21,C_XN22,C_XN23,C_XN24,C_XN25,N_ORDER)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:C_STOVE,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:C_CF1,:C_CF2,:C_CF3,:C_CF4,:C_CF5,:C_CF6,:C_CF7,:C_CF8,:C_CF9,:C_CF10,:C_CF11,:C_CF12,:C_XN01,:C_XN02,:C_XN03,:C_XN04,:C_XN05,:C_XN06,:C_XN07,:C_XN08,:C_XN09,:C_XN10,:C_XN11,:C_XN12,:C_XN13,:C_XN14,:C_XN15,:C_XN16,:C_XN17,:C_XN18,:C_XN19,:C_XN20,:C_XN21,:C_XN22,:C_XN23,:C_XN24,:C_XN25,:N_ORDER)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CF1", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF2", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF3", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF4", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF5", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF6", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF7", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF8", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF9", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF10", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF11", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF12", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN01", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN02", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN03", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN04", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN05", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN06", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN07", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN08", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN09", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN10", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN11", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN12", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN13", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN14", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN15", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN16", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN17", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN18", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN19", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN20", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN21", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN22", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN23", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN24", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN25", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,5)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_SPEC;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_CF1;
            parameters[6].Value = model.C_CF2;
            parameters[7].Value = model.C_CF3;
            parameters[8].Value = model.C_CF4;
            parameters[9].Value = model.C_CF5;
            parameters[10].Value = model.C_CF6;
            parameters[11].Value = model.C_CF7;
            parameters[12].Value = model.C_CF8;
            parameters[13].Value = model.C_CF9;
            parameters[14].Value = model.C_CF10;
            parameters[15].Value = model.C_CF11;
            parameters[16].Value = model.C_CF12;
            parameters[17].Value = model.C_XN01;
            parameters[18].Value = model.C_XN02;
            parameters[19].Value = model.C_XN03;
            parameters[20].Value = model.C_XN04;
            parameters[21].Value = model.C_XN05;
            parameters[22].Value = model.C_XN06;
            parameters[23].Value = model.C_XN07;
            parameters[24].Value = model.C_XN08;
            parameters[25].Value = model.C_XN09;
            parameters[26].Value = model.C_XN10;
            parameters[27].Value = model.C_XN11;
            parameters[28].Value = model.C_XN12;
            parameters[29].Value = model.C_XN13;
            parameters[30].Value = model.C_XN14;
            parameters[31].Value = model.C_XN15;
            parameters[32].Value = model.C_XN16;
            parameters[33].Value = model.C_XN17;
            parameters[34].Value = model.C_XN18;
            parameters[35].Value = model.C_XN19;
            parameters[36].Value = model.C_XN20;
            parameters[37].Value = model.C_XN21;
            parameters[38].Value = model.C_XN22;
            parameters[39].Value = model.C_XN23;
            parameters[40].Value = model.C_XN24;
            parameters[41].Value = model.C_XN25;
            parameters[42].Value = model.N_ORDER;

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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TQR_ZBS_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQR_ZBS_ITEM(");
            strSql.Append("C_BATCH_NO,C_STOVE,C_SPEC,C_STL_GRD,C_STD_CODE,C_CF1,C_CF2,C_CF3,C_CF4,C_CF5,C_CF6,C_CF7,C_CF8,C_CF9,C_CF10,C_CF11,C_CF12,C_XN01,C_XN02,C_XN03,C_XN04,C_XN05,C_XN06,C_XN07,C_XN08,C_XN09,C_XN10,C_XN11,C_XN12,C_XN13,C_XN14,C_XN15,C_XN16,C_XN17,C_XN18,C_XN19,C_XN20,C_XN21,C_XN22,C_XN23,C_XN24,C_XN25,N_ORDER)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:C_STOVE,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:C_CF1,:C_CF2,:C_CF3,:C_CF4,:C_CF5,:C_CF6,:C_CF7,:C_CF8,:C_CF9,:C_CF10,:C_CF11,:C_CF12,:C_XN01,:C_XN02,:C_XN03,:C_XN04,:C_XN05,:C_XN06,:C_XN07,:C_XN08,:C_XN09,:C_XN10,:C_XN11,:C_XN12,:C_XN13,:C_XN14,:C_XN15,:C_XN16,:C_XN17,:C_XN18,:C_XN19,:C_XN20,:C_XN21,:C_XN22,:C_XN23,:C_XN24,:C_XN25,:N_ORDER)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CF1", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF2", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF3", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF4", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF5", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF6", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF7", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF8", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF9", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF10", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF11", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF12", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN01", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN02", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN03", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN04", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN05", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN06", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN07", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN08", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN09", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN10", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN11", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN12", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN13", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN14", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN15", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN16", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN17", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN18", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN19", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN20", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN21", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN22", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN23", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN24", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN25", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,5)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_SPEC;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_CF1;
            parameters[6].Value = model.C_CF2;
            parameters[7].Value = model.C_CF3;
            parameters[8].Value = model.C_CF4;
            parameters[9].Value = model.C_CF5;
            parameters[10].Value = model.C_CF6;
            parameters[11].Value = model.C_CF7;
            parameters[12].Value = model.C_CF8;
            parameters[13].Value = model.C_CF9;
            parameters[14].Value = model.C_CF10;
            parameters[15].Value = model.C_CF11;
            parameters[16].Value = model.C_CF12;
            parameters[17].Value = model.C_XN01;
            parameters[18].Value = model.C_XN02;
            parameters[19].Value = model.C_XN03;
            parameters[20].Value = model.C_XN04;
            parameters[21].Value = model.C_XN05;
            parameters[22].Value = model.C_XN06;
            parameters[23].Value = model.C_XN07;
            parameters[24].Value = model.C_XN08;
            parameters[25].Value = model.C_XN09;
            parameters[26].Value = model.C_XN10;
            parameters[27].Value = model.C_XN11;
            parameters[28].Value = model.C_XN12;
            parameters[29].Value = model.C_XN13;
            parameters[30].Value = model.C_XN14;
            parameters[31].Value = model.C_XN15;
            parameters[32].Value = model.C_XN16;
            parameters[33].Value = model.C_XN17;
            parameters[34].Value = model.C_XN18;
            parameters[35].Value = model.C_XN19;
            parameters[36].Value = model.C_XN20;
            parameters[37].Value = model.C_XN21;
            parameters[38].Value = model.C_XN22;
            parameters[39].Value = model.C_XN23;
            parameters[40].Value = model.C_XN24;
            parameters[41].Value = model.C_XN25;
            parameters[42].Value = model.N_ORDER;

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
        public bool Update(Mod_TQR_ZBS_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQR_ZBS_ITEM set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_CF1=:C_CF1,");
            strSql.Append("C_CF2=:C_CF2,");
            strSql.Append("C_CF3=:C_CF3,");
            strSql.Append("C_CF4=:C_CF4,");
            strSql.Append("C_CF5=:C_CF5,");
            strSql.Append("C_CF6=:C_CF6,");
            strSql.Append("C_CF7=:C_CF7,");
            strSql.Append("C_CF8=:C_CF8,");
            strSql.Append("C_CF9=:C_CF9,");
            strSql.Append("C_CF10=:C_CF10,");
            strSql.Append("C_CF11=:C_CF11,");
            strSql.Append("C_CF12=:C_CF12,");
            strSql.Append("C_XN01=:C_XN01,");
            strSql.Append("C_XN02=:C_XN02,");
            strSql.Append("C_XN03=:C_XN03,");
            strSql.Append("C_XN04=:C_XN04,");
            strSql.Append("C_XN05=:C_XN05,");
            strSql.Append("C_XN06=:C_XN06,");
            strSql.Append("C_XN07=:C_XN07,");
            strSql.Append("C_XN08=:C_XN08,");
            strSql.Append("C_XN09=:C_XN09,");
            strSql.Append("C_XN10=:C_XN10,");
            strSql.Append("C_XN11=:C_XN11,");
            strSql.Append("C_XN12=:C_XN12,");
            strSql.Append("C_XN13=:C_XN13,");
            strSql.Append("C_XN14=:C_XN14,");
            strSql.Append("C_XN15=:C_XN15,");
            strSql.Append("C_XN16=:C_XN16,");
            strSql.Append("C_XN17=:C_XN17,");
            strSql.Append("C_XN18=:C_XN18,");
            strSql.Append("C_XN19=:C_XN19,");
            strSql.Append("C_XN20=:C_XN20,");
            strSql.Append("C_XN21=:C_XN21,");
            strSql.Append("C_XN22=:C_XN22,");
            strSql.Append("C_XN23=:C_XN23,");
            strSql.Append("C_XN24=:C_XN24,");
            strSql.Append("C_XN25=:C_XN25,");
            strSql.Append("N_ORDER=:N_ORDER");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CF1", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF2", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF3", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF4", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF5", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF6", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF7", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF8", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF9", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF10", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF11", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_CF12", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN01", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN02", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN03", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN04", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN05", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN06", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN07", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN08", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN09", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN10", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN11", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN12", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN13", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN14", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN15", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN16", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN17", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN18", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN19", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN20", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN21", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN22", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN23", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN24", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XN25", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_SPEC;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_CF1;
            parameters[6].Value = model.C_CF2;
            parameters[7].Value = model.C_CF3;
            parameters[8].Value = model.C_CF4;
            parameters[9].Value = model.C_CF5;
            parameters[10].Value = model.C_CF6;
            parameters[11].Value = model.C_CF7;
            parameters[12].Value = model.C_CF8;
            parameters[13].Value = model.C_CF9;
            parameters[14].Value = model.C_CF10;
            parameters[15].Value = model.C_CF11;
            parameters[16].Value = model.C_CF12;
            parameters[17].Value = model.C_XN01;
            parameters[18].Value = model.C_XN02;
            parameters[19].Value = model.C_XN03;
            parameters[20].Value = model.C_XN04;
            parameters[21].Value = model.C_XN05;
            parameters[22].Value = model.C_XN06;
            parameters[23].Value = model.C_XN07;
            parameters[24].Value = model.C_XN08;
            parameters[25].Value = model.C_XN09;
            parameters[26].Value = model.C_XN10;
            parameters[27].Value = model.C_XN11;
            parameters[28].Value = model.C_XN12;
            parameters[29].Value = model.C_XN13;
            parameters[30].Value = model.C_XN14;
            parameters[31].Value = model.C_XN15;
            parameters[32].Value = model.C_XN16;
            parameters[33].Value = model.C_XN17;
            parameters[34].Value = model.C_XN18;
            parameters[35].Value = model.C_XN19;
            parameters[36].Value = model.C_XN20;
            parameters[37].Value = model.C_XN21;
            parameters[38].Value = model.C_XN22;
            parameters[39].Value = model.C_XN23;
            parameters[40].Value = model.C_XN24;
            parameters[41].Value = model.C_XN25;
            parameters[42].Value = model.N_ORDER;
            parameters[43].Value = model.C_ID;

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
            strSql.Append("delete from TQR_ZBS_ITEM ");
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
            strSql.Append("delete from TQR_ZBS_ITEM ");
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
        public Mod_TQR_ZBS_ITEM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_STOVE,C_SPEC,C_STL_GRD,C_STD_CODE,C_CF1,C_CF2,C_CF3,C_CF4,C_CF5,C_CF6,C_CF7,C_CF8,C_CF9,C_CF10,C_CF11,C_CF12,C_XN01,C_XN02,C_XN03,C_XN04,C_XN05,C_XN06,C_XN07,C_XN08,C_XN09,C_XN10,C_XN11,C_XN12,C_XN13,C_XN14,C_XN15,C_XN16,C_XN17,C_XN18,C_XN19,C_XN20,C_XN21,C_XN22,C_XN23,C_XN24,C_XN25,N_ORDER from TQR_ZBS_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TQR_ZBS_ITEM model = new Mod_TQR_ZBS_ITEM();
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
        public Mod_TQR_ZBS_ITEM DataRowToModel(DataRow row)
        {
            Mod_TQR_ZBS_ITEM model = new Mod_TQR_ZBS_ITEM();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_CF1"] != null)
                {
                    model.C_CF1 = row["C_CF1"].ToString();
                }
                if (row["C_CF2"] != null)
                {
                    model.C_CF2 = row["C_CF2"].ToString();
                }
                if (row["C_CF3"] != null)
                {
                    model.C_CF3 = row["C_CF3"].ToString();
                }
                if (row["C_CF4"] != null)
                {
                    model.C_CF4 = row["C_CF4"].ToString();
                }
                if (row["C_CF5"] != null)
                {
                    model.C_CF5 = row["C_CF5"].ToString();
                }
                if (row["C_CF6"] != null)
                {
                    model.C_CF6 = row["C_CF6"].ToString();
                }
                if (row["C_CF7"] != null)
                {
                    model.C_CF7 = row["C_CF7"].ToString();
                }
                if (row["C_CF8"] != null)
                {
                    model.C_CF8 = row["C_CF8"].ToString();
                }
                if (row["C_CF9"] != null)
                {
                    model.C_CF9 = row["C_CF9"].ToString();
                }
                if (row["C_CF10"] != null)
                {
                    model.C_CF10 = row["C_CF10"].ToString();
                }
                if (row["C_CF11"] != null)
                {
                    model.C_CF11 = row["C_CF11"].ToString();
                }
                if (row["C_CF12"] != null)
                {
                    model.C_CF12 = row["C_CF12"].ToString();
                }
                if (row["C_XN01"] != null)
                {
                    model.C_XN01 = row["C_XN01"].ToString();
                }
                if (row["C_XN02"] != null)
                {
                    model.C_XN02 = row["C_XN02"].ToString();
                }
                if (row["C_XN03"] != null)
                {
                    model.C_XN03 = row["C_XN03"].ToString();
                }
                if (row["C_XN04"] != null)
                {
                    model.C_XN04 = row["C_XN04"].ToString();
                }
                if (row["C_XN05"] != null)
                {
                    model.C_XN05 = row["C_XN05"].ToString();
                }
                if (row["C_XN06"] != null)
                {
                    model.C_XN06 = row["C_XN06"].ToString();
                }
                if (row["C_XN07"] != null)
                {
                    model.C_XN07 = row["C_XN07"].ToString();
                }
                if (row["C_XN08"] != null)
                {
                    model.C_XN08 = row["C_XN08"].ToString();
                }
                if (row["C_XN09"] != null)
                {
                    model.C_XN09 = row["C_XN09"].ToString();
                }
                if (row["C_XN10"] != null)
                {
                    model.C_XN10 = row["C_XN10"].ToString();
                }
                if (row["C_XN11"] != null)
                {
                    model.C_XN11 = row["C_XN11"].ToString();
                }
                if (row["C_XN12"] != null)
                {
                    model.C_XN12 = row["C_XN12"].ToString();
                }
                if (row["C_XN13"] != null)
                {
                    model.C_XN13 = row["C_XN13"].ToString();
                }
                if (row["C_XN14"] != null)
                {
                    model.C_XN14 = row["C_XN14"].ToString();
                }
                if (row["C_XN15"] != null)
                {
                    model.C_XN15 = row["C_XN15"].ToString();
                }
                if (row["C_XN16"] != null)
                {
                    model.C_XN16 = row["C_XN16"].ToString();
                }
                if (row["C_XN17"] != null)
                {
                    model.C_XN17 = row["C_XN17"].ToString();
                }
                if (row["C_XN18"] != null)
                {
                    model.C_XN18 = row["C_XN18"].ToString();
                }
                if (row["C_XN19"] != null)
                {
                    model.C_XN19 = row["C_XN19"].ToString();
                }
                if (row["C_XN20"] != null)
                {
                    model.C_XN20 = row["C_XN20"].ToString();
                }
                if (row["C_XN21"] != null)
                {
                    model.C_XN21 = row["C_XN21"].ToString();
                }
                if (row["C_XN22"] != null)
                {
                    model.C_XN22 = row["C_XN22"].ToString();
                }
                if (row["C_XN23"] != null)
                {
                    model.C_XN23 = row["C_XN23"].ToString();
                }
                if (row["C_XN24"] != null)
                {
                    model.C_XN24 = row["C_XN24"].ToString();
                }
                if (row["C_XN25"] != null)
                {
                    model.C_XN25 = row["C_XN25"].ToString();
                }
                if (row["N_ORDER"] != null && row["N_ORDER"].ToString() != "")
                {
                    model.N_ORDER = decimal.Parse(row["N_ORDER"].ToString());
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
            strSql.Append("select C_ID,C_BATCH_NO,C_STOVE,C_SPEC,C_STL_GRD,C_STD_CODE,C_CF1,C_CF2,C_CF3,C_CF4,C_CF5,C_CF6,C_CF7,C_CF8,C_CF9,C_CF10,C_CF11,C_CF12,C_XN01,C_XN02,C_XN03,C_XN04,C_XN05,C_XN06,C_XN07,C_XN08,C_XN09,C_XN10,C_XN11,C_XN12,C_XN13,C_XN14,C_XN15,C_XN16,C_XN17,C_XN18,C_XN19,C_XN20,C_XN21,C_XN22,C_XN23,C_XN24,C_XN25,N_ORDER ");
            strSql.Append(" FROM TQR_ZBS_ITEM ");
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
            strSql.Append("select count(1) FROM TQR_ZBS_ITEM ");
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

        #endregion  BasicMethod

    }
}

