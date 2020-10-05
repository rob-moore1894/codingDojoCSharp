using System; 

namespace HungryNinja
{
    class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get{
                if(calorieIntake >= 1500){
                    return true;
                }
                return false; 
            }
        }
            

        public override void Consume(Buffet foodList)
        {
            while (IsFull == false){
                IConsumable item = foodList.Serve(); 
                if(item.IsSweet == true){
                    // Console.WriteLine($"{item.Name} is sweet! +10 Calories"); 
                    calorieIntake += item.Calories + 10;
                } else if(item.IsSweet == false){
                    calorieIntake += item.Calories;
                }
                ConsumptionHistory.Add(item); 
                item.GetInfo(); 
            } 
            
            Console.WriteLine("Ninja is too full, cannot eat anymore!"); 
        }
    }
}