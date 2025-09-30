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
                double x = Double.Parse(Console.ReadLine());
                double y = Double.Parse(Console.ReadLine());
                double length = Math.Sqrt(x * x + y * y);
                if (length > r1 & length < r2) count++;
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
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                average += (a + b + c + d) / 4;
                if (a == 2 || b == 2 || c == 2 || d == 2) count++;
            }
            if (n!=0) average /= n;
                
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
                theory = int.Parse(Console.ReadLine());
                practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85) mark = 5;
                else if (score > 70) mark = 4;
                else if (score > 50) mark = 3;
                else mark = 2;
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
                string try_code = "";
                bool flag = false;
                for (int i = 0; i < 3; i++)
                {
                    int a = int.Parse(Console.ReadLine());
                    try_code += a.ToString();
                    if (a == -1)
                    {
                        solution = "Аварийный выход!";
                        flag = true;
                        break;
                    }
                }

                if (flag) break;
                if (code.ToString() == try_code)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
                if (attempts == limit) solution = "Система заблокирована!";
            }
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = a; i < n; i++)
            {
                int day = i;
                if (day > 31) day -= 31;
                switch (day)
                {
                    case 1 or 8 or 5 or 22 or 29:
                        // Console.Write($"\n{day}: Пик энергии! {luck} -> ");
                        luck *= 1.5;
                        if (luck > 100) luck = 100;
                        Console.Write(luck);
                        break;
                    case 4 or 11 or 18 or 25:
                        // Console.Write($"\n{day}: Темные силы... {luck} -> ");
                        luck -= 10;
                        if (luck < 0) luck = 0;
                        Console.Write(luck);
                        break;
                    case 7 or 14 or 21 or 28:
                        // Console.Write($"\n{day}: Мистический шанс! {luck} -> ");
                        if (luck < 50) luck = 55;
                        Console.Write(luck);
                        break;
                    default:
                        // Console.Write($"\n{day}: Обычный день {luck} -> ");
                        luck += 5;
                        if (luck > 100) luck = 100;
                        Console.Write(luck);
                        break;
                }
            }
            // end

            return luck;
        }
    }
}