using System.Globalization;
using System.Net.Http.Headers;

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
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                double dist = Math.Sqrt(x * x + y * y);
                if (dist <= (double)r2 && dist >= (double)r1)
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
            double sum = 0;
            // code here
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
                for (int j = 0; j < 4; j++)
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    sum += x;
                    if (x == 2) flag = true;
                }
                if (flag) count++;
            }
            // end
            average = sum / (4 * n);
            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark, n = exams;
            double score = 0;
            while (exams > 0)
            {
                theory = Convert.ToInt32(Console.ReadLine());
                practice = Convert.ToInt32(Console.ReadLine());
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
                attempts++;
                int n1 = Convert.ToInt32(Console.ReadLine());
                if (n1 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int n3 = Convert.ToInt32(Console.ReadLine());
                if (n3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                if (code == n1 * 100 + n2 * 10 + n3)
                {
                    solution = "Доступ разрешен!";
                    break;
                }

            }
            if (solution == "Код не подобран") solution = "Система заблокирована!";
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = a; i < a + n; i++)
            {
                switch (i % 7)
                {
                    case 1: 
                        luck *= 1.5;
                        luck = Math.Min(100.0, luck);
                        break;
                    case 4:
                        luck -= 10;
                        luck = Math.Max(luck, 0.0);
                        break;
                    case 0:
                        if (i == 0)
                        {
                            luck += 5;
                            luck = Math.Min(100, luck);
                            break;
                        }
                        if (luck < 50) luck = 55;
                        break;
                    default:
                        luck += 5;
                        luck = Math.Min(100, luck);
                        break;
                }
            }
            // end

            return luck;
        }
    }
}
