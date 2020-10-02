using System; 

namespace Human{

class Human {
            public string Name; 
            public int Strength; 
            public int Intelligence; 
            public int Dexterity;
            private int health; 

            // add a public "getter" property to access health
            public int Health{
                get {
                    return health; 
                }
                set {
                    health = value; 
                }
            }

            // Add a constructor that takes a value to set Name, and set the remaining fields to default values
            public Human(string name){
                Name = name; 
                Strength = 3; 
                Intelligence = 3; 
                Dexterity = 3; 
                health = 100; 
            }

            // Add a constructor to assign custom values to all fields
            public Human(string name, int strength, int intelligence, int dexterity, int health){
                Name = name; 
                Strength = strength;
                Intelligence = intelligence; 
                Dexterity = dexterity; 
                Health = health; 
            }

            // Build Attack method
            // Reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
            public virtual int Attack(Human target){
                int damageDealt = this.Strength * 5; 
                target.health = target.health - damageDealt;
                Console.WriteLine($"{this.Name} attacked {target.Name} and reduced {target.Name}'s health by {damageDealt}.\n{this.Name} health = {this.Health}\n{target.Name} health = {target.Health}");  
                return target.Health; 
            }

            public void Display(){
                Console.WriteLine($"Name = {this.Name}\nStrength = {this.Strength}\nIntelligence = {this.Intelligence}\nDexterity = {this.Dexterity}\nHealth = {this.Health}"
                );
            }
        }
}