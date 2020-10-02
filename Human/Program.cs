using System;

namespace Human
{
    class Program
    {
        
        static void Main(string[] args){
            Human alfie = new Human("Alfie Peters");
            alfie.Display(); 

            Console.WriteLine("====================================");
            Human kenny = new Human("Kenny Omega", 5, 7, 8, 100); 
            kenny.Display();

            alfie.Attack(kenny);
            Console.WriteLine("====================================");

            kenny.Attack(alfie);
            Console.WriteLine("====================================");

            Ninja tozawa = new Ninja("Akira Tozawa");
            tozawa.Display();
            Console.WriteLine("====================================");        

            Wizard merlin = new Wizard("Merlin"); 
            merlin.Display();
            Console.WriteLine("====================================");

            Samurai elsam = new Samurai("El Samurai"); 
            elsam.Display();
            Console.WriteLine("====================================");

            merlin.Attack(elsam); 
            Console.WriteLine("====================================");

            tozawa.Attack(alfie);
            Console.WriteLine("====================================");

            elsam.Attack(kenny); 
            Console.WriteLine("====================================");

            merlin.Heal(alfie);
            Console.WriteLine("===================================="); 

            elsam.Meditate();
            Console.WriteLine("====================================");

            tozawa.Steal(elsam);
            Console.WriteLine("====================================");

            tozawa.Steal(alfie);
            Console.WriteLine("====================================");
        }
    }
}
