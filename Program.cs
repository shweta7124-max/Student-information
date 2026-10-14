
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> grades = new List<double>();

        for (int i = 1; i <= 5; i++)
        {
            double grade;

            while (true)
            {
                Console.Write($"Enter grade {i}: ");

                if (double.TryParse(Console.ReadLine(), out grade))
                {
                    break;
                }

                Console.WriteLine("Invalid input. Please enter a numeric grade.");
            }

            grades.Add(grade);
        }

        double maximum = grades.Max();
        double minimum = grades.Min();
        double average = grades.Average();

        Console.WriteLine("\nStudent Grade Statistics");
        Console.WriteLine("------------------------");
        Console.WriteLine($"Maximum grade: {maximum:F2}");
        Console.WriteLine($"Minimum grade: {minimum:F2}");
        Console.WriteLine($"Average grade: {average:F2}");
    }
}

