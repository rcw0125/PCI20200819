using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MODEL
{
    public partial class Mod_TPP_LGPC_LCLSB
    {
        /// <summary>
        /// 是否新增
        /// </summary>
        public bool added { get; set; }

        public Mod_TPP_LGPC_LCLSB Clone()
        {
            return new Mod_TPP_LGPC_LCLSB()
            {
                C_BY1 = this.C_BY1,
                C_BY2 = this.C_BY2,
                C_BY3 = this.C_BY3,
                C_CCM_DESC = this.C_CCM_DESC,
                C_DFP_HL = this.C_DFP_HL,
                C_HL = this.C_HL,
                C_ID = Guid.NewGuid().ToString("N"),
                C_RH = this.C_RH,
                C_STL_GRD = this.C_STL_GRD,
                C_XM = this.C_XM,
                N_GROUP = this.N_GROUP,
                N_SORT = this.N_SORT + 1,
                C_CCM_ID = this.C_CCM_ID,
                C_FK = this.C_FK,
                C_STD_CODE = this.C_STD_CODE,
               // N_JC_SORT = this.N_JC_SORT,
                C_STATE = "1",
                N_SLAB_WGT = this.N_SLAB_WGT,
                added = true
            };
        }
    }
}
