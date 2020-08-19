using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public static class General
    {
        public static string ChoicedName;
        //键和值,键必须是唯一的,而值不需要唯一的
        public static Dictionary<string, string> NameType = new Dictionary<string, string>()
        {
            { "全修2mm", "C_EXTEND1"},{ "全修1.5mm", "C_EXTEND2"},{"全修1.2mm", "C_EXTEND6" },{ "全修1mm", "C_EXTEND3"},{ "精修0.5mm", "C_EXTEND4"},{"精修1mm", "C_EXTEND12" },{"修角刺", "C_EXTEND5" },{ "全修1mm+1mm", "C_EXTEND13"},{ "全修1.5mm+0.5mm", "C_EXTEND14"},{ "全修2.5mm", "C_EXTEND15"}/*,{ "", "C_EXTEND16"}*/
        };
        //键和值,键必须是唯一的,而值不需要唯一的
        public static Dictionary<string, string> NameTypes = new Dictionary<string, string>()
        {
            { "A", "C_EXTEND7"},{ "B", "C_EXTEND8"},{"C", "C_EXTEND9" },{ "E", "C_EXTEND10"},{ "F", "C_EXTEND13"}
        };
    }
}
