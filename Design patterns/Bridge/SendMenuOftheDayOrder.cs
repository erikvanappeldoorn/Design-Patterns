using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Bridge
{
    public class SendMenuOftheDayOrder : SendOrderBase
    {
        public SendMenuOftheDayOrder(IRestaurant restaurant) : base(restaurant)
        {
            
        }
        public override void Send()
        {
            base.restaurant.Place("Menu of the day Order");
        }
    }
}
