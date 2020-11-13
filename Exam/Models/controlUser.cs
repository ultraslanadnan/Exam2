using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class controlUser
    {

      
        public List<string> icerikofyazilar(yazilar iceriks)
        {
            List<string> icerikler = new List<string>();
            icerikler.Add(iceriks.aciklama);
            return icerikler.ToList();
        }
        public int CheckUserLogin(user users)
        {
            if(users.kullanici=="adnan" && users.sifre == "adnan")
            {
                return 1;
            }
            else
            
            {
                if (users.kullanici==null || users.sifre==null)
                {
                    return 2;
                }
                return 0;
            }
            
        }
        //public int getYaziler()
        //{
        //    string cs = "Data Source=:memory:";
        //    using var con = new SqliteConnection(cs);
        //    con.Open();

        //    using var cmd = new SqliteCommand("select * from yazilar", con);
           


        //}
    }
}
