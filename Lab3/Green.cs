namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            double x;
            double y;
            for (int i = 0; i < n; i++)
            {
                bool q = Double.TryParse(Console.ReadLine(), out x);
                bool w = Double.TryParse(Console.ReadLine(), out y);            
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
            int num = 0;
            double x = 0;
            double y = 0;
            for (int i = 0; i < n; i++)
            {
                bool q = Double.TryParse(Console.ReadLine(), out x);
                bool w = Double.TryParse(Console.ReadLine(), out y);
                num += 1;
                double r = Math.Sqrt(x * x + y * y);
                if (length == 0)
                {
                    length = r;
                    index = num;
                }
                else if (r <= length)
                {
                    length = r;
                    index = num;
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
            double y;
            double pi = 3.1415926535897931;
            while (Double.TryParse(Console.ReadLine(), out x) && Double.TryParse(Console.ReadLine(), out y))
            {
                if ((x >= 0 && x <= pi) && (y >= 0 && y <= Math.Sin(x)))
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
            int mark;
            while (labs > 0 || cw > 0)
            {
                bool q = Int32.TryParse(Console.ReadLine(), out mark);
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
            double pi = 3.1415926535897931;
            switch (type)
            {
                case 1:
                    area = a * b;
                    break;
                case 2:
                    area = Math.Abs(pi * a * a - pi * b * b);
                    break;
                case 3:
                    area = 0.5 * a * Math.Sqrt(b * b - 0.25 * a * a);
                    break;
                default: break;
            }
            // end

            return area;
        }
    }
}