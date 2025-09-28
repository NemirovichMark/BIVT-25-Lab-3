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
                double.TryParse(Console.ReadLine(), out double a);
                if (a < norma)
                {
                    milk += glass;
                }
            }
            // end
            milk /= 1000.0;

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for ( int i = 0; i < n; i++ )
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                if ( x > 0 && y > 0 )
                {
                    first++;
                }
                else if ( x < 0 && y > 0 )
                {
                    second++;
                }
                else if ( x<0 && y < 0)
                {
                    third++;
                }
                else if ( x > 0 && y < 0)
                {
                    fourth++;
                }
                else
                {
                    Console.WriteLine("Точка лежит на границе квадрантов.");
                }
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for ( int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int m1);
                int.TryParse(Console.ReadLine(), out int m2);
                int.TryParse(Console.ReadLine(), out int m3);
                int.TryParse(Console.ReadLine(), out int m4);
                if (m1 != 2 && m1 != 3 &&
                m2 != 2 && m2 != 3 &&
                m3 != 2 && m3 != 3 &&
                m4 != 2 && m4 != 3)
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
            int taskTime = 10;
            for ( int i = 0; i < 1440; i++)
            {
                if (time < 1440)
                {
                    if (tasks > 0)
                    {
                        time += taskTime;
                        taskTime += 5;
                        tasks--;
                    }
                    else
                    {
                        int.TryParse(Console.ReadLine(), out int seriasTime);
                        time += seriasTime;
                        serias++;
                    }
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
                    if (intellect < 0) { intellect = 0; }
                    break;
                case 2:
                    agility += 5;
                    power -= 5;
                    if (power < 0) { power = 0; }
                    break;
                case 3:
                    power += 10;
                    intellect -= 3;
                    if (intellect < 0) { intellect = 0; }
                    break;
                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    if (power < 0) { power = 0; }
                    if (intellect < 0) { intellect = 0; }
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    if (power < 0) { power = 0; }
                    break;
            }
            // end

            return (power, agility, intellect);
        }
    }

}
