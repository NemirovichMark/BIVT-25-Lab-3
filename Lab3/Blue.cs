using System.Globalization;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            for (int i = 0; i < n; ++i)
            {
                int w = Convert.ToInt32(Console.ReadLine());
                if (w < norma) milk += glass;
            }

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

           for (int i = 0; i < n; ++i)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 && y > 0) ++first;
                if (x < 0 && y > 0) ++second;
                if (x < 0 && y < 0) ++third;
                if (x > 0 && y < 0) ++fourth;
            }

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            for (int i = 0; i < n; ++i) {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());
                if (a != 2 && a != 3 && b != 2 && b != 3 && c != 2 && c != 3 && d != 2 && d != 3)
                {
                    ++count;
                }
            }

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int seriasTime, taskTime = 10;

            while (time < 60 * 24)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                } else
                {
                    seriasTime = Convert.ToInt32(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            if (number == 1 || number == 3)
            {
                power += 10;
                intellect -= 5;
            }else if (number == 2)
            {
                agility += 5; power -= 5; intellect -= 5;
            } else if (number == 4)
            {
                agility += 15; power -= 10; intellect -= 10;
            } else if (number == 5)
            {
                intellect += 7;
                power -= 5;
            }
            power = Math.Max(0, power);
            intellect = Math.Max(0, intellect);
            agility = Math.Max(0, agility);

                return (power, agility, intellect);
        }
    }
}