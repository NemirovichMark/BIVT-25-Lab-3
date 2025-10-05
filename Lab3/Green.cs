using System.Globalization;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here

            for (int i = 0; i < n; i++)
            {
                double x;
                double y;
                double.TryParse(Console.ReadLine(), out x);
                double.TryParse(Console.ReadLine(), out y);
                if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here
            double curlen = 10000000.0;
            for (int i = 0; i < n; i++)
            {
                
                double x;
                double y;
                double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x);
                double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y);
                if (Math.Sqrt(x * x + y * y) < curlen)
                {
                    length = curlen = Math.Sqrt(x * x + y * y);
                    index = i + 1;
                }

            }
            
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            double x;
            while (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x))
            {
                double y;
                x = (double)Math.Clamp(x, 0, Math.PI);
                double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y);
                if ((Math.Sin(x) >= y && y >= 0) && (x >= 0 && x <= Math.PI))
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
                int mark;
                int.TryParse(Console.ReadLine(), out mark);
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
                    area = Math.Abs(a * a - b * b) * Math.PI;
                    break;
                case 3:
                    double height = Math.Sqrt(b * b - (a * a) / 4.0);
                    area = (a * height) / 2;
                    break;
            }            // end

            return area;
        }
    }
}