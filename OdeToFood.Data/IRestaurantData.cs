using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Sam's Pizzaria", Location = "Stockwell", Cuisine = CuisineType.Italian},
                new Restaurant{Id = 2, Name = "Hector's Mexican Fiesta", Location = "Waterloo", Cuisine = CuisineType.Mexican},
                new Restaurant{Id = 3, Name = "Javid's Indian Palace", Location = "Surbiton", Cuisine = CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
