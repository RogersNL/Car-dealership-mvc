using Microsoft.AspNetCore.Mvc;

namespace Car.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
            // return new EmptyResult();
        }
    }
}
