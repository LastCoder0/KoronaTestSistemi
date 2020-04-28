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
        public IActionResult VirusPozitif()
        {
           ViewBag.ad= TempData["Ad"];

            return View();
        }
        public IActionResult VirusNegatif()
        {
            ViewBag.ad = TempData["Ad"];

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
            TempData["Ad"] = test.Ad; ;

          

            if (test.UcuncuSoru==1) //Ateş kontrolü
            {
                if(test.DorduncuSoru==1)
                {
                    if(test.BesinciSoru==1)
                    {
                        if (test.AltinciSoru == 1)
                        {
                            return RedirectToAction("VirusPozitif", "Page");
                        }
                    }

                }

            }
          
            
                return RedirectToAction("VirusNegatif", "Page");
            
         
        }
    }
    }
    
