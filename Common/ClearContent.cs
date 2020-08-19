using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    /// <summary>
    /// 2018-4-18 zmc
    /// </summary>
    public  class ClearContent
    {
        /// <summary>
        /// 重置panelControl中控件值
        /// </summary>
        /// <param name="dd">panelControl1.Controls</param>h
        public static void ClearPanelControl(DevExpress.XtraEditors.PanelControl.ControlCollection dd)
        {
            foreach (var c in dd)
            {

                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    ((DevExpress.XtraEditors.TextEdit)c).Text = "";
                }

                if (c is DevExpress.XtraEditors.DateEdit)
                {
                    ((DevExpress.XtraEditors.DateEdit)c).Text = "";
                }

                if (c is DevExpress.XtraEditors.ComboBoxEdit)
                {
                    ((DevExpress.XtraEditors.ComboBoxEdit)c).SelectedIndex = -1;
                }
                if (c is DevExpress.XtraEditors.ImageComboBoxEdit)
                {
                    ((DevExpress.XtraEditors.ImageComboBoxEdit)c).SelectedIndex = -1;
                }
            }

        }
        /// <summary>
        /// 禁用容器中的控件
        /// </summary>
        /// <param name="dd"></param>
        public static void DisablePanelControl(DevExpress.XtraEditors.PanelControl.ControlCollection dd)
        {
            foreach (var c in dd)
            {

                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    ((DevExpress.XtraEditors.TextEdit)c).ReadOnly = true;
                }

                if (c is DevExpress.XtraEditors.DateEdit)
                {
                    ((DevExpress.XtraEditors.DateEdit)c).ReadOnly = true;
                }

                if (c is DevExpress.XtraEditors.ComboBoxEdit)
                {
                    ((DevExpress.XtraEditors.ComboBoxEdit)c).ReadOnly = true;
                }
                if (c is DevExpress.XtraEditors.ImageComboBoxEdit)
                {
                    ((DevExpress.XtraEditors.ImageComboBoxEdit)c).ReadOnly = true;
                }
                if (c is DevExpress.XtraEditors.SimpleButton)
                {
                    ((DevExpress.XtraEditors.SimpleButton)c).Enabled = false;
                }
            }

        }

        /// <summary>
        /// 启用容器中的控件
        /// </summary>
        /// <param name="dd"></param>
        public static void EnablePanelControl(DevExpress.XtraEditors.PanelControl.ControlCollection dd)
        {
            foreach (var c in dd)
            {

                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    ((DevExpress.XtraEditors.TextEdit)c).ReadOnly = false;
                }

                if (c is DevExpress.XtraEditors.DateEdit)
                {
                    ((DevExpress.XtraEditors.DateEdit)c).ReadOnly=false;
                }

                if (c is DevExpress.XtraEditors.ComboBoxEdit)
                {
                    ((DevExpress.XtraEditors.ComboBoxEdit)c).ReadOnly = false;
                }
                if (c is DevExpress.XtraEditors.ImageComboBoxEdit)
                {
                    ((DevExpress.XtraEditors.ImageComboBoxEdit)c).ReadOnly = false;
                }
                if (c is DevExpress.XtraEditors.SimpleButton)
                {
                    ((DevExpress.XtraEditors.SimpleButton)c).Enabled = true;
                }
            }

        }


        /// <summary>
        /// 重置FlowLayoutPanel中控件值
        /// </summary>
        /// <param name="dd">panelControl1.Controls</param>h
        public static void ClearFlowLayoutPanel(System.Windows.Forms.FlowLayoutPanel.ControlCollection dd)
        {
            foreach (var c in dd)
            {

                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    ((DevExpress.XtraEditors.TextEdit)c).Text = "";
                }

                if (c is DevExpress.XtraEditors.DateEdit)
                {
                    ((DevExpress.XtraEditors.DateEdit)c).Text = "";
                }

                if (c is DevExpress.XtraEditors.ComboBoxEdit)
                {
                    ((DevExpress.XtraEditors.ComboBoxEdit)c).SelectedIndex = -1;
                }
                if (c is DevExpress.XtraEditors.ImageComboBoxEdit)
                {
                    ((DevExpress.XtraEditors.ImageComboBoxEdit)c).SelectedIndex = -1;
                }
            }

        }
    }
}
