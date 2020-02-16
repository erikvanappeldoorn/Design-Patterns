using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Prototype
{
    public class Sandwich : SandwichPrototype
    {
        private string bread;
        private string meat;
        private string cheese;
        private string veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public string Bread { get => bread; set => bread = value; }
        public string Meat { get => meat; set => meat = value; }
        public string Cheese { get => cheese; set => cheese = value; }
        public string Veggies { get => veggies; set => veggies = value; }

        public override SandwichPrototype Clone()
        {
            return MemberwiseClone() as SandwichPrototype;
        }
    }
}
