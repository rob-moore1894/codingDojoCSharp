using System;
using System.Collections.Generic; 

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to hold integer values 0 through 9
            int[] numArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (int num in numArray) {
                Console.WriteLine(num);
            }
            
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            foreach (string name in names) {
                Console.WriteLine(name);
            }

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] tf = new bool[10]; 
            for (int i = 0; i < tf.Length; i++){
                if(i % 2 == 0){
                    tf[i] = true;
                } else {
                    tf[i] = false;
                }
            }
            foreach (bool val in tf){
                Console.WriteLine(val);
            }
            
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Stark Raving Hazelnuts");
            flavors.Add("Hulka Hulka Burning Fudge");
            flavors.Add("Netflix & Chilll'd");
            flavors.Add("Boots on the Moooo'n");
            flavors.Add("Chip Happens");
            foreach (string flavor in flavors){
                Console.WriteLine("- " + flavor);
            }

            // Output the length of this list after building it
            Console.WriteLine($"Flavors length: {flavors.Count}");

            // Output the third flavor in the list, then remove this value
            Console.WriteLine($"Third Flavor: {flavors[2]}");
            flavors.RemoveAt(2); 
            Console.WriteLine("Aaaand Removed");

            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine($"Flavors length: {flavors.Count}");

            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> nameFlavor = new Dictionary<string, string>();

            // Add key/value pairs to this dictionary where:
                // each key is a name from your names array
                // each value is a randomly select a flavor from your flavors list.
            Random randFlavor = new Random();

            for (int i = 0; i < names.Length; i++){
                int idx = randFlavor.Next(flavors.Count);
                nameFlavor.Add(names[i], flavors[idx]);
            }

            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach(KeyValuePair<string, string> entry in nameFlavor){
                Console.WriteLine(entry.Key + " = " + entry.Value); 
            }
        }
    }
}
