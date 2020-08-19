using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DevExpress.XtraEditors.Repository;

namespace RV.UI
{
    public class UserInfo
    {
        public static string userID;//用户ID
        public static string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public static string _userAccount;//用户ID
        public static string userAccount
        {
            get { return _userAccount; }
            set { _userAccount = value; }
        }

        public static string userName; //用户名
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public static string menuName;//菜单名
        public static string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }

        public static RepositoryItemImageComboBox repoUserName; // 按钮ID集合
        public static RepositoryItemImageComboBox RepoUserName
        {
            get { return repoUserName; }
            set { repoUserName = value; }
        }

        public static string menuID;//菜单ID
        public static string MenuID
        {
            get { return menuName; }
            set { menuName = value; }
        }
    }
}
