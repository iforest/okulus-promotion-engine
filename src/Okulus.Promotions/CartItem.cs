using System;

namespace Okulus.Promotions
{
    public struct CartItem 
    {
        public CartItem(string skuId, int quantity, decimal unitPrice)
            => (SkuId, Quantity, UnitPrice) = (skuId, quantity, unitPrice);

        public string SkuId { get; }
        public int Quantity { get; }
        public decimal UnitPrice { get; }
    }
}
