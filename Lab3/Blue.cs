namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            while (n > 0)
            {
                double.TryParse(Console.ReadLine(), out double x);
                if (x < (double)norma)
                {
                    milk += (double)glass;
                }
                --n;
            }
            milk /= 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            while (n > 0)
            {
                double.TryParse((Console.ReadLine()), out double x);
                double.TryParse((Console.ReadLine()), out double y);
                if (x > 0 && y > 0)
                {
                    ++first;
                }
                else if (x < 0 && y > 0)
                {
                    ++second;
                }
                else if (x < 0 && y < 0)
                {
                    ++third;
                }
                else if (x > 0 && y < 0)
                {
                    ++fourth;
                }
                --n;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            while (n > 0)
            {
                int.TryParse(Console.ReadLine(), out int x1);
                int.TryParse(Console.ReadLine(), out int x2);
                int.TryParse(Console.ReadLine(), out int x3);
                int.TryParse(Console.ReadLine(), out int x4);
                if (x1 > 3 && x2 > 3 && x3 > 3 && x4 > 3)
                {
                    ++count;
                }
                --n;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10;
            serias = 0;
            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    --tasks;
                }
                else
                {
                    int.TryParse(Console.ReadLine(), out seriasTime);
                    time += seriasTime;
                    ++serias;
                }
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            if (number == 1 || number == 3)
            {
                power += 10;
                intellect = (intellect >= 5 ? intellect - 5 : 0);
            }
            else if (number == 2)
            {
                agility += 5;
                intellect = (intellect >= 5 ? intellect - 5 : 0);
                power = (power >= 5 ? power - 5 : 0);
            }
            else if (number == 4)
            {
                agility += 15;
                intellect = (intellect >= 10 ? intellect - 10 : 0);
                power = (power >= 10 ? power - 10 : 0);
            }
            else if (number == 5)
            {
                intellect += 7;
                power = (power >= 5 ? power - 5 : 0);
            }
            // end

            return (power, agility, intellect);
        }
    }
}