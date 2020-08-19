using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using MODEL;
namespace DAL
{
    public partial class Dal_Interface_NC_Roll_KC4N_ZP
    {
        private Dal_Send_NC dalSendNC = new Dal_Send_NC();
        Dal_TRC_ROLL_WGD dalTrcRollWgd = new Dal_TRC_ROLL_WGD();
        Dal_TRC_ROLL_PRODCUT dal_roll_pro = new Dal_TRC_ROLL_PRODCUT();
        Dal_TB_MATRL_MAIN dal_mater_main = new Dal_TB_MATRL_MAIN();
        Dal_TS_USER dal_user = new Dal_TS_USER();
        Dal_TPB_LINEWH dal_linewh = new Dal_TPB_LINEWH();
        Dal_TB_STD_CONFIG dal_std_config = new Dal_TB_STD_CONFIG();
        Dal_TMO_ORDER dal_tmo_order = new Dal_TMO_ORDER();
        Dal_TQB_CHECKSTATE dal_checkstate = new Dal_TQB_CHECKSTATE();
        Dal_TS_DEPT dal_TS_DEPT = new Dal_TS_DEPT();
        /// <summary>
        /// 发送综判信息给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param> 
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public string SendXml_GP(string xmlFileName, string strBatchNo, string C_MASTER_ID, string C_MAT_CODE, string strWgt, string strQua, string strZYX1, string strZYX2, Mod_TRC_ROLL_WGD mod_wgd, string C_GP_BEFORE_ID)
        {
            try
            {
                DateTime time = RV.UI.ServerTime.timeNow();
                string strUserID = RV.UI.UserInfo.userID;

                string urlname = "ZP" + C_MASTER_ID + ".xml";
                string url = xmlFileName + "\\NCXML";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }

                //Mod_TRC_ROLL_WGD mod_wgd = dalTrcRollWgd.Get_WGD_Modle(strBatchNo);//获取完工单信息
                //if (mod_wgd == null) return "没有找到完工单信息！";

                DataTable dt_sj_list = dal_roll_pro.Get_All_ByBatch_Trans(strBatchNo, C_MASTER_ID).Tables[0];//实绩信息
                if (dt_sj_list.Rows.Count == 0) return "没有找到实绩信息！";

                Mod_TB_MATRL_MAIN mod_mater_main = dal_mater_main.GetModel_Interface_Trans(C_MAT_CODE); //物料主表

                Mod_TS_USER mod_ts_user = dal_user.GetModel_Interface_Trans(strUserID);//用户主表
                string bmid = dal_TS_DEPT.GetDept(mod_ts_user.C_ACCOUNT);
                if (bmid == "")
                {
                    return "操作人部门未维护！";
                }
                Mod_TS_DEPT mod_TS_DEPT = dal_TS_DEPT.GetModel(bmid);//获取部门
                Mod_TPB_LINEWH mod_linewh = dal_linewh.GetModel_Interface_Trans(dt_sj_list.Rows[0]["C_LINEWH_CODE"].ToString());//库存表
                Mod_TMO_ORDER mod_tmo_order = dal_tmo_order.GetModelByORDERNO_Trans(dt_sj_list.Rows[0]["C_ORDER_NO"].ToString());//订单池

                if (mod_tmo_order == null) return "获取订单信息失败！";


                //Mod_TQB_CHECKSTATE mod_checkstate = dal_checkstate.GetModelByName_Trans(mod_wgd.C_MRSX, mod_tmo_order.C_XGID);//判定等级
                Mod_TQB_CHECKSTATE mod_checkstate = dal_checkstate.GetModelByName_Trans("DP", mod_tmo_order.C_XGID);//判定等级

                if (mod_mater_main == null) return "没有找到物料编码信息！";

                if (mod_ts_user == null) return "获取用户信息错误！";
                if (mod_linewh == null) return "获取库存信息错误！";
                if (mod_checkstate == null) return "获取判定等级信息错误！";
                
                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
                xmlDoc.AppendChild(node);

                //创建根节点  
                XmlElement root = xmlDoc.CreateElement("ufinterface");
                #region//给节点属性赋值
                root.SetAttribute("billtype", "4N");
                root.SetAttribute("filename", urlname);
                root.SetAttribute("isexchange", "Y");
                root.SetAttribute("operation", "req");
                root.SetAttribute("proc", "add");
                root.SetAttribute("receiver", "101");
                root.SetAttribute("replace", "n");
                root.SetAttribute("roottag", "bill");
                root.SetAttribute("sender", "1107");
                #endregion
                xmlDoc.AppendChild(root);

                //创建子根节点
                XmlElement bill = xmlDoc.CreateElement("bill");
                #region//节点属性
                bill.SetAttribute("id", C_MASTER_ID);
                #endregion
                root.AppendChild(bill);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "bill_head", null);
                #region //表头_order_head
                CreateNode(xmlDoc, head, "ctjname", "");
                CreateNode(xmlDoc, head, "bz", "");
                CreateNode(xmlDoc, head, "cbilltypecode", "");//库存单据类型编码
                CreateNode(xmlDoc, head, "cinbsrid", "");//入库业务员
                CreateNode(xmlDoc, head, "cinbsrname", "");
                CreateNode(xmlDoc, head, "cindeptid", "");//入库部门ID
                CreateNode(xmlDoc, head, "cindeptname", "");
                CreateNode(xmlDoc, head, "cinwarehouseid", "");//入库仓库ID
                CreateNode(xmlDoc, head, "cinwarehousename", "");
                CreateNode(xmlDoc, head, "isLocatorMgtIn", "");
                CreateNode(xmlDoc, head, "isWasteWhIn", "");
                CreateNode(xmlDoc, head, "whreservedptyin", "");
                CreateNode(xmlDoc, head, "islocatormgtin", "");
                CreateNode(xmlDoc, head, "iswastewhin", "");
                CreateNode(xmlDoc, head, "whreservedptyin", "");
                CreateNode(xmlDoc, head, "coutbsor", mod_ts_user.C_ID);//出库业务员
                CreateNode(xmlDoc, head, "coutbsorname", mod_ts_user.C_NAME);
                CreateNode(xmlDoc, head, "coutdeptid", mod_TS_DEPT.C_ID);//出库部门ID
                CreateNode(xmlDoc, head, "coutdeptname", mod_TS_DEPT.C_NAME);
                CreateNode(xmlDoc, head, "coutwarehouseid", "");//出库仓库ID
                CreateNode(xmlDoc, head, "coutwarehousename", "");
                CreateNode(xmlDoc, head, "isLocatorMgtOut", "");//
                CreateNode(xmlDoc, head, "isWasteWhOut", "");
                CreateNode(xmlDoc, head, "whReservedPtyOut", "");
                CreateNode(xmlDoc, head, "islocatormgtout", "");
                CreateNode(xmlDoc, head, "iswastewhout", "");
                CreateNode(xmlDoc, head, "whreservedptyout", "");
                CreateNode(xmlDoc, head, "cshlddiliverdate", "");//应发货日期
                CreateNode(xmlDoc, head, "ctj", "");
                CreateNode(xmlDoc, head, "dbilldate", time.ToString("yyyy-MM-dd"));//单据日期
                CreateNode(xmlDoc, head, "nfixdisassemblymny", "");//组装拆卸费用
                CreateNode(xmlDoc, head, "pdfs", "");
                CreateNode(xmlDoc, head, "pk_corp", mod_tmo_order.C_XGID);//公司ID
                CreateNode(xmlDoc, head, "vbillcode", "");//单据号
                CreateNode(xmlDoc, head, "vnote", "");//备注
                CreateNode(xmlDoc, head, "vshldarrivedate", "");//应到货日期
                CreateNode(xmlDoc, head, "vuserdef1", "");//自定义项
                CreateNode(xmlDoc, head, "vuserdef2", "");    //自定义项
                CreateNode(xmlDoc, head, "vuserdef3", "");    //自定义项
                CreateNode(xmlDoc, head, "vuserdef4", "");    //自定义项
                CreateNode(xmlDoc, head, "vuserdef5", "");    //自定义项
                CreateNode(xmlDoc, head, "vuserdef6", "");    //自定义项
                CreateNode(xmlDoc, head, "vuserdef7", "");    //自定义项
                CreateNode(xmlDoc, head, "vuserdef8", "");    //自定义项
                CreateNode(xmlDoc, head, "vuserdef9", "");    //自定义项
                CreateNode(xmlDoc, head, "vuserdef10", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef11", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef12", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef13", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef14", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef15", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef16", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef17", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef18", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef19", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef20", "");   //自定义项
                CreateNode(xmlDoc, head, "vuserdef11h", "");
                CreateNode(xmlDoc, head, "vuserdef12h", "");
                CreateNode(xmlDoc, head, "vuserdef13h", "");
                CreateNode(xmlDoc, head, "vuserdef14h", "");
                CreateNode(xmlDoc, head, "vuserdef15h", "");
                CreateNode(xmlDoc, head, "vuserdef16h", "");
                CreateNode(xmlDoc, head, "vuserdef17h", "");
                CreateNode(xmlDoc, head, "vuserdef18h", "");
                CreateNode(xmlDoc, head, "vuserdef19h", "");
                CreateNode(xmlDoc, head, "vuserdef20h", "");
                CreateNode(xmlDoc, head, "pk_defdoc1", "");//自定义项主键1
                CreateNode(xmlDoc, head, "pk_defdoc2", "");   //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc3", "");   //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc4", "");   //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc5", "");   //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc6", "");   //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc7", "");   //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc8", "");   //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc9", "");   //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc10", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc1h", "");
                CreateNode(xmlDoc, head, "pk_defdoc2h", "");
                CreateNode(xmlDoc, head, "pk_defdoc3h", "");
                CreateNode(xmlDoc, head, "pk_defdoc4h", "");
                CreateNode(xmlDoc, head, "pk_defdoc5h", "");
                CreateNode(xmlDoc, head, "pk_defdoc6h", "");
                CreateNode(xmlDoc, head, "pk_defdoc7h", "");
                CreateNode(xmlDoc, head, "pk_defdoc8h", "");
                CreateNode(xmlDoc, head, "pk_defdoc9h", "");
                CreateNode(xmlDoc, head, "pk_defdoc10h", "");
                CreateNode(xmlDoc, head, "pk_defdoc11", "");//自定义项主键11
                CreateNode(xmlDoc, head, "pk_defdoc12", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc13", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc14", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc15", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc16", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc17", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc18", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc19", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc20", "");  //自定义项主键
                CreateNode(xmlDoc, head, "pk_defdoc11h", "");
                CreateNode(xmlDoc, head, "pk_defdoc12h", "");
                CreateNode(xmlDoc, head, "pk_defdoc13h", "");
                CreateNode(xmlDoc, head, "pk_defdoc14h", "");
                CreateNode(xmlDoc, head, "pk_defdoc15h", "");
                CreateNode(xmlDoc, head, "pk_defdoc16h", "");
                CreateNode(xmlDoc, head, "pk_defdoc17h", "");
                CreateNode(xmlDoc, head, "pk_defdoc18h", "");
                CreateNode(xmlDoc, head, "pk_defdoc19h", "");
                CreateNode(xmlDoc, head, "pk_defdoc20h", "");
                CreateNode(xmlDoc, head, "vuserdef1h", "");
                CreateNode(xmlDoc, head, "vuserdef2h", "");
                CreateNode(xmlDoc, head, "vuserdef3h", "");
                CreateNode(xmlDoc, head, "vuserdef4h", "");
                CreateNode(xmlDoc, head, "vuserdef5h", "");
                CreateNode(xmlDoc, head, "vuserdef6h", "");
                CreateNode(xmlDoc, head, "vuserdef7h", "");
                CreateNode(xmlDoc, head, "vuserdef8h", "");
                CreateNode(xmlDoc, head, "vuserdef9h", "");
                CreateNode(xmlDoc, head, "vuserdef10h", "");
                CreateNode(xmlDoc, head, "cauditorid", "");//审核人
                CreateNode(xmlDoc, head, "cauditorname", "");//
                CreateNode(xmlDoc, head, "coperatorid", mod_ts_user.C_ID);//制单人
                CreateNode(xmlDoc, head, "coperatorname", mod_ts_user.C_NAME);
                CreateNode(xmlDoc, head, "vadjuster", "");//调整人
                CreateNode(xmlDoc, head, "vadjustername", "");
                CreateNode(xmlDoc, head, "coperatoridnow", "");
                CreateNode(xmlDoc, head, "ctjname", "");
                CreateNode(xmlDoc, head, "pk_calbody_in", "1001NC10000000000669");//*
                CreateNode(xmlDoc, head, "pk_calbody_out", "1001NC10000000000669");//*
                CreateNode(xmlDoc, head, "vcalbody_inname", "");
                CreateNode(xmlDoc, head, "vcalbody_outname", "");
                CreateNode(xmlDoc, head, "ts", time.ToString());
                CreateNode(xmlDoc, head, "timestamp", "");
                CreateNode(xmlDoc, head, "headts", time.ToString());
                CreateNode(xmlDoc, head, "isforeignstor_in", "N ");
                CreateNode(xmlDoc, head, "isgathersettle_in", "N ");
                CreateNode(xmlDoc, head, "isforeignstor_out", "N ");
                CreateNode(xmlDoc, head, "isgathersettle_out", "N ");
                CreateNode(xmlDoc, head, "icheckmode", "");//盘点方式
                CreateNode(xmlDoc, head, "fassistantflag", "N ");//是否计算期间业务量
                CreateNode(xmlDoc, head, "fbillflag", "");//单据状态
                CreateNode(xmlDoc, head, "vostatus", "");
                CreateNode(xmlDoc, head, "iprintcount", "");//打印次数
                CreateNode(xmlDoc, head, "clastmodiid", mod_ts_user.C_ID);//最后修改人
                CreateNode(xmlDoc, head, "clastmodiname", "");
                CreateNode(xmlDoc, head, "tlastmoditime", time.ToString());//最后修改时间
                CreateNode(xmlDoc, head, "cnxtbilltypecode", "");
                CreateNode(xmlDoc, head, "cspecialhid", "");//特殊业务单据ID
                #endregion




