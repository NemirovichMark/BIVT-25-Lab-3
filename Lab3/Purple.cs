using System.Globalization;
using System.Net.Http.Headers;
using System.Xml.Schema;

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
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double Dist = Math.Sqrt(x * x + y * y);
                if (Dist <= (double)r2 && Dist >= (double)r1) count++;
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
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    int d = int.Parse(Console.ReadLine());
                    sum += (double)(a + b + c + d) / 4.0;
                    if (a == 2 || b == 2 || c == 2 || d == 2) count++;
                }

                average = sum / (double)n;
            }
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark;
            int n = exams;
            double score;
            while (exams > 0)
            {
                theory = int.Parse(Console.ReadLine());
                practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85) mark = 5;
                else if (score > 70 && score <= 85) mark = 4;
                else if (score > 50 && score <= 70) mark = 3;
                else mark = 2;
                avgMark += (double)mark / (double)n;
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
                string currentCode = "";
                attempts++;
                for (int i = 0; i < 3; i++)
                {
                    string newElement = Console.ReadLine();
                    if (newElement == "-1")
                    {
                        solution = "Аварийный выход!";
                        return (solution, attempts);
                    }
                    currentCode += newElement;
                }
                if (int.Parse(currentCode) == code)
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
            for (int i = a; i < a + n; i++)
            {
                int currentMonthDay = i % 30;
                if (currentMonthDay != 0)
                {
                    switch (currentMonthDay % 7)
                    {
                        case 1:
                            luck = Math.Min(luck * 1.5, 100);
                            break;
                        case 4:
                            luck = Math.Max(luck - 10, 0);
                            break;
                        case 0:
                            if (luck < 50) luck = 55;
                            break;
                        default:
                            luck = Math.Min(luck + 5, 100);
                            break;
                    }
                }
                else luck = Math.Min(luck + 5, 100);
            }
            // end
            return luck;
        }
    }
}
