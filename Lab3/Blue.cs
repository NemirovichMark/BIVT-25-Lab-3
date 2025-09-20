namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double weight;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out weight);
                if (weight < norma)
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
            double x, y;
            for (int i = 0; i < n; i++)
            {
                double.TryParse((Console.ReadLine()), out x);
                double.TryParse((Console.ReadLine()), out y);
                if (x > 0)
                {
                    if (y > 0)
                    {
                        first++;
                    }
                    else if (y < 0)
                    {
                        fourth++;
                    }
                }
                else if (x < 0)
                {
                    if (y > 0)
                    {
                        second++;
                    }
                    else if (y < 0)
                    {
                        third++;
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
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                int.TryParse((Console.ReadLine()), out int a);
                int.TryParse((Console.ReadLine()), out int b);
                int.TryParse((Console.ReadLine()), out int c);
                int.TryParse((Console.ReadLine()), out int d);
                if ((a != 2) && (a != 3)) k++;
                if ((b != 2) && (b != 3)) k++;
                if ((c != 2) && (c != 3)) k++;
                if ((d != 2) && (d != 3)) k++;
                if (k == 4) count++;
                k = 0;
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
                case 0: break;
                case 1:
                    power += 10; intellect = Math.Max(intellect - 5, 0);
                    break;
                case 2:
                    agility += 5; power = Math.Max(power - 5, 0); intellect = Math.Max(intellect - 5, 0);
                    break;
                case 3:
                    power += 10; intellect = Math.Max(intellect - 5, 0);
                    break;
                case 4:
                    agility += 15; power = Math.Max(power - 10, 0); intellect = Math.Max(intellect - 10, 0);
                    break;
                case 5:
                    intellect += 7; power = Math.Max(power - 5, 0);
                    break;
            }
            // end

            return (power, agility, intellect);
        }
    }

}
