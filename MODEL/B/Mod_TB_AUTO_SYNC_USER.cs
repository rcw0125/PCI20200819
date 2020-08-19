using System;
namespace MODEL
{
    [Serializable]
    public class Mod_TB_AUTO_SYNC_USER
    {
        public Mod_TB_AUTO_SYNC_USER()
        { }

        private string _c_id;
        private string _c_useraccount;
        /// <summary>
        /// 
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_USERACCOUNT
        {
            set { _c_useraccount = value; }
            get { return _c_useraccount; }
        }
    }
}
