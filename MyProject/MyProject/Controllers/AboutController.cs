using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            
            return "1+12412+4123+4123";
        }
        [Route("address")]
        public string Address()
        {
            return "USA";
        }
    }
}
