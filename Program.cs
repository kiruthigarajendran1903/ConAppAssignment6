using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace ConAppAssignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] StudentsScore = new int[3][];
            StudentsScore[0] = new int[3] { 85, 92, 78 };
            StudentsScore[1] = new int[4] { 90, 87, 93, 89 };
            StudentsScore[2] = new int[2] { 76, 88 };

            Console.WriteLine("Enter Students List");
            for(int i = 0; i < StudentsScore.Length; i++)
            {
                Console.WriteLine($"Enter Student {i+1} Mark");
                for (int j = 0; j < StudentsScore[i].Length; j++)
                {
                    Console.WriteLine(StudentsScore[i][j]+"\t") ;
                }
                Console.WriteLine("\n");


            }
            Console.WriteLine("Average Scores:");
            for (int i = 0; i <StudentsScore.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j <StudentsScore[i].Length; j++)
                {
                    sum += StudentsScore[i][j];
                }
                double average = sum / StudentsScore[i].Length;
                Console.WriteLine($"Student {i + 1}: {average:F2}");
            }
            Console.WriteLine("Average Score for All Students Combined:");
            double totalSum = 0;
            int totalLength = 0;
            for (int i = 0; i < StudentsScore.Length; i++)
            {
                for (int j = 0; j < StudentsScore[i].Length; j++)
                {
                    totalSum += StudentsScore[i][j];
                    totalLength++;
                }
            }
            double totalAverage = totalSum / totalLength;
            Console.WriteLine($"Overall Average: {totalAverage:F2}");
        }

    }
}
