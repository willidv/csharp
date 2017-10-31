using System;
using System.Collections.Generic;

namespace box_unbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            List<int> intlist = new List<int>();
            List<object> blist = new List<object>();
            blist.Add(7);
            blist.Add(-1);
            blist.Add(true);
            blist.Add("chair");
        
            foreach(object i in blist){
                Console.WriteLine(i);
                if (i is int){
                    Sum += Convert.ToInt32(i);
                    Console.WriteLine(Sum);
                }
            }   
        }
    }
}
