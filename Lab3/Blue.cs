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
                double s = glass;
                double ves = Convert.ToDouble(Console.ReadLine());
                if (ves < norma)
                {
                    milk+= glass;
                }

                
            }
            milk = milk / 1000.0;

            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0;i < n;i++)
            {
                bool s1 = double.TryParse(Console.ReadLine(),out double x);
                bool s2 = double.TryParse(Console.ReadLine(), out double y);
                if (x > 0 && y >0)
                {
                    first++;
                }
                else if (x < 0 && y > 0)
                {
                    second++;
                }
                else if (x < 0 &&  y <  0)
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
            for (int i = 0; i <n; i++)
            {
                bool s1 = int.TryParse(Console.ReadLine(), out int a1);
                bool s2 = int.TryParse(Console.ReadLine(), out int a2);
                bool s3 = int.TryParse(Console.ReadLine(), out int a3);
                bool s4 = int.TryParse(Console.ReadLine(), out int a4);
                if (a1 > 3 && a2 > 3 && a3 > 3 && a4 > 3) 
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
            int tasktime = 10;
            int serialstime;
            while (time < 1440)
            {
                if (tasks >0)
                {
                    time += tasktime;
                    tasktime += 5;
                    tasks--;
                }
                else
                {
                    bool s = int.TryParse(Console.ReadLine(), out int seriastime);
                    time += seriastime;
                    serias++;
                }
            }

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
            if (power < 0)
            {
                power = 0;
            }
            if (intellect < 0)
            {
                intellect = 0;
            }
            if (agility < 0)
            {
                agility = 0;
            }
            // end

            return (power, agility, intellect);
        }
        
    }
}
