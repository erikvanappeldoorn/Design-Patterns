using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Bridge
{
    public abstract class SendOrderBase
    {
        protected readonly IRestaurant restaurant;

        public SendOrderBase(IRestaurant restaurant)
        {
            this.restaurant = restaurant;
        }

        public abstract void Send();
    }
}
