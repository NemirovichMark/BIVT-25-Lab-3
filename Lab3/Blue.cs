using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            for (int i = 0; i < n; i++)
            {
                if (double.Parse(Console.ReadLine()) < norma)
                {
                    milk += glass;
                }
            }

            return milk/1000;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            for (int i = 0; i < n; i++)
            {
                double x, y;
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    first += 1;
                }
                if (x < 0 && y > 0)
                {
                    second += 1;
                }
                if (x < 0 && y < 0)
                {
                    third += 1; 
                }
                if (x > 0 && y < 0)
                {
                    fourth += 1;
                }

            }
            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int flag = 1;
                for (int j = 0; j < 4; j++)
                {
                    int mark;
                    mark = int.Parse(Console.ReadLine());
                    if (mark <= 3)
                    {
                        flag = 0;
                    }
                }
                count += flag;
            }

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0, tasktime = 10;

            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += tasktime;
                    tasktime += 5;
                    tasks--;
                }
                else
                {
                    time += int.Parse(Console.ReadLine());
                    serias++;
                }
            }

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
            if (number == 1)
            {
                power += 10;
                intellect -= 5;
            }
            if (number == 2)
            {
                agility += 5;
                power -= 5;
                intellect -= 5;
            }
            if (number == 3)
            {
                power += 10;
                intellect -= 5;
            }
            if (number == 4)
            {
                agility += 15;
                power -= 10;
                intellect -= 10;
            }
            if (number == 5)
            {
                intellect += 7;
                power -= 5;
            }

            if (power < 0)
            {
                power = 0;
            }
            if (agility < 0)
            {
                agility = 0;
            }
            if (intellect < 0)
            {
                intellect = 0;
            }

            return (power, agility, intellect);
        }
    }
}