using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region İf-Else

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şİfre Doğru");
            //}else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //string capital, country;
            //Console.Write("Lütfen Başkenti Giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Lütfen Ülkeyi Giriniz: ");
            //country= Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı");
            //}

            //int number;
            //Console.Write("Lütfen Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number == 5)
            //{
            //    Console.Write("Doğru");
            //}
            //else
            //{
            //    Console.Write("Yanlış");
            //}

            //int exam1, exam2, exam3, avarge;
            //string result;
            //Console.Write("Exam1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Exam2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Exam3: ");
            //exam3 = int.Parse(Console.ReadLine());
            //avarge = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Ortalama: " + avarge);

            //if(avarge>0 & avarge <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (avarge > 50 & avarge <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (avarge > 70 & avarge <= 840)
            //{
            //    result = "sonuç iyi";
            //}
            //if (avarge > 0)
            //{
            //    result = "sonuç mükemmel";
            //}
            //else{
            //    Console.Write("Hatalı");
            //}
            //Console.Write("Lütfen kullanıcı giriniz: ");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.Write("kabul edilmez");
            //}
            //else
            //{
            //    Console.Write("kabul edilir");
            //}


            //Console.Read();



            #endregion
            #region Mod
            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);
            //Console.Write("Lütfen sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if(number % 2 == 0)
            //{
            //    Console.Write("Sayı Çift sayıdır. ");
            //}
            //else
            //{
            //    Console.Write("Sayı tek sayıdır. ");

            //char team;
            //Console.Write("Lütfen takım sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            #endregion
            #region Örnek Proje Uygulaması
            //Console.WriteLine("******* C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekeler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını Görmek İstediğiniz Menüyü Seçin");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekeler----------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Balık");
            //    Console.WriteLine("3-Pirzola");
            //    Console.WriteLine("4-Karnıyarık");
            //    Console.WriteLine("5-Taze Fasulye");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Çorbalar------------");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Yayla");
            //    Console.WriteLine("4-Tavuk Suyu");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar--------");
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Pepporoni");
            //    Console.WriteLine("3-Mantarlı");
            //    Console.WriteLine("4-Sucuklu");
            //    Console.WriteLine("5-Zeytinli");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------İçecekler--------");
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Vişne");
            //    Console.WriteLine("4-Şeftali");
            //    Console.WriteLine("5-Kayısı");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar--------");
            //    Console.WriteLine("1-Tiramisu");
            //    Console.WriteLine("2-Ekler");
            //    Console.WriteLine("3-Baklava");
            //    Console.WriteLine("4-Sütlaç");
            //    Console.WriteLine("5-Helva");
            //}


            #endregion
            #region Switch Case

            //Console.Write("Lütfen Ay Girişini Yapınız: ");
            //int montNumber = int.Parse(Console.ReadLine());

            //switch (montNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;



            //}


            #endregion
            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istedeğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}

            #endregion

            Console.ReadLine();



            
        }

    }
}
