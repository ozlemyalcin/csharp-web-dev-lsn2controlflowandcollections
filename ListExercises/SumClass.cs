using System;
using System.Collections.Generic;

namespace ListExercises
{
    public class SumClass
    {
        public static void SumNumbers(List<int> list)
        {


            int sum = 0;

            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
