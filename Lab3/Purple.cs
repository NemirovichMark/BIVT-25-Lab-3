using System.Net.Http.Headers;
using System.Numerics;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            while (n > 0)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                if (x * x + y * y >= (double)r1 * (double)r1 && x * x + y * y <= (double)r2 * (double)r2)
                {
                    ++count;
                }
                --n;
            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
            if (n == 0)
            {
                return (0, 0);
            }
            for (int i = 0; i < n; ++i)
            {
                int.TryParse(Console.ReadLine(), out int x1);
                int.TryParse(Console.ReadLine(), out int x2);
                int.TryParse(Console.ReadLine(), out int x3);
                int.TryParse(Console.ReadLine(), out int x4);
                average += (double)(x1 + x2 + x3 + x4);
                if (x1 == 2 || x2 == 2 || x3 == 2 || x4 == 2)
                {
                    ++count;
                }
            }
            average /= (double)(n * 4);
            Console.WriteLine(count + ", " +  average);
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark, n;
            n = exams;
            double score;
            while (exams > 0)
            {
                int.TryParse(Console.ReadLine(), out theory);
                int.TryParse(Console.ReadLine(), out practice);
                score = (double)(0.4 * theory) + (double)(0.6 * practice);
                if ((int)score > 85)
                {
                    mark = 5;
                }
                else if ((int)score > 70)
                {
                    mark = 4;
                }
                else if ((int)score > 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
                }
                avgMark += (double)mark / n;
                --exams;
            }
            Console.WriteLine(avgMark);
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here
            while (attempts < limit)
            {
                ++attempts;
                int.TryParse(Console.ReadLine(), out int x1);
                int.TryParse(Console.ReadLine(), out int x2);
                int.TryParse(Console.ReadLine(), out int x3);
                if (x1 == -1 || x2 == -1 || x3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                if (x1 == code / 100 && x2 == code / 10 % 10 && x3 == code % 10)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }
            if (solution == "Код не подобран")
            {
                solution = "Система заблокирована!";
            }
            Console.WriteLine(solution + ", " + attempts);
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int day = a, i = 0; i < n; ++day, ++i)
            {
                if (day == 30)
                {
                    day = 1;
                }
                if (day % 7 == 1)
                {
                    luck = (luck * 1.5 > 100) ? 100 : luck * 1.5;
                }
                else if (day % 7 == 4)
                {
                    luck = (luck > 10) ? luck - 10 : 0;
                }
                else if (day % 7 == 0 && day != 0)
                {
                    luck = (luck < 50) ? 55 : luck;
                }
                else
                {
                    luck = (luck + 5 > 100) ? 100 : luck + 5;
                }
            }
            // end

            return luck;
        }
    }
}