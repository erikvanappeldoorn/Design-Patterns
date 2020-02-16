using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Bridge
{
    public class ThreeMichellinStarRestaurant : IRestaurant
    {
        public void Place(string order)
        {
            Console.WriteLine($"Placing order for {order} at Three Michellin Star Restaurant");
        }
    }
}
