using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MODEL
{
    public partial class Mod_TPP_LGPC_LSB
    {
        public string test { get; set; }

        public Mod_TPP_LGPC_LSB Clone()
        {
            return new Mod_TPP_LGPC_LSB()
            {
                C_BY1 = this.C_BY1,
                C_BY2 = this.C_BY2,
                C_BY3 = this.C_BY3,
                C_CCM_CODE = this.C_CCM_CODE,
                C_CCM_ID = this.C_CCM_ID,
                C_DFP_HL = this.C_DFP_HL,
                C_HL = this.C_HL,
                C_ID = Guid.NewGuid().ToString("N"),
                C_REMARK = this.C_REMARK,
                C_RH = this.C_RH,
                C_STL_GRD = this.C_STL_GRD,
                C_XM = this.C_XM,
                N_GROUP = this.N_GROUP,
                N_JSCN = this.N_JSCN,
                N_MLZL = this.N_MLZL,
                N_ORDER_LS = 0,
                N_PRODUCE_TIME = this.N_PRODUCE_TIME,
                N_SORT = this.N_SORT + 1,
                N_TOTAL_WGT = this.N_TOTAL_WGT,
                N_ZJCLS = this.N_ZJCLS,
                N_ZJCLZL = this.N_ZJCLZL,
            };
        }
    }
}
