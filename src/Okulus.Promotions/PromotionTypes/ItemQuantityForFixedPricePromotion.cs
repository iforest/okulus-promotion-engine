using System;

namespace Okulus.Promotions.PromotionTypes
{
    public class ItemQuantityForFixedPricePromotion : IPromotion
    {
        public string SkuId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal Apply(ICart cart, PromotionContext promotionContext)
        {
            decimal value = 0;

            foreach (var cardItem in cart.Items.Values)
            {
                if(cardItem.SkuId == SkuId) 
                {
                    promotionContext.ProcessedSkus[SkuId] = true;

                    var applicableQuantity = cardItem.Quantity / Quantity;
                    var remainingQuantity = applicableQuantity > 0 ? cardItem.Quantity % Quantity : cardItem.Quantity;

                    value += (applicableQuantity * Price) + (remainingQuantity * cardItem.UnitPrice);
                }
            }

            return value;
        }
    }
}
