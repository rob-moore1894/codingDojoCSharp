using System;
using System.Collections.Generic; 

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

        

        public static void RemoveDups(List<int> numList){
            //Given a sorted List, return a NEW List that doesn't have any duplicate values
            foreach(int item in numList)
            {
                Console.WriteLine(item);
            }
            for(int i = 0; i < numList.Count; i++)
            {
                for(i = 0; i < numList.Count; i++)
                {
                    if(numList[i] == numList.Count)
                    {
                        Console.WriteLine(numList[i]);
                    }
                    else
                    {
                        if(numList[i] == numList[i+1])
                        {
                            numList.RemoveAt(i);
                        }
                    }

                }
            }
            foreach(int item in numList)
            {
                Console.WriteLine(item);
            }

        }
        
        static void Main(string[] args)
        {
            // BinarySearch(new int[] { 2, 3, 4, 10, 40 }, 11); 
             

        }
    }
}
