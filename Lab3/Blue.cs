namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            
            
            int i = 1;
            while (i <= n)
            {
                
                string cons = Console.ReadLine();
                double weight;
                bool pars = double.TryParse(cons, out weight);

                if (pars && weight < norma)
                {
                    milk += glass;
                }

                i++;
            }

            milk = milk / 1000.0;

            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;
            // code here
            int i = 1;
            while (i <= n)
            {
                double x, y;

                string ent1 = Console.ReadLine();
                bool ch = double.TryParse(ent1, out x);

                string ent2 = Console.ReadLine();
                bool ch1 = double.TryParse(ent2, out y);

                if (x > 0 && y > 0)
                    first++;
                else if (x < 0 && y > 0)
                    second++;
                else if (x < 0 && y < 0)
                    third++;
                else if (x > 0 && y < 0)
                    fourth++;

                i++;
            }
            // end
            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            
            int i = 1;

            while (i <= n)
            {
                bool hasBadMark = false; // признак того, что у студента есть 2 или 3
                int j = 1;

                while (j <= 4) // 4 экзамена
                {
                    string input = Console.ReadLine();
                    bool parsed = int.TryParse(input, out int mark);

                    if (parsed && (mark == 2 || mark == 3))
                        hasBadMark = true;

                    j++;
                }

                if (hasBadMark == false) // если нет 2 и 3
                    count++;

                i++;
            }

            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10;
            while (time < 1440) {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks --;
                }
                else
                {
                    string input = Console.ReadLine();
                    bool parsed = int.TryParse(input, out seriasTime);
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
                    intellect -= 10;
                    power -= 10;
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    break;
                default:
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