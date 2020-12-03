using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Second_task
{
    abstract class Food
    {
        public List<string> _vitamins = new List<string>();

        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public double Calorie { get; protected set; }
        public int Weight { get; protected set; }

        protected Food(string name, double price, double calorie,
           int weight, List<string> vitamins)
        {
            Name = name;
            Price = price;
            Calorie = calorie;
            Weight = weight;
            _vitamins = vitamins;
        }

    }
}
