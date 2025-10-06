using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            double x, y;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                double.TryParse(Console.ReadLine(), out y);
                double d = x * x + y * y;
                if (r1 * r1 <= d && r2 * r2 >= d)
                {
                    count++;
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
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int a);
                int.TryParse(Console.ReadLine(), out int b);
                int.TryParse(Console.ReadLine(), out int c);
                int.TryParse(Console.ReadLine(), out int d);
                if (a == 2 || b == 2 || c == 2 || d == 2)
                {
                    count++;
                }
                average += a + b + c + d;
            }
            if (n != 0)
            {
                average /= (4 * n);
            }
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark, n = exams;
            double score;
            while (exams > 0)
            {
                int.TryParse(Console.ReadLine(), out theory);
                int.TryParse(Console.ReadLine(), out practice);
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85)
                {
                    mark = 5;
                } else if (score > 70)
                {
                    mark = 4;
                } else if (score > 50)
                {
                    mark = 3;
                } else
                {
                    mark = 2;
                }
                avgMark += mark / n;
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
            while (attempts < limit)
            {
                int.TryParse(Console.ReadLine(), out int a);
                int.TryParse(Console.ReadLine(), out int b);
                int.TryParse(Console.ReadLine(), out int c);
                attempts++;
                if (a == -1 || b == -1  || c == -1)
                {
                    solution = "Аварийный выход!";
                    return (solution, attempts);
                } else if (a == code / 100 &&  b == (code / 10) % 10 && c == code % 10)
                {
                    solution = "Доступ разрешен!";
                    return (solution, attempts);
                }
            }
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
                switch (a)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck *= 1.5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck -= 10;
                        if (luck < 0)
                        {
                            luck = 0;
                        }
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50)
                            luck = 55;
                        break;
                    default:
                        luck += 5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;
                }
                a++;
                if (a > 30)
                {
                    a = 1;
                }
            }
            // end

            return luck;
        }
    }
}