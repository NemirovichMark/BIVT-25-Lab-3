using System.ComponentModel.DataAnnotations;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            double x, y;
            for(int i = 0; i < n; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) { count++; Console.WriteLine(true); }
            }
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here
            double x, y;
            if (n != 0) length = 1e9;
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                if (Math.Abs(x * x + y * y) < length) {length = Math.Abs(x * x + y * y);index = i + 1;}
            }
            // end
            return (index, Math.Sqrt(length));
        }
        public int Task3()
        {
            int count = 0;

            // code here
            double pi = Math.PI;
            while (double.TryParse(Console.ReadLine(), out var x) && double.TryParse(Console.ReadLine(), out var y))
            {
                if (0 <= x && x <= pi && y >= 0 && y <= Math.Sin(x))
                {
                    count++; Console.WriteLine(true);
                }
            }
            // end

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            while(labs > 0 || cw > 0)
            {
                int.TryParse(Console.ReadLine(), out var mark);
                if (labs > 0)
                {
                    score+=mark;
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
            // code here
            double A = a, B = b;
            double p = A + B + b;
            p /= 2;
            switch (type)
            {
                case 1:
                    return a * b;
                case 2:
                    return (double) Math.Abs(a * a - b * b) * Math.PI;
                case 3:
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - b));
                default:
                    return 0;
            }
            // end
        }
    }
}
