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
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int weight))
                {
                    if (weight < norma)
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
            for (int i = 0; i < n; i++)
            {
                string? X = Console.ReadLine();
                string? Y = Console.ReadLine();

                if (int.TryParse(X, out int x) && int.TryParse(Y, out int y))
                {
                    if (x > 0 && y > 0) first+=1;
                    else if (x < 0 && y > 0) second+=1;
                    else if (x < 0 && y < 0) third+=1;
                    else if (x > 0 && y < 0) fourth+=1;
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
                bool bad = false;
                for (int j = 0; j < 4; j++)
                {
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int mark))
                    {
                        if (mark == 2 || mark == 3)
                            bad = true;
                    }
                }
                if (!bad)
                    count += 1;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here

            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here

            // end

            return (power, agility, intellect);
        }
    }
}