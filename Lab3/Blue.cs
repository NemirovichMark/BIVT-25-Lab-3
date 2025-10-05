namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            for (int i = 0; i < n; i++)
            {
                double weight = Convert.ToDouble(Console.ReadLine());

                if (weight < norma)
                    milk += glass;
            }
            Console.WriteLine(milk / 1000);

            return milk / 1000;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            for (int i = 0; i < n; i++)
            {
                double dotX = Convert.ToDouble(Console.ReadLine());
                double dotY = Convert.ToDouble(Console.ReadLine());

                if (dotX > 0 && dotY > 0)
                    first++;
                if (dotX < 0 && dotY > 0)
                    second++;
                if (dotX < 0 && dotY < 0) 
                    third++;
                if (dotX > 0 && dotY < 0)
                    fourth++;
            }

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            for(int i = 0; i < n; i++)
            {
                int first = Convert.ToInt32(Console.ReadLine());
                int second = Convert.ToInt32(Console.ReadLine());
                int third = Convert.ToInt32(Console.ReadLine());
                int forth = Convert.ToInt32(Console.ReadLine());
                
                if (first > 3 && second > 3 && third > 3 && forth > 3)
                    count++;
            }

            return count;
        }

        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int seriasTime;
            int taskTime = 10;
            
            while (time < 24)
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
            if (number == 1 || number == 3)
                power += 10;
            if (number == 2)
                agility += 5;
            if (number == 4)
                agility += 15;
            if (number == 5)
                intellect += 7;

            if (number >= 1 && number <= 3)
                intellect -= 5;
            if (number == 2 || number == 5)
                power -= 5;
            if (number == 4)
            {
                power -= 10;
                intellect -= 10;
            }

            power = Math.Max(power, 0);
            agility = Math.Max(agility, 0);
            intellect = Math.Max(intellect, 0);

            return (power, agility, intellect);
        }

    }
}
