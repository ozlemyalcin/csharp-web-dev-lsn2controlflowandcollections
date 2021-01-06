using System;

namespace StringExercises
{
    class Program
    {
        public static object Print { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");

            string str= "I would not, could not, in a box. I would not, could not with a fox."+
                        "I will not eat them in a house. I will not eat them with a mouse.";

            string[] words = str.Split(" ");
            foreach (string word in words) 
            {
                Console.WriteLine($"{word}");
                
            }
            Console.WriteLine(string.Join(",", words));

            


        }

    }
}
