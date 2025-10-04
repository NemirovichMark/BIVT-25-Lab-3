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
            for (int i = 0; i < n; i++)
            {
                double height = Double.Parse(Console.ReadLine());
                s += height;
            }
            if (n != 0)
                averageHeight = s / n;
            else averageHeight = 0;
            // end
            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            double x = 100;
            for (int i = 0; i < n; i++)
            {
                double res = double.Parse(Console.ReadLine());
                if (res < x) x = res;
            }
            if (n != 0) bestResult = x;
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double res = double.Parse(Console.ReadLine());
                if (res < limit) count++;
            }
            // end
            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
            int amount = 0;
            amount = int.Parse(Console.ReadLine());
            while (amount < maxAmount)
            {
                if (hours % 5 != 4) amount += 1;
                else amount -= 2;
                hours++;
            }
            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here
            if (type == 1) area = r * r;
            else if (type == 2) area = Math.PI * r * r;
            else if (type == 3) area = Math.Sqrt(3) * r * r / 4;
            // end

            return area;
        }
    }
}