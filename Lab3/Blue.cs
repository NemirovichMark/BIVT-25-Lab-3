namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            for (int i = 0; i < n; i++)
            {
                double kg = Convert.ToDouble(Console.ReadLine());
                if (kg < norma)
                {
                    milk += glass;
                }
            }
            milk /= 1000;

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

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
                else if (x != 0 && y != 0)
                {
                    fourth++;
                }
            }

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            int m1 = 0;
            int m2 = 0;
            int m3 = 0;
            int m4 = 0;
            for (int i = 0; i < n; i++)
            {
                m1 = Convert.ToInt32(Console.ReadLine());
                m2 = Convert.ToInt32(Console.ReadLine());
                m3 = Convert.ToInt32(Console.ReadLine());
                m4 = Convert.ToInt32(Console.ReadLine());
                if (m1 > 3 && m2 > 3 && m3 > 3 && m4 > 3)
                {
                    count++;
                }
            }

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

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

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            if (number == 1)
            {
                power += 10;
                intellect -= 5;
            }
            else if (number == 2)
            {
                agility += 5;
                intellect -= 5;
                power -= 5;
            }
            else if (number == 3)
            {
                power += 10;
                intellect -= 5;
            }
            else if (number == 4)
            {
                agility += 15;
                power -= 10;
                intellect -= 10;
            }
            else if (number == 5)
            {
                intellect += 7;
                power -= 5;
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
