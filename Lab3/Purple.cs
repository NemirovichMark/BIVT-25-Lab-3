using System.Globalization;
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

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
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());

                bool a = ((Math.Min(r1 * r1, r2 * r2) < (x * x + y * y)) && ((x * x + y * y) < Math.Max(r1 * r1, r2 * r2)));
                if (a)
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
            int a, b, c, d;
            int sum = 0;
            int numcount = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                sum += a + b + c + d;
                numcount += 4;
                if (a == 2 || b == 2 || c == 2 || d == 2)
                {
                    count++;
                }
            }
            average = (double)sum / (double)numcount;
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int n = exams;
            decimal theory, practice, mark;
            decimal score;

            while (exams > 0)
            {
                decimal.TryParse(Console.ReadLine(), out theory);
                decimal.TryParse(Console.ReadLine(), out practice);
                score = 0.4m * theory + 0.6m * practice;
                System.Console.WriteLine($"{theory} {practice} {score}");

                mark = 2;
                if (score > 50)
                {
                    mark = 3;
                }
                if (score > 70)
                {
                    mark = 4;
                }
                if (score > 85)
                {
                    mark = 5;
                }
                avgMark += (double)mark / n;
                exams--;
            }
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Система заблокирована!";
            int attempts = 0;

            // code here


            for (int i =0; i < limit; i++)
            {
                int a, b, c;
                int.TryParse(Console.ReadLine(), out a);
                int.TryParse(Console.ReadLine(), out b);
                int.TryParse(Console.ReadLine(), out c);
                attempts++;

                if ((a == -1) || (b == -1) || (c == -1))
                {
                    solution = "Аварийный выход!";
                    break;
                }
                else
                {
                    int num = int.Parse($"{a}{b}{c}");

                    if (code == num)
                    {
                        solution = "Доступ разрешен!";
                        break;
                    }
                }
                
            }

            System.Console.WriteLine($"{solution} {attempts}");
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            List<int> lucky = new List<int>{1,8,15,22,29};
            List<int> unlucky = new List<int>{4,11,18,25};
            List<int> chance = new List<int>{7,14,21,28};

            for (int i = a; i < a + n; i++)
            {
                int day_type = 0;
                if (lucky.Contains(i)) day_type = 1;
                if (unlucky.Contains(i)) day_type = 2;
                if (chance.Contains(i)) day_type = 3;
                switch (day_type)
                {
                    case 1:
                        luck *= 1.5;
                        goto case 7;
                    case 2:
                        luck -= 10;
                        goto case 7;
                    case 3:
                        if (luck < 50) luck = 55;
                        break;
                    default:
                        luck += 5;
                        goto case 7;
                    case 7:
                        if (luck > 100) luck = 100;
                        if (luck <= 0) luck = 0;
                        break;
                }

                // //if-else solution
                // if (lucky.Contains(i))
                // {
                //     luck *= 1.5;
                // }

                // else if (unlucky.Contains(i))
                // {
                //     luck -= 10;
                // }

                // else if (chance.Contains(i))
                // {
                //     if (luck < 50)
                //     {
                //         luck = 55;
                //     }
                // }
                // else
                // {
                //     luck += 5;
                // }

                // //bring luck back in limits
                // if (luck > 100)
                // {
                //     luck = 100;
                // }
                // if (luck < 0)
                // {
                //     luck = 0;
                // }
            }
            // end

            return luck;
        }
    }
}