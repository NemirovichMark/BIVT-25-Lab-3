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
                var res = double.TryParse(Console.ReadLine(), out double mas);
                if (mas < norma)
                {
                    milk += glass;
                }
            }
            milk /= 1000;
            Console.WriteLine(milk);
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                var res = double.TryParse(Console.ReadLine(), out double x);
                var res2 = double.TryParse(Console.ReadLine(), out double y);
                if (x > 0 && y > 0) first++;
                else if (x < 0 && y > 0) second++;
                else if (x < 0 && y < 0) third++;
                else if (x > 0 && y < 0) fourth++;
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
                var x1 = int.TryParse(Console.ReadLine(), out int res1);
                var x2 = int.TryParse(Console.ReadLine(), out int res2);
                var x3 = int.TryParse(Console.ReadLine(), out int res3);
                var x4 = int.TryParse(Console.ReadLine(), out int res4);
                if (res1 != 2 && res1 != 3 && res2 != 2 && res2 != 3 && res3 != 2 && res3 != 3 && res4 != 2 && res4 != 3) count++;
            }
            Console.WriteLine(count);
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10;
            while (time/60 < 24 )
            {
                if (tasks > 0 )
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
            if (number == 1)
            {
                power += 10;
                intellect -= 5;
            }
            else if (number == 2)
            {
                agility += 5;
                power -= 5;
                intellect -= 5;
            }
            else if (number == 3)
            {
                power += 10;
                intellect -= 5;
            }
            else if (number == 4) 
            {
                agility += 15;
                power -= 10;
                intellect -= 10;
            }
            else if (number == 5)
            {
                intellect += 7;
                power -= 5;
            }
            if (power < 0) power = 0;
            if (agility < 0) agility = 0;
            if (intellect < 0) intellect = 0;
            // end

            return (power, agility, intellect);
        }
    }
}
