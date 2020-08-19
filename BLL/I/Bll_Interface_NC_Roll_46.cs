using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class Bll_Interface_NC_Roll_46
    {
        private readonly Dal_Interface_NC_Roll_46 dal = new Dal_Interface_NC_Roll_46();

        public Bll_Interface_NC_Roll_46()
        { }

        public List<string> SendXml_ROLL_46(string dayplcode, string xmlFileName, List<NcRoll46> nc, string path)
        {
            return dal.SendXml_ROLL_46(dayplcode, xmlFileName, nc, path);
        }

    }
}
