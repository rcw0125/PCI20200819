using BLL;
using MODEL;
using MODEL.P.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XGCAP.UI.P.PO.ViewModel
{
    public class PO_SCDD_PC_ViewModel
    {
        /// <summary>
        /// 浇次计划
        /// </summary>
        public List<Mod_TPP_LGPC_LSB> LSBList { get; set; } = new List<Mod_TPP_LGPC_LSB>();

        /// <summary>
        /// 炉次计划
        /// </summary>
        public List<Mod_TPP_LGPC_LCLSB> LCLSBList { get; set; } = new List<Mod_TPP_LGPC_LCLSB>();

        private LCLSBHelper _helper;

        #region 服务
        /// <summary>
        /// 炼钢排产临时表
        /// </summary>
        private Bll_TPP_LGPC_LSB bll_lsb = new Bll_TPP_LGPC_LSB();

        /// <summary>
        /// 炼钢炉次计划临时表
        /// </summary>
        private Bll_TPP_LGPC_LCLSB bll_lclsb = new Bll_TPP_LGPC_LCLSB();

        #endregion


        private string _strCCMID { get; set; }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="strCCMID"></param>
        public void Init(string strCCMID)
        {
            _strCCMID = strCCMID;
            // 初始化数据
            InitLsb();
            InitLcLsb();
            _helper = new LCLSBHelper(LSBList, LCLSBList);
        }

        /// <summary>
        /// 加载浇次计划
        /// </summary>
        private void InitLsb()
        {
            var result = bll_lsb.GetModelList(_strCCMID);
            foreach (var item in result)
            {
                item.N_SORT = result.IndexOf(item) + 1;
            }

            LSBList.Clear();
            LSBList.AddRange(result);
        }

        /// <summary>
        /// 加载炉次计划
        /// </summary>
        private void InitLcLsb()
        {
            var result = bll_lclsb.GetModelList(string.Empty, _strCCMID);
            foreach (var item in result)
            {
                item.N_SORT = result.IndexOf(item) + 1;
            }

            LCLSBList.Clear();
            LCLSBList.AddRange(result);
        }

        /// <summary>
        /// 保存浇次计划,浇次计划
        /// 保存顺序,停机数
        /// </summary>
        public void SaveJCPlan()
        {
            bll_lsb.SavePlan(LSBList, LCLSBList);
        }

        /// <summary>
        /// 修改炉数
        /// </summary>
        /// <param name="current"></param>
        /// <param name="ls"></param>
        public void ChangedLs(Mod_TPP_LGPC_LSB current, decimal ls)
        {
            // 最大，最小，正常炉数
            decimal maxLs = 22m, minLs = 18m, normalLs = 20m;

            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);
            // 差异炉数，正数增多炉数，负数减少炉数
            var exceptLs = (int)((ls - current.N_ZJCLS) ?? 0);

            // 增多炉数
            if (jcData.Count() == 0)
            {
                throw new Exception("没有炉次计划可供添加！");
            }

            if (exceptLs > 0)
            {
                _helper.Add(current, exceptLs);
            }
            else
            {
                // 减少炉数，不违反订单最少炉数，直接减少，否则减少炉数，排列到最后一个浇次中
                _helper.Remove(current, -exceptLs);
            }
        }
    }
}
