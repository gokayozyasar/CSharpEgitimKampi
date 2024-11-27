using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  İf Else
            //Console.Write("Lütfen Şifreyi Giriniz :");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifreniz Yanlış");
            //}

            //Console.Read();

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");

            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");

            //}


            //int number;
            //Console.Write("Sayıyı Giriniz :");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result="Hata";

            //Console.Write("Sınav 1:");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2:");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3:");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması :" + avarage);

            //if (avarage > 0 & avarage <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "Sonuç Orta";s

            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (avarage > 84)
            //{
            //    result = "Sonuç Çokiyi";
            //}
            //Console.Write(result);


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city =Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //    Console.WriteLine("Şehir Mevcuttur");
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değildir.");
            //}

            //Console.Write("Lütfen Kullanıcı adını giriniz :");
            //string username = Console.ReadLine();
            //if (username != "admin") 
            //    {
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz..");
            //}
            //Console.Read();

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.Sayıyı Giriniz :");
            //int number1 =int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı giriniz :");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. Sayının 2.Sayı'ya bölümünden kalan : "+result); 

            //Console.Write("Lütfen Sayıyı Giriniz :");
            //int number =int.Parse(Console.ReadLine());
            //if (number % 2==0)
            //{
            //    Console.Write("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.Write("Trabzonspor");
            //}

            #endregion

            #region Örnek Proje Uygulaması

//            Console.WriteLine("****** C # Eğitim Kampı Restoran ****** ");
//            Console.WriteLine();
//            Console.WriteLine("------------------------------");
//            Console.WriteLine("1 - Ana Yemekler :");
//            Console.WriteLine("2 - Çorbalar :");
//            Console.WriteLine("3 - Pizzalar :");
//            Console.WriteLine("4 - İçecekler :");
//            Console.WriteLine("5 - Tatlılar :");
//            Console.WriteLine("------------------------------");
//            Console.WriteLine();

//            string menuItem;
//            Console.Write("Detayını Görmek İstediğiniz Menüyü Seçiniz :");
//            menuItem = Console.ReadLine();

//            if (menuItem == "1")
//            {
//                Console.WriteLine();
//                Console.WriteLine("-------------Ana Yemekler-------------");
//                Console.WriteLine();
//                Console.WriteLine("1- Köri Soslu Tavuk :");
//                Console.WriteLine("2- Kızartma Tabağı :");
//                Console.WriteLine("3- Fasulye Pilav :");
//                Console.WriteLine("4- Fırında Somon :");
//                Console.WriteLine("5- Patlıcan Musakka :");
//                Console.WriteLine("-------------Ana Yemekler-------------");

//                Console.WriteLine();
//            }
//            if (menuItem == "2")
//            {
//                Console.WriteLine();
//                Console.WriteLine("-------------Çorbalar-------------");
//                Console.WriteLine();
//                Console.WriteLine("1- Mercimek Çorbası :");
//                Console.WriteLine("2- Ezogelin Çorba :");
//                Console.WriteLine("-------------Çorbalar-------------");

//                Console.WriteLine();
//            }
//            if (menuItem == "3")
//            {
//                Console.WriteLine();
//                Console.WriteLine("-------------Pizzalar-------------");
//                Console.WriteLine();
//                Console.WriteLine("1- Akdeniz Pizza :");
//                Console.WriteLine("2- Margarita:");
//                Console.WriteLine("3- Tavuklu Pizza:");//Hocam Tavuklu pizzamı olur :)
//                Console.WriteLine("-------------Pizzalar-------------");

//                Console.WriteLine();
//            }
//            if (menuItem == "4")
//            {
//                Console.WriteLine();
//                Console.WriteLine("-------------İçecekler-------------");
//                Console.WriteLine();
//                Console.WriteLine("1- Kola :");
//                Console.WriteLine("2- Ayran :");
//                Console.WriteLine("3- Su :");
//                Console.WriteLine("-------------İçecekler-------------");

//                Console.WriteLine();
//            }
//            if (menuItem == "5")
//            {
//                Console.WriteLine();
//                Console.WriteLine("-------------Tatlılar-------------");
//                Console.WriteLine();
//                Console.WriteLine("1- Triliçe :");
//                Console.WriteLine("2- Kazandibi :");
//                Console.WriteLine("3- Sütlaç :");
//                Console.WriteLine("-------------Tatlılar-------------");

//                Console.WriteLine();
//                Console.Read();
//            }
//;



            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız :");
            //int monthNumber =int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak");break;
            //    case 2:Console.Write("Şubat");break;
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
            //    default:Console.Write("Hatalı Veri Girişi Yaptınız Kontrol Ediniz!!");break;


            //}




            #endregion

            #region Switch Case ile Hesap Makinası

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz :");
            //number1 =int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz :");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak istediğiniz işlemi giriniz :");
            //symbol =char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.Write(" Toplam: "+result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.Write(" Fark : " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.Write(" Çarpım : " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.Write(" Bölüm : " + result);
            //        break;
            //}




            #endregion


            Console.Read();

        }
    }
}
