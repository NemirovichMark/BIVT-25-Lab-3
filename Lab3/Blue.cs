namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk= 0;

            // code here
            for (int i = 0; i < n; i+=1)
            {
                double weight = Convert.ToDouble(Console.ReadLine());
                if (weight < norma)
                {
                    milk += glass;
                }
            }
            milk = milk/ 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            double x, y;
            for (int i = 0; i < n; i += 1)
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                    first += 1;
                else if (x < 0 && y > 0)
                    second += 1;
                else if (x < 0 && y < 0)
                    third += 1;
                else if (x > 0 && y < 0)
                    fourth+=1;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i += 1)
            {
                int f = 1;
                for (int j = 0; j < n; j += 1)
                {
                    int o = int.Parse(Console.ReadLine());
                    if (o == 2 || o == 3)
                        f = 0;
                }
                if (f == 1)
                    count += 1;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int serias_time, task_time = 10;
            do
            {
                if (tasks > 0)
                {
                    time += task_time;
                    task_time += 5;
                    tasks--;
                }
                else
                {
                    serias_time = int.Parse(Console.ReadLine());
                    time += serias_time;
                    serias += 1;
                }
            }
            while (time < 24 * 60);
            // end

            return (tasks, serias);
        }
        public (int power, int agil, int intel) Task5(int power, int agil, int intel, int num)
        {

            // code here
            switch (num)
            {
                case 1:
                    power += 10;
                    intel -= 5;
                    break;
                case 2:
                    agil += 5;
                    intel -= 5;
                    power -= 5;
                    break;
                case 3:
                    power += 10;
                    intel -= 5;
                    break;
                case 4:
                    agil += 15;
                    power -= 10;
                    intel -= 10;
                    break;
                case 5:
                    intel += 7;
                    power -= 5;
                    break;
                default:
                    break;
            }
            if (power < 0)
                power = 0;
            if (agil < 0)
                agil = 0;
            if (intel < 0)
                intel = 0;
            // end

            return (power, agil, intel);
        }
    }
}
