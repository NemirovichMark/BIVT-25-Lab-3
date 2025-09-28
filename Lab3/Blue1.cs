using System;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            if (n == 0)
                return milk;
            //double[] douЬlesArray = new double[n];
            for (int i = 0; i < n ; i++)
            {
                double weight = double.Parse(Console.ReadLine());
                if (weight < norma)
                {
                    milk += glass * 0.001;
                }
            }
            milk = Math.Round(milk, 2);       
            Console.WriteLine(milk);
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            if (n == 0)
                return (first, second, third, fourth);
            //double[] doublesArray = new double[n * 2];
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                    first += 1;
                if (x < 0 && y > 0)
                    second += 1;
                if (x < 0 && y < 0)
                    third += 1;
                if (x > 0 && y < 0)
                    fourth += 1;
                if (x == 0 || y == 0)
                    continue;
            }

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            if (n == 0)
                return count;
            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                if (a > 3 && b > 3 && c > 3 && d > 3)
                    count += 1;
            }

            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime = 10;
            int taskTime = 10;
            serias = 0;
            for (; time < 1440;)
            {
                for (; tasks > 0 && time < 1440;)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                if (time < 1440)
                {
                    seriasTime = int.Parse(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }
            // end
            Console.WriteLine($"{tasks}, {serias}");
            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            switch (number)
            {
                case 0:
                    return(power, agility, intellect);
                case 1:
                    power += 10;
                    intellect -= 5; break;
                case 2:
                    agility += 5;
                    intellect -= 5;
                    power -= 5; break;
                case 3:
                    power += 10;
                    intellect -= 5; break;
                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10; break;
                case 5:
                    intellect += 7;
                    power -= 5; break;
            }
            for (;power < 0;)
                power += 1;
            for (;agility < 0;)
                agility += 1;
            for (;intellect < 0;)
                intellect += 1;
            // end
            Console.WriteLine($"{power}, {agility}, {intellect}");
            return (power, agility, intellect);
        }
    }
}
