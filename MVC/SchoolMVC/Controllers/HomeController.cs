using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolMVC.Models;
using SchoolMVC.GraphQL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async IActionResult Index()
        {
            var teachers = await School.AllTeachers.ExecuteAsync();

            return View("Index", new HomeVM
            {
                Teachers = teachers
            });
        }
    }
}
