using System;
using System.Collections.Generic; 

namespace HungryNinja{
    class Buffet{
        public List<Food> Menu; 

        public Buffet(){
            Menu = new List<Food>()
            {
                new Food("Good Morning Breakfast", 300, false, false),
                new Food("Crossroads on corn with tomatillo sauce", 439, true, false),
                new Food("Sushiburrito", 200, true, false),
                new Food("Brisket", 160, false, false), 
                new Food("Buffalo Wings", 300, true, false),
                new Food("Double Milk Chocolate and Peanut Butter Cookies", 500, false, true),
                new Food("General Tso's Chicken", 1000, true, false),
            };            
        }

        // build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object
        public Food Serve(){
            Random randFood = new Random();
            int idx = randFood.Next(Menu.Count); 
            Console.WriteLine(Menu[idx]);
            return Menu[idx]; 
        } 
    }
}