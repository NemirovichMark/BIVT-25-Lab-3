using System.Collections.Generic;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here

            List<double> list = new List<double>();
            for (int i = 0; i <= n; i++)
            {
                double kg = Convert.ToDouble(Console.ReadLine());
                list.Add(kg);
            }
            
            foreach (double kg in list)
            {
                if (kg < norma)
                {
                    milk += 2 * glass;
                }
                else
                {
                    milk += kg;
                }
            }

            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here

            List<double> list = new List<double>();
            for (int i = 0; i <= n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                list.Add(x);
                double y = Convert.ToDouble(Console.ReadLine());
                list.Add(y);
            }


            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here

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
