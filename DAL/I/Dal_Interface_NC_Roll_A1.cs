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
    public partial class Dal_Interface_NC_Roll_A1
    {
        private readonly Dal_TB_NCIF_LOG dal_TB_NCIF_LOG = new Dal_TB_NCIF_LOG();
        private Dal_Send_NC dalSendNC = new Dal_Send_NC();

        public List<string> SendXml_ROLL_A1(string dayplcode, string xmlFileName, NcRollA1 nc, string path)
        {
            try
            {
                string url = path + "\\NCXML";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }

                //Bll_TMP_DAYPLAN tmp_dayplan = new Bll_TMP_DAYPLAN();
                //Mod_TMP_DAYPLAN modPlan = tmp_dayplan.GetModel(dayplcode);

                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
                xmlDoc.AppendChild(node);

                //创建根节点  
                XmlElement root = xmlDoc.CreateElement("ufinterface");
                #region//给节点属性赋值
                root.SetAttribute("account", "1");
                root.SetAttribute("billtype", "A1");
                root.SetAttribute("filename", "" + dayplcode + ".xml");
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
                CreateNode(xmlDoc, head, "bmid", nc.bmid);//部门ID  用下发计划人查询部门
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
                CreateNode(xmlDoc, head, "jhfaid", nc.jhfaid);//计划方案ID
                CreateNode(xmlDoc, head, "jhlx", "0");//备料计划类型(固定)
                CreateNode(xmlDoc, head, "jhrq", nc.jhrq.ToString("yyyy-MM-dd"));//计划日期
                CreateNode(xmlDoc, head, "jhxxsl", nc.jhxxsl);//计划下限数量
                CreateNode(xmlDoc, head, "jhyid", nc.jhyid);//计划员ID
                CreateNode(xmlDoc, head, "jldw", "");//计量单位
                CreateNode(xmlDoc, head, "jldwid", nc.jldwid);//计量单位ID
                CreateNode(xmlDoc, head, "ksid", "");//客商ID
                CreateNode(xmlDoc, head, "memo", nc.memo);//备注
                CreateNode(xmlDoc, head, "pch", "");//批次号
                CreateNode(xmlDoc, head, "pk_corp", "1001");//公司
                CreateNode(xmlDoc, head, "pk_poid", "");//计划订单主键
                CreateNode(xmlDoc, head, "pk_produce", nc.pk_produce);//物料PK
                CreateNode(xmlDoc, head, "primaryKey", "");
                CreateNode(xmlDoc, head, "pzh", "");//配置号
                CreateNode(xmlDoc, head, "qrrid", "");
                CreateNode(xmlDoc, head, "qrrq", "");
                CreateNode(xmlDoc, head, "rtver", "");
                CreateNode(xmlDoc, head, "scbmbm", "");
                CreateNode(xmlDoc, head, "scbmid", nc.scbmid);//生产部门ID
                CreateNode(xmlDoc, head, "scbmmc", "");
                CreateNode(xmlDoc, head, "scbz", "1");
                CreateNode(xmlDoc, head, "scxid", "");
                CreateNode(xmlDoc, head, "shrid", nc.shrid);
                CreateNode(xmlDoc, head, "shrq", nc.shrq.ToString("yyyy-MM-dd"));
                CreateNode(xmlDoc, head, "slrq", nc.slrq.ToString("yyyy-MM-dd"));
                CreateNode(xmlDoc, head, "unitcode", "");
                CreateNode(xmlDoc, head, "userid", "");
                CreateNode(xmlDoc, head, "wlbm", "");
                CreateNode(xmlDoc, head, "wlbmid", nc.wlbmid);
                CreateNode(xmlDoc, head, "wlmc", "");
                CreateNode(xmlDoc, head, "wpcsl", "0.00000000");
                CreateNode(xmlDoc, head, "wwlx", "OA");
                CreateNode(xmlDoc, head, "xdrq", nc.xdrq.ToString("yyyy-MM-dd"));
                CreateNode(xmlDoc, head, "xqfsl", "");
                CreateNode(xmlDoc, head, "xqrq", nc.xqrq.ToString("yyyy-MM-dd"));
                CreateNode(xmlDoc, head, "xqsl", nc.xqsl);
                CreateNode(xmlDoc, head, "xsddh", "");
                CreateNode(xmlDoc, head, "xsddid", "");
                CreateNode(xmlDoc, head, "xxbz", "0");
                CreateNode(xmlDoc, head, "yfjsl", "");
                CreateNode(xmlDoc, head, "ypcsl", "");
                CreateNode(xmlDoc, head, "ywwsl", "");
                CreateNode(xmlDoc, head, "zdrid", nc.shrid);
                CreateNode(xmlDoc, head, "zdrmc", "");
                CreateNode(xmlDoc, head, "zdrq", nc.zdrq.ToString("yyyy-MM-dd"));
                CreateNode(xmlDoc, head, "zdy1", "");
                CreateNode(xmlDoc, head, "zdy2", "其它要求");
                CreateNode(xmlDoc, head, "zdy3", "");
                CreateNode(xmlDoc, head, "zdy4", "火运");
                CreateNode(xmlDoc, head, "zdy5", "特级");
                CreateNode(xmlDoc, head, "zt", "B");
                CreateNode(xmlDoc, head, "zyx1", nc.zyx1);
                CreateNode(xmlDoc, head, "zyx2", nc.zyx2);
                CreateNode(xmlDoc, head, "zyx3", nc.zyx3);
                CreateNode(xmlDoc, head, "zyx4", "");
                CreateNode(xmlDoc, head, "zyx5", nc.zyx5);//pci主键
                #endregion

                so_order.AppendChild(head);
                xmlDoc.Save(url + "\\" + xmlFileName);
                var result = dalSendNC.SendXML(url + "\\" + xmlFileName);
                Mod_TB_NCIF_LOG log = new Mod_TB_NCIF_LOG();
                log.C_TYPE = "A1";
                log.C_RESULT = result[0];
                log.C_REMARK = result[1];
                log.C_RELATIONSHIP_ID = nc.zyx5;
                dal_TB_NCIF_LOG.Add(log);
                return result;
            }
            catch (Exception ex)
            {
                return null;
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
