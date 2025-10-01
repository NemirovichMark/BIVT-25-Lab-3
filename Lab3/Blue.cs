using System.ComponentModel.Design;

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
                double ves=Convert.ToDouble(Console.ReadLine());
                if (ves < norma)
                {
                    milk += glass;
                }
            }
            milk /= 1000;
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
                double x=Convert.ToDouble(Console.ReadLine());
                double y=Convert.ToDouble(Console.ReadLine());
                if(x!=0 && y != 0)
                {
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
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            int sum = 0;
            for (int i=0;i<n;i++)
            {
                for(int a = 0; a < 4; a++)
                {
                    int x=Convert.ToInt32(Console.ReadLine());
                    if (x >= 4)
                    {
                        sum++;
                    }
                }
                if (sum == 4)
                {
                    count++;
                }
                sum = 0;
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
                    tasks -= 1;
                }
                else
                {
                    seriasTime=Convert.ToInt32(Console.ReadLine());
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
                    if (intellect < 5)
                    {
                        intellect = 0;
                    }
                    else
                    {
                        intellect -= 5;
                    }
                    break;
                case 2:
                    agility += 5;
                    if (intellect < 5)
                    {
                        intellect = 0;
                    }
                    else
                    {
                        intellect -= 5;
                    }
                    if (power < 5)
                    {
                        power = 0;
                    }
                    else
                    {
                        power -= 5;
                    }
                    break;
                case 3:
                    power += 10;
                    if (intellect < 5)
                    {
                        intellect = 0;
                    }
                    else
                    {
                        intellect -= 5;
                    }
                    break;
                case 4:
                    agility += 15;
                    if (intellect < 10)
                    {
                        intellect = 0;
                    }
                    else
                    {
                        intellect -= 10;
                    }
                    if (power < 10)
                    {
                        power = 0;
                    }
                    else
                    {
                        power -= 10;
                    }
                    break;
                case 5:
                    intellect += 7;
                    if (power < 5)
                    {
                        power = 0;
                    }
                    else
                    {
                        power -= 5;
                    }
                    break;
            }
            // end

            return (power, agility, intellect);
        }
    }
}