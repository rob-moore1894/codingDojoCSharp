using System; 

namespace Human
{
    class Samurai : Human
    {
        public Samurai(string name): base(name){
            Name = name;
            Health = 200; 
        }

        // Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
        public override int Attack(Human target){
            base.Attack(target); 
            if(target.Health < 50){
                target.Health = 0;
                Console.WriteLine($"{target.Name} was killed by Samurai {Name}"); 
            }
            return target.Health; 
        }

        public int Meditate(){
            Health = 200; 
            Console.WriteLine($"{Name} meditated and returned to {Health} health"); 
            return Health; 
        }
    }
}