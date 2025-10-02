using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            while(n > 0)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double l = (double)Math.Sqrt(x * x + y * y);
                if (l <= r2 && l >= r1)
                {
                    count++;
                }
                n --;
            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            double sum = 0;
            int d = n;
            // code here
            while(4*n > 0)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double z = double.Parse(Console.ReadLine());
                double w = double.Parse(Console.ReadLine());
                sum += x + y + z + w;
                n --;
                if (x == 2 || y == 2 || z == 2 || w == 2)
                {
                    count += 1;
                }
            }
            average = sum / (4 * d);
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int  n = exams;
            int mark;
            double score = 0;
            while (exams > 0)
            {
                int theory = int.Parse(Console.ReadLine());
                int practice = int.Parse(Console.ReadLine());
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
                exams-= 1;

                
            }
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Система заблокирована!"; // Изменено согласно условию
            int attempts = 0;

            // code here
            int d1 = code / 100;
            int d2 = (code / 10) % 10;
            int d3 = code % 10;

            for (attempts = 1; attempts <= limit; attempts++)
            {
                int input1 = int.Parse(Console.ReadLine());
                if (input1 == -1)
                    return ("Аварийный выход!", attempts);

                int input2 = int.Parse(Console.ReadLine());
                if (input2 == -1)
                    return ("Аварийный выход!", attempts);

                int input3 = int.Parse(Console.ReadLine());
                if (input3 == -1)
                    return ("Аварийный выход!", attempts);

                if (input1 == d1 && input2 == d2 && input3 == d3)
                    return ("Доступ разрешен!", attempts);
            }
            // end

            return (solution, limit);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            // code here
            for (int day = a; day < a + n; day++)
            {
                switch (day)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck = luck * 1.5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck = luck - 10;
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
            }
            // end
            // end

            return luck;
        }
    }
}