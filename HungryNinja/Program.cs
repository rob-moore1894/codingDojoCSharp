using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet ayce = new Buffet(); 
            SweetTooth alfie = new SweetTooth();
            SpiceHound gomez = new SpiceHound();
            
            alfie.Consume(ayce);
            foreach(IConsumable item in alfie.ConsumptionHistory){
                Console.WriteLine(item.Name); 
            } 
            Console.WriteLine($"This ninja had {alfie.ConsumptionHistory.Count} items");
            Console.WriteLine("========================================");

            gomez.Consume(ayce);
            foreach(IConsumable item in gomez.ConsumptionHistory){
                Console.WriteLine(item.Name); 
            }
            Console.WriteLine($"This ninja had {gomez.ConsumptionHistory.Count} items");
            Console.WriteLine("========================================"); 

            if(alfie.ConsumptionHistory.Count > gomez.ConsumptionHistory.Count){
                Console.WriteLine("Alfie had more items!"); 
            } else if (alfie.ConsumptionHistory.Count < gomez.ConsumptionHistory.Count){
                Console.WriteLine("Gomez had more items!");
            } else {
                Console.WriteLine("Both ninjas had the same items");
            }         
        }
    }
}
