using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            for (int i = 1;i<=n; i++) 
            {
                double.TryParse(Console.ReadLine(), out double X);
                double.TryParse(Console.ReadLine(), out double Y);
                double dist = (X - a) * (X - a) + (Y - b) * (Y - b);
                if (Math.Sqrt(dist) <= r)
                {
                    count++;
                }
            }

            // end
            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;
            double mindist=0;
            // code here
            if (n > 0)
            {
                mindist = double.MaxValue;
            }
            for (int i = 1; i <= n; i++)
            {
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                double.TryParse(x, out double X);
                double.TryParse(y, out double Y);
                double distance = Math.Sqrt(X * X + Y * Y);
                if (distance < mindist)
                {
                    mindist = distance;
                    index = i;
                    length = mindist;
                }

                // end
            }
                return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (true)
            {
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                if ( (!double.TryParse(x, out double X)) || (!double.TryParse(y, out double Y)))
                {
                    break;
                }
                if (X>=0 && X<=Math.PI && Y>=0 && Y <= Math.Sin(X))
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            while (labs > 0 || cw > 0)
            {
                int.TryParse(Console.ReadLine(), out int mark);
                if (labs > 0)
                {
                    score += mark;
                    labs--;
                }
                else
                {
                    score += 4 * mark;
                    cw--;
                }
            }
            // end

            return score;
        }
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            // code here
            switch (type)
            {
                case 1:
                    area = a * b;
                    break;
                case 2:
                    area = Math.Abs((Math.PI * a * a - Math.PI * b * b));
                    break;
                case 3:
                    double p = (a + b + b) / 2.0;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - b));
                    break;
                default:
                    area = 0;
                    break;
            }
            // end

            return area;
        }
    }
}