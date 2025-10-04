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
                if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
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
            if (n > 0) length = double.MaxValue;
            double length1 = 0;
            for (int i = 1; i <= n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                length1 = Math.Sqrt(x * x + y * y);
                if (length1 < length)
                {
                    index = i;
                    length = length1;
                }
            }
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
                if (x > 0 && y <= Math.Sin(x))
                    count++;
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
                    area = a * b; break;
                case 2:
                    area = Math.Abs(a * a * Math.PI - b * b * Math.PI); break;
                case 3:
                    double p = (a + b + b) / 2.0;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - b));
                    break;
            }
            // end

            return area;
        }
    }
}
