using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double heigh = double.Parse(Console.ReadLine());
                sum += heigh;
            }
            if (n > 0)
                averageHeight = sum / n;
            else averageHeight = 0;
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out double t);
                if (i == 0 || t < bestResult)
                {
                    bestResult = t;
                }

            }
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out double s);
                if (s <= limit)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
            int amount = int.Parse(Console.ReadLine());
            while (amount < maxAmount)
            {
                if (hours % 5 != 4)
                {
                    amount++;
                }
                else
                {
                    amount -= 2;
                }
                hours++;
            }
            return hours;

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
                    area = r * r; break;
                case 2:
                    area = double.Pi * r * r; break;
                case 3:
                    area = Math.Sqrt(3) / 4 * r * r; break;

            }
            return area;
        }
    }
}
