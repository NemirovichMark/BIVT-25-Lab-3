using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;
            double x, y, dist;
            // code here
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                dist = (x * x) + y * y;
                if (r1*r1<=dist && r2*r2>=dist)
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
            int m1, m2, m3, m4;
            for (int i = 0; i<n; i++)
            {
                m1=Convert.ToInt32((Console.ReadLine()));
                m2=Convert.ToInt32((Console.ReadLine()));
                m3=Convert.ToInt32((Console.ReadLine()));
                m4=Convert.ToInt32((Console.ReadLine()));
                if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
                    count++;
                average += (m1 + m2 + m3 + m4) / 4.0;
            }
            average /= n;
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark, n = exams;
            double score;
            while (exams> 0)
            {
                theory = Convert.ToInt32((Console.ReadLine()));
                practice = Convert.ToInt32((Console.ReadLine()));
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85)
                    mark = 5;
                else if (score > 70)
                    mark = 4;
                else if (score > 50)
                    mark = 3;
                else
                    mark = 2;
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
            solution = "Система заблокирована!";
            int d1, d2, d3;
            for (;attempts<limit;)
            {
                attempts++;
                d1=Convert.ToInt32((Console.ReadLine()));
                if (d1 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                d2=Convert.ToInt32((Console.ReadLine()));
                if (d2 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                d3=Convert.ToInt32((Console.ReadLine()));
                if (d3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                if (d1*100+d2*10+d3==code)
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
            for (int i = a; i<a+n; i++)
            {
                if (i % 7 == 1)
                {
                    luck *= 1.5;
                }
                else if (i % 7 == 4)
                {
                    luck -= 10;
                }
                else if (i % 7 == 0 && i>0)
                {
                    luck = luck < 50 ? 55 : luck;
                }
                else
                {
                    luck += 5;
                }
                if (luck < 0)
                    luck = 0;
                if (luck > 100)
                    luck = 100;
            }
            // end

            return luck;
        }
    }
}
