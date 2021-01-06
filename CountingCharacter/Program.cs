using System;
using System.Collections.Generic;


namespace CountingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            char[] textChars = text.ToCharArray();

            /* TODO: count the characters in textChars array */

            Dictionary<char, int> counts = new Dictionary<char, int>();


            foreach(char c in textChars)
            {
             
                if(!counts.ContainsKey(c))
                {
                    counts.Add(c, 1);

                }
                else
                {
                    counts[c] ++;
                    
                } 
                

            }

            foreach (KeyValuePair<char, int> count in counts)

            {
                Console.WriteLine($"{count.Key}: {count.Value}");



            }


        }
    }
}
