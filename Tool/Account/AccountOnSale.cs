using System.Collections.Generic;

namespace SlitherEvo
{
    public class AccountOnSale
    {
        public int InitTime;

        // key: MerchantCommodityID, Value: Num.
        public Dictionary<int, int> MerchantCommodityIDNums = new Dictionary<int, int>();
    }
}