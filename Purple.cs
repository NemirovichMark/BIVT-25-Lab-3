using Microsoft.VisualBasic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2) // работает
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                double d2 = x * x + y * y;
                if ((d2 >= r1*r1) && (d2 <= r2*r2))
                {
                    count++;
                }
            }
            Console.WriteLine("ответ " + count);
            // end

            return count;
        }
        public (int count, double average) Task2(int n) // работает
        {
            int count = 0;
            double average = 0;

            // code here
            double sum = 0;
            int low_rate = 0;
            for (int student = 1; student <= n; student++)
            {
                bool low_rated = false;
                for (int student_marks = 1; student_marks <= 4; student_marks++)
                {
                    int.TryParse(Console.ReadLine(), out int mark);
                    if ((mark == 2) && (!low_rated))
                    {
                        low_rate++;
                        low_rated = true;
                    }
                    sum += mark;
                }
            }
            count = low_rate;
            average = sum / (n*4);
            // end

            return (count, average);
        }
        public double Task3(int exams) // работает
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
                switch (score)
                {
                    case > 85: mark = 5; break; 
                    case > 70: mark = 4; break; 
                    case > 50: mark = 3; break; 
                    default: mark = 2; break;
                }
                avgMark += (double)mark / n;
                exams--;
            }
                // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit) // работает
        {
            string solution = "Код не подобран";
            int attempts = 0;
            // code here
            bool f = false;
            while (attempts < limit) {
                string n1 = Console.ReadLine();
                string n2 = Console.ReadLine();
                string n3 = Console.ReadLine();
                string variant = n1 + n2 + n3;
                attempts++;
                if ((n1 == "-1") || (n2 == "-1") || (n3 == "-1"))
                {
                    solution = "Аварийный выход!";
                    f = true;
                    break;
                }
                if (variant == code.ToString())
                {
                    solution = "Доступ разрешен!";
                    f = true;
                    break;
                }
            }
            if (!f)
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
            for (int day = a; day < a+n; day++)
            {
                switch (day)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        if (luck * 1.5 <= 100)
                        {
                            luck *= 1.5;
                        }
                        else luck = 100; break;

                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        if (luck - 10 >= 0)
                        {
                            luck -= 10;
                        }   
                        else luck = 0; break;
 
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50)
                        {
                            luck = 55;
                        }
                        break;
                    default: if (luck + 5 <= 100)
                        {
                            luck += 5;
                        }
                        else
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