                bill.AppendChild(head);
                XmlElement body = xmlDoc.CreateElement("bill_body");
                bill.AppendChild(body);

                XmlNode item = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);
                #region //表体_item
                CreateNode(xmlDoc, item, "csourcetypename", "");
                CreateNode(xmlDoc, item, "cinvbasid", mod_mater_main.C_PK_INVBASDOC);//存货基本ID
                CreateNode(xmlDoc, item, "pk_invbasdoc", mod_mater_main.C_PK_INVBASDOC);
                CreateNode(xmlDoc, item, "fixedflag", "N");
                CreateNode(xmlDoc, item, "bgssl", "");
                CreateNode(xmlDoc, item, "castunitid", mod_mater_main.C_FJLDW);//辅计量单位ID
                CreateNode(xmlDoc, item, "castunitname", mod_mater_main.C_FJLDWMC);
                CreateNode(xmlDoc, item, "cinventorycode", mod_mater_main.C_MAT_CODE);//物料编码
                CreateNode(xmlDoc, item, "cinventoryid", mod_mater_main.C_PK_INVMANDOC);//存货管理ID
                CreateNode(xmlDoc, item, "cinvmanid", mod_mater_main.C_PK_INVBASDOC);
                CreateNode(xmlDoc, item, "isLotMgt", "1");
                CreateNode(xmlDoc, item, "isSerialMgt", "0");
                CreateNode(xmlDoc, item, "isValidateMgt", "0");
                CreateNode(xmlDoc, item, "isAstUOMmgt", "1");
                CreateNode(xmlDoc, item, "isFreeItemMgt", "1");
                CreateNode(xmlDoc, item, "isSet", "0");
                CreateNode(xmlDoc, item, "standStoreUOM", "");
                CreateNode(xmlDoc, item, "defaultAstUOM", mod_mater_main.C_FJLDW);
                CreateNode(xmlDoc, item, "isSellProxy", "0");
                CreateNode(xmlDoc, item, "qualityDay", "");
                CreateNode(xmlDoc, item, "invReservedPty", "");
                CreateNode(xmlDoc, item, "isSolidConvRate", "0");
                CreateNode(xmlDoc, item, "islotmgt", "1");
                CreateNode(xmlDoc, item, "isserialmgt", "0");
                CreateNode(xmlDoc, item, "isvalidatemgt", "0");
                CreateNode(xmlDoc, item, "isastuommgt", "1");
                CreateNode(xmlDoc, item, "isfreeitemmgt", "1");
                CreateNode(xmlDoc, item, "isset", "0");
                CreateNode(xmlDoc, item, "standstoreuom", "");
                CreateNode(xmlDoc, item, "defaultastuom", mod_mater_main.C_FJLDW);//辅计量单位主键
                CreateNode(xmlDoc, item, "issellproxy", "0");
                CreateNode(xmlDoc, item, "qualityday", "");
                CreateNode(xmlDoc, item, "invreservedpty", "");
                CreateNode(xmlDoc, item, "issolidconvrate", "0");
                CreateNode(xmlDoc, item, "csourcebillbid", "");//来源单据表体序列号
                CreateNode(xmlDoc, item, "csourcebillhid", "");//来源单据表头序列号
                CreateNode(xmlDoc, item, "csourcetype", "");//来源单据类型
                CreateNode(xmlDoc, item, "cspaceid", "");//货位ID
                CreateNode(xmlDoc, item, "cspacecode", "");
                CreateNode(xmlDoc, item, "cspacename", "");
                CreateNode(xmlDoc, item, "cspecialhid", "");//特殊业务单据ID
                CreateNode(xmlDoc, item, "cwarehouseid", mod_linewh.C_ID);//仓库ID
                CreateNode(xmlDoc, item, "cwarehousename", mod_linewh.C_LINEWH_NAME); //仓库描述
                CreateNode(xmlDoc, item, "isLocatorMgt", "0");
                CreateNode(xmlDoc, item, "isWasteWh", "0");
                CreateNode(xmlDoc, item, "whreservedpty", "");
                CreateNode(xmlDoc, item, "islocatormgt", "0");
                CreateNode(xmlDoc, item, "iswastewh", "0");
                CreateNode(xmlDoc, item, "whreservedpty", "");
                CreateNode(xmlDoc, item, "cyfsl", "");
                CreateNode(xmlDoc, item, "cysl", "");
                CreateNode(xmlDoc, item, "desl", "");
                CreateNode(xmlDoc, item, "dshldtransnum", strWgt); //应转数量
                CreateNode(xmlDoc, item, "dvalidate", "");//失效日期
                CreateNode(xmlDoc, item, "fbillrowflag", "2");//单据行标志
                CreateNode(xmlDoc, item, "hlzl", "");
                CreateNode(xmlDoc, item, "hsl", (Convert.ToDecimal(strWgt) / Convert.ToDecimal(strQua)).ToString("0.000000"));//换算率
                CreateNode(xmlDoc, item, "invname", mod_mater_main.C_PROD_KIND); //品种
                CreateNode(xmlDoc, item, "invspec", mod_mater_main.C_SPEC); //规格
                CreateNode(xmlDoc, item, "invtype", mod_mater_main.C_STL_GRD); //钢种
                CreateNode(xmlDoc, item, "je", "");
                CreateNode(xmlDoc, item, "jhdj", "");
                CreateNode(xmlDoc, item, "jhje", "");
                CreateNode(xmlDoc, item, "jhpdzq", "");
                CreateNode(xmlDoc, item, "measdocname", mod_mater_main.C_ZJLDWMC);
                CreateNode(xmlDoc, item, "naccountastnum", "");//帐面辅数量
                CreateNode(xmlDoc, item, "naccountnum", "");//帐面数量
                CreateNode(xmlDoc, item, "nadjustastnum", "");//调整辅数量
                CreateNode(xmlDoc, item, "nadjustnum", "");//调整数量
                CreateNode(xmlDoc, item, "ncheckastnum", "");//盘点辅数量
                CreateNode(xmlDoc, item, "nchecknum", "");//盘点数量
                CreateNode(xmlDoc, item, "nprice", "");//单价
                CreateNode(xmlDoc, item, "nmny", "");//金额
                CreateNode(xmlDoc, item, "nplannedmny", "");//计划金额
                CreateNode(xmlDoc, item, "nplannedprice", "");//计划单价
                CreateNode(xmlDoc, item, "nshldtransastnum", strQua);//应转辅数量
                CreateNode(xmlDoc, item, "pk_measdoc", mod_mater_main.C_PK_MEASDOC);////计量单位主键
                CreateNode(xmlDoc, item, "scrq", Convert.ToDateTime(mod_wgd.D_PRODUCE_DATE_E).ToString("yyyy-MM-dd"));
                CreateNode(xmlDoc, item, "sjpdzq", "");
                CreateNode(xmlDoc, item, "vbatchcode", strBatchNo);//vbatchcode
                CreateNode(xmlDoc, item, "vfree0", "");//自由项1
                CreateNode(xmlDoc, item, "vfree1", strZYX1);
                CreateNode(xmlDoc, item, "vfree2", strZYX2);
                CreateNode(xmlDoc, item, "vfree3", mod_wgd.C_PACK);
                CreateNode(xmlDoc, item, "vfree4", "");
                CreateNode(xmlDoc, item, "vfree5", "");
                CreateNode(xmlDoc, item, "vfree6", "");
                CreateNode(xmlDoc, item, "vfree7", "");
                CreateNode(xmlDoc, item, "vfree8", "");
                CreateNode(xmlDoc, item, "vfree9", "");
                CreateNode(xmlDoc, item, "vfree10", "");
                CreateNode(xmlDoc, item, "vfreename1", "");
                CreateNode(xmlDoc, item, "vfreename2", "");
                CreateNode(xmlDoc, item, "vfreename3", "");
                CreateNode(xmlDoc, item, "vfreename4", "");
                CreateNode(xmlDoc, item, "vfreename5", "");
                CreateNode(xmlDoc, item, "vfreename6", "");
                CreateNode(xmlDoc, item, "vfreename7", "");
                CreateNode(xmlDoc, item, "vfreename8", "");
                CreateNode(xmlDoc, item, "vfreename9", "");
                CreateNode(xmlDoc, item, "vfreename10", "");
                CreateNode(xmlDoc, item, "vsourcebillcode", "");//来源单据号
                CreateNode(xmlDoc, item, "vuserdef1", "");//自定义项1
                CreateNode(xmlDoc, item, "vuserdef2", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef3", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef4", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef5", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef6", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef7", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef8", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef9", "");//自定义项 
                CreateNode(xmlDoc, item, "vuserdef10", C_GP_BEFORE_ID);//自定义项
                CreateNode(xmlDoc, item, "vuserdef11", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef12", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef13", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef14", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef15", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef16", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef17", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef18", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef19", "");//自定义项
                CreateNode(xmlDoc, item, "vuserdef20", "");//自定义项
                CreateNode(xmlDoc, item, "pk_defdoc1", "");//自定义项主键1
                CreateNode(xmlDoc, item, "pk_defdoc2", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc3", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc4", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc5", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc6", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc7", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc8", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc9", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc10", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc11", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc12", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc13", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc14", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc15", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc16", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc17", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc18", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc19", "");//自定义项主键
                CreateNode(xmlDoc, item, "pk_defdoc20", "");//自定义项主键
                CreateNode(xmlDoc, item, "yy", "");
                CreateNode(xmlDoc, item, "ztsl", "");
                CreateNode(xmlDoc, item, "bkxcl", "");
                CreateNode(xmlDoc, item, "chzl", "");
                CreateNode(xmlDoc, item, "neconomicnum", "");
                CreateNode(xmlDoc, item, "nmaxstocknum", "");
                CreateNode(xmlDoc, item, "nminstocknum", strQua);  //件数
                CreateNode(xmlDoc, item, "norderpointnum", strWgt);// 重量
                CreateNode(xmlDoc, item, "xczl", "");
                CreateNode(xmlDoc, item, "nsafestocknum", "");
                CreateNode(xmlDoc, item, "fbillflag", "");//单据状态
                CreateNode(xmlDoc, item, "vfreeid1", "");
                CreateNode(xmlDoc, item, "vfreeid2", "");
                CreateNode(xmlDoc, item, "vfreeid3", "");
                CreateNode(xmlDoc, item, "vfreeid4", "");
                CreateNode(xmlDoc, item, "vfreeid5", "");
                CreateNode(xmlDoc, item, "vfreeid6", "");
                CreateNode(xmlDoc, item, "vfreeid7", "");
                CreateNode(xmlDoc, item, "vfreeid8", "");
                CreateNode(xmlDoc, item, "vfreeid9", "");
                CreateNode(xmlDoc, item, "vfreeid10", "");
                CreateNode(xmlDoc, item, "discountflag", "N");
                CreateNode(xmlDoc, item, "laborflag", "N");
                CreateNode(xmlDoc, item, "childsnum", "");
                CreateNode(xmlDoc, item, "invsetparttype", "转换前");
                CreateNode(xmlDoc, item, "partpercent", "");
                CreateNode(xmlDoc, item, "vnote", "");//备注
                CreateNode(xmlDoc, item, "vbodynote", "");//表体备注2
                CreateNode(xmlDoc, item, "ccorrespondtypename", "");
                CreateNode(xmlDoc, item, "cfirstbillbid", "");//源头单据表体ID
                CreateNode(xmlDoc, item, "cfirstbillhid", "");//源头单据表头ID
                CreateNode(xmlDoc, item, "cfirsttypename", "");
                CreateNode(xmlDoc, item, "cfirsttype", "");//源头单据类型
                CreateNode(xmlDoc, item, "csourcetypename", "");
                CreateNode(xmlDoc, item, "pk_calbody", "1001NC10000000000669");//库存组织PK
                CreateNode(xmlDoc, item, "vcalbodyname", "邢钢库存组织");
                CreateNode(xmlDoc, item, "ts", mod_wgd.D_PRODUCE_DATE_E.ToString());
                CreateNode(xmlDoc, item, "timestamp", "");
                CreateNode(xmlDoc, item, "bodyts", mod_wgd.D_PRODUCE_DATE_E.ToString());
                CreateNode(xmlDoc, item, "crowno", "1");//行号
                CreateNode(xmlDoc, item, "nperiodastnum", "");//期间业务辅数量
                CreateNode(xmlDoc, item, "nperiodnum", "");//期间业务数量
                CreateNode(xmlDoc, item, "isforeignstor", "N");
                CreateNode(xmlDoc, item, "isgathersettle", "N");
                CreateNode(xmlDoc, item, "csortrowno", "");
                CreateNode(xmlDoc, item, "cvendorid", "");//供应商
                CreateNode(xmlDoc, item, "cvendorname", "");
                CreateNode(xmlDoc, item, "pk_cubasdoc", "");//客户基本档案ID
                CreateNode(xmlDoc, item, "pk_corp", "");//公司ID
                CreateNode(xmlDoc, item, "tbatchtime", "");
                CreateNode(xmlDoc, item, "dproducedate", "");
                CreateNode(xmlDoc, item, "dvalidate", "");//失效日期
                CreateNode(xmlDoc, item, "vvendbatchcode", "");
                CreateNode(xmlDoc, item, "qualitymanflag", "");
                CreateNode(xmlDoc, item, "qualitydaynum", "");
                CreateNode(xmlDoc, item, "cqualitylevelid", mod_checkstate.C_ID);//质量等级主键？
                CreateNode(xmlDoc, item, "vnote", "");//备注
                CreateNode(xmlDoc, item, "tchecktime", mod_wgd.D_PRODUCE_DATE_E.ToString());
                CreateNode(xmlDoc, item, "vdef1", "");
                CreateNode(xmlDoc, item, "vdef2", "");
                CreateNode(xmlDoc, item, "vdef3", "");
                CreateNode(xmlDoc, item, "vdef4", "");
                CreateNode(xmlDoc, item, "vdef5", "");
                CreateNode(xmlDoc, item, "vdef6", "");
                CreateNode(xmlDoc, item, "vdef7", "");
                CreateNode(xmlDoc, item, "vdef8", "");
                CreateNode(xmlDoc, item, "vdef9", "");
                CreateNode(xmlDoc, item, "vdef10", "");
                CreateNode(xmlDoc, item, "vdef11", "");
                CreateNode(xmlDoc, item, "vdef12", "");
                CreateNode(xmlDoc, item, "vdef13", "");
                CreateNode(xmlDoc, item, "vdef14", "");
                CreateNode(xmlDoc, item, "vdef15", "");
                CreateNode(xmlDoc, item, "vdef16", "");
                CreateNode(xmlDoc, item, "vdef17", "");
                CreateNode(xmlDoc, item, "vdef18", "");
                CreateNode(xmlDoc, item, "vdef19", "");
                CreateNode(xmlDoc, item, "vdef20", "");
                CreateNode(xmlDoc, item, "naccountgrsnum", "");//帐面毛重数量
                CreateNode(xmlDoc, item, "ncheckgrsnum", "");//盘点毛重数量
                CreateNode(xmlDoc, item, "nadjustgrsnum", "");//调整毛重数量
                CreateNode(xmlDoc, item, "nshldtransgrsnum", "");//应转出毛重数量
                CreateNode(xmlDoc, item, "cspecialbid", "");
                CreateNode(xmlDoc, item, "vbatchcode_temp", "");//批号
                //CreateNode(xmlDoc, item, "cqualitylevelname", mod_wgd.C_MRSX);
                CreateNode(xmlDoc, item, "cqualitylevelname", "DP");
                CreateNode(xmlDoc, item, "vdef1", "");
                CreateNode(xmlDoc, item, "vdef2", "");
                CreateNode(xmlDoc, item, "vdef3", "");

                #endregion

                body.AppendChild(item);


                for (int i = 0; i < dt_sj_list.Rows.Count; i++)
                {
                    Mod_TQB_CHECKSTATE mod_Lev = dal_checkstate.GetModelByName_Trans(dt_sj_list.Rows[i]["C_JUDGE_LEV_ZH"].ToString(), mod_tmo_order.C_XGID);//判定等级

                    if (mod_Lev == null) return "获取判定等级信息错误！";

                    XmlNode item_gp = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);

                    #region //表体_item
                    CreateNode(xmlDoc, item_gp, "csourcetypename", "");
                    CreateNode(xmlDoc, item_gp, "cinvbasid", mod_mater_main.C_PK_INVBASDOC);//存货基本ID
                    CreateNode(xmlDoc, item_gp, "pk_invbasdoc", mod_mater_main.C_PK_INVBASDOC);
                    CreateNode(xmlDoc, item_gp, "fixedflag", "N");
                    CreateNode(xmlDoc, item_gp, "bgssl", "");
                    CreateNode(xmlDoc, item_gp, "castunitid", mod_mater_main.C_FJLDW);//辅计量单位ID
                    CreateNode(xmlDoc, item_gp, "castunitname", mod_mater_main.C_FJLDWMC);
                    CreateNode(xmlDoc, item_gp, "cinventorycode", mod_mater_main.C_MAT_CODE);//物料编码
                    CreateNode(xmlDoc, item_gp, "cinventoryid", mod_mater_main.C_PK_INVMANDOC);//存货管理ID
                    CreateNode(xmlDoc, item_gp, "cinvmanid", mod_mater_main.C_PK_INVBASDOC);
                    CreateNode(xmlDoc, item_gp, "isLotMgt", "1");
                    CreateNode(xmlDoc, item_gp, "isSerialMgt", "0");
                    CreateNode(xmlDoc, item_gp, "isValidateMgt", "0");
                    CreateNode(xmlDoc, item_gp, "isAstUOMmgt", "1");
                    CreateNode(xmlDoc, item_gp, "isFreeItemMgt", "1");
                    CreateNode(xmlDoc, item_gp, "isSet", "0");
                    CreateNode(xmlDoc, item_gp, "standStoreUOM", "");
                    CreateNode(xmlDoc, item_gp, "defaultAstUOM", mod_mater_main.C_FJLDW);
                    CreateNode(xmlDoc, item_gp, "isSellProxy", "0");
                    CreateNode(xmlDoc, item_gp, "qualityDay", "");
                    CreateNode(xmlDoc, item_gp, "invReservedPty", "");
                    CreateNode(xmlDoc, item_gp, "isSolidConvRate", "0");
                    CreateNode(xmlDoc, item_gp, "islotmgt", "1");
                    CreateNode(xmlDoc, item_gp, "isserialmgt", "0");
                    CreateNode(xmlDoc, item_gp, "isvalidatemgt", "0");
                    CreateNode(xmlDoc, item_gp, "isastuommgt", "1");
                    CreateNode(xmlDoc, item_gp, "isfreeitemmgt", "1");
                    CreateNode(xmlDoc, item_gp, "isset", "0");
                    CreateNode(xmlDoc, item_gp, "standstoreuom", "");
                    CreateNode(xmlDoc, item_gp, "defaultastuom", mod_mater_main.C_FJLDW);//辅计量单位主键
                    CreateNode(xmlDoc, item_gp, "issellproxy", "0");
                    CreateNode(xmlDoc, item_gp, "qualityday", "");
                    CreateNode(xmlDoc, item_gp, "invreservedpty", "");
                    CreateNode(xmlDoc, item_gp, "issolidconvrate", "0");
                    CreateNode(xmlDoc, item_gp, "csourcebillbid", "");//来源单据表体序列号
                    CreateNode(xmlDoc, item_gp, "csourcebillhid", "");//来源单据表头序列号
                    CreateNode(xmlDoc, item_gp, "csourcetype", "");//来源单据类型
                    CreateNode(xmlDoc, item_gp, "cspaceid", "");//货位ID
                    CreateNode(xmlDoc, item_gp, "cspacecode", "");
                    CreateNode(xmlDoc, item_gp, "cspacename", "");
                    CreateNode(xmlDoc, item_gp, "cspecialhid", "");//特殊业务单据ID
                    CreateNode(xmlDoc, item_gp, "cwarehouseid", mod_linewh.C_ID);//仓库ID
                    CreateNode(xmlDoc, item_gp, "cwarehousename", mod_linewh.C_LINEWH_NAME); //仓库描述
                    CreateNode(xmlDoc, item_gp, "isLocatorMgt", "0");
                    CreateNode(xmlDoc, item_gp, "isWasteWh", "0");
                    CreateNode(xmlDoc, item_gp, "whreservedpty", "");
                    CreateNode(xmlDoc, item_gp, "islocatormgt", "0");
                    CreateNode(xmlDoc, item_gp, "iswastewh", "0");
                    CreateNode(xmlDoc, item_gp, "whreservedpty", "");
                    CreateNode(xmlDoc, item_gp, "cyfsl", "");
                    CreateNode(xmlDoc, item_gp, "cysl", "");
                    CreateNode(xmlDoc, item_gp, "desl", "");
                    CreateNode(xmlDoc, item_gp, "dshldtransnum", dt_sj_list.Rows[i]["N_WGT"].ToString()); //应转数量
                    CreateNode(xmlDoc, item_gp, "dvalidate", "");//失效日期
                    CreateNode(xmlDoc, item_gp, "fbillrowflag", "3");//单据行标志
                    CreateNode(xmlDoc, item_gp, "hlzl", "");
                    CreateNode(xmlDoc, item_gp, "hsl", (Convert.ToDecimal(dt_sj_list.Rows[i]["N_WGT"].ToString()) / Convert.ToDecimal(dt_sj_list.Rows[i]["QUA"].ToString())).ToString("0.000000"));//换算率
                    CreateNode(xmlDoc, item_gp, "invname", mod_mater_main.C_PROD_KIND); //品种
                    CreateNode(xmlDoc, item_gp, "invspec", mod_mater_main.C_SPEC); //规格
                    CreateNode(xmlDoc, item_gp, "invtype", mod_mater_main.C_STL_GRD); //钢种
                    CreateNode(xmlDoc, item_gp, "je", "");
                    CreateNode(xmlDoc, item_gp, "jhdj", "");
                    CreateNode(xmlDoc, item_gp, "jhje", "");
                    CreateNode(xmlDoc, item_gp, "jhpdzq", "");
                    CreateNode(xmlDoc, item_gp, "measdocname", mod_mater_main.C_ZJLDWMC);
                    CreateNode(xmlDoc, item_gp, "naccountastnum", "");//帐面辅数量
                    CreateNode(xmlDoc, item_gp, "naccountnum", "");//帐面数量
                    CreateNode(xmlDoc, item_gp, "nadjustastnum", "");//调整辅数量
                    CreateNode(xmlDoc, item_gp, "nadjustnum", "");//调整数量
                    CreateNode(xmlDoc, item_gp, "ncheckastnum", "");//盘点辅数量
                    CreateNode(xmlDoc, item_gp, "nchecknum", "");//盘点数量
                    CreateNode(xmlDoc, item_gp, "nprice", "");//单价
                    CreateNode(xmlDoc, item_gp, "nmny", "");//金额
                    CreateNode(xmlDoc, item_gp, "nplannedmny", "");//计划金额
                    CreateNode(xmlDoc, item_gp, "nplannedprice", "");//计划单价
                    CreateNode(xmlDoc, item_gp, "nshldtransastnum", dt_sj_list.Rows[i]["QUA"].ToString());//应转辅数量
                    CreateNode(xmlDoc, item_gp, "pk_measdoc", mod_mater_main.C_PK_MEASDOC);////计量单位主键
                    CreateNode(xmlDoc, item_gp, "scrq", Convert.ToDateTime(mod_wgd.D_PRODUCE_DATE_E).ToString("yyyy-MM-dd"));
                    CreateNode(xmlDoc, item_gp, "sjpdzq", "");
                    CreateNode(xmlDoc, item_gp, "vbatchcode", strBatchNo);//vbatchcode
                    CreateNode(xmlDoc, item_gp, "vfree0", "");//自由项1
                    CreateNode(xmlDoc, item_gp, "vfree1", dt_sj_list.Rows[i]["C_ZYX1"].ToString());
                    CreateNode(xmlDoc, item_gp, "vfree2", dt_sj_list.Rows[i]["C_ZYX2"].ToString());
                    CreateNode(xmlDoc, item_gp, "vfree3", mod_wgd.C_PACK);
                    CreateNode(xmlDoc, item_gp, "vfree4", "");
                    CreateNode(xmlDoc, item_gp, "vfree5", "");
                    CreateNode(xmlDoc, item_gp, "vfree6", "");
                    CreateNode(xmlDoc, item_gp, "vfree7", "");
                    CreateNode(xmlDoc, item_gp, "vfree8", "");
                    CreateNode(xmlDoc, item_gp, "vfree9", "");
                    CreateNode(xmlDoc, item_gp, "vfree10", "");
                    CreateNode(xmlDoc, item_gp, "vfreename1", "");
                    CreateNode(xmlDoc, item_gp, "vfreename2", "");
                    CreateNode(xmlDoc, item_gp, "vfreename3", "");
                    CreateNode(xmlDoc, item_gp, "vfreename4", "");
                    CreateNode(xmlDoc, item_gp, "vfreename5", "");
                    CreateNode(xmlDoc, item_gp, "vfreename6", "");
                    CreateNode(xmlDoc, item_gp, "vfreename7", "");
                    CreateNode(xmlDoc, item_gp, "vfreename8", "");
                    CreateNode(xmlDoc, item_gp, "vfreename9", "");
                    CreateNode(xmlDoc, item_gp, "vfreename10", "");
                    CreateNode(xmlDoc, item_gp, "vsourcebillcode", "");//来源单据号
                    CreateNode(xmlDoc, item_gp, "vuserdef1", "");//自定义项1
                    CreateNode(xmlDoc, item_gp, "vuserdef2", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef3", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef4", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef5", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef6", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef7", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef8", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef9", "");//自定义项 
                    CreateNode(xmlDoc, item_gp, "vuserdef10", dt_sj_list.Rows[i]["C_GP_AFTER_ID"].ToString());//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef11", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef12", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef13", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef14", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef15", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef16", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef17", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef18", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef19", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "vuserdef20", "");//自定义项
                    CreateNode(xmlDoc, item_gp, "pk_defdoc1", "");//自定义项主键1
                    CreateNode(xmlDoc, item_gp, "pk_defdoc2", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc3", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc4", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc5", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc6", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc7", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc8", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc9", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc10", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc11", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc12", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc13", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc14", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc15", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc16", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc17", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc18", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc19", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "pk_defdoc20", "");//自定义项主键
                    CreateNode(xmlDoc, item_gp, "yy", "");
                    CreateNode(xmlDoc, item_gp, "ztsl", "");
                    CreateNode(xmlDoc, item_gp, "bkxcl", "");
                    CreateNode(xmlDoc, item_gp, "chzl", "");
                    CreateNode(xmlDoc, item_gp, "neconomicnum", "");
                    CreateNode(xmlDoc, item_gp, "nmaxstocknum", "");
                    CreateNode(xmlDoc, item_gp, "nminstocknum", dt_sj_list.Rows[i]["QUA"].ToString());  //件数
                    CreateNode(xmlDoc, item_gp, "norderpointnum", dt_sj_list.Rows[i]["N_WGT"].ToString());// 重量
                    CreateNode(xmlDoc, item_gp, "xczl", "");
                    CreateNode(xmlDoc, item_gp, "nsafestocknum", "");
                    CreateNode(xmlDoc, item_gp, "fbillflag", "");//单据状态
                    CreateNode(xmlDoc, item_gp, "vfreeid1", "");//?
                    CreateNode(xmlDoc, item_gp, "vfreeid2", "");//?
                    CreateNode(xmlDoc, item_gp, "vfreeid3", "");//?
                    CreateNode(xmlDoc, item_gp, "vfreeid4", "");
                    CreateNode(xmlDoc, item_gp, "vfreeid5", "");
                    CreateNode(xmlDoc, item_gp, "vfreeid6", "");
                    CreateNode(xmlDoc, item_gp, "vfreeid7", "");
                    CreateNode(xmlDoc, item_gp, "vfreeid8", "");
                    CreateNode(xmlDoc, item_gp, "vfreeid9", "");
                    CreateNode(xmlDoc, item_gp, "vfreeid10", "");
                    CreateNode(xmlDoc, item_gp, "discountflag", "N");
                    CreateNode(xmlDoc, item_gp, "laborflag", "N");
                    CreateNode(xmlDoc, item_gp, "childsnum", "");
                    CreateNode(xmlDoc, item_gp, "invsetparttype", "转换后");
                    CreateNode(xmlDoc, item_gp, "partpercent", "");
                    CreateNode(xmlDoc, item_gp, "vnote", "");//备注
                    CreateNode(xmlDoc, item_gp, "vbodynote", "");//表体备注2
                    CreateNode(xmlDoc, item_gp, "ccorrespondtypename", "");
                    CreateNode(xmlDoc, item_gp, "cfirstbillbid", "");//源头单据表体ID
                    CreateNode(xmlDoc, item_gp, "cfirstbillhid", "");//源头单据表头ID
                    CreateNode(xmlDoc, item_gp, "cfirsttypename", "");
                    CreateNode(xmlDoc, item_gp, "cfirsttype", "");//源头单据类型
                    CreateNode(xmlDoc, item_gp, "csourcetypename", "");
                    CreateNode(xmlDoc, item_gp, "pk_calbody", "1001NC10000000000669");//库存组织PK 
                    CreateNode(xmlDoc, item_gp, "vcalbodyname", "邢钢库存组织");
                    CreateNode(xmlDoc, item_gp, "ts", time.ToString());
                    CreateNode(xmlDoc, item_gp, "timestamp", "");
                    CreateNode(xmlDoc, item_gp, "bodyts", time.ToString());
                    CreateNode(xmlDoc, item_gp, "crowno", i.ToString());//行号
                    CreateNode(xmlDoc, item_gp, "nperiodastnum", "");//期间业务辅数量
                    CreateNode(xmlDoc, item_gp, "nperiodnum", "");//期间业务数量
                    CreateNode(xmlDoc, item_gp, "isforeignstor", "N");
                    CreateNode(xmlDoc, item_gp, "isgathersettle", "N");
                    CreateNode(xmlDoc, item_gp, "csortrowno", "");
                    CreateNode(xmlDoc, item_gp, "cvendorid", "");//供应商
                    CreateNode(xmlDoc, item_gp, "cvendorname", "");
                    CreateNode(xmlDoc, item_gp, "pk_cubasdoc", "");//客户基本档案ID
                    CreateNode(xmlDoc, item_gp, "pk_corp", "");//公司ID
                    CreateNode(xmlDoc, item_gp, "tbatchtime", "");
                    CreateNode(xmlDoc, item_gp, "dproducedate", "");
                    CreateNode(xmlDoc, item_gp, "dvalidate", "");//失效日期
                    CreateNode(xmlDoc, item_gp, "vvendbatchcode", "");
                    CreateNode(xmlDoc, item_gp, "qualitymanflag", "");
                    CreateNode(xmlDoc, item_gp, "qualitydaynum", "");
                    CreateNode(xmlDoc, item_gp, "cqualitylevelid", mod_Lev.C_ID);//质量等级主键？
                    CreateNode(xmlDoc, item_gp, "vnote", "");//备注
                    CreateNode(xmlDoc, item_gp, "tchecktime", time.ToString());
                    CreateNode(xmlDoc, item_gp, "vdef1", "");
                    CreateNode(xmlDoc, item_gp, "vdef2", "");
                    CreateNode(xmlDoc, item_gp, "vdef3", "");
                    CreateNode(xmlDoc, item_gp, "vdef4", "");
                    CreateNode(xmlDoc, item_gp, "vdef5", "");
                    CreateNode(xmlDoc, item_gp, "vdef6", "");
                    CreateNode(xmlDoc, item_gp, "vdef7", "");
                    CreateNode(xmlDoc, item_gp, "vdef8", "");
                    CreateNode(xmlDoc, item_gp, "vdef9", "");
                    CreateNode(xmlDoc, item_gp, "vdef10", "");
                    CreateNode(xmlDoc, item_gp, "vdef11", "");
                    CreateNode(xmlDoc, item_gp, "vdef12", "");
                    CreateNode(xmlDoc, item_gp, "vdef13", "");
                    CreateNode(xmlDoc, item_gp, "vdef14", "");
                    CreateNode(xmlDoc, item_gp, "vdef15", "");
                    CreateNode(xmlDoc, item_gp, "vdef16", "");
                    CreateNode(xmlDoc, item_gp, "vdef17", "");
                    CreateNode(xmlDoc, item_gp, "vdef18", "");
                    CreateNode(xmlDoc, item_gp, "vdef19", "");
                    CreateNode(xmlDoc, item_gp, "vdef20", "");
                    CreateNode(xmlDoc, item_gp, "naccountgrsnum", "");//帐面毛重数量
                    CreateNode(xmlDoc, item_gp, "ncheckgrsnum", "");//盘点毛重数量
                    CreateNode(xmlDoc, item_gp, "nadjustgrsnum", "");//调整毛重数量
                    CreateNode(xmlDoc, item_gp, "nshldtransgrsnum", "");//应转出毛重数量
                    CreateNode(xmlDoc, item_gp, "cspecialbid", "");
                    CreateNode(xmlDoc, item_gp, "vbatchcode_temp", "");//批号
                    CreateNode(xmlDoc, item_gp, "cqualitylevelname", dt_sj_list.Rows[i]["C_JUDGE_LEV_ZH"].ToString());
                    CreateNode(xmlDoc, item_gp, "vdef1", "");
                    CreateNode(xmlDoc, item_gp, "vdef2", "");
                    CreateNode(xmlDoc, item_gp, "vdef3", "");

                    #endregion

                    body.AppendChild(item_gp);
                }



                xmlDoc.Save(url + "\\" + urlname);
                List<string> parem = dalSendNC.SendXML(url + "\\" + urlname);
                if (parem[0] == "1")
                {
                    return "1";
                }
                else
                {
                    return parem[1].ToString();
                }

                //return "失败";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>    
        /// 创建节点    
        /// </summary>    
        /// <param name="xmldoc"></param>  xml文档  
        /// <param name="parentnode"></param>父节点    
        /// <param name="name"></param>  节点名  
        /// <param name="value"></param>  节点值  
        ///   
        private void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }

    }
}
