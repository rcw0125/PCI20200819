using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Bll_APS_LGPC
    {
        public Bll_APS_LGPC()
        {
        }

        private Dal_APS_LGPC dal = new Dal_APS_LGPC();
        public void updateALL()
        {
            dal.updateALL();
        }

    }
}
