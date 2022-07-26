using Microsoft.AspNetCore.Mvc;

namespace EmployeeAssignment_26_07_WebApp.Controllers
{
    public class RazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
