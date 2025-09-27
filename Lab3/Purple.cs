using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if ((Math.Sqrt(x * x + y * y) >= r1) && (Math.Sqrt(x * x + y * y) <= r2))
                {
                    answer++;
                }
            }

            return answer;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int o1 = int.Parse(Console.ReadLine());
                    int o2 = int.Parse(Console.ReadLine());
                    int o3 = int.Parse(Console.ReadLine());
                    int o4 = int.Parse(Console.ReadLine());
                
                    average += o1;
                    average += o2;
                    average += o3;
                    average += o4;
            
                    if ((o1 == 2) || (o2 == 2) || (o3 == 2) || (o4 == 2))
                    {
                        count++;
                    }
                }
            }
            else
            {
                return (count, average);
            }

            average /= (4 * n);

            return (count, average);
        }
        public double Task3(int exams)
        {
            int n = exams;
            double avgMark = 0;

            while (exams > 0)
            {
                int theory = int.Parse(Console.ReadLine());
                int practice = int.Parse(Console.ReadLine());

                double score = 0.4 * theory + 0.6 * practice;
    
                int mark = exams;
    
                if (score > 50 && score <= 70)
                {
                    mark = 3;
                }

                if (score > 70 && score <= 85)
                {

                    mark = 4;
                }

                if (score > 85)
                {
                    mark = 5;
                }
                if (score <= 50)
                {
                    mark = 2;
                }

                avgMark += (double)mark / n;
                exams--;
            }

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "";
            int attempts = 0;
            
            while (attempts < limit)
            {
                attempts++;

                int d1 = int.Parse(Console.ReadLine());
                int d2 = int.Parse(Console.ReadLine());
                int d3 = int.Parse(Console.ReadLine());
                
                if (d1 == -1 || d2 == -1 || d3 == -1)
                {
                    solution = "Аварийный выход!";
                    return (solution, attempts);
                }
                
                int check = d1 * 100 + d2 * 10 + d3;
                
                if (check == code)
                {
                    solution = "Доступ разрешен!";
                    return (solution, attempts);
                }
            }
            
            solution = "Система заблокирована!";

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        { 
            double luck = 0;

            for (int i = 0; i < n; i++)
            {
                int day = (a + i - 1) % 29 + 1; 
                
                if (day == 1 || day == 8 || day == 15 || day == 22 || day == 29)
                {
                    luck = luck * 1.5;
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

            return luck;
        }
    }
}
