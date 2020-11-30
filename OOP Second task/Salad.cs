using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Second_task
{
    class Salad : Food
    {
        static List<string> vitamins = new List<string>();
        private List<Vegetables> list = new List<Vegetables>();

        public Salad(string name)
            : base(name, 0, 0, 0, vitamins)
        { }

        public void Add(Potato veg)
        {
            this.Weight += veg.Weight;
            this.Price += veg.Price;
            this.Calorie += veg.Calorie;

            foreach (var item in veg._vitamins)
            {
                this._vitamins.Add(item);
            }

            list.Add(veg);
        }

        public void Add(Tomato veg)
        {
            this.Weight += veg.Weight;
            this.Price += veg.Price;
            this.Calorie += veg.Calorie;

            foreach (var item in veg._vitamins)
            {
                this._vitamins.Add(item);
            }

            list.Add(veg);
        }

        public void Add(Dill veg)
        {
            this.Weight += veg.Weight;
            this.Price += veg.Price;
            this.Calorie += veg.Calorie;

            foreach (var item in veg._vitamins)
            {
                this._vitamins.Add(item);
            }

            list.Add(veg);
        }

        public void Add(Beans veg)
        {
            this.Weight += veg.Weight;
            this.Price += veg.Price;
            this.Calorie += veg.Calorie;

            foreach (var item in veg._vitamins)
            {
                this._vitamins.Add(item);
            }

            list.Add(veg);
        }

        public void SortList()
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].Price > list[j].Price)
                    {
                       var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
