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
                double weight = Convert.ToDouble(Console.ReadLine());
                if (weight < norma)
                {
                    milk += glass;
                }
            }
            milk /= 1000;
            //end
            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    first++;             
                }
                else if (x<0 && y > 0)
                {
                    second++;
                }
                else if (x < 0 && y < 0)
                {
                    third++;
                }
                else if (x > 0 && y < 0)
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
                int ocenka1_ = Convert.ToInt32(Console.ReadLine());
                int ocenka2_ = Convert.ToInt32(Console.ReadLine());
                int ocenka3_ = Convert.ToInt32(Console.ReadLine());
                int ocenka4_ = Convert.ToInt32(Console.ReadLine());
                if ((ocenka1_ != 2 && ocenka1_ != 3) && (ocenka2_ != 2 && ocenka2_ != 3) && (ocenka3_ != 2 && ocenka3_ != 3) && (ocenka4_ != 2 && ocenka4_ != 3))
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
            do
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
            } while (time < 24 * 60);
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
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
            if (power < 0) {
                do
                {
                    power++;
                } while (power !< 0);
            }
            if (agility < 0)
            {
                do
                {
                    agility++;
                } while (agility !< 0);
            }
            if (intellect < 0)
            {
                do
                {
                    intellect++;
                } while (intellect !< 0);
            }

            // end

            return (power, agility, intellect);
        }
    }
}