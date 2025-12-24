// This file contains 20 coding snippets as per the provided specifications.
// this are done on 24th dec 2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snippets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This file contains 20 coding snippets as per the provided specifications.");
        }

        // Q1
        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return Math.Round(area, 2, MidpointRounding.AwayFromZero);
        }

        // Q2
        public static double FeetToCentimeters(int feet)
        {
            return Math.Round(feet * 30.48, 2, MidpointRounding.AwayFromZero);
        }

        // Q3
        public static string HeightCategory(int heightCm)
        {
            if (heightCm < 150) return "Short";
            if (heightCm < 180) return "Average";
            return "Tall";
        }

        // Q4
        public static int LargestOfThree(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        // Q5
        public static string FormatSeconds(int totalSeconds)
        {
            int m = totalSeconds / 60;
            int s = totalSeconds % 60;
            return $"{m}:{s:D2}";
        }

        // Q6
        public static int SumPositiveUntilZero(int[] nums)
        {
            int sum = 0;
            foreach (int n in nums)
            {
                if (n == 0) break;
                if (n < 0) continue;
                sum += n;
            }
            return sum;
        }

        // Q7
        public static int[] MultiplicationRow(int n, int upto)
        {
            int[] res = new int[upto];
            for (int i = 1; i <= upto; i++)
                res[i - 1] = n * i;
            return res;
        }

        // Q8
        public static int SumParsedInts(string[] tokens)
        {
            int sum = 0;
            foreach (string t in tokens)
                if (int.TryParse(t, out int v))
                    sum += v;
            return sum;
        }

        // Q9
        public static int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        // Q10
        public static int FinalBalance(int initialBalance, int[] transactions)
        {
            int balance = initialBalance;
            foreach (int t in transactions)
            {
                if (t >= 0) balance += t;
                else if (balance + t >= 0) balance += t;
            }
            return balance;
        }

    }
}
