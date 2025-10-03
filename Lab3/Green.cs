namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            for (int i=1;i<=n;i++)
            {
                double.TryParse(Console.ReadLine(),out double x);
                double.TryParse(Console.ReadLine(),out double y);
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
            for (int i=1; i<=n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                double ras=Math.Sqrt(x*x + y*y);
                if (ras<length || length==0)
                {
                    length = ras;
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
            while (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
            {
                if (x > 0 && x < Math.PI && Math.Sin(x) >= y && y >= 0)
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
                int.TryParse(Console.ReadLine(),out int mark);
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
            if (type == 2)
            {
                if (a > b)
                {
                    area = Math.PI * (a * a - b * b);
                }
                else
                    area = Math.PI *( b * b - a * a);
            }
            if (type == 3)
            {
                double h = Math.Sqrt(b * b - a * a / 4.0);
                area = (1 / 2.0) * h * a;
            }
            // end

            return area;
        }
    }
}