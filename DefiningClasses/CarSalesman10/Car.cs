using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int? weight)
            : this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color)
           : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int? weight, string color)
           : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public int? Weight { get; set; }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color { get; set; }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{Model}:");
            builder.Append(Engine);
            builder.AppendLine($"  Weight: {(Weight == null ? "n/a" : Weight.ToString())}");
            builder.Append($"  Color: {(Color == null ? "n/a" : Color)}");

            return builder.ToString();
        }
    }
}
