using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly MyProjectDbContext context;

        public SqlRestaurantData(MyProjectDbContext context)
        {
            this.context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            context.Restaurants.Add(restaurant);
            context.SaveChanges(); // Will not use Unit of Work due to the size of this app.
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return context.Restaurants.OrderBy(r => r.Name);
        }
    }
}
