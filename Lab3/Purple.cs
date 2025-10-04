using System;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double dist = x * x + y * y;
                if (dist >= r1 * r1 && dist <= r2 * r2)
                    count++;
            }
            // end

            return count;
        }

        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double totalSum = 0;
            int totalMarks = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int a1 = int.Parse(Console.ReadLine());
                int a2 = int.Parse(Console.ReadLine());
                int a3 = int.Parse(Console.ReadLine());
                int a4 = int.Parse(Console.ReadLine());

                totalSum += a1 + a2 + a3 + a4;
                totalMarks += 4;

                if (a1 == 2 || a2 == 2 || a3 == 2 || a4 == 2)
                    count++;
            }

            double average = totalSum / totalMarks;
            // end

            return (count, average);
        }

        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            double sum = 0;
            for (int i = 0; i < exams; i++)
            {
                double theory = double.Parse(Console.ReadLine());
                double practice = double.Parse(Console.ReadLine());
                double score = 0.4 * theory + 0.6 * practice;

                if (score > 85)
                    sum += 5;
                else if (score > 70)
                    sum += 4;
                else if (score > 50)
                    sum += 3;
                else
                    sum += 2;
            }
            avgMark = sum / exams;
            // end

            return avgMark;
        }

        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here
            int b1 = code / 100;
            int b2 = (code / 10) % 10;
            int b3 = code % 10;

            while (attempts < limit)
            {
                int a1 = int.Parse(Console.ReadLine());
                if (a1 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int a2 = int.Parse(Console.ReadLine());
                if (a2 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int a3 = int.Parse(Console.ReadLine());
                if (a3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }

                attempts++;

                if (a1 == b1 && a2 == b2 && a3 == b3)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }

            if (solution == "Код не подобран" && attempts >= limit)
                solution = "Система заблокирована!";
            // end

            return (solution, attempts);
        }

        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                int b = (a + i - 1) % 29 + 1;

                // base increment
                luck = Math.Min(luck + 5, 100);

                // modifiers
                if (b == 4 || b == 11 || b == 18 || b == 25)
                    luck = Math.Max(luck - 10, 0);
                else if (b == 7 || b == 14 || b == 21 || b == 28)
                {
                    if (luck < 50)
                        luck = 55;
                }
                else if (b == 1 || b == 8 || b == 15 || b == 22 || b == 29)
                    luck = Math.Min(luck * 1.5, 100);
            }
            // end

            return luck;
        }
    }
}
