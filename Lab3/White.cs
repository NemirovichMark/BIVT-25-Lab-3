using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            double r, s = 0;
            int i = 0;
            for (; ; i++)
            {
                double.TryParse(Console.ReadLine(), out r);
                if (r <= 0) break;
                s = s + r;
            }
            averageHeight = s / n;
            // end
            //Console.WriteLine(averageHeight);
            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here

            bestResult = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                double time = double.Parse(Console.ReadLine());
                if (time < bestResult)
                {
                    bestResult = time;
                }
            }
            Console.WriteLine(bestResult);
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            double t = double.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (double.Parse(Console.ReadLine()) <= limit)
                    count++;
            }
            // end

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
            int hour = 0;
            int amount = int.Parse(Console.ReadLine());
            {
                while (amount < maxAmount)
                {
                    if (hour % 5 != 4)
                    {
                        amount += 1;
                        hours++;
                    }
                    else
                    {
                        amount -= 2;
                        hours++;
                    }
                }
            }
            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here
            switch (type)
            {
                case 1:
                    area = r * r;
                    break;
                case 2:
                    area = Math.PI * r * r;
                    break;
                case 3:
                    area = (Math.Sqrt(3) / 4) * r * r;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Выберите 1, 2 или 3:");
                    break;
            }

            Console.WriteLine(area);
            // end

            return area;
        }
    }
}