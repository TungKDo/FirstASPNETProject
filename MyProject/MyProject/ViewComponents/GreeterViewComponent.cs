using Microsoft.AspNetCore.Mvc;
using MyProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        private readonly IGreeter greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = greeter.GetMessageOfTheDay();
            return View("Default", model);
        }
    }
}
