namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double[] list = { 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5 };
            double sum = 0;
            for (int i = 0; i < n && i < list.Length; i++)
                sum += list[i];
            milk = sum / norma * glass;
            // end

            return milk;
        }

        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            double[] coords =
            {
                1.2, 1.7, 0, 0, 4.5, 0, -1, 1.5, -0.5, -0.5,
                0.2, 0.7, 2, 0, 0.5, 0.5, -1, 1.5, 0.5, 0.1
            };
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
            int[] marks =
            {
                3,4,2,2,5,4,5,5,5,5,5,5,4,4,4,4,4,4,2,5,4,3,3,4,5,2,2,3,4,5,
                5,4,3,4,4,5,4,5,3,4
            };
            for (int i = 0; i < n && i < marks.Length; i++)
                if (marks[i] == 5) count++;
            // end

            return count;
        }

        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int[] mins =
            {
                125,120,125,115,117,121,122,120,120,117,
                126,135,130,132,133
            };
            int total = 0;
            for (int i = 0; i < mins.Length; i++)
            {
                if (total + mins[i] <= time)
                {
                    total += mins[i];
                    serias++;
                }
                else break;
            }
            // end

            return (tasks, serias);
        }

        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            if (number == 0)
            {
                return (power, agility, intellect);
            }
            else if (number == 1)
            {
                power += 11;
                agility += 1;
            }
            else if (number == 2)
            {
                agility += 7;
            }
            else if (number == 3)
            {
                power += 13;
                agility += 3;
            }
            else if (number == 5)
            {
                agility += 5;
                intellect += 12;
            }
            else if (number == 10)
            {
                power += 20;
                agility += 10;
                intellect += 5;
            }
            else if (number == 11)
            {
                power += 5;
                agility += 15;
                intellect += 5;
            }
            else if (number == 12)
            {
                power += 22;
                agility += 12;
                intellect += 7;
            }
            else if (number == 25)
            {
                power += 25;
                agility += 25;
                intellect += 25;
            }
            // end

            return (power, agility, intellect);
        }
    }
}
