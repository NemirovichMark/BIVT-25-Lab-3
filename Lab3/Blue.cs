namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
        for (int i = 1; i <= n; i++)
            {
                double weight = Convert.ToDouble(Console.ReadLine());
                if (weight < norma)
                {
                    milk += glass * 0.001;
                }
            }
            milk = Math.Round(milk, 2);
            // end
            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 && y > 0)
                    first += 1;
                else if (x < 0 && y > 0)
                    second += 1;
                else if (x < 0 && y < 0)
                    third += 1;
                else if (x > 0 && y < 0)
                    fourth += 1;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                byte first_mark = Convert.ToByte(Console.ReadLine());
                byte second_mark = Convert.ToByte(Console.ReadLine());
                byte third_mark = Convert.ToByte(Console.ReadLine());
                byte fourth_mark = Convert.ToByte(Console.ReadLine());
                if ((first_mark != 2) && (first_mark != 3) && (second_mark != 2) && (second_mark != 3) && (third_mark != 2) && (third_mark != 3) && (fourth_mark != 2) && (fourth_mark != 3))
                {
                    count++;
                }  
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
            if (number == 1)
            {
                power += 10;
                intellect -= 5;
            }
            else if (number == 2)
            {
                agility += 5;
                intellect -= 5;
                power -= 5;
            }
            else if (number == 3)
            {
                power += 10;
                intellect -= 5;
            }
            else if (number == 4)
            {
                power -= 10;
                intellect -= 10;
                agility += 15;
            }
            else if (number == 5)
            {
                intellect += 7;
                power -= 5;
            }
            if (power < 0)
                power = 0;
            if (intellect < 0)
                intellect = 0;
            if (agility < 0)
                agility = 0;
            // end

            return (power, agility, intellect);
        }
    }
}
