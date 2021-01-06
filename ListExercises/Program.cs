using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");

            List<int> numberList = new List<int>() { 2, 4, 56, 7, 89, 75, 3, 7, 0, 9 };


            SumClass.SumNumbers(numberList);
        

            string str = "I would not, could not, in a box. I would not, could not with a fox." +
                     "I will not eat them in a house. I will not eat them with a mouse.";


            

            List<string> words = str.Split(' ').ToList();

            Print.PrintWords(words);
        }
    }
}