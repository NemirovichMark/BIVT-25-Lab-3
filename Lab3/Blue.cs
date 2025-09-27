using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            int nenorma = 0;
            double kg = 0;
            for (int i=0; i<n; i++)
            {
                kg=(double.Parse(Console.ReadLine()));
                if (kg < norma)
                {
                    nenorma++;
                }
            }

            milk = ((double)(nenorma  * glass) / 1000);
            Console.WriteLine(nenorma);
            Console.WriteLine(milk);

            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = (double.Parse(Console.ReadLine()));
                double y = (double.Parse(Console.ReadLine()));
                if ((x>0) && (y > 0))
                {
                    first++;
                }
                else if((x < 0) && (y > 0))
                {
                    second++;
                }
                else if((x < 0) && (y < 0))
                {
                    third++;
                }
                else if ((x > 0) && (y < 0))
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
            int g1;
            int g2;
            int g3;
            int g4;
            // code here
            for (int i=0; i < n; i++)
            {
                g1 = int.Parse(Console.ReadLine());
                g2 = int.Parse(Console.ReadLine());
                g3 = int.Parse(Console.ReadLine());
                g4 = int.Parse(Console.ReadLine());
                if ((g1 != 2) && (g2 != 2) && (g3 != 2) && (g4 != 2))
                {
                    if ((g1 != 3) && (g2 != 3) && (g3 != 3) && (g4 != 3))
                    {
                        count++;
                    }
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
                    seriasTime = int.Parse(Console.ReadLine());
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
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect = Math.Max(0, intellect - 5);
                    break;
                case 2:
                    agility += 5;
                    power = Math.Max(0, power - 5);
                    intellect = Math.Max(0, intellect - 5);
                    break;
                case 3:
                    power += 10;
                    intellect = Math.Max(0, intellect - 5);
                    break;
                case 4:
                    agility += 15;
                    power = Math.Max(0, power - 10);
                    intellect = Math.Max(0, intellect - 10);
                    break;
                case 5:
                    intellect += 7;
                    power = Math.Max(0, power - 5);
                    break;
            }

            // end

            return (power, agility, intellect);
        }
    }
}
