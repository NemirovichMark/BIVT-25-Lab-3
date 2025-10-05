using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            double answer = 0;
            for (int i = 1;i <=n; i = i + 1)
            {
                double height;
                double.TryParse(Console.ReadLine(), out height);
                answer += height;
            }
            averageHeight = answer / n;
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here

            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i=i+1)
            {
                double time = double.Parse(Console.ReadLine());
                if (time <= limit)
                {
                    count=count+1;
                }
            }

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
            for (int i = 1; i <= maxAmount; i=i+1)
            {
                hours += i;
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
                area = Math.PI * (r * r);
            }
            if (type == 3)
            {
                area = ((r * r) * Math.Sqrt(3)) / 4;
            }
            // end

            return area;
        }
    }
}
