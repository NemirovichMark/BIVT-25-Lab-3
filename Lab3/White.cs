using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;
            int s = 0;
            for(int i = 0; i < n; i++)
            {
                int Height = int.Parse(Console.ReadLine());
                s += Height;
            }
            averageHeight = s / n;
            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;
            int s = 0;
            for(int i = 0; i<n; i++)
            {
                int Result = int.Parse(Console.ReadLine());
                if(s < Result)
                {
                    s = Result;
                }
            }
            bestResult = s;
            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                int Time = int.Parse(Console.ReadLine());
                if(Time <= limit)
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
            if(amount > maxAmount)
            {
                if(amount % 5 != 4)
                {
                    amount += 1;
                }
                else
                {
                    amount -= 2;
                }
                hours++;
            }
            else
            {
                return hours;
            }
                return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;
            if(type == 1)
            {
                area = r * r;
            }
            else if(type == 2)
            {
                area = Math.PI * r * r;
            }
            else if(type == 3)
            {
                area = (Math.Sqrt(3) / 4) * (r * r);
            }
                return area;
        }
    }
}

