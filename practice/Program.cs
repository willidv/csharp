﻿using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=255; i ++){
                Console.WriteLine(i);
            }
            for (int i = 0; i <= 100; i ++){
                if(i%3== 0 || i%5==0){
                    Console.WriteLine(i);
                }
            }
            for(int i = 0; i <= 100; i ++){
                Console.WriteLine(i);
                if(i%3== 0 && i%5 == 0){
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i%3 == 0){
                     Console.WriteLine("Fizz");
                }
                else if (i%5 == 0){
                     Console.WriteLine("Buzz");
                }
            }
            
        }
 
    }

}
