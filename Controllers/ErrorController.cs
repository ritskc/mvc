using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, page could not be found";
                    break;
            }
            return View("NotFound");
        }
    }
}
