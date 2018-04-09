using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyProject.Models;
using MyProject.Services;
using MyProject.ViewModels;

namespace MyProject.Pages
{
    public class GreetingModel : PageModel
    {
        private readonly IGreeter greeter;
        private readonly IRestaurantData restaurantData;

        public string CurrentGreeting { get; set; }
        public IEnumerable<Restaurant> restaurants { get; set; }

        public GreetingModel(IGreeter greeter, IRestaurantData restaurantData)
        {
            restaurants = new List<Restaurant>();
            this.greeter = greeter;
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {
            this.restaurants = restaurantData.GetAll();
            CurrentGreeting = greeter.GetMessageOfTheDay();
        }
    }
}