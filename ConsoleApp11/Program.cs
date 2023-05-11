using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            //змінні
            List<char> abc = new List<char>();
            //створення
            for (int i = 65; i < 91; ++i)
            {
                abc.Add(Convert.ToChar(i));
            }
            //вивід
            foreach (char liter in abc)
            {
                Console.WriteLine(liter);
            }

            Console.WriteLine("task 2");
            //змінні
            Random random = new Random();
            List<house> houses = new List<house>();
            int num_houses = random.Next(1, 4);
            //створення
            for (int i = 0; i < num_houses; ++i)
            {
                houses.Add(new house());
            }
            //вивід
            foreach (house house in houses)
            {
                house.show();
            }
            Console.WriteLine("Num houses: " + num_houses);

            Console.WriteLine("task 3");
            //змінні
            List<garage> garages = new List<garage>();
            int num_garage = random.Next(1, 4);
            //створення
            for (int i = 0; i < num_houses; ++i)
            {
                garages.Add(new garage());
            }
            //вивід
            foreach (var garage in garages)
            {
                garage.show();
            }
            Console.ReadLine();
        }
    }
}