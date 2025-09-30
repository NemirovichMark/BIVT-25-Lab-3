using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double weight;
            for (int i = 0; i<n; i++)
            {
                double.TryParse(Console.ReadLine(), out weight);
                if (weight<norma)
                    milk += glass;
            }
            milk /= 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            double a;
            double b;
            
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out a);
                double.TryParse(Console.ReadLine(), out b);
                if (a > 0 && b > 0)
                    first++;
                else if (a < 0 && b > 0)
                    second++;
                else if (a < 0 && b < 0)
                    third++;
                else if (a > 0 && b > 0)
                    fourth++;
            }


            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            int a;
            int b;
            int c;
            int d;

            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out a);
                int.TryParse(Console.ReadLine(), out b);
                int.TryParse(Console.ReadLine(), out c);
                int.TryParse(Console.ReadLine(), out d);
                if (a != 2 && a != 3 && b != 2 && b != 3 && c != 2 && c != 3 && d != 2 && d != 3)
                    count++;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10;
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
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect -=5; break;
                
                case 2:
                    agility += 5;
                    intellect -= 5;
                    power -= 5; break;
                case 3:
                    power += 10;
                    intellect -= 5; break;
                case 4:
                    power -= 10;
                    agility += 15;
                    intellect -= 10; break;
                case 5:
                    power-= 5;
                    intellect += 7; break;
                default: break;
           
            }
            if (power < 0) power = 0;
            if (intellect < 0) intellect = 0;
            if (agility < 0) agility = 0;
            // end

            return (power, agility, intellect);
        }
    }
}
