using System;
using System.Collections.Generic;

namespace Pluralsight_Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            int students;
            double result = 0.0;

            List<double> grades = new List<double>() { };

           

            Console.WriteLine("Enter the number of students in the class");
            students = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("There are {0} students in the class", students);

            foreach (double number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N2}");

        }
    }
}
