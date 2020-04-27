using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoronaVirus.Models;
using Microsoft.AspNetCore.Mvc;

namespace KoronaVirus.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Viruspage()
        {
            return View();
        }


        public IActionResult Viruspage2()
        {
            return View();
        }
        public IActionResult Viruspage3()
        {
            return View();
        }
        public IActionResult VirusPozitif(Test test)
        {

            return View();
        }
        public IActionResult VirusNegatif(Test test)
        {

            return View();
        }
        [HttpGet]
        public IActionResult TesteBasla()
        {

            return View();
        }
         [HttpPost]
        public IActionResult TesteBasla(Test test)
        {

            return RedirectToAction("VirusNegatif","Page");
        }
    }
    }
    
