using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Exam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Exam.Controllers
{
    //[Route("ListeController1")]
    public class ListeController1 : Controller
    {
        private MyDbContext db;
      
        controlUser db2 = new controlUser();
        public ListeController1(MyDbContext _db)
        {
            db = _db;
        }

        //[Route("")]
        //[Route("~/")]
        //[Route("index")]
        public IActionResult Index()
        {
            List<yazilar> listYazi = new List<yazilar>();
          
            listYazi = (from yazi in db.yazilar  select yazi ).ToList();
         
            listYazi.Insert(0, new yazilar {id=0,baslik= "Baslik Seciniz" });

            ViewBag.listofYazilar = listYazi;
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(yazilar yazis, sinavlar sinav, string soru1, string secenek1A, string secenek1B, string secenek1C, string secenek1D,string Cevap1, string soru2, string secenek2A, string secenek2B, string secenek2C, string secenek2D, string Cevap2, string soru3, string secenek3A, string secenek3B, string secenek3C, string secenek3D, string Cevap3, string soru4, string secenek4A, string secenek4B, string secenek4C, string secenek4D, string Cevap4)
        {
            string stringofbaslik="" ;
            string stringofaciklama = "";
          
            if (yazis.id== 0)
            {
                ModelState.AddModelError("","Lütfen Yazi Basligi Secin");
                
            }
            else
            {
               var  yazilarim = await db.yazilar.FirstOrDefaultAsync(m => m.id == yazis.id);
                stringofbaslik = yazilarim.baslik;
                stringofaciklama = yazilarim.aciklama;
                ViewBag.SelectedValue = yazilarim.aciklama;
             
            }
            int SelectValue = yazis.id;
            if (Cevap1 != "0" && Cevap2 != "0" && Cevap3 != "0" && Cevap4 != "0" && yazis.id!=0)
            {
                ViewBag.success = "success";
                sinav.soru1 = soru1;
                sinav.secenekA = secenek1A;
                sinav.secenekB = secenek1B;
                sinav.secenekC = secenek1C;
                sinav.secenekD = secenek1D;
                sinav.Cevap = Cevap1;


                sinav.soru2 = soru2;
                sinav.secenek2A = secenek2A;
                sinav.secenek2B = secenek2B;
                sinav.secenek2C = secenek2C;
                sinav.secenek2D = secenek2D;
                sinav.Cevap2 = Cevap2;

                sinav.soru3 = soru3;
                sinav.secenek3A = secenek3A;
                sinav.secenek3B = secenek3B;
                sinav.secenek3C = secenek3C;
                sinav.secenek3D = secenek3D;
                sinav.Cevap3 = Cevap3;

                sinav.soru4 = soru4;
                sinav.secenek4A = secenek4A;
                sinav.secenek4B = secenek4B;
                sinav.secenek4C = secenek4C;
                sinav.secenek4D = secenek4D;
                sinav.Cevap4 = Cevap4;

                sinav.tarih = DateTime.Now;
                sinav.baslik = stringofbaslik;
                sinav.aciklama = stringofaciklama;
                db.Add(sinav);
                await db.SaveChangesAsync();
            }
            else
            {
             
               


            }






            List<yazilar> listYazi = new List<yazilar>();
            listYazi = (from yazi in db.yazilar select yazi).ToList();
            listYazi.Insert(0, new yazilar { aciklama = "Baslik Seciniz", baslik = "Select" });
            ViewBag.listofYazilar = listYazi;
            return View();
        }
    }
}
