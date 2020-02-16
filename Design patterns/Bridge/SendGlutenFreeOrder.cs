using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Bridge
{
    public class SendGlutenFreeOrder : SendOrderBase
    {
        public SendGlutenFreeOrder(IRestaurant restaurant) : base(restaurant)
        {
        }
        public override void Send()
        {
            base.restaurant.Place("Gluten Free order");
        }
    }
}
