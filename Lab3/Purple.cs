using System.ComponentModel;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i=0; i<n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double rr = Math.Pow(x, 2) + Math.Pow(y, 2);
                double r = Math.Sqrt(rr);
                if (r>=r1 && r <= r2)
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
            for (int i=0; i<n; i++)
            {
                bool otl = true;
                for (int j=0; j<4; j++)
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x <= 2)
                    {
                        otl = false;
                    }
                    sum += x;
                    
                }
                if (otl == false)
                {
                    count++;
                }
            }
            if (!(n == 0)) { average = Math.Round(sum / (n * 4), 5); }
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
                if (score > 85)
                {
                    mark = 5;
                } else if (score > 70)
                {
                    mark = 4;
                } else if (score > 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
                }
                avgMark += Math.Round((double)mark / (double)n, 5);
                exams--;
            }
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;
            int x1 = code / 100;
            int y1 = (code / 10)%10;
            int z1 = code % 10;
            // code here
            while (limit > 0 && solution== "Код не подобран")
            {
                attempts++;
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = int.Parse(Console.ReadLine());
                if (x==-1 || y==-1 || z == -1)
                {
                    solution = "Аварийный выход!";
                }
                else if (x == x1 && y == y1 && z == z1)
                {
                    solution = "Доступ разрешен!";
                }
                limit--;
            }
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
                switch (i)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck = luck * 1.5;
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck = luck - 10;
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50)
                        {
                            luck = 55;
                        }
                        break;
                    default:
                        luck = luck + 5;
                        break;
                }
                if (luck < 0)
                {
                    luck = 0;
                }
                if (luck > 100)
                {
                    luck = 100;
                }
            }
            // end

            return luck;
        }
    }
}