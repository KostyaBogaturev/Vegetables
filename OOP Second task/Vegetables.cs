using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Second_task
{
    abstract class Vegetables:Food
    {

        public string Colour { get; protected set; }


        protected Vegetables(string name, double price, double calorie,
            int weight, string colour, List<string> vitamins)
            :base(name, price, calorie, weight, vitamins) { 
            Colour = colour;
        }

        public override string ToString()
        {
            return $"{Name}(price {Price}, calorie {Calorie}, colour {Colour}) ";
        }

    }
}
