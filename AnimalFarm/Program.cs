using System;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert chicken name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Insert chicken age: ");
            int age = int.Parse(Console.ReadLine());

            try
            {
                Chicken chicken = new Chicken(name, age);
                Console.WriteLine("Chicken {0} (age {1}) can produce {2} eggs per day.", chicken.Name, chicken.Age, chicken.GetProductPerDay());
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
