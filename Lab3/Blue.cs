using System.Net.Http.Headers;

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
                double s = double.Parse(Console.ReadLine());
                if (s < norma){
                    milk += glass/1000.0;
                }

            }
            milk = Math.Round(milk, 3);
            // end
            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            //code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    first += 1;
                }
                else if (x > 0 && y < 0)
                {
                    fourth += 1;
                }
                else if (x < 0 && y > 0)
                {
                    second += 1;
                }
                else if (x < 0 && y < 0)
                {
                    third += 1;
                }
            }
            //end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                bool fl = false;
                for (int j = 0; j < 4; j++)
                {
                    int grade = int.Parse(Console.ReadLine());
                    switch (grade)
                    {
                        case 2:
                        case 3:
                            fl = true;
                            break;
                    }
                }
                if (!fl)
                {
                    count ++;
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
                    seriasTime = Convert.ToInt32(Console.ReadLine());
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
                intellect = Math.Max(intellect - 5, 0);
            }
            else if (number == 2)
            {
                agility += 5;
                power = Math.Max(power - 5, 0);
                intellect = Math.Max(intellect - 5, 0);
            }
            else if (number == 3)
            {
                power += 10;
                intellect = Math.Max(intellect - 5, 0);
            }
            else if (number == 4)
            {
                agility += 15;
                power = Math.Max(power - 10, 0);
                intellect = Math.Max(intellect - 10, 0);
            }
            else if (number == 5) 
            {
                intellect += 7;
                power = Math.Max(power - 5, 0);
            }
            // end

            return (power, agility, intellect);
        }
    }
}
