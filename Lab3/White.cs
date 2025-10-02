using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += int.Parse(Console.ReadLine());
                
            }
            if (n != 0)
            {
                averageHeight = (double) sum / n;
            }
            

            return averageHeight;
        }
        public double Task2(int n)
        {
            if (n == 0) return 0;
            double bestResult = double.Parse(Console.ReadLine());
            double result = 0;
            for(int i = 0; i < n - 1; i++)
            {
                result = double.Parse(Console.ReadLine());
                if(bestResult > result)
                {
                    bestResult = result;
                   
                }
            }
            

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            if (n == 0) return 0;
            int count = 0;
            double result = 0;
            for(int i = 0; i < n; i++)
            {
                result = double.Parse(Console.ReadLine());
                if(result <= limit)
                {
                    count++;
                }
            }
            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;
            int amount = int.Parse(Console.ReadLine());
            while(amount < maxAmount)
            {
                if(hours % 5 != 4)
                {
                    amount += 1;
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
                    area = r * r * Math.Sqrt(3) / 4;
                    break;
                default:
                    break;

            }

            return area;
        }
    }
}