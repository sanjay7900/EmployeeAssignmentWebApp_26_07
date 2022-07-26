using EmployeeAssignment_26_07_WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAssignment_26_07_WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private WebAppDbContext _context;
        public EmployeeController(WebAppDbContext webAppDbContext)
        {
            _context = webAppDbContext; 

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Data(Employee employee)
        {
            try
            {
                _context.Employee.Add(employee);
                _context.SaveChanges();
                return Content($"Employee Registered Successfully  with {employee.FirstName}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }

            return Content($"OOps, SomeThing Wrong");
        }
        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var employees = _context.Employee.ToList(); 
            var JsonEmployees= JsonConvert.SerializeObject(employees);
            return Content(JsonEmployees);
        }
    }
}
