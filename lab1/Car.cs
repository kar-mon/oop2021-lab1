using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Car {
        public string Make;
        public string Model;
        public decimal Value;
        public string Engine;
        public string Colour;

        public Car(string make, string model, decimal value, string engine, string colour)
        {
            Make = make;
            Model = model;
            Value = value;
            Engine = engine;
            Colour = colour;
        }
        public override string ToString() {
            return Make + " " + Model + " " + Value + " " + Engine + " " + Colour;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Car c = (Car)obj;
                return (this.Make == c.Make) && (this.Model == c.Model);
            }
        }

    }
}
