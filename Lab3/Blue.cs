using System.Security.Cryptography.X509Certificates;

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
                string a = Console.ReadLine();
                double w;
                double.TryParse(a, out w);
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
            string a, b;
            double x, y;
            for (int i = 0; i < n; i++)
            {
                a = Console.ReadLine();
                b = Console.ReadLine();
                double.TryParse(a, out x);
                double.TryParse(b, out y);
                if ((x > 0) && (y > 0))
                {
                    first++;
                }
                else if ((x < 0) && (y > 0))
                {
                    second++;
                }
                else if ((x < 0) && (y < 0))
                {
                    third++;
                }
                else if ((x > 0) && (y < 0))
                {
                    fourth++;
                }
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            string a;
            int IsNew = 0, f = 0, grade;
            for (int i = 0; i < (n * 4); i++)
            {
                a = Console.ReadLine();
                int.TryParse(a, out grade);
                if ((grade == 2) || (grade == 3))
                {
                    f = 1;
                }
                IsNew++;
                if (IsNew == 4)
                {
                    if (f == 0)
                    {
                        count += 1;
                    }
                    f = 0;
                    IsNew = 0;
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
            power = (power + Math.Abs(power)) / 2;
            agility = (agility + Math.Abs(agility)) / 2;
            intellect = (intellect + Math.Abs(intellect)) / 2;
            // end

            return (power, agility, intellect);
        }
    }
}