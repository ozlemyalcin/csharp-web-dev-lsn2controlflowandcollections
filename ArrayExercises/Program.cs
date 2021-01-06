using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");

            int[] arrays = new int[6] { 1, 1, 2, 3, 5, 8 };
            
            foreach(int i in arrays)
            {
                Console.WriteLine(i);
            }
            foreach(int i in arrays)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
