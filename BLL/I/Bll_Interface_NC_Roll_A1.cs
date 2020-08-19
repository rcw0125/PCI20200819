using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class Bll_Interface_NC_Roll_A1
    {
        private readonly Dal_Interface_NC_Roll_A1 dal = new Dal_Interface_NC_Roll_A1();

        public Bll_Interface_NC_Roll_A1()
        { }

        public List<string> SendXml_ROLL_A1(string dayplcode, string xmlFileName, NcRollA1 nc, string path)
        {
            return dal.SendXml_ROLL_A1(dayplcode, xmlFileName, nc, path);
        }

    }
}
