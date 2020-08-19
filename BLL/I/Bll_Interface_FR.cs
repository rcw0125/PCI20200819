using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// ReZJB_FYD
    /// </summary>
    public partial class Bll_Interface_FR
    {
        private readonly Dal_Interface_FR dal = new Dal_Interface_FR();
        public Bll_Interface_FR()
        { }
        /// <summary>
        ///同步条码库存信息
        /// </summary>
        /// <param name="Barcode">钢卷唯一码</param>
        /// <param name="CK">仓库</param>
        /// <param name="HW">货位</param>
        /// <param name="WGDH">完工单号</param>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <param name="GZ">钢种</param>
        /// <returns>同步结果</returns>
        public string TbKCList(string Barcode, string CK, string HW, string WGDH, string PH, string GH, string GZ)
        {
            return dal.TbKCList(Barcode, CK, HW, WGDH, PH, GH, GZ);
        }

        /// <summary>
        /// 根据批号获取条码库存钢卷信息
        /// </summary>
        /// <param name="PCH"></param>
        /// <returns></returns>
        public DataTable GetRFListByPCH(string PCH)
        {
            return dal.GetRFListByPCH(PCH);
        }
            /// <summary>
            ///同步条码库存信息
            /// </summary>
            public string TbWWList()
        {
            return dal.TbWWList();
        }
        /// <summary>
        ///同步条码库存信息
        /// </summary>
        public string TbPCIList()
        {
            return dal.TbPCIList();
        }
        /// <summary>
        ///同步条码库存信息
        /// </summary>
        public string TBFYD(string path)
        {
            return dal.TBFYD(path);
        }
        /// <summary>
        ///根据发运单号获取条码中间表数据
        /// </summary>
        /// <param name="C_FYDH">发运单号</param>
        /// <returns></returns>
        public DataSet GetTMFYD(string C_FYDH)
        {
            return dal.GetTMFYD(C_FYDH);
        }
        /// <summary>
        /// 根据单号获取线材实绩日志
        /// </summary>
        /// <param name="DH">单号</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        public DataSet GetYWDXQ(string DH, string status, string id)
        {
            return dal.GetYWDXQ(DH, status, id);
        }
        /// <summary>
        /// 获取最新的转库单号
        /// </summary>
        /// <param name="zkdstr">转库单</param>
        /// <returns></returns>
        public string GetZKDNO(string zkdstr)
        {
            return dal.GetZKDNO(zkdstr);
        }
        /// <summary>
        /// 检测库存是否变更
        /// </summary>
        /// <param name="mat">物料号</param>
        /// <param name="ck">仓库</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public int CKKC(string mat, string ck, string batch, string zldj, string bzyq)
        {
            return dal.CKKC(mat, ck, batch, zldj, bzyq);
        }

        /// <summary>
        /// 向条码发送转库单
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <param name="ckcode">仓库代码</param>
        /// <returns></returns>
        public string SENDZKD1(List<CommonKC> list, string mbck, string zkd)
        {
            return dal.SENDZKD1(list, mbck, zkd);
        }
        /// <summary>
        /// 根据转库单号获取条码转库单数据
        /// </summary>
        /// <param name="C_ZKD">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetTMZKZJB(string C_ZKD)
        {
            return dal.GetTMZKZJB(C_ZKD);
        }
        /// <summary>
        /// 同步条码转库单信息
        /// </summary>
        /// <param name="path">地址</param>
        /// <returns></returns>
        public string TBZKD1(string path)
        {
            return dal.TBZKD1(path);
        }
        /// <summary>
        /// 获取最新的其他出库单号
        /// </summary>
        /// <param name="qtckdstr">出库单号</param>
        /// <returns></returns>
        public string GetQTCKNO(string qtckdstr)
        {
            return dal.GetQTCKNO(qtckdstr);
        }
        /// <summary>
        /// 向条码发送其他出库信息
        /// </summary>
        /// <param name="num">数量</param>
        /// <param name="cph">车牌号</param>
        /// <param name="address">位置</param>
        /// <param name="zdr">制单人</param>
        /// <param name="cklx">出库类型</param>
        /// <param name="shdw">送货单位</param>
        /// <param name="fysj">发运实绩</param>
        /// <returns></returns>
        public string SENDQTCKD1(List<CommonKC> list, string qtckd, string cph, string address, string zdr, string cklx, string shdw, DateTime fysj, string cys, string mbckid, string mbckmc)
        {
            return dal.SENDQTCKD1(list, qtckd, cph, address, zdr, cklx, shdw, fysj, cys, mbckid, mbckmc);
        }
        /// <summary>
        ///根据条码其他出库单撤销数据
        /// </summary>
        /// <param name="ZKD">转库单</param>
        /// <returns></returns>
        public int CXZKDByDH(string ZKD)
        {
            return dal.CXZKDByDH(ZKD);
        }
        /// <summary>
        ///根据条码其他出库单撤销数据
        /// </summary>
        /// <param name="qtckd">其他出库单</param>
        /// <returns></returns>
        public int CXQTCKDByDH(string qtckd)
        {
            return dal.CXQTCKDByDH(qtckd);
        }
        /// <summary>
        /// 同步条码移位单信息
        /// </summary>
        /// <returns></returns>
        public string TBYWD()
        {
            return dal.TBYWD();
        }
        /// <summary>
        /// 获取移位单数据
        /// </summary>
        /// <param name="C_YWDH">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetTMYWD(string C_YWDH)
        {
            return dal.GetTMYWD(C_YWDH);
        }
        /// <summary>
        /// 获取其他出库单数据
        /// </summary>
        /// <param name="C_QTCKD">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetTMZJB(string C_QTCKD)
        {
            return dal.GetTMZJB(C_QTCKD);
        }
        /// <summary>
        /// 同步条码其他出库单信息
        /// </summary>
        /// <returns></returns>
        public string QTCKDTB(string xmlFileName)
        {
            return dal.QTCKDTB(xmlFileName);
        }

        /// <summary>
        /// 查询线材重量
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="gh">钩号</param>
        /// <returns></returns>
        public DataSet RfXC(string batchNo, string gh)
        {
            return dal.RfXC(batchNo, gh);
        }

        /// <summary>
        /// 获取线材信息
        /// </summary>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        public DataSet RollPro(string batchNo, string gh)
        {
            return dal.RollPro(batchNo, gh);
        }

        public bool UpdateWgt(string id, decimal wgt, DateTime rkrq)
        {
            return dal.UpdateWgt(id, wgt, rkrq);
        }
        /// 获取条码库存信息
        /// </summary> 
        /// <param name="PH">批号</param> 
        /// <param name="GH">勾号</param> 
        public DataSet Get_TM_XL_List(string PCH, string GH)
        {
            return dal.Get_TM_XL_List(PCH, GH);
        }
    }

}
