using System;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double s = x * x + y * y;
                if (s >= r1 * r1 && s <= r2 * r2) count++;
            }

            return count;
        }

        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int a1 = int.Parse(Console.ReadLine());
                int a2 = int.Parse(Console.ReadLine());
                int a3 = int.Parse(Console.ReadLine());
                int a4 = int.Parse(Console.ReadLine());

                sum += a1 + a2 + a3 + a4;
                if (a1 == 2 || a2 == 2 || a3 == 2 || a4 == 2) count++;
            }

            double average = sum / (n * 4.0);
            return (count, average);
        }

        public double Task3(int exams)
        {
            double total = 0;

            for (int i = 0; i < exams; i++)
            {
                double theory = double.Parse(Console.ReadLine());
                double practice = double.Parse(Console.ReadLine());
                double score = 0.4 * theory + 0.6 * practice;

                if (score > 85) total += 5;
                else if (score > 70) total += 4;
                else if (score > 50) total += 3;
                else total += 2;
            }

            return total / exams;
        }

        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            int b1 = code / 100;
            int b2 = (code / 10) % 10;
            int b3 = code % 10;

            while (attempts < limit)
            {
                int
