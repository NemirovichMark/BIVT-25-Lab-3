using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                int Distance = x * x + y * y;
                r1 = r1 * r1;
                r2 = r2 * r2;
                if (Distance > r1 && Distance <= r2)
                {
                    count++;
                }
            }
            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            double sum = 0;
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
                sum += a + b + c + d;
            }
            if (n != 0)
            {
                average = sum / (double)n / 4;
            }

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            int n = exams;
            while (exams > 0)
            {
                int theory = int.Parse(Console.ReadLine());
                int practice = int.Parse(Console.ReadLine());
                double score = 0.4 * theory + 0.6 * practice;
                int mark = exams;
                if ((score < 70) && (score > 50))
                {
                    mark = 3;
                }
                if ((score > 70) && (score < 85))
                {
                    mark = 4;
                }
                if (score > 85)
                {
                    mark = 5;
                }
                if (score < 50)
                {
                    mark = 2;
                }
                avgMark += (double)mark / n;
                exams--;
            }
            return avgMark;

        }
        public (string solution, int attempts) 
            Task4(int code,int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            while (attempts < limit)
            {
                int.TryParse(Console.ReadLine(), out int a);
                int.TryParse(Console.ReadLine(), out int b);
                int.TryParse(Console.ReadLine(), out int c);
                attempts++;
                if (a == -1 || b == -1 || c == -1)
                {
                    solution = "Аварийный выход!";
                    return (solution, attempts);
                }
                if (a == code / 100 && b == code / 10 % 10 && c == code % 10)
                {
                    solution = "Доступ разрешен!";
                    return (solution, attempts);
                }
            }
            solution = "Система заблокирована!";

            return (solution, attempts);

        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            for (int i = 0; i < n; i++)
            {
                int day = (a + i - 1) % 29 + 1;
                if (day == 1 || day == 8 || day == 15 || day == 22 || day == 29)
                {
                    luck *= 1.5;
                    if (luck > 100)
                    {
                        luck = 100;
                    }
                }
                else if (day == 4 || day == 11 || day == 18 || day == 25)
                {
                    luck -= 10;
                    if (luck < 0)
                    {
                        luck = 0;
                    }
                }
                else if (day == 7 || day == 14 || day == 21 || day == 28)
                {
                    if (luck < 50)
                    {
                        luck = 55;
                    }
                }
                else
                {
                    luck += 5;
                    if (luck > 100)
                    {
                        luck = 100;
                    }
                }
            }

            return luck;
        }
    }
}