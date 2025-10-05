using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;
            string s = Console.ReadLine();
            string[] numbers = s.Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (double.TryParse(numbers[i], out double chi))
                {
                    averageHeight += chi;
                }
            }
            averageHeight /= n;
            Console.WriteLine(averageHeight);
            return averageHeight;

        }
        public double Task2(int n)
        {
            double bestResult = 100;
            string s = Console.ReadLine();
            string[] numbers = s.Split(' ');
            for (int i = 0; i < n; i++)
            {
                double.TryParse(numbers[i], out double time);
                
                if (time <= bestResult) { bestResult = time; }
            }
            Console.WriteLine(bestResult);
            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            string s = Console.ReadLine();
            string[] numbers = s.Split(' ');

            for (int i = 0; i < n; i++)
            {
                double.TryParse(numbers[i], out double time);
                if (time <= limit) { count++; } 
            }
            Console.WriteLine(count);
            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0, amount = 0;

            amount = int.Parse(Console.ReadLine());
            
            while (amount < maxAmount) { 
                if (hours % 5 != 4) { amount += 1; }
                else { amount -= 2; }
                hours++;
            }
            Console.WriteLine(hours);
            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            if (type == 1) { area = r * r; }
            else if (type == 2) { area = Math.PI * r *r; }
            else if (type == 3) { area = (r * r * Math.Sqrt(3))/4; }
            else { area = 0; }

            return area;
        }
    }
}
