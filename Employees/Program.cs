using System;

namespace employees
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee Virginia = new PartTimeEmployee();
            Virginia.First_Name = "Virginia";
            Virginia.Last_Name = "Reardon";
            Virginia.Age =32;

            FullTimeEmployee David = new FullTimeEmployee();
            David.First_Name = "David";
            David.Last_Name = "Williams";
            David.Age = 28;
            
            David.PrintName();
            Console.WriteLine("The employee {0} is {1} years old, and they are {2}", David.First_Name, David.Age, David.type);
            Console.WriteLine("The employee {0} is {1} years old, and they are {2}", Virginia.First_Name, Virginia.Age, Virginia.type);
        }
    }
}
