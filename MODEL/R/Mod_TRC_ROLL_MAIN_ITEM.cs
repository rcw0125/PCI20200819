using System;

namespace MODEL
{
    [Serializable]
    public class Mod_TRC_ROLL_MAIN_ITEM
    {
        public Mod_TRC_ROLL_MAIN_ITEM()
        { }
        #region Model
        private string _c_id;
        private string _c_roll_main_id;
        private string _c_slab_main_id;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 组批ID
        /// </summary>
        public string C_ROLL_MAIN_ID
        {
            set { _c_roll_main_id = value; }
            get { return _c_roll_main_id; }
        }
        /// <summary>
        /// 钢坯ID
        /// </summary>
        public string C_SLAB_MAIN_ID
        {
            set { _c_slab_main_id = value; }
            get { return _c_slab_main_id; }
        }
        #endregion Model
    }
}
