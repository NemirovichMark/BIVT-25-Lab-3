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
                bool c1 = double.TryParse(Console.ReadLine(), out double x);
                bool c2 = double.TryParse(Console.ReadLine(), out double y);
                if (c1 && c2)
                {
                    if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) <= Math.Pow(r, 2))
                    {
                        count++;
                    }
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
            if (n > 0)
            {
                length = double.MaxValue;
            }
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double CL = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (CL < length)
                {
                    length = CL;
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
            while (true)
            {
                bool c1 = double.TryParse(Console.ReadLine(), out double x);
                bool c2 = double.TryParse(Console.ReadLine(), out double y);
                if (c1 && c2)
                {
                    if (x >= 0 && x <= Math.PI && y <= Math.Sin(x))
                    {
                        count++;
                    }
                }
                else
                {
                    break;
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
            // end

            return score;
        }
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            // code here
            if (type == 1)
            {
                area = a * b;
            }
            else if (type == 2)
            {
                area = Math.Abs(Math.PI * a * a - Math.PI * b * b);
            }
            else if (type == 3)
            {
                double c = (double)(a + b + b) / 2;
                area = Math.Sqrt(c * (c - a) * (c - b) * (c - b));
            }
            // end

            return area;
        }
    }
}
