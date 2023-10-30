﻿using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using mvc.Repository.IRepository;
using mvc.Repository.MockRepository;
using mvc.ViewModels;
using System.Diagnostics;

namespace mvc.Controllers
{
    //[Route("Home")]
    [Route("[controller]/[action]")]
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

        //[Route("")]        
        //[Route("index")]
        //[Route("[action]")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("{id}")]
        public ViewResult Details(int? id)
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details" 
            };
           
            return View(employeeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}