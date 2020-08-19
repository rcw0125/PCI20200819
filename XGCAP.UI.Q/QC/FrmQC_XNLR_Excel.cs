using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BLL;
using MODEL;
using Common;
using DevExpress.Spreadsheet;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XNLR_Excel : Form
    {
        private Bll_TQC_PHYSICS_RESULT bllTqcPhysicsResult = new Bll_TQC_PHYSICS_RESULT();
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQC_PHYSICS_RESULT_MAIN bllTqcPhyResultMain = new Bll_TQC_PHYSICS_RESULT_MAIN();
        private Bll_TQB_PHYSICS_QUALITATIVE bllTqbPhysicsQualitative = new Bll_TQB_PHYSICS_QUALITATIVE();

        List<Sampples> list = new List<Sampples>();
        private string strPhyCode;
        private string strMenuName;

        private DataTable dtDX;

        private string str_PHYSICS_GROUP_ID;

        Bll_TQB_PHYSICS_EQUIPMENT bll_TQB_PHYSICS_EQUIPMENT = new Bll_TQB_PHYSICS_EQUIPMENT();//实验室设备
        Bll_TQB_PHYSICS_GROUP blltqbPhysicsGroup = new Bll_TQB_PHYSICS_GROUP();//物理检验项目分组维护

        private Worksheet _sheet { get => this.spreadsheetControl1.ActiveWorksheet; }
        // 数据绑定起始位置
        private string _dataRange = "A2";
        // 列头绑定起始位置
        private string _columnRange = "J1";
        public FrmQC_XNLR_Excel()
        {
            InitializeComponent();

            this.spreadsheetManager1.Init();

            this.spreadsheetManager1.ContentChanged += SpreadsheetManager1_ContentChanged;
        }

        private void FrmQC_XNLR_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;
                strPhyCode = RV.UI.QueryString.parameter;

                dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

                dt_Start_Result.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dt_End_Result.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

                str_PHYSICS_GROUP_ID = blltqbPhysicsGroup.Get_ID(strPhyCode);

                DataTable dt = blltqbPhysicsGroup.GetList_Code(strPhyCode).Tables[0];


                dtDX = bllTqbPhysicsQualitative.Get_List(str_PHYSICS_GROUP_ID).Tables[0];



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 修改指定表格中的数据
        /// </summary>
        /// <param name="obj"></param>
        private void SpreadsheetManager1_ContentChanged(List<Cell> obj)
        {
            var changeRowList = obj.Select(w => new { row = GetRowObj(w), cell = w }).Where(x => x.row != null).ToArray();

            Array.ForEach(changeRowList, x => SetObjValu(x.row, x.cell));
        }
        /// <summary>
        /// 保存修改的数据
        /// </summary>
        /// <param name="currentRowObj"></param>
        /// <param name="cell"></param>
        private void SetObjValu(Sampples currentRowObj, Cell cell)
        {
            // 获取cell值
            var obj = CellValue.DefaultConverter.ConvertToObject(cell.Value);

            DataTable dt_Result = bllTqcPhysicsResult.Get_XNList(strPhyCode, str_PHYSICS_GROUP_ID).Tables[0];
            int cStart = _sheet[_columnRange].RightColumnIndex;//数据绑定的起始值
            int cEnd = cStart + dt_Result.Rows.Count;
            int cValue = 7;
            if (cell.ColumnIndex == cValue)
            {
                currentRowObj.C_EQ_NAME = obj?.ToString();
                return;
            }
            if (cell.ColumnIndex < cStart || cell.ColumnIndex > cEnd) { return; } 

            var detailIndex = cell.ColumnIndex - _sheet[_columnRange].RightColumnIndex;

            var resultinfo = currentRowObj.Results[detailIndex];

            resultinfo.Value = obj?.ToString();
        }
        /// <summary>
        /// 查询录入结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Result_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable dt_Code = blltqbPhysicsGroup.GetList_Code(strPhyCode).Tables[0];
                //DataTable dt_name = bll_TQB_PHYSICS_EQUIPMENT.GetList_Fid(dt_Code.Rows[0]["C_ID"].ToString()).Tables[0];
                //CellValue[] cells = new CellValue[dt_name.Rows.Count];
                //for (int i = 0; i < dt_name.Rows.Count; i++)
                //{
                //    cells[i] = dt_name.Rows[i]["C_EQ_NAME"].ToString();
                //}
                // BindResult();
                DataTable dt = bllTqcPresentSamples.GetList(dt_Start.Text.Trim(), dt_End.Text.Trim(), txt_BatchNo.Text.Trim(), str_PHYSICS_GROUP_ID).Tables[0];

                List<Sampples> list_sam = new List<Sampples>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Sampples sam = new Sampples();
                    sam.C_ID = dt.Rows[i]["取样主表主键"].ToString();
                    sam.C_BATCH_NO = dt.Rows[i]["炉号"].ToString();
                    sam.C_STOVE = dt.Rows[i]["批号"].ToString();
                    sam.C_TICK_NO = dt.Rows[i]["钩号"].ToString();
                    sam.C_STL_GRD = dt.Rows[i]["钢种"].ToString();
                    sam.C_STD_CODE = dt.Rows[i]["执行标准"].ToString();
                    sam.C_SPEC = dt.Rows[i]["规格"].ToString();
                    sam.D_MOD_DT_ZY = dt.Rows[i]["制样时间"].ToString();
                    sam.C_EQ_NAME = dt.Rows[i]["设备信息"].ToString();
                    sam.C_CHECK_STATE = dt.Rows[i]["检验状态"].ToString();
                    list_sam.Add(sam);
                }
                DataTable dt_count = bllTqcPhysicsResult.Get_XNList(strPhyCode, dt.Rows[0]["取样主表主键"].ToString()).Tables[0];
                string[] strHead = new string[dt_count.Rows.Count];

                foreach (var item in list_sam)
                {
                    DataTable dt_Result = bllTqcPhysicsResult.Get_XNList(strPhyCode, item.C_ID).Tables[0];
                    for (int s = 0; s < dt_Result.Rows.Count; s++)
                    {
                        Result res = new Result();
                        strHead[s] = dt_Result.Rows[s]["C_NAME"].ToString();
                        res.C_CHARACTER_ID = dt_Result.Rows[s]["C_CHARACTER_ID"].ToString();
                        res.C_PHYSICS_GROUP_ID = dt_Result.Rows[s]["C_PHYSICS_GROUP_ID"].ToString();
                        res.C_CODE = dt_Result.Rows[s]["C_CODE"].ToString();
                        res.Name = dt_Result.Rows[s]["C_NAME"].ToString();
                        res.Value = dt_Result.Rows[s]["C_VALUE"].ToString();
                        item.Results.Add(res);
                    }
                }
                list.Clear();
                list.AddRange(list_sam);
                this.spreadsheetControl1.BeginUpdate();
                // 绑定列头
                this.spreadsheetManager1.BuildHeader(_sheet["J1"], strHead);
                // 绑定数据
                var dataRange = _sheet.BindDataSource(_sheet[_dataRange], list);

                //var cmbRange = this._sheet.Range.FromLTRB(7, 1, 7, dataRange.BottomRowIndex);
                //_sheet.DataValidations.Add(cmbRange, DataValidationType.List, ValueObject.CreateListSource(cells));
                _sheet.FreezePanes(0, 2);
                this.spreadsheetControl1.EndUpdate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 指定区域的内容修改
        /// </summary>
        /// <param name="cell">修改的值</param>
        /// <returns></returns>
        private Sampples GetRowObj(Cell cell)
        {
            var rowIndex = cell.RowIndex - 1;

            if (rowIndex < 0 || rowIndex > list.Count - 1) { return null; }

            return list[rowIndex];
        }
        /// <summary>
        /// 结果值查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                BindResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 绑定性能结果信息
        /// </summary>
        private void BindResult()
        {
            DataTable dt = bllTqcPhysicsResult.Get_List(strPhyCode, txt_BatchNo.Text.Trim(), dt_Start_Result.Text.Trim(), dt_End_Result.Text.Trim(), "1").Tables["ds"];

            gc_Result.DataSource = dt;
            gv_Result.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Result);

            if (dt != null && dt.Rows.Count > 0)
            {
                gv_Result.Columns[9].Caption = "录入人";
                gv_Result.Columns[0].Visible = false;
            }
        }


        /// <summary>
        /// 保存性能录入结果信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bllTqcPresentSamples.GetList(dt_Start.Text.Trim(), dt_End.Text.Trim(), txt_BatchNo.Text.Trim(), str_PHYSICS_GROUP_ID).Tables[0];
                string userID = RV.UI.UserInfo.userID;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    ArrayList SQLStringList = new ArrayList();

                    string C_PRESENT_SAMPLES_ID = dt.Rows[i]["取样主表主键"].ToString();
                    DataTable dt_Result = bllTqcPhysicsResult.Get_XNList(strPhyCode, C_PRESENT_SAMPLES_ID).Tables[0];
                    Mod_TQC_PHYSICS_RESULT_MAIN mod = bllTqcPhyResultMain.GetModel(C_PRESENT_SAMPLES_ID);
                    if (mod != null)
                    {
                        mod.C_EQ_NAME = list[i].C_EQ_NAME;
                        bllTqcPhyResultMain.Update(mod);
                    }

                    bllTqcPhysicsResult.Delete(str_PHYSICS_GROUP_ID, C_PRESENT_SAMPLES_ID);

                    for (int k = 0; k < dt_Result.Rows.Count; k++)
                    {
                        string strType = "";
                        if (list[i].Results[k].C_CODE.Contains("000GCL"))
                        {
                            strType = "0";
                        }
                        else
                        {
                            strType = "1";
                        }

                        if (!string.IsNullOrEmpty(list[i].Results[k].Value))
                        {
                            SQLStringList.Add("insert into TQC_PHYSICS_RESULT(C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,C_EMP_ID,N_TYPE,C_TICK_NO)values('" + str_PHYSICS_GROUP_ID + "','" + C_PRESENT_SAMPLES_ID + "','" + list[i].Results[k].C_CHARACTER_ID + "','" + list[i].Results[k].C_CODE + "','" + list[i].Results[k].Name + "','" + list[i].Results[k].Value + "','" + userID + "','" + strType + "','" + list[i].C_TICK_NO + "') ");
                        }
                    }

                    if (bllTqcPhysicsResult.SaveResult(SQLStringList))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存性能信息");//添加操作日志  
                    }
                }
                MessageBox.Show("保存成功！");
                btn_Result_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
    /// <summary>
    /// 制样信息
    /// </summary>
    public class Sampples
    {
        /// <summary>
        /// 取样主表主键
        /// </summary> 
        public string C_ID { get; set; }
        /// <summary>
        /// 炉号
        /// </summary>
        [SpreadSheetCell]
        public string C_STOVE { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        [SpreadSheetCell]
        public string C_BATCH_NO { get; set; }
        /// <summary>
        /// 钩号
        /// </summary>
        [SpreadSheetCell]
        public string C_TICK_NO { get; set; }
        /// <summary>
        /// 钢种
        /// </summary>
        [SpreadSheetCell]
        public string C_STL_GRD { get; set; }
        /// <summary>
        /// 执行标准
        /// </summary>
        [SpreadSheetCell]
        public string C_STD_CODE { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        [SpreadSheetCell]
        public string C_SPEC { get; set; }
        /// <summary>
        /// 制样时间
        /// </summary>
        [SpreadSheetCell]
        public string D_MOD_DT_ZY { get; set; }
        /// <summary>
        /// 设备信息
        /// </summary>
        [SpreadSheetCell]
        public string C_EQ_NAME { get; set; }
        /// <summary>
        /// 检验状态
        /// </summary>
        [SpreadSheetCell]
        public string C_CHECK_STATE { get; set; }
        /// <summary>
        /// 子表
        /// </summary>
        [SpreadSheetCell]
        public List<Result> Results { get; set; } = new List<Result>();
    }
    /// <summary>
    /// 检测项目结果
    /// </summary>
    public class Result
    {
        /// <summary>
        /// 基础数据外键
        /// </summary>
        public string C_CHARACTER_ID { get; set; }
        /// <summary>
        /// 配置表外键
        /// </summary>
        public string C_PHYSICS_GROUP_ID { get; set; }
        /// <summary>
        /// 检测项目代码
        /// </summary>
        public string C_CODE { get; set; }
        /// <summary>
        /// 检测项目
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 结果值
        /// </summary>
        [SpreadSheetCell]
        public string Value { get; set; }
    }
}
