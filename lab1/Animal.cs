using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Animal {
        private string Species;
        public string Name;
        private double weight;
        private bool isAlive = true;

        public Animal(string species, double animalWeight)
        {
            Species = species;
            weight = animalWeight;
        }

        public void PrintWeight() {
            Console.WriteLine(weight);
        }

        public void Feed(double foodWeight) {
            if (isAlive)
            {
                weight += foodWeight;
                Console.WriteLine("thx for food, bro");
                Console.WriteLine("my weight is now " + weight);
            }

            else Console.WriteLine("The animal is dead");
        }

        public void TakeForAWalk(double walkWeight)
        {
            if (isAlive)
            {
                weight -= walkWeight;
                Console.WriteLine("thx for walk, bro");
                if (weight <= 0)
                {
                    isAlive = false;
                    weight = 0;
                }
                Console.WriteLine("my weight is now " + weight);
            }
            if (!isAlive) { Console.WriteLine("The animal is dead"); }
        }



        public string ReturnSpeciesAndName() {
            return Species + " " + Name;
        }

        public string ReturnNameAndOwner(string owner) {
            return Name + " " + owner;
        }
    }
}
