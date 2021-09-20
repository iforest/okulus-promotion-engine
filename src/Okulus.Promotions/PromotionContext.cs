using System;
using System.Collections.Generic;

namespace Okulus.Promotions
{
    public class PromotionContext
    {
        public IDictionary<string, bool> ProcessedSkus { get; init; } = new Dictionary<string, bool>();
    }
}
