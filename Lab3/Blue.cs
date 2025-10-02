namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            int c = 0;
            for (int i = 0; i < n; i++) {

                double a = Double.Parse(Console.ReadLine());
                if (a < norma){
                    c++;
                }

            }
            milk = (double)c*glass/1000;

            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            double x = 0;
            double y = 0;
            for (int i = 0; i < n; i++)
            {

                x = Double.Parse(Console.ReadLine());
                y = Double.Parse(Console.ReadLine());

                if(x > 0 & y > 0){
                    first++;
                }
                else if (x < 0 & y > 0)
                {
                    second++;
                }
                else if(x < 0 & y < 0)
                {
                    third++;
                }
                else if(x>0 & y < 0)
                {
                    fourth++;
                }
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for(int i = 0; i < n; i++)
            {

            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime = 10;
            int taskTime = 10;

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