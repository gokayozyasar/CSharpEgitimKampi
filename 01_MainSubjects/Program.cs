using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region StringDeğişkenler

            // string 
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Gökay";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri :" + customerName+" "+customerSurname);
            //Console.WriteLine("İletişim :"+customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";


            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri :" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim :" + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");

            #endregion
            
            #region Int Değişkenler

            // int tam sayı türündeki değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friedPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");   
            Console.WriteLine();
            Console.WriteLine("----Hamburger :" +hamburgerPrice +" TL");
            Console.WriteLine("----Pizza :" + pizzaPrice + " TL");
            Console.WriteLine("----Kola :" + cokePrice + " TL");
            Console.WriteLine("----Limonata :" + lemonadePrice + " TL");
            Console.WriteLine("----Kızartma :" + friedPrice + " TL");
            Console.WriteLine("----Su :" + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friedCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalfriedPrice;
            int totalPizzaPrice;
            int totallemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friedCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount *hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;
            totalfriedPrice = friedCount * friedPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;





            Console.WriteLine("------------------------------") ;
            Console.WriteLine("Hamburger Tutarı :" + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı :" + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı :" + totalfriedPrice + " TL");
            Console.WriteLine("Kola Tutarı :" + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı :" + totallemonadePrice + " TL");
            Console.WriteLine("Su Tutarı :" + totalWaterPrice + " TL");
            Console.WriteLine("------------------------------");

            Console.WriteLine();
            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalfriedPrice + totalCokePrice + totallemonadePrice + totalWaterPrice;
            Console.WriteLine("Toplam Ödenecek Tutar :" + totalPrice+" TL");

            #endregion

            Console.Read();

        }
    }
}



//Yazdırma Komutları
