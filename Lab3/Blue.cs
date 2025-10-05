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
                Console.Write("Введите вес ученика: ");
                int weight = Convert.ToInt32(Console.ReadLine());
                if (weight < norma)
                    milk += glass;
            }

            milk /= 1000.0;
            // end

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
                    first++;
                else if (x < 0 && y > 0)
                    second++;
                else if (x < 0 && y < 0)
                    third++;
                else if (x > 0 && y < 0)
                    fourth++;
                // end

                return (first, second, third, fourth);
            }
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            int badMarks = 0;
            int marksRead = 0;
            for (int i = 0; i < n * 4; i++)
            {
                int mark = Convert.ToInt32(Console.ReadLine());
                marksRead++;

                if (mark == 2 || mark == 3)
                    badMarks++;

                if (marksRead == 4)
                {
                    if (badMarks == 0)
                        count++;

                    marksRead = 0;
                    badMarks = 0;
                }
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int doneTasks = 0;

            // code here
            while (time >= 45 && tasks > 0)
            {
                time -= 45;
                doneTasks++;
                tasks--;

                if (doneTasks % 3 == 0 && tasks > 0)
                {
                    serias++;
                    time -= 30;
                }

                if (time < 45)
                    break;
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

            if (power < 0) power = 0;
            if (agility < 0) agility = 0;
            if (intellect < 0) intellect = 0;
            // end

            return (power, agility, intellect);
        }
    }
}