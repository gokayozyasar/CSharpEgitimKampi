using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            // ()
            // Geriye değer döndürmeyen metotlar
            // Customer --> Listele,Ekle,Sil,Güncelle
            // Void

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Mehmet Yıldız");
            //    Console.WriteLine("Murat Yıldız");
            //    Console.WriteLine("Hakan Yıldız");
            //}

            //void sum()
            //{
            //    int x = 1; int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();








            #endregion

            #region Geriye değer döndürmeyen parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: "+name+ " "+ surName);
            //}

            //CustomerCard("Gökay","Yıldız");



            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void sum (int number1, int number2, int number3)
            //{
            //    int result = number1 + number2+number3;
            //    Console.WriteLine(result);
            //}

            //sum(5,6,7);



            #endregion

            #region Geriye değer döndüren metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();

            // string studentCard()
            // {
            //     string name = "Ali";
            //     string surname = "Kaya";

            //     return name + " " + surname;

            // }

            //Console.WriteLine(studentCard());



            #endregion

            #region Geriye değer döndüren  string parametreli metotlar

            //string countyCard(string countryName, string capital, string flagColor)

            //{
            //    string cardInfo = "Ülke : " + countryName + "- Başkent : " + capital + "- Bayrak Rengi : " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz : ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz :");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz : ");
            //z = Console.ReadLine();

            //Console.Write(countyCard(x, y, z));



            #endregion

            #region Geriye değer döndüren  int  parametreli metotlar

           //int sum (int number1, int number2)
           // {
           //     int result = number1 + number2;
           //     return result;
           // }
           // Console.WriteLine(sum(45, 98));
           // Console.WriteLine(sum(45, 25));
           // Console.WriteLine(sum(44, 36));
           // Console.WriteLine(sum(14, 20));


            #endregion

            #region Örnek
            string exampleResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50) 
                {
                    return student + " isimli öğrenci sınavı geçti "+ " Ortalama : "+ result;
                }
                else
                {
                    return student + " isimli öğrenci sınavda başarısız oldu " + " Ortalama : " + result;
                }                
            }

            Console.WriteLine(exampleResult("Gökay", 10, 20, 70));
            Console.WriteLine(exampleResult("Gözde", 70, 95, 75));

            #endregion





            Console.Read();
        }
    }
}
