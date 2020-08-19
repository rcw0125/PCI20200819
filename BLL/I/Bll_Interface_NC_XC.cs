using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Bll_Interface_NC_XC
    {
        private readonly Dal_Interface_NC_XC dal = new Dal_Interface_NC_XC();

        public Bll_Interface_NC_XC()
        { }

        /// <summary>
        /// 发送改判信息给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <param name="dh">单号</param>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public string SendXml_DM(string xmlFileName, string dh)
        {
            return dal.SendXml_DM(xmlFileName, dh);
        }

    }
}
