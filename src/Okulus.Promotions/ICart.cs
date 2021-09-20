using System;
using System.Collections.Generic;

namespace Okulus.Promotions
{
    public interface ICart
    {
        IDictionary<string,CartItem> Items { get; }
        decimal TotalValue { get; }
    }
}
