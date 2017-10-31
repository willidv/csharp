using System;
using System.Collections.Generic;

namespace lists_dicts_arrs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length ; i ++){
                Console.WriteLine(i);
            }

            string[] names = new string[4]{"Tim", "Martin", "Nikki", "Sara" };
            foreach(string name in names){
                Console.WriteLine(name);
            }
            bool[] values = new bool[10];
            for(int i = 0; i <=10; i ++){
                if(i%2 == 0){
                    values[i] = true;
                }
                else if (i%2==1){
                    values[i] = false;
                }
                foreach(bool val in values)
                Console.WriteLine(val);
            }

            int[,] multitable = new int[10,10];
            for(int i = 1; i <= 10; i ++){
                for(int j = 1; j <=10; j ++){
                    multitable[i-1,j-1] = i*j;
                    foreach(int n in multitable)
                    Console.WriteLine(n);
                }
            }
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Bday Cake");
            flavors.Add("Butter Pecan");
            foreach (string f in flavors)
            Console.WriteLine(f);
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            Dictionary<string, string> people = new Dictionary<string,string>();
            string[] names = new string[4]{"Tim", "Martin", "Nikki", "Sara" };
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Bday Cake");
            flavors.Add("Butter Pecan");
            Random rand = new Random();
            foreach(string n in names){
                people.Add(key: n, value: flavors[rand.Next(0,4)]);
            }
            foreach (var entry in people){
                Console.WriteLine(entry.Key + " - " + entry.Value);
                
            }
        }

    }
    
}
