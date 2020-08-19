using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BLL;
using MODEL;

namespace Common
{
    public class CommonSub
    {
        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TB_MATRL_MAIN bll_TB_MATRL_MAIN = new Bll_TB_MATRL_MAIN();
        Bll_TQB_STD_SPEC bll_TQB_STD_SPEC = new Bll_TQB_STD_SPEC();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        Bll_TQB_CHARACTER bll_TQB_CHARACTER = new Bll_TQB_CHARACTER();
        Bll_TPB_LINE_SPEC bll_TPB_LINE_SPEC = new Bll_TPB_LINE_SPEC();
        Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        Bll_TPB_SLABWH_AREA bll_TPB_SLABWH_AREA = new Bll_TPB_SLABWH_AREA();
        Bll_TPB_SLABWH_LOC bll_TPB_SLABWH_LOC = new Bll_TPB_SLABWH_LOC();
        Bll_TPB_SLABWH_TIER bll_TPB_SLABWH_TIER = new Bll_TPB_SLABWH_TIER();
        Bll_TPB_COOLPIT bll_TPB_COOLPIT = new Bll_TPB_COOLPIT();
        Bll_TPB_COOLPIT_AREA bll_TPB_COOLPIT_AREA = new Bll_TPB_COOLPIT_AREA();
        Bll_TPB_COOLPIT_LOC bll_TPB_COOLPIT_LOC = new Bll_TPB_COOLPIT_LOC();
        Bll_TPB_COOLPIT_TIER bll_TPB_COOLPIT_TIER = new Bll_TPB_COOLPIT_TIER();
        Bll_TPP_INITIALIZE_ITEM bll_TPP_INITIALIZE_ITEM = new Bll_TPP_INITIALIZE_ITEM();
        Bll_TRP_PLAN_ROLL bll_TRP_PLAN_ROLL = new Bll_TRP_PLAN_ROLL();
        Bll_TSP_PLAN_SMS bll_TSP_PLAN_SMS = new Bll_TSP_PLAN_SMS();
        private static Bll_TPP_INITIALIZE_STA bll_TPP_INITIALIZE_STA = new Bll_TPP_INITIALIZE_STA();
        Bll_TPP_INITIALIZE_LINE bll_TPP_INITIALIZE_LINE = new Bll_TPP_INITIALIZE_LINE();
        Bll_TPB_GL_CAPACITY bll_TPB_GL_CAPACITY = new Bll_TPB_GL_CAPACITY();
        Bll_TPP_PRODUCTION_PLAN bll_TPP_PRODUCTION_PLAN = new Bll_TPP_PRODUCTION_PLAN();
        Bll_TPB_LINEWH bll_TPB_LINEWH = new Bll_TPB_LINEWH();
        Bll_TPB_LINEWH_AREA bll_TPB_LINEWH_AREA = new Bll_TPB_LINEWH_AREA();
        Bll_TB_BC bll_TB_BC = new Bll_TB_BC();
        Bll_TB_BZ bll_TB_BZ = new Bll_TB_BZ();
        Bll_TB_BCBZ bll_TB_BCBZ = new Bll_TB_BCBZ();
        Bll_TPB_LINEWH_LOC bll_TPB_LINEWH_LOC = new Bll_TPB_LINEWH_LOC();
        Bll_TB_BCBZGZ bll_tb_bcbzgz = new Bll_TB_BCBZGZ();
        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        public static void BindIcbo(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByIni(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                cbo.Properties.Items.Add("全部", "", -1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        public static void BindIcbo_XF(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByIni(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        public static void BindIcboNoAll(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByIni(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
                cbo.SelectedIndex = 0;
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }


        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        public static void BindIcboBXG(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByBXG(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
                cbo.SelectedIndex = 0;
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        /// <param name="strQB">是否加载全部选择项</param>
        public static void BindIcbo(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo, string strQB)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByIni(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                if (strQB == "Y")
                {
                    cbo.Properties.Items.Add("全部", "all", -1);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
                cbo.Properties.Items.Add("工位为空", "", -1);
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// ImageComboBoxEdit加载排产方案
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindFA(DevExpress.XtraEditors.ImageComboBoxEdit cbo, string qs)
        {
            //cbo.Properties.Items.Clear();
            //DataTable dt = bll_TPP_INITIALIZE_ITEM.GetList("0", qs, "", null, null).Tables[0];
            //if (dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        cbo.Properties.Items.Add(dt.Rows[i]["C_ITEM_NAME"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
            //    }
            //}
            //else
            //{
            //    cbo.Properties.Items.Clear();
            //}
        }
        /// <summary>
        /// ComboBoxEdit加载排产顺序
        /// </summary>
        /// <param name="cbo">控件</param>

        public void ComboBoxEditBindPCSX(string C_INITIALIZE_ITEM_ID, string C_STA_ID, DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            int count = bll_TRP_PLAN_ROLL.GetFACount(C_INITIALIZE_ITEM_ID, C_STA_ID);

            if (count > 0)
            {
                for (int i = 1; i <= count; i++)
                {
                    cbo.Properties.Items.Add(i);
                }
                cbo.Properties.Items.Add(count + 1);
            }
            else
            {
                cbo.Properties.Items.Clear();
                cbo.Properties.Items.Add(1);
            }
        }

        /// <summary>
        /// ImageComboBoxEdit加载工序
        /// </summary>
        /// <param name="strGX">工序</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGX(string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo, string str)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_PRO.GetListByStatus(1, strGX, str).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_PRO_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit根据工序加载工位
        /// </summary>
        /// <param name="strGX">工序</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGW(string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_STA.GetListByStatus(1, strGX, "").Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// ImageComboBoxEdit根据备注加载工位
        /// </summary>
        /// <param name="strBZ">备注</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGWByBZ(string strBZ, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_STA.GetListByStatusAndBZ(1, strBZ).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 执行标准
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DataTable GetZXBZList(string grd)
        {
            DataTable zxbzdt = bll_TQB_STD_MAIN.GetList_STD(grd).Tables[0];
            return zxbzdt;
        }
        /// <summary>
        /// 钢种
        /// </summary>
        /// <returns></returns>
        public DataTable GetGZList()
        {
            DataTable gzdt = bll_TB_MATRL_MAIN.GetGZList().Tables[0];
            return gzdt;
        }
        /// <summary>
        /// ComboBoxEdit加载钢种
        /// </summary>
        /// <param name="cbo">ComboBoxEdit控件</param>
        public void ComboBoxEditBindGZ(DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = GetGZList();
            //cbo.Properties.Items.Add("");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STL_GRD"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }

        }
        /// <summary>
        /// ComboBoxEdit根据钢种加载执行标准
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindBZ(string strGZ, DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = GetZXBZList(strGZ);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STD_CODE"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ComboBoxEdit根据fno加载规格
        /// </summary>
        /// <param name="fno">方案号</param>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindGG(string fno, string C_SPEC, DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_PRODUCTION_PLAN.GetGGList(fno, C_SPEC).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_SPEC"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }


        /// <summary>
        /// ImageComboBoxEdit根据钢种加载执行标准
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindBZ(string strGZ, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = GetZXBZList(strGZ);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STD_CODE"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit根据类别加载项目
        /// </summary>
        /// <param name="strLB">类别：成分/性能</param>
        /// <param name="cbo">ImageComboBoxEdit控件</param>
        public void ImageComboBoxEditBindItem(string strLB, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TQB_CHARACTER.GetItemByLB(strLB).Tables[0];

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    cbo.Properties.Items.Add(dt.Rows[i]["C_NAME"].ToString(), dt.Rows[i]["C_CODE"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// 工序id翻译成描述
        /// </summary>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetGXIdDescItemComboBox()
        {
            var dt = bll_TB_PRO.GetAllList().Tables[0];
            var repo = new RepositoryItemImageComboBox();
            foreach (DataRow item in dt.Rows)
            {
                var list = new ImageComboBoxItem(item["C_PRO_DESC"].ToString(), item["C_ID"]);
                repo.Items.Add(list);
            }
            return repo;
        }
        /// <summary>
        /// 根据工序将工位id翻译成描述
        /// </summary>
        /// <param name="pro">工序</param>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetGWIdByGXDescItemComboBox(string pro)
        {
            var dt = bll_TB_STA.GetListByGX(pro).Tables[0];
            var repo = new RepositoryItemImageComboBox();
            foreach (DataRow item in dt.Rows)
            {
                var list = new ImageComboBoxItem(item["C_STA_DESC"].ToString(), item["C_ID"]);
                repo.Items.Add(list);
            }
            var nulllist = new ImageComboBoxItem("", "");
            repo.Items.Add(nulllist);
            return repo;
        }
        /// <summary>
        /// 工位id翻译成描述
        /// </summary>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetGWIdDescItemComboBox()
        {
            var dt = bll_TB_STA.GetAllList().Tables[0];
            var repo = new RepositoryItemImageComboBox();
            foreach (DataRow item in dt.Rows)
            {
                var list = new ImageComboBoxItem(item["C_STA_DESC"].ToString(), item["C_ID"]);
                repo.Items.Add(list);
            }
            return repo;
        }
        /// <summary>
        /// 方案id翻译成描述
        /// </summary>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetFADescItemComboBox()
        {
            var dt = bll_TPP_INITIALIZE_ITEM.GetAllList().Tables[0];
            var repo = new RepositoryItemImageComboBox();
            foreach (DataRow item in dt.Rows)
            {
                var list = new ImageComboBoxItem(item["C_ITEM_NAME"].ToString(), item["C_ID"]);
                repo.Items.Add(list);
            }
            return repo;
        }
        /// <summary>
        /// 设置列为只读
        /// </summary>
        /// <param name="dd"></param>
        public void setColumReadOnly(DevExpress.XtraGrid.Columns.GridColumnCollection dd)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in dd)
            {
                if (item.FieldName != "Selected")
                {
                    item.OptionsColumn.ReadOnly = true;
                }
            }
        }
        /// <summary>
        /// 工位加载规格
        /// </summary>
        /// <param name="strGW">工位</param>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindSPECByGW(string strGW, DevExpress.XtraEditors.ComboBoxEdit cbo, string SPEC)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_LINE_SPEC.GetSPECList(strGW, SPEC, "", "1").Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_SPEC"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// 根据工位加载规格
        /// </summary>
        /// <param name="cbo">控件</param>
        /// <param name="C_STA_ID">工位</param>
        /// <param name="SPEC">规格</param>
        public void ComboBoxEditBindSPECByGW(DevExpress.XtraEditors.ComboBoxEdit cbo, string C_STA_ID, string SPEC)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_LINE_SPEC.GetSPECList(C_STA_ID, SPEC).Tables[0];
            cbo.Properties.Items.Add("");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_SPEC"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// 加载全部规格
        /// </summary>
        /// <param name="cbo">控件</param>
        /// <param name="SPEC">规格</param>
        public void ComboBoxEditBindSPEC(DevExpress.XtraEditors.ComboBoxEdit cbo, string SPEC)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TQB_STD_SPEC.GetSPECListBySPEC(SPEC).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_SPEC"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit根据工序描述加载工位
        /// </summary>
        /// <param name="strGXDESC">工序描述</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGWByGX(string strGXDESC, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_STA.GetListByGX(strGXDESC).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), i);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit根据多条工序描述加载工位
        /// </summary>
        /// <param name="strGXDESC">工序描述</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGWByGXstr(string strGXDESC, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_STA.GetListByGXStr(strGXDESC).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), i);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// 加载计划工位
        /// </summary>
        /// <param name="strGXDESC">工序描述</param>
        /// <param name="cbo">控件</param>
        public void BindZJGW(string strGXDESC, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_STA.GetListByGX(strGXDESC).Tables[0];

            cbo.Properties.Items.Add("全部", "全部", -1);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }

            cbo.SelectedIndex = 0;
        }

        /// <summary>
        /// ImageComboBoxEdit根据工序描述加载工位
        /// </summary>
        /// <param name="strGXDESC">工序描述</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGWByGX(DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_STA.GetListByZLGX().Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), i);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ComboBoxEdit加载品种
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindPZ(DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TQB_STD_MAIN.GetPZList().Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_PROD_KIND"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ComboBoxEdit加载品名
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindPM(string PZ, DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TQB_STD_MAIN.GetPZList(PZ).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_PROD_NAME"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ComboBoxEdit加载执行标准
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindBZByGZ(string GZ, DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TQB_STD_MAIN.GetBZListByGZ(GZ).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STD_CODE"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ComboBoxEdit加载钢种
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindGZ(string PM, DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TQB_STD_MAIN.GetGZListByPM(PM).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STL_GRD"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        #region 钢坯库下拉框
        /// <summary>
        /// ImageComboBoxEdit加载钢坯仓库
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGPK(DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_SLABWH.GetList().Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add( dt.Rows[i]["C_SLABWH_CODE"].ToString()+ dt.Rows[i]["C_SLABWH_NAME"].ToString(), dt.Rows[i]["C_SLABWH_CODE"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// ImageComboBoxEdit加载钢坯仓库
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindStock(DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_SLABWH.GetList().Tables[0];
            if (dt.Rows.Count > 0)
            {
                cbo.Properties.Items.Add("全部", "全部", 0);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_SLABWH_CODE"].ToString() + dt.Rows[i]["C_SLABWH_NAME"].ToString(), dt.Rows[i]["C_SLABWH_CODE"].ToString(), -1);
                }
                cbo.SelectedIndex = 0;
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载钢坯库区域
        /// </summary>
        /// <param name="strck">仓库</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGPKQY(string strck, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_SLABWH_AREA.GetListBySlabWHID(strck, 1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_SLABWH_AREA_CODE"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载钢坯库位
        /// </summary>
        /// <param name="strqy">区域</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGPKKW(string strqy, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_SLABWH_LOC.GetListByArea(strqy, 1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_SLABWH_LOC_CODE"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载钢坯仓库层
        /// </summary>
        /// <param name="strkw">库位</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindGPKC(string strkw, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_SLABWH_TIER.GetListByKW(strkw).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_SLABWH_TIER_CODE"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// 获取当前层最大支数
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public DataTable GetMAXZSByC(string c)
        {
            DataTable dt = null;
            dt = bll_TPB_SLABWH_TIER.GetMAXZSByC(c).Tables[0];
            return dt;
        }
        /// <summary>
        /// 获取当前层支数
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int GetZSByC(string c)
        {
            return bll_TPB_SLABWH_TIER.GetListByC(c);
        }
        #endregion
        /// <summary>
        /// ImageComboBoxEdit加载线材库（id）
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindXCKById(DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_LINEWH.GetListByStatus(1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_LINEWH_NAME"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载线材库
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindXCK(DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_LINEWH.GetListByStatus(1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_LINEWH_NAME"].ToString() + "(" + dt.Rows[i]["C_LINEWH_CODE"].ToString() + ")", dt.Rows[i]["C_LINEWH_CODE"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载线材库区域
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindXCKQY(string qy, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_LINEWH_AREA.GetList_ID(qy).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_LINEWH_AREA_NAME"].ToString() + "(" + dt.Rows[i]["C_LINEWH_AREA_CODE"].ToString() + ")", dt.Rows[i]["C_LINEWH_AREA_CODE"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载线材库区域
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindXCKKW(string qy, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_LINEWH_LOC.GetList_ID(qy).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_LINEWH_LOC_NAME"].ToString() + "(" + dt.Rows[i]["C_LINEWH_LOC_CODE"].ToString() + ")", dt.Rows[i]["C_LINEWH_LOC_CODE"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        #region 缓冷坑下拉框
        /// <summary>
        /// ImageComboBoxEdit加载缓冷坑
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindHLK(DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_COOLPIT.GetListByStatus(1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_COOLPIT_CODE"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载缓冷坑区域
        /// </summary>
        /// <param name="strck">仓库</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindHLKQY(string strck, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_COOLPIT_AREA.GetListByCOOLPITID(strck, 1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_COOLPIT_AREA_CODE"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载缓冷坑位
        /// </summary>
        /// <param name="strqy">区域</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindHLKKW(string strqy, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_COOLPIT_LOC.GetListByArea(strqy, 1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_COOLPIT_LOC_CODE"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载缓冷坑库层
        /// </summary>
        /// <param name="strkw">库位</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindHLKC(string strkw, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPB_COOLPIT_TIER.GetListByKW(strkw).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_COOLPIT_TIER_CODE"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// 获取当前层最大支数
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public DataTable GetHLKMAXZSByC(string c)
        {
            DataTable dt = null;
            dt = bll_TPB_COOLPIT_TIER.GetMAXZSByC(c).Tables[0];
            return dt;
        }
        /// <summary>
        /// 获取当前层支数
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int GetHLKZSByC(string c)
        {
            return bll_TPB_COOLPIT_TIER.GetListByC(c);
        }



        #endregion
        /// <summary>
        /// ImageComboBoxEdit根据方案加载工位
        /// </summary>
        /// <param name="strGX">工序</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindLGGW(string strGX, string fid, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetList(strGX, "全部", fid, "").Tables[0];
            cbo.Properties.Items.Add("", "", -1);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// 根据时间段绑定方案
        /// </summary>
        /// <param name="cbo">控件</param>
        /// <param name="dt1">开始时间</param>
        /// <param name="dt2">结束时间</param>
        /// <param name="type">类型</param>
        public void ImageComboBoxEditBindFABYTIME(DevExpress.XtraEditors.ImageComboBoxEdit cbo, string dt1, string dt2, string type)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_ITEM.GetList(null, type, dt1, dt2).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_ITEM_NAME"].ToString(), dt.Rows[i]["C_ID"].ToString(), 0);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 根据方案加载连铸工位
        /// </summary>
        /// <param name="strGX">工序</param>
        /// <param name="cbo">控件</param>
        public void BindCCM(string strGX, string fid, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetList(strGX, "全部", fid, "").Tables[0];
            cbo.Properties.Items.Add("全部", "全部", 0);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }


        /// <summary>
        /// ComboBoxEdit加载路线
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindLX(DevExpress.XtraEditors.ComboBoxEdit cbo, string C_INITIALIZE_ITEM_ID)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_LINE.GetCXList(C_INITIALIZE_ITEM_ID).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_REMARK"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// ComboBoxEdit加载期数
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ComboBoxEditBindQS(DevExpress.XtraEditors.ComboBoxEdit cbo)
        {
            cbo.Text = "";
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_ITEM.GetQSList().Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_ISSUE"].ToString());
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// ImageComboBoxEdit加载班次
        /// </summary>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindBC(DevExpress.XtraEditors.ImageComboBoxEdit cbo, int num)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_BC.GetListBynum(num).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_BC_NAME"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        ///  ImageComboBoxEdit加载班组
        /// </summary>
        /// <param name="cbo">ImageComboBoxEdit</param>
        /// <param name="num">0</param>
        public void ImageComboBoxEditBindBZ(DevExpress.XtraEditors.ImageComboBoxEdit cbo, int num)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_BZ.GetListBynum(num).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_BZ_NAME"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// 班次id翻译成描述
        /// </summary>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetBCIdDescItemComboBox()
        {
            var dt = bll_TB_BCBZ.GetNCBCList("", "").Tables[0];
            var repo = new RepositoryItemImageComboBox();
            foreach (DataRow item in dt.Rows)
            {
                var list = new ImageComboBoxItem(item["BCNAME"].ToString(), item["PK_WTID"]);
                repo.Items.Add(list);
            }
            return repo;
        }
        /// <summary>
        /// 班组id翻译成描述
        /// </summary>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetBZIdDescItemComboBox()
        {
            var dt = bll_TB_BCBZ.GetNCBZList("", "").Tables[0];
            var repo = new RepositoryItemImageComboBox();
            foreach (DataRow item in dt.Rows)
            {
                var list = new ImageComboBoxItem(item["BZMC"].ToString(), item["PK_PGAID"]);
                repo.Items.Add(list);
            }
            return repo;
        }
        /// <summary>
        /// 默认班次班组
        /// </summary>
        /// <param name="bccbo">班次</param>
        /// <param name="bzcbo">班组</param>
        /// <param name="stacode">工位代码</param>
        /// <param name="type">工序</param>
        public void BCBZBindEdit(DevExpress.XtraEditors.ImageComboBoxEdit bccbo, DevExpress.XtraEditors.ImageComboBoxEdit bzcbo, string stacode)
        {
            Mod_TB_STA mod_TB_STA = bll_TB_STA.GetModelByCODE(stacode);//获取NC工位代码
            DataTable dt = bll_TB_BCBZ.GetList(mod_TB_STA.C_PRO_ID, DateTime.Now).Tables[0];
            if (dt.Rows.Count > 0)
            {
                DataTable dt1 = bll_TB_BCBZ.GetNCBCList(mod_TB_STA.C_STA_ERPCODE, dt.Rows[0]["C_BC_NAME"].ToString()).Tables[0];
                DataTable dt2 = bll_TB_BCBZ.GetNCBZList(mod_TB_STA.C_ERP_PK, dt.Rows[0]["C_BZ_NAME"].ToString()).Tables[0];
                if (dt1.Rows.Count > 0)
                {
                    bccbo.EditValue = dt1.Rows[0]["PK_WTID"].ToString();
                }
                if (dt2.Rows.Count > 0)
                {
                    bzcbo.EditValue = dt2.Rows[0]["PK_PGAID"].ToString();
                }
            }
        }

        /// <summary>
        /// ImageComboBoxEdit加载班次
        /// </summary>
        /// <param name="cbo">控件</param>
        /// <param name="stacode">工位代码</param>
        public void ImageComboBoxEditBindNCBC(DevExpress.XtraEditors.ImageComboBoxEdit cbo, string stacode)
        {
            Mod_TB_STA mod_TB_STA = bll_TB_STA.GetModelByCODE(stacode);//获取NC工位代码
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_BCBZ.GetNCBCList(mod_TB_STA.C_STA_ERPCODE, "").Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["BCNAME"].ToString(), dt.Rows[i]["PK_WTID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
        /// <summary>
        /// ImageComboBoxEdit加载班组
        /// </summary>
        /// <param name="cbo">控件</param>
        /// <param name="stacode">工位代码</param>
        public void ImageComboBoxEditBindNCBZ(DevExpress.XtraEditors.ImageComboBoxEdit cbo, string stacode)
        {
            Mod_TB_STA mod_TB_STA = bll_TB_STA.GetModelByCODE(stacode);//获取工作中心id
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TB_BCBZ.GetNCBZList(mod_TB_STA.C_ERP_PK, "").Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["BZMC"].ToString(), dt.Rows[i]["PK_PGAID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// ImageComboBoxEdit加载排班规则
        /// </summary>
        /// <param name="strGX">工序</param>
        /// <param name="cbo">控件</param>
        public void ImageComboBoxEditBindPBGZ(DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_tb_bcbzgz.GetListByMC("").Tables[0];
            //cbo.Properties.Items.Add("");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_GZMC"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }
    }
}
