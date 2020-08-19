using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class Bll_Interface_NC_Roll_A2
    {
        private readonly Dal_Interface_NC_Roll_A2 dal = new Dal_Interface_NC_Roll_A2();

        public Bll_Interface_NC_Roll_A2()
        { }

        public List<string> SendXml_ROLL_A2(string dayplcode, string xmlFileName, NcRollA2 ncA2, string path)
        {
            return dal.SendXml_ROLL_A2(dayplcode, xmlFileName, ncA2, path);
        }

    }
}
