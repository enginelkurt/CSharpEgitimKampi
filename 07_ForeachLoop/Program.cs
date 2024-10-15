using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Dongusu

            // 4 parametre alır , 1 degisken türü , 2 Degisken adi , 3 In , 4 liste koleksiyon dizi


            //string[] cities = { "Roma", "Budapeste", "Istanbul", "Ankara", "Varsova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //};

            //int[] numbers = { 231, 23, 34, 64, 54, 655, 774, 845, 933, 1044, 11342, };

            //foreach (int number in numbers)
            //{

            //    Console.WriteLine(number);
            //};


            //int[] numbers = { 231, 23, 34, 64, 54, 655, 774, 845, 933, 1044, 11342, };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    };
            //};


            //int[] numbers = { 231, 23, 34, 64, 54, 655, 774, 845, 933, 1044, 11342, };

            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List <int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers )
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion


            #region Ornek Sinav Sistemi Uygulaması


            Console.Write("***** C# Egitim Kampi Sinav Uygulamasi ******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıf ogrenci sayisi kullanıcıdan alındi.
            Console.WriteLine("-------------------------");
            Console.Write("Sinifta kaç ogrenci var: ");
            int studentCount=int.Parse(Console.ReadLine()); 
            Console.WriteLine("-------------------------");
            // Ogrenci isim ve not ortalamalari saklayacak diziler
           string[]studentNames =new string[studentCount];  
           double [] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. ogrencinin ismini giriniz");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her ogrencı ıcın 3 sınav gırısı

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]}adli ögrencinin {j + 1}. sinav notunu giriniz");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları toplama

                };

                studentExamAvg[i] = totalExamResult / 3;

            }

           //sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adli ogrencinin ortalamasi : {studentExamAvg[i]}");

                //Gecıp kalma durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i] } adli ogrenci dersi gecti") ;
                }

                 else
                {
                    Console.WriteLine($"{studentNames[i]} adli ogrenci dersten kaldi");
                }

            }






            #endregion
            Console.Read();
        }
    }
}
