using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;

namespace AllForOne.Services
{
    public class RestaurantPickerService
    {
        public List<String> FastFoodRestaurant = new List<string>(new string[]
        {
                "Burger King",
                "TacoBell",
                "McDonalds",
                "Jack in the box",
                "Carl's Jr",
                "Wendy's",
                "Sonics",
                "Chick-fil-A",
                "KFC",
                "Popeyes",
           
        });

        public List<String> FineRestaurant = new List<String>(new string[]
        {
            "Cheesecake Factory",
            "Rooftop",
            "Popoca Oakland",
            "Bella Siena",
            "Benu",
            "Pappo",
            "Elia",
            "Ambrose Butchery",
            "Lazy Bear",
            "Birdsong",
        });


        public List<String> AllRestaurants = new List<String>(new string[]
        {
            "Cheesecake Factory",
            "Rooftop",
            "Popoca Oakland",
            "Bella Siena",
            "Benu",
            "Pappo",
            "Elia",
            "Ambrose Butchery",
            "Lazy Bear",
            "Birdsong",
            "Burger King",
            "TacoBell",
            "McDonalds",
            "Jack in the box",
            "Carl's Jr",
            "Wendy's",
            "Sonics",
            "Chick-fil-A",
            "KFC",
            "Popeyes",
        });
        

        Random r = new Random();

        public string RandomRestaurantPicker()
        {

        int index = r.Next(AllRestaurants.Count);

        return AllRestaurants[index];
        
        }

        public string RandomFastFood()
        {
            int index = r.Next(FastFoodRestaurant.Count);
            return FastFoodRestaurant[index];
        }

        public string RandomFineDining()
        {
            int index = r.Next(FineRestaurant.Count);
            return FineRestaurant[index];
        }

    }
}