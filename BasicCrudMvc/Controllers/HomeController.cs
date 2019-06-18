using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BasicCrudMvc.core.Contracts;
using BasicCrudMvc.core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using BasicCrudMvc.Models;

namespace BasicCrudMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;

        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public IActionResult Index()
        {
            var viewModel = new HomeViewModel()
            {
                Message = "Getting all the lists", 
                Users = _userRepository.getAllUsers().ToList()
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}