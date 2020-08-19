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
    public partial class Dal_Interface_NC_Roll_46
    {
        private readonly Dal_TB_NCIF_LOG dal_TB_NCIF_LOG = new Dal_TB_NCIF_LOG();
        private Dal_Send_NC dalSendNC = new Dal_Send_NC();

        public List<string> SendXml_ROLL_46(string cwarehouseid, string xmlFileName, List<NcRoll46> nc, string path)
        {
            try
            {

                string url = path + "\\NCXML";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }

                //Mod_TMO_CON modCon = tmo_con.GetModel(cwarehouseid);
                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
                xmlDoc.AppendChild(node);

                //创建根节点  
                XmlElement root = xmlDoc.CreateElement("ufinterface");
                #region//给节点属性赋值
                root.SetAttribute("billtype", "46");
                root.SetAttribute("filename", "123.xml");
                root.SetAttribute("isexchange", "Y");
                root.SetAttribute("operation", "req");
                root.SetAttribute("proc", "add");
                root.SetAttribute("receiver", "101");
                root.SetAttribute("replace", "Y");
                root.SetAttribute("roottag", "bill");
                root.SetAttribute("sender", "1107");
                #endregion
                xmlDoc.AppendChild(root);

                //创建子根节点
                XmlElement bill = xmlDoc.CreateElement("bill");
                #region//节点属性
                bill.SetAttribute("id", nc[0].vbatchcode);
                #endregion
                root.AppendChild(bill);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "bill_head", null);

                #region //表头_order_head

                CreateNode(xmlDoc, head, "cwarehouseid", nc[0].castunitid);

                #endregion

                bill.AppendChild(head);
                XmlElement body = xmlDoc.CreateElement("bill_body");
                bill.AppendChild(body);



                #region //表体_item
                foreach (var n in nc)
                {
                    XmlNode item = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);
                    CreateNode(xmlDoc, item, "cwarehouseid", n.cwarehouseid);//仓库ID
                    CreateNode(xmlDoc, item, "taccounttime", n.taccounttime.ToString("yyyy-MM-dd HH:mm:ss"));//库房签字时间
                    CreateNode(xmlDoc, item, "coperatorid", n.coperatorid);//制单人
                    CreateNode(xmlDoc, item, "ccheckstate_bid", n.ccheckstate_bid);//质量等级NC主键
                    CreateNode(xmlDoc, item, "cworkcenterid", n.cworkcenterid);//工作中心主键1线NC主键
                    CreateNode(xmlDoc, item, "dbizdate", n.dbizdate.ToString("yyyy-MM-dd"));//业务日期
                    CreateNode(xmlDoc, item, "vbatchcode", n.vbatchcode);//批次号
                    CreateNode(xmlDoc, item, "cinvbasid", n.cinvbasid);//存货基本ID
                    CreateNode(xmlDoc, item, "pk_produce", n.pk_produce);//物料PK C_PK_PRODUCE
                    CreateNode(xmlDoc, item, "ninnum", n.ninnum);//实入数量
                    CreateNode(xmlDoc, item, "ninassistnum", n.ninassistnum);//实入辅数量 件数
                    CreateNode(xmlDoc, item, "castunitid", n.castunitid);//辅计量单位ID
                    CreateNode(xmlDoc, item, "vfree1", n.vfree1);//自由项1
                    CreateNode(xmlDoc, item, "vfree2", n.vfree2);//自由项2
                    CreateNode(xmlDoc, item, "vfree3", n.vfree3);//自由项3
                    CreateNode(xmlDoc, item, "vfree4", "");//自由项4
                    CreateNode(xmlDoc, item, "vfree5", "");//自由项5
                    CreateNode(xmlDoc, item, "pk_corp", "1001");//公司编码 1001
                    CreateNode(xmlDoc, item, "gcbm", "");//工厂 
                    #endregion

                    body.AppendChild(item);

                }
                

                xmlDoc.Save(url + "\\" + xmlFileName);
                List<string> result = dalSendNC.SendXML(url + "\\" + xmlFileName);
                Mod_TB_NCIF_LOG log = new Mod_TB_NCIF_LOG();
                log.C_TYPE = "46";
                log.C_RESULT = result[0];
                log.C_REMARK = result[1];
                log.C_RELATIONSHIP_ID = nc[0].vbatchcode;
                dal_TB_NCIF_LOG.Add(log);
                return result;

            }
            catch
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
