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
            for (int i = 0; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
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
            int count = 0;
            double average = 0;

            // code here
            int mark1, mark2, mark3, mark4;
            for (int i = 0; i < n; i++)
            {
                mark1 = Convert.ToInt32(Console.ReadLine());
                mark2 = Convert.ToInt32(Console.ReadLine());
                mark3 = Convert.ToInt32(Console.ReadLine());
                mark4 = Convert.ToInt32(Console.ReadLine());
                if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
                {
                    count++;
                }
                average += (mark1 + mark2 + mark3 + mark4) / 4.0;
            }
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
                theory = Convert.ToInt32(Console.ReadLine());
                practice = Convert.ToInt32(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85)
                {
                    mark = 5;
                }
                else if (score > 70)
                {
                    mark = 4;
                }
                else if (score > 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
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
            string first, second, third;
            string StringCode = Convert.ToString(code);
            for (int i = 1; i <= limit; i++)
            {
                first = (Console.ReadLine());
                if (first == "-1")
                {
                    solution = "Аварийный выход!";
                    break;
                }
                second = (Console.ReadLine());
                if (second == "-1")
                {
                    solution = "Аварийный выход!";
                    break;
                }
                third = (Console.ReadLine());
                if (third == "-1")
                {
                    solution = "Аварийный выход!";
                    break;
                }
                if (Convert.ToChar(first) == StringCode[0] 
                    && Convert.ToChar(second) == StringCode[1] 
                    && Convert.ToChar(third) == StringCode[2])
                {
                    solution = "Доступ разрешен!";
                    break;
                }
                attempts = i;
            }
            attempts--;
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
            for (int i = a; i < a + n; i++)
            {
                if (i < 30 && (i - 1) % 7 ==0)
                {
                    if (1.5 * luck <= 100)
                    {
                        luck *= 1.5;
                    }
                    else
                    {
                        luck = 100;
                    }
                }
                else if (i < 26 && (i - 4) % 7 == 0)
                {
                    if (luck - 10 >= 0)
                    {
                        luck -= 10;
                    }
                    else
                    {
                        luck = 0;
                    }
                }
                else if (i > 0 && i < 29 && i % 7 == 0)
                {
                    if (luck < 50)
                    {
                        luck = 55;
                    }
                }
                else
                {
                    if (luck <= 95)
                    {
                        luck += 5;
                    }
                    else
                    {
                        luck = 100;
                    }
                }
            }
            // end

            return luck;
        }
    }
}
