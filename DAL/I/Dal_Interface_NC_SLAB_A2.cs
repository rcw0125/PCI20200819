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
    public partial class Dal_Interface_NC_SLAB_A2
    {
        private Dal_Send_NC dalSendNC = new Dal_Send_NC();
        Dal_TSC_SLAB_MAIN dal_slab_main = new Dal_TSC_SLAB_MAIN();
        Dal_TB_MATRL_MAIN dal_mater_main = new Dal_TB_MATRL_MAIN();
        Dal_TPB_SLABWH dal_slabwh = new Dal_TPB_SLABWH();
        Dal_TS_USER dal_user = new Dal_TS_USER();
        Dal_TB_STD_CONFIG dal_std_config = new Dal_TB_STD_CONFIG();
        Dal_TMO_ORDER dal_tmo_order = new Dal_TMO_ORDER();
        Dal_TQB_CHECKSTATE dal_checkstate = new Dal_TQB_CHECKSTATE();
        Dal_TPP_CAST_PLAN dal_cast_plan = new Dal_TPP_CAST_PLAN();
        Dal_TSP_PLAN_SMS dal_plan_sms = new Dal_TSP_PLAN_SMS();
        Dal_TB_STA dalSta = new Dal_TB_STA();
        /// <summary>
        /// 发送炉次计划给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <param name="urlname">xml名称</param>
        /// <param name="urlname">计划表主键</param>
        /// <param name="c_stove">炉号</param>
        /// <returns></returns>
        public bool SendXml_SLAB_A2(string xmlFileName, string tsp_plan_sms_id, string stove)
        {
            try
            {
                string urlname = "A2LC" + stove + ".XML";//XML名称

                string url = xmlFileName + "\\NCXML";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }
                //DataTable dt = dal_slab_mes.GetList("", "", stove, "", "").Tables[0];
                Mod_TSP_PLAN_SMS mod_plan_sms = dal_plan_sms.GetModel(tsp_plan_sms_id); //连铸生产计划表
                Mod_TPP_CAST_PLAN mod_cast_plan = dal_cast_plan.GetModel_PLAN_ID(tsp_plan_sms_id);
                Mod_TB_MATRL_MAIN mod_mater_main = dal_mater_main.GetModel(mod_plan_sms.C_MATRL_NO);//物料主表
                Mod_TS_USER mod_ts_user = dal_user.GetModel(mod_plan_sms.C_EMP_ID);//用户主表
                Mod_TMO_ORDER mod_Order = dal_tmo_order.GetModel(mod_plan_sms.C_ORDER_NO);
                Mod_TB_STA modSta = dalSta.GetModel(mod_plan_sms.C_CCM_ID);
                if (mod_plan_sms == null) return false;
                if (mod_cast_plan == null) return false;
                if (mod_mater_main == null) return false;
                if (mod_ts_user == null) return false;
                if (mod_Order == null) return false;
                if (modSta == null) return false;


                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
                xmlDoc.AppendChild(node);

                //创建根节点  
                XmlElement root = xmlDoc.CreateElement("ufinterface");
                #region//给节点属性赋值
                root.SetAttribute("billtype", "A2");
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
                bill.SetAttribute("id", mod_cast_plan.C_HEAT_ID);
                #endregion
                root.AppendChild(bill);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "bill_head", null);

                #region //表头_order_head 
                CreateNode(xmlDoc, head, "scddh", "");//生产订单号 (空)
                CreateNode(xmlDoc, head, "pk_poid", "");//计划订单主键 (空)
                CreateNode(xmlDoc, head, "jhddh", "");//计划订单号 (空)
                CreateNode(xmlDoc, head, "wlbmid", mod_mater_main.C_PK_INVBASDOC);//物料编码ID （C_PK_INVBASDOC）
                CreateNode(xmlDoc, head, "pk_produce", "");//物料PK
                CreateNode(xmlDoc, head, "invcode", mod_mater_main.C_ID);//物料编码
                CreateNode(xmlDoc, head, "invname", "");
                CreateNode(xmlDoc, head, "pch", stove);//批次号
                CreateNode(xmlDoc, head, "scbmid", "1001NC1000000000037T");//生产部门ID
                CreateNode(xmlDoc, head, "gzzxid", modSta.C_ERP_PK);//工作中心ID-连铸机号
                CreateNode(xmlDoc, head, "gzzxbm", "");//工作中心编码ID
                CreateNode(xmlDoc, head, "ksid", "");//客商ID
                CreateNode(xmlDoc, head, "memo", "");//备注
                CreateNode(xmlDoc, head, "sfjj", "");//是否加急
                CreateNode(xmlDoc, head, "yxj", "");//有效机时
                CreateNode(xmlDoc, head, "bcid", "1001NC1000000000103W");//班次ID
                CreateNode(xmlDoc, head, "bzid", "1001NC100000002E7W1K");//班组
                CreateNode(xmlDoc, head, "jhkgrq", Convert.ToDateTime(mod_plan_sms.D_P_START_TIME.ToString()).ToString("yyyy-MM-dd"));//计划开工日期
                CreateNode(xmlDoc, head, "jhwgrq", Convert.ToDateTime(mod_plan_sms.D_P_END_TIME.ToString()).ToString("yyyy-MM-dd"));//计划完工日期
                CreateNode(xmlDoc, head, "jhkssj", Convert.ToDateTime(mod_plan_sms.D_P_START_TIME.ToString()).ToString("HH:mm:ss"));//计划开始时间
                CreateNode(xmlDoc, head, "jhjssj", Convert.ToDateTime(mod_plan_sms.D_P_END_TIME.ToString()).ToString("HH:mm:ss"));//计划结束时间
                CreateNode(xmlDoc, head, "sjkgrq", Convert.ToDateTime(mod_cast_plan.D_AIM_CASTINGSTART_TIME.ToString()).ToString("yyyy-MM-dd"));//实际开工日期
                CreateNode(xmlDoc, head, "sjwgrq", Convert.ToDateTime(mod_cast_plan.D_AIM_CASTINGEND_TIME.ToString()).ToString("yyyy-MM-dd"));//实际完工日期
                CreateNode(xmlDoc, head, "sjkssj", Convert.ToDateTime(mod_cast_plan.D_AIM_CASTINGSTART_TIME.ToString()).ToString("HH:mm:ss"));//实际开始时间
                CreateNode(xmlDoc, head, "sjjssj", Convert.ToDateTime(mod_cast_plan.D_AIM_CASTINGEND_TIME.ToString()).ToString("HH:mm:ss"));//实际结束时间
                CreateNode(xmlDoc, head, "jhwgsl", mod_plan_sms.N_SLAB_WGT.ToString());//计划完工数量
                CreateNode(xmlDoc, head, "fjhsl", mod_plan_sms.C_QUA);//辅计量数量
                CreateNode(xmlDoc, head, "jldwid", mod_mater_main.C_PK_MEASDOC);//计量单位ID
                CreateNode(xmlDoc, head, "fjlid", mod_mater_main.C_FJLDW);//辅计量ID
                CreateNode(xmlDoc, head, "sjwgsl", mod_plan_sms.N_SLAB_WGT.ToString());//实际完工数量
                CreateNode(xmlDoc, head, "fwcsl", "");
                CreateNode(xmlDoc, head, "zdy1", ""); //自定义项1
                CreateNode(xmlDoc, head, "zdy2", "");//自定义项2
                CreateNode(xmlDoc, head, "zdy3", "");//自定义项3
                CreateNode(xmlDoc, head, "zdy4", "");//自定义项4
                CreateNode(xmlDoc, head, "zdy5", "");//自定义项5
                CreateNode(xmlDoc, head, "freeitemvalue1", mod_Order.C_FREE1);
                CreateNode(xmlDoc, head, "freeitemvalue2", mod_Order.C_FREE2);
                CreateNode(xmlDoc, head, "freeitemvalue3", "");
                CreateNode(xmlDoc, head, "freeitemvalue4", "");
                CreateNode(xmlDoc, head, "freeitemvalue5", mod_plan_sms.C_ID);//PCI计划订单主键（tsp_plan_sms主键）
                CreateNode(xmlDoc, head, "pk_corp", "1001");//公司ID
                CreateNode(xmlDoc, head, "gcbm", "1001NC10000000000669");//工厂
                CreateNode(xmlDoc, head, "zdrid", mod_ts_user.C_ACCOUNT);//制单人
                CreateNode(xmlDoc, head, "pk_moid", "");//生产定单ID

                #endregion

                bill.AppendChild(head);
                XmlElement body = xmlDoc.CreateElement("bill_body");
                bill.AppendChild(body);

                XmlNode item = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);


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
