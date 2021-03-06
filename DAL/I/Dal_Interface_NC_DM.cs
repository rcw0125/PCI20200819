﻿using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace DAL
{
    public partial class Dal_Interface_NC_DM
    {
        public Dal_Interface_NC_DM()
        { }
        private Dal_Send_NC dalSendNC = new Dal_Send_NC();
        Dal_TMD_DISPATCH dal_TMD_DISPATCH = new Dal_TMD_DISPATCH();
        Dal_TMD_DISPATCHDETAILS dal_fyditem = new Dal_TMD_DISPATCHDETAILS();
        Dal_TMP_DAYPLAN dal_TMP_DAYPLAN = new Dal_TMP_DAYPLAN();
        Dal_TMO_ORDER dal_TMO_ORDER = new Dal_TMO_ORDER();
        Dal_TS_CUSTFILE dal_TS_CUSTFILE = new Dal_TS_CUSTFILE();
        Dal_TMB_AREA dal_TMB_AREA = new Dal_TMB_AREA();
        Dal_TB_MATRL_MAIN dal_TB_MATRL_MAIN = new Dal_TB_MATRL_MAIN();
        Dal_TPB_LINEWH dal_TPB_LINEWH = new Dal_TPB_LINEWH();
        Dal_TPB_SLABWH dal_TPB_SLABWH = new Dal_TPB_SLABWH();
        Dal_TQB_CHECKSTATE dal_TQB_CHECKSTATE = new Dal_TQB_CHECKSTATE();
        /// <summary>
        /// 根据发运单号获取中间表数据
        /// </summary>
        /// <param name="dhstr">发运单号</param>
        /// <returns></returns>
        public DataSet GetZJBList(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_DISPATCH_ID,C_SEND_STOCK,N_NUM,C_CKDH,N_WGT,N_JZ,C_STOVE,C_BATCH_NO,C_PLAN_ID,C_STL_GRD,C_STD_CODE,C_SPEC,C_PK_NCID,C_MZDATE,N_MWGT,N_PWGT,N_MZTIME,N_PZTIME,C_PZDATE,C_ZLDJ");
            strSql.Append(" FROM TMD_DISPATCH_SJZJB WHERE 1=1 ");
            if (dhstr.Trim() != "")
            {
                strSql.Append(" AND C_DISPATCH_ID='" + dhstr + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 发送改判信息给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <returns></returns>
        public string SendXml_DM(string xmlFileName,string fydh)
        {
            try
            {
                string name = "FYSJ" + fydh + ".xml";
                xmlFileName += "\\NCXML\\" + name;
                Mod_TMD_DISPATCH modDispatch = dal_TMD_DISPATCH.GetModel(fydh);
                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
                xmlDoc.AppendChild(node);
                //创建根节点  
                XmlElement root = xmlDoc.CreateElement("ufinterface");
                #region//给节点属性赋值
                root.SetAttribute("billtype", "7F");
                root.SetAttribute("filename", name);
                root.SetAttribute("isexchange", "Y");
                root.SetAttribute("operation", "req");
                root.SetAttribute("proc", "update");
                root.SetAttribute("receiver", "101");
                root.SetAttribute("replace", "Y");
                root.SetAttribute("roottag", "bill");
                root.SetAttribute("sender", "1107");
                #endregion
                xmlDoc.AppendChild(root);

                //创建子根节点
                XmlElement bill = xmlDoc.CreateElement("bill");
                bill.SetAttribute("id", modDispatch.C_GUID);//发运单表头主键
                root.AppendChild(bill);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "bill_head", null);

                #region //表头_order_head
                CreateNode(xmlDoc, head, "apprdate", Convert.ToDateTime(modDispatch.D_APPROVE_DT).ToString("yyy-MM-dd"));//审批日期
                CreateNode(xmlDoc, head, "bconfirm", "N");
                CreateNode(xmlDoc, head, "billdate", Convert.ToDateTime(modDispatch.D_CREATE_DT).ToString("yyy-MM-dd"));//制单日期
                CreateNode(xmlDoc, head, "billnewaddtime", Convert.ToDateTime(modDispatch.D_CREATE_DT).ToString("yyy-MM-dd HH:mm:ss"));
                CreateNode(xmlDoc, head, "bisopen", "");
                CreateNode(xmlDoc, head, "bmissionbill", "N");
                CreateNode(xmlDoc, head, "bmustreturnbillcode", "");
                CreateNode(xmlDoc, head, "btestbyinvoice", "");
                CreateNode(xmlDoc, head, "clastmodifierid", modDispatch.C_EMP_ID);//最后修改人
                CreateNode(xmlDoc, head, "clastmodiname", "");
                CreateNode(xmlDoc, head, "curbilltype", "");
                CreateNode(xmlDoc, head, "dallpacknum", "0");
                CreateNode(xmlDoc, head, "dallvolumn", "0");
                CreateNode(xmlDoc, head, "dallweight", "0");
                CreateNode(xmlDoc, head, "dfactweight", "");
                CreateNode(xmlDoc, head, "dr", "0");
                CreateNode(xmlDoc, head, "dtotal", "");
                CreateNode(xmlDoc, head, "employee", "");
                CreateNode(xmlDoc, head, "h_confirmarrivedate", "");
                CreateNode(xmlDoc, head, "iprintcount", "");
                CreateNode(xmlDoc, head, "isendtype", "3");//运费类别
                CreateNode(xmlDoc, head, "linkman1", "");
                CreateNode(xmlDoc, head, "oprdepartname", "");
                CreateNode(xmlDoc, head, "phone1", "");
                CreateNode(xmlDoc, head, "pk_defdoc0", modDispatch.C_IS_WIRESALE_ID); //是否线材销售主键
                CreateNode(xmlDoc, head, "pk_defdoc1", "");
                CreateNode(xmlDoc, head, "pk_defdoc10", "");
                CreateNode(xmlDoc, head, "pk_defdoc11", "");
                CreateNode(xmlDoc, head, "pk_defdoc12", "");
                CreateNode(xmlDoc, head, "pk_defdoc13", "");
                CreateNode(xmlDoc, head, "pk_defdoc14", "");
                CreateNode(xmlDoc, head, "pk_defdoc15", "");
                CreateNode(xmlDoc, head, "pk_defdoc16", "");
                CreateNode(xmlDoc, head, "pk_defdoc17", "");
                CreateNode(xmlDoc, head, "pk_defdoc18", "");
                CreateNode(xmlDoc, head, "pk_defdoc19", "");
                CreateNode(xmlDoc, head, "pk_defdoc2", "");
                CreateNode(xmlDoc, head, "pk_defdoc3", "");
                CreateNode(xmlDoc, head, "pk_defdoc4", "");
                CreateNode(xmlDoc, head, "pk_defdoc5", "");
                CreateNode(xmlDoc, head, "pk_defdoc6", "");
                CreateNode(xmlDoc, head, "pk_defdoc7", "");
                CreateNode(xmlDoc, head, "pk_defdoc8", "");
                CreateNode(xmlDoc, head, "pk_defdoc9", "");
                CreateNode(xmlDoc, head, "pk_delivbill_h", "");//发运单表头主键
                CreateNode(xmlDoc, head, "pkapprperson", "");
                CreateNode(xmlDoc, head, "pkbillperson", modDispatch.C_CREATE_ID);//制单人
                CreateNode(xmlDoc, head, "pkcorpforgenoid", "1001");
                CreateNode(xmlDoc, head, "pkdelivmode", modDispatch.C_SHIPVIA);//发运方式主键
                CreateNode(xmlDoc, head, "pkdelivorg", "1001NC10000000006EHS");//发运组织主键固定
                CreateNode(xmlDoc, head, "pkdelivroute", "1001NC10000000006EHV");//发运路线主键 固定
                CreateNode(xmlDoc, head, "pkdriver", "");
                CreateNode(xmlDoc, head, "pkoperator", modDispatch.C_BUSINESS_ID);//业务员主键
                CreateNode(xmlDoc, head, "pkoprdepart", modDispatch.C_BUSINESS_DEPT);//业务部门主键
                CreateNode(xmlDoc, head, "pksendperson", "");
                CreateNode(xmlDoc, head, "pktrancust", modDispatch.C_COMCAR);//承运商
                CreateNode(xmlDoc, head, "pktranorg", "");
                CreateNode(xmlDoc, head, "pkvehicle", "");
                CreateNode(xmlDoc, head, "pkvehicletype", "");
                CreateNode(xmlDoc, head, "returndate", "");
                CreateNode(xmlDoc, head, "returntime", "");
                CreateNode(xmlDoc, head, "senddate", Convert.ToDateTime(modDispatch.D_DISP_DT).ToString("yyy-MM-dd"));//发运日期
                CreateNode(xmlDoc, head, "startdate", "");
                CreateNode(xmlDoc, head, "starttime", "");
                CreateNode(xmlDoc, head, "taudittime", "");
                CreateNode(xmlDoc, head, "tlastmodifytime", Convert.ToDateTime(modDispatch.D_MOD_DT).ToString("yyy-MM-dd HH:mm:ss"));//最后修改时间
                CreateNode(xmlDoc, head, "tmaketime", Convert.ToDateTime(modDispatch.D_CREATE_DT).ToString("yyy-MM-dd HH:mm:ss"));// 制单时间
                CreateNode(xmlDoc, head, "ts", Convert.ToDateTime(modDispatch.D_CREATE_DT).ToString("yyy-MM-dd HH:mm:ss"));
                CreateNode(xmlDoc, head, "userid", modDispatch.C_CREATE_ID);//制单人
                CreateNode(xmlDoc, head, "vapprpersonname", "");
                CreateNode(xmlDoc, head, "vbillpersonname", "");
                CreateNode(xmlDoc, head, "vdelivbillcode", modDispatch.C_ID);//发运单单据号
                CreateNode(xmlDoc, head, "vdoname", "");
                CreateNode(xmlDoc, head, "vdrivername", "");
                CreateNode(xmlDoc, head, "vehiclelicense", "");
                CreateNode(xmlDoc, head, "vnote", "");
                CreateNode(xmlDoc, head, "voldDelivbillcode", "");
                CreateNode(xmlDoc, head, "vroutedescr", "");
                CreateNode(xmlDoc, head, "vroutename", "");
                CreateNode(xmlDoc, head, "vsendtypename", "");
                CreateNode(xmlDoc, head, "vtranname", "");
                CreateNode(xmlDoc, head, "vtranorgname", "");
                CreateNode(xmlDoc, head, "vuserdef0", modDispatch.C_IS_WIRESALE);// 是否线材销售 是/ 否  *****             
                CreateNode(xmlDoc, head, "vuserdef1", "");
                CreateNode(xmlDoc, head, "vuserdef10", "");
                CreateNode(xmlDoc, head, "vuserdef11", "");
                CreateNode(xmlDoc, head, "vuserdef12", "");
                CreateNode(xmlDoc, head, "vuserdef13", "");
                CreateNode(xmlDoc, head, "vuserdef14", "");
                CreateNode(xmlDoc, head, "vuserdef15", "");
                CreateNode(xmlDoc, head, "vuserdef16", "");
                CreateNode(xmlDoc, head, "vuserdef17", "");
                CreateNode(xmlDoc, head, "vuserdef18", "");
                CreateNode(xmlDoc, head, "vuserdef19", "");
                CreateNode(xmlDoc, head, "vuserdef2", "");
                CreateNode(xmlDoc, head, "vuserdef3", "Y");//是否已导出
                CreateNode(xmlDoc, head, "vuserdef4", modDispatch.C_LIC_PLA_NO); //车牌号
                CreateNode(xmlDoc, head, "vuserdef5", "");
                CreateNode(xmlDoc, head, "vuserdef6", "");
                CreateNode(xmlDoc, head, "vuserdef7", "");
                CreateNode(xmlDoc, head, "vuserdef8", "");
                CreateNode(xmlDoc, head, "vuserdef9", "");
                CreateNode(xmlDoc, head, "vvehiclename", "");
                CreateNode(xmlDoc, head, "vvhcltypename", "");

                #endregion

                bill.AppendChild(head);
                XmlElement body = xmlDoc.CreateElement("bill_body");
                bill.AppendChild(body);

                DataTable dt = GetZJBList(fydh).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int rowno = i + 1;

                        Mod_TMP_DAYPLAN modDayPlan = dal_TMP_DAYPLAN.GetModel(dt.Rows[i]["C_PLAN_ID"].ToString());
                        if (modDayPlan != null)
                        {
                            #region //实体参数

                            Mod_TMO_ORDER modOrder = dal_TMO_ORDER.GetModel(modDayPlan.C_PKBILLB);
                            Mod_TPB_LINEWH mbck = dal_TPB_LINEWH.GetModel_Interface_Trans(dt.Rows[i]["C_SEND_STOCK"].ToString());//目标仓库
                            Mod_TPB_SLABWH slabwh = dal_TPB_SLABWH.GetModel_Interface_Trans(dt.Rows[i]["C_SEND_STOCK"].ToString());
                            Mod_TS_CUSTFILE modCust = dal_TS_CUSTFILE.GetCustModel(modDayPlan.C_PKCUST);//客户档案
                            Mod_TMB_AREA modArea = dal_TMB_AREA.GetModel(modDayPlan.C_PKARRIVEAREA);//区域
                            Mod_TB_MATRL_MAIN modMat = dal_TB_MATRL_MAIN.GetMatModel(modDayPlan.C_PKINV);//物料
                            Mod_TQB_CHECKSTATE mod_TQB_CHECKSTATE = dal_TQB_CHECKSTATE.GetModelByName(dt.Rows[i]["C_ZLDJ"].ToString(), "1001");
                            Mod_TMD_DISPATCHDETAILS modfyditem = dal_fyditem.GetModel(dt.Rows[i]["C_PK_NCID"].ToString());

                            string addrpk = "";
                            DataTable dtaddess = dal_TMB_AREA.GetAreaAddress(modfyditem.C_SEND_AREA).Tables[0];
                            if (dtaddess.Rows.Count > 0)
                            {
                                addrpk = dtaddess.Rows[0]["PK_ADDRESS"].ToString();
                            }
                            #endregion

                            decimal dunitprice = Convert.ToDecimal(modDayPlan.N_UNITPRICE);//含税单价
                            string wgt = dt.Rows[i]["N_WGT"].ToString();//重量
                            string jz = dt.Rows[i]["N_JZ"].ToString();//净重
                            string num = dt.Rows[i]["N_NUM"].ToString();//数量
                            decimal dmoney = dunitprice * Convert.ToDecimal(dt.Rows[i]["N_JZ"]);//订单金额

                            XmlNode item = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);

                            #region //表体_item
                            CreateNode(xmlDoc, item, "bappendent", "");
                            CreateNode(xmlDoc, item, "bcloseout", "");
                            CreateNode(xmlDoc, item, "bcloseout_old", "");
                            CreateNode(xmlDoc, item, "blargess", "N");
                            CreateNode(xmlDoc, item, "borderreturn", "N");
                            CreateNode(xmlDoc, item, "breceiveinform", "");
                            CreateNode(xmlDoc, item, "bsigned", "");
                            CreateNode(xmlDoc, item, "btestbyinvoice", "");
                            CreateNode(xmlDoc, item, "carrivecorpname", "");
                            CreateNode(xmlDoc, item, "cbiztype", modDayPlan.C_BIZTYPE);//业务类型
                            CreateNode(xmlDoc, item, "ccheckstate_bid", mod_TQB_CHECKSTATE.C_ID);//质量等级**
                            CreateNode(xmlDoc, item, "ccheckstatename", "");
                            CreateNode(xmlDoc, item, "cfreezeid", "");
                            CreateNode(xmlDoc, item, "cinvmanid", "");
                            CreateNode(xmlDoc, item, "confirmarrivedate", "");
                            CreateNode(xmlDoc, item, "cquoteunitid", modDayPlan.C_UNITID);//报价计量单位ID
                            CreateNode(xmlDoc, item, "cquoteunitname", "");
                            CreateNode(xmlDoc, item, "creceiptcorp", "");
                            CreateNode(xmlDoc, item, "creceiptcorpid", modDayPlan.C_RECEIPTCORPID);//收货单位
                            CreateNode(xmlDoc, item, "csendcorp", "");
                            CreateNode(xmlDoc, item, "csendcorpid", "");
                            CreateNode(xmlDoc, item, "dcancelassistnum", "");
                            CreateNode(xmlDoc, item, "dcancelnum", "");
                            CreateNode(xmlDoc, item, "dfee", "");
                            CreateNode(xmlDoc, item, "dfeeitem", "");
                            CreateNode(xmlDoc, item, "dinvassist",num);//辅数量-件数
                            CreateNode(xmlDoc, item, "dinvnum", wgt);//存货数量
                            CreateNode(xmlDoc, item, "dinvweight", "");
                            CreateNode(xmlDoc, item, "dmileage", "");
                            CreateNode(xmlDoc, item, "dmoney", dmoney.ToString());//订单金额
                            CreateNode(xmlDoc, item, "doutassistnum", "");
                            CreateNode(xmlDoc, item, "doutnum", "");
                            CreateNode(xmlDoc, item, "doutnummargin", "");
                            CreateNode(xmlDoc, item, "dpackboxnum", "");
                            CreateNode(xmlDoc, item, "dpacknum", "");
                            CreateNode(xmlDoc, item, "dpackvolumn", "");
                            CreateNode(xmlDoc, item, "dpackweight", "");
                            CreateNode(xmlDoc, item, "dr", "0");
                            CreateNode(xmlDoc, item, "dreturnassistnum", "");
                            CreateNode(xmlDoc, item, "dreturnnum", "");
                            CreateNode(xmlDoc, item, "dsignasnum", "");
                            CreateNode(xmlDoc, item, "dsignassistnum", "");
                            CreateNode(xmlDoc, item, "dsignnum", "");
                            CreateNode(xmlDoc, item, "dsourcerow", "");
                            CreateNode(xmlDoc, item, "dtotalout", "");
                            CreateNode(xmlDoc, item, "dunitprice", dunitprice.ToString());//含税单价
                            CreateNode(xmlDoc, item, "dvolumn", "");
                            CreateNode(xmlDoc, item, "dwaylossasnum", "");
                            CreateNode(xmlDoc, item, "dwaylossnum", "");
                            CreateNode(xmlDoc, item, "hsl", "");
                            CreateNode(xmlDoc, item, "iattitude", "");
                            CreateNode(xmlDoc, item, "ibatchstatus", "0");
                            CreateNode(xmlDoc, item, "ibetimes", "");
                            CreateNode(xmlDoc, item, "iloadnum", "");
                            CreateNode(xmlDoc, item, "ilockstatus", "");
                            CreateNode(xmlDoc, item, "ionroadtime", "");
                            CreateNode(xmlDoc, item, "ipacking", "");
                            CreateNode(xmlDoc, item, "irownumber", rowno.ToString());//行号
                            CreateNode(xmlDoc, item, "irowstatus", "0");
                            CreateNode(xmlDoc, item, "ischeckatp", "N");
                            CreateNode(xmlDoc, item, "linkman1", "");
                            CreateNode(xmlDoc, item, "nassistnetwgt", num);
                            CreateNode(xmlDoc, item, "nfeedbacknum", wgt);//回写上游数量
                            CreateNode(xmlDoc, item, "nnetwgt", jz);//净重
                            CreateNode(xmlDoc, item, "nquoteunitnum", wgt);//报价计量单位数量？-存货数量
                            CreateNode(xmlDoc, item, "nquoteunitrate", "1");//报价计量单位换算率固定
                            CreateNode(xmlDoc, item, "ntotalshouldoutnum", "");
                            CreateNode(xmlDoc, item, "orderplantime", "");
                            CreateNode(xmlDoc, item, "packsortcode", "");
                            CreateNode(xmlDoc, item, "packsortname", "");
                            CreateNode(xmlDoc, item, "phone1", "");//****?
                            CreateNode(xmlDoc, item, "pk_corp", "");
                            CreateNode(xmlDoc, item, "pk_defdoc0", "");
                            CreateNode(xmlDoc, item, "pk_defdoc1", "");
                            CreateNode(xmlDoc, item, "pk_defdoc10", "");
                            CreateNode(xmlDoc, item, "pk_defdoc11", "");
                            CreateNode(xmlDoc, item, "pk_defdoc12", "");
                            CreateNode(xmlDoc, item, "pk_defdoc13", "");
                            CreateNode(xmlDoc, item, "pk_defdoc14", "");
                            CreateNode(xmlDoc, item, "pk_defdoc15", "");
                            CreateNode(xmlDoc, item, "pk_defdoc16", "");
                            CreateNode(xmlDoc, item, "pk_defdoc17", "");
                            CreateNode(xmlDoc, item, "pk_defdoc18", "");
                            CreateNode(xmlDoc, item, "pk_defdoc19", "");
                            CreateNode(xmlDoc, item, "pk_defdoc2", "");
                            CreateNode(xmlDoc, item, "pk_defdoc3", "");
                            CreateNode(xmlDoc, item, "pk_defdoc4", "");
                            CreateNode(xmlDoc, item, "pk_defdoc5", "");
                            CreateNode(xmlDoc, item, "pk_defdoc6", "");
                            CreateNode(xmlDoc, item, "pk_defdoc7", "");
                            CreateNode(xmlDoc, item, "pk_defdoc8", "");
                            CreateNode(xmlDoc, item, "pk_defdoc9", "");
                            CreateNode(xmlDoc, item, "pk_delivbill_b", "");//置空
                            CreateNode(xmlDoc, item, "pk_delivbill_h", "");
                            CreateNode(xmlDoc, item, "pk_invbasdoc", modOrder.C_INVBASDOCID);//存货档案主键
                            CreateNode(xmlDoc, item, "pk_packsort", "");
                            CreateNode(xmlDoc, item, "pk_transcontainer", "");
                            CreateNode(xmlDoc, item, "pkarriveaddress",addrpk);//到货地点
                            CreateNode(xmlDoc, item, "pkarrivearea", modfyditem.C_SEND_AREA);//到货地区主键
                            CreateNode(xmlDoc, item, "pkarrivecorp", "");
                            CreateNode(xmlDoc, item, "pkassistmeasure", modOrder.C_FUNITID);//辅计量单位
                            CreateNode(xmlDoc, item, "pkbasinv", modOrder.C_INVBASDOCID);//存货档案主键
                            CreateNode(xmlDoc, item, "pkbasreceiptcorp", modCust.C_NC_ID);//客户主键
                            CreateNode(xmlDoc, item, "pkbassendcorp", "");
                            CreateNode(xmlDoc, item, "pkconsign", "");
                            CreateNode(xmlDoc, item, "pkcorpforgenoid", modDayPlan.C_PKSALECORP);//销售公司（1001）
                            CreateNode(xmlDoc, item, "pkcusbasdoc", modCust.C_NC_ID);//客户主键
                            CreateNode(xmlDoc, item, "pkcusmandoc", modDayPlan.C_PKCUST);//客户管理主键
                            CreateNode(xmlDoc, item, "pkcustinvoice", "");
                            CreateNode(xmlDoc, item, "pkdayplan", "");
                            CreateNode(xmlDoc, item, "pkdestrep", "");
                            CreateNode(xmlDoc, item, "pkdeststockorg", "");
                            CreateNode(xmlDoc, item, "pkinv", modOrder.C_INVENTORYID);//存货管理档案主键
                            CreateNode(xmlDoc, item, "pkinvoice", "");
                            CreateNode(xmlDoc, item, "pkitem", "");
                            CreateNode(xmlDoc, item, "pkitemperiod", "");
                            CreateNode(xmlDoc, item, "pkoperator", modDayPlan.C_PKOPERATOR);//业务员ID
                            CreateNode(xmlDoc, item, "pkoprdepart", modDayPlan.C_PKOPRDEPART);//业务员部门
                            CreateNode(xmlDoc, item, "pkorder", "");
                            CreateNode(xmlDoc, item, "pkorderplanid", "");
                            CreateNode(xmlDoc, item, "pkorderrow", "");
                            CreateNode(xmlDoc, item, "pkpackboxtype", "");
                            CreateNode(xmlDoc, item, "pksalecorp", "1001");
                            CreateNode(xmlDoc, item, "pksalegrp", modDayPlan.C_PKSALEORG);//销售组织主键
                            CreateNode(xmlDoc, item, "pksendaddress", "0001AA1000000002LFNT");//发货地点
                            CreateNode(xmlDoc, item, "pksendarea", "dqda0000000000000057");//发货地区
                            if (mbck != null)
                            {
                                CreateNode(xmlDoc, item, "pksendstock", mbck.C_ID);//发货仓库
                            }
                            else
                            {
                                CreateNode(xmlDoc, item, "pksendstock", slabwh.C_ID);//发货仓库
                            }
                            CreateNode(xmlDoc, item, "pksendstockorg", "1001NC10000000000669");//发货库存组织主键-固定
                            CreateNode(xmlDoc, item, "pksrccalbodyar", "");
                            CreateNode(xmlDoc, item, "pkunit", "");
                            CreateNode(xmlDoc, item, "plantime", "");
                            CreateNode(xmlDoc, item, "receivedate", "");
                            CreateNode(xmlDoc, item, "requireday", Convert.ToDateTime(modDayPlan.D_REQUIREDATE).ToString("yyy-MM-dd"));//要求到货日期
                            CreateNode(xmlDoc, item, "sourcebillts", "");
                            CreateNode(xmlDoc, item, "ts", "");//HH:mm:ss
                            CreateNode(xmlDoc, item, "ufdtmp", "");
                            CreateNode(xmlDoc, item, "userid", "");
                            CreateNode(xmlDoc, item, "varriveaddress", "其他地区");
                            CreateNode(xmlDoc, item, "vassistmeaname", "");
                            string batch = "";
                            if (modMat.C_MAT_TYPE=="6")
                            {
                                if (dt.Rows[i]["C_BATCH_NO"].ToString()!="")
                                {
                                    batch = dt.Rows[i]["C_BATCH_NO"].ToString();
                                }
                                else
                                {
                                    batch = dt.Rows[i]["C_STOVE"].ToString();
                                }
                            }
                            if (modMat.C_MAT_TYPE == "8")
                            {
                                batch = dt.Rows[i]["C_BATCH_NO"].ToString();
                            }
                            CreateNode(xmlDoc, item, "vbatchcode", batch);
                            CreateNode(xmlDoc, item, "vbilltype", "30");
                            CreateNode(xmlDoc, item, "vbilltypename", "");
                            CreateNode(xmlDoc, item, "vcargcode", "");
                            CreateNode(xmlDoc, item, "vconsign", "");
                            CreateNode(xmlDoc, item, "vcontainername", "");
                            CreateNode(xmlDoc, item, "vcustcode", modCust.C_NO);//客户编码
                            CreateNode(xmlDoc, item, "vcustname", modCust.C_NAME);//客户名称
                            CreateNode(xmlDoc, item, "vdayplancode", modDayPlan.C_PLCODE);//对应日计划单据号
                            CreateNode(xmlDoc, item, "vdestaddress", modfyditem.C_AREA);//收货地址
                            CreateNode(xmlDoc, item, "vdestarea", modfyditem.C_SEND_AREA);//收货地区
                            CreateNode(xmlDoc, item, "vdeststoreaddre", "");
                            CreateNode(xmlDoc, item, "vdeststorename", "");
                            CreateNode(xmlDoc, item, "vdeststoreorgname", "");
                            CreateNode(xmlDoc, item, "vfree0", "");
                            CreateNode(xmlDoc, item, "vfree1", modDayPlan.C_VFREE1);//自由项1
                            CreateNode(xmlDoc, item, "vfree10", dt.Rows[i]["C_PK_NCID"].ToString());//CRM发运单表体主键//C_PK_NCID
                            CreateNode(xmlDoc, item, "vfree2", modDayPlan.C_VFREE2);//自由项2
                            CreateNode(xmlDoc, item, "vfree3","");//包装钢坯传空
                            CreateNode(xmlDoc, item, "vfree4", "");
                            CreateNode(xmlDoc, item, "vfree5", "");
                            CreateNode(xmlDoc, item, "vfree6", "");
                            CreateNode(xmlDoc, item, "vfree7", "");
                            CreateNode(xmlDoc, item, "vfree8", modDayPlan.C_ID);//CRM发运日计划主键
                            CreateNode(xmlDoc, item, "vfree9", modDispatch.C_GUID);// CRM发运单表头主键
                            CreateNode(xmlDoc, item, "vfreeid1", "");
                            CreateNode(xmlDoc, item, "vfreeid10", "");
                            CreateNode(xmlDoc, item, "vfreeid2", "");
                            CreateNode(xmlDoc, item, "vfreeid3", "");
                            CreateNode(xmlDoc, item, "vfreeid4", "");
                            CreateNode(xmlDoc, item, "vfreeid5", "");
                            CreateNode(xmlDoc, item, "vfreeid6", "");
                            CreateNode(xmlDoc, item, "vfreeid7", "");
                            CreateNode(xmlDoc, item, "vfreeid8", "");
                            CreateNode(xmlDoc, item, "vfreeid9", "");
                            CreateNode(xmlDoc, item, "vfreename1", "");
                            CreateNode(xmlDoc, item, "vfreename10", "");
                            CreateNode(xmlDoc, item, "vfreename2", "");
                            CreateNode(xmlDoc, item, "vfreename3", "");
                            CreateNode(xmlDoc, item, "vfreename4", "");
                            CreateNode(xmlDoc, item, "vfreename5", "");
                            CreateNode(xmlDoc, item, "vfreename6", "");
                            CreateNode(xmlDoc, item, "vfreename7", "");
                            CreateNode(xmlDoc, item, "vfreename8", "");
                            CreateNode(xmlDoc, item, "vfreename9", "");
                            CreateNode(xmlDoc, item, "vinvcode", modMat.C_MAT_CODE);
                            CreateNode(xmlDoc, item, "vinvname", "");
                            CreateNode(xmlDoc, item, "vinvoicecode", "");
                            CreateNode(xmlDoc, item, "vitemname", "");
                            CreateNode(xmlDoc, item, "vitemperiodname", "");
                            CreateNode(xmlDoc, item, "vnote", "");
                            CreateNode(xmlDoc, item, "voperatorname", "");
                            CreateNode(xmlDoc, item, "voprdepartname", "");
                            CreateNode(xmlDoc, item, "vordercode", modDayPlan.C_SALECODE);//销售单据号
                            CreateNode(xmlDoc, item, "vreceiptcorpname", "");
                            CreateNode(xmlDoc, item, "vsalecorpname", "");
                            CreateNode(xmlDoc, item, "vsaleorgname", "");
                            CreateNode(xmlDoc, item, "vsendaddr", "");
                            CreateNode(xmlDoc, item, "vsendaddress", "");
                            CreateNode(xmlDoc, item, "vsendarea", "");
                            CreateNode(xmlDoc, item, "vsendcorpname", "");
                            CreateNode(xmlDoc, item, "vsendstoreaddre", "");
                            CreateNode(xmlDoc, item, "vsendstorename", "");
                            CreateNode(xmlDoc, item, "vsendstoreorgaddre", "");
                            CreateNode(xmlDoc, item, "vsendstoreorgname", "");
                            CreateNode(xmlDoc, item, "vsignname", "");
                            CreateNode(xmlDoc, item, "vsignnote", "");
                            CreateNode(xmlDoc, item, "vspec", modMat.C_SPEC);//规格
                            CreateNode(xmlDoc, item, "vsrccalbodyarname", "");
                            CreateNode(xmlDoc, item, "vtype", modMat.C_STL_GRD);//钢种
                            CreateNode(xmlDoc, item, "vunit", modMat.C_ZJLDWMC);//主计量单位名称
                            CreateNode(xmlDoc, item, "vuserdef0", "");
                            CreateNode(xmlDoc, item, "vuserdef1", dt.Rows[i]["C_MZDATE"].ToString());//计量毛重日期*****
                            CreateNode(xmlDoc, item, "vuserdef10", modDayPlan.C_CONNO);//合同号
                            CreateNode(xmlDoc, item, "vuserdef11", "");
                            CreateNode(xmlDoc, item, "vuserdef12", "");
                            CreateNode(xmlDoc, item, "vuserdef13", "");
                            CreateNode(xmlDoc, item, "vuserdef14", "");
                            CreateNode(xmlDoc, item, "vuserdef15", "");
                            CreateNode(xmlDoc, item, "vuserdef16", "");
                            CreateNode(xmlDoc, item, "vuserdef17", "");
                            CreateNode(xmlDoc, item, "vuserdef18", "");
                            CreateNode(xmlDoc, item, "vuserdef19", "");
                            CreateNode(xmlDoc, item, "vuserdef2", dt.Rows[i]["N_MWGT"].ToString());//毛重*****
                            CreateNode(xmlDoc, item, "vuserdef3", dt.Rows[i]["C_PZDATE"].ToString());//计量皮重日期****
                            CreateNode(xmlDoc, item, "vuserdef4", dt.Rows[i]["N_PWGT"].ToString());//皮重
                            CreateNode(xmlDoc, item, "vuserdef5", jz);//净重
                            CreateNode(xmlDoc, item, "vuserdef6", dt.Rows[i]["N_PWGT"].ToString());//计量毛重时间
                            CreateNode(xmlDoc, item, "vuserdef7", dt.Rows[i]["N_PZTIME"].ToString());//计量皮重时间
                            CreateNode(xmlDoc, item, "vuserdef8", "");
                            CreateNode(xmlDoc, item, "vuserdef9", "");
                            #endregion

                            body.AppendChild(item);
                        }
                    }
                }
                xmlDoc.Save(xmlFileName);
                List<string> parem = dalSendNC.SendXML(xmlFileName);
                if (parem[0] == "1")
                {
                    return "1";
                }
                else
                {
                    return parem[1];
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
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
