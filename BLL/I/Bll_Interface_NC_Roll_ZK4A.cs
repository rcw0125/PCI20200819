﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Bll_Interface_NC_Roll_ZK4A
    {
        private readonly Dal_Interface_NC_Roll_ZK4A dal = new Dal_Interface_NC_Roll_ZK4A();

        public Bll_Interface_NC_Roll_ZK4A()
        { }

        /// <summary>
        /// 发送改判信息给NC
        /// </summary>
        /// <param name="xmlFileName">xml完整路径</param>
        /// <param name="c_master_id">实绩主键</param>
        /// <returns></returns>
        public string SendXml_GP(string xmlFileName, string C_ZKD_NO)
        {
            return dal.SendXml_GP(xmlFileName, C_ZKD_NO);
        }

    }
}
