using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("Chads Book");
            
            while (true) 
            {
                Console.WriteLine("Enter a grade (or 'q' to Quit): ");
                var input = Console.ReadLine();
                if (input == "q") 
                {
                    break;
                }

                try {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                } catch(ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                } catch (FormatException ex) {
                    Console.WriteLine(ex.Message);
                } finally {
                    Console.WriteLine("**");
                }

                
            }
            
            var stats = book.GetStatistics();
            System.Console.WriteLine($"The highest is {stats.High}");
            System.Console.WriteLine($"The lowest is {stats.Low}");
            System.Console.WriteLine($"The average is {stats.Average:N1}");
            System.Console.WriteLine($"The letter grade is {stats.LetterGrade}");
        }
    }
}