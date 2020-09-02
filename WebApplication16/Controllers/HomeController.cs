using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContex _applicationDbContex;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContex applicationDbContex)
        {
            _logger = logger;
            _applicationDbContex = applicationDbContex;
        }

        [HttpPost]
        public void Crete(UserView userView)
        {
            var test = _applicationDbContex.Users.ToList();
            _applicationDbContex.Users.Add(new Users{Name = userView.Name, Age = userView.Age});
            _applicationDbContex.SaveChanges();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
