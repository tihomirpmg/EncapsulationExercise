using System;
using System.Collections.Generic;

namespace LAB_02.SalaryIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert how many persons you will add: ");
            int line = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert first name, last name, age and salary for {0} persons, then input the percentage", line);
            List<Person> persons = new List<Person>();
            for (int i = 0; i < line; i++)
            {
                string[] info = Console.ReadLine().Split();
                Person person = new Person(info[0], info[1], int.Parse(info[2]), decimal.Parse(info[3]));
                persons.Add(person);
            }
            decimal percentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
