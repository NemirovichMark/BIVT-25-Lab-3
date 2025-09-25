using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            double x, y;
            for (int i=1; i<=n; i++)
            {
                x = double.Parse(Console.ReadLine()); ;
                y = double.Parse(Console.ReadLine()); ;
                if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            {
                int count = 0;
                double average = 0;

                // code here
                int m1, m2, m3, m4;
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    m1 = int.Parse(Console.ReadLine());
                    m2 = int.Parse(Console.ReadLine());
                    m3 = int.Parse(Console.ReadLine());
                    m4 = int.Parse(Console.ReadLine());
                    if ((m1 == 2) || (m2 == 2) || (m3 == 2) || (m4 == 2))
                    {
                        count++;
                    }
                    sum += m1 + m2 + m3 + m4;
                }
                if (n != 0)
                {
                    average =(double)sum / (n * 4);
                }
                // end

                return (count, average);
            }
        }
        public double Task3(int exams)
        {
            double score, avgMark = 0;

            // code here
            int theory, practice, mark, n = exams;
            while (exams > 0)
            {
                theory = int.Parse(Console.ReadLine());
                practice = int.Parse(Console.ReadLine());
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
                avgMark += (double)mark/n;
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
            int d1, d2, d3;
            for (int i = 1; i <= limit; i++)
            {
                attempts++;
                d1 = int.Parse(Console.ReadLine());
                if (d1 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                d2 = int.Parse(Console.ReadLine());
                if (d2 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                d3 = int.Parse(Console.ReadLine());
                if (d3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                if (d1 * 100 + d2 * 10 + d3 == code)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }
            if (solution == "Код не подобран")
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
            for (int i=0; i<n; i++)
            {
                switch (a+i)
                {
                    case 1 or 8 or 15 or 22 or 29:
                        luck = luck * 1.5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;
                    case 4 or 11 or 18 or 25:
                        luck = luck - 10;
                        if (luck<0)
                        {
                            luck = 0;
                        }
                        break;
                    case 7 or 14 or 21 or 28:
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
