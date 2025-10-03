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
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);

                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
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
            for (int i = 1; i <= n; i++)
            {
                bool x1 = double.TryParse(Console.ReadLine(), out double x);
                bool y1 = double.TryParse(Console.ReadLine(), out double y);
                double l = Math.Sqrt(x * x + y * y);

                if (i == 1 || l < length)
                {
                    length = l;
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
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    break;
                }
                if (!double.TryParse(Console.ReadLine(), out double y))
                {
                    break;
                }
                if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
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
                    area = Math.PI * ((b * b) - (a * a));
                    break;
                case 3:
                    double h = Math.Sqrt((b * b) - (a * a * 0.25));
                    area = 0.5 * a * h;
                    break;
            }
            // end

            return area;
        }
    }
}
