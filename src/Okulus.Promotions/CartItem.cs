using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulus.Promotions
{
    public struct CartItem 
    {
        public CartItem(string skuId, int quantity, decimal value)
            => (SkuId, Quantity, Value) = (skuId, quantity, value);

        public string SkuId { get; }
        public int Quantity { get; }
        public decimal Value { get; }
    }
}
