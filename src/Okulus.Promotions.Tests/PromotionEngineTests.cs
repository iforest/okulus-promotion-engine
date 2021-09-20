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
            new TestCaseData(new[]{("A", 1), ("B", 1), ("C", 1)})
                .Returns(100)
                .SetName("Scenario A"),
            new TestCaseData(new[]{("A", 5), ("B", 5), ("C", 1)})
                .Returns(370)
                .SetName("Scenario B"),
            new TestCaseData(new[]{("A", 3), ("B", 5), ("C", 1), ("D", 1)})
                .Returns(280)
                .SetName("Scenario C"),
        };

        [TestCaseSource(nameof(promotionEngineTestCaseData))]
        public decimal ShouldCalculateTotalOrderValueAfterApplyingActivePromotion(
            (string skuId, int quantity)[] items
        )
        {
            throw new NotImplementedException();
        }
    }
}
