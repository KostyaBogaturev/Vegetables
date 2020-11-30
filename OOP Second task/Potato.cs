using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Second_task
{
    class Potato:Vegetables
    {
        static List<string> vit = new List<string>() { "A1", "B2" };

        public Potato( double price,int weight)
            : base("Potato", price * 0.001 * weight, 0.77*weight, weight, "brown", vit)
        { }
    }
}
