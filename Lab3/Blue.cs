using System.Diagnostics;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            
            for (int i = 0; i<n; i++)
            {
                double weight;
                double.TryParse(Console.ReadLine(), out weight);
                if (weight < norma)
                {
                    milk += glass;
                }
            }
            milk = milk / 1000.0;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i<n; i++)
            {
                double x, y;
                double.TryParse(Console.ReadLine(), out x);
                double.TryParse(Console.ReadLine(), out y);
                if (x>0 && y>0)
                {
                    first++;
                }
                else if (x < 0 && y>0)
                {
                    second++;
                }
                else if (x<0 && y<0)
                {
                    third++;

                }
                else if (x>0 && y <0)
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
            for (int i = 0; i < n; i++)
            {
                int not23 = 0;
                for (int o = 0; o<4; o++ )
                {
                    int.TryParse(Console.ReadLine(), out int ots);
                    if (ots!=2 && ots !=3)
                    {
                        not23++;
                    }
                    if (not23 == 4)
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
            int  taskTime = 10;
            while (time <24*60)
            {
                if (tasks >0)
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
            if (number == 1 || number == 3)
            {
                power += 10;
                intellect -= 5;
            }
            if (number == 2 )
            {
                power -= 5;
                agility += 5;
                intellect -= 5;

            }
            if (number ==4)
            {
                power -= 10;
                intellect -= 10;
                agility += 15;
            }
            if (number ==5)
            {
                intellect += 7;
                power -= 5;
            }
            power = Math.Max(power, 0);
            intellect = Math.Max(intellect, 0);
            agility = Math.Max(agility, 0);

            // end

            return (power, agility, intellect);
        }
    }
}