using System;

namespace testCsharp
{
    public class Program
    {
    // can create classes here or on another page that shares the same namespace as seen in Vehicle.cs
        public class Game{
        public string type;
        public string ages;
        public string fun;
        public Game(string x, string y, string z){
            /* this is a consctructor, constructors are functions that exist to "construct" instances of a class. A constructor is called the moment an object is created using the "NEW" keyword*/
            type = x;
            ages = y;
            fun = z;
        }
    }
        public static void Main(string[] args)
        {
            Game Beer_Pong = new Game("drinking", "21 and up", "kind of"); /*--> this is an example of the "new" keyword being used to construct an object*/
            Game Spades = new Game("card", "all", "very");

            Person David = new Person("jet black", "dark brown", "hard");
            Person Virginia  = new Person("brown", "blue grey", "super hard");

            Vehicle mycar= new Vehicle(7);
            Vehicle mybike = new Vehicle(1);

            
            mybike.Drive(1.3);
            mycar.Drive(4.5);
            mycar.Reverse(2.0);
                        
            Console.WriteLine(Virginia.eye_color);
            Console.WriteLine("Beer pong is {0} fun", Beer_Pong.fun);
            

            Console.WriteLine("David's hair color is {0} eye color is {1} work ethic is {2}.", David.hair_color, David.eye_color, David.work_ethic);
            Console.WriteLine("My bike drove {0} miles and my car drove {1} miles", mybike.distance, mycar.distance);
        }
    }
}
 