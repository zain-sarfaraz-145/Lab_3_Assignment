//2.Create a class student with a data members name, age, marks of English , marks of math, marks of science, total marks, obtained marks and percentage 
//provide member functions CalculateTotalMarks and CalculatePercentage to calculate marks and percentage in main.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3_Ques._2
{
    public class Marks
    {
        public string name;
        public int age;
        public int eng;
        public int math;
        public int science;
        public int total;
        public float percentage;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Marks sheet=new Marks();
            Console.WriteLine("Enter your Name: ");
            sheet.name = (Console.ReadLine());
            Console.WriteLine("Enter your Age: ");
            sheet.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter English Marks: ");
            sheet.eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Math Marks: ");
            sheet.math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Science Marks: ");
            sheet.science = int.Parse(Console.ReadLine());
            sheet.total=sheet.eng+sheet.math+sheet.science;
            Console.WriteLine("\nTotal Marks are: "+sheet.total);
            sheet.percentage=((sheet.total*100)/300);
            Console.WriteLine("\nPercentage is: "+sheet.percentage+"%");
            Console.ReadKey();
        }
    }
}
