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
                double.TryParse(Console.ReadLine(), out double w);
                if (w < norma)
                {
                    milk += glass;
                }
            }
            milk /= 1000;

            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here

            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                if (y > 0)
                {
                    if (x > 0)
                    {
                        first++;
                    }
                    else if (x < 0)
                    {
                        second++;
                    }
                }
                else if (y < 0)
                {
                    if (x < 0)
                    {
                        third++;
                    }
                    else if (x > 0)
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

            for (int i = 0; i < n; ++i)
            {
                int.TryParse(Console.ReadLine(), out int a);
                int.TryParse(Console.ReadLine(), out int b);
                int.TryParse(Console.ReadLine(), out int c);
                int.TryParse(Console.ReadLine(), out int d);
                int min_mark = Math.Min(Math.Min(a, b), Math.Min(c, d));
                if (min_mark >= 4)
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

            while (time < 24 * 60)
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

            switch(number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    power -= 5;
                    agility += 5;
                    intellect -= 5;
                    break;
                case 3:
                    power += 10;
                    intellect -= 5;
                    break;
                case 4:
                    power -= 10;
                    agility += 15;
                    intellect -= 10;
                    break;
                case 5:
                    power -= 5;
                    intellect += 7;
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