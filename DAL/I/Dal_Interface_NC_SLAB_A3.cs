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
    public partial class Dal_Interface_NC_SLAB_A3
    {
        private Dal_Send_NC dalSendNC = new Dal_Send_NC();

        /// <summary>
        /// 发送物料消耗信息给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <returns></returns>
        public bool SendXml_SLAB_A3(string xmlFileName)
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
                root.SetAttribute("billtype", "46");
                root.SetAttribute("filename", "");
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
                bill.SetAttribute("id", "241899256");
                #endregion
                root.AppendChild(bill);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "bill_head", null);

                #region //表头_order_head
                CreateNode(xmlDoc, head, "scddh", "");//上级生产订单号
                CreateNode(xmlDoc, head, "zdrid", "08908");//制单人
                CreateNode(xmlDoc, head, "pch", "241899256");//批次号
                CreateNode(xmlDoc, head, "wlbmid", "0001NC100000000Q7U2X");//介质物料编码ID
                CreateNode(xmlDoc, head, "jldwid", "jlda0000000000000012");//计量单位ID
                CreateNode(xmlDoc, head, "ylbmid", "");//用料部门ID
                CreateNode(xmlDoc, head, "bljhdh", "");//备料计划单号
                CreateNode(xmlDoc, head, "zdrq", "2018-04-20");//制单日期
                CreateNode(xmlDoc, head, "freeitemvalue1", "XGSWRCH15A~Q/XG231-2016");
                CreateNode(xmlDoc, head, "freeitemvalue2", "XGSWRCH15A~普通要求");
                CreateNode(xmlDoc, head, "freeitemvalue3", "");
                CreateNode(xmlDoc, head, "freeitemvalue4", "");
                CreateNode(xmlDoc, head, "freeitemvalue5", "");//PCI计划订单主键

                #endregion

                bill.AppendChild(head);
                XmlElement body = xmlDoc.CreateElement("bill_body");
                bill.AppendChild(body);

                XmlNode item = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);
                #region //表体_item
                CreateNode(xmlDoc, item, "kgyid", "08908");//库管员
                CreateNode(xmlDoc, item, "ckckid", "1006AA100000000E8U7E");//出库仓库ID
                CreateNode(xmlDoc, item, "ckckbm", "");
                CreateNode(xmlDoc, item, "wlbmid", "0001NC100000000N94EZ");//物料编码ID
                CreateNode(xmlDoc, item, "jldwid", "jlda0000000000000012");//计量单位ID
                CreateNode(xmlDoc, item, "fjldwid", "");//辅计量单位ID
                CreateNode(xmlDoc, item, "ljcksl", "0.03");//累计出库数量
                CreateNode(xmlDoc, item, "fljcksl", "");//辅累计出库数量
                CreateNode(xmlDoc, item, "pch", "171010001“袋”");//批次号
                CreateNode(xmlDoc, item, "gzzxid", "1001NC100000000015QU");//工作中心ID
                CreateNode(xmlDoc, item, "gxh", "");//工序号
                CreateNode(xmlDoc, item, "zdy1", ""); //自定义项1
                CreateNode(xmlDoc, item, "zdy2", "");//自定义项2
                CreateNode(xmlDoc, item, "zdy3", ""); //自定义项3
                CreateNode(xmlDoc, item, "zdy4", "");//自定义项4
                CreateNode(xmlDoc, item, "zdy5", "");//自定义项5
                CreateNode(xmlDoc, item, "freeitemvalue1", "");
                CreateNode(xmlDoc, item, "freeitemvalue2", "");
                CreateNode(xmlDoc, item, "freeitemvalue3", "");
                CreateNode(xmlDoc, item, "freeitemvalue4", "");
                CreateNode(xmlDoc, item, "freeitemvalue5", "");//PCI计划订单主键
                CreateNode(xmlDoc, item, "pk_corp", "");//公司
                CreateNode(xmlDoc, item, "gcbm", "");//工厂
                CreateNode(xmlDoc, item, "ccostobject", "");//成本对象ID
                CreateNode(xmlDoc, item, "flrq", "2018-04-20");//发料日期
                CreateNode(xmlDoc, item, "pk_moid", "");//生产定单ID


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
