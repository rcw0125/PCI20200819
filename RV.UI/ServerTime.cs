using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RV.BLL;

namespace RV.UI
{
    public class ServerTime
    {
        public static  DateTime timeNow()
        {
            BllTime bllTime = new BllTime();
            string str = bllTime.GetTime();

            if (str == "")
            {
                return DateTime.Now;
            }
            else
            {
                return Convert.ToDateTime(str);
            }
        }
    }
}
