using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Common
{
    public class Cart
    {

        public Dictionary<int, CartItem> _myCart = new Dictionary<int, CartItem>();



        public void AddItem(CartItem cartItem)
        {
            if (_myCart.ContainsKey(cartItem.Id))
            {
                _myCart[cartItem.Id].Quantity += 1;
                return;
            }
            _myCart.Add(cartItem.Id, cartItem);
        }

        //todo: update item

    }
}
