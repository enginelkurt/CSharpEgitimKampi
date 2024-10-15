using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Ornekleri
            //DegiskenTürü  [] DiziAdı = new DegiskenTürü[ElemanSayisi]
            //string[] colors = new string[4];
            //colors[0] = "Kirmizi";
            //colors[1] = "Sari";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            ////Console.WriteLine(colors[2]);
            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeste";
            //cities[2] = "Istanbul";
            //cities[3] = "Madrid";
            //cities[4] = "Lyon";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 40;
            //numbers[2] = 30;
            //numbers[3] = 60;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Prag", "Ankara", "Bursa", "Roma" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanaları Listeleme

            //string[] colors = { "Sari", "Laciver", "Yesil", "Mor", "Beyaz", "Pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 2, 3, 44, 555, 66, 223, 42, 5353, 22 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {

            //        Console.WriteLine(numbers[i]);
            //    }
            //};



            ////char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            ////for (int i = 0; i < symbols.Length; i++)
            ////{

            ////    Console.WriteLine(symbols[i]);
            ////}

            //int[] myArray = { 47, 85, 94, 41, 25, 634, 100, 86 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //    Console.WriteLine(maxNumber);


            //string[] persons = { "ali", "ahmet", "cem", "ayse", "buse", "deniz" };
            //Console.WriteLine(persons.Length);

            //int [] numbers = { 45,85,52,41,79,24};
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] number = { 45, 85, 52, 41, 79, 24 };
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}


            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "ayse", "buse", "ahmet", "merve" };

            //int index = Array.IndexOf(customers, "ayse");
            //Console.WriteLine(index);   


            //int[] numbers = { 34, 22, 44, 53, 88, 76, 97 };

            //Console.WriteLine("Dizinin En buyuk elemani: "  + numbers.Max()+ " Dizinin en kucuk degeri:"  +numbers.Min());





            #endregion

            #region Kullanicidan Deger Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{

            //    Console.Write($"Lütfen {i + 1}.Sehrini Giriniz: ");
            //    cities [i] = Console.ReadLine();
            //;}
            //Console.WriteLine();
            //Console.WriteLine("---------------");

            //for(int i=0; i<cities.Length;i++)
            //    Console.WriteLine( cities [i] );

            //int[] number = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i=0; i<number.Length; i++)
            //    { sum += number[i]; };
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 748, 338, 39, 220 };
            //Console.WriteLine("Cift Sayilar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)

            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            //Console.WriteLine("----------");
            //Console.WriteLine("Tek Sayilar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)

            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            #endregion
            //Console.Read();


        }
    }
}


