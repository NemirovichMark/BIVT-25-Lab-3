using System.Net.Http.Headers;
using System.Net.NetworkInformation;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                double way = (x * x) + (y * y);
                if (r1*r1 <= way && way <= r2*r2)
                {
                    count ++;
                }
            }
            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            double summary = 0;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out double m1);
                double.TryParse(Console.ReadLine(), out double m2);
                double.TryParse(Console.ReadLine(), out double m3);
                double.TryParse(Console.ReadLine(), out double m4);
                double[] marks = [m1, m2, m3, m4];
                summary += marks.Sum();
                bool f = marks.Contains(2);
                if (f == true)
                {
                    count++;
                }
            }
            //Console.WriteLine(summary);
            if (n > 0)
            {
                average = summary / (n * 4);
            }

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            int theory, practice, mark, n = exams;
            double score;
            while (exams > 0)
            {
                int.TryParse(Console.ReadLine(), out theory);
                int.TryParse(Console.ReadLine(), out practice);
                score = 0.4 * theory + 0.6 * practice;
                switch (score)
                {
                    case > 85:
                        mark = 5; break;
                    case > 70:
                        mark = 4; break;
                    case > 50:
                        mark = 3; break;
                    default:
                        mark = 2; break;
                }
                avgMark += (double) mark/n;
                exams--;
            }
            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;
            for (int i = 0; i < limit; i++)
            {
                attempts++;
                string n1 = Console.ReadLine();
                string n2 = Console.ReadLine();
                string n3 = Console.ReadLine();
                //Console.WriteLine(attempts +" " + n1);
                if (n1 == "-1" || n2 == "-1" || n3 == "-1")
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int.TryParse(n1+n2+n3, out int pin);
                if (pin == code)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }
            if (solution == "Код не подобран")
            {   
                solution = "Система заблокирована!";
            }

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            for (int i = a; i < n + a; i++)
            {
                if (i == 0)
                {
                    luck += 5;
                    continue;
                }
                int ost = i % 7;
                switch (ost)
                {
                    case 1:
                        if (luck * 1.5 <= 100)
                            luck *= 1.5;
                        else
                            luck = 100;
                        break;
                    case 4:
                        if (luck - 10 >= 0)
                            luck -= 10;
                        else
                            luck = 0;
                        break;
                    case 0:
                        if (luck <= 50)
                            luck = 55;
                        break;
                    default:
                        if (luck + 5 <= 100)
                            luck += 5;
                        else
                            luck = 100; 
                        break;
                }
            }
            

            return luck;
        }
    }
}
