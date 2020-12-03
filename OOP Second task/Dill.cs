using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Second_task
{
    class Dill:Vegetables
    {
        static List<string> vit = new List<string>() { "C", "B2", "P" };

        public Dill(double price, int weight)
            : base("Dill", price * 0.001 * weight, 0.43 * weight, weight, "green", vit)
        { }
    }
}
