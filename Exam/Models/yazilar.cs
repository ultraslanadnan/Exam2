using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class yazilar
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Yazi Başlığı")]
        public string baslik { get; set; }

        public string aciklama { get; set; }
 



    }
}
