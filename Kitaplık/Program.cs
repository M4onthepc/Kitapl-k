using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;



namespace Kitaplık
{
    internal class Program
    {
        /// <summary>
        /// metod isimleri anlaşılır olsun ingilizce olsun
        /// tüm bu veriler veri tabanından çekilsin
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("İşlemler Menüsü");
            Console.WriteLine();
            Console.WriteLine("1- Fiyat Sorgulama");
            Console.WriteLine("2- Yeni Okur Kaydı");
            Console.WriteLine("3- Günün Kitabı");
            Console.WriteLine("4- Kitap Arşivi");
            Console.WriteLine("5- Yeni Kitap Ekle");
            Console.WriteLine("6- Kitap Satın Al");//form ekranı açılsın kitapların yanına satın al butonu koy dapper ile yap
            Console.WriteLine("7- Kitap Düzenle");//ve çıkan formda kitap isimlerini düzenle
            Console.WriteLine("8- Oyun");
           
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarası ");
            string islem = Console.ReadLine();

            if (islem == "1")
            {
                Kitaplar book = new Kitaplar();
                System.Windows.Forms.Application.Run(book);
            }
            if (islem == "2")
            {
                Kitaplık.CiftSecenekler.NewReaderRegistration();
            }
            if (islem == "3")
            {
               Kitaplık.TekSecenekler.BookOfDay();
            }
            if (islem == "4")
            {
                Kitaplık.CiftSecenekler.BookArchive();
            }
            if (islem == "5")
            {
                AddNewBook book = new AddNewBook();
                System.Windows.Forms.Application.Run(book);
            }
            if (islem == "6")
            {
                BuyNewBook book = new BuyNewBook();
                System.Windows.Forms.Application.Run(book);
            }
            if (islem == "7")
            {
                KitapDuzenle duzenleme=new KitapDuzenle();  
                System.Windows.Forms.Application.Run(duzenleme);
            }
            if (islem == "8")
            {
                Kitaplık.CiftSecenekler.Game();
            }
            Console.Read();
        }

    }
}
