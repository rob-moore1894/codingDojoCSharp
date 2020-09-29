using System;

namespace Algorithms
{
    class Program
    {
        public static bool BinarySearch(int[] arr, int num){
            int left = 0; 
            int right = arr.Length-1; 

            while (left < right){
                int mid = (right + left)/2; 
                if (arr[mid] == num){
                    Console.WriteLine("true");
                    return true; 
                }
                if (arr[mid] < num){
                    left = mid + 1; 
                }
                else {
                    right = mid - 1; 
                }
            }
            Console.WriteLine("false");
            return false; 
        }
        
        static void Main(string[] args)
        {
            BinarySearch(new int[] { 2, 3, 4, 10, 40 }, 11); 
        }
    }
}
