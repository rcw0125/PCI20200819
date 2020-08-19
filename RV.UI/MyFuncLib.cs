using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace RV.UI
{
     class MyFuncLib
    {
        ///// <summary>
        ///// Form和Tab属性
        ///// </summary>
        ///// 
        //public static ArrayList frmList; // 已打开表单集合
        //public static ArrayList FrmLsit
        //{
        //    get { return frmList; }
        //    set { frmList = value; }
        //}
        public static ArrayList tabList; // 已打开Tab选项卡
        public static ArrayList TabList
        {
            get { return tabList; }
            set { tabList = value; }
        }
        //public static Form activedFrm;
        //public static Form ActivedFrm
        //{
        //    get { return activedFrm; }
        //    set { activedFrm = value; }
        //}
    }
}
