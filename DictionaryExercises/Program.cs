using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            string newStudent;
            string input;


            Console.WriteLine("Enter students(or Enter to finish): ");

            do
            {
                Console.WriteLine("Student ID: ");

                input = Console.ReadLine();

                if (!Equals(input, ""))
                {
                    int id = int.Parse(input);

                    Console.WriteLine("Student Name:");
                    input = Console.ReadLine();

                    newStudent = input;

                    students.Add(id, newStudent);

                }


            } while (!Equals(input, ""));


            foreach(KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }
    }
}