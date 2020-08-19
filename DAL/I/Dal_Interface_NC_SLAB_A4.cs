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
    public partial class Dal_Interface_NC_SLAB_A4
    {
        private Dal_Send_NC dalSendNC = new Dal_Send_NC();
        Dal_TSC_SLAB_MAIN dal_slab_main = new Dal_TSC_SLAB_MAIN();
        Dal_TB_MATRL_MAIN dal_mater_main = new Dal_TB_MATRL_MAIN();
        Dal_TPB_SLABWH dal_slabwh = new Dal_TPB_SLABWH();
        Dal_TS_USER dal_user = new Dal_TS_USER();
        Dal_TB_STD_CONFIG dal_std_config = new Dal_TB_STD_CONFIG();
        Dal_TMO_ORDER dal_tmo_order = new Dal_TMO_ORDER();
        Dal_TQB_CHECKSTATE dal_checkstate = new Dal_TQB_CHECKSTATE();
        Dal_TSC_SLAB_MES dal_slab_mes = new Dal_TSC_SLAB_MES();
        /// <summary>
        /// 发送完工报告给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <param name="c_stove">炉号</param>
        /// <returns></returns>
        public bool SendXml_SLAB_A4(string xmlFileName, string c_stove, string strUserID)
        {
            try
            {
                string urlname = "GPWG" + c_stove + ".XML";//XML名称

                string url = xmlFileName + "\\NCXML";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }
                DataTable dt = dal_slab_mes.GetList("", "", c_stove, "", "全部").Tables[0];
                Mod_TSC_SLAB_MAIN mod_slab_main = dal_slab_main.GetModel_Stove_Trans(c_stove);//钢坯实绩
                Mod_TB_MATRL_MAIN mod_mater_main = dal_mater_main.GetModel(mod_slab_main.C_MAT_CODE);//物料主表
                Mod_TS_USER mod_ts_user = dal_user.GetModel(strUserID);//用户主表
                Mod_TPB_SLABWH mod_SLABWH = dal_slabwh.GetModel_Interface(mod_slab_main.C_SLABWH_CODE);//库存表 
                Mod_TB_STD_CONFIG mod_std_config = dal_std_config.GetModel_Interface(mod_slab_main.C_STD_CODE, mod_slab_main.C_STL_GRD);// 自由项
                if (dt == null) return false;
                if (mod_slab_main == null) return false;
                if (mod_mater_main == null) return false;
                if (mod_ts_user == null) return false;
                if (mod_SLABWH == null) return false;
                if (mod_std_config == null) return false;

                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
                xmlDoc.AppendChild(node);

                //创建根节点  
                XmlElement root = xmlDoc.CreateElement("ufinterface");
                #region//给节点属性赋值
                root.SetAttribute("billtype", "AM");
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
                bill.SetAttribute("id", mod_slab_main.C_STOVE);
                #endregion
                root.AppendChild(bill);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "bill_head", null);

                #region //表头_order_head
                CreateNode(xmlDoc, head, "zdrid", "08908");//制单人  （mod_ts_user.C_ACCOUNT）
                CreateNode(xmlDoc, head, "rq", Convert.ToDateTime(dt.Rows[0]["生产时间"].ToString()).ToString("yyyy-MM-dd"));//日期
                CreateNode(xmlDoc, head, "sj", Convert.ToDateTime(dt.Rows[0]["生产时间"].ToString()).ToString("HH:mm:ss"));//时间
                CreateNode(xmlDoc, head, "gzzxbmid", dt.Rows[0]["连铸代码"].ToString());//工作中心编码ID
                CreateNode(xmlDoc, head, "scbmid", "");//生产部门ID

                #endregion

                bill.AppendChild(head);
                XmlElement body = xmlDoc.CreateElement("bill_body");
                bill.AppendChild(body);

                XmlNode item = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);
                #region //表体_item

                CreateNode(xmlDoc, item, "pch", mod_slab_main.C_STOVE);//批次号
                CreateNode(xmlDoc, item, "scddh", "");//生产订单号
                CreateNode(xmlDoc, item, "wlbmid", mod_mater_main.C_PK_INVMANDOC);//物料编码ID（C_PK_INVMANDOC）
                CreateNode(xmlDoc, item, "jldwid", mod_mater_main.C_PK_MEASDOC);//计量单位ID
                CreateNode(xmlDoc, item, "gzzxid", dt.Rows[0]["连铸主键"].ToString());//工作中心ID
                CreateNode(xmlDoc, item, "ccxh", mod_slab_main.C_STOVE);//产出序号-炉号
                CreateNode(xmlDoc, item, "gxh", "");//工序号
                CreateNode(xmlDoc, item, "pk_produce", "");//物料PK
                CreateNode(xmlDoc, item, "ksrq", Convert.ToDateTime(dt.Rows[0]["计划开始时间"].ToString()).ToString("yyyy-MM-dd"));//开始日期
                CreateNode(xmlDoc, item, "kssj", Convert.ToDateTime(dt.Rows[0]["计划开始时间"].ToString()).ToString("HH:mm:ss"));//开始时间
                CreateNode(xmlDoc, item, "jsrq", Convert.ToDateTime(dt.Rows[0]["计划结束时间"].ToString()).ToString("yyyy-MM-dd"));//结束日期
                CreateNode(xmlDoc, item, "jssj", Convert.ToDateTime(dt.Rows[0]["计划结束时间"].ToString()).ToString("HH:mm:ss"));//结束时间
                CreateNode(xmlDoc, item, "hgsl", dt.Rows[0]["重量"].ToString());//合格数量
                CreateNode(xmlDoc, item, "fhgsl", dt.Rows[0]["支数"].ToString());//辅合格数量
                CreateNode(xmlDoc, item, "sflfcp", "N");//是否联副产品
                CreateNode(xmlDoc, item, "sffsgp", "N");//是否发生改判
                CreateNode(xmlDoc, item, "zdy1", "");//自定义项1
                CreateNode(xmlDoc, item, "zdy2", "");//自定义项2
                CreateNode(xmlDoc, item, "zdy3", "");//自定义项3
                CreateNode(xmlDoc, item, "zdy4", "");//自定义项4
                CreateNode(xmlDoc, item, "zdy5", "");//自定义项5
                CreateNode(xmlDoc, item, "freeitemvalue1", mod_std_config.C_ZYX1);
                CreateNode(xmlDoc, item, "freeitemvalue2", mod_std_config.C_ZYX2);
                CreateNode(xmlDoc, item, "freeitemvalue3", "");
                CreateNode(xmlDoc, item, "freeitemvalue4", "");
                CreateNode(xmlDoc, item, "freeitemvalue5", dt.Rows[0]["C_PLAN_ID"].ToString());//PCI计划订单主键
                CreateNode(xmlDoc, item, "pk_corp", "");//公司编码
                CreateNode(xmlDoc, item, "gcbm", "");//工厂

                #endregion

                body.AppendChild(item);


                xmlDoc.Save(url + "\\" + urlname);
                List<string> parem = dalSendNC.SendXML(url + "\\" + urlname);

                if (parem[0] == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
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
