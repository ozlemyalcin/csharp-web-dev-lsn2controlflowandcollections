using System;
using System.Collections.Generic;

namespace ListExercises
{
    public class Print
    {
        public static void PrintWords(List<string> list )
        {
            Console.WriteLine("Length of words:");
            int num = int.Parse(Console.ReadLine());

            foreach(string word in list)
            {
                if (word.Length == num)
                {
                    Console.WriteLine(word);
                }
            }




        }
    }
}
