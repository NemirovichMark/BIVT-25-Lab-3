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
                int weight = int.Parse(Console.ReadLine());
                if (weight < norma)
                {
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
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

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
                bool hasBadGrade = false;
                for (int j = 0; j < 4; j++)
                {
                    int grade = int.Parse(Console.ReadLine());
                    if (grade == 2 || grade == 3)
                    {
                        hasBadGrade = true;
                    }
                }
                if (!hasBadGrade) count++;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int sessionTime;
            int taskTime = 10;

            while (time < 2400 && tasks > 0)
            {
                sessionTime = int.Parse(Console.ReadLine());
                taskTime = 5;
                serias = 1;
                tasks--;
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            if (number == 1 || number == 3)
            {
                power += 10;
            }
            if (number == 2)
            {
                agility += 5;
            }
            if (number == 4)
            {
                agility += 15;
            }
            if (number == 5)
            {
                intellect += 7;
            }

            // Уменьшения
            if (number == 1 || number == 2 || number == 3)
            {
                intellect -= 5;
            }
            if (number == 2 || number == 5)
            {
                power -= 5;
            }
            if (number == 4)
            {
                power -= 10;
                intellect -= 10;
            }

            // Проверка на минимальное значение 0
            if (power < 0) power = 0;
            if (agility < 0) agility = 0;
            if (intellect < 0) intellect = 0;
            // end

            return (power, agility, intellect);
        }
    }
}
