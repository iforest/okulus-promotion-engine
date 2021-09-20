using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulus.Promotions
{
    public class PromotionEngine : IPromotionEngine
    {
        public PromotionEngine(IEnumerable<IPromotion> promotions)
            => Promotions = promotions ?? throw new ArgumentNullException(nameof(promotions));

        public IEnumerable<IPromotion> Promotions { get; init; }

        public decimal ApplyPromotions(ICart cart)
        {
            throw new NotImplementedException();
        }
    }
}
