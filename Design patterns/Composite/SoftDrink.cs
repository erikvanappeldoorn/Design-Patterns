﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Composite
{
    public abstract class SoftDrink
    {
        public int Calories { get; set; }

        public List<SoftDrink> Flavors { get; set; }

        public SoftDrink(int calories)
        {
            Calories = calories;
            Flavors = new List<SoftDrink>();
        }

        public void DisplayCalories()
        {
            Console.WriteLine(this.GetType().Name + ": " + this.Calories.ToString() + " calories.");
            foreach (var flavor in this.Flavors)
            {
                flavor.DisplayCalories();
            }
        }
    }
}
