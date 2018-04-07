
using Microsoft.AspNetCore.Mvc;
using MyProject.Model;
using MyProject.Services;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        public IActionResult Index()
        {
            var model = restaurantData.GetAll();
            return View(model);
        }
    }
}
