namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            // code here 
            double a = Convert.ToDouble(glass) / 1000;
            for (int i = 1; i <= n; i++)
            {
                double weight = Convert.ToDouble(Console.ReadLine());
                if (weight < norma) milk += a;
            }
            milk = Math.Round(milk, 2);
            // end 

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 && y > 0) first++;
                if (x > 0 && y < 0) fourth++;
                if (x < 0 && y > 0) second++;
                if (x < 0 && y < 0) third++;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                int s1 = Convert.ToInt32(Console.ReadLine());
                int s2 = Convert.ToInt32(Console.ReadLine());
                int s3 = Convert.ToInt32(Console.ReadLine());
                int s4 = Convert.ToInt32(Console.ReadLine());
                if (s1 != 2 && s1 != 3 && s2 != 2 && s2 != 3 && s3 != 2 && s3 != 3 && s4 != 2 && s4 != 3) count++;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int seriasTime;
            int taskTime = 10;
            // code here
            while (time < 1440)
            {
                if (tasks > 0) { time += taskTime;taskTime += 5;tasks--; }
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
                intellect -= 5;
                if (intellect < 0) intellect = 0;
            }
            if (number == 2)
            {
                agility += 5;
                intellect -= 5;
                if (intellect < 0) intellect = 0;
                power -= 5;
                if (power < 0) power = 0;
            }
            if (number == 3)
            {
                intellect -= 5;
                if (intellect < 0) intellect = 0;
                power += 10;
            }
            if (number == 4)
            {
                agility += 15;
                intellect -= 10;
                if (intellect < 0) intellect = 0;
                power -= 10;
                if (power < 0) power = 0;
            }
            if (number == 5)
            {
                intellect += 7;
                power -= 5;
                if (power < 0) power = 0;
            }
            // end

                return (power, agility, intellect);
        }
    }
}
