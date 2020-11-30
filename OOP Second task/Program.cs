using System;

namespace OOP_Second_task
{
    class Program
    {
        static void Main(string[] args)
        {

            var potato = new Potato(22.12, 1000);
            var tomato = new Tomato(2.12, 100);
            var dill = new Dill(213, 200);
            var beans = new Beans(11, 115);
            var salad = new Salad("Anton");
            salad.Add(potato);
            salad.Add(tomato);
            salad.Add(dill);
            salad.Add(beans);
            Console.WriteLine($"Calorie of salad Anton = {salad.Calorie}");
            salad.SortList();

        }
    }
}
