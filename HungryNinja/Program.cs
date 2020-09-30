using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet ayce = new Buffet(); 
            Ninja alfie = new Ninja();

            while(alfie.IsFull() == false){
                alfie.Eat(ayce.Serve());
                Console.WriteLine("================================");
            } 

            foreach(Food item in alfie.FoodHistory){
                Console.WriteLine(item.Name); 
            } 
            
        }
    }
}
