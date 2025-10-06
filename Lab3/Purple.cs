using System.Net.Http.Headers;
using System.Numerics;
using static System.Formats.Asn1.AsnWriter;

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
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if ((r1 * r1 <= x * x + y * y) && (x * x + y * y <= r2 * r2))
                {
                    count += 1;
                }
            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
            double sum = 0;
            if (n == 0)
            {
                return (count, average);
            }
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                double x1 = Convert.ToInt32((Console.ReadLine()));
                double x2 = Convert.ToInt32((Console.ReadLine()));
                double x3 = Convert.ToInt32((Console.ReadLine()));
                double x4 = Convert.ToInt32((Console.ReadLine()));

                sum += (x1 + x2 + x3 + x4);
                s += 4;

                if (x1 == 2 || x2 == 2 || x3 == 2 || x4 == 2)
                {
                    count++;
                }
            }
            average = sum / s;
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark;
            int n = exams;
            double score = 0;

            while (exams > 0)
            {
                theory = Convert.ToInt32(Console.ReadLine());
                practice = Convert.ToInt32(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85)
                {
                    mark = 5;
                }
                else if (score > 70)
                {
                    mark = 4;
                }
                else if (score > 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
                }
                avgMark += (double)mark / n;
                exams--;
            }
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here
            for (int i = 0; i < limit; i++)
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 == -1 || num2 == -1 || num3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }

                if ((code % 10 == num3) && ((code / 10) % 10 == num2) && ((code / 100) % 10 == num1))
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = a; i < a + n; i++)
            {
                switch (i)
                {
                    case int k when (k == 1 || k == 8 || k == 15 || k == 22 || k == 29):
                        luck *= 1.5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;
                    case int k when (k == 4 || k == 11 || k == 18 || k == 25):
                        luck -= 10;
                        if (luck < 0)
                        {
                            luck = 0;
                        }
                        break;
                    case int k when (k == 7 || k == 14 || k == 21 || k == 28):
                        if (luck < 50)
                        {
                            luck = 55;
                        }
                        break;
                    default:
                        luck += 5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;
                }
            }
            // end

            return luck;
        }
    }
}