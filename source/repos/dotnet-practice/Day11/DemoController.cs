/*
Browser Request
      ↓
HTTPS Redirection
      ↓
Routing
      ↓
Custom Middleware (Request Started)
      ↓
Controller Action Executes
      ↓
Dependency Injection Creates LogService
      ↓
Controller Uses Service
      ↓
Custom Middleware (Request Finished)
      ↓
Response Sent
*/



using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Services;

namespace MyFirstWebApp.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private readonly ILogService logService;

        public DemoController(ILogService service)
        {
            logService = service;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            logService.Log("DemoController.Index Executed");
            return Content("Demo Index Page");
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            logService.Log("DemoController.About Executed");
            return Content("Demo About Page");
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            logService.Log("DemoController.Contact Executed");
            return Content("Demo Contact Page");
        }
    }
}
