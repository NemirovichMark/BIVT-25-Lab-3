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
                var line = Console.ReadLine();
                var items = line.Split(' ');
                double x = double.Parse(items[0]);
                double y = double.Parse(items[1]);
                if (Math.Pow(x, 2) + Math.Pow(y, 2) >= r1 * r1 && Math.Pow(x, 2) + Math.Pow(y, 2) <= r2 * r2)
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
                var line = Console.ReadLine();
                var items = line.Split(' ');
                int x1 = int.Parse(items[0]);
                int x2 = int.Parse(items[1]);
                int x3 = int.Parse(items[2]);
                int x4 = int.Parse(items[3]);
                if (x1 ==2 || x2 == 2 || x3 == 2 || x4 == 2)
                {
                    average += 1;
                }
                
            }

            // end

                return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            int theory = 0;
            int practice = 0;
            int mark = 0;
            int n = exams;
            double score = 0;
            double avgMark = 0;

            // code here
            while (exams > 0)
            {
                theory = int.Parse(Console.ReadLine());
                practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score >= 85)
                {
                    mark = 5;
                }
                else if (score >= 70)
                {
                    mark = 4;
                }
                else if (score >= 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
                }
                avgMark += mark;
                exams--;
            }

            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Система заблокирована!";
            int attempts = 0;

            // code here
            for (attempts = 0; attempts < limit; attempts++)
            {
                attempts++;
                int input = int.Parse(Console.ReadLine());
                if (input == code)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
                else if (input == -1)
                {
                    solution = "Аварийный выход!";
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
            for (int i = a; i < n + a; i++)
            {
                switch (i % 31)
                {
                    case 1: case 8: case 15: case 22: case 29:
                        luck *= 1.5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;
                    case 4: case 11: case 18: case 25:
                        luck -= 10;
                        if (luck < 0)
                        {
                            luck = 0;
                        }
                        break;
                    case 7: case 14: case 21: case 28:
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