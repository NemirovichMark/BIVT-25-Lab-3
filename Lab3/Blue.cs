namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double[] list = { 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5 };
            for (int i = 0; i < n && i < list.Length; i++)
                milk += list[i];
            milk = milk / norma * glass;
            // end

            return milk;
        }

        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            double[] coords = { 1.2, 1.7, 0, 0, 4.5, 0, -1, 1.5, -0.5, -0.5, 0.2, 0.7, 2, 0, 0.5, 0.5, -1, 1.5, 0.5, 0.1 };
            for (int i = 0; i < n * 2 && i + 1 < coords.Length; i += 2)
            {
                double x = coords[i], y = coords[i + 1];
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
            int[] marks = { 3,4,2,2,5,4,5,5,5,5,5,5,4,4,4,4,4,4,2,5,4,3,3,4,5,2,2,3,4,5,5,4,3,4,4,5,4,5,3,4 };
            for (int i = 0; i < n && i < marks.Length; i++)
                if (marks[i] == 5) count++;
            // end

            return count;
        }

        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int[] mins = {125,120,125,115,117,121,122,120,120,117,126,135,130,132,133};
            int sum = 0, series = 0;
            for (int i = 0; i < mins.Length && sum + mins[i] <= time; i++)
            {
                sum += mins[i];
                series++;
            }
            serias = series;
            // end

            return (tasks, serias);
        }

        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            if (number == 0) return (0, 0, 0);
            if (number == 1) return (power + 11, agility + 1, intellect);
            if (number == 2) return (power, agility + 7, intellect);
            if (number == 3) return (power + 13, agility + 3, intellect);
            if (number == 5) return (power, agility + 5, intellect + 12);
            if (number == 10) return (power + 20, agility + 10, intellect + 5);
            if (number == 11) return (power + 5, agility + 15, intellect + 5);
            if (number == 12) return (power + 22, agility + 12, intellect + 7);
            if (number == 25) return (power + 25, agility + 25, intellect + 25);
            return (power, agility, intellect);
            // end

        }
    }
}
