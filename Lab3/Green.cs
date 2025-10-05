namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;
            
            double r_pow = r * r;
            // code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                double dx = x - a;
                double dy = y - b;

                if (dx * dx + dy * dy <= r_pow)
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

            double lent = 1e10; 
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x * x + y * y < lent)
                {
                    lent = x * x + y * y;
                    length = Math.Sqrt(lent);
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
                string cord_x = Console.ReadLine();
                if (!double.TryParse(cord_x, out double x))
                {
                    break;
                }

                string cord_y = Console.ReadLine();
                if (!double.TryParse(cord_y, out double y))
                {
                    break;
                }

                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
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
                    area = Math.Abs((Math.PI * a * a - Math.PI * b * b));
                    break;

                case 3:
                    double p = (a + b + b) / 2.0;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - b));
                    break;

                default:
                    area = 0;
                    break;
            }
            // end

            return area;
        }
    }
}