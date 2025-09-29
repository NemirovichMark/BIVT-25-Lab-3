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
                //milk += glass;
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

            for (int i = 0; i != n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);

                if (x == 0 || y == 0) continue;

                else if (x > 0 && y > 0) first += 1;
                else if (x < 0 && y > 0) second += 1;
                else if (x < 0 && y < 0) third += 1;
                else if (x > 0 && y < 0) fourth += 1;
            }

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here

            for (int i = 0; i != n; i++)
            {
                int.TryParse(Console.ReadLine(), out int a);
                int.TryParse(Console.ReadLine(), out int b);
                int.TryParse(Console.ReadLine(), out int c);
                int.TryParse(Console.ReadLine(), out int d);

                if (a == 2 || a== 3 || b == 2 || b == 3 || c == 2 || c == 3 || d == 2 || d == 3) continue;
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
                intellect -= 5;
                power += 10;
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
            if (power < 0) power = 0;
            if (agility < 0) agility = 0;
            if (intellect < 0) intellect = 0;
                // end

                return (power, agility, intellect);
        }
    }
}
