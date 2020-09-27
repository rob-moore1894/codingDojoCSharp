using System;

namespace CSharpFundamentals
{
    class Program
    {
        // For Loop Versions
        static void divider(){
            Console.WriteLine("=======================================================");
        }
        static void print1to255(){
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
            divider();
        }
        static void divBy3or5(){
            for(int i = 1; i <= 100; i++){
                if (i % 3 == 0 || i % 5 == 0){
                    Console.WriteLine(i); 
                }
            }
            divider();
        }
        static void fizzBuzz(){
            for (int i = 1; i <= 100; i++){
                if (i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine($"{i} = FizzBuzz"); 
                } else if (i % 5 == 0){
                    Console.WriteLine($"{i} = Buzz");
                } else if (i % 3 == 0){
                    Console.WriteLine($"{i} = Fizz");
                } 
            }
            divider(); 
        }
        // While Loop Versions
        static void while1to255(){
            int i = 1;
            while (i <= 255){
                Console.WriteLine(i);
                i++; 
            }
            divider();
        }
        static void while3or5(){
            int i = 1; 
            while(i <= 100){
                if(i % 3 == 0 || i % 5 == 0){
                    Console.WriteLine(i);
                }
                i++;
            }
            divider();
        }
        static void whileFizzBuzz(){
            int i = 1;
            while(i <= 100){
                if (i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine($"{i} FizzBuzz");
                } else if (i % 3 == 0){
                    Console.WriteLine($"{i} Fizz");
                } else if (i % 5 == 0){
                    Console.WriteLine($"{i} Buzz");
                }
                i++;
            }
            divider();
        }
        static void Main(string[] args)
        {
            print1to255(); 
            divBy3or5(); 
            fizzBuzz(); 
            while1to255();
            while3or5();
            whileFizzBuzz();
        }
    }
}
