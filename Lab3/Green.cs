using System.Data.SqlTypes;
using System.Runtime;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here

            for(int i = 0; i < n; i++)
            {
                string sx = Console.ReadLine().Replace('.', ',');
                string sy = Console.ReadLine().Replace('.', ',');

                double x = double.Parse(sx);
                double y = double.Parse(sy);
                double d = Math.Sqrt(((x - a) * (x - a)) + ((y - b) * (y - b)));
                if(d <= r)
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
            double length = 1000000;

            // code here

            for(int i = 0; i < n; i++)
            {
                string sx = Console.ReadLine().Replace('.', ',');
                string sy = Console.ReadLine().Replace('.', ',');
                double x = double.Parse(sx);
                double y = double.Parse(sy);
                double d = Math.Sqrt(x * x + y * y);
                if(d < length)
                {
                    index = i+1;
                    length = d;
                }
            }

            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here

            while (true)
            {
                string sx = Console.ReadLine().Replace('.', ',');
                string sy = Console.ReadLine().Replace('.', ',');
                if (!double.TryParse(sx, out double x))
                {
                    break;
                }
                if(!double.TryParse(sy, out double y))
                {
                    break;
                }
                if(x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
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

            while(labs > 0 || cw > 0)
            {
                string m = Console.ReadLine();
                int mark = Convert.ToInt32(m);
                if(labs > 0)
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
                    double R = Math.Max(a, b);
                    double r = Math.Min(a, b);
                    area = Math.PI * (R * R - r * r);
                    break;
                case 3:
                    double h = Math.Sqrt(b * b - (a * a) / 4.0);
                    area = 0.5 * a * h;
                    break;
                default:
                    break;
            }

            // end

            return area;
        }
    }
}
