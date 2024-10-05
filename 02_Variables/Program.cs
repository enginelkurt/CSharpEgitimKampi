using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.88;
            //strawberryPrice = 00.44;
            //potatoPrice = 10.44;
            //tomatoPrice = 6.11;

            //Console.WriteLine("---- Elma Birim Fiyati:" + applePrice + "TL");
            //Console.WriteLine("---- Portakal Birim Fiyati:" + orangePrice + "TL");
            //Console.WriteLine("---- Cilek Birim Fiyati:" + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyati:" + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyati:" + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice= applePrice * appleGram;
            //double orangeTotalPrice= orangePrice * orangeGram;
            //double strawberryTotalPrice= strawberryPrice * strawberryGram;
            //double potatoTotalPrice= potatoPrice * potatoGram;
            //double tomatoTotalPrice= tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Urun:Elma - " + "Birim Fiyat :" + applePrice + "Gramaj : " + appleGram + " -Toplam Tutar :" + appleTotalPrice);

            //Console.WriteLine("Alınan Urun:Portakal - " + "Birim Fiyat :" + orangePrice + "Gramaj : " + orangeGram + "-Toplam Tutar :" + orangeTotalPrice);

            //Console.WriteLine("Alınan Urun:Cilek - " + "Birim Fiyat : " + strawberryPrice + "Gramaj: " +
            //    strawberryGram + "-Toplam Tutar :" + strawberryTotalPrice);

            //Console.WriteLine("Alınan Urun :Patates - " +"Birim Fiyat : " + potatoPrice + "Gramaj : " + potatoGram + "-Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Urun:Domates - " + "Birim Fiyat :" + tomatoPrice + "Gramaj : " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice +strawberryTotalPrice +potatoTotalPrice+tomatoTotalPrice;

            //Console.WriteLine("Toplam Tutar :" + shoppingTotalPrice + "TL");

            #endregion

            #region Char Degiskenler

            //ABCDEFGH
            //DEF....
            //Toplanti saat 20:00'de 

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion


            #region  Klavyeden Veri Girisleri

            //Console.WriteLine("***** CSharp Hava Yollari Yolcu Bilgisi ***** ");
            //string passengerName,passengerSurname,passengerDistrict,passengerCity,passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adi:" );
            //passengerName=Console.ReadLine();
            //Console.Write("Yolcu Soyadi :");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlce Bilgisi:");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Sehir Bilgisi :");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yasi:" );
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Kimlik Numarasi: ");
            //passengerIdentityNumber = Console.ReadLine();




            //Console.WriteLine();
            //Console.WriteLine("------------");
            //Console.WriteLine("Yolcu Kimlik Numarasi: "   +  passengerIdentityNumber +"- Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + "Yolcu İlcesi" +passengerDistrict + "Yolcu Ili "+passengerCity + "Yolcu Yasi " + passengerAge );




            #endregion

            #region Klavyeden Tam Sayi Girisleri ve Donusumler


            ////ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;


            //Console.Write("Lütfen aldiginiz ayakakabi sayisini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldiginiz bilgisayar sayisini giriniz :");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldiginiz sandalye sayisini giriniz :");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldiginiz TV sayisini giriniz :");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice+ tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Odenmesi Gereken Tutar: "+ totalPrice);




            #endregion


            #region Klavyeden Ondalikli Sayi İslemleri 


            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.Sınav notunu giriniz:");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sınav notunu giriniz:");
            //exam2 =double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.Sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());
            //result=(exam1+exam2+exam3)/3;
            //Console.Write("Sonuc Ortalamanız: " + result);







            #endregion

            #region Klavyeden Karakter Girisleri

            //char gender;
            //Console.Write("Lutfen cinsiyet seciniz:");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Sectiginiz Cinsiyet:" +gender);

            //#endregion

            //Console.Read();
        }
    }
}
