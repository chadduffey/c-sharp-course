using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("Chads Book");
            book.AddGrade(34.4);
            book.AddGrade(80.1);
            var stats = book.GetStatistics();
            System.Console.WriteLine($"The highest is {stats.High}");
            System.Console.WriteLine($"The lowest is {stats.Low}");
            System.Console.WriteLine($"The average is {stats.Average:N1}");
        }
    }
}