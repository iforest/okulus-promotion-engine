using System;
using System.Linq;

namespace Okulus.Promotions.PromotionTypes
{
    public class ItemComboForFixedPricePromotion : IPromotion
    {
        public string[] SkuIds { get; set; }
        public decimal Price { get; set; }

        public decimal Apply(ICart cart, PromotionContext promotionContext)
        {
            decimal value = 0;

            if(SkuIds.All(skuid => cart.Items.ContainsKey(skuid))) 
            {
                foreach (var skuId in SkuIds)
                {
                    promotionContext.ProcessedSkus[skuId] = true;
                }
                value = cart.Items[SkuIds[0]].Quantity * Price;
            }
            
            return value;
        }
    }
}
