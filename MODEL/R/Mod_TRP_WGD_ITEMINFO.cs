using System;
namespace MODEL
{
    public class Mod_TRP_WGD_ITEMINFO
    {
        /// <summary>
        /// 完工单订单计划中间表（关系表）
        /// </summary>
        public Mod_TRP_WGD_ITEMINFO()
        { }
        #region Model
        private string _c_item_info_id;
        private string _c_wgd_id;
        private string _c_id;
        /// <summary>
        /// 订单计划中间表ID
        /// </summary>
        public string C_ITEM_INFO_ID
        {
            set { _c_item_info_id = value; }
            get { return _c_item_info_id; }
        }
        /// <summary>
        /// 完工单ID（组坯主键）
        /// </summary>
        public string C_WGD_ID
        {
            set { _c_wgd_id = value; }
            get { return _c_wgd_id; }
        }
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        #endregion Model
    }
}
