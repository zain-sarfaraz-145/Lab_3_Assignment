//4.	Create a rectangle class with two data members’ length and width Provide member functions to calculate the perimeter and area of the rectangle and a 
//function square which returns true if the rectangle is a square otherwise it returns false.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3_Ques._4
{
    public class rectangle
    {
        public int l, b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            rectangle rec = new rectangle();
            Console.Write("Enter the length of Rectangle: ");
            rec.l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the breadth of Rectangle: ");
            rec.b = Convert.ToInt32(Console.ReadLine());
            int area = rec.l * rec.b;
            int peri = 2 * (rec.l + rec.b);
            Console.WriteLine("\n\nArea of Rectangle is = {0} and Perimeter of Rectangle is = {1}", area, peri);
            if (rec.l == rec.b)
            {
                Console.WriteLine("\nRectangle is a square");
            }
            else
            {
                Console.WriteLine("\nRectangle is not a Square");
            }
            Console.ReadKey();
        }
    }
}