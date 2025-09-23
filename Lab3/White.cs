using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int height);
                // Console.WriteLine("Height is " + height);

            }
            Console.WriteLine(averageHeight);
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out double time);
                Console.WriteLine("TIME is " + time);
            }
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here

            // end

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here

            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here

            // end

            return area;
        }
    }
}
