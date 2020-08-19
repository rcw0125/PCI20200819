using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RV.DAL;

namespace RV.BLL
{
    public partial class BllTime
    {
        private readonly DalTime dal = new DalTime();

        /// <summary>
		/// 获取时间
		/// </summary>
		public string GetTime()
        {
            return dal.GetTime();
        }
    }
}
