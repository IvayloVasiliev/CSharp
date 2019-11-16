using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split();

                string model = data[0];
                int power = int.Parse(data[1]);
                                
                Engine engine = new Engine(model, power);

                if (data.Length == 3)
                {
                    if (int.TryParse(data[2], out int result))
                    {
                        engine.Displacement = result;
                    }
                    else
                    {
                        engine.Efficiency = data[2];
                    }
                }
                else if (data.Length == 4)
                {
                    engine.Displacement = int.Parse(data[2]);
                    engine.Efficiency = data[3];
                }
            
                engines.Add(engine);
            }

            
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var data = Console.ReadLine().Split();

                string model = data[0];
                Engine engine = engines.First(e=>e.Model == data[1]);

                Car car = new Car(model, engine);

                if (data.Length == 3)
                {
                    if (int.TryParse(data[2], out int result))
                    {
                        car.Weight = result;
                    }
                    else
                    {
                        car.Color = data[2];
                    }
                }
                else if (data.Length == 4)
                {
                    car.Weight = int.Parse(data[2]);
                    car.Color = data[3];
                }

                cars.Add(car);
            }

            cars.ForEach(Console.WriteLine);
        }
    }
}
