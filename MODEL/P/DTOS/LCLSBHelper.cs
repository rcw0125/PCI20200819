using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODEL.P.DTOS
{
    /// <summary>
    /// 浇次计划，炉次计划工具类
    /// </summary>
    public class LCLSBHelper
    {
        /// <summary>
        /// 浇次计划
        /// </summary>
        public List<Mod_TPP_LGPC_LSB> LSBList { get; protected set; }

        /// <summary>
        /// 炉次计划
        /// </summary>
        public List<Mod_TPP_LGPC_LCLSB> LCLSBList { get; protected set; }

        private decimal _minLc = 18;
        private decimal _normalLc = 22;
        private decimal _maxLc = 24;

        public LCLSBHelper(
            List<Mod_TPP_LGPC_LSB> lSBList,
            List<Mod_TPP_LGPC_LCLSB> lCLSBList)
        {
            LSBList = lSBList;
            LCLSBList = lCLSBList;
        }

        /// <summary>
        /// 计算浇次计划炉数
        /// </summary>
        /// <param name="current"></param>
        private void CountLs(Mod_TPP_LGPC_LSB current)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);

            current.N_ZJCLS = jcData.Count();
            current.N_ZJCLZL = jcData.Sum(w => w.N_SLAB_PW);
            current.N_ORDER_LS = jcData.Where(w => w.C_STATE != "1").Count();
            current.C_REMARK = BuildPaiHao(current);
        }

        /// <summary>
        /// 生成牌号，基于炉次计划
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        private string BuildPaiHao(Mod_TPP_LGPC_LSB current)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);
            return current.C_REMARK;
        }

        /// <summary>
        /// 添加炉次计划，考虑浇次计划，合并浇次计划
        /// </summary>
        /// <param name="current"></param>
        /// <param name="lcNum"></param>
        public void Add(Mod_TPP_LGPC_LSB current, int lcNum)
        {
            var grpJc = LSBList.Where(w => w.N_GROUP == current.N_GROUP).OrderByDescending(w => w.N_SORT).ToList();

            foreach (var item in grpJc)
            {
                if (lcNum == 0 || item == current)
                {
                    break;
                }

                // 炉次数据
                var jcData = LCLSBList.Where(w => w.C_FK == item.C_ID).Where(w => w.C_STATE != "1");
                foreach (var lcItem in jcData.OrderByDescending(w => w.N_SORT))
                {
                    if (lcNum == 0) { break; }

                    LCLSBList.Remove(lcItem);
                    AddOrdLc(current, lcItem);

                    lcNum--;
                }
                AddFullLc(item, new List<Mod_TPP_LGPC_LCLSB> { });
                RemoveEmptyJc(item);
                CountLs(item);
            }

            if (lcNum > 0)
            {
                AddLc(current, lcNum);
            }

            CountLs(current);
        }

        /// <summary>
        /// 移除空的浇次计划，及关联的炉次计划
        /// </summary>
        /// <param name="current"></param>
        private void RemoveEmptyJc(Mod_TPP_LGPC_LSB current)
        {
            // 炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);

            if (jcData.All(w => w.C_STATE == "1"))
            {
                LCLSBList.RemoveAll(x => jcData.Contains(x));
                LSBList.Remove(current);
            }
        }

        /// <summary>
        /// 移除炉次计划，满足订单炉次，将移除的订单炉次添加到最后或新的浇次中
        /// </summary>
        /// <param name="current"></param>
        /// <param name="lcNum"></param>
        public void Remove(Mod_TPP_LGPC_LSB current, int lcNum)
        {
            if ((current.N_ZJCLS - current.N_ORDER_LS) >= lcNum)
            {
                // 移除后还能满足订单
                RemoveLcWithMoreOrd(current, lcNum);
            }
            else
            {
                // 移除不能满足订单最低炉数
                RemoveLcWithLessOrd(current, lcNum);
            }

            CountLs(current);
        }

        /// <summary>
        /// 直接添加炉次计划，不考虑浇次炉数
        /// </summary>
        /// <param name="current"></param>
        /// <param name="lcNum"></param>
        private void AddLc(Mod_TPP_LGPC_LSB current, int lcNum)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);

            if (jcData.Count() > 0)
            {
                for (int i = 0; i < lcNum; i++)
                {
                    LCLSBList.Add(jcData.OrderBy(w => w.N_SORT).LastOrDefault().Clone());
                }
            }

            CountLs(current);
        }

        /// <summary>
        /// 直接添加炉次计划，不考虑浇次炉数
        /// </summary>
        /// <param name="current"></param>
        /// <param name="lcData"></param>
        private void AddOrdLc(Mod_TPP_LGPC_LSB current, params Mod_TPP_LGPC_LCLSB[] lcData)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);

            foreach (var item in lcData)
            {
                decimal max = jcData.Max(x => x.N_SORT) ?? 0;
                item.C_FK = current.C_ID;
                item.N_SORT = max + 1;
                item.C_STATE = "0";
                LCLSBList.Add(item);
            }
        }

        /// <summary>
        /// 直接从后往前移除炉次计划，不考虑浇次炉数
        /// 注：优先移除非订单的炉次
        /// </summary>
        /// <param name="current"></param>
        /// <param name="lcNum"></param>
        private void RemoveLcWithMoreOrd(Mod_TPP_LGPC_LSB current, int lcNum)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);

            var removeItem = GetLast(current, lcNum);
            LCLSBList.RemoveAll(w => removeItem.Contains(w));

            //for (int i = 0; i < lcNum; i++)
            //{
            //    LCLSBList.RemoveAll(x => x.C_FK == current.C_ID && x.N_SORT == jcData.Max(l => l.N_SORT));
            //}
        }

        /// <summary>
        /// 移除炉次计划将移除的订单炉次计划添加到最后浇次中，考虑浇次最大炉数
        /// </summary>
        /// <param name="current"></param>
        /// <param name="lcNum"></param>
        private void RemoveLcWithLessOrd(Mod_TPP_LGPC_LSB current, int lcNum)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);

            var removeLcData = GetLast(current, lcNum);
            RemoveLcWithMoreOrd(current, lcNum);
            removeLcData.RemoveAll(x => x.C_STATE =="1");

            // 将炉次计划添加到最后浇次中，或新增浇次并满足最低炉次
            var lastJc = LSBList.Where(w => w.N_GROUP == current.N_GROUP).OrderBy(w => w.N_SORT).LastOrDefault();
            if (lastJc == current)
            {
                // 如果当前浇次就是最后一个浇次，新增浇次
                lastJc = current.Clone();
                LSBList.Add(lastJc);
            }

            ReplaceLc(lastJc, removeLcData);
        }

        /// <summary>
        /// 递归替换炉次计划
        /// 满足最小炉次，如果超过最大炉次新增浇次计划
        /// </summary>
        /// <param name="current"></param>
        /// <param name="replaceLcData"></param>
        private void ReplaceLc(Mod_TPP_LGPC_LSB current, List<Mod_TPP_LGPC_LCLSB> replaceLcData)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);

            // 替换的不是订单类型的炉次
            Replace(current, replaceLcData);

            if (replaceLcData.Count > 0)
            {
                // 添加最少浇次炉次数据
                AddFullLc(current, replaceLcData);
            }

            if (replaceLcData.Count > 0)
            {
                // 新增浇次递归，满足最低炉次
                var addJc = current.Clone();
                LSBList.Add(addJc);
                ReplaceLc(addJc, replaceLcData);
            }

            CountLs(current);
        }

        /// <summary>
        /// 替换Type=1的炉次
        /// </summary>
        /// <param name="current"></param>
        /// <param name="replaceLcData"></param>
        private void Replace(Mod_TPP_LGPC_LSB current, List<Mod_TPP_LGPC_LCLSB> replaceLcData)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);

            // 可替换的炉次
            var dataElse = jcData.Where(w => w.C_STATE == "1").ToList();
            foreach (var item in dataElse)
            {
                if (replaceLcData.Count == 0)
                    break;

                var replaceItem = replaceLcData.FirstOrDefault();
                replaceItem.N_SORT = item.N_SORT;
                replaceItem.C_FK = current.C_ID;
                var index = LCLSBList.IndexOf(item);
                LCLSBList.RemoveAt(index);
                LCLSBList.Insert(index, replaceItem);
                replaceLcData.Remove(replaceItem);
            }
        }

        /// <summary>
        /// 添加整浇次炉次
        /// </summary>
        /// <param name="current"></param>
        /// <param name="replaceLcDat"></param>
        private void AddFullLc(Mod_TPP_LGPC_LSB current, List<Mod_TPP_LGPC_LCLSB> replaceLcData)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID);

            if (replaceLcData.Any())
            {
                // 最大可以添加的炉次
                var maxAddCount = _maxLc - jcData.Count();
                maxAddCount = maxAddCount > replaceLcData.Count ? replaceLcData.Count : maxAddCount;
                var replaceItems = replaceLcData.Take((int)maxAddCount).ToList();
                AddOrdLc(current, replaceItems.ToArray());
                replaceLcData.RemoveAll(w => replaceItems.Contains(w));
            }

            // 添加整浇次炉次
            var elseAdd = (int)_minLc - jcData.Count();
            if (elseAdd > 0)
                AddLc(current, elseAdd);
        }

        /// <summary>
        /// 获取浇次计划中最后几个炉次计划
        /// </summary>
        /// <param name="current"></param>
        /// <param name="lcNum"></param>
        /// <returns></returns>
        private List<Mod_TPP_LGPC_LCLSB> GetLast(Mod_TPP_LGPC_LSB current, int lcNum)
        {
            // 浇次炉次数据
            var jcData = LCLSBList.Where(w => w.C_FK == current.C_ID)
                .OrderBy(w => w.C_STATE != "1")
                .ThenByDescending(w => w.N_SORT);

            return jcData.Take(lcNum).ToList();
        }
    }
}
