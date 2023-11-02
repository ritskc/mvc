using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger = logger;
        }
        [Route("Error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();   
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, page could not be found";
                    this.logger.LogWarning($"The path {statusCodeResult.OriginalPath} threw an exception");
                    break;
            }
            return View("NotFound");
        }

        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error(int statusCode)
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            this.logger.LogWarning($"The path {exceptionDetails.Path} threw an exception");
            ViewBag.ExceptionPath = exceptionDetails.Path;
            ViewBag.ErrorMessage = exceptionDetails.Error.Message;
            ViewBag.StackTrace = exceptionDetails.Error.StackTrace;

            return View("NotFound");
        }
    }
}
