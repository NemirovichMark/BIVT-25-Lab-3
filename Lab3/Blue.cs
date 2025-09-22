using System.IO.Compression;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            if (n > 0)
            {
                for (uint i = 0; i < n; i++)
                {
                    var weight = Convert.ToInt32(Console.ReadLine());
                    if (weight < norma)
                    {
                        milk += glass;
                    }
                }
            }
            return milk;
        }
        
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            for (uint i = 0; i < n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 && y > 0)
                    first++;
                
                if (x < 0 && y > 0)
                    second++;

                if (x < 0 && y < 0)
                    third++;

                if (x > 0 && y < 0)
                    fourth++;
            }

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            for (uint i = 0; i < n; i++)
            {
                var first_grade = Convert.ToUInt32(Console.ReadLine());
                var second_grade = Convert.ToUInt32(Console.ReadLine());
                var third_grade = Convert.ToUInt32(Console.ReadLine());
                var forth_grade = Convert.ToUInt32(Console.ReadLine());
                if (first_grade > 3 && second_grade > 3 && third_grade > 3 && forth_grade > 3)
                {
                    count++;
                }
            }
            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0, taskTime = 10;

            while (time < 3600)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    var seriasTime = Convert.ToInt32(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }
            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    power -= 5;
                    intellect -= 5;
                    agility += 5;
                    break;
                case 3:
                    power += 10;
                    intellect -= 5;
                    break;
                case 4:
                    agility += 15;
                    intellect -= 10;
                    power -= 10;
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    break;
            }

            if (power < 0)
            {
                power = 0;
            }

            if (intellect < 0)
            {
                intellect = 0;
            }

            if (agility < 0)
            {
                agility = 0;
            }
            return (power, agility, intellect);
        }
    }
}
