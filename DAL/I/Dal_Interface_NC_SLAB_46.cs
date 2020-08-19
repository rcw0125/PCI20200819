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
    public partial class Dal_Interface_NC_SLAB_46
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
        /// 发送入库实绩给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <param name="c_stove">炉号</param>
        /// <param name="user_id">操作人员</param>
        /// <returns></returns>
        public bool SendXml_SLAB_46(string xmlFileName, string c_stove,string user_id)
        {
            try
            {
                string urlname = "GPRK" + c_stove + ".XML";//XML名称

                string url = xmlFileName + "\\NCXML";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }
                DataTable dt = dal_slab_mes.GetList("", "", c_stove, "", "全部").Tables[0];
                Mod_TSC_SLAB_MAIN mod_slab_main = dal_slab_main.GetModel_Stove_Trans(c_stove);//钢坯实绩
                Mod_TB_MATRL_MAIN mod_mater_main = dal_mater_main.GetModel(mod_slab_main.C_MAT_CODE);//物料主表
                Mod_TS_USER mod_ts_user = dal_user.GetModel(user_id);//用户主表
                Mod_TPB_SLABWH mod_SLABWH = dal_slabwh.GetModel_Interface(mod_slab_main.C_SLABWH_CODE);//库存表 
                Mod_TB_STD_CONFIG mod_std_config = dal_std_config.GetModel_Interface(mod_slab_main.C_STD_CODE, mod_slab_main.C_STL_GRD);// 自由项
                Mod_TMO_ORDER mod_tmo_order = dal_tmo_order.GetModelByORDERNO(mod_slab_main.C_ORD_NO);//订单池
                Mod_TQB_CHECKSTATE mod_checkstate = dal_checkstate.GetModelByName(mod_slab_main.C_JUDGE_LEV_ZH, mod_tmo_order.C_XGID);//判定等级 
                DateTime dt_time = Convert.ToDateTime(mod_slab_main.D_WE_DATE.ToString());
                if (dt == null) return false;
                if (mod_slab_main == null) return false;
                if (mod_mater_main == null) return false;
                if (mod_ts_user == null) return false;
                if (mod_SLABWH == null) return false;
                if (mod_std_config == null) return false;
                if (mod_tmo_order == null) return false;
                if (mod_checkstate == null) return false;

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
                bill.SetAttribute("id", mod_slab_main.C_STOVE);
                #endregion
                root.AppendChild(bill);

                XmlNode head = xmlDoc.CreateNode(XmlNodeType.Element, "bill_head", null);

                #region //表头_order_head
                CreateNode(xmlDoc, head, "cwarehouseid", mod_SLABWH.C_ID); //仓库ID
                #endregion

                bill.AppendChild(head);
                XmlElement body = xmlDoc.CreateElement("bill_body");
                bill.AppendChild(body);

                XmlNode item = xmlDoc.CreateNode(XmlNodeType.Element, "item", null);
                #region //表体_item
                CreateNode(xmlDoc, item, "cwarehouseid", mod_SLABWH.C_ID);//仓库ID
                CreateNode(xmlDoc, item, "taccounttime", mod_slab_main.D_WE_DATE.ToString());//库房签字时间
                CreateNode(xmlDoc, item, "coperatorid", mod_ts_user.C_ID);//制单人
                CreateNode(xmlDoc, item, "ccheckstate_bid", mod_checkstate.C_ID);//质量等级
                CreateNode(xmlDoc, item, "cworkcenterid", dt.Rows[0]["连铸主键"].ToString());//工作中心主键/连铸机号
                CreateNode(xmlDoc, item, "dbizdate", dt_time.ToString("yyyy-MM-dd"));//业务日期
                CreateNode(xmlDoc, item, "vbatchcode", mod_slab_main.C_STOVE);//批次号
                CreateNode(xmlDoc, item, "cinvbasid", mod_mater_main.C_PK_INVBASDOC);//存货基本ID
                CreateNode(xmlDoc, item, "pk_produce", "");//介质物料PK
                CreateNode(xmlDoc, item, "ninnum", dt.Rows[0]["重量"].ToString());//实入数量-重量
                CreateNode(xmlDoc, item, "ninassistnum", dt.Rows[0]["支数"].ToString());//实入辅数量-件数
                CreateNode(xmlDoc, item, "castunitid", mod_mater_main.C_FJLDW);//辅计量单位ID
                CreateNode(xmlDoc, item, "vfree1", mod_std_config.C_ZYX1);//自由项1
                CreateNode(xmlDoc, item, "vfree2", mod_std_config.C_ZYX2);//自由项2
                CreateNode(xmlDoc, item, "vfree3", "");//自由项3
                CreateNode(xmlDoc, item, "vfree4", ""); //自由项4
                CreateNode(xmlDoc, item, "vfree5", "");//自由项5
                CreateNode(xmlDoc, item, "pk_corp", "");//公司
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
