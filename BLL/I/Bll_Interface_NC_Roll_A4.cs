using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class Bll_Interface_NC_Roll_A4
    {
        private readonly Dal_Interface_NC_Roll_A4 dal = new Dal_Interface_NC_Roll_A4();

        public Bll_Interface_NC_Roll_A4()
        { }

        public List<string> SendXml_ROLL_A4(string dayplcode, string xmlFileName, NcRollA4 nc, string path)
        {
            return dal.SendXml_ROLL_A4(dayplcode, xmlFileName, nc, path);
        }

    }
}
