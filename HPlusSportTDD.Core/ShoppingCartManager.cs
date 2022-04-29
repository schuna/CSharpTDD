using System;

namespace HPlusSportTDD.Core
{
    public class ShoppingCartManager
    {
        public ShoppingCartManager()
        {
        }

        public static AddToCartResponse AddToCart(AddToCartRequest request)
        {
            return new AddToCartResponse()
            {
                Items = new AddToCartItem[] { request.Item }
            };
        }
    }
}