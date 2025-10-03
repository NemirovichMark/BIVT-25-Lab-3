namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                double x, y;
                string X = Console.ReadLine();
                string Y = Console.ReadLine();
                bool k1 = Double.TryParse(X, out x);
                bool k2 = Double.TryParse(Y, out y);
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                    count++;
            }
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here
            double lenght1;
            for (int i = 1; i <= n; i++)
            {
                Double.TryParse(Console.ReadLine(), out double x);
                Double.TryParse(Console.ReadLine(), out double y);
                double current = Math.Sqrt(x * x + y * y);
                if (i == 1 || current < length)
                {
                    length = current;
                    index = i;
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
                if (!Double.TryParse(Console.ReadLine(), out double x))
                {
                    break;
                }
                if (!Double.TryParse(Console.ReadLine(), out double y))
                { 
                    break;
                }
                if (y > 0 && y < Math.Sin(x) && x >= 0 && x <= Math.PI)
                    count++;
            }
            // end

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            while (labs > 0)
            {
                Int32.TryParse(Console.ReadLine(), out int mark);
                score += mark;
                labs--;
            }
            while (cw > 0)
            {
                Int32.TryParse(Console.ReadLine(), out int mark);
                score += 4 * mark;
                cw--;
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
                    area = Math.PI * (b * b - a * a);
                    break;
                case 3:
                    if (b * b >= (a * a) / 4.0)
                    {
                        double h = Math.Sqrt(b * b - (a * a) / 4.0);
                        area = 0.5 * a * h;
                    }
                    else
                    {
                        area = 0;
                    }
                    break;
            }
            // end

            return area;
        }
    }
}
