using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;
            // code here
            if (n > 0)
            {
                int S = 0;
                
                            for (int i = 0; i < n; i++)
                            {
                                int h;
                                int.TryParse(Console.ReadLine(), out h);
                                S += h;
                            }
                
                            averageHeight = (double)S / n;
            }
            else
            {
                averageHeight = 0;
            }
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            if (n > 0)
            {
                double mx = 10000;
                for (int i = 0; i < n; i++)
                {
                    double time;
                    double.TryParse(Console.ReadLine(), out time);
                    if (time < mx)
                        mx = time;
                }

                bestResult = mx;
                Console.WriteLine(bestResult + " Ответ");
            }
            else
                bestResult = 0;
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    double time;
                    double.TryParse(Console.ReadLine(), out time);
                    if (time <= limit)
                        count++;
                }
                Console.WriteLine("Answer: {0}", count);
            }
            else
                count = 0;
          
            // end

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
            int amount;
            int.TryParse(Console.ReadLine(), out amount);

            while (amount < maxAmount)
            {
                if (hours % 5 != 4)
                    amount += 1;
                else
                    amount -= 2;
                hours++;
            }
            Console.WriteLine(hours);
            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here
            if (type == 1)
                area = r * r;
            if (type == 2)
                area = Math.PI * (r * r);
            if (type == 3)
                area = ((r * r) * Math.Sqrt(3)) / 4;
            // end
            area *= 1.0;
            return area;
        }
    }
}
