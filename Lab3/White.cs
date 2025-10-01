using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            Console.WriteLine("Введите количество учеников");
            n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Ошибка");
            }

            double s = 0; // сумма роста
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите рост ученика");
                double height = double.Parse(Console.ReadLine());
                s += height;
            }
            averageHeight = s / n;
            Console.WriteLine($"Средний рост - {averageHeight}");
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            bestResult = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double time = double.Parse(Console.ReadLine());
                if (time < bestResult) bestResult = time;
            }
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            
            for (int i = 0; i < n; i++)
            {
                double time = double.Parse(Console.ReadLine());
                if (time <= limit)
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
            int hour = 0;
            int amount = int.Parse(Console.ReadLine());
            if (amount < maxAmount)
            {
                if (hour % 5 != 4) 
                {
                    amount += 1;
                    hours++;
                }
                else
                {
                    amount -= 2;
                    hours++;
                }
            }
            else
            {
                return hours;
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
                area = (r * r * Math.Sqrt(3)) / 4;
            }
            // end

            return area;
        }
    }
}
