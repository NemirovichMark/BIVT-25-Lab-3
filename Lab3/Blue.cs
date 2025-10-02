using System.Data;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int p;
                int.TryParse(Console.ReadLine(), out p);
                if (p < norma)
                {
                    milk += (double)glass / 1000;
                }
            }
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x, y;
                double.TryParse(Console.ReadLine(), out x);
                double.TryParse(Console.ReadLine(), out y);
                if (x > 0 && y > 0)
                {
                    first += 1;
                }
                else if (x < 0 && y > 0)
                {
                    second += 1;
                }
                else if (x < 0 && y < 0)
                {
                    third += 1;
                }
                else if (x < 0 && y > 0)
                {
                    fourth += 1;
                }
            }
            // end

                return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int x, y, z, w;
                int.TryParse(Console.ReadLine(), out x);
                int.TryParse(Console.ReadLine(), out y);
                int.TryParse(Console.ReadLine(), out z);
                int.TryParse(Console.ReadLine(), out w);
                if (x != 2 && x != 3 && y != 2 && y != 3 && z != 2 && z != 3 && w != 2 && w != 3)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime;
            int taskTime = 10;
            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    int.TryParse(Console.ReadLine(), out seriasTime);
                    time += seriasTime;
                    serias++;
                }
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            if (number == 1)
            {
                power += 10;
                intellect = Math.Max(0, intellect - 5);
            }
            else if (number == 2)
            {
                agility += 5;
                power = Math.Max(0, power - 5);
                intellect = Math.Max(0, intellect - 5);
            }
            else if (number == 3)
            {
                power += 10;
                intellect = Math.Max(0, intellect - 5);
            }
            else if (number == 4)
            {
                agility += 15;
                power = Math.Max(0, power - 10);
                intellect = Math.Max(0, intellect - 10);
            }
            else if (number == 5)
            {
                intellect += 7;
                power = Math.Max(0, power - 5);
            }
            // end

            return (power, agility, intellect);
        }
    }
}