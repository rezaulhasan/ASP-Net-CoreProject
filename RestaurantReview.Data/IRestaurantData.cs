using RestaurantReviewApp.Core;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;

namespace RestaurantReviewApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurants> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurants> restaurants; 

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurants>()
            {
                new Restaurants {Id = 1, Name= "White Heaven", Location= "Wiley Park", Cuisine = CuisineType.Mexican },
                new Restaurants {Id = 2, Name= "Blazin Grillz", Location= "Lakemba", Cuisine = CuisineType.Italian },
                new Restaurants {Id = 3, Name= "Hungry Jacks", Location= "Rockdale", Cuisine = CuisineType.Indian},
                new Restaurants {Id = 4, Name= "Bongo Bazar", Location= "Regents Park", Cuisine = CuisineType.Chinease },
            }; 
        }

        public IEnumerable<Restaurants> GetAll()
        {
             return from r in restaurants
                    orderby r.Name
                    select r;
        }
    }
}
