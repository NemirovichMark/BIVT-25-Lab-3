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
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double radius = Math.Sqrt(x*x + y*y);
                if (radius >= r1 && radius <= r2) 
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
            if (n == 0)
                return (0, 0);
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                int mark1 = int.Parse(Console.ReadLine());
                int mark2 = int.Parse(Console.ReadLine());
                int mark3 = int.Parse(Console.ReadLine());
                int mark4 = int.Parse(Console.ReadLine());
                if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
                    count++;
                sum += mark1 + mark2 + mark3 + mark4;
            }
            average = sum / (4*n);
            // Вариант 2 (с двойной вложенностью циклов)
            
            // double sum = 0;
            // for (int i = 0; i < n; i++)
            // {
            //     bool isBadMark = false;
            //     for (int j = 0; j < 4; j++)
            //     {
            //         int mark = int.Parse(Console.ReadLine());
            //         if (mark == 2 && !isBadMark) //если оценка 2 и оценка 2 уже была
            //         {
            //             count++;
            //             isBadMark = true;
            //         }
            //         sum += mark;
            //     }
            //     
            // }
            // average = sum / (4*n);
            
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory = exams;
            int practice = exams;
            int mark = exams;
            int n = exams;
            double score = 0;
            while (exams > 0)
            {
                theory = int.Parse(Console.ReadLine());
                practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                mark = score switch
                {
                    > 85 => 5,
                    > 70 => 4,
                    > 50 => 3,
                    _ => 2
                };
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
            for (int i = 1; i <= limit; i++)
            {
                attempts++;
                
                int number1 = int.Parse(Console.ReadLine());
                if (number1 == -1)
                    return ("Аварийный выход!", attempts);
                
                int number2 = int.Parse(Console.ReadLine());
                if (number2 == -1)
                    return ("Аварийный выход!", attempts);
                
                int number3 = int.Parse(Console.ReadLine());
                if (number3 == -1)
                    return ("Аварийный выход!", attempts);
                
                int allNumber = number1*100 + number2*10 + number3;
                if (code == allNumber)
                    return ("Доступ разрешен!", attempts);
            }
            return ("Система заблокирована!", attempts);
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = a; i < a + n; i++)
            {
                int moonDay = ((i - 1) % 28) + 1;
                luck = moonDay switch
                {
                    1 or 8 or 15 or 22 or 29 => Math.Min(luck * 1.5,100),
                    4 or 11 or 18 or 25 => Math.Max(luck - 10, 0),
                    7 or 14 or 21 or 28 => luck < 50? 55: luck, // условие? "если верно": "если неверно"
                    _ => Math.Min(luck + 5,100)
                };
            }
            // end

            return luck;
        }
    }
}