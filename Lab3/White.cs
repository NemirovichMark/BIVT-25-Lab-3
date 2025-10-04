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
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            double bestTime = 99999999;
            for (int i = 0; i < n; i++)
            {
                double time = double.Parse(Console.ReadLine());
                if (time < bestTime)
                {
                    bestTime = time;
                }
            }
            if (n != 0) bestResult = bestTime;

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