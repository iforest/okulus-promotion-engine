using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulus.Promotions
{
    public interface ICart
    {
        IEnumerable<CartItem> Items { get; }
        decimal TotalValue { get; }
    }
}
