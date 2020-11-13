using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exam.Models;

namespace Exam.Controllers
{
    public class HomeController : Controller
    {
       
        controlUser dbop = new controlUser();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([Bind] user users)
        {
            int res = dbop.CheckUserLogin(users);
            if (res == 1)
            {

                //TempData["msg"] = "Hata yok";

               
                return RedirectToAction("index", "ListeController1");
            }
            else
            {
                if (res == 2)
                {
                    TempData["msg"] = "Bos alanlari doldurun";
                    return View();
                }
                else
                {
                    TempData["msg"] = "Sifreniz ya da kullanici adiniz hatali";
                    return View();
                }
              
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }
     
 
   
      
    
     
        public IActionResult liste()
        {
           

                return View();
        



        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
