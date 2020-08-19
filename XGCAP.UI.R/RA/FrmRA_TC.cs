using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.RA
{
    public partial class FrmRA_TC : Form
    {
        public FrmRA_TC()
        {
            InitializeComponent();
        }

        private Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        private CommonSub commonSub = new CommonSub();
        private Bll_TPB_SLABWH_AREA Bll_TPB_SLABWH_AREA = new BLL.Bll_TPB_SLABWH_AREA();//钢坯库区域信息
        private Bll_TPB_SLABWH_LOC Bll_TPB_SLABWH_LOC = new BLL.Bll_TPB_SLABWH_LOC();//钢坯库库位信息
        private Bll_TPB_SLABWH_TIER bll_TPB_SLABWH_TIER = new Bll_TPB_SLABWH_TIER();//钢坯库层信息
        private Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        private List<Mod_SLAB_INFO> lst = null;

        private void btn_save_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (var item in lst)
            {
                bll_TSC_SLAB_MAIN.UpdateSlabTier(i.ToString(), item.C_STOVE, item.C_SLABWH_CODE, item.C_SLABWH_AREA_CODE, item.C_SLABWH_LOC_CODE, item.C_SLABWH_TIER_CODE.ToString());
                i++;
            }
            MessageBox.Show("修改成功！");
            btn_Query_Click(null, null);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_SLAB_INFO> DataTableToList(DataTable dt)
        {
            List<Mod_SLAB_INFO> modelList = new List<Mod_SLAB_INFO>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_SLAB_INFO model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        private void FrmRA_TC_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindGPK(cbo_CK1);
            cbo_CK1.SelectedIndex = 0;
            BindStoreArea();
            BindStoreLoc();
        }

        /// <summary>
        /// 绑定仓库区域
        /// </summary>
        public void BindStoreArea()
        {
            string slabwhID = bll_TPB_SLABWH.GetList_id(cbo_CK1.EditValue.ToString());
            DataTable dt = Bll_TPB_SLABWH_AREA.GetListBySlabwhID(slabwhID).Tables[0];
            image_Area.Properties.Items.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    this.image_Area.Properties.Items.Add(item["C_SLABWH_AREA_NAME"].ToString(), item["C_SLABWH_AREA_CODE"], -1);
                }
            }
            this.image_Area.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定仓库库位
        /// </summary>
        public void BindStoreLoc()
        {
            string areaCode = this.image_Area.EditValue == null ? "" : this.image_Area.EditValue.ToString();
            string areaID = "";
            DataTable dt = null;
            if (!string.IsNullOrWhiteSpace(areaCode))
            {
                areaID = Bll_TPB_SLABWH_AREA.GetList_ID(areaCode);
                dt = Bll_TPB_SLABWH_LOC.GetListByArea(areaID, 1).Tables[0];
            }
            image_Loc.Properties.Items.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    this.image_Loc.Properties.Items.Add(item["C_SLABWH_LOC_NAME"].ToString(), item["C_SLABWH_LOC_CODE"], -1);
                }
            }
            this.image_Loc.SelectedIndex = 0;
        }

        private void cbo_CK1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindStoreArea();
            BindStoreLoc();
        }

        private void image_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindStoreLoc();
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_SLAB_INFO DataRowToModel(DataRow row)
        {
            Mod_SLAB_INFO model = new Mod_SLAB_INFO();
            if (row != null)
            {
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["N_QUA"] != null && row["N_QUA"].ToString() != "")
                {
                    model.N_QUA = decimal.Parse(row["N_QUA"].ToString());
                }
                if (row["C_SLABWH_CODE"] != null)
                {
                    model.C_SLABWH_CODE = row["C_SLABWH_CODE"].ToString();
                }
                if (row["C_SLABWH_AREA_CODE"] != null)
                {
                    model.C_SLABWH_AREA_CODE = row["C_SLABWH_AREA_CODE"].ToString();
                }
                if (row["C_SLABWH_LOC_CODE"] != null)
                {
                    model.C_SLABWH_LOC_CODE = row["C_SLABWH_LOC_CODE"].ToString();
                }
                if (row["C_SLABWH_TIER_CODE"] != null)
                {
                    model.C_SLABWH_TIER_CODE = int.Parse(row["C_SLABWH_TIER_CODE"].ToString());
                }
                if (row["C_SLABWH_CODE_NAME"] != null)
                {
                    model.C_SLABWH_CODE_NAME = row["C_SLABWH_CODE_NAME"].ToString();
                }
                if (row["C_SLABWH_LOC_CODE_NAME"] != null)
                {
                    model.C_SLABWH_LOC_CODE_NAME = row["C_SLABWH_LOC_CODE_NAME"].ToString();
                }

            }
            return model;
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            string slab = cbo_CK1.EditValue.ToString();
            string area = image_Area.EditValue == null ? "" : image_Area.EditValue.ToString(); ;
            string loc = image_Loc.EditValue == null ? "" : image_Loc.EditValue.ToString();
            if (string.IsNullOrWhiteSpace(area) || string.IsNullOrWhiteSpace(loc))
            {
                MessageBox.Show("择区域和库位不能为空");
                return;
            }
            lst = DataTableToList(bll_TSC_SLAB_MAIN.GetTCInfo(slab, area, loc));
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].N_SORT = i;
            }
            bindChangeFlooerSource.DataSource = lst;
            try
            {
                //InitDrop();
            }
            catch { }

        }

        /// <summary>
        /// 行托动方法
        /// </summary>
        /// <param name="lst">加载的数据</param>
        /// <param name="gvSource">gridview</param>
        private void InitDrop()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                this.gv_GPSJ, gv_GPSJ, (row1, row2) =>
                {
                    if (row1 == row2) return;

                    var plan1 = gv_GPSJ.GetRow(row1) as Mod_SLAB_INFO;
                    if (row2 < lst.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gv_GPSJ.RowCount)
                        {
                            row2 = gv_GPSJ.RowCount - 1;
                        }
                        var plan2 = gv_GPSJ.GetRow(row2) as Mod_SLAB_INFO;
                        if (plan2 == null)
                            return;
                        lst.Remove(plan1);
                        var left = lst.TakeWhile(x => x.N_SORT < plan2.N_SORT).ToList();
                        var right = lst.Where(x => left.Contains(x) == false).ToList();
                        lst.Clear();
                        lst.AddRange(left);
                        lst.Add(plan1);
                        lst.AddRange(right);
                    }
                    else
                    {
                        lst.Remove(plan1);
                        lst.Add(plan1);
                    }
                    gv_GPSJ.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;
        }

        /// <summary>
        /// 上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_up_Click(object sender, EventArgs e)
        {
            int rowIndex = gv_GPSJ.FocusedRowHandle;

            if (rowIndex == 0)
            {
                return;
            }
            else
            {
                lst[rowIndex].N_SORT = lst[rowIndex].N_SORT - 1;
                lst[rowIndex - 1].N_SORT = lst[rowIndex - 1].N_SORT + 1;
            }

            lst = lst.OrderBy(x => x.N_SORT).ToList();

            bindChangeFlooerSource.DataSource = lst;

            gv_GPSJ.RefreshData();

            gv_GPSJ.FocusedRowHandle = rowIndex - 1;
        }

        /// <summary>
        /// 下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_down_Click(object sender, EventArgs e)
        {
            int rowIndex = gv_GPSJ.FocusedRowHandle;

            if (rowIndex == lst.Count - 1)
            {
                return;
            }
            else
            {
                lst[rowIndex].N_SORT = lst[rowIndex].N_SORT + 1;
                lst[rowIndex + 1].N_SORT = lst[rowIndex + 1].N_SORT - 1;
            }

            lst = lst.OrderBy(x => x.N_SORT).ToList();

            bindChangeFlooerSource.DataSource = lst;

            gv_GPSJ.RefreshData();

            gv_GPSJ.FocusedRowHandle = rowIndex + 1;
        }
    }
}
