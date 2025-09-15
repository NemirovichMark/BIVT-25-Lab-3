using System.Collections.Generic;
using System.Security.Cryptography;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here

            List<double> list = new List<double>();
            for (int i = 0; i <= n; i++)
            {
                double kg = Convert.ToDouble(Console.ReadLine());
                list.Add(kg);
            }
            
            foreach (double kg in list)
            {
                if (kg < norma)
                {
                    milk += 2 * glass;
                }
                else
                {
                    milk += kg;
                }
            }

            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here

            double x, y;
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    first++;
                }
                else if (x < 0 && y > 0)
                {
                    second++;
                }
                else if (x < 0 && y < 0)
                {
                    third++;
                }
                else
                {
                    fourth++;
                }
            }

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here

            int mark1 = 0;
            int mark2 = 0;
            int mark3 = 0;
            int mark4 = 0;
            for (int i = 0; i < n; i++)
            {
                mark1 = Convert.ToInt32(Console.ReadLine());
                mark2 = Convert.ToInt32(Console.ReadLine());
                mark3 = Convert.ToInt32(Console.ReadLine());
                mark4 = Convert.ToInt32(Console.ReadLine());
                if (mark1 > 3 && mark2 > 3 && mark3 > 3 && mark4 > 3)
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

            int seriasTime, taskTime = 10;
            serias = 0;
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
                    seriasTime = Convert.ToInt32(Console.ReadLine());
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

            // end

            return (power, agility, intellect);
        }
    }
}
