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
                double weight = double.Parse(Console.ReadLine());
                if (weight < norma)
                { milk++; }
            }

            // end
            Console.WriteLine((milk * glass) / 1000);
            return (milk * glass) / 1000;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
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
            for (int i = 0; i < n; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int n3 = int.Parse(Console.ReadLine());
                int n4 = int.Parse(Console.ReadLine());
                if ((n1 > 3) && (n2 > 3) && (n3 > 3) && (n4 > 3))
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
            int seriasTime;
            int taskTime = 10;
            // code here
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
                    seriasTime = int.Parse(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }
            // end

            return (tasks, serias);
        }
        public (int, int, int) Task5(int power, int agility, int intellect, int number)
        {
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    agility += 5;
                    power -= 5;
                    intellect -= 5;
                    break;
                case 3:
                    power += 10;
                    intellect -= 5;
                    break;
                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    break;
            }

            power = Math.Max(0, power);
            agility = Math.Max(0, agility);
            intellect = Math.Max(0, intellect);

            return (power, agility, intellect);
        }
    }
}
    