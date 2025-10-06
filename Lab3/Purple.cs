using System.Net.Http.Headers;
using System.Threading.Tasks.Sources;

namespace Lab3
{
    public class Purple
    {
        private double Min(double a, double b)
        {
            if (a >= b)
                return b;
            return a;
        }
        private double Max(double a, double b)
        {
            if (a >= b)
                return a;
            return b;
        }
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double x, y;
                Double.TryParse(Console.ReadLine(), out x);
                Double.TryParse(Console.ReadLine(), out y);
                double r = x * x + y * y;
                if (r >= r1 * r1 && r <= r2 * r2)
                    count++;
            }
            //Console.WriteLine(count);
            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            bool flag = false;
            for (int i = 0; i < 4 * n; i++)
            {
                if ((i & 3) == 0)
                {
                    count += flag ? 1 : 0;
                    flag = false;
                }

                Int32.TryParse(Console.ReadLine(), out int cur);
                if (cur == 2)
                    flag = true;
                average += cur;

            }
            count += flag ? 1 : 0;
            if (n > 0)
                average /= 4 * n;
            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            int theory, practice, mark, n = exams;
            double score;

            while (exams > 0)
            {
                Int32.TryParse(Console.ReadLine(), out theory);
                Int32.TryParse(Console.ReadLine(), out practice);
                score = 0.4 * theory + 0.6 * practice;
                switch (score)
                {
                    case > 85.0:
                        mark = 5;
                        break;
                    case > 70.0:
                        mark = 4;
                        break;
                    case > 50.0:
                        mark = 3;
                        break;
                    default:
                        mark = 2;
                        break;
                }

                avgMark += (double)(mark) / n;
                --exams;
            }

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = limit;

            while (attempts > 0)
            {
                --attempts;
                Int32.TryParse(Console.ReadLine(), out int a);
                if (a == -1)
                    return ("Аварийный выход!", limit - attempts);
                Int32.TryParse(Console.ReadLine(), out int b);
                if (b == -1)
                    return ("Аварийный выход!", limit - attempts);
                Int32.TryParse(Console.ReadLine(), out int c);
                if (c == -1)
                    return ("Аварийный выход!", limit - attempts);
                if (code == 100 * a + 10 * b + c)
                    return ("Доступ разрешен!", limit - attempts);
            }
            solution = "Система заблокирована!";
            return (solution, limit - attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            for (int i = a; i < a + n; i++)
            {
                switch (i % 7)
                {
                    case 1 when (1 <= i && i <= 29):
                        luck = Min(luck * 1.5, 100);
                        break;
                    case 4 when (1 <= i && i <= 29):
                        luck = Max(luck - 10, 0);
                        break;
                    case 0 when (1 <= i && i <= 29):
                        luck = (luck < 50 ? 55 : luck);
                        break;
                    default:
                        luck = Min(luck + 5, 100);
                        break;
                }
            }
            return luck;
        }
    }
}