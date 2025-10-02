using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            for (int i = 0; i<n; i++)
            {
                int.TryParse(Console.ReadLine(), out int height);
                averageHeight += height;
            }
            averageHeight /= n;
            // end

            return averageHeight;
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
                double.TryParse(Console.ReadLine(), out double U);
                if ( U<=limit)
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
            int.TryParse(Console.ReadLine(), out int hour);
            while(amount < maxAmount)
            {
                if (hour % 5 != 4)
                {
                    amount += 1;
                    hours++;
                }
                amount -= 2;
                hours++;
            }
            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here
            double Skv = r * r;
            double Skr = Math.PI * (r * r);
            double Str = (Math.Sqrt(3) * (r * r)) / 4;
            switch (type)
            {
                case 1:
                    area = Skv;
                    break;
                case 2:
                    area = Skr;
                    break;
                case 3:
                    area = Str;
                    break;
            }
            // end

            return area;
        }
    }

}
