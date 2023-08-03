using Dapper;
using Kitaplık.Models;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Kitaplık
{
    public static class TekSecenekler
    {
        public static void BookOfDay()
        {
            Console.WriteLine();
            Console.WriteLine("İşlem: Günün Kitabı");
            Console.WriteLine();
            Console.WriteLine("******************************************");

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-458LKBF;Initial Catalog=Kitaplık;Integrated Security=True");
            var result = baglanti.Query<Book>("select*from Kitap", baglanti).ToList();


            Random rastgele = new Random();
            int sayi = rastgele.Next(0, result.Count());
            Console.WriteLine(result[sayi].KitapAd);
            Console.WriteLine("******************************************");
            Console.ReadKey();
        }
       
    }
}

