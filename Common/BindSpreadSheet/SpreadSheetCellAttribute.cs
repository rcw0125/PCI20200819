using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class SpreadSheetCellAttribute : Attribute
    {
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="seq">排序值，顺序，越小越靠前</param>
        public SpreadSheetCellAttribute(int seq = 0, bool visible = true)
        {
            this.Seq = seq;
            this.Visible = visible;
        }

        /// <summary>
        /// 排序值，顺序排列
        /// </summary>
        public int Seq { get; set; }

        public bool Visible { get; set; }
    }
}
