using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class sinavlar
    {
        [Key]
        [Display(Name = "Sınav ID")]
        public int sinavid { get; set; }
        public string soru1 { get; set; }
        public string secenekA { get; set; }
        public string secenekB { get; set; }
        public string secenekC { get; set; }
        public string secenekD { get; set; }
        public string Cevap { get; set; }


        public string soru2 { get; set; }
        public string secenek2A { get; set; }
        public string secenek2B { get; set; }
        public string secenek2C { get; set; }
        public string secenek2D { get; set; }
        public string Cevap2 { get; set; }


        public string soru3 { get; set; }
        public string secenek3A { get; set; }
        public string secenek3B { get; set; }
        public string secenek3C { get; set; }
        public string secenek3D { get; set; }
        public string Cevap3 { get; set; }


        public string soru4 { get; set; }
        public string secenek4A { get; set; }
        public string secenek4B { get; set; }
        public string secenek4C { get; set; }
        public string secenek4D { get; set; }
        public string Cevap4 { get; set; }
        [Display(Name ="Başlık")]
        public string baslik { get; set; }
        [Display(Name = "Tarih")]
        public DateTime tarih { get; set; }
        public string aciklama { get; set; }

    }
}
