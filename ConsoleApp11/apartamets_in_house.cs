using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class apartment
    {
        private int num_population;
        Random random = new Random();
        public apartment()
        {
            num_population = random.Next(1, 5);
        }
        public void show()
        {
            Console.WriteLine(num_population);
        }
    }
    public class house
    {
        public List<apartment> apartments = new List<apartment>();
        public Random random = new Random();
        public int num_apartaments;
        public house()
        {
            num_apartaments = random.Next(1, 9);
            for (int i = 0; i < num_apartaments; ++i)
            {
                apartments.Add(new apartment());
            }
        }
        public void show()
        {
            foreach (apartment apartment in apartments)
            {
                Console.WriteLine("in this apartment live:");
                apartment.show();
            }
            Console.WriteLine("apartament in this house : " + num_apartaments);
        }
    }
}
}
