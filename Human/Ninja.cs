using System; 

namespace Human
{
    class Ninja : Human
    {
        public Ninja(string name): base(name){
            Name = name; 
            Dexterity = 175; 
        }

        // Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
        public override int Attack(Human target){
            Random chanceDamage = new Random();
            int damageDealt = this.Dexterity * 5;
            Console.WriteLine($"Ninja {this.Name} attacked {target.Name} and reduced health by {damageDealt}"); 
            if (chanceDamage.Next(100) < 20){
                Console.WriteLine("+10 Additional Damage dealt");
                target.Health = target.Health - (damageDealt + 10);
            } else {
                Console.WriteLine("No Additional Damage Dealt");
                target.Health = target.Health - damageDealt; 
            }  
            Console.WriteLine($"{this.Name} health = {this.Health}\n{target.Name} health = {target.Health}"); 
            return target.Health;           
        }

        public int Steal(Human target){
            if (target.Health > 5){
                target.Health -= 5;
                Health += 5; 
                Console.WriteLine($"Ninja {Name} stole 5 Health from {target.Name}\n{Name} health = {Health}\n{target.Name} health = {target.Health}");
            } else {
                Console.WriteLine($"Ninja {Name} tried to steal health from {target.Name} but there was not enough health to steal"); 
            }
            return Health; 
        }
    }
}