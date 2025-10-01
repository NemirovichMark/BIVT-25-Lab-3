using Microsoft.Win32.SafeHandles;
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
                double x = Convert.ToDouble(Console.ReadLine()!);
                double y = Convert.ToDouble(Console.ReadLine()!);
                double rad = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (rad >= r1 && rad <= r2)
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
            int gradeSum = 0;
            for (int student = 0; student < n; student++)
            {
                bool failed = false;
                for (int i = 0; i < 4; i++)
                {
                    int grade = int.Parse(Console.ReadLine()!);
                    gradeSum += grade;
                    if (grade == 2)
                    {
                        failed = true;
                    }
                }
                if (failed) count++;
            }
            average = (double)gradeSum / (4.0 * n);
            // end
            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int n = exams;
            while (true)
            {
                if (exams <= 0) return avgMark;
                int theory = int.Parse(Console.ReadLine()!);
                int practice = int.Parse(Console.ReadLine()!);
                double score = 0.4 * theory + 0.6 * practice;
                int mark;
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
            while (true)
            {
                if (attempts >= limit)
                {
                    solution = "Система заблокирована!";
                    break;
                }
                int attempt_code = 0;
                for (int i = 0; i < 3; i++)
                {
                    int digit = int.Parse(Console.ReadLine()!);
                    attempt_code += (int)Math.Pow(10, 2 - i) * digit;
                    if (digit == -1)
                    {
                        solution = "Аварийный выход!";
                        return (solution, attempts);
                    }
                }
                if (attempt_code == code)
                {
                    solution = "Досткп разрешен!";
                    break;
                }
                attempts++;
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
                    case 1: case 8: case 15: case 22: case 29:
                        luck = Math.Min(100, luck * 1.5);
                        break;
                    case 4: case 11: case 18: case 25:
                        luck = Math.Max(0, luck - 10);
                        break;
                    case 7: case 14: case 21: case 28:
                        if (luck < 50) luck = 55;
                        break;
                    default:
                        luck = Math.Min(100, luck + 5);
                        break;
                }
            }
            // end

            return luck;
        }
    }
}
