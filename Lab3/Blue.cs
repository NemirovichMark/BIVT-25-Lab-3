using System.Runtime.Serialization;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            for (int i = 0; i < n; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight < norma)
                {
                    milk += glass;
                }
            }
            milk = milk / 1000.0;

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    first++;
                }
                if (x < 0 && y > 0)
                {
                    second++;
                }
                if (x < 0 && y < 0)
                {
                    third++;
                }
                if (x > 0 && y < 0)
                {
                    fourth++;
                }
            }
        
            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool Flag = false;
                for (int j = 0; j < 4; j++)
                {
                    int grade = int.Parse(Console.ReadLine());
                    if (grade == 2 || grade == 3)
                    {
                        Flag = true;
                    }

                }
                if (!Flag)
                {
                    count++;
                }
            }

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int seriasTime;
            int taskTime = 10;
            int serias = 0;
            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                } else
                {
                    seriasTime = int.Parse(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }

                return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
            int powerChange = 0;
            int agilityChange = 0;
            int intellectChange = 0;

            switch (number)
            {
                case 1:
                    powerChange = 10;
                    intellectChange = -5;
                    break;
                case 2:
                    agilityChange = 5;
                    powerChange = -5;
                    intellectChange = -5;
                    break;
                case 3:
                    powerChange = 10; 
                    intellectChange = -5;
                    break;
                case 4:
                    agilityChange = 15;
                    powerChange = -10;
                    intellectChange = -10;
                    break;
                case 5:
                    intellectChange = 7;
                    powerChange = -5;
                    break;
            }
            power += powerChange;
            agility += agilityChange;
            intellect += intellectChange;

            power = Math.Max(0, power);
            agility = Math.Max(0, agility);
            intellect = Math.Max(0, intellect);



            return (power, agility, intellect);
        }
    }
}
