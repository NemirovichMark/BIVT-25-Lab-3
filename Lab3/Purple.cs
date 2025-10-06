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
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if ((x*x + y*y >= r1*r1) && (x*x + y*y <= r2 * r2))
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
            for (int i = 0; i < n; i++)
            {
                bool b = false;
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 2)
                {
                    b = true;
                }
                average += x;
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 2)
                {
                    b = true;
                }
                average += x;
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 2)
                {
                    b = true;
                }
                average += x;
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 2)
                {
                    b = true;
                }
                average += x;
                if (b)
                {
                    count++;
                }
            }
            average /= n * 4;
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

                switch (score)
                {
                    case double x when x > 85:
                        mark = 5; break;
                    case double x when x > 70:
                        mark = 4; break;
                    case double x when x > 50:
                        mark = 3; break;
                    default:
                        mark = 2; break;
                }

                avgMark += Convert.ToDouble(mark) / n;
                exams--;
            }
            Console.WriteLine(avgMark);
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Система заблокирована!";
            int attempts = 0;

            // code here
            for (int i = 0; i < limit; i++)
            {
                attempts++;
                string str = "";
                string x = Console.ReadLine();
                if (x == "-1")
                {
                    solution = "Аварийный выход!";
                    break;
                }
                str += x;
                x = Console.ReadLine();
                if (x == "-1")
                {
                    solution = "Аварийный выход!";
                    break;
                }
                str += x;
                x = Console.ReadLine();
                if (x == "-1")
                {
                    solution = "Аварийный выход!";
                    break;
                }
                str += x;
                if (str == Convert.ToString(code))
                {
                    solution = "Доступ разрешен!";
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
            for (int i = 0; i < n; i++)
            {
                switch (a++)
                {
                    case int x when x % 7 == 1:
                        luck = Math.Min(100, luck * 1.5); break;
                    case int x when x % 7 == 4:
                        luck = Math.Max(0, luck - 10); break;
                    case int x when x % 7 == 0 && x != 0:
                        if (luck < 50)
                        {
                            luck = 55;
                        }
                        break;
                    default:
                        luck += 5; break;
                }
            }
            // end

            return luck;
        }
    }
}
