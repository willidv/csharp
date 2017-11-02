using System;

namespace employees
{
    public class Employee
    {
        public string First_Name;
        public string Last_Name;
        public string City;
        public int Age{ get; set; }
        

         public void PrintName()
        {  
            Console.WriteLine(this.First_Name);
        }
    }
    public class FullTimeEmployee : Employee{
        public string type = "salaried";
        public new void PrintName(){
            Console.WriteLine(this.Last_Name);
        }
    }
    public class PartTimeEmployee : Employee{
       public string type = "hourly";
       public new void PrintName(){
            Console.WriteLine(this.Last_Name);
        }
    }
}