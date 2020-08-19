using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Bll_Interface_NC_Roll_ZK4I
    {
        private readonly Dal_Interface_NC_Roll_ZK4I dal = new Dal_Interface_NC_Roll_ZK4I();

        public Bll_Interface_NC_Roll_ZK4I()
        { }

        /// <summary>
        /// 发送改判信息给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <param name="c_master_id">实绩主键</param>
        /// <param name="c_gp_before_id">改判前主键</param>
        /// <param name="c_gp_after_id">改判后主键</param>
        /// <returns></returns>
        public string SendXml_GP(string xmlFileName,string id)
        {
            return dal.SendXml_GP(xmlFileName,id);
        }

    }
}
