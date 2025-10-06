using System;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double height = Convert.ToDouble(Console.ReadLine());
                sum += height;
            }
            double averageHeight = n > 0 ? sum / n : 0;
            return averageHeight;
        }

        public double Task2(int n)
        {
            double bestResult = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double result = Convert.ToDouble(Console.ReadLine());
                if (result < bestResult)
                    bestResult = result;
            }
            return bestResult == double.MaxValue ? 0 : bestResult;
        }

        public int Task3(int n, double limit)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                double time = Convert.ToDouble(Console.ReadLine());
                if (time <= limit)
                    count++;
            }
            return count;
        }

        public int Task4(int maxAmount)
        {
            int hours = 0;
            int amount = 0;

            while (amount < maxAmount)
            {
                if (hours % 5 != 4)
                    amount += 1;
                else
                    amount -= 2;
                hours++;
            }

            return hours;
        }

        public double Task5(int r, int type)
        {
            double area = 0;
            const double PI = Math.PI;

            switch (type)
            {
                case 1:
                    area = r * r;
                    break;
                case 2:
                    area = PI * r * r;
                    break;
                case 3:
                    area = Math.Sqrt(3) / 4 * r * r;
                    break;
                default:
                    area = 0;
                    break;
            }

            return area;
        }
    }
}
