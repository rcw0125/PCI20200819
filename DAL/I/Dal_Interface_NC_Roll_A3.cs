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
    public partial class Dal_Interface_NC_Roll_A3
    {

        private readonly Dal_TB_NCIF_LOG dal_TB_NCIF_LOG = new Dal_TB_NCIF_LOG();
        private Dal_Send_NC dalSendNC = new Dal_Send_NC();

        public List<string> SendXml_ROLL_A3(string zdrid, string xmlFileName, NcRollA3 nc, string path)
        {
            try
            {

                string url = path + "\\NCXML";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }

                //Mod_TMO_CON modCon = tmo_con.GetModel(zdrid);
                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
                xmlDoc.AppendChild(node);

                //创建根节点  
                XmlElement root = xmlDoc.CreateElement("ufinterface");
                #region//给节点属性赋值
                root.SetAttribute("billtype", "A3");
                root.SetAttribute("filename", "" + zdrid + ".xml");
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
                bill.SetAttribute("id", nc.hpch);
                #endregion
                root.AppendChild(bill);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "bill_head", null);

                #region //表头_order_head

                CreateNode(xmlDoc, head, "scddh", "");//生产订单号  表头是线材数据
                CreateNode(xmlDoc, head, "zdrid", nc.hzdrid);//制单人
                CreateNode(xmlDoc, head, "pch", nc.hpch);//批次号
                CreateNode(xmlDoc, head, "wlbmid", nc.hwlbmid);//物料编码ID
                CreateNode(xmlDoc, head, "jldwid", nc.hjldwid);//计量单位ID
                CreateNode(xmlDoc, head, "ylbmid", "");//用料部门ID
                CreateNode(xmlDoc, head, "bljhdh", "");//备料计划单号
                CreateNode(xmlDoc, head, "zdrq", nc.hzdrq.ToString("yyyy-MM-dd"));//制单日期  没有出出炉日期，可以编辑
                CreateNode(xmlDoc, head, "freeitemvalue1", nc.hfreeitemvalue1);
                CreateNode(xmlDoc, head, "freeitemvalue2", nc.hfreeitemvalue2);
                CreateNode(xmlDoc, head, "freeitemvalue3", nc.hfreeitemvalue3);
                CreateNode(xmlDoc, head, "freeitemvalue4", "");
                CreateNode(xmlDoc, head, "freeitemvalue5", "");
                #endregion

                bill.AppendChild(head);
                XmlElement body = xmlDoc.CreateElement("bill_body");
                bill.AppendChild(body);

                XmlNode item = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);

                #region //表体_item

                CreateNode(xmlDoc, item, "kgyid", nc.kgyid);//库管员  表体是消耗钢坯数据
                CreateNode(xmlDoc, item, "ckckid", nc.ckckid);//出库仓库ID
                CreateNode(xmlDoc, item, "ckckbm", "");
                CreateNode(xmlDoc, item, "wlbmid", nc.wlbmid);//物料编码ID
                CreateNode(xmlDoc, item, "jldwid", nc.jldwid);//计量单位ID
                CreateNode(xmlDoc, item, "fjldwid", nc.fjldwid);//辅计量单位ID
                CreateNode(xmlDoc, item, "ljcksl", nc.ljcksl);//累计出库数量
                CreateNode(xmlDoc, item, "fljcksl", nc.fljcksl);//辅累计出库数量
                CreateNode(xmlDoc, item, "pch", nc.pch);//批次号
                CreateNode(xmlDoc, item, "gzzxid", nc.gzzxid);//工作中心ID
                CreateNode(xmlDoc, item, "gxh", "");//工序号
                CreateNode(xmlDoc, item, "zdy1", "");//自定义项1
                CreateNode(xmlDoc, item, "zdy2", "");//自定义项2
                CreateNode(xmlDoc, item, "zdy3", "");//自定义项3
                CreateNode(xmlDoc, item, "zdy4", "");//自定义项4
                CreateNode(xmlDoc, item, "zdy5", "");//自定义项5
                CreateNode(xmlDoc, item, "freeitemvalue1", nc.freeitemvalue1);
                CreateNode(xmlDoc, item, "freeitemvalue2", nc.freeitemvalue2);
                CreateNode(xmlDoc, item, "freeitemvalue3", "");
                CreateNode(xmlDoc, item, "freeitemvalue4", "");
                CreateNode(xmlDoc, item, "freeitemvalue5", "");
                CreateNode(xmlDoc, item, "pk_corp", "");//公司编码
                CreateNode(xmlDoc, item, "gcbm", "");//工厂
                CreateNode(xmlDoc, item, "ccostobject", "");//成本对象ID
                CreateNode(xmlDoc, item, "flrq", nc.flrq);//发料日期
                CreateNode(xmlDoc, item, "pk_moid", "");//生产定单ID
                #endregion

                body.AppendChild(item);


                xmlDoc.Save(url + "\\" + xmlFileName);
                var result = dalSendNC.SendXML(url + "\\" + xmlFileName);
                Mod_TB_NCIF_LOG log = new Mod_TB_NCIF_LOG();
                log.C_TYPE = "A3";
                log.C_RESULT = result[0];
                log.C_REMARK = result[1];
                log.C_RELATIONSHIP_ID = nc.pch;
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
