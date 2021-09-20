using System;
using System.Collections.Generic;

namespace Okulus.Promotions
{
    public class PromotionEngine : IPromotionEngine
    {
        public PromotionEngine(IEnumerable<IPromotion> promotions)
            => Promotions = promotions ?? throw new ArgumentNullException(nameof(promotions));

        public IEnumerable<IPromotion> Promotions { get; init; }

        public decimal ApplyPromotions(ICart cart)
        {
            var promotionContext = new PromotionContext();
            decimal value = 0;

            foreach (var promotion in Promotions)
            {
                value += promotion.Apply(cart, promotionContext);
            }

            foreach (var cartItem in cart.Items.Values)
            {
                if (!promotionContext.ProcessedSkus.ContainsKey(cartItem.SkuId))
                {
                    value += cartItem.Quantity * cartItem.UnitPrice;
                }
            }

            return value;
        }
    }
}
