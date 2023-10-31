using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using mvc.Repository.IRepository;
using mvc.Repository.MockRepository;
using mvc.ViewModels;
using System.Diagnostics;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(ILogger<HomeController> logger,
            IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
        }

        public ViewResult Index()
        {
            var model = _employeeRepository.GetAll();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult Details(int id)
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel()
            {
                Employee = _employeeRepository.Get(id),
                PageTitle = "Employee Details" 
            };
           
            return View(employeeViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee = _employeeRepository.Add(employee);
                //return RedirectToAction("details", new { id = employee.Id });
                return View();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}