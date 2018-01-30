//3. Write a program that contains a class which has a method that takes user name as input and second functions which returns number of vowels present in 
//it and Main program prints the number of vowels 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3_Ques._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Write Anything: ");
            string sentence = Console.ReadLine().ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    total++;
                }
            }
            Console.WriteLine("Number of vowels are: {0}", total);
            Console.ReadLine();
        }
    }
}
