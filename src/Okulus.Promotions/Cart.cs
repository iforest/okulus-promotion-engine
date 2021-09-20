using System;
using System.Collections.Generic;
using System.Linq;

namespace Okulus.Promotions
{
    public class Cart : ICart
    {
        //private Dictionary<string,CartItem> _items;

        public Cart(IEnumerable<CartItem> items)
        {
            _ = items ?? throw new ArgumentNullException(nameof(items));

            foreach (var item in items)
            {
                Items.Add(item.SkuId, item);
            }

            TotalValue = Items.Values.Sum(item => item.Quantity * item.UnitPrice);
        }

        public IDictionary<string, CartItem> Items { get; } = new Dictionary<string,CartItem>();
        
        public decimal TotalValue { get; }
    }
}
