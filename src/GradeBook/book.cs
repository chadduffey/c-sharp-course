using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        
        private List<double> grades;
        public string Name;
        private double lowGrade;
        private double highGrade;


        public Book(string name)
        {
            grades = new List<double>();
            lowGrade = double.MaxValue;
            highGrade = double.MinValue;
            Name = name;
        }

        public void AddGrade(double grade){
            grades.Add(grade);
            highGrade = Math.Max(grade, highGrade);
            lowGrade = Math.Min(grade,lowGrade);
        }

        private double HighGrade(double grade){
            return highGrade;
        }

        private double LowGrade(double grade){
            return lowGrade;
        }

        private double Average(){
            double total = 0.0;
            foreach (double grade in grades){
                total += grade;
            }
            return total / grades.Count;
        }

        public Statistics GetStatistics(){

            var result = new Statistics();

            result.Average = Average();
            result.Low = lowGrade;
            result.High = highGrade;

            return result;
        }
    }
}
