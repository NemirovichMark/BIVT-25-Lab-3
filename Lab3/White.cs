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
            double r;
            for (int i = 1; i <= n; i++)
            {
                double.TryParse(Console.ReadLine(), out r); 
                sum += r;
            }
            
            averageHeight = sum/n;
            Console.WriteLine(averageHeight);
           
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            double min;
            double r;
            double.TryParse(Console.ReadLine(), out min);
            for (int i = 1; i<n; i++)
            {
                double.TryParse(Console.ReadLine(), out r);
                if (r<min)
                {
                    min= r;
                }
            }
            bestResult = min;
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            double time;
            for (int i = 1; i <= n; i++)
            {
                double.TryParse(Console.ReadLine(), out time);
                if (time <= limit)
                {
                    count += 1;
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
                if ((hours % 5)!= 4)
                {
                    amount+=1;
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
                area = (Math.Sqrt(3) / 4) * r * r;
            }
                    // end

                    return area;
        }
    }
}
