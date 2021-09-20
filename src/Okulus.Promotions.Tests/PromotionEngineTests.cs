using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Okulus.Promotions.Tests
{
    public class PromotionEngineTests
    {
        private static IEnumerable<TestCaseData> promotionEngineTestCaseData = new[]
        {
            new TestCaseData(new Cart(new CartItem[]{new("A", 1, 50), new("B", 1, 30), new("C", 1, 20)}))
                .Returns(100)
                .SetName("Scenario A"),
            new TestCaseData(new Cart(new CartItem[]{new("A", 5, 50), new("B", 5, 30), new("C", 1, 20)}))
                .Returns(370)
                .SetName("Scenario B"),
            new TestCaseData(new Cart(new CartItem[]{new("A", 3, 50), new("B", 5, 30), new("C", 1, 20), new("D", 1, 15)}))
                .Returns(280)
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
            return Enumerable.Empty<IPromotion>();
        }
    }
}
