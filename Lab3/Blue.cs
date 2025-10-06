namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double w;
            for (int i = 0; i < n; i++)
            {
                w = Convert.ToDouble(Console.ReadLine());
                if (w < (double)norma)
                    milk += glass;
            }
            // end

            return milk/1000;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;
            double x, y;
            // code here
            for (int i=1;i<=n;i++){
                x=Convert.ToDouble((Console.ReadLine()));
                y=Convert.ToDouble((Console.ReadLine()));
                if (x > 0 && y > 0) first++;
                else if (y > 0 && x < 0) second++;
                else if (y < 0 && x < 0) third++;
                else if (x > 0 && y < 0) fourth++;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;
            short a, b, c, d;

            // code here
            for (int i = 1; i <= n; i++){
                a=Convert.ToInt16(Console.ReadLine());
                b=Convert.ToInt16(Console.ReadLine());
                c=Convert.ToInt16(Console.ReadLine());
                d=Convert.ToInt16(Console.ReadLine());
                if (a > 3 && b > 3 && c > 3 && d > 3) count++;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0, seriasTime, taskTime=10;

            // code here
            while (time < 24 * 60) {
                if (tasks > 0) {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else {
                    seriasTime = Convert.ToInt32(Console.ReadLine());
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
                case 3:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    agility += 5;
                    power -= 5;
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
            if (power < 0) power = 0;
            if (agility < 0) agility = 0;
            if (intellect < 0) intellect = 0;
            // end

            return (power, agility, intellect);
        }
    }
}
