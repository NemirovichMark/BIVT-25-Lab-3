namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for(int i = 0; i < n; i++)
            {
                bool m = Double.TryParse(Console.ReadLine(), out double x);
                if (x < norma)
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
            for(int i = 0; i < n; i++)
            {
                bool m = Double.TryParse(Console.ReadLine(), out double x);
                bool l = Double.TryParse(Console.ReadLine(), out double y);
                if(x>0 && y > 0)
                {
                    first++;
                }
                else if(x<0 && y > 0)
                {
                    second++;
                }
                else if(x<0 && y < 0)
                {
                    third++;
                }
                else if(x>0 && y < 0)
                {
                    fourth++;
                }
            }
            //end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
           for(int i = 0; i < n; i++)
            {
                bool p = Int32.TryParse(Console.ReadLine(), out int x1);
                bool q = Int32.TryParse(Console.ReadLine(), out int x2);
                bool r = Int32.TryParse(Console.ReadLine(), out int x3);
                bool s = Int32.TryParse(Console.ReadLine(), out int x4);
                if(x1!=2 && x1!=3 && x2 != 2 && x2 != 3 && x3 != 2 && x3 != 3 && x4 != 2 && x4 != 3)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int  taskTime=10, serias = 0, seriasTime;

            // code here
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
                    bool m = Int32.TryParse(Console.ReadLine(), out seriasTime);
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
            if (number == 1 || number==3)
            {
                power += 10;
                intellect -= 5;
                if(intellect<0)
                {
                    intellect = 0;
                }
            }
            else if (number == 2)
            {
                agility += 5;
                power -= 5;
                if (power < 0)
                {
                    power = 0;
                }
                intellect -= 5;
                if (intellect < 0)
                {
                    intellect = 0;
                }
            }
            else if (number == 5)
            {
                intellect += 7;
                power -= 5;
                if (power < 0)
                {
                    power = 0;
                }
            }
            else if (number == 4)
            {
                agility += 15;
                power -= 10;
                if (power < 0)
                {
                    power = 0;
                }
                intellect -= 10;
                if (intellect < 0)
                {
                    intellect = 0;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(agility);
            Console.WriteLine(intellect);
                // end

                return (power, agility, intellect);
        }
    }
}