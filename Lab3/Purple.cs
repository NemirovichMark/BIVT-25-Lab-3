using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i = 0; i<n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                
                int Distance = x*x + y*y;
                 r1 = r1 * r1;
                 r2 = r2 * r2;
                if (Distance>r1 && Distance<=r2)
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
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int g1 = int.Parse(Console.ReadLine());
                    int g2 = int.Parse(Console.ReadLine());
                    int g3 = int.Parse(Console.ReadLine());
                    int g4 = int.Parse(Console.ReadLine());
                    average = average + g1 + g2 + g3 + g4;
                    if ((g1 == 0) || (g2 == 0) || (g3 == 0) || (g4 == 0))
                    {
                        count++;
                    }
                }
            }
            else
            {
                return(count, average);
            }
            average = average / (4 * n);
                // end

                return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int n = exams;
            while (exams > 0)
            {
                int theory = int.Parse(Console.ReadLine());
                int practice = int.Parse(Console.ReadLine());
                double score = 0.4 * theory + 0.6 * practice;
                int mark = exams;
                if ((score < 70) && (score > 50))
                {
                    mark = 3;
                }
                if ((score > 70) && (score < 85))
                {
                    mark = 4;
                }
                if (score > 85)
                {
                    mark = 5;
                }
                if (score < 50)
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
            while (attempts < limit)
            {
                attempts++;
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());
                if (((num1 == -1) || (num2 == -1) || (num3 == -1)))
                {
                    solution = "Аварийный выход!";
                }
                // end
            }
            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = 0; i<n; i++)
            {
                int day = (a + i - 1) % 29 + 1;
                if (day == 1 || day == 8 || day == 15 || day == 22 || day == 29)
                {
                    luck *= 1.5;
                    if (luck > 100)
                    {
                        luck = 100;
                    }
                }
                else if (day == 4 || day == 11 || day == 18 || day == 25)
                {
                    luck -= 10;
                    if (luck < 0)
                    {
                        luck = 0;
                    }
                }
                else if (day == 7 || day == 14 || day == 21 || day == 28)
                {
                    if (luck < 50)
                    {
                        luck = 55;
                    }
                }
                else
                {
                    luck += 5;
                    if (luck > 100)
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