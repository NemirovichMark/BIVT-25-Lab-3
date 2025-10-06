using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n) 
        {
            double averageHeight = 0; 
            int s = 0; 

            for (int i = 0; i != n; i++) 
            {
                s += Convert.ToInt16(Console.ReadLine()); 
            }

            if (s != 0) averageHeight = (double) s / n; 

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 9999;
            double result = 0;

            for (int i = 0; i != n; i++)
            {
                result = Convert.ToDouble(Console.ReadLine());
                if (result < bestResult) bestResult = result;
            }

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            for (int i = 0; i != n; i++)
            {
                if (Convert.ToDouble(Console.ReadLine()) <= limit) count++;
            }

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;
            double amount = Convert.ToDouble(Console.ReadLine());

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
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            switch (type)
            {
                case 1:
                    area = r * r;
                    break;
                case 2:
                    area = Math.PI * r * r;
                    break;
                case 3:
                    area = (r * r * Math.Sqrt(3)) / 4;
                    break;
            }

            return area;
        }
    }
}
