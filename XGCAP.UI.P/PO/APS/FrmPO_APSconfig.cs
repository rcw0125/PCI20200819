using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;
namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APSconfig : Form
    {
        public FrmPO_APSconfig()
        {
            InitializeComponent();
        }
        Bll_TPO_APS_CONFIG bll_TPO_APS_CONFIG = new Bll_TPO_APS_CONFIG();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Mod_TPO_APS_CONFIG mod_TPO_APS_CONFIG = new Mod_TPO_APS_CONFIG();
            mod_TPO_APS_CONFIG.N_1KPJSCL = Convert.ToInt32(txt_1KPCN.Text==""?"0": txt_1KPCN.Text);
            mod_TPO_APS_CONFIG.N_2KPJSCL = Convert.ToInt32(txt_2KPCN.Text == "" ? "0" : txt_2KPCN.Text);
            mod_TPO_APS_CONFIG.N_3LZZL = Convert.ToInt32(txt_3CCMZL.Text == "" ? "0" : txt_3CCMZL.Text);
            mod_TPO_APS_CONFIG.N_3LZZS = Convert.ToInt32(txt_3CCMZS.Text == "" ? "0" : txt_3CCMZS.Text);
            mod_TPO_APS_CONFIG.N_4LZZL = Convert.ToInt32(txt_4CCMZL.Text == "" ? "0" : txt_4CCMZL.Text);
            mod_TPO_APS_CONFIG.N_4LZZS = Convert.ToInt32(txt_4CCMZS.Text == "" ? "0" : txt_4CCMZS.Text);
            mod_TPO_APS_CONFIG.N_5LZZL = Convert.ToInt32(txt_5CCMZL.Text == "" ? "0" : txt_5CCMZL.Text);
            mod_TPO_APS_CONFIG.N_5LZZS = Convert.ToInt32(txt_5CCMZS.Text == "" ? "0" : txt_5CCMZS.Text);
            mod_TPO_APS_CONFIG.N_6LZZL = Convert.ToInt32(txt_6CCMZL.Text == "" ? "0" : txt_6CCMZL.Text);
            mod_TPO_APS_CONFIG.N_6LZZS = Convert.ToInt32(txt_6CCMZS.Text == "" ? "0" : txt_6CCMZL.Text);
            mod_TPO_APS_CONFIG.N_7LZZL = Convert.ToInt32(txt_7CCMZL.Text == "" ? "0" : txt_7CCMZL.Text);
            mod_TPO_APS_CONFIG.N_7LZZS = Convert.ToInt32(txt_7CCMZS.Text == "" ? "0" : txt_7CCMZS.Text);
            mod_TPO_APS_CONFIG.N_BXGJSCL = Convert.ToInt32(txt_BXGRCL.Text == "" ? "0" : txt_BXGRCL.Text);
            mod_TPO_APS_CONFIG.N_DHLKP = Convert.ToInt32(txt_DHLKP.Text == "" ? "0" : txt_DHLKP.Text);
            mod_TPO_APS_CONFIG.N_HLGLS = Convert.ToInt32(txt_HLGLS.Text == "" ? "0" : txt_HLGLS.Text);
            mod_TPO_APS_CONFIG.N_HLGSJ = Convert.ToInt32(txt_HLGSJ.Text == "" ? "0" : txt_HLGSJ.Text);
            mod_TPO_APS_CONFIG.N_KPL = Convert.ToInt32(txt_KPAQKC.Text == "" ? "0" : txt_KPAQKC.Text);
            mod_TPO_APS_CONFIG.N_KPXHL = Convert.ToInt32(txt_KPXHL.Text == "" ? "0" : txt_KPXHL.Text);
            mod_TPO_APS_CONFIG.N_KPZG = Convert.ToInt32(txt_KPZG.Text == "" ? "0" : txt_KPZG.Text);
            mod_TPO_APS_CONFIG.N_LZDHL = Convert.ToInt32(txt_LZDHL.Text == "" ? "0" : txt_LZDHL.Text);
            mod_TPO_APS_CONFIG.N_LZKP = Convert.ToInt32(txt_LZKP.Text == "" ? "0" : txt_LZKP.Text);
            mod_TPO_APS_CONFIG.N_RHLS = Convert.ToInt32(txt_RHSM.Text == "" ? "0" : txt_RHSM.Text);
            mod_TPO_APS_CONFIG.N_TGJSCL = Convert.ToInt32(txt_TGRCL.Text == "" ? "0" : txt_TGRCL.Text);
            mod_TPO_APS_CONFIG.N_XHLZG = Convert.ToInt32(txt_XHLZG.Text == "" ? "0" : txt_XHLZG.Text);
            mod_TPO_APS_CONFIG.N_XML = Convert.ToInt32(txt_XMAQKC.Text == "" ? "0" : txt_XMAQKC.Text);
            bll_TPO_APS_CONFIG.Delete();
            if (bll_TPO_APS_CONFIG.Add(mod_TPO_APS_CONFIG)==true)
            {
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("保存失败");
            }

            Query();
        }

        private void FrmPO_APSconfig_Load(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TPO_APS_CONFIG.GetList("").Tables[0];
                if (dt.Rows.Count==0)
                {
                    return;
                }
                DataRow item = dt.Rows[0];
                txt_1KPCN.Text = item["N_1KPJSCL"].ToString();
                txt_2KPCN.Text = item["N_2KPJSCL"].ToString();
                txt_3CCMZL.Text = item["N_3LZZL"].ToString();
                txt_3CCMZS.Text = item["N_3LZZS"].ToString();
                txt_4CCMZL.Text = item["N_4LZZL"].ToString();
                txt_4CCMZS.Text = item["N_4LZZS"].ToString();
                txt_5CCMZL.Text = item["N_5LZZL"].ToString();
                txt_5CCMZS.Text = item["N_5LZZS"].ToString();
                txt_6CCMZL.Text = item["N_6LZZL"].ToString();
                txt_6CCMZS.Text = item["N_6LZZS"].ToString();
                txt_7CCMZL.Text = item["N_7LZZL"].ToString();
                txt_7CCMZS.Text = item["N_7LZZS"].ToString();
                txt_BXGRCL.Text = item["N_BXGJSCL"].ToString();
                txt_DHLKP.Text = item["N_DHLKP"].ToString();
                txt_HLGLS.Text = item["N_HLGLS"].ToString();
                txt_HLGSJ.Text = item["N_HLGSJ"].ToString();
                txt_KPAQKC.Text = item["N_KPL"].ToString();
                txt_KPXHL.Text = item["N_KPXHL"].ToString();
                txt_KPZG.Text = item["N_KPZG"].ToString();
                txt_LZDHL.Text = item["N_LZDHL"].ToString();
                txt_LZKP.Text = item["N_LZKP"].ToString();
                txt_RHSM.Text = item["N_RHLS"].ToString();
                txt_TGRCL.Text = item["N_TGJSCL"].ToString();
                txt_XHLZG.Text = item["N_XHLZG"].ToString();
                txt_XMAQKC.Text = item["N_XML"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
