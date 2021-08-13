using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            Console.WriteLine("On first line insert (name=money;) for as many people as you want.");
            string[] namesInput = Console.ReadLine().Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("On second line insert (product=price;) for as many products as you want");
            string[] productsInput = Console.ReadLine().Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("On every new line insert (name (of person) product (which product tried to buy))");
            Console.WriteLine("When you are ready type END");

            for (int i = 0; i < namesInput.Length - 1; i += 2)
            {
                string name = namesInput[i];
                double money = double.Parse(namesInput[i + 1]);
                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }

            for (int i = 0; i < productsInput.Length - 1; i += 2)
            {
                string name = productsInput[i];
                double cost = double.Parse(productsInput[i + 1]);
                try
                {
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string personName = inputParts[0];
                string productName = inputParts[1];

                Person person = people.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                person.BuyProduct(product);
                input = Console.ReadLine();
            }

            foreach (Person person in people)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} ------- Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
                }
            }
        }
    }
}
