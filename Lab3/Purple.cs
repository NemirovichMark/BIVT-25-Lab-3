using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;

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
                double x, y;
                string? v1 = Console.ReadLine();
                string? v2 = Console.ReadLine();
                bool res1 = double.TryParse(v1, out x);
                bool res2 = double.TryParse(v2, out y);
                if (res1 && res2)
                {
                    if ((x * x + y * y) <= r2 * r2 && (x * x + y * y) >= r1 * r1)
                    {
                        count++;
                    }
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
                int x, y, z, w;
                string? s1 = Console.ReadLine();
                string? s2 = Console.ReadLine();
                string? s3 = Console.ReadLine();
                string? s4 = Console.ReadLine();
                bool v1 = int.TryParse(s1, out x), v2 = int.TryParse(s2, out y), v3 = int.TryParse(s3, out z), v4 = int.TryParse(s4, out w);
                if (v1 && v2 && v3 && v4)
                { 
                    int total = x + y + z + w;
                    if (x == 2 || y == 2 || z == 2 || w == 2)
                    {
                        count++;
                    }
                    average += total;
                }

            }
            average /= (double)(n * 4);
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
                string? s1 = Console.ReadLine();
                string? s2 = Console.ReadLine();
                bool f1 = int.TryParse(s1, out theory);
                bool f2 = int.TryParse(s2, out practice);
                if (f1 && f2)
                {
                    score = 0.4 * theory + 0.6 * practice;
                    switch (score)
                    {
                        case > 85:
                            mark = 5;
                            break;
                        case > 70:
                            mark = 4;
                            break;
                        case > 50:
                            mark = 3;
                            break;
                        default:
                            mark = 2;
                            break;

                    }
                    avgMark += (double)mark / n;
                    exams--;
                }
            }
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here
            int temp = 0;
            while (limit > 0)
            {
                limit--;
                attempts++;
                int x, y, z;
                string? s1 = Console.ReadLine(), s2 = Console.ReadLine(), s3 = Console.ReadLine();
                bool f1 = int.TryParse(s1, out x), f2 = int.TryParse(s2, out y), f3 = int.TryParse(s3, out z);
                if (code / 100 == x && code / 10 % 10 == y && code % 10 == z)
                {
                    solution = "Доступ разрешен!";
                    temp++;
                    break;
                }
                else if (x == -1 || y == -1 || z == -1)
                {
                    solution = "Аварийный выход!";
                    temp++;
                    break;
                }
            }
            if (temp == 0)
            {
                solution = "Система заблокирована!";
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
                        if (luck >= 10)
                        {
                            luck -= 10;
                        }
                        else
                        {
                            luck = 0;
                        }
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50)
                        {
                            luck = 55;
                        }
                        break;
                    default:
                        luck += 5;
                        if (luck >= 100)
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