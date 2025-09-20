namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            for (int i = 0; i < n; i++)
            {
                double weight = double.Parse(Console.ReadLine());
                if (weight < norma) milk += glass;
            }
            
            milk /= 1000.0;
            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0) 
                    first++;
                else if  (x < 0 && y > 0)
                    second++;
                else if (x < 0 && y < 0) 
                    third++;
                else if (x >  0 && y < 0) 
                    fourth++;
                
            }

            return (first, second, third, fourth);  
        }
        public int Task3(int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int third = int.Parse(Console.ReadLine());
                int fourth = int.Parse(Console.ReadLine());
                
                if (first != 2 && first != 3 && second != 2 && second != 3 && third != 2 && third != 3 && fourth != 2 &&
                    fourth != 3)
                {
                    count++;
                }

            }

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int seriasTime, taskTime = 10;

            while (time < 60 * 24)
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
            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect = Math.Max(0, intellect - 5);
                    break;
                case 2:
                    agility += 5;
                    power = Math.Max(0, power - 5);
                    intellect = Math.Max(0, intellect - 5);
                    break;
                case 3:
                    power += 10;
                    intellect = Math.Max(0, intellect - 5);
                    break;
                case 4:
                    agility += 15;
                    power = Math.Max(0, power - 10);
                    intellect = Math.Max(0, intellect - 10);
                    break;
                case 5:
                    intellect += 7;
                    power = Math.Max(0, power - 5);
                    break;
            }

            return (power, agility, intellect);
        }
    }
}