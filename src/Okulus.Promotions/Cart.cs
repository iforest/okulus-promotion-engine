using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulus.Promotions
{
    public class Cart : ICart
    {
        private List<CartItem> _items;

        public Cart(IEnumerable<CartItem> items)
        {
            _ = items ?? throw new ArgumentNullException(nameof(items));

            _items = new List<CartItem>(items);
            TotalValue = _items.Sum(item => item.Quantity * item.Value);
        }

        public IEnumerable<CartItem> Items => _items.AsReadOnly();

        public decimal TotalValue { get; }
    }
}
