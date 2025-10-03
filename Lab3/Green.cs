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
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
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

            // code here
            double mx = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double x, y;
                double.TryParse(Console.ReadLine(), out x);
                double.TryParse(Console.ReadLine(), out y);
                length = (Math.Sqrt(x * x + y * y));
                if (length < mx)
                {
                    mx = length;
                    index = i + 1;
                }
            }
            length = mx;
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            bool fl = true;
            while (fl)
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
                    fl = false;
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
                int mark = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("Дружище, есть потенциал, что это не треугольник");
                    break;
            }
            // end

            return area;
        }
    }
}
