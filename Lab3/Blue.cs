using System;

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
                Console.Write("");
                int weight = int.Parse(Console.ReadLine());

                if (weight < norma)
                {
                    milk += glass;
                }
            }
            milk = milk / 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                Console.Write($"");
                double x = double.Parse(Console.ReadLine());
                Console.Write($"");
                double y = double.Parse(Console.ReadLine());
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
                else if (x > 0 && y < 0)
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
                bool neud = false;
                for (int k = 0; k < 4; k++)
                {
                    Console.Write($"");
                    int ud = int.Parse(Console.ReadLine());
                    if (ud == 3 || ud == 2)
                    {
                        neud = true;
                    }
                }
                if (neud==false)
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
            int seriasTime = int.Parse(Console.ReadLine());
            int taskTime = 10;
            

            while (time<24*60)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else 
                {
                    Console.Write("");
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
                    intellect -= 5;
                    break;
                case 2:
                    agility += 5;
                    power -= 5;
                    intellect -= 5;
                    break;
                case 3:
                    power += 10;
                    intellect -= 5;
                    break;
                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    break;
            }
            power = Math.Max(power, 0);
            agility = Math.Max(agility, 0);
            intellect = Math.Max(intellect, 0);
            // end

            return (power, agility, intellect);
        }
    }
}
