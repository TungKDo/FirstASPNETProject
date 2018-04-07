using MyProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            { new Restaurant { Id = 1, Name = "Ivan"},
            new Restaurant { Id = 2, Name = "Gosho"},
            new Restaurant { Id = 3, Name = "Pesho"}
            };
        }
        List<Restaurant> restaurants;

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }
    }
}
