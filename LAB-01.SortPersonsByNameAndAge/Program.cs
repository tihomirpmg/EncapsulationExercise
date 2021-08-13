using System;
using System.Linq;
using System.Collections.Generic;

namespace LAB_01.SortPersonsByNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert how many persons you will add: ");
            int line = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert first name, last name and age for {0} persons", line);
            List<Person> persons = new List<Person>();
            for (int i = 0; i < line; i++)
            {
                string[] info = Console.ReadLine().Split();
                Person person = new Person(info[0], info[1], int.Parse(info[2]));
                persons.Add(person);
            }
            persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
