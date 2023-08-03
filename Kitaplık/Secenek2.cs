using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace Kitaplık
{
    public static class CiftSecenekler
    {
        public static void NewReaderRegistration()
        {
            
            Console.WriteLine();
            Console.WriteLine("İşlem: Yeni Okur Kaydı\n*****  Yeni Okur Kaydı  *****");
            string name, surname, school;
            Console.Write("Adınız: ");
            name = Console.ReadLine();
            Console.Write("Soyadınız: ");
            surname = Console.ReadLine();
            Console.Write("Okuduğunuz Okul: ");
            school = Console.ReadLine();

            StreamWriter sr = new StreamWriter("C:\\Users\\M4KIF\\Desktop\\Kullanıcı.txt");
            sr.WriteLine( name);
            sr.WriteLine( surname);
            sr.WriteLine( school);
            sr.Close();

            Console.WriteLine(".................... ");
            FileStream ac = new FileStream("C:\\Users\\M4KIF\\Desktop\\Kullanıcı.txt",FileMode.Open,FileAccess.Read);
            StreamReader goster = new StreamReader(ac);

            string dosya= goster.ReadLine();
            while (dosya != null)
            {
                Console.WriteLine(dosya);
                dosya=goster.ReadLine();
            }
            goster.Close(); 
            sr.Close();

        }

        public static void BookArchive()
        {
            Console.WriteLine();
            Console.WriteLine("İşlem: Kitap Arşivi");
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();

            FileStream file = new FileStream("C:\\Users\\M4KIF\\Desktop\\Yeni Metin Belgesi (2).txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);

            string metin = sr.ReadLine();
            while (metin != null)
            {
                Console.WriteLine(metin);
                metin = sr.ReadLine();
            }
            sr.Close();
            file.Close();
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }

        public static void BuyNewBook()
        {
            int id;
            Console.Write("id girin:");
            id = Convert.ToInt16(Console.ReadLine());
            var baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-458LKBF;Initial Catalog=Kitaplık;Integrated Security=True";
            baglanti.Execute("select KitapFiyat from Kitap where id=@id", new{id});


            Kitaplar book = new Kitaplar();
            System.Windows.Forms.Application.Run(book);


            //Console.WriteLine();
            //Console.WriteLine("İşlem: Yeni Kitap Satın Al");
            //Console.WriteLine();
            //int toplamFiyat = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    Console.Write("Alacağınız kitabın numarasını yazın: ");
            //    string secim = Console.ReadLine();
            //    if (secim == "1")
            //    {
            //        toplamFiyat = toplamFiyat + 13;
            //    }
            //    else if (secim == "2")
            //    {
            //        toplamFiyat = toplamFiyat + 11;
            //    }
            //    else if (secim == "3")
            //    {
            //        toplamFiyat = toplamFiyat + 14;
            //    }
            //    else if (secim == "4")
            //    {
            //        toplamFiyat = toplamFiyat + 15;
            //    }
            //    else if (secim == "5")
            //    {
            //        toplamFiyat = toplamFiyat + 10;
            //    }

            //    else if (secim == "6")
            //    {
            //        toplamFiyat = toplamFiyat + 11;
            //    }
            //    else if (secim == "7")
            //    {
            //        toplamFiyat = toplamFiyat + 18;
            //    }
            //    else if (secim == "8")
            //    {
            //        toplamFiyat = toplamFiyat + 17;
            //    }
            //    else if (secim == "9")
            //    {
            //        toplamFiyat = toplamFiyat + 13;
            //    }
            //    else if (secim == "10")
            //    {
            //        toplamFiyat = toplamFiyat + 12;
            //    }
            //    else if (secim == "11")
            //    {
            //        toplamFiyat = toplamFiyat + 16;
            //    }
            //    else if (secim == "12")
            //    {
            //        toplamFiyat = toplamFiyat + 17;
            //    }
            //    else
            //        Console.Write("Böyle bir kitap numarası yok");
            //    Console.WriteLine();
            //    Console.Write("Başka bir kitap almak ister misiniz ");
            //    string cikis = Console.ReadLine();
            //    if (cikis == "hayır" || cikis == "yok" || cikis == "h") break;
            //}
            //Console.Write("Toplam tutar : " + toplamFiyat);
        }
        public static void Game()
        {
            Console.WriteLine();
            Console.WriteLine("İşlem: Oyun");
            Console.WriteLine();
            int tahmin =0;
            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            while (sayi != tahmin)
            {
                Console.Write("Sayı Girin : ");
                tahmin = Convert.ToInt16(Console.ReadLine());
                if (tahmin > sayi)
                {
                    Console.Write("Daha Küçük ");
                }
                if (tahmin < sayi)
                {
                    Console.Write("Daha Büyük ");
                }
                if (tahmin == sayi)
                {
                    Console.Write("Tebrikler BİLDİNİZ "); 
                }
            }
        }
    }

  

}
