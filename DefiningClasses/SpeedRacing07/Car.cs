using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string  model;
        private double fuelAmmount;
        private double consPerKilometar;
        private  double distance;

        public Car(string model, double fuelAmmount, double consPerKilometar)
        {
            Model = model;
            FuelAmmount = fuelAmmount;
            ConsPerKilometar = consPerKilometar;
            Distance = 0;

        }

        public  double Distance 
        {
            get { return distance; }
            set { distance = value; }
        }

        public double ConsPerKilometar
        {
            get { return consPerKilometar; }
            set { consPerKilometar = value; }
        }

        public double FuelAmmount
        {
            get { return fuelAmmount; }
            set { fuelAmmount = value; }
        }

        public string  Model
        {
            get { return model; }
            set { model = value; }
        }

        public bool Drive(double distance)
        {
            if (distance * ConsPerKilometar <= FuelAmmount)
            {
                FuelAmmount -= ConsPerKilometar * distance;
                Distance += distance;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmmount:F2} {Distance}";
        }

    }
}
