using System;
namespace MODEL
{
    /// <summary>
    /// 钢坯完工信息
    /// </summary>
    [Serializable]
	public partial class Mod_TSC_SLAB_MES
	{
		public Mod_TSC_SLAB_MES()
		{}
		#region Model
		private string _guid;
		private string _name;
		private string _materialid;
		private decimal? _status;
		private string _position;
		private decimal? _qastatus;
		private decimal? _qalevel;
		private string _ordercontractid;
		private string _producecontractid;
		private string _salescontractid;
		private string _casterid;
		private string _casting_no;
		private decimal? _casting_heat_cnt;
		private string _pre_steelgradeindex;
		private string _steelgradeindex;
		private string _cut_steelgradeindex;
		private string _final_steelgradeindex;
		private decimal? _length;
		private decimal? _width;
		private decimal? _thickness;
		private string _cur_section_id;
		private string _cur_pile_id;
		private string _cur_layer_id;
		private decimal? _cur_seq_id;
		private string _cur_bay_id;
		private string _destination;
		private decimal? _hot_send_flag;
		private decimal? _process_type;
		private string _plan_ord_id;
		private DateTime? _produce_date;
		private decimal? _finish_flag;
		private DateTime? _finishedtime;
		private decimal? _bloom_count;
		private decimal? _cal_weight;
		private decimal? _right_count;
		private decimal? _right_weight;
		private decimal? _waster_count;
		private decimal? _waster_weight;
		private decimal? _waster_count1;
		private decimal? _waster_weight1;
		private string _waster_reason1;
		private decimal? _waster_count2;
		private decimal? _waster_weight2;
		private string _waster_reason2;
		private decimal? _waster_count3;
		private decimal? _waster_weight3;
		private string _waster_reason3;
		private decimal? _wrong_count;
		private decimal? _wrong_weight;
		private decimal? _wrong_count1;
		private decimal? _wrong_weight1;
		private string _wrong_reason1;
		private decimal? _wrong_count2;
		private decimal? _wrong_weight2;
		private string _wrong_reason2;
		private decimal? _wrong_count3;
		private decimal? _wrong_weight3;
		private string _wrong_reason3;
		private string _sufacedefactdes;
		private string _reason;
		private string _heatid;
		private decimal? _test_roll_count;
		private decimal? _test_roll_weight;
		private decimal? _back_flag;
		private DateTime? _back_date;
		private decimal? _add_bloom_count;
		private decimal? _div_bloom_count;
		private decimal? _plan_bloom_count;
		private string _add_div_heatid;
		private string _add_heatid1;
		private string _add_heatid2;
		private decimal? _add_bloom_count2;
		private DateTime _d_insert_time= Convert.ToDateTime(DateTime.Now);
		private string _c_up_state="N";
		/// <summary>
		/// 
		/// </summary>
		public string GUID
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
		}
        /// <summary>
        /// 炉号
        /// </summary>
        public string MATERIALID
		{
			set{ _materialid=value;}
			get{return _materialid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string POSITION
		{
			set{ _position=value;}
			get{return _position;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? QASTATUS
		{
			set{ _qastatus=value;}
			get{return _qastatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? QALEVEL
		{
			set{ _qalevel=value;}
			get{return _qalevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERCONTRACTID
		{
			set{ _ordercontractid=value;}
			get{return _ordercontractid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRODUCECONTRACTID
		{
			set{ _producecontractid=value;}
			get{return _producecontractid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SALESCONTRACTID
		{
			set{ _salescontractid=value;}
			get{return _salescontractid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CASTERID
		{
			set{ _casterid=value;}
			get{return _casterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CASTING_NO
		{
			set{ _casting_no=value;}
			get{return _casting_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CASTING_HEAT_CNT
		{
			set{ _casting_heat_cnt=value;}
			get{return _casting_heat_cnt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRE_STEELGRADEINDEX
		{
			set{ _pre_steelgradeindex=value;}
			get{return _pre_steelgradeindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STEELGRADEINDEX
		{
			set{ _steelgradeindex=value;}
			get{return _steelgradeindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUT_STEELGRADEINDEX
		{
			set{ _cut_steelgradeindex=value;}
			get{return _cut_steelgradeindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FINAL_STEELGRADEINDEX
		{
			set{ _final_steelgradeindex=value;}
			get{return _final_steelgradeindex;}
		}
		/// <summary>
		/// 长
		/// </summary>
		public decimal? LENGTH
		{
			set{ _length=value;}
			get{return _length;}
		}
		/// <summary>
		/// 宽
		/// </summary>
		public decimal? WIDTH
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 厚
		/// </summary>
		public decimal? THICKNESS
		{
			set{ _thickness=value;}
			get{return _thickness;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUR_SECTION_ID
		{
			set{ _cur_section_id=value;}
			get{return _cur_section_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUR_PILE_ID
		{
			set{ _cur_pile_id=value;}
			get{return _cur_pile_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUR_LAYER_ID
		{
			set{ _cur_layer_id=value;}
			get{return _cur_layer_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CUR_SEQ_ID
		{
			set{ _cur_seq_id=value;}
			get{return _cur_seq_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUR_BAY_ID
		{
			set{ _cur_bay_id=value;}
			get{return _cur_bay_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESTINATION
		{
			set{ _destination=value;}
			get{return _destination;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? HOT_SEND_FLAG
		{
			set{ _hot_send_flag=value;}
			get{return _hot_send_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PROCESS_TYPE
		{
			set{ _process_type=value;}
			get{return _process_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PLAN_ORD_ID
		{
			set{ _plan_ord_id=value;}
			get{return _plan_ord_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PRODUCE_DATE
		{
			set{ _produce_date=value;}
			get{return _produce_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FINISH_FLAG
		{
			set{ _finish_flag=value;}
			get{return _finish_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? FINISHEDTIME
		{
			set{ _finishedtime=value;}
			get{return _finishedtime;}
		}
        /// <summary>
        /// 支数
        /// </summary>
        public decimal? BLOOM_COUNT
		{
			set{ _bloom_count=value;}
			get{return _bloom_count;}
		}
        /// <summary>
        /// 重量
        /// </summary>
        public decimal? CAL_WEIGHT
		{
			set{ _cal_weight=value;}
			get{return _cal_weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RIGHT_COUNT
		{
			set{ _right_count=value;}
			get{return _right_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RIGHT_WEIGHT
		{
			set{ _right_weight=value;}
			get{return _right_weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WASTER_COUNT
		{
			set{ _waster_count=value;}
			get{return _waster_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WASTER_WEIGHT
		{
			set{ _waster_weight=value;}
			get{return _waster_weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WASTER_COUNT1
		{
			set{ _waster_count1=value;}
			get{return _waster_count1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WASTER_WEIGHT1
		{
			set{ _waster_weight1=value;}
			get{return _waster_weight1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WASTER_REASON1
		{
			set{ _waster_reason1=value;}
			get{return _waster_reason1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WASTER_COUNT2
		{
			set{ _waster_count2=value;}
			get{return _waster_count2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WASTER_WEIGHT2
		{
			set{ _waster_weight2=value;}
			get{return _waster_weight2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WASTER_REASON2
		{
			set{ _waster_reason2=value;}
			get{return _waster_reason2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WASTER_COUNT3
		{
			set{ _waster_count3=value;}
			get{return _waster_count3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WASTER_WEIGHT3
		{
			set{ _waster_weight3=value;}
			get{return _waster_weight3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WASTER_REASON3
		{
			set{ _waster_reason3=value;}
			get{return _waster_reason3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WRONG_COUNT
		{
			set{ _wrong_count=value;}
			get{return _wrong_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WRONG_WEIGHT
		{
			set{ _wrong_weight=value;}
			get{return _wrong_weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WRONG_COUNT1
		{
			set{ _wrong_count1=value;}
			get{return _wrong_count1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WRONG_WEIGHT1
		{
			set{ _wrong_weight1=value;}
			get{return _wrong_weight1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WRONG_REASON1
		{
			set{ _wrong_reason1=value;}
			get{return _wrong_reason1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WRONG_COUNT2
		{
			set{ _wrong_count2=value;}
			get{return _wrong_count2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WRONG_WEIGHT2
		{
			set{ _wrong_weight2=value;}
			get{return _wrong_weight2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WRONG_REASON2
		{
			set{ _wrong_reason2=value;}
			get{return _wrong_reason2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WRONG_COUNT3
		{
			set{ _wrong_count3=value;}
			get{return _wrong_count3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WRONG_WEIGHT3
		{
			set{ _wrong_weight3=value;}
			get{return _wrong_weight3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WRONG_REASON3
		{
			set{ _wrong_reason3=value;}
			get{return _wrong_reason3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUFACEDEFACTDES
		{
			set{ _sufacedefactdes=value;}
			get{return _sufacedefactdes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REASON
		{
			set{ _reason=value;}
			get{return _reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HEATID
		{
			set{ _heatid=value;}
			get{return _heatid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TEST_ROLL_COUNT
		{
			set{ _test_roll_count=value;}
			get{return _test_roll_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TEST_ROLL_WEIGHT
		{
			set{ _test_roll_weight=value;}
			get{return _test_roll_weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BACK_FLAG
		{
			set{ _back_flag=value;}
			get{return _back_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BACK_DATE
		{
			set{ _back_date=value;}
			get{return _back_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ADD_BLOOM_COUNT
		{
			set{ _add_bloom_count=value;}
			get{return _add_bloom_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DIV_BLOOM_COUNT
		{
			set{ _div_bloom_count=value;}
			get{return _div_bloom_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PLAN_BLOOM_COUNT
		{
			set{ _plan_bloom_count=value;}
			get{return _plan_bloom_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADD_DIV_HEATID
		{
			set{ _add_div_heatid=value;}
			get{return _add_div_heatid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADD_HEATID1
		{
			set{ _add_heatid1=value;}
			get{return _add_heatid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADD_HEATID2
		{
			set{ _add_heatid2=value;}
			get{return _add_heatid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ADD_BLOOM_COUNT2
		{
			set{ _add_bloom_count2=value;}
			get{return _add_bloom_count2;}
		}
        /// <summary>
        /// 同步时间
        /// </summary>
        public DateTime D_INSERT_TIME
		{
			set{ _d_insert_time=value;}
			get{return _d_insert_time;}
		}
		/// <summary>
		/// 是否上传NC；
		/// </summary>
		public string C_UP_STATE
		{
			set{ _c_up_state=value;}
			get{return _c_up_state;}
		}
		#endregion Model

	}
}

