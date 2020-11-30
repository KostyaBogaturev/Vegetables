using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Second_task
{
    class Tomato : Vegetables
    {
        static List<string> vit = new List<string>() { "A", "B6", "PP" };

        public Tomato(double price, int weight)
            : base("Tomato", price*0.001*weight, 0.18 * weight, weight, "red", vit)
        { }
    }
}
