using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                double x, y;
                double.TryParse(Console.ReadLine(), out x);
                double.TryParse(Console.ReadLine(), out y);
                double d = Math.Pow(Math.Pow(x, 2) + Math.Pow(y, 2), 0.5);
                if (d >= r1 && d <= r2)
                    count++;
            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
            double s = 0;
            double k = 0;
            for (int i = 1; i <= n; i++)
            {
                int a, b, c, d;
                int.TryParse(Console.ReadLine(), out a);
                int.TryParse(Console.ReadLine(), out b);
                int.TryParse(Console.ReadLine(), out c);
                int.TryParse(Console.ReadLine(), out d);
                s = s + a + b + c + d;
                k++;
                if (a == 2 || b == 2 || c == 2 || d == 2)
                    count++;
            }
            if (n != 0)
                average = s / k / 4;
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practise;
            double mark;
            int n = exams;
            double score = 0;
            while (exams > 0)
            {
                int.TryParse(Console.ReadLine(), out theory);
                int.TryParse(Console.ReadLine(), out practise);
                score = 0.4 * theory + 0.6 * practise;
                if (score > 85)
                    mark = 5;
                else if (score > 70)
                    mark = 4;
                else if (score > 50)
                    mark = 3;
                else
                    mark = 2;
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
            for (int i = 1; i <= limit; i++)
            {
                solution = "Система заблокирована!";
                attempts = i;
                int a, b, c;
                int.TryParse(Console.ReadLine(), out a);
                int.TryParse(Console.ReadLine(), out b);
                int.TryParse(Console.ReadLine(), out c);
                if (a == -1 || b == -1 || c == -1)
                {
                    solution = "Аварийный выход!";
                    attempts = i;
                    break;
                }
                else if (a * 100 + b * 10 + c == code)
                {
                    solution = "Доступ разрешен!";
                    attempts = i; 
                    break;
                }
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
                switch(i)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        if (luck * 1.5 <= 100)
                            luck *= 1.5;
                        else
                            luck = 100;
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        if (luck >= 10)
                            luck -= 10;
                        else
                            luck = 0;
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50)
                            luck = 55;
                        break;
                    default:
                        if (luck + 5 <= 100)
                            luck += 5;
                        else
                            luck = 100;
                        break;
                }
            }
            // end

            return luck;
        }
    }
}