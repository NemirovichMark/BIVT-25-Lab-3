using System.Security.Cryptography;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            int nenorma = 0;
            int[] kg;
            for (int i=1; i==n; i++)
            {
                kg.Append(int.Parse(Console.ReadLine()));
                if (kg[kg.Length - 1] < norma)
                {
                    nenorma++;
                }
            }

            milk = (nenorma + n) * glass / 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            int[][] grades = new int[n][];
            for (int i=0; i < n; i++)
            {

            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime;
            int taskTime = 10;
            serias = 0;
           while (time < 24)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;

                }
                else
                {
                    seriasTime = int.Parse(Console.ReadLine());
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



