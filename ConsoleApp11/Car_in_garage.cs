using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class car
    {
        private string brend;
        Random random = new Random();
        public car()
        {
            Console.WriteLine("enter brend of car");
            brend = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine(brend);
        }
    }
    public class garage
    {
        public List<car> cars = new List<car>();
        public Random random = new Random();
        public int num_car;
        public garage()
        {
            num_car = random.Next(1, 9);
            for (int i = 0; i < num_car; ++i)
            {
                cars.Add(new car());
            }
        }
        public void show()
        {
            foreach (car car in cars)
            {
                Console.WriteLine("brend of car:");
                car.show();
            }
            Console.WriteLine("cars in this garage : " + num_car);
        }
    }
}
}
