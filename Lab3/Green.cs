namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                {
                    count++;
                }
            }

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            double mx = 9999999999999;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (Math.Sqrt(x * x + y * y) <= mx)
                {
                    mx = Math.Sqrt(x * x + y * y);
                    index = i + 1;
                    length = mx;
                }
            }

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            bool f = true;
            while (f)
            {
                double x, y;
                if ((double.TryParse(Console.ReadLine(), out x)) && (double.TryParse(Console.ReadLine(), out y)))
                {
                    if ((x >= 0 && x <= Math.PI) && (y >= 0 && y <= Math.Sin(x)))
                    {
                        count++;
                    }
                }
                else
                {
                    f = false;
                }
            }

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            while (labs > 0 || cw > 0)
            {
                int mark = int.Parse(Console.ReadLine());
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

            return score;
        }
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            switch (type)
            {
                case 1:
                    area = a * b;
                    break;
                case 2:
                    int R = Math.Max(a, b);
                    int r = Math.Min(a, b);
                    area = Math.PI * (R * R - r * r);
                    break;
                case 3:
                    if (2 * b > a)
                    {
                        double h = Math.Sqrt(b * b - (a * a) / 4.0);
                        area = 0.5 * a * h;
                    }
                    break;
                default:
                    break;
            }

            return area;
        }
    }
}
