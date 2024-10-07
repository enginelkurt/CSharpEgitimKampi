using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen sifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifre dogrudur");

            //}
            //else
            //{
            //    Console.WriteLine("Sifre Yanlis");

            //}
            //Console.Read();

            //string capital, country;
            //Console.Write("Baskenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")

            //{
            //    Console.Write("Veriler Dogrulandi");
            //}
            //else
            //{
            //    Console.Write("Hatali bilgi");

            //}


            //int number;
            //Console.Write("Sayiyi Giriniz: ");
            //number=int.Parse (Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayi dogru");

            //}
            //else
            //{
            //    Console.WriteLine("Sayi hatali");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";
            //Console.Write("Sinav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sinav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sinav3: ");
            //exam3 = int.Parse(Console.ReadLine());


            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sinavlarin ortalamasi: " + average);

            //if (average > 0 & average < 50)
            //{
            //    result = "Sonuc Vasat";

            //}
            //if (average > 50 & average < 69)
            //{
            //    result = "Sonuc vasatin ustu";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuc iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuc cok iyi";
            //}

            //Console.WriteLine(result);
            //Console.Read();

            //string city;
            //Console.Write("Lütfen sehir girisi yapiniz: ");
            //city=Console.ReadLine();
            //if (city == "Adana" | city == "Ankara" | city == "Bursa" | city == "Rize")
            //{
            //    Console.WriteLine("Sehir mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("Sehir mevcut degildir");
            //}
            //Console.Read();


            //Console.Write("Lütfen kullanici adi giriniz: ");
            //string username=Console.ReadLine();
            //if(username!="admin")
            //{
            //    Console.Write("Bu kullanici adi kabul edilemez");

            //}
            //else
            //{
            //    Console.Write("Hos geldiniz");
            //}
            //Console.Read();

            #endregion

            #region Mod İslemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Read();

            //Console.Write("Lütfen 1.sayiyi giriniz: ");
            //int number1= int.Parse(Console.ReadLine());


            //Console.Write("Lütfen 2.sayiyi giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result=number1%number2;
            //Console.Write("1.Sayinin 2.sayiya bölümününden kalan: "+ result);
            //Console.Read();


            //Console.Write("Lütfen sayiyi giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayi cifttir");


            //}
            //else 
            //{
            //    Console.Write("Sayi tektir");

            //}
            //Console.Read();
            #endregion

            #region Char Ornek Karar Yapıları
            //char team;
            //Console.Write("Lütfen takim sembolunu gireiniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Giresunspor");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahce");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Besiktas");
            //}

            //Console.Read();
            #endregion

            #region Ornek Proje Uygulamasi
            //Console.WriteLine("***** C# Egitim Kampi Restoran*****");
            //Console.WriteLine();
            //Console.WriteLine("------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İcecekler");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("------------");


            //string menuItem;
            //Console.Write("Lütfen detayini görmek istediginiz menü secimi: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabagi");
            //    Console.WriteLine("3-Fasulye");
            //    Console.WriteLine("4-Somon");
            //    Console.WriteLine("5-Patlıcan");
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Corbalar-----");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Pirinc");
            //    Console.WriteLine("4-Tarhana");
            //    Console.WriteLine("5-Domates");
            //    Console.WriteLine("-----Corbalar-----");
            //    Console.WriteLine();
            //}


            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine("1-Karisik");
            //    Console.WriteLine("2-Akdeniz");
            //    Console.WriteLine("3-Margaritha");
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Icecekler-----");
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("-----Icecekler-----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlilar-----");
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-Profiterol");
            //    Console.WriteLine("3-Sutlac");
            //    Console.WriteLine("-----Tatlilar-----");
            //    Console.WriteLine();
            //}

            //Console.ReadLine();
            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girisi yapiniz:" );
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Subat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayis"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Agustos"); break;
            //    case 9: Console.Write("Eylul"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasim"); break;
            //    case 12: Console.Write("Aralik"); break;

            //    default: Console.Write("Hatali veri girisi"); break;

            //}





            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.sayiyi giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.sayiyi giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediginiz islemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());
            //switch(symbol)
            //{
            //    case '+':
            //        result = number1 + number2; 
            //        Console.WriteLine("Toplam: " +result);
            //        break;


            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: "+result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Carpim: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bolum: " + result);
            //        break;
            //}




            #endregion

            Console.Read();
        }
    }
}
