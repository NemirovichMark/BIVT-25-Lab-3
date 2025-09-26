namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double weight = 0;
            double glassMl = glass * 0.001;
            for (int x = 0; x < n; x++)
            {
                while (double.TryParse(Console.ReadLine().Replace('.', ','), out weight) != true) ;
                if (weight < norma)
                {
                    milk += glassMl;
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
            for (int i = 0; i < n; i++)
            {
                double x, y = 0;
                while (double.TryParse(Console.ReadLine().Replace('.', ','), out x) != true);
                while (double.TryParse(Console.ReadLine().Replace('.', ','), out y) != true);
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
            int k = 0;
            int score = 0;
            bool deb = true;
            for (int i = 0; i < n * 4; i++)
            {
                while (int.TryParse(Console.ReadLine(), out score) != true) ;
                k++;
                if (score == 2 || score == 3) deb = false;
                if (k == 4 && deb == true)
                {
                    count += Convert.ToInt16(deb);
                    k = 0;
                }
                else if (k == 4 && deb == false)
                {
                    k = 0;
                    deb = true;
                }       
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int taskTime = 10;
            int seriasTime;
            while (time < 24*60)
            {
                if (tasks > 0)
                {
                    time+=taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    while (int.TryParse(Console.ReadLine(), out seriasTime) != true);
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

            // end

            return (power, agility, intellect);
        }
    }
}