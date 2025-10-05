

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            

            // code here
            for (int i =0;i<n;i++)
            {
                double w=0;
                double.TryParse(Console.ReadLine(), out w);
                Console.WriteLine($"{w}, {norma}");
                if (w<norma)
                {
                    milk += glass/1000.0;
                    Console.WriteLine(milk);
                }
            }
            // end

            return Math.Round(milk, 5);
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                first += (x > 0 && y > 0) ? 1 : 0;
                second += (x < 0 && y > 0) ? 1 : 0;
                third += (x < 0 && y < 0) ? 1 : 0;
                fourth += (x > 0 && y < 0) ? 1 : 0;

            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i =0; i < n; i++)
            {
                bool isNikolay = true;
                for (int j=0;j<4;j++)
                {
                    
                    int.TryParse(Console.ReadLine(), out int o);
                    if (o==2 || o == 3)
                    {
                        isNikolay = false;
                    }
                    
                }
                if (isNikolay)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {

            // code here
            int serias = 0;
            int seriasTime, taskTime = 10;

            while (time < 24 * 60.0)
            {
                
                    if (tasks > 0)
                    {
                        time += taskTime;
                        taskTime += 5;
                        tasks--;
                    } else
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
            switch (number) {
                case 1: 
                    {
                        power += 10;
                        agility += 0;
                        intellect += -5;
                        
                        break;
                    }
                case 2:
                    {
                        power += -5;
                        agility += 5;
                        intellect += -5;

                        break;
                    }
                case 3:
                    {
                        power += 10;
                        agility += 0;
                        intellect += -5;

                        break;
                    }
                case 4:
                    {
                        power += -10;
                        agility += 15;
                        intellect += -10;

                        break;
                    }
                case 5:
                    {
                        power += -5;
                        agility += 0;
                        intellect += 7;

                        break;
                    }

            }
            // end

            return (power > 0 ? power : 0, agility > 0 ? agility : 0, intellect > 0 ? intellect : 0);
        }
    }
}