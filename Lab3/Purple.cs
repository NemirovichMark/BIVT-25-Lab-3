using System.ComponentModel;
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
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (r1 * r1 <= x*x + y*y && x*x + y*y <= r2 * r2) count++;
            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here

            for (int i = 1; i <= n; i++)
            {
                int a1 = int.Parse(Console.ReadLine());
                int a2 = int.Parse(Console.ReadLine());
                int a3 = int.Parse(Console.ReadLine());
                int a4 = int.Parse(Console.ReadLine());
                average += a1 + a2 + a3 + a4;
                if (a1 == 2 || a2 == 2 || a3 == 2 || a4 == 2) count++;

            }
            average = average / count / 4;
            
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            
            double mark;
            double n = exams;
            while (exams > 0)
            {
                double theory = double.Parse(Console.ReadLine());
                double practice = double.Parse(Console.ReadLine());
                double score = 0.4 * theory + practice * 0.6;
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
            int b1 = code / 100;
            int b2 = code / 10 % 10;
            int b3 = code % 10;

            
            for (; attempts <= limit; attempts++)
            {
                int a1 = int.Parse(Console.ReadLine());
                if (a1 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int a2 = int.Parse(Console.ReadLine());
                if (a2 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int a3 = int.Parse(Console.ReadLine());
                if (a3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                if (a1 == b1 && a2 == b2 && a3 == b3)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
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

            for (int i = 0; i < n; i ++)
            {
                int b = (a + i - 1) % 29 + 1;
                switch (b)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck = Math.Min(1.5 * luck, 100);
                        break;
                    
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck = Math.Max(luck-10, 0);
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
                        luck = Math.Min(luck+5, 100);
                        break; 
                 
                }
            }
            
            // end

            return luck;
        }
    }
}
