using System; 

namespace HungryNinja
{
    class SpiceHound : Ninja
    {
        public override bool IsFull 
        {
            get 
            {
                if(calorieIntake >= 1200){
                    return true; 
                }
                return false; 
            }
        }

        public override void Consume(Buffet foodList)
        {
            while (IsFull == false){
                IConsumable item = foodList.Serve(); 
                if(item.IsSpicy == true){
                    // Console.WriteLine($"{item.Name} is spicy! -5 Calories to you!");
                    calorieIntake += item.Calories - 5; 
                } else if(item.IsSpicy == false){
                    calorieIntake += item.Calories; 
                }
                ConsumptionHistory.Add(item);
                item.GetInfo();
            } 
            
            Console.WriteLine("Ninja is too full, cannot eat anymore!");
        }
    }
}