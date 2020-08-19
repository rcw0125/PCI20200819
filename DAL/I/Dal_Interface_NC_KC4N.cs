﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace DAL
{
    public partial class Dal_Interface_NC_KC4N
    {
        private Dal_Interface_NC_KC4N dalSendNC = new Dal_Interface_NC_KC4N();

        /// <summary>
        /// 发送改判信息给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <returns></returns>
        public bool SendXml_GP(string xmlFileName)
        {
            try
            {
                //Mod_TMO_CON modCon = tmo_con.GetModel(billId);
                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
                xmlDoc.AppendChild(node);

                //创建根节点  
                XmlElement root = xmlDoc.CreateElement("ufinterface");
                #region//给节点属性赋值
                root.SetAttribute("billtype", "4N");
                root.SetAttribute("filename", "ZH1809110007.xml");
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
                bill.SetAttribute("id","PCI1001NC10000000ARPD72");//
                #endregion
                root.AppendChild(bill);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "bill_head", null);

                #region //表头_order_head
                CreateNode(xmlDoc, head, "ctjname", "");
                CreateNode(xmlDoc, head, "bz", "");
                CreateNode(xmlDoc, head, "cbilltypecode", "");//库存单据类型编码
                CreateNode(xmlDoc, head, "cinbsrid", "");//入库业务员
                CreateNode(xmlDoc, head, "cinbsrname", "");//?
                CreateNode(xmlDoc, head, "cindeptid", "");//入库部门ID
                CreateNode(xmlDoc, head, "cindeptname", "");//?
                CreateNode(xmlDoc, head, "cinwarehouseid", "");//入库仓库ID
                CreateNode(xmlDoc, head, "cinwarehousename", "");//?
                CreateNode(xmlDoc, head, "isLocatorMgtIn", "");//?
                CreateNode(xmlDoc, head, "isWasteWhIn", "");//?
                CreateNode(xmlDoc, head, "whreservedptyin", "");//?
                CreateNode(xmlDoc, head, "islocatormgtin", "");//?
                CreateNode(xmlDoc, head, "iswastewhin", "");//?
                CreateNode(xmlDoc, head, "whreservedptyin", "");//?
                CreateNode(xmlDoc, head, "coutbsor", "");//出库业务员
                CreateNode(xmlDoc, head, "coutbsorname", "");//?
                CreateNode(xmlDoc, head, "coutdeptid", "");//出库部门ID
                CreateNode(xmlDoc, head, "coutdeptname", "");//?
                CreateNode(xmlDoc, head, "coutwarehouseid", "");//出库仓库ID
                CreateNode(xmlDoc, head, "coutwarehousename", "");//?
                CreateNode(xmlDoc, head, "isLocatorMgtOut", "");//
                CreateNode(xmlDoc, head, "isWasteWhOut", "");//?
                CreateNode(xmlDoc, head, "whReservedPtyOut", "");//?
                CreateNode(xmlDoc, head, "islocatormgtout", "");//?
                CreateNode(xmlDoc, head, "iswastewhout", "");//?
                CreateNode(xmlDoc, head, "whreservedptyout", "");//?
                CreateNode(xmlDoc, head, "cshlddiliverdate", "");//应发货日期
                CreateNode(xmlDoc, head, "ctj", "");//?
                CreateNode(xmlDoc, head, "dbilldate", "2018-09-11 ");//单据日期
                CreateNode(xmlDoc, head, "nfixdisassemblymny", "");//组装拆卸费用
                CreateNode(xmlDoc, head, "pdfs", "");//?
                CreateNode(xmlDoc, head, "pk_corp", "1001 ");//公司ID
                CreateNode(xmlDoc, head, "vbillcode", "ZH1809110007 ");//单据号
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
                CreateNode(xmlDoc, head, "vuserdef11h", "");//?
                CreateNode(xmlDoc, head, "vuserdef12h", ""); //?
                CreateNode(xmlDoc, head, "vuserdef13h", ""); //?
                CreateNode(xmlDoc, head, "vuserdef14h", ""); //?
                CreateNode(xmlDoc, head, "vuserdef15h", ""); //?
                CreateNode(xmlDoc, head, "vuserdef16h", ""); //?
                CreateNode(xmlDoc, head, "vuserdef17h", ""); //?
                CreateNode(xmlDoc, head, "vuserdef18h", ""); //?
                CreateNode(xmlDoc, head, "vuserdef19h", ""); //?
                CreateNode(xmlDoc, head, "vuserdef20h", "");//?
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
                CreateNode(xmlDoc, head, "pk_defdoc1h", "");  //?
                CreateNode(xmlDoc, head, "pk_defdoc2h", "");  //?
                CreateNode(xmlDoc, head, "pk_defdoc3h", "");  //?
                CreateNode(xmlDoc, head, "pk_defdoc4h", "");  //?
                CreateNode(xmlDoc, head, "pk_defdoc5h", "");  //?
                CreateNode(xmlDoc, head, "pk_defdoc6h", "");  //?
                CreateNode(xmlDoc, head, "pk_defdoc7h", "");  //?
                CreateNode(xmlDoc, head, "pk_defdoc8h", "");  //?
                CreateNode(xmlDoc, head, "pk_defdoc9h", "");  //?
                CreateNode(xmlDoc, head, "pk_defdoc10h", ""); //?
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
                CreateNode(xmlDoc, head, "pk_defdoc11h", "");//?
                CreateNode(xmlDoc, head, "pk_defdoc12h", "");//?
                CreateNode(xmlDoc, head, "pk_defdoc13h", "");//?
                CreateNode(xmlDoc, head, "pk_defdoc14h", "");//?
                CreateNode(xmlDoc, head, "pk_defdoc15h", "");//?
                CreateNode(xmlDoc, head, "pk_defdoc16h", "");//?
                CreateNode(xmlDoc, head, "pk_defdoc17h", "");//?
                CreateNode(xmlDoc, head, "pk_defdoc18h", "");//?
                CreateNode(xmlDoc, head, "pk_defdoc19h", "");//?
                CreateNode(xmlDoc, head, "pk_defdoc20h", "");//?
                CreateNode(xmlDoc, head, "vuserdef1h", "");//?
                CreateNode(xmlDoc, head, "vuserdef2h", "");//?
                CreateNode(xmlDoc, head, "vuserdef3h", "");//?
                CreateNode(xmlDoc, head, "vuserdef4h", "");//?
                CreateNode(xmlDoc, head, "vuserdef5h", "");//?
                CreateNode(xmlDoc, head, "vuserdef6h", "");//?
                CreateNode(xmlDoc, head, "vuserdef7h", "");//?
                CreateNode(xmlDoc, head, "vuserdef8h", "");//?
                CreateNode(xmlDoc, head, "vuserdef9h", "");//?
                CreateNode(xmlDoc, head, "vuserdef10h", "");//?
                CreateNode(xmlDoc, head, "cauditorid", "");//审核人
                CreateNode(xmlDoc, head, "cauditorname", "");//
                CreateNode(xmlDoc, head, "coperatorid", "1006AA100000001UWF9G ");//制单人主键
                CreateNode(xmlDoc, head, "coperatorname", "高娜 ");//制单人名称
                CreateNode(xmlDoc, head, "vadjuster", "");//调整人
                CreateNode(xmlDoc, head, "vadjustername", "");//?
                CreateNode(xmlDoc, head, "coperatoridnow", "");//?
                CreateNode(xmlDoc, head, "ctjname", "");//?
                CreateNode(xmlDoc, head, "pk_calbody_in", "");//?
                CreateNode(xmlDoc, head, "pk_calbody_out", "");//?
                CreateNode(xmlDoc, head, "vcalbody_inname", "");//?
                CreateNode(xmlDoc, head, "vcalbody_outname", "");//?
                CreateNode(xmlDoc, head, "ts", "2018-09-11 11:37:55");//?
                CreateNode(xmlDoc, head, "timestamp", "");//?
                CreateNode(xmlDoc, head, "headts", "2018-09-11 11:37:55");//?
                CreateNode(xmlDoc, head, "isforeignstor_in", "N ");//?
                CreateNode(xmlDoc, head, "isgathersettle_in", "N ");//?
                CreateNode(xmlDoc, head, "isforeignstor_out", "N ");//?
                CreateNode(xmlDoc, head, "isgathersettle_out", "N ");//?
                CreateNode(xmlDoc, head, "icheckmode", "");//盘点方式
                CreateNode(xmlDoc, head, "fassistantflag", "N ");//是否计算期间业务量
                CreateNode(xmlDoc, head, "fbillflag", "");//单据状态
                CreateNode(xmlDoc, head, "vostatus", "");//?
                CreateNode(xmlDoc, head, "iprintcount", "");//打印次数
                CreateNode(xmlDoc, head, "clastmodiid", "1006AA100000001UWF9G");//最后修改人
                CreateNode(xmlDoc, head, "clastmodiname", "");//?
                CreateNode(xmlDoc, head, "tlastmoditime", "2018-09-11 11:37:55 ");//最后修改时间
                CreateNode(xmlDoc, head, "cnxtbilltypecode", "");//?
                CreateNode(xmlDoc, head, "cspecialhid", "");//特殊业务单据ID
                #endregion

                bill.AppendChild(head);
                XmlElement body = xmlDoc.CreateElement("bill_body");
                bill.AppendChild(body);

                XmlNode item = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);
                #region //表体_item
                CreateNode(xmlDoc, item, "csourcetypename", "");//?
                CreateNode(xmlDoc, item, "cinvbasid", "0001NC100000000NM9PQ");//存货基本ID
                CreateNode(xmlDoc, item, "pk_invbasdoc", "0001NC100000000NM9PQ");//?
                CreateNode(xmlDoc, item, "fixedflag", "N");//?
                CreateNode(xmlDoc, item, "bgssl", "");//?
                CreateNode(xmlDoc, item, "castunitid", "jlda0000000000000041");//辅计量单位ID
                CreateNode(xmlDoc, item, "castunitname", "件【线材】");//?
                CreateNode(xmlDoc, item, "cinventorycode", "8011067200");//物料编码
                CreateNode(xmlDoc, item, "cinventoryid", "1001NC1000000046COMF");//存货管理ID
                CreateNode(xmlDoc, item, "cinvmanid", "0001NC100000000NM9PQ");//?
                CreateNode(xmlDoc, item, "isLotMgt", "1");//?
                CreateNode(xmlDoc, item, "isSerialMgt", "0");//?
                CreateNode(xmlDoc, item, "isValidateMgt", "0");//?
                CreateNode(xmlDoc, item, "isAstUOMmgt", "1");//?
                CreateNode(xmlDoc, item, "isFreeItemMgt", "1");//?
                CreateNode(xmlDoc, item, "isSet", "0");//?
                CreateNode(xmlDoc, item, "standStoreUOM", "");//?
                CreateNode(xmlDoc, item, "defaultAstUOM", "jlda0000000000000041");//?
                CreateNode(xmlDoc, item, "isSellProxy", "0");//?
                CreateNode(xmlDoc, item, "qualityDay", "");//?
                CreateNode(xmlDoc, item, "invReservedPty", "");//?
                CreateNode(xmlDoc, item, "isSolidConvRate", "0");//?
                CreateNode(xmlDoc, item, "islotmgt", "1");//?
                CreateNode(xmlDoc, item, "isserialmgt", "0");//?
                CreateNode(xmlDoc, item, "isvalidatemgt", "0");//?
                CreateNode(xmlDoc, item, "isastuommgt", "1");//?
                CreateNode(xmlDoc, item, "isfreeitemmgt", "1");//?
                CreateNode(xmlDoc, item, "isset", "0");//?
                CreateNode(xmlDoc, item, "standstoreuom", "");//?
                CreateNode(xmlDoc, item, "defaultastuom", "jlda0000000000000041");//辅计量单位主键
                CreateNode(xmlDoc, item, "issellproxy", "0");//?
                CreateNode(xmlDoc, item, "qualityday", "");//?
                CreateNode(xmlDoc, item, "invreservedpty", "");//?
                CreateNode(xmlDoc, item, "issolidconvrate", "0");//?
                CreateNode(xmlDoc, item, "csourcebillbid", "");//来源单据表体序列号
                CreateNode(xmlDoc, item, "csourcebillhid", "");//来源单据表头序列号
                CreateNode(xmlDoc, item, "csourcetype", "");//来源单据类型
                CreateNode(xmlDoc, item, "cspaceid", "");//货位ID
                CreateNode(xmlDoc, item, "cspacecode", "");//?
                CreateNode(xmlDoc, item, "cspacename", "");//?
                CreateNode(xmlDoc, item, "cspecialhid", "");//特殊业务单据ID
                CreateNode(xmlDoc, item, "cwarehouseid", "1001NC100000002K8KOK");//仓库ID
                CreateNode(xmlDoc, item, "cwarehousename", "钢材市场线材仓库610");//?
                CreateNode(xmlDoc, item, "isLocatorMgt", "0");//?
                CreateNode(xmlDoc, item, "isWasteWh", "0");//?
                CreateNode(xmlDoc, item, "whreservedpty", "");//?
                CreateNode(xmlDoc, item, "islocatormgt", "0");//?
                CreateNode(xmlDoc, item, "iswastewh", "0");//?
                CreateNode(xmlDoc, item, "whreservedpty", "");//?
                CreateNode(xmlDoc, item, "cyfsl", "");//?
                CreateNode(xmlDoc, item, "cysl", "");//?
                CreateNode(xmlDoc, item, "desl", "");//?
                CreateNode(xmlDoc, item, "dshldtransnum", "46.000000");//应转数量
                CreateNode(xmlDoc, item, "dvalidate", "");//失效日期
                CreateNode(xmlDoc, item, "fbillrowflag", "2");//单据行标志
                CreateNode(xmlDoc, item, "hlzl", "");//?
                CreateNode(xmlDoc, item, "hsl", "2");//换算率
                CreateNode(xmlDoc, item, "invname", "高速线材");//?
                CreateNode(xmlDoc, item, "invspec", "φ20mm");//?
                CreateNode(xmlDoc, item, "invtype", "ML15Al");//?
                CreateNode(xmlDoc, item, "je", "");//?
                CreateNode(xmlDoc, item, "jhdj", "");//?
                CreateNode(xmlDoc, item, "jhje", "");//?
                CreateNode(xmlDoc, item, "jhpdzq", "");//？
                CreateNode(xmlDoc, item, "measdocname", "吨");//？
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
                CreateNode(xmlDoc, item, "nshldtransastnum", "23.00");//应转辅数量
                CreateNode(xmlDoc, item, "pk_measdoc", "jlda0000000000000012");////计量单位主键
                CreateNode(xmlDoc, item, "scrq", "2018-09-10");//？
                CreateNode(xmlDoc, item, "sjpdzq", "");//？
                CreateNode(xmlDoc, item, "vbatchcode", "351808074");//vbatchcode
                CreateNode(xmlDoc, item, "vfree0", "[ML15Al产品标准:ML15Al~协议][ML15Al技术要求:ML15Al~JSKZ-534-45][包装要求:D1]");
                CreateNode(xmlDoc, item, "vfree1", "ML15Al~协议");
                CreateNode(xmlDoc, item, "vfree2", "ML15Al~JSKZ-534-45");
                CreateNode(xmlDoc, item, "vfree3", "D1");
                CreateNode(xmlDoc, item, "vfree4", "");
                CreateNode(xmlDoc, item, "vfree5", "");
                CreateNode(xmlDoc, item, "vfree6", "");
                CreateNode(xmlDoc, item, "vfree7", "");
                CreateNode(xmlDoc, item, "vfree8", "");
                CreateNode(xmlDoc, item, "vfree9", "");
                CreateNode(xmlDoc, item, "vfree10", "");
                CreateNode(xmlDoc, item, "vfreename1", "ML15Al产品标准");
                CreateNode(xmlDoc, item, "vfreename2", "ML15Al技术要求");
                CreateNode(xmlDoc, item, "vfreename3", "包装要求");
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
                CreateNode(xmlDoc, item, "vuserdef10", "1234567989789456123");//自定义项
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
                CreateNode(xmlDoc, item, "yy", "");//？
                CreateNode(xmlDoc, item, "ztsl", "");//？
                CreateNode(xmlDoc, item, "bkxcl", "");//？
                CreateNode(xmlDoc, item, "chzl", "");//？
                CreateNode(xmlDoc, item, "neconomicnum", "");//?
                CreateNode(xmlDoc, item, "nmaxstocknum", "");//?
                CreateNode(xmlDoc, item, "nminstocknum", "23");//?
                CreateNode(xmlDoc, item, "norderpointnum", "47.169");//?
                CreateNode(xmlDoc, item, "xczl", "");//?
                CreateNode(xmlDoc, item, "nsafestocknum", "");//?
                CreateNode(xmlDoc, item, "fbillflag", "");//单据状态
                CreateNode(xmlDoc, item, "vfreeid1", "0001NC100000000N81YJ"); //?
                CreateNode(xmlDoc, item, "vfreeid2", "0001NC100000000N81YI"); //?
                CreateNode(xmlDoc, item, "vfreeid3", "0001NC10000000001Y8M"); //?
                CreateNode(xmlDoc, item, "vfreeid4", "");//?
                CreateNode(xmlDoc, item, "vfreeid5", "");//?
                CreateNode(xmlDoc, item, "vfreeid6", "");//?
                CreateNode(xmlDoc, item, "vfreeid7", "");//?
                CreateNode(xmlDoc, item, "vfreeid8", "");//?
                CreateNode(xmlDoc, item, "vfreeid9", "");//?
                CreateNode(xmlDoc, item, "vfreeid10", "");//?
                CreateNode(xmlDoc, item, "discountflag", "N");//?
                CreateNode(xmlDoc, item, "laborflag", "N");//?
                CreateNode(xmlDoc, item, "childsnum", "");//?
                CreateNode(xmlDoc, item, "invsetparttype", "转换前");//?
                CreateNode(xmlDoc, item, "partpercent", "");//?
                CreateNode(xmlDoc, item, "vnote", "");//备注
                CreateNode(xmlDoc, item, "vbodynote", "");//表体备注2
                CreateNode(xmlDoc, item, "ccorrespondtypename", "");//?
                CreateNode(xmlDoc, item, "cfirstbillbid", "");//源头单据表体ID
                CreateNode(xmlDoc, item, "cfirstbillhid", "");//源头单据表头ID
                CreateNode(xmlDoc, item, "cfirsttypename", "");
                CreateNode(xmlDoc, item, "cfirsttype", "");//源头单据类型
                CreateNode(xmlDoc, item, "csourcetypename", "");//?
                CreateNode(xmlDoc, item, "pk_calbody", "1001NC10000000000669");//库存组织PK
                CreateNode(xmlDoc, item, "vcalbodyname", "邢钢库存组织");//?
                CreateNode(xmlDoc, item, "ts", "2018-09-11 11:37:55");//?
                CreateNode(xmlDoc, item, "timestamp", "");//?
                CreateNode(xmlDoc, item, "bodyts", "2018-09-11 11:37:55");//?
                CreateNode(xmlDoc, item, "crowno", "10");//行号
                CreateNode(xmlDoc, item, "nperiodastnum", "");//期间业务辅数量
                CreateNode(xmlDoc, item, "nperiodnum", "");//期间业务数量
                CreateNode(xmlDoc, item, "isforeignstor", "N");//?
                CreateNode(xmlDoc, item, "isgathersettle", "N");//?
                CreateNode(xmlDoc, item, "csortrowno", "");//?
                CreateNode(xmlDoc, item, "cvendorid", "");//供应商
                CreateNode(xmlDoc, item, "cvendorname", "");//?
                CreateNode(xmlDoc, item, "pk_cubasdoc", "");//客户基本档案ID
                CreateNode(xmlDoc, item, "pk_corp", "");//公司ID
                CreateNode(xmlDoc, item, "tbatchtime", "");//?
                CreateNode(xmlDoc, item, "dproducedate", "");//?
                CreateNode(xmlDoc, item, "dvalidate", "");//失效日期
                CreateNode(xmlDoc, item, "vvendbatchcode", "");//?
                CreateNode(xmlDoc, item, "qualitymanflag", "");//?
                CreateNode(xmlDoc, item, "qualitydaynum", "");//?
                CreateNode(xmlDoc, item, "cqualitylevelid", "1001NC100000000052ZK");//?
                CreateNode(xmlDoc, item, "vnote", "");//备注
                CreateNode(xmlDoc, item, "tchecktime", "2018-09-09 00:37:29");//?
                CreateNode(xmlDoc, item, "vdef1", ""); //？
                CreateNode(xmlDoc, item, "vdef2", ""); //？
                CreateNode(xmlDoc, item, "vdef3", ""); //？
                CreateNode(xmlDoc, item, "vdef4", ""); //？
                CreateNode(xmlDoc, item, "vdef5", ""); //？
                CreateNode(xmlDoc, item, "vdef6", ""); //？
                CreateNode(xmlDoc, item, "vdef7", ""); //？
                CreateNode(xmlDoc, item, "vdef8", ""); //？
                CreateNode(xmlDoc, item, "vdef9", ""); //？
                CreateNode(xmlDoc, item, "vdef10", "");//？
                CreateNode(xmlDoc, item, "vdef11", "");//？
                CreateNode(xmlDoc, item, "vdef12", "");//？
                CreateNode(xmlDoc, item, "vdef13", "");//？
                CreateNode(xmlDoc, item, "vdef14", "");//？
                CreateNode(xmlDoc, item, "vdef15", "");//？
                CreateNode(xmlDoc, item, "vdef16", "");//？
                CreateNode(xmlDoc, item, "vdef17", "");//？
                CreateNode(xmlDoc, item, "vdef18", "");//？
                CreateNode(xmlDoc, item, "vdef19", "");//？
                CreateNode(xmlDoc, item, "vdef20", "");//？
                CreateNode(xmlDoc, item, "naccountgrsnum", "");//帐面毛重数量
                CreateNode(xmlDoc, item, "ncheckgrsnum", "");//盘点毛重数量
                CreateNode(xmlDoc, item, "nadjustgrsnum", "");//调整毛重数量
                CreateNode(xmlDoc, item, "nshldtransgrsnum", "");//应转出毛重数量
                CreateNode(xmlDoc, item, "cspecialbid", "");//?
                CreateNode(xmlDoc, item, "vbatchcode_temp", "351808074");//？
                CreateNode(xmlDoc, item, "cqualitylevelname", "DP");//？
                CreateNode(xmlDoc, item, "vdef1", "");//？
                CreateNode(xmlDoc, item, "vdef2", "");//？
                CreateNode(xmlDoc, item, "vdef3", "");//？



                #endregion

                body.AppendChild(item);


                xmlDoc.Save(xmlFileName);

                //List<string> parem = dalSendNC.SendXML(xmlFileName);
                //parem.Add(dayplcode);
                //parem.Add(empID);
                //parem.Add("发运单");

                ////日志
                //AddLog(parem);

                //if (parem[2] == "成功")
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}

                return false;
            }
            catch
            {
                return false;
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