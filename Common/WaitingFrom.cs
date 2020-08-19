using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class WaitingFrom
    {
        public static SplashScreenManager _loadForm;

        /// <summary>
        /// 等待窗体管理对象
        /// </summary>
        public static SplashScreenManager LoadForm
        {
            get
            {
                if (_loadForm == null)
                {
                    _loadForm = new SplashScreenManager(null, typeof(CustomWaitForm), true, true);
                    _loadForm.ClosingDelay = 0;
                }
                return _loadForm;
            }
        }

        public static void ShowWait(string Msg)
        {
            try
            {
                bool flag = !LoadForm.IsSplashFormVisible;
                if (flag)
                {
                    LoadForm.ShowWaitForm();

                    if (string.IsNullOrEmpty(Msg))
                    {
                        Msg = "请稍后,正在加载中...";
                    }

                    _loadForm.SetWaitFormCaption(Msg);
                }
                else
                {
                    LoadForm.CloseWaitForm();
                    LoadForm.ShowWaitForm();
                }
            }
            catch (Exception ex)
            {

            }

            //try
            //{
            //    SplashScreenManager.ShowForm(typeof(CustomWaitForm));
            //}
            //catch
            //{

            //}
        }

        public static void CloseWait()
        {
            try
            {
                bool isSplashFormVisible = LoadForm.IsSplashFormVisible;
                if (isSplashFormVisible)
                {
                    LoadForm.CloseWaitForm();
                }
            }
            catch
            {

            }

            //try
            //{
            //    SplashScreenManager.CloseForm();
            //}
            //catch
            //{

            //}
        }
    }
}
