using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            double s = 0;
            double k = 0;
            
            
            while (k < n)
            {
                double q = double.Parse(Console.ReadLine());
                s += q;
                k += 1;
            }
            averageHeight = s / n;
            if (n == 0)
            {
                averageHeight = 0;
            }
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            double min = 10000000000000;
            double k = 0;
            while (k < n)
            {
                double res = double.Parse(Console.ReadLine());
                min = Math.Min(min, res);
                k += 1;
            }
            bestResult = min;
            if (n==0)
            {
                bestResult = 0;
            }
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            int k = 0;

            while (k < n)
            {
                k += 1;
                double res = double.Parse(Console.ReadLine());
                if (limit >= res)
                {
                    count += 1;
                }
                
            }
            if (n == 0)
            {
                count = 0;
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
                    amount += 1;
                }
                else
                {
                    amount -= 2;
                }
                hours++;
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
                    area = double.Pi * r * r;
                    break;
                case 3:
                    area = Math.Sqrt(3) / 4 * (r * r);
                    break;


            }
            
            // end

            return area;
        }
    }
}
