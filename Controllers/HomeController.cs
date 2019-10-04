using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormsPractice.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormsPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculatorFacade _calculatorFacade;

        public HomeController(ICalculatorFacade calculatorFacade)
        {
            _calculatorFacade = calculatorFacade;
        }
        public IActionResult Index()
        {
            var viewModel = new PersonalViewForm();
            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Calculator(CalculatorNumberForm calculator)
        {
            var model = _calculatorFacade.GettingModel(calculator);
            return View(model);
        }

        public IActionResult Contact(PersonalViewForm personalInfo)
        {
            ViewData["Message"] = "Your contact page.";

            return View(personalInfo);
        }
       
        public IActionResult Privacy(IndexViewModel model)
        {


            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
