using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RV.UI
{
    public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                Application.Run(new Main());
            }

            //Application.Run(new FrmUserManage());
        }

        public static void SetPath(string str)
        {
            DllPath.strPath = str;
        }
    }
}
