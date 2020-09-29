using System;

namespace Human
{
    class Program
    {
        
        static void Main(string[] args){
            Human rob = new Human("Rob");
            Console.WriteLine($"Name = {rob.Name}\nStrength = {rob.Strength}\nIntelligence = {rob.Intelligence}\nDexterity = {rob.Dexterity}\nHealth = {rob.Health}"); 

            Console.WriteLine("====================================");
            Human kenny = new Human("Kenny", 5, 7, 8, 100); 
            Console.WriteLine($"Name = {kenny.Name}\nStrength = {kenny.Strength}\nIntelligence = {kenny.Intelligence}\nDexterity = {kenny.Dexterity}\nHealth = {kenny.Health}");

            rob.Attack(kenny); 
        }
    }
}
