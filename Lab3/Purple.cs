using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            double x;
            double y;
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                if (r1*r1 <= x*x + y*y && x*x + y*y <= r2*r2)
                {
                    count += 1;
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
            if (n == 0)
            {
                return (count, average);
            }
            double marks_sum = 0;
            int marks_count = 0;
            for (int i = 0; i < n; i++)
            {
                double mark1 = Convert.ToInt32(Console.ReadLine());
                double mark2 = Convert.ToInt32(Console.ReadLine());
                double mark3 = Convert.ToInt32(Console.ReadLine());
                double mark4 = Convert.ToInt32(Console.ReadLine());
                marks_count += 4;
                marks_sum += (mark1 + mark2 + mark3 + mark4); 
                
                if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
                {
                    count += 1;
                }
            }
            average = marks_sum / marks_count;
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            int theory, practice, mark, n = exams;
            double score, avgMark = 0;
            // code here
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
            for (int i = 0; i < limit; i++)
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (num1 < 0 || num2 < 0 || num3 < 0)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                if ((code % 10 == num3) && ((code / 10) % 10 == num2) && ((code / 100) % 10 == num1))
                {
                    solution = "Доступ разрешен!";
                    break;
                }

            }
            if (solution != "Аварийный выход!" && solution != "Доступ разрешен!")
            {
                solution = "Система заблокирована!";
            }
            // end
            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            int monthDay = a;

            // code here
            for (int i = a; i < a+n; i++)
            {
                switch (monthDay)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck *= 1.5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;

                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck -= 10;
                        if (luck < 0)
                        {
                            luck = 0;
                        }
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
                        luck += 5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;

                }
                monthDay++;
                if (monthDay > 30)
                {
                    monthDay = 1;
                }
            }
            
            // end

            return luck;
        }
    }
}