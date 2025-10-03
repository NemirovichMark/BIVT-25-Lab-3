using System.Diagnostics;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for (int i = 0; i != n; i++)
            {
                Console.Write("вес ученика: ");
                double wes = Convert.ToDouble(Console.ReadLine());
                if (wes < norma)
                {
                    milk += glass;
                }

            }
            milk = milk / 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;
            int s1 = first;
            int s2 = second;
            int s3 = third;
            int s4 = fourth;
            List<string> k1 = new List<string>();
            List<string> k2 = new List<string>();
            List<string> k3 = new List<string>();
            List<string> k4 = new List<string>();
            // code here
            for (int i = 0; i != n; i++)
            {
                Console.Write("x = ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y = ");
                double y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 && y > 0){ 
                    s1 += 1;
                    k1.Add(Convert.ToString(x) + " " + Convert.ToString(y));
                }
                if (x < 0 && y < 0)
                {
                    s2 += 1;
                    k2.Add(Convert.ToString(x) + " " + Convert.ToString(y));
                }
                if (x < 0 && y > 0)
                {
                    s3 += 1;
                    k3.Add(Convert.ToString(x) + " " + Convert.ToString(y));
                }
                if (x > 0 && y < 0)
                {
                    s4 += 1;
                    k4.Add(Convert.ToString(x) + " " + Convert.ToString(y));
                }


            }
            //Console.WriteLine("1-й = " + k1.Distinct().Count());
            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in k1.Distinct())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(s3);
            //Console.WriteLine("2-й = " + k3.Distinct().Count());
            foreach (var item in k3.Distinct())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(s2);
            //Console.WriteLine("3-й = " + k2.Distinct().Count());
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in k2.Distinct())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(s4);
            //Console.WriteLine("4-й = " + k4.Distinct().Count());
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in k4.Distinct())
            {
                Console.WriteLine(item);
            }

            first = s1;
            second = s3;
            third = s2;
            fourth = s4;

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;
            // code here

            for (int i = 0; i != n; i++)
            {
                bool Flag = true;
                for (int j = 0; j != 4; j++) {
                    int s = Convert.ToInt32(Console.ReadLine());
                    if (s < 4) Flag = false;
                }
                if (Flag) count++;
           
            }

            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int TaskTime = 10;
            
            // code here
            while (time/60 < 24)
            {
                if (tasks > 0)
                {
                    time += TaskTime;
                    TaskTime += 5;
                    tasks--;
                }
                else
                { 
                    time += Convert.ToInt32(Console.ReadLine());
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
