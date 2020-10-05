using System; 
using System.Collections.Generic; 

namespace HungryNinja
{
    abstract class Ninja{
        //Fields
        protected int calorieIntake; 
        public List<IConsumable> ConsumptionHistory; 

        // add a constructor
        public Ninja(){
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>(); 
        }

        public int CalorieIntake{
            get {
                return calorieIntake;
            }
            set {
                calorieIntake = value; 
            }
        }

        public abstract bool IsFull {get;}
        public abstract void Consume (Buffet foodList); 
    }
}