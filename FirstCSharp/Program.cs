﻿using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Rob"; 
            Random rand = new Random(); 
            int randAge = rand.Next(1,101);
            for (int i = 0; i < 10; i++){
                if(randAge == 1){
                    Console.WriteLine($"My name is {name}, I am {randAge} year old");
                } else {
                    Console.WriteLine($"My name is {name}, I am {randAge} years old");
                }
            }
        }
    }
}
