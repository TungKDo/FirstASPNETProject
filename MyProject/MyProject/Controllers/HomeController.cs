
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using MyProject.Services;
using MyProject.ViewModels;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData restaurantData;
        private readonly IGreeter greeter;

        public HomeController(IRestaurantData restaurantData,
                                IGreeter greeter)
        {
            this.restaurantData = restaurantData;
            this.greeter = greeter;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = restaurantData.GetAll();
            model.CurrentMessage = greeter.GetMessageOfTheDay();
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = restaurantData.Get(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditModel model)
        {
            if(ModelState.IsValid)
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Name = model.Name;
                newRestaurant.Cuisine = model.Cuisine;

                newRestaurant = restaurantData.Add(newRestaurant);

                return RedirectToAction(nameof(Details), new { id = newRestaurant.Id });
            }
            else
            {
                return View();
            }
            
        }
    }
}
