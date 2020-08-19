using MODEL;
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
    public partial class Dal_Interface_NC_SLAB_A1_NEW
    {
        private Dal_Send_NC dalSendNC = new Dal_Send_NC();
        Dal_TB_MATRL_MAIN dal_mater_main = new Dal_TB_MATRL_MAIN();
        Dal_TPP_CAST_PLAN dal_cast_plan = new Dal_TPP_CAST_PLAN();
        Dal_TSP_PLAN_SMS dal_plan_sms = new Dal_TSP_PLAN_SMS();
        Dal_TMO_ORDER dal_tmo_order = new Dal_TMO_ORDER();
        Dal_TB_STA dalSta = new Dal_TB_STA();
        /// <summary>
        /// 发送计划给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <param name="tsp_plan_sms_id">炉号</param>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public string SendXml_SLAB_A1(string xmlFileName, string tsp_plan_sms_id, string stove,string StrOrderID)
        {
            try
            {
                string urlname = "A1LC" + stove + ".XML";//XML名称

                string url = xmlFileName + "\\NCXML";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }
                //DataTable dt = dal_slab_mes.GetList("", "", stove, "", "").Tables[0];

                Mod_TSP_PLAN_SMS mod_plan_sms = dal_plan_sms.GetModel(tsp_plan_sms_id); //连铸生产计划表
                //Mod_TPP_CAST_PLAN mod_cast_plan = dal_cast_plan.GetModel_PLAN_ID(tsp_plan_sms_id);
                Mod_TB_MATRL_MAIN mod_mater_main = dal_mater_main.GetModel(mod_plan_sms.C_MATRL_NO);//物料主表
                Mod_TMO_ORDER mod_Order = dal_tmo_order.GetModel(StrOrderID);
                Mod_TB_STA modSta = dalSta.GetModel(mod_plan_sms.C_CCM_ID);
                if (mod_plan_sms == null) return "获取连铸计划失败！";
                //if (mod_cast_plan == null) return "获取各工序计划失败！";
                if (mod_mater_main == null) return "获取物料信息失败！";
                if (mod_Order == null) return "获取订单信息失败！";
                if (modSta == null) return "获取工位信息失败！";
                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
                xmlDoc.AppendChild(node);

                //创建根节点  
                XmlElement root = xmlDoc.CreateElement("ufinterface");
                #region//给节点属性赋值
                root.SetAttribute("account", "1");
                root.SetAttribute("billtype", "A1");
                root.SetAttribute("filename", urlname);
                root.SetAttribute("isexchange", "Y");
                root.SetAttribute("proc", "add");
                root.SetAttribute("receiver", "101");
                root.SetAttribute("replace", "Y");
                root.SetAttribute("roottag", "bill");
                root.SetAttribute("sender", "1107");
                #endregion
                xmlDoc.AppendChild(root);

                //创建子根节点
                XmlElement so_order = xmlDoc.CreateElement("bill");
                //#region//节点属性
                //so_order.SetAttribute("id", dayplcode);
                //#endregiond
                root.AppendChild(so_order);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "billhead", null);

                #region //表头_order_head

                CreateNode(xmlDoc, head, "bgbz", "1");//变更标志
                CreateNode(xmlDoc, head, "bmid", "1001NC10000000000345");//部门ID
                CreateNode(xmlDoc, head, "bmmc", "");//部门名称
                CreateNode(xmlDoc, head, "bomver", "");//BOM版本
                CreateNode(xmlDoc, head, "busiDate", "");
                CreateNode(xmlDoc, head, "ckbm", ""); //仓库编码
                CreateNode(xmlDoc, head, "ckbmid", "");//仓库编码ID
                CreateNode(xmlDoc, head, "ckmc", "");//仓库名称
                CreateNode(xmlDoc, head, "curwwsl", "");
                CreateNode(xmlDoc, head, "ddlx", "1");//订单类型
                CreateNode(xmlDoc, head, "ddlxshow", "");
                CreateNode(xmlDoc, head, "durl", "");//资料路径
                CreateNode(xmlDoc, head, "fah", "");
                CreateNode(xmlDoc, head, "fjbz", "0");//分解标记
                CreateNode(xmlDoc, head, "fjldwid", "");//辅计量单位ID
                CreateNode(xmlDoc, head, "fjldwmc", "");
                CreateNode(xmlDoc, head, "gcbm", "1001NC10000000000669");//工厂
                CreateNode(xmlDoc, head, "gcbmcode", "");
                CreateNode(xmlDoc, head, "graphid", "");
                CreateNode(xmlDoc, head, "gzzxbm", "");//工作中心编码ID
                CreateNode(xmlDoc, head, "gzzxid", "");//工作中心ID
                CreateNode(xmlDoc, head, "gzzxmc", "");//工作中心名称
                CreateNode(xmlDoc, head, "hbbz", "0");//合并标志
                CreateNode(xmlDoc, head, "hsl", "");//换算率
                CreateNode(xmlDoc, head, "invspec", "");
                CreateNode(xmlDoc, head, "invtype", "");
                CreateNode(xmlDoc, head, "jhbmbm", "");
                CreateNode(xmlDoc, head, "jhddh", "");//计划订单号
                CreateNode(xmlDoc, head, "jhfaid", mod_mater_main.C_PK_PSID);//计划方案ID
                CreateNode(xmlDoc, head, "jhlx", "0");//备料计划类型(固定)
                CreateNode(xmlDoc, head, "jhrq", Convert.ToDateTime(mod_plan_sms.D_P_START_TIME).ToString("yyyy-MM-dd"));//计划日期
                CreateNode(xmlDoc, head, "jhxxsl", "");//计划下限数量
                CreateNode(xmlDoc, head, "jhyid", mod_mater_main.C_PLANEMP);//计划员ID
                CreateNode(xmlDoc, head, "jldw", "");//计量单位
                CreateNode(xmlDoc, head, "jldwid", mod_mater_main.C_PK_MEASDOC);//计量单位ID
                CreateNode(xmlDoc, head, "ksid", "");//客商ID
                CreateNode(xmlDoc, head, "memo", "");//备注
                CreateNode(xmlDoc, head, "pch", "");//批次号
                CreateNode(xmlDoc, head, "pk_corp", "1001");//公司
                CreateNode(xmlDoc, head, "pk_poid", "");//计划订单主键
                CreateNode(xmlDoc, head, "pk_produce", mod_mater_main.C_PK_PRODUCE);//物料PK
                CreateNode(xmlDoc, head, "primaryKey", "");
                CreateNode(xmlDoc, head, "pzh", "");//配置号
                CreateNode(xmlDoc, head, "qrrid", "");
                CreateNode(xmlDoc, head, "qrrq", "");
                CreateNode(xmlDoc, head, "rtver", "");
                CreateNode(xmlDoc, head, "scbmbm", "");
                CreateNode(xmlDoc, head, "scbmid", modSta.C_SSBMID);//生产部门ID
                CreateNode(xmlDoc, head, "scbmmc", "");
                CreateNode(xmlDoc, head, "scbz", "1");
                CreateNode(xmlDoc, head, "scxid", "");
                CreateNode(xmlDoc, head, "shrid", mod_plan_sms.C_EMP_ID);//操作人员
                CreateNode(xmlDoc, head, "shrq", Convert.ToDateTime(mod_plan_sms.D_P_START_TIME).ToString("yyyy-MM-dd"));//审核日期
                CreateNode(xmlDoc, head, "slrq", Convert.ToDateTime(mod_Order.D_NEED_DT).ToString("yyyy-MM-dd"));//需求日期
                CreateNode(xmlDoc, head, "unitcode", "");
                CreateNode(xmlDoc, head, "userid", "");
                CreateNode(xmlDoc, head, "wlbm", "");
                CreateNode(xmlDoc, head, "wlbmid", mod_mater_main.C_PK_INVBASDOC);
                CreateNode(xmlDoc, head, "wlmc", "");
                CreateNode(xmlDoc, head, "wpcsl", "0.00000000");
                CreateNode(xmlDoc, head, "wwlx", "OA");
                CreateNode(xmlDoc, head, "xdrq", Convert.ToDateTime(mod_plan_sms.D_P_START_TIME).ToString("yyyy-MM-dd"));//下单日期
                CreateNode(xmlDoc, head, "xqfsl", "");
                CreateNode(xmlDoc, head, "xqrq", Convert.ToDateTime(mod_Order.D_DELIVERY_DT).ToString("yyyy-MM-dd"));//交货日期
                CreateNode(xmlDoc, head, "xqsl", mod_Order.N_WGT.ToString());//计划量
                CreateNode(xmlDoc, head, "xsddh", "");
                CreateNode(xmlDoc, head, "xsddid", "");
                CreateNode(xmlDoc, head, "xxbz", "0");
                CreateNode(xmlDoc, head, "yfjsl", "");
                CreateNode(xmlDoc, head, "ypcsl", "");
                CreateNode(xmlDoc, head, "ywwsl", "");
                CreateNode(xmlDoc, head, "zdrid", mod_plan_sms.C_EMP_ID);//制单人ID
                CreateNode(xmlDoc, head, "zdrmc", "");
                CreateNode(xmlDoc, head, "zdrq", Convert.ToDateTime(mod_plan_sms.D_MOD_DT).ToString("yyyy-MM-dd"));//制单日期
                CreateNode(xmlDoc, head, "zdy1", "");
                CreateNode(xmlDoc, head, "zdy2", "其它要求");
                CreateNode(xmlDoc, head, "zdy3", "");
                CreateNode(xmlDoc, head, "zdy4", "");
                CreateNode(xmlDoc, head, "zdy5", "");
                CreateNode(xmlDoc, head, "zt", "B");
                CreateNode(xmlDoc, head, "zyx1", mod_Order.C_FREE1);//自由项1
                CreateNode(xmlDoc, head, "zyx2", mod_Order.C_FREE2);//自由项2
                CreateNode(xmlDoc, head, "zyx3", "");//自由项3
                CreateNode(xmlDoc, head, "zyx4", "");
                CreateNode(xmlDoc, head, "zyx5", mod_Order.C_ID);//pci主键
                #endregion

                so_order.AppendChild(head);

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
