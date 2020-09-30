using System; 
using System.Collections.Generic; 

namespace HungryNinja
{
    class Ninja{
        //Fields
        private int calorieIntake; 
        public List<Food> FoodHistory; 

        // add a constructor
        public Ninja(){
            calorieIntake = 0;
            FoodHistory = new List<Food>(); 
        }

        public int CalorieIntake{
            get {
                return calorieIntake;
            }
            set {
                calorieIntake = value; 
            }
        }

        // add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
        public bool IsFull(){
            if(CalorieIntake >= 1200 ){
                return true; 
            } else {
                return false; 
            }
        }

        // build out the Eat method that: if the Ninja is NOT full
            // adds calorie value to ninja's total calorieIntake
            // adds the randomly selected Food object to ninja's FoodHistory list
            // writes the Food's Name - and if it is spicy/sweet to the console
        // if the Ninja IS full
            // issues a warning to the console that the ninja is full and cannot eat anymore
        public void Eat(Food item){
            Console.WriteLine($"Calorie intake is: {this.CalorieIntake}"); 
            if(this.IsFull() == false){
                CalorieIntake += item.Calories; 
                FoodHistory.Add(item);
                if(item.IsSpicy == true){ 
                    Console.WriteLine($"Ate {item.Name} and it was spicy"); 
                } else if(item.IsSweet == true) {
                    Console.WriteLine($"Ate {item.Name} and it was sweet");
                } else {
                    Console.WriteLine($"Ate {item.Name}"); 
                }
            } else {
                Console.WriteLine("Ninja is full and cannot eat anymore"); 
            }
            Console.WriteLine($"Calorie intake is now: {this.CalorieIntake}"); 
        }
    }
}