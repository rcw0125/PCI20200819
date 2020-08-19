using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Bll_Interface_NC_Roll_QT4I
    {
        private readonly Dal_Interface_NC_Roll_QT4I dal = new Dal_Interface_NC_Roll_QT4I();

        public Bll_Interface_NC_Roll_QT4I()
        { }

        /// <summary>
        /// 发送改判信息给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <param name="no">出库单号</param>
        /// <param name="itemid">子表主键</param>
        /// <returns></returns>
        public string SendXml_GP(string xmlFileName, string no)
        {
            return dal.SendXml_GP(xmlFileName, no);
        }

    }
}
