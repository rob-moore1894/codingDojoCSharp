using System;
using System.Collections.Generic; 

namespace BasicThirteen
{
    class Program
    {
        public static void divider(){
            Console.WriteLine("========================================================");
        }

        public static void DisplayArray(int[] numbers){
            for (int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]); 
            }
        }
        public static void PrintNumbers(){
            Console.WriteLine("Print Numbers"); 
            for (int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
            divider();
        }

        public static void PrintOdds(){
            Console.WriteLine("Print Odds"); 
            for (int i = 1; i <= 255; i++){
                if(i%2 != 0){
                    Console.WriteLine(i); 
                }
            }
            divider();
        }

        public static void PrintSum(){
            Console.WriteLine("Print Sum");
            int sum = 0; 
            for (int i = 0; i <= 255; i++){
                sum += i; 
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
            divider();
        }

        public static void LoopArray(int[] numbers){
            Console.WriteLine("Loop Array"); 
            for (int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]); 
            }
            divider();
        }

        public static void FindMax(int[] numbers){
            Console.WriteLine("Find Max");
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++){
                if (max < numbers[i]){
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Max number is = {max}");
            divider();
        }

        public static void GetAverage(int[] numbers){
            Console.WriteLine("Get Average");
            decimal sum = 0; 
            for (int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
                Console.WriteLine($"Number = {numbers[i]} Sum = {sum}"); 
            }
            decimal avg = sum/numbers.Length; 
            Console.WriteLine(avg);
            divider();
        }

        public static int[] OddArray(){
            Console.WriteLine("Odd Array");
            int[] arr = new int[128];
            int odd = 1;  
            for(int i = 0; i < 128; i++){
                arr[i] = odd; 
                odd += 2; 
            }
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]); 
            }
            divider();
            return arr; 
        }

        public static int GreaterThanY(int[] numbers, int y){
            Console.WriteLine($"Greater than {y}");
            int count = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > y){
                    count++;
                }
            }
            Console.WriteLine(count);
            divider(); 
            return count; 
        }

        public static void SquareArrayValues(int[] numbers){
            Console.WriteLine("Square Array");
            for(int i = 0; i < numbers.Length; i++){
                numbers[i] = numbers[i] * numbers[i];
            }
            DisplayArray(numbers); 
            divider();
        }

        public static void EliminateNegatives(int[] numbers){
            Console.WriteLine("Eliminate Negatives");
            for (int i = 0; i < numbers.Length; i++){
                if (numbers[i] < 0){
                    numbers[i] = 0;
                }
            }
            DisplayArray(numbers);
            divider();
        }

        public static void MinMaxAverage(int[] numbers){
            Console.WriteLine("Min Max Average");
            int[] mma = new int[3];
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(min > numbers[i]){
                    min = numbers[i];
                }
            }
            for(int i = 0; i < numbers.Length; i++){
                if(max < numbers[i]){
                    max = numbers[i];
                }
            }
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            int avg = sum/numbers.Length; 
            mma[0] = min;
            mma[1] = max;  
            mma[2] = avg; 
            DisplayArray(mma); 
            divider();
        }

        public static void ShiftValues(int[] numbers){
            Console.WriteLine("Shift Values");
            for (int i = 1; i < numbers.Length; i++){
                numbers[i-1] = numbers[i];
            }
            numbers[numbers.Length-1] = 0;
            DisplayArray(numbers);
            divider();
        }

        public static object[] NumToString(int[] numbers){
            Console.WriteLine("Num to String");
            object[] result = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++){
                if (numbers[i] < 0){
                    result[i] = "Dojo";
                } else {
                    result[i] = numbers[i];
                }
            }
            foreach (var item in result){
                Console.WriteLine(item);
            }
            divider();
            return result; 
        }

        public static void multiplicationTable(){
            int [,] multTable = new int[10,10]; 
            for(int i = 1; i < multTable.Length; i++){

            }
            Console.WriteLine(multTable);
        }

        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum(); 
            int[] testArr = {35, 11, 8, 7};
            LoopArray(testArr); 
            FindMax(testArr);
            GetAverage(testArr);
            OddArray();
            GreaterThanY(testArr, 10);
            SquareArrayValues(new int[] {1,2,3,4,5}); 
            EliminateNegatives(new int[] {1, 5, 10, -2});
            MinMaxAverage(testArr);
            ShiftValues(testArr);
            NumToString(new int[] {-1, -3, 2});
            multiplicationTable();
        }
    }
}
