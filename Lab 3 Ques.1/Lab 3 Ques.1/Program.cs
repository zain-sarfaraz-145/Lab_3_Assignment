using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3_Ques._1
{
    public class Book
    {
        public string Title;
        public string Author;
        public short YearPublished;
        public int NumberOfPages;
        public char CoverType;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var First = new Book();

            First.Title = " Turbo C ";
            First.Author = "Robert Lafore";
            First.YearPublished = 1996;
            First.NumberOfPages = 872;
            First.CoverType = 'H';
            Console.WriteLine("Book Characteristics");

            Console.Write("Title:  ");
            Console.WriteLine(First.Title);
            Console.Write("Author: ");
            Console.WriteLine(First.Author);
            Console.Write("Year:   ");
            Console.WriteLine(First.YearPublished);
            Console.Write("Pages:  ");
            Console.WriteLine(First.NumberOfPages);
            Console.Write("Cover:  ");
            Console.WriteLine(First.CoverType);
            Console.ReadKey();   

        }
    }
}
