using System;
using System.Collections.Generic;
using NUnit.Framework;
using Okulus.Promotions.PromotionTypes;

namespace Okulus.Promotions.Tests
{
    public class PromotionEngineTests
    {
        private static IEnumerable<TestCaseData> promotionEngineTestCaseData = new[]
        {
            new TestCaseData(new Cart(new CartItem[]{new("A", 1, 50), new("B", 1, 30), new("C", 1, 20)}))
                .Returns(100M)
                .SetName("Scenario A"),
            new TestCaseData(new Cart(new CartItem[]{new("A", 5, 50), new("B", 5, 30), new("C", 1, 20)}))
                .Returns(370M)
                .SetName("Scenario B"),
            new TestCaseData(new Cart(new CartItem[]{new("A", 3, 50), new("B", 5, 30), new("C", 1, 20), new("D", 1, 15)}))
                .Returns(280M)
                .SetName("Scenario C"),
        };

        [TestCaseSource(nameof(promotionEngineTestCaseData))]
        public decimal ShouldCalculateTotalOrderValueAfterApplyingActivePromotion(ICart cart)
        {
            IEnumerable<IPromotion> activePromotions = GetActivePromotions();
            IPromotionEngine promotionEngine = new PromotionEngine(activePromotions);

            return promotionEngine.ApplyPromotions(cart);
        }

        private IEnumerable<IPromotion> GetActivePromotions() 
        {
            return new IPromotion[] { 
                new ItemQuantityForFixedPricePromotion {SkuId="A", Quantity=3, Price=130},
                new ItemQuantityForFixedPricePromotion {SkuId="B", Quantity=2, Price=45},
                new ItemComboForFixedPricePromotion {SkuIds=new[]{"C","D"}, Price=30},
            };
        }
    }
}
