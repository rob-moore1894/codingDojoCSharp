using System; 

namespace Human
{
    class Wizard : Human
    {
        public Wizard(string name): base(name){
            Name = name; 
            Health = 50;
            Intelligence = 25; 
        }

        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        public override int Attack(Human target){
            int damageDealt = this.Intelligence * 5; 
            target.Health = target.Health - damageDealt; 
            this.Health = this.Health + damageDealt;
            Console.WriteLine($"Wizard {this.Name} attacked {target.Name} and reduced {target.Name}'s health by {damageDealt}.\n{this.Name} gained {damageDealt} in health. \n{this.Name} health = {this.Health}\n{target.Name} health = {target.Health}"); 
            return target.Health; 
        }

        // Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
        public int Heal(Human target){
            int healPoints = Intelligence * 10; 
            target.Health += healPoints; 
            Console.WriteLine($"Wizard {Name} healed {target.Name} by {healPoints}\n{target.Name}'s health is now {target.Health}"); 
            return target.Health;
        }
    }
}