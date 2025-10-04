using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            int i = 0;
            while (i < n)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double r = x * x + y * y;
                if (r >= r1 * r1 && r <= r2 * r2)
                    count++;
                i++;
            }
            // end

            return count;
        }

        public (int count, double average) Task2(int n)
        {
            int badCount = 0;
            double total = 0;

            // code here
            int student = 0;
            while (student < n)
            {
                int[] marks = new int[4];
                for (int j = 0; j < 4; j++)
                    marks[j] = int.Parse(Console.ReadLine());

                bool hasTwo = false;
                for (int j = 0; j < 4; j++)
                {
                    total += marks[j];
                    if (marks[j] == 2) hasTwo = true;
                }
                if (hasTwo) badCount++;
                student++;
            }
            double avg = total / (n * 4);
            // end

            return (badCount, avg);
        }

        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            double totalMark = 0;
            for (int i = 0; i < exams; i++)
            {
                double theory = Convert.ToDouble(Console.ReadLine());
                double practice = Convert.ToDouble(Console.ReadLine());
                double result = theory * 0.4 + practice * 0.6;

                double grade;
                if (result > 85) grade = 5;
                else if (result > 70) grade = 4;
                else if (result > 50) grade = 3;
                else grade = 2;

                totalMark += grade;
            }
            avgMark = totalMark / exams;
            // end

            return avgMark;
        }

        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here
            int c1 = code / 100;
            int c2 = (code / 10) % 10;
            int c3 = code % 10;

            while (attempts < limit)
            {
                int x1 = int.Parse(Console.ReadLine());
                if (x1 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int x2 = int.Parse(Console.ReadLine());
                if (x2 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int x3 = int.Parse(Console.ReadLine());
                if (x3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }

                if (x1 == c1 && x2 == c2 && x3 == c3)
                {
                    solution = "Доступ разрешен!";
                    break;
                }

                attempts++;
            }

            if (solution == "Код не подобран")
                solution = "Система заблокирована!";
            // end

            return (solution, attempts);
        }

        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int b = (a + i - 1) % 29 + 1;

                // first apply base increase
                luck = Math.Min(luck + 5, 100);

                // then handle special cases
                if (b == 4 || b == 11 || b == 18 || b == 25)
                {
                    luck = Math.Max(luck - 10, 0);
                }
                else if (b == 7 || b == 14 || b == 21 || b == 28)
                {
                    if (luck < 50) luck = 55;
                }
                else if (b == 1 || b == 8 || b == 15 || b == 22 || b == 29)
                {
                    luck = Math.Min(luck * 1.5, 100);
                }
            }
            // end

            return luck;
        }
    }
}
