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
    public class Bll_TPP_HJXQ
    {
        public Bll_TPP_HJXQ()
        {
        }

        private Dal_TPP_HJXQ dal = new Dal_TPP_HJXQ();
        /// <summary>
        /// 根据合金名称获取数据
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataSet GetList(string name, DateTime dt1, DateTime dt2)
        {
            return dal.GetList(name, dt1, dt2);
        }
        /// <summary>
        /// 估计合金名称获取需求合金订单
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataSet GetXQList(string name, DateTime dt1, DateTime dt2)
        {
            return dal.GetXQList(name, dt1, dt2);
        }
        }
}
