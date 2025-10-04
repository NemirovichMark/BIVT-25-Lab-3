﻿using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            double s = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    int.TryParse(Console.ReadLine(), out int a);
                    s += a;
                }
                averageHeight = s / n;
            }

            // end


            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            
            if (n > 0)
                bestResult = 100 * 1000;
            {
                for (int i = 1; i <= n; i++)
                {
                    double.TryParse(Console.ReadLine(), out double a);
                    bestResult = Math.Min(a, bestResult);
                }
            }
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    double.TryParse(Console.ReadLine(), out double a);
                    if (a <= limit)
                    {
                        count += 1;
                    }
                }
            }

            // end

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
            int amount = 0;
            int.TryParse(Console.ReadLine(), out amount);
            while (amount < maxAmount)
            {
                if (hours % 5 != 4)
                {
                    amount += 1;
                }
                else
                {
                    amount -= 2;
                    hours++;
                }
            }
            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here
            if (type == 1)
            {
                area = r * r;
            }
            else if (type == 2)
            {
                area = Math.PI * r * r;
            }
            else if (type == 3)
            {
                area = 0.86602540378 * 0.5 * r * r;
            }
            // end

            return area;

        }
    }
}