using Common;
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

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_JCJHCK : Form
    {
        public FrmPP_JCJHCK()
        {
            InitializeComponent();
        }

        private Bll_TSP_PLAN_SMS bll_lcjh = new Bll_TSP_PLAN_SMS();//炉次计划

        private void FrmPP_JCJHCK_Load(object sender, EventArgs e)
        {
            this.dt_to.Text = System.DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            this.dt_from.Text = System.DateTime.Now.AddDays(-10).ToString("yyyy-MM-dd");
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            int xh = 0;
            if (BindJCJH("3#CC", this.gridControl1, this.gridView1))
            {
                this.gridControl1.Visible = true;
                this.gridView1.ColumnWidthChanged += GridView1_ColumnWidthChanged;
                xh = 3;
            }
            else
            {
                this.gridControl1.Visible = false;
            }
            if (BindJCJH("4#CC", this.gridControl2, this.gridView2))
            {
                this.gridView2.ColumnWidthChanged += GridView2_ColumnWidthChanged;
                splitterControl1.Visible = true;
                xh = 4;
            }
            else
            {
                splitterControl1.Visible = false;
                this.gridControl2.Visible = false;
            }
            if (BindJCJH("5#CC", this.gridControl3, this.gridView3))
            {
                this.gridView3.ColumnWidthChanged += GridView3_ColumnWidthChanged;
                splitterControl2.Visible = true;
                xh = 5;
            }
            else
            {
                splitterControl2.Visible = false;
                this.gridControl3.Visible = false;
            }
            if (BindJCJH("6#CC", this.gridControl4, this.gridView4))
            {
                this.gridView4.ColumnWidthChanged += GridView4_ColumnWidthChanged;
                splitterControl4.Visible = true;
                xh = 6;
            }
            else
            {
                splitterControl3.Visible = false;
                this.gridControl4.Visible = false;
            }
            if (BindJCJH("7#CC", this.gridControl5, this.gridView5))
            {
                this.gridView5.ColumnWidthChanged += GridView5_ColumnWidthChanged;
                splitterControl4.Visible = true;
                xh = 7;
            }
            else
            {
                splitterControl4.Visible = false;
                this.gridControl5.Visible = false;
            }

            if (xh == 7)
            {
                this.gridControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            if (xh == 6)
            {
                this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            if (xh == 5)
            {
                this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            if (xh == 4)
            {
                this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            if (xh == 3)
            {
                this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            }


        }
        #region ColumnWidthChange
        private void GridView5_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            #region MyRegion
            this.gridView5.OptionsView.RowAutoHeight = true;
            for (int i = 0; i < gridView5.Columns.Count; i++)
            {
                if (gridView5.Columns[i].FieldName == "C_STL_GRD")
                {
                    //设置所有列可编辑
                    gridView5.Columns[i].OptionsColumn.AllowEdit = true;
                    //RepositoryItemMemoEdit对每一列进行设置
                    DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryitemmemoedi1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                    gridView5.Columns[i].ColumnEdit = repositoryitemmemoedi1;
                    repositoryitemmemoedi1.LinesCount = 0;

                    //设置列不可编辑
                    gridView5.Columns[i].OptionsColumn.AllowEdit = false;
                }

            }
            #endregion
        }

        private void GridView4_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            #region MyRegion
            this.gridView4.OptionsView.RowAutoHeight = true;
            for (int i = 0; i < gridView4.Columns.Count; i++)
            {
                if (gridView4.Columns[i].FieldName == "C_STL_GRD")
                {
                    //设置所有列可编辑
                    gridView4.Columns[i].OptionsColumn.AllowEdit = true;
                    //RepositoryItemMemoEdit对每一列进行设置
                    DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryitemmemoedi1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                    gridView4.Columns[i].ColumnEdit = repositoryitemmemoedi1;
                    repositoryitemmemoedi1.LinesCount = 0;

                    //设置列不可编辑
                    gridView4.Columns[i].OptionsColumn.AllowEdit = false;
                }

            }
            #endregion
        }

        private void GridView3_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {

            #region MyRegion
            this.gridView3.OptionsView.RowAutoHeight = true;
            for (int i = 0; i < gridView3.Columns.Count; i++)
            {
                if (gridView3.Columns[i].FieldName == "C_STL_GRD")
                {
                    //设置所有列可编辑
                    gridView3.Columns[i].OptionsColumn.AllowEdit = true;
                    //RepositoryItemMemoEdit对每一列进行设置
                    DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryitemmemoedi1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                    gridView3.Columns[i].ColumnEdit = repositoryitemmemoedi1;
                    repositoryitemmemoedi1.LinesCount = 0;

                    //设置列不可编辑
                    gridView3.Columns[i].OptionsColumn.AllowEdit = false;
                }

            }
            #endregion
        }

        private void GridView2_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            #region MyRegion
            this.gridView1.OptionsView.RowAutoHeight = true;
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                if (gridView1.Columns[i].FieldName == "C_STL_GRD")
                {
                    //设置所有列可编辑
                    gridView1.Columns[i].OptionsColumn.AllowEdit = true;
                    //RepositoryItemMemoEdit对每一列进行设置
                    DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryitemmemoedi1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                    gridView1.Columns[i].ColumnEdit = repositoryitemmemoedi1;
                    repositoryitemmemoedi1.LinesCount = 0;

                    //设置列不可编辑
                    gridView1.Columns[i].OptionsColumn.AllowEdit = false;
                }

            }
            #endregion
        }

        private void GridView1_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            #region MyRegion
            this.gridView1.OptionsView.RowAutoHeight = true;
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                if (gridView1.Columns[i].FieldName == "C_STL_GRD")
                {
                    //设置所有列可编辑
                    gridView1.Columns[i].OptionsColumn.AllowEdit = true;
                    //RepositoryItemMemoEdit对每一列进行设置
                    DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryitemmemoedi1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                    gridView1.Columns[i].ColumnEdit = repositoryitemmemoedi1;
                    repositoryitemmemoedi1.LinesCount = 0;

                    //设置列不可编辑
                    gridView1.Columns[i].OptionsColumn.AllowEdit = false;
                }

            }
            #endregion
        }
        #endregion
        public bool BindJCJH(string C_CCM,DevExpress.XtraGrid.GridControl gc, DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            DataTable dt = bll_lcjh.GetJCJH(C_CCM,this.dt_from.Text.Trim(),this.dt_to.Text.Trim());
            if (dt.Rows.Count>0)
            {
                gc.DataSource = dt;
                //gv.OptionsView.ColumnAutoWidth = false;
                gv.OptionsSelection.MultiSelect = true;
                SetGridViewRowNum.SetRowNum(gv);
                return true;
            }
            else
            {
                return false;                    
            }
           
        }

        private void Gv_ColumnChanged(object sender, EventArgs e)
        {






        }
    }
}
