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
            #region Yazdirma Komutlari
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Corbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soguk Baslangiclar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("6-Icecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Degiskenler

            //String Degiskenler
            //Degisken_turu degisken_adi;

            //string name;
            //name = "Engin";
            //Console.WriteLine(name);

            //string customerName;
            //string custormerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Engin";
            //custormerSurname = "Elkurt";
            //customerPhone = "5555555555";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadiköy";
            //city = "Istanbul";

            //Console.WriteLine("**** Rezervasyon Kartı **** ");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Müşteri: " + customerName + "  " +custormerSurname);
            //Console.WriteLine("İletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:"+ district + " / " + city);
            //Console.WriteLine("-----------------------");

            //customerName = "Ahmet";
            //custormerSurname = "Kaya";
            //customerPhone = "66666666";
            //customerEmail = "sallasalla33@hotmail.com";
            //district = "Avcılar";
            //city = "Istanbul";

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Müşteri: " + customerName + "  " + custormerSurname);
            //Console.WriteLine("İletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + district + " / " + city);
            //Console.WriteLine("-----------------------");


            #endregion

            #region Int Degiskenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 150;

            Console.WriteLine("***** Restoran Menü Fiyati *****" );
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyati:" + hamburgerPrice +"TL");
            Console.WriteLine("-----Kola Fiyati:" + cokePrice + "TL");
            Console.WriteLine("-----Su Fiyati:" + waterPrice + "TL");
            Console.WriteLine("-----Patates Kızartması Fiyati:" + friesPrice + "TL");
            Console.WriteLine("-----Limonata Fiyati:" + lemonadePrice + "TL");
            Console.WriteLine("-----Pizza Fiyati:" + pizzaPrice + "TL");
            Console.WriteLine() ;
            Console.WriteLine("***** Restoran Menü Fiyati *****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount; 
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice ;
            int totalCokePrice ;
            int totalWaterPrice ;
            int totalFriesPrice ;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 1;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + "TL");
            Console.WriteLine("Patates Kızartması Tutarı:" + totalFriesPrice + "TL");
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + "TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + "TL");

            Console.WriteLine();
            
            int totalPrice =  totalHamburgerPrice + totalCokePrice +totalFriesPrice + totalWaterPrice+totalLemonadePrice + totalPizzaPrice;

            Console.WriteLine( "Toplam Odenecek Tutar : " + totalPrice);

            #endregion

            Console.Read();  
        }
    }
}
