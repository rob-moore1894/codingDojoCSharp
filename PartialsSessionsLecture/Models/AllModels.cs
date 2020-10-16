using System; 
using System.Collections.Generic;

namespace PartialsSessionsLecture
{
    public class AllModels
    {
        public List<Donut> AllDonuts {get; set;}
        public List<Drink> AllDrinks {get; set;}

        public AllModels()
        {
            AllDonuts = new List<Donut>();
            AllDrinks = new List<Drink>(); 
        }
    }
}