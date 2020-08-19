using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class Bll_Interface_NC_Roll_A3
    {
        private readonly Dal_Interface_NC_Roll_A3 dal = new Dal_Interface_NC_Roll_A3();

        public Bll_Interface_NC_Roll_A3()
        { }

        public List<string> SendXml_ROLL_A3(string dayplcode, string xmlFileName, NcRollA3 nc, string path)
        {
            return dal.SendXml_ROLL_A3(dayplcode, xmlFileName, nc, path);
        }

    }
}
