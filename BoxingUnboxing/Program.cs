using System;
using System.Collections.Generic; 

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object
            var list = new List<object>();

            // Add the following values to the list: 7, 28, -1, true, "chair"
            int a = 7; 
            int b = 28;
            int c = -1; 
            bool t = true; 
            string str = "chair";
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(t);
            list.Add(str); 
            
            // Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach(var item in list){
                Console.WriteLine(item); 
            }

            // Add all values that are Int type together and output the sum
            int sum = 0; 
            foreach(var item in list){
                if (item is int){
                    sum = sum + (int)item; 
                }
            }
            Console.WriteLine($"Sum of all integers in object = {sum}");
        }
    }
}
