using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                cars.Add(new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2])));                
            }

            List<string> data = Console.ReadLine().Split(' ').ToList();
       
            while (data[0] != "End")
            {
                string model = data[1];
                double distance = double.Parse(data[2]);

                Car car = cars.First(c => c.Model == model);

                if (!car.Drive(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                data = Console.ReadLine().Split(' ').ToList();
            }

            cars.ForEach(Console.WriteLine);

        }
    }
}
