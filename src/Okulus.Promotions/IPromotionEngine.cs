using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulus.Promotions
{
    public interface IPromotionEngine
    {
        IEnumerable<IPromotion> Promotions { get; init; }

        decimal ApplyPromotions(ICart cart);
    }
}
