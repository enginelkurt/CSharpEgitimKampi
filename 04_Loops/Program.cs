using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Dongusu
            //DongulerFor
            //For (x;y;z)
            //x:Baslangic degeri
            //y:Bitis degeri
            //z:Artis-Azalis degerleri

            //int i;
            //for (i=1; i<=5; i++)
            //{
            //    Console.WriteLine("C# EgitimKampi");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Lutfen ekrana yazilmsasini istediginiz adeti giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yasasin Cumhuriyet");
            //}



            #endregion


            #region For Dongusu ile Karar Yapilari

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0;
            //for(int i=1; i<=10;i++ )
            //{
            //    totalValue += i;

            //}
            //Console.WriteLine( totalValue);
            //Console.Read();

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if( i % 2 == 0 )
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("-----");
            //Console.WriteLine(totalValue);
            //Console.Read();

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}





            #endregion


            #region While Dongusu

            //While(Sart)

            //    int i = 1;
            //    while (i <=10)
            //    {
            //        Console.WriteLine("Merhaba Donguler");
            //        i++;
            //    }
            //    
            //    Console.Read();
            //}

            //int i = 1;
            //while (i <= 10)
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //i++;
            //Console.Read();


            //int i = 1;
            //int sum = 0;
            //while (i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.Read();




            #endregion

            #region Ornek Soru

            //Klavyeden girilen 3 basamaklı sayının , basamakları toplamını hesaplyan kodu yaziniz.
            //456 

            //Console.Write("Sayiyi giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;


            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            //Console.Read();

            #endregion

            
        }
    }
}
