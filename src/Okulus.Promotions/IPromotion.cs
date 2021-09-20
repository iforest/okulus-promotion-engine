using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulus.Promotions
{
    public interface IPromotion
    {
        decimal Apply(ICart cart, PromotionContext promotionContext);
    }
}
