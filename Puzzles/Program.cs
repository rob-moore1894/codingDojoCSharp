using System;
using System.Collections.Generic;
using System.Linq;

namespace Puzzles
{
    class Program
    {
        public static void RandomArray(){
            int[] randArr = new int[10];
            Random randNum = new Random();
            for (int i = 0; i < randArr.Length; i++){
                randArr[i] = randNum.Next(5, 25);
            }
            foreach (int num in randArr){
                Console.WriteLine(num);
            }
            int min = FindMin(randArr); 
            int max = FindMax(randArr);
            int sum = SumArray(randArr); 
        }

        public static int SumArray(int[] numbers){
            int sum = 0; 
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            Console.WriteLine($"Sum of Array = {sum}");
            return sum; 
        }

        public static int FindMin(int[] numbers){
            int min = numbers[0];
            for(int i = 0; i < numbers.Length; i++){
                if(min > numbers[i]){
                    min = numbers[i];
                }
            }
            Console.WriteLine($"Minimum Value in Array = {min}");
            return min; 
        }

        public static int FindMax(int[] numbers){
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++){
                if(max < numbers[i]){
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Maximum Value in Array = {max}");
            return max; 
        }

        public static string TossCoin(){
            Random flip = new Random();
            Console.WriteLine("Tossing a Coin!"); 
            int res = flip.Next(0,2); 
            if(res == 0){
                Console.WriteLine("Heads");
                return "Heads";
            } else {
                Console.WriteLine("Tails"); 
                return "Tails";
            }
        }   

        public static double TossMultipleCoins(int num){
            double count = 0; 
            for(int i = 1; i <= num; i++){
                string result = TossCoin();
                if (result == "Heads"){
                    count++;
                } 
            }
            Console.WriteLine($"{count} \"heads\" out of {num} tosses");
            
            return count; 
        }    

        public static List<string> Names(){
            List<string> names = new List<string>(); 
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");

            Console.WriteLine("Original Name List: ");
            foreach(string name in names){
                Console.WriteLine(name); 
            }
            Console.WriteLine("--------------------------------");

            names = names.OrderBy(i => Guid.NewGuid()).ToList(); 
            Console.WriteLine("Shuffled list: ");
            foreach(string name in names){
                Console.WriteLine(name); 
            }
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Names with more than 5 characters");
            foreach(string name in names){
                if(name.Length > 5){
                    Console.WriteLine(name); 
                }
            }
            return names; 
        }      
        
        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine("==========================================");
            TossCoin();
            Console.WriteLine("==========================================");
            TossMultipleCoins(5);
            Console.WriteLine("==========================================");
            Names(); 
        }
    }
}
