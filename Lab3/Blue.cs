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
                int wes = Convert.ToInt32(Console.ReadLine());
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

            // code here
            for (int i = 0; i != n; i++)
            {
                Console.WriteLine("x = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                if (x > 0 & y > 0) s1 += 1;
                if (x < 0 & y < 0) s2 += 1;
                if (x < 0 & y > 0) s3 += 1;
                if (x > 0 & y < 0) s4 += 1;
                

            }
            Console.WriteLine("1-й = " + s1);
            Console.WriteLine("2-й = " + s3);
            Console.WriteLine("3-й = " + s2);
            Console.WriteLine("4-й = " + s4);
            first = s1;
            second = s2;
            third = s3;
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
                bool fl = true;
                Console.Write("Оценки: (через пробел) = ");
                string[] Marks = Console.ReadLine().Split();
                foreach (string s in Marks)

                {
                    if (Convert.ToInt32(s) < 4) fl = false;
                    break;
                }
                if (fl) { count++; }

            }
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
