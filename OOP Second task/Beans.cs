using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Second_task
{
    class Beans:Vegetables
    {
        static List<string> vit = new List<string>() { "C", "E", "K" };

        public Beans(double price, int weight)
            : base("Beans", price * 0.001 * weight, 1.23 * weight, weight, "grey", vit)
        { }
    }
}
