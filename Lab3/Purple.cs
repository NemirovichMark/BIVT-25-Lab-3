using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
                    count++;
                
            }

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = int.Parse(Console.ReadLine());
                int w = int.Parse(Console.ReadLine());
                average += (x + y + z + w);
                if (x == 2 || y == 2 || z == 2 || w == 2)
                    count+=1;
            }
            average = average / (n * 4);

            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            int mark, n = exams;
            double score;
            while (exams > 0)
            {
                int theory = int.Parse(Console.ReadLine());
                int practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85) mark = 5;
                else if (score > 70) mark = 4;
                else if (score > 50) mark = 3;
                else mark = 2;
                avgMark += (double) mark / n;
                exams--;
            }
            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Система заблокирована!";
            int attempts = 0;
            for (int i = 1; i <= limit; i++)
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                string s3 = Console.ReadLine();
                attempts++;
                if (s1 == "-1" || s2 == "-1" || s3 == "-1")
                {
                    solution = "Аварийный выход!";
                    return (solution, attempts);
                    break;
                }

                if ((s1 + s2 + s3) == Convert.ToString(code))
                {
                    return ("Доступ разрешен!", attempts);
                }
                
            }
            // code here

            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            for (int i = a; i < a +  n; i++)
            {
                switch (i)
                {
                    case 1 or 8 or 15 or 22 or 29:
                        luck = Math.Min(luck * 1.5, 100);
                        break;
                    case 4 or 11 or 18 or 25:
                        luck = Math.Max(luck - 10, 0);
                        break;
                    case 7 or 14 or 21 or 28:
                        if (luck < 50) luck = 55;
                        break;
                    default:
                        luck = Math.Min(luck + 5, 100);
                        break;
                }
            }
            // code here

            // end

            return luck;
        }
    }
}