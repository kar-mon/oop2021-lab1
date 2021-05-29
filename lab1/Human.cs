using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Human
    {
        public string FirstName;
        public string LastName;
        public Animal Pet;
        public Phone Phone;
        public int Number;
        private Car _car;
        public Car Car
        {
            get => _car;
            set
            {
                if (_salary > value.Value)
                {
                    _car = value;
                }
                else Console.WriteLine("this car is too expensive for you");
            }



        }

        private DateTime Date;
        private decimal _salary=500;
        public decimal Salary
        { 
            get => _salary;
            set { _salary = value > 0 ? value : 0;
                Console.WriteLine("the information has been added");
                Date = DateTime.Now;
                    }

        }


    }
}
