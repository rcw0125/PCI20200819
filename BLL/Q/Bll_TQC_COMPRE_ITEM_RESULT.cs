using System;
using System.Data;
using System.Collections.Generic;
using MODEL;
using DAL;
namespace BLL
{
    /// <summary>
    /// 综合判定项目结果明细
    /// </summary>
    public partial class Bll_TQC_COMPRE_ITEM_RESULT
    {
        private readonly Dal_TQC_COMPRE_ITEM_RESULT dal = new Dal_TQC_COMPRE_ITEM_RESULT();
        public Bll_TQC_COMPRE_ITEM_RESULT()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            return dal.Exists(C_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_COMPRE_ITEM_RESULT model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_COMPRE_ITEM_RESULT model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            return dal.Delete(C_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            return dal.DeleteList(C_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQC_COMPRE_ITEM_RESULT GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN(string Begin, string End, string strStove, string strBatchNo, string strSTLGRD, string strSTDCode)
        {
            return dal.GetList_CFXN(Begin, End, strStove, strBatchNo, strSTLGRD, strSTDCode);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <returns></returns>
        public DataSet GetList_Stove(string C_HTH, string C_STOVE, string strSTLGRD, string strSTDCode)
        {
            return dal.GetList_Stove(C_HTH, C_STOVE, strSTLGRD, strSTDCode);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CF(DateTime Begin, DateTime End, string C_STOVE, string strSTLGRD, string strSTDCode)
        {
            return dal.GetList_CF(Begin, End, C_STOVE, strSTLGRD, strSTDCode);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetList_CF_Name()
        {
            return dal.GetList_CF_Name();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CK_CF(string C_STOVE)
        {
            return dal.GetList_CK_CF(C_STOVE);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_CKC(string strBatchNo)
        {
            return dal.GetList_CFXN_CKC(strBatchNo);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_Item_CKC(string strBatchNo, string strSTLGRD, string strSTDCode, string strHTH)
        {
            return dal.GetList_CFXN_Item_CKC(strBatchNo, strSTLGRD, strSTDCode, strHTH);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_Item(string Begin, string End, string strStove, string strBatchNo, string strSTLGRD, string strSTDCode)
        {
            return dal.GetList_CFXN_Item(Begin, End, strStove, strBatchNo, strSTLGRD, strSTDCode);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CF_Item(DateTime Begin, DateTime End, string strStove, string strSTLGRD, string strSTDCode)
        {
            return dal.GetList_CF_Item(Begin, End, strStove, strSTLGRD, strSTDCode);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_XC(DateTime Begin, DateTime End, string strStove, string strSTLGRD, string strBatch)
        {
            return dal.GetList_XC(Begin, End, strStove, strSTLGRD, strBatch);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CK_CF_Item(string strStove)
        {
            return dal.GetList_CK_CF_Item(strStove);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_Value(string Begin, string End, string strStove, string strBatchNo, string strSTLGRD, string strSTDCode)
        {
            return dal.GetList_CFXN_Value(Begin, End, strStove, strBatchNo, strSTLGRD, strSTDCode);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CF_Value(DateTime Begin, DateTime End, string strStove, string strSTLGRD, string strSTDCode)
        {
            return dal.GetList_CF_Value(Begin, End, strStove, strSTLGRD, strSTDCode);
        }

        /// <summary>
        /// 获得成分原始值
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CF_YSZ_Value()
        {
            return dal.GetList_CF_YSZ_Value();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CK_CF_Value(string strStove)
        {
            return dal.GetList_CK_CF_Value(strStove);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_Value_CKC(string strBatchNo)
        {
            return dal.GetList_CFXN_Value_CKC(strBatchNo);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 获取成分列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strStdCode">执行标准</param>
        /// <returns></returns>
        public DataSet GetListCF(string strStove, string strGrd, string strSpec, string strStdCode)
        {
            return dal.GetListCF(strStove, strGrd, strSpec, strStdCode);
        }

        /// <summary>
        /// 获取成分列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strStdCode">执行标准</param>
        /// <param name="strBatch">批号</param>
        /// <returns></returns>
        public DataSet GetListCF(string strStove, string strGrd, string strSpec, string strStdCode, string strBatch)
        {
            return dal.GetListCF(strStove, strGrd, strSpec, strStdCode, strBatch);
        }

        /// <summary>
        /// 获取性能列表
        /// </summary>
        /// <param name="strBatch">批号</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strStdCode">执行标准</param>
        /// <returns></returns>
        public DataSet GetListXN(string strBatch, string strGrd, string strSpec, string strStdCode)
        {
            return dal.GetListXN(strBatch, strGrd, strSpec, strStdCode);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQC_COMPRE_ITEM_RESULT GetModel(string c_batch_no, string c_stl_grd, string c_std_code)
        {
            return dal.GetModel(c_batch_no, c_stl_grd, c_std_code);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int Get_Max_Group(string c_batch_no, string c_stove, string c_stl_grd, string c_std_code, string c_character_id)
        {
            return dal.Get_Max_Group(c_batch_no, c_stove, c_stl_grd, c_std_code, c_character_id);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 分组获取数据
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="C_IS_QR">综判是否确认</param>
        /// <returns></returns>
        public DataSet GetList_Group(DateTime begin, DateTime end, string c_stove, string c_batch_no, string C_IS_QR)
        {
            return dal.GetList_Group(begin, end, c_stove, c_batch_no, C_IS_QR);
        }
        /// <summary>
        /// 获取项目名称
        /// </summary>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <returns></returns>
        public DataSet GetList_ItemName(string c_stove, string c_batch_no)
        {
            return dal.GetList_ItemName(c_stove, c_batch_no);
        }
        /// <summary>
        /// 获取项目名称
        /// </summary>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <returns></returns>
        public DataSet Get_Item(string c_stove, string c_batch_no, string code)
        {
            return dal.Get_Item(c_stove, c_batch_no, code);
        }

        /// <summary>
        /// 获取NC成分性能信息（碳钢或者深加工产品编码为807、806开头）
        /// </summary>
        /// <param name="strBatch">批号</param>
        /// <returns></returns>
        public DataSet Get_NC_Item_List_PT(string strBatch)
        {
            return dal.Get_NC_Item_List_PT(strBatch);
        }

        /// <summary>
        /// 获取NC成分性能信息（深加工产品编码805开头）
        /// </summary>
        /// <param name="strBatch">批号</param>
        /// <returns></returns>
        public DataSet Get_NC_Item_List_WW(string strBatch)
        {
            return dal.Get_NC_Item_List_WW(strBatch);
        }

        /// <summary>
        /// 获取已同步的成分性能信息
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Item_List(string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.Get_Item_List(C_BATCH_NO, C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 同步NC成分性能信息
        /// </summary>
        /// <returns></returns>
        public string Tb_NC_CfXn(string C_Batch)
        {
            string result = "1";

            string strBatch = "";
            string batch_head = "";
            string strMATTYPE = "";
            string strDesign = "";
            string strStove = "";
            string strStdCode = "";
            string strStlGrd = "";

            try
            {
                TransactionHelper.BeginTransaction();

                string userID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                Dal_TQC_QUA_RESULT dalTqcQuaResult = new Dal_TQC_QUA_RESULT();
                Dal_TQB_CHARACTER dalCharacter = new Dal_TQB_CHARACTER();
                Dal_TQB_CHECKTYPE dalCheckType = new Dal_TQB_CHECKTYPE();
                Dal_TQB_STD_CFXN dalCfXn = new Dal_TQB_STD_CFXN();

                DataTable dt_Batch = dal.Get_Tb_List(C_Batch).Tables[0];

                //DataTable dt_Batch = dal.Get_Tb_List_Old().Tables[0];

                for (int i = 0; i < dt_Batch.Rows.Count; i++)
                {
                    strBatch = dt_Batch.Rows[i]["C_BATCH_NO"].ToString();
                    strStove = dt_Batch.Rows[i]["C_STOVE"].ToString();
                    strMATTYPE = dt_Batch.Rows[i]["MATTYPE"].ToString();
                    strDesign = dt_Batch.Rows[i]["C_DESIGN_NO"].ToString();
                    strStdCode = dt_Batch.Rows[i]["C_STD_CODE"].ToString();
                    strStlGrd = dt_Batch.Rows[i]["C_STL_GRD"].ToString();

                    if (strBatch.Substring(0, 1) == "3")
                    {
                        int stoveCount = dalTqcQuaResult.Get_Stove_Count(strStove);
                        if (stoveCount > 0)
                        {
                            if (dt_Batch.Rows[i]["N_SFOB"].ToString() != "1")
                            {
                                continue;
                            }
                        }

                        dal.Delete_Trans(strBatch, strStdCode, strStlGrd);

                        if (!string.IsNullOrEmpty(strDesign))
                        {
                            if (strBatch.Length > 0)
                            {
                                batch_head = strBatch.Substring(0, 1);

                                if (strMATTYPE == "805" && batch_head != "3")
                                {
                                    DataTable dt_item = dal.Get_NC_Item_List_WW(strBatch).Tables[0];
                                    if (dt_item.Rows.Count > 0)
                                    {
                                        for (int jj = 0; jj < dt_item.Rows.Count; jj++)
                                        {
                                            if (string.IsNullOrEmpty(dt_item.Rows[jj]["CRESULT"].ToString()))
                                            {
                                                continue;
                                            }

                                            Mod_TQB_CHARACTER modCharacter = new Mod_TQB_CHARACTER();

                                            if (dt_item.Rows[jj]["CCHECKITEMCODE"].ToString() == "30005")
                                            {
                                                modCharacter = dalCharacter.GetModel_ByCode("60009");
                                            }
                                            else
                                            {
                                                modCharacter = dalCharacter.GetModel_ByCode(dt_item.Rows[jj]["CCHECKITEMCODE"].ToString());
                                            }

                                            if (modCharacter != null)
                                            {
                                                if (dt_item.Rows[jj]["CCHECKITEMCODE"].ToString() == "30014")
                                                {
                                                    string strResult = dt_item.Rows[jj]["CRESULT"].ToString();

                                                    if (!string.IsNullOrEmpty(strResult))
                                                    {
                                                        string[] strs = strResult.Split(' ');
                                                        for (int kk = 0; kk < strs.Length; kk++)
                                                        {
                                                            if (string.IsNullOrEmpty(strs[kk]))
                                                            {
                                                                continue;
                                                            }

                                                            Mod_TQC_COMPRE_ITEM_RESULT modelResult = new Mod_TQC_COMPRE_ITEM_RESULT();

                                                            string s_head = strs[kk].Substring(0, 2);

                                                            char s_last = strs[kk][strs[kk].Length - 1];

                                                            bool isChar = false;//最后一位是否为字母

                                                            if (Char.IsLetter(s_last))
                                                            {
                                                                isChar = true;

                                                                strs[kk] = strs[kk].Substring(0, strs[kk].Length - 1);
                                                            }

                                                            Mod_TQB_CHARACTER modCharacterTemp = new Mod_TQB_CHARACTER();

                                                            if (s_head == "DS")
                                                            {
                                                                if (isChar)//字母
                                                                {
                                                                    modCharacterTemp = dalCharacter.GetModel_ByCode("30105");
                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(2);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                                else//数字
                                                                {
                                                                    modCharacterTemp = dalCharacter.GetModel_ByCode("30104");
                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(2);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                s_head = strs[kk].Substring(0, 1);
                                                                if (isChar)//字母
                                                                {
                                                                    modCharacterTemp = new Mod_TQB_CHARACTER();
                                                                    if (s_head == "A")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30034");
                                                                    }
                                                                    else if (s_head == "B")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30036");
                                                                    }
                                                                    else if (s_head == "C")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30038");
                                                                    }
                                                                    else if (s_head == "D")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30040");
                                                                    }

                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(1);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                                else//数字
                                                                {
                                                                    if (s_head == "A")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30033");
                                                                    }
                                                                    else if (s_head == "B")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30035");
                                                                    }
                                                                    else if (s_head == "C")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30037");
                                                                    }
                                                                    else if (s_head == "D")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30039");
                                                                    }

                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(1);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                            }

                                                            DataTable dtCFXN = dalCfXn.Get_List(strStdCode, strStlGrd, modCharacterTemp.C_ID).Tables[0];
                                                            if (dtCFXN.Rows.Count > 0)
                                                            {
                                                                modelResult.C_IS_DECIDE = dtCFXN.Rows[0]["C_IS_DECIDE"].ToString();
                                                                modelResult.C_IS_SHOW = dtCFXN.Rows[0]["C_IS_PRINT"].ToString();
                                                            }

                                                            modelResult.C_BATCH_NO = strBatch;
                                                            modelResult.C_STOVE = strStove;
                                                            modelResult.C_STL_GRD = dt_Batch.Rows[i]["C_STL_GRD"].ToString();
                                                            modelResult.C_SPEC = dt_Batch.Rows[i]["C_SPEC"].ToString();
                                                            modelResult.C_STD_CODE = dt_Batch.Rows[i]["C_STD_CODE"].ToString();
                                                            modelResult.N_STATUS = 1;

                                                            if (modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷弯试验" || modelResult.C_ITEM_NAME == "O" || modelResult.C_ITEM_NAME == "N" || modelResult.C_ITEM_NAME == "H")
                                                            {
                                                                modelResult.C_GROUP = "1";
                                                            }
                                                            else
                                                            {
                                                                modelResult.C_GROUP = dt_item.Rows[jj]["VSAMPLECODE"].ToString();
                                                            }
                                                            modelResult.C_TB = "Y";
                                                            modelResult.C_CHECK_STATE = "0";
                                                            modelResult.C_DESIGN_NO = strDesign;
                                                            modelResult.D_MOD_DT = dTime;
                                                            modelResult.C_EMP_ID = userID;
                                                            modelResult.C_RESULT = "Y";

                                                            if (!dal.Add_Trans(modelResult))
                                                            {
                                                                TransactionHelper.RollBack();
                                                                return "0";
                                                            }
                                                        }
                                                    }

                                                }
                                                else
                                                {
                                                    Mod_TQC_COMPRE_ITEM_RESULT modelResult = new Mod_TQC_COMPRE_ITEM_RESULT();
                                                    modelResult.C_BATCH_NO = strBatch;
                                                    modelResult.C_STOVE = strStove;
                                                    modelResult.C_STL_GRD = dt_Batch.Rows[i]["C_STL_GRD"].ToString();
                                                    modelResult.C_SPEC = dt_Batch.Rows[i]["C_SPEC"].ToString();
                                                    modelResult.C_STD_CODE = dt_Batch.Rows[i]["C_STD_CODE"].ToString();
                                                    modelResult.C_ITEM_NAME = modCharacter.C_NAME;
                                                    modelResult.N_STATUS = 1;
                                                    if (dt_item.Rows[jj]["VSAMPLECODE"].ToString().Length > 10)
                                                    {
                                                        modelResult.C_GROUP = "1";
                                                    }
                                                    else
                                                    {
                                                        if (modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷弯试验" || modelResult.C_ITEM_NAME == "O" || modelResult.C_ITEM_NAME == "N" || modelResult.C_ITEM_NAME == "H")
                                                        {
                                                            modelResult.C_GROUP = "1";
                                                        }
                                                        else
                                                        {
                                                            modelResult.C_GROUP = dt_item.Rows[jj]["VSAMPLECODE"].ToString();
                                                        }
                                                    }
                                                    modelResult.C_TB = "Y";
                                                    modelResult.C_CHECK_STATE = "0";
                                                    modelResult.C_DESIGN_NO = strDesign;
                                                    modelResult.D_MOD_DT = dTime;
                                                    modelResult.C_EMP_ID = userID;
                                                    modelResult.C_CHARACTER_ID = modCharacter.C_ID;

                                                    modelResult.C_VALUE = dt_item.Rows[jj]["CRESULT"].ToString();

                                                    DataTable dtCFXN = dalCfXn.Get_List(strStdCode, strStlGrd, modCharacter.C_ID).Tables[0];
                                                    if (dtCFXN.Rows.Count > 0)
                                                    {
                                                        modelResult.C_IS_DECIDE = dtCFXN.Rows[0]["C_IS_DECIDE"].ToString();
                                                        modelResult.C_IS_SHOW = dtCFXN.Rows[0]["C_IS_PRINT"].ToString();
                                                    }

                                                    modelResult.C_RESULT = "Y";

                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacter.C_TYPE_ID);

                                                    if (!dal.Add_Trans(modelResult))
                                                    {
                                                        TransactionHelper.RollBack();
                                                        return "0";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                TransactionHelper.RollBack();
                                                return dt_item.Rows[jj]["CCHECKITEMNAME"].ToString() + "在系统中没有维护，无法从NC同步！";
                                            }
                                        }

                                        int count = dalTqcQuaResult.Get_Count_Trans(strStove);
                                        if (count == 0)
                                        {
                                            for (int mm = 0; mm < dt_item.Rows.Count; mm++)
                                            {
                                                if (dt_item.Rows[mm]["VSAMPLECODE"].ToString().Length > 10)
                                                {
                                                    if (!string.IsNullOrEmpty(dt_item.Rows[mm]["CRESULT"].ToString()))
                                                    {
                                                        Mod_TQC_QUA_RESULT modQua = new Mod_TQC_QUA_RESULT();
                                                        modQua.N_STATUS = 1;
                                                        modQua.D_MOD_DT = dTime;
                                                        modQua.N_SPLIT = 0;
                                                        modQua.N_TYPE = 1;
                                                        modQua.C_STOVE = strStove;
                                                        modQua.D_CREATETIME = dTime;
                                                        modQua.C_ANAITEM = dt_item.Rows[mm]["CCHECKITEMNAME"].ToString();
                                                        modQua.N_ORIGINALVALUE = Convert.ToDecimal(dt_item.Rows[mm]["CRESULT"].ToString());
                                                        modQua.C_SAMPID = dt_item.Rows[mm]["VSAMPLECODE"].ToString();

                                                        if (!dalTqcQuaResult.Add_Trans(modQua))
                                                        {
                                                            TransactionHelper.RollBack();
                                                            return "0";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (batch_head == "3" || strMATTYPE == "807" || strMATTYPE == "806")
                                {
                                    DataTable dt_item = dal.Get_NC_Item_List_PT(strBatch).Tables[0];
                                    if (dt_item.Rows.Count > 0)
                                    {
                                        for (int jj = 0; jj < dt_item.Rows.Count; jj++)
                                        {
                                            if (string.IsNullOrEmpty(dt_item.Rows[jj]["CRESULT"].ToString()))
                                            {
                                                continue;
                                            }

                                            Mod_TQB_CHARACTER modCharacter = new Mod_TQB_CHARACTER();

                                            if (dt_item.Rows[jj]["CCHECKITEMCODE"].ToString() == "30005")
                                            {
                                                modCharacter = dalCharacter.GetModel_ByCode("60009");
                                            }
                                            else
                                            {
                                                modCharacter = dalCharacter.GetModel_ByCode(dt_item.Rows[jj]["CCHECKITEMCODE"].ToString());
                                            }

                                            if (modCharacter != null)
                                            {
                                                if (dt_item.Rows[jj]["CCHECKITEMCODE"].ToString() == "30014")
                                                {
                                                    string strResult = dt_item.Rows[jj]["CRESULT"].ToString();

                                                    if (!string.IsNullOrEmpty(strResult))
                                                    {
                                                        string[] strs = strResult.Split(' ');
                                                        for (int kk = 0; kk < strs.Length; kk++)
                                                        {
                                                            if (string.IsNullOrEmpty(strs[kk]))
                                                            {
                                                                continue;
                                                            }

                                                            Mod_TQC_COMPRE_ITEM_RESULT modelResult = new Mod_TQC_COMPRE_ITEM_RESULT();

                                                            string s_head = strs[kk].Substring(0, 2);

                                                            char s_last = strs[kk][strs[kk].Length - 1];

                                                            bool isChar = false;//最后一位是否为字母

                                                            if (Char.IsLetter(s_last))
                                                            {
                                                                isChar = true;

                                                                strs[kk] = strs[kk].Substring(0, strs[kk].Length - 1);
                                                            }

                                                            Mod_TQB_CHARACTER modCharacterTemp = new Mod_TQB_CHARACTER();

                                                            if (s_head == "DS")
                                                            {
                                                                if (isChar)//字母
                                                                {
                                                                    modCharacterTemp = dalCharacter.GetModel_ByCode("30105");
                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(2);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                                else//数字
                                                                {
                                                                    modCharacterTemp = dalCharacter.GetModel_ByCode("30104");
                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(2);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                s_head = strs[kk].Substring(0, 1);
                                                                if (isChar)//字母
                                                                {
                                                                    modCharacterTemp = new Mod_TQB_CHARACTER();
                                                                    if (s_head == "A")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30034");
                                                                    }
                                                                    else if (s_head == "B")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30036");
                                                                    }
                                                                    else if (s_head == "C")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30038");
                                                                    }
                                                                    else if (s_head == "D")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30040");
                                                                    }

                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(1);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                                else//数字
                                                                {
                                                                    modCharacterTemp = new Mod_TQB_CHARACTER();
                                                                    if (s_head == "A")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30033");
                                                                    }
                                                                    else if (s_head == "B")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30035");
                                                                    }
                                                                    else if (s_head == "C")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30037");
                                                                    }
                                                                    else if (s_head == "D")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30039");
                                                                    }

                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(1);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                            }

                                                            DataTable dtCFXN = dalCfXn.Get_List(strStdCode, strStlGrd, modCharacterTemp.C_ID).Tables[0];
                                                            if (dtCFXN.Rows.Count > 0)
                                                            {
                                                                modelResult.C_IS_DECIDE = dtCFXN.Rows[0]["C_IS_DECIDE"].ToString();
                                                                modelResult.C_RESULT = dtCFXN.Rows[0]["C_IS_PRINT"].ToString();
                                                            }

                                                            modelResult.C_BATCH_NO = strBatch;
                                                            modelResult.C_STOVE = strStove;
                                                            modelResult.C_STL_GRD = dt_Batch.Rows[i]["C_STL_GRD"].ToString();
                                                            modelResult.C_SPEC = dt_Batch.Rows[i]["C_SPEC"].ToString();
                                                            modelResult.C_STD_CODE = dt_Batch.Rows[i]["C_STD_CODE"].ToString();
                                                            modelResult.N_STATUS = 1;

                                                            if (modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷弯试验" || modelResult.C_ITEM_NAME == "O" || modelResult.C_ITEM_NAME == "N" || modelResult.C_ITEM_NAME == "H")
                                                            {
                                                                modelResult.C_GROUP = "1";
                                                            }
                                                            else
                                                            {
                                                                modelResult.C_GROUP = dt_item.Rows[jj]["VSAMPLECODE"].ToString();
                                                            }

                                                            modelResult.C_TB = "Y";
                                                            modelResult.C_CHECK_STATE = "0";
                                                            modelResult.C_DESIGN_NO = strDesign;
                                                            modelResult.D_MOD_DT = dTime;
                                                            modelResult.C_EMP_ID = userID;

                                                            if (!dal.Add_Trans(modelResult))
                                                            {
                                                                TransactionHelper.RollBack();
                                                                return "0";
                                                            }
                                                        }
                                                    }

                                                }
                                                else
                                                {
                                                    Mod_TQC_COMPRE_ITEM_RESULT modelResult = new Mod_TQC_COMPRE_ITEM_RESULT();
                                                    modelResult.C_BATCH_NO = strBatch;
                                                    modelResult.C_STOVE = strStove;
                                                    modelResult.C_STL_GRD = dt_Batch.Rows[i]["C_STL_GRD"].ToString();
                                                    modelResult.C_SPEC = dt_Batch.Rows[i]["C_SPEC"].ToString();
                                                    modelResult.C_STD_CODE = dt_Batch.Rows[i]["C_STD_CODE"].ToString();
                                                    modelResult.N_STATUS = 1;
                                                    modelResult.C_ITEM_NAME = modCharacter.C_NAME;
                                                    if (dt_item.Rows[jj]["VSAMPLECODE"].ToString().Length > 10)
                                                    {
                                                        modelResult.C_GROUP = "1";
                                                    }
                                                    else
                                                    {
                                                        if (modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷弯试验" || modelResult.C_ITEM_NAME == "O" || modelResult.C_ITEM_NAME == "N" || modelResult.C_ITEM_NAME == "H")
                                                        {
                                                            modelResult.C_GROUP = "1";
                                                        }
                                                        else
                                                        {
                                                            modelResult.C_GROUP = dt_item.Rows[jj]["VSAMPLECODE"].ToString();
                                                        }
                                                    }
                                                    modelResult.C_TB = "Y";
                                                    modelResult.C_CHECK_STATE = "0";
                                                    modelResult.C_DESIGN_NO = strDesign;
                                                    modelResult.D_MOD_DT = dTime;
                                                    modelResult.C_EMP_ID = userID;
                                                    modelResult.C_CHARACTER_ID = modCharacter.C_ID;

                                                    modelResult.C_VALUE = dt_item.Rows[jj]["CRESULT"].ToString();

                                                    DataTable dtCFXN = dalCfXn.Get_List(strStdCode, strStlGrd, modCharacter.C_ID).Tables[0];
                                                    if (dtCFXN.Rows.Count > 0)
                                                    {
                                                        modelResult.C_IS_DECIDE = dtCFXN.Rows[0]["C_IS_DECIDE"].ToString();
                                                        modelResult.C_IS_SHOW = dtCFXN.Rows[0]["C_IS_PRINT"].ToString();
                                                    }

                                                    modelResult.C_RESULT = "Y";

                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacter.C_TYPE_ID);

                                                    if (!dal.Add_Trans(modelResult))
                                                    {
                                                        TransactionHelper.RollBack();
                                                        return "0";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                TransactionHelper.RollBack();
                                                return dt_item.Rows[jj]["CCHECKITEMNAME"].ToString() + "在系统中没有维护，无法从NC同步！";
                                            }
                                        }

                                        int count = dalTqcQuaResult.Get_Count_Trans(strStove);
                                        if (count == 0)
                                        {
                                            for (int mm = 0; mm < dt_item.Rows.Count; mm++)
                                            {
                                                if (dt_item.Rows[mm]["VSAMPLECODE"].ToString().Length > 10)
                                                {
                                                    if (!string.IsNullOrEmpty(dt_item.Rows[mm]["CRESULT"].ToString()))
                                                    {
                                                        Mod_TQC_QUA_RESULT modQua = new Mod_TQC_QUA_RESULT();
                                                        modQua.N_STATUS = 1;
                                                        modQua.D_MOD_DT = dTime;
                                                        modQua.N_SPLIT = 0;
                                                        modQua.N_TYPE = 1;
                                                        modQua.C_STOVE = strStove;
                                                        modQua.D_CREATETIME = dTime;
                                                        modQua.C_ANAITEM = dt_item.Rows[mm]["CCHECKITEMNAME"].ToString();
                                                        modQua.N_ORIGINALVALUE = Convert.ToDecimal(dt_item.Rows[mm]["CRESULT"].ToString());
                                                        modQua.C_SAMPID = dt_item.Rows[mm]["VSAMPLECODE"].ToString();
                                                        modQua.C_IS_PD = "1";

                                                        if (!dalTqcQuaResult.Add_Trans(modQua))
                                                        {
                                                            TransactionHelper.RollBack();
                                                            return "0";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        dal.Delete_Trans(strBatch, strStdCode, strStlGrd);

                        //if (!string.IsNullOrEmpty(strDesign))
                        {
                            if (strBatch.Length > 0)
                            {
                                batch_head = strBatch.Substring(0, 1);

                                if (strMATTYPE == "805" && batch_head != "3")
                                {
                                    DataTable dt_item = dal.Get_NC_Item_List_WW(strBatch).Tables[0];
                                    if (dt_item.Rows.Count > 0)
                                    {
                                        for (int jj = 0; jj < dt_item.Rows.Count; jj++)
                                        {
                                            if (string.IsNullOrEmpty(dt_item.Rows[jj]["CRESULT"].ToString()))
                                            {
                                                continue;
                                            }

                                            Mod_TQB_CHARACTER modCharacter = new Mod_TQB_CHARACTER();

                                            if (dt_item.Rows[jj]["CCHECKITEMCODE"].ToString() == "30005")
                                            {
                                                modCharacter = dalCharacter.GetModel_ByCode("60009");
                                            }
                                            else
                                            {
                                                modCharacter = dalCharacter.GetModel_ByCode(dt_item.Rows[jj]["CCHECKITEMCODE"].ToString());
                                            }

                                            if (modCharacter != null)
                                            {
                                                if (dt_item.Rows[jj]["CCHECKITEMCODE"].ToString() == "30014")
                                                {
                                                    string strResult = dt_item.Rows[jj]["CRESULT"].ToString();

                                                    if (!string.IsNullOrEmpty(strResult))
                                                    {
                                                        string[] strs = strResult.Split(' ');
                                                        for (int kk = 0; kk < strs.Length; kk++)
                                                        {
                                                            if (string.IsNullOrEmpty(strs[kk]))
                                                            {
                                                                continue;
                                                            }

                                                            Mod_TQC_COMPRE_ITEM_RESULT modelResult = new Mod_TQC_COMPRE_ITEM_RESULT();

                                                            string s_head = strs[kk].Substring(0, 2);

                                                            char s_last = strs[kk][strs[kk].Length - 1];

                                                            bool isChar = false;//最后一位是否为字母

                                                            if (Char.IsLetter(s_last))
                                                            {
                                                                isChar = true;

                                                                strs[kk] = strs[kk].Substring(0, strs[kk].Length - 1);
                                                            }

                                                            if (s_head == "DS")
                                                            {
                                                                if (isChar)//字母
                                                                {
                                                                    Mod_TQB_CHARACTER modCharacterTemp = dalCharacter.GetModel_ByCode("30105");
                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(2);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                                else//数字
                                                                {
                                                                    Mod_TQB_CHARACTER modCharacterTemp = dalCharacter.GetModel_ByCode("30104");
                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(2);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                s_head = strs[kk].Substring(0, 1);
                                                                if (isChar)//字母
                                                                {
                                                                    Mod_TQB_CHARACTER modCharacterTemp = new Mod_TQB_CHARACTER();
                                                                    if (s_head == "A")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30034");
                                                                    }
                                                                    else if (s_head == "B")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30036");
                                                                    }
                                                                    else if (s_head == "C")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30038");
                                                                    }
                                                                    else if (s_head == "D")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30040");
                                                                    }

                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(1);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                                else//数字
                                                                {
                                                                    Mod_TQB_CHARACTER modCharacterTemp = new Mod_TQB_CHARACTER();
                                                                    if (s_head == "A")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30033");
                                                                    }
                                                                    else if (s_head == "B")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30035");
                                                                    }
                                                                    else if (s_head == "C")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30037");
                                                                    }
                                                                    else if (s_head == "D")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30039");
                                                                    }

                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(1);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                            }

                                                            modelResult.C_BATCH_NO = strBatch;
                                                            modelResult.C_STOVE = strStove;
                                                            modelResult.C_STL_GRD = dt_Batch.Rows[i]["C_STL_GRD"].ToString();
                                                            modelResult.C_SPEC = dt_Batch.Rows[i]["C_SPEC"].ToString();
                                                            modelResult.C_STD_CODE = dt_Batch.Rows[i]["C_STD_CODE"].ToString();
                                                            modelResult.N_STATUS = 1;

                                                            if (modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷弯试验" || modelResult.C_ITEM_NAME == "O" || modelResult.C_ITEM_NAME == "N" || modelResult.C_ITEM_NAME == "H")
                                                            {
                                                                modelResult.C_GROUP = "1";
                                                            }
                                                            else
                                                            {
                                                                modelResult.C_GROUP = dt_item.Rows[jj]["VSAMPLECODE"].ToString();
                                                            }
                                                            modelResult.C_TB = "Y";
                                                            modelResult.C_CHECK_STATE = "0";
                                                            modelResult.C_DESIGN_NO = strDesign;
                                                            modelResult.D_MOD_DT = dTime;
                                                            modelResult.C_EMP_ID = userID;

                                                            DataTable dtCFXN = dalCfXn.Get_List(strStdCode, strStlGrd, modCharacter.C_ID).Tables[0];
                                                            if (dtCFXN.Rows.Count > 0)
                                                            {
                                                                modelResult.C_IS_DECIDE = dtCFXN.Rows[0]["C_IS_DECIDE"].ToString();
                                                                modelResult.C_IS_SHOW = dtCFXN.Rows[0]["C_IS_PRINT"].ToString();
                                                            }

                                                            modelResult.C_RESULT = "Y";


                                                            if (!dal.Add_Trans(modelResult))
                                                            {
                                                                TransactionHelper.RollBack();
                                                                return "0";
                                                            }
                                                        }
                                                    }

                                                }
                                                else
                                                {
                                                    Mod_TQC_COMPRE_ITEM_RESULT modelResult = new Mod_TQC_COMPRE_ITEM_RESULT();
                                                    modelResult.C_BATCH_NO = strBatch;
                                                    modelResult.C_STOVE = strStove;
                                                    modelResult.C_STL_GRD = dt_Batch.Rows[i]["C_STL_GRD"].ToString();
                                                    modelResult.C_SPEC = dt_Batch.Rows[i]["C_SPEC"].ToString();
                                                    modelResult.C_STD_CODE = dt_Batch.Rows[i]["C_STD_CODE"].ToString();
                                                    modelResult.C_ITEM_NAME = modCharacter.C_NAME;
                                                    modelResult.N_STATUS = 1;
                                                    if (dt_item.Rows[jj]["VSAMPLECODE"].ToString().Length > 10)
                                                    {
                                                        modelResult.C_GROUP = "1";
                                                    }
                                                    else
                                                    {
                                                        if (modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷弯试验" || modelResult.C_ITEM_NAME == "O" || modelResult.C_ITEM_NAME == "N" || modelResult.C_ITEM_NAME == "H")
                                                        {
                                                            modelResult.C_GROUP = "1";
                                                        }
                                                        else
                                                        {
                                                            modelResult.C_GROUP = dt_item.Rows[jj]["VSAMPLECODE"].ToString();
                                                        }
                                                    }
                                                    modelResult.C_TB = "Y";
                                                    modelResult.C_CHECK_STATE = "0";
                                                    modelResult.C_DESIGN_NO = strDesign;
                                                    modelResult.D_MOD_DT = dTime;
                                                    modelResult.C_EMP_ID = userID;
                                                    modelResult.C_CHARACTER_ID = modCharacter.C_ID;

                                                    modelResult.C_VALUE = dt_item.Rows[jj]["CRESULT"].ToString();

                                                    DataTable dtCFXN = dalCfXn.Get_List(strStdCode, strStlGrd, modCharacter.C_ID).Tables[0];
                                                    if (dtCFXN.Rows.Count > 0)
                                                    {
                                                        modelResult.C_IS_DECIDE = dtCFXN.Rows[0]["C_IS_DECIDE"].ToString();
                                                        modelResult.C_IS_SHOW = dtCFXN.Rows[0]["C_IS_PRINT"].ToString();
                                                    }

                                                    modelResult.C_RESULT = "Y";

                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacter.C_TYPE_ID);

                                                    if (!dal.Add_Trans(modelResult))
                                                    {
                                                        TransactionHelper.RollBack();
                                                        return "0";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                TransactionHelper.RollBack();
                                                return dt_item.Rows[jj]["CCHECKITEMNAME"].ToString() + "在系统中没有维护，无法从NC同步！";
                                            }
                                        }

                                        int count = dalTqcQuaResult.Get_Count_Trans(strStove);
                                        if (count == 0)
                                        {
                                            for (int mm = 0; mm < dt_item.Rows.Count; mm++)
                                            {
                                                if (dt_item.Rows[mm]["VSAMPLECODE"].ToString().Length > 10)
                                                {
                                                    if (!string.IsNullOrEmpty(dt_item.Rows[mm]["CRESULT"].ToString()))
                                                    {
                                                        Mod_TQC_QUA_RESULT modQua = new Mod_TQC_QUA_RESULT();
                                                        modQua.N_STATUS = 1;
                                                        modQua.D_MOD_DT = dTime;
                                                        modQua.N_SPLIT = 0;
                                                        modQua.N_TYPE = 1;
                                                        modQua.C_STOVE = strStove;
                                                        modQua.D_CREATETIME = dTime;
                                                        modQua.C_ANAITEM = dt_item.Rows[mm]["CCHECKITEMNAME"].ToString();
                                                        modQua.N_ORIGINALVALUE = Convert.ToDecimal(dt_item.Rows[mm]["CRESULT"].ToString());
                                                        modQua.C_SAMPID = dt_item.Rows[mm]["VSAMPLECODE"].ToString();

                                                        if (!dalTqcQuaResult.Add_Trans(modQua))
                                                        {
                                                            TransactionHelper.RollBack();
                                                            return "0";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (batch_head == "3" || strMATTYPE == "807" || strMATTYPE == "806")
                                {
                                    DataTable dt_item = dal.Get_NC_Item_List_PT(strBatch).Tables[0];
                                    if (dt_item.Rows.Count > 0)
                                    {
                                        for (int jj = 0; jj < dt_item.Rows.Count; jj++)
                                        {
                                            if (string.IsNullOrEmpty(dt_item.Rows[jj]["CRESULT"].ToString()))
                                            {
                                                continue;
                                            }

                                            Mod_TQB_CHARACTER modCharacter = new Mod_TQB_CHARACTER();

                                            if (dt_item.Rows[jj]["CCHECKITEMCODE"].ToString() == "30005")
                                            {
                                                modCharacter = dalCharacter.GetModel_ByCode("60009");
                                            }
                                            else
                                            {
                                                modCharacter = dalCharacter.GetModel_ByCode(dt_item.Rows[jj]["CCHECKITEMCODE"].ToString());
                                            }

                                            if (modCharacter != null)
                                            {
                                                if (dt_item.Rows[jj]["CCHECKITEMCODE"].ToString() == "30014")
                                                {
                                                    string strResult = dt_item.Rows[jj]["CRESULT"].ToString();

                                                    if (!string.IsNullOrEmpty(strResult))
                                                    {
                                                        string[] strs = strResult.Split(' ');
                                                        for (int kk = 0; kk < strs.Length; kk++)
                                                        {
                                                            if (string.IsNullOrEmpty(strs[kk]))
                                                            {
                                                                continue;
                                                            }

                                                            Mod_TQC_COMPRE_ITEM_RESULT modelResult = new Mod_TQC_COMPRE_ITEM_RESULT();

                                                            string s_head = strs[kk].Substring(0, 2);

                                                            char s_last = strs[kk][strs[kk].Length - 1];

                                                            bool isChar = false;//最后一位是否为字母

                                                            if (Char.IsLetter(s_last))
                                                            {
                                                                isChar = true;

                                                                strs[kk] = strs[kk].Substring(0, strs[kk].Length - 1);
                                                            }

                                                            if (s_head == "DS")
                                                            {
                                                                if (isChar)//字母
                                                                {
                                                                    Mod_TQB_CHARACTER modCharacterTemp = dalCharacter.GetModel_ByCode("30105");
                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(2);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                                else//数字
                                                                {
                                                                    Mod_TQB_CHARACTER modCharacterTemp = dalCharacter.GetModel_ByCode("30104");
                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(2);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                s_head = strs[kk].Substring(0, 1);
                                                                if (isChar)//字母
                                                                {
                                                                    Mod_TQB_CHARACTER modCharacterTemp = new Mod_TQB_CHARACTER();
                                                                    if (s_head == "A")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30034");
                                                                    }
                                                                    else if (s_head == "B")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30036");
                                                                    }
                                                                    else if (s_head == "C")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30038");
                                                                    }
                                                                    else if (s_head == "D")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30040");
                                                                    }

                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(1);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                                else//数字
                                                                {
                                                                    Mod_TQB_CHARACTER modCharacterTemp = new Mod_TQB_CHARACTER();
                                                                    if (s_head == "A")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30033");
                                                                    }
                                                                    else if (s_head == "B")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30035");
                                                                    }
                                                                    else if (s_head == "C")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30037");
                                                                    }
                                                                    else if (s_head == "D")
                                                                    {
                                                                        modCharacterTemp = dalCharacter.GetModel_ByCode("30039");
                                                                    }

                                                                    modelResult.C_CHARACTER_ID = modCharacterTemp.C_ID;
                                                                    modelResult.C_ITEM_NAME = modCharacterTemp.C_NAME;
                                                                    modelResult.C_VALUE = strs[kk].Substring(1);

                                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacterTemp.C_TYPE_ID);
                                                                }
                                                            }

                                                            modelResult.C_BATCH_NO = strBatch;
                                                            modelResult.C_STOVE = strStove;
                                                            modelResult.C_STL_GRD = dt_Batch.Rows[i]["C_STL_GRD"].ToString();
                                                            modelResult.C_SPEC = dt_Batch.Rows[i]["C_SPEC"].ToString();
                                                            modelResult.C_STD_CODE = dt_Batch.Rows[i]["C_STD_CODE"].ToString();
                                                            modelResult.N_STATUS = 1;

                                                            if (modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷弯试验" || modelResult.C_ITEM_NAME == "O" || modelResult.C_ITEM_NAME == "N" || modelResult.C_ITEM_NAME == "H")
                                                            {
                                                                modelResult.C_GROUP = "1";
                                                            }
                                                            else
                                                            {
                                                                modelResult.C_GROUP = dt_item.Rows[jj]["VSAMPLECODE"].ToString();
                                                            }

                                                            modelResult.C_TB = "Y";
                                                            modelResult.C_CHECK_STATE = "0";
                                                            modelResult.C_DESIGN_NO = strDesign;
                                                            modelResult.D_MOD_DT = dTime;
                                                            modelResult.C_EMP_ID = userID;

                                                            DataTable dtCFXN = dalCfXn.Get_List(strStdCode, strStlGrd, modCharacter.C_ID).Tables[0];
                                                            if (dtCFXN.Rows.Count > 0)
                                                            {
                                                                modelResult.C_IS_DECIDE = dtCFXN.Rows[0]["C_IS_DECIDE"].ToString();
                                                                modelResult.C_RESULT = dtCFXN.Rows[0]["C_IS_PRINT"].ToString();
                                                            }

                                                            if (!dal.Add_Trans(modelResult))
                                                            {
                                                                TransactionHelper.RollBack();
                                                                return "0";
                                                            }
                                                        }
                                                    }

                                                }
                                                else
                                                {
                                                    Mod_TQC_COMPRE_ITEM_RESULT modelResult = new Mod_TQC_COMPRE_ITEM_RESULT();
                                                    modelResult.C_BATCH_NO = strBatch;
                                                    modelResult.C_STOVE = strStove;
                                                    modelResult.C_STL_GRD = dt_Batch.Rows[i]["C_STL_GRD"].ToString();
                                                    modelResult.C_SPEC = dt_Batch.Rows[i]["C_SPEC"].ToString();
                                                    modelResult.C_STD_CODE = dt_Batch.Rows[i]["C_STD_CODE"].ToString();
                                                    modelResult.N_STATUS = 1;
                                                    modelResult.C_ITEM_NAME = modCharacter.C_NAME;
                                                    if (dt_item.Rows[jj]["VSAMPLECODE"].ToString().Length > 10)
                                                    {
                                                        modelResult.C_GROUP = "1";
                                                    }
                                                    else
                                                    {
                                                        if (modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷顶锻" || modelResult.C_ITEM_NAME == "冷弯试验" || modelResult.C_ITEM_NAME == "O" || modelResult.C_ITEM_NAME == "N" || modelResult.C_ITEM_NAME == "H")
                                                        {
                                                            modelResult.C_GROUP = "1";
                                                        }
                                                        else
                                                        {
                                                            modelResult.C_GROUP = dt_item.Rows[jj]["VSAMPLECODE"].ToString();
                                                        }
                                                    }
                                                    modelResult.C_TB = "Y";
                                                    modelResult.C_CHECK_STATE = "0";
                                                    modelResult.C_DESIGN_NO = strDesign;
                                                    modelResult.D_MOD_DT = dTime;
                                                    modelResult.C_EMP_ID = userID;
                                                    modelResult.C_CHARACTER_ID = modCharacter.C_ID;

                                                    modelResult.C_VALUE = dt_item.Rows[jj]["CRESULT"].ToString();

                                                    DataTable dtCFXN = dalCfXn.Get_List(strStdCode, strStlGrd, modCharacter.C_ID).Tables[0];
                                                    if (dtCFXN.Rows.Count > 0)
                                                    {
                                                        modelResult.C_IS_DECIDE = dtCFXN.Rows[0]["C_IS_DECIDE"].ToString();
                                                        modelResult.C_IS_SHOW = dtCFXN.Rows[0]["C_IS_PRINT"].ToString();
                                                    }

                                                    modelResult.C_RESULT = "Y";

                                                    modelResult.C_TYPE = dalCheckType.Get_Type_Name(modCharacter.C_TYPE_ID);

                                                    if (!dal.Add_Trans(modelResult))
                                                    {
                                                        TransactionHelper.RollBack();
                                                        return "0";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                TransactionHelper.RollBack();
                                                return dt_item.Rows[jj]["CCHECKITEMNAME"].ToString() + "在系统中没有维护，无法从NC同步！";
                                            }
                                        }

                                        int count = dalTqcQuaResult.Get_Count_Trans(strStove);
                                        if (count == 0)
                                        {
                                            for (int mm = 0; mm < dt_item.Rows.Count; mm++)
                                            {
                                                if (dt_item.Rows[mm]["VSAMPLECODE"].ToString().Length > 10)
                                                {
                                                    if (!string.IsNullOrEmpty(dt_item.Rows[mm]["CRESULT"].ToString()))
                                                    {
                                                        Mod_TQC_QUA_RESULT modQua = new Mod_TQC_QUA_RESULT();
                                                        modQua.N_STATUS = 1;
                                                        modQua.D_MOD_DT = dTime;
                                                        modQua.N_SPLIT = 0;
                                                        modQua.N_TYPE = 1;
                                                        modQua.C_STOVE = strStove;
                                                        modQua.D_CREATETIME = dTime;
                                                        modQua.C_ANAITEM = dt_item.Rows[mm]["CCHECKITEMNAME"].ToString();
                                                        modQua.N_ORIGINALVALUE = Convert.ToDecimal(dt_item.Rows[mm]["CRESULT"].ToString());
                                                        modQua.C_SAMPID = dt_item.Rows[mm]["VSAMPLECODE"].ToString();
                                                        modQua.C_IS_PD = "1";

                                                        if (!dalTqcQuaResult.Add_Trans(modQua))
                                                        {
                                                            TransactionHelper.RollBack();
                                                            return "0";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                string ss = strBatch;
                TransactionHelper.RollBack();
                return ex.Message;
            }

            return result;
        }

        #endregion  ExtensionMethod
    }
}

