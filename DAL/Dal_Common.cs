using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class Dal_Common
    {
        public Dal_Common()
        { }

        /// <summary>
        /// 根据钢种、执行标准获取NC自由项1和自由项2信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>自由项信息</returns>
        public DataTable GetZYX(string C_STL_GRD, string C_STD_CODE)
        {
            string sql = @"SELECT CASE
         WHEN INSTR(BZ1, '协议') > 0 OR INSTR(BZ2, '普通要求') > 0 THEN
          BZ1
         ELSE
          BZ2
       END ZYX1,
       CASE
         WHEN INSTR(BZ2, '协议') > 0 OR INSTR(BZ1, '普通要求') > 0 THEN
          BZ1
         ELSE
          BZ2
       END ZYX2
  FROM(SELECT N.DOCNAME BZ1,
               CASE
                 WHEN INSTR('" + C_STD_CODE + "', 'JSKZ') > 0 THEN  '" + C_STL_GRD + "' || '~协议'     ELSE   '" + C_STL_GRD + "' || '~普通要求'               END BZ2          FROM XGERP50.BD_DEFDOCLIST@CAP_ERP M, XGERP50.BD_DEFDOC@CAP_ERP N      WHERE M.PK_DEFDOCLIST = N.PK_DEFDOCLIST           AND(N.SEALFLAG = 'N' OR N.SEALFLAG IS NULL)           AND N.DOCNAME LIKE '" + C_STL_GRD + "~%'           AND REPLACE(N.DOCNAME, ' ', '') LIKE '%" + C_STD_CODE + "')";

            return DbHelperOra.Query(sql.ToString()).Tables[0];

        }

        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="str_TableName">表面</param>
        /// <param name="C_ID">主键</param>
        /// <param name="C_EMP_ID">维护人</param>
        /// <param name="dtime">维护时间</param>
        /// <returns></returns>
		public bool DataDisabled(string str_TableName, string C_ID, string C_EMP_ID, DateTime dtime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update " + str_TableName + " set ");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = 0;
            parameters[1].Value = C_EMP_ID;
            parameters[2].Value = dtime;
            parameters[3].Value = C_ID;

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
        /// 查询是否有重复
        /// </summary>
        /// <param name="str">语句</param>
        /// <returns></returns>
        public int CheckTable(string str)
        {
            object obj = DbHelperOra.GetSingle(str);
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
        /// 获取条码库存信息
        /// </summary>
        public DataSet Get_TM_KCList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select T.CK AS TM_CK,T.WLH AS TM_WLH,T.WLMC AS TM_WLMC,T.GG AS TM_GG,T.PH AS TM_PH,t.PCH AS TM_PCH,(CASE T2.ZPDJBZ         WHEN '1' THEN 'DP' ELSE T.SX END) AS TM_SX,count(1) AS TM_COU,sum(T.ZL) AS TM_ZL,t.vfree1 AS TM_ZYX1,t.vfree2 AS TM_ZYX2,t.vfree3 AS TM_ZYX3  FROM WMS_BMS_INV_INFO T INNER JOIN WMS_BMS_REC_WGD T2 ON T.WGDH = T2.WGDH where T.CK is not null group by T.CK, T.WLH, T.WLMC, T.GG, T.PH, t.PCH, t.vfree1, t.vfree2, t.vfree3, (CASE T2.ZPDJBZ WHEN '1' THEN 'DP' ELSE T.SX END) ");
            return DbHelper_SQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取NC线材库存信息
        /// </summary>
        public DataSet Get_NC_KCList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select T.STORCODE AS NC_CK,T.批次号 AS NC_PCH,T.INVTYPE AS NC_PH,T.INVSPEC AS NC_GG,T.ccheckstatename AS NC_SX,T.数量 AS NC_WGT,T.辅数量 AS NC_COU,T.INVCODE AS NC_WLH,T.INVNAME AS NC_WLMC,T.VFREE1 AS NC_ZYX1,T.VFREE2 AS NC_ZYX2,T.VFREE3 AS NC_ZYX3 from XGERP50.V_ONHAND_XC t where T.批次号 like '3%' and T.STORCODE not like '7%' and T.STORCODE not like '680%' and T.STORCODE not like '671%' ");
            return DbHelperNC.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取CAP线材库存信息
        /// </summary>
        public DataSet Get_PCI_KCList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT T.C_LINEWH_CODE AS PCI_CK,T.C_BATCH_NO AS PCI_PCH,(T.C_SPEC||'mm')AS PCI_GG,COUNT(1)AS PCI_COU,SUM(T.N_WGT)AS PCI_WGT,T.C_STL_GRD AS PCI_PH,NVL(T.C_JUDGE_LEV_ZH,'DP') AS PCI_SX,T.C_MAT_CODE AS PCI_WLH,T.C_MAT_DESC AS PCI_WLMC,T.C_ZYX1 AS PCI_ZYX1,T.C_ZYX2 AS PCI_ZYX2,T.C_BZYQ AS PCI_ZYX3 FROM TRC_ROLL_PRODCUT T WHERE T.C_MOVE_TYPE='E' and t.C_BATCH_NO like '3%' GROUP BY T.C_LINEWH_CODE,T.C_BATCH_NO,T.C_STL_GRD,T.C_MAT_CODE,T.C_MAT_DESC,T.C_ZYX1,T.C_ZYX2,T.C_BZYQ,T.C_SPEC,NVL(T.C_JUDGE_LEV_ZH,'DP') ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取NC钢坯库存信息
        /// </summary>
        public DataSet Get_NC_Slab_KCList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select T.STORCODE AS NC_CK,decode(substr(T.批次号, 1, 1), '4', t.连铸炉号, t.批次号) as NC_STOVE,nvl(decode(substr(T.批次号, 1, 1), '4', t.批次号, ''),' ') as NC_BATCH_NO,T.INVTYPE AS NC_PH,replace(substr(T.INVSPEC, 1, instr(T.INVSPEC, '×', -1) - 1), 'mm', '') as NC_SLAB_SIZE,replace(substr(T.INVSPEC, instr(T.INVSPEC, '×', -1) + 1), 'm', '') * 1000 AS NC_LEN,T.ccheckstatename AS NC_SX,T.数量 AS NC_WGT,T.辅数量 AS NC_COU,T.INVCODE AS NC_WLH,T.INVNAME AS NC_WLMC,T.VFREE1 AS NC_ZYX1,T.VFREE2 AS NC_ZYX2,T.VFREE3 AS NC_ZYX3,T.生产入库日期 as 生产时间  from XGERP50.V_ONHAND t where t.批次号 not like '7%' ");
            return DbHelperNC.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取CAP钢坯库存信息
        /// </summary>
        public DataSet Get_PCI_Slab_KCList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select T.C_SLABWH_CODE AS PCI_CK,T.C_STOVE as PCI_STOVE,nvl(T.C_BATCH_NO,' ') as PCI_BATCH_NO,T.C_STL_GRD AS PCI_PH,replace(T.C_SPEC,'*','×') as PCI_SLAB_SIZE,T.N_LEN AS PCI_LEN,T.C_JUDGE_LEV_ZH AS PCI_SX,SUM(T.N_WGT) AS PCI_WGT,COUNT(1) AS PCI_COU,T.C_MAT_CODE AS PCI_WLH,T.C_MAT_NAME AS PCI_WLMC,T.C_ZYX1 AS PCI_ZYX1,T.C_ZYX2 AS PCI_ZYX2,to_char(max(t.d_ccm_date),'yyyy-mm-dd')as 生产时间  from TSC_SLAB_MAIN t where T.C_MOVE_TYPE = 'E' GROUP BY T.C_SLABWH_CODE, T.C_STOVE, T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_JUDGE_LEV_ZH, T.C_MAT_CODE, T.C_MAT_NAME, T.C_ZYX1, T.C_ZYX2 ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 更新一条数据_炉号
        /// </summary>
        public bool Update_Stove(string stove, string stlgrd, string matcode, string zyx1, string zyx2,string ckcode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN set ");
            strSql.Append("c_move_type ='S' ");
            strSql.Append("where C_STOVE='" + stove + "' and C_STL_GRD='" + stlgrd + "' and C_MAT_CODE='" + matcode + "' and C_ZYX1='" + zyx1 + "' and C_ZYX2='" + zyx2 + "' and c_move_type='E' and C_SLABWH_CODE='"+ ckcode + "' ");

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
        /// 返回数据库表清单及数据表字段说明
        /// </summary>
        /// <returns></returns>
        public DataTable bind()
        {

            DataTable dt = new DataTable("数据库表说明");//可以给表创建一个名字，datatable 
            //2.给表加个列名： 
            dt.Columns.Add("序号", typeof(System.String));
            dt.Columns.Add("字段名", typeof(System.String));
            dt.Columns.Add("字段说明", typeof(System.String));
            dt.Columns.Add("数据类型", typeof(System.String));
            dt.Columns.Add("数据长度", typeof(System.String));

            string sql = " SELECT A.TABLE_NAME 表名, A.COMMENTS 表备注  FROM USER_TAB_COMMENTS A, USER_TABLES B WHERE A.TABLE_NAME = B.TABLE_NAME AND NVL(B.NUM_ROWS, 0) > 0 ORDER BY A.TABLE_NAME";
            DataTable DT = DbHelperOra.Query(sql).Tables[0];
            if (DT.Rows.Count > 0)
            {
                DataRow row = dt.NewRow();
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    string name = DT.Rows[i]["表名"].ToString();
                    string dec = DT.Rows[i]["表备注"].ToString();

                    row = dt.NewRow();
                    row["序号"] = "";
                    row["字段名"] = "";
                    row["字段说明"] = "";
                    row["数据类型"] = "";
                    row["数据长度"] = "";
                    dt.Rows.Add(row);

                    row = dt.NewRow();
                    row["序号"] = "";
                    row["字段名"] = "表名:" + name;
                    row["字段说明"] = "表备注:" + dec;
                    row["数据类型"] = "";
                    row["数据长度"] = "";
                    dt.Rows.Add(row);

                    row = dt.NewRow();
                    row["序号"] = "序号";
                    row["字段名"] = "字段名";
                    row["字段说明"] = "字段说明";
                    row["数据类型"] = "数据类型";
                    row["数据长度"] = "数据长度";
                    dt.Rows.Add(row);

                    string sql2 = "  SELECT T.COLUMN_NAME 字段名, C.COMMENTS 字段说明, T.DATA_TYPE 数据类型, T.DATA_LENGTH 数据长度 FROM USER_TAB_COLUMNS T, USER_COL_COMMENTS C, USER_TAB_COMMENTS A, USER_TABLES B WHERE T.TABLE_NAME = C.TABLE_NAME AND T.COLUMN_NAME = C.COLUMN_NAME AND A.TABLE_NAME = B.TABLE_NAME AND T.TABLE_NAME = A.TABLE_NAME AND NVL(B.NUM_ROWS, 0) > 0 AND t.TABLE_NAME='" + name + "' ORDER BY T.TABLE_NAME ";
                    DataTable dt2 = DbHelperOra.Query(sql2).Tables[0];
                    if (dt2.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            row = dt.NewRow();
                            row["序号"] = (j + 1).ToString();
                            row["字段名"] = dt2.Rows[j]["字段名"].ToString();
                            row["字段说明"] = dt2.Rows[j]["字段说明"].ToString();
                            row["数据类型"] = dt2.Rows[j]["数据类型"].ToString();
                            row["数据长度"] = dt2.Rows[j]["数据长度"].ToString();
                            dt.Rows.Add(row);
                        }
                    }

                }
            }
            return dt;
        }

    }
}
