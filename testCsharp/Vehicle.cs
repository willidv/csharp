using System; 

namespace testCsharp{
    public class Vehicle{
        public int numPassenger = 4;
        public double distance;
        public Vehicle(int val = 0){
            numPassenger = val;
            distance = 0.0;
        }
        public void Drive(double miles){
            /*create functions called METHODS!!! as public within the class. If STATIC is not included, then each separate instance of this class can use the method, and it will not affect other instancces of the same class. on the Program.cs file, it will show that both a bike and a car in the same class can use the functions and it will affect each one separate from the other. */
            distance += miles;
        }
        public void Reverse(double miles){
            distance -= miles;
        }
    }
    public class Person{
        public string hair_color;
        public string eye_color;
        public string work_ethic;
        public Person(string x, string y, string z){
            hair_color = x;
            eye_color = y;
            work_ethic = z;
        }
    }
 
}