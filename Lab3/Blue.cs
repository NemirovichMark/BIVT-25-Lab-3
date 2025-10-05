namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            // code here
            double weight = 0;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine().Replace(".", ","), out weight);
                if (weight < norma)
                {
                    milk += glass;
                }
            }
            milk = milk / 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            double x = 0, y = 0;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine().Replace(".", ","), out x);
                double.TryParse(Console.ReadLine().Replace(".", ","), out y);
                if (x > 0 && y > 0)
                {
                    first++;
                }
                else if (x > 0 && y < 0)
                {
                    fourth++;
                }
                else if (x < 0 && y > 0)
                {
                    second++;
                }
                else if (x < 0 && y < 0)
                {
                    third++;
                }
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int score1 = Convert.ToInt32(Console.ReadLine());
                int score2 = Convert.ToInt32(Console.ReadLine());
                int score3 = Convert.ToInt32(Console.ReadLine());
                int score4 = Convert.ToInt32(Console.ReadLine());
                if (score1 > 3 && score2 > 3 && score3 > 3 && score4 > 3)
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

            // end

            return (power, agility, intellect);
        }
    }
}
