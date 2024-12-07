using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Değişken Türü
            //Değişken Adı
            //In
            //Liste Koleksiyon Adı
            //string[] cities = { "milano", "roma", "antalya", "paris" };
            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 88, 98, 102, 36, 47, 9, 7 };
            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}
            //int[] numbers = { 45, 88, 70, 56, 83 };
            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += 1;

            //}
            //Console.WriteLine(total);
            //List<int> numbers = new List<int>()
            //{
            //    1,2,5,9,56
            //};
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #region Örnek Sınav Sistemi
            //Console.WriteLine("****** C# eğitim Kampı ********");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki Öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Sınfınızda Kaç Öğrenci Var? ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------");

            //// Öğrenci isimlerini ve not ortalamarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for ( int i=0; i<studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult = 0;

            //    //her öğrenci için üç sınav notu girişi
            //    for (int j= 0; j<3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;

            //    }
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            //for(int i = 0; i<studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalamsı: {studentExamAvg[i]}");
            //}
            #endregion
            //Console.Read();
        }
    }
}
