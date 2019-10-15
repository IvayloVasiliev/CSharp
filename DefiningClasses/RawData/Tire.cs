using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        //<Tire1Pressure> <Tire1Age> 

        private double pressure;
        private int age;

        public Tire(int age, double pressure )
        {
            this.Pressure = pressure;
            this.Age = age;
        }

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }



    }
}
