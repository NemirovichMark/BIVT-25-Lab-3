using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Lab3
{
    public class White
    {
        public double Task1(int n) // верно
        {
            double averageHeight = 0;

            // code here
            Console.WriteLine("Введите количество учеников: ");
            n = int.Parse(Console.ReadLine());

            double totalHight = 0;
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Введите рост ученика {i + 1}: ");
                double hight = double.Parse(Console.ReadLine());
            }

            averageHeight = totalHight / n;
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите время спортсмена {i + 1} (в секундах): ");
                double time = double.Parse(Console.ReadLine());

                if (i == 0 || time < bestResult)
                {
                    bestResult = time;
                }
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
                Console.Write($"Введите результат спортсмена {i + 1} (в секундах):  ");
                double result = double.Parse(Console.ReadLine());

                if (result <= limit)
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
            double amount = 0;
            amount = double.Parse(Console.ReadLine());

            while (amount < maxAmount)
            {
                if (hours % 5 != 4)
                {
                    amount += 1;
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
            switch (type)
            {
                case 1: // площадь квадрата
                    area = r * r;
                    break;
                case 2: // площадь круга
                    area = Math.PI * r * r;
                    break;
                case 3: // площадь равностороннего треугольника
                    area = (Math.Sqrt(3) / 4) * r * r;
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный тип фигуры");
                    break;
            }
            // end

            return area;
        }
    }
}

