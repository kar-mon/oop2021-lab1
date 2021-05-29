using System;

namespace OOPlab1 {
    class Program {
        static void Main(string[] args) {
            Animal dog = new Animal( "canis canis", 7);

            dog.Name = "Szarik";
            dog.Feed(2.0);
            dog.TakeForAWalk(10.0);

            string text = dog.ReturnSpeciesAndName();
            Console.WriteLine(text);
            text += " afawe";
            Console.WriteLine(text);

            String nameAndOwner = dog.ReturnNameAndOwner("Grazyna");
            Console.WriteLine(nameAndOwner);

            Human me = new Human();
            me.FirstName = "Grazyna";
            me.LastName = "Karczoch";
            me.Pet = dog;

            dog.Feed(1.0);
            dog.PrintWeight();

            Car vehicle = new Car("volvo", "xc70", 13, "3,2l", "black");
            Console.WriteLine(vehicle);

            Car automobil = new Car("ford", "fiesta", 3, "0,5l", "red");
            Car auto = new Car("ford", "fiesta", 7, "1l", "grey");
            
            if (vehicle.Equals(automobil)) { Console.WriteLine("the same car"); };
            if (automobil.Equals(auto)) { Console.WriteLine("totally the same car"); };
            
            me.Phone = new Phone("onePlus",
                "8Pro",
                2.3,
                "Android");
            Console.WriteLine(me.Phone.Model);

            me.Phone = new Phone("apple", "6s", 5.0, "iOs");

            Console.WriteLine(me.Phone.Model);
        }
    }
}
