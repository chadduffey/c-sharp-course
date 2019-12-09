using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }
    }
    
    public abstract class BookBase
    {
        public abstract void AddGrade(double grade);
    }
    public class Book : NamedObject
    {
        
        private List<double> grades;
        private double lowGrade;
        private double highGrade;

        public Book(string name) : base(name)
        {
            grades = new List<double>();
            lowGrade = double.MaxValue;
            highGrade = double.MinValue;
            Name = name;
        }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade,lowGrade);
            } else {
                throw new ArgumentException($"Invalid grade: {nameof(grade)}");
            }    
            
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

        private char LetterGrade(double grade)
        {
            char lg;

            if (grade >= 90) {
                lg = 'A';
            } else if (grade >= 80) {
                lg = 'B';
            } else if (grade >= 70) {
                lg = 'C';
            } else if (grade >= 60) {
                lg = 'D';
            } else {
                lg = 'F';
            }

            return lg;
        }

        public Statistics GetStatistics(){

            var result = new Statistics();

            result.Average = Average();
            result.Low = lowGrade;
            result.High = highGrade;

            result.LetterGrade = LetterGrade(result.Average);

            return result;
        }
    }
}
