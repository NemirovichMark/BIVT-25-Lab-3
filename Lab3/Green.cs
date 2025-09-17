namespace Lab3
{
    public class Green
    {
        
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double dx = x - a;
                double dy = y - b;

                if (dx * dx + dy * dy <= r * r)
                {
                    count++;
                }
            }

            return count;
        }

        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 1000000;

            for (int i = 0; i < n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if (Math.Sqrt(x * x + y * y) < length)
                {
                    length = Math.Sqrt(x * x + y * y);
                    index = i + 1;
                }
                
            }
        return (index, length);
        }
        public int Task3()
        {
            //0 <= x <= pi
            //0 <= y <= sin(x)
            int count = 0;
            
            while (true)
            {
                string l1 = Console.ReadLine();

                if (!double.TryParse(l1, out double x))
                {
                    break;
                }
                
                string l2 = Console.ReadLine();
                if (!double.TryParse(l2, out double y))
                {
                    break;
                }

                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                {
                    count++;
                }
            }

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

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
            return score;
        }
        
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            if (type == 1)
            {
                area = a * b;
            } else if (type == 2)
            {
                int r1 = Math.Max(a, b);
                int r2 = Math.Min(a, b);
                area = Math.PI * (r1 * r1 - r2 * r2);
            } else if (type == 3)
            {
                double h = Math.Sqrt(b * b - a/2.0 * a/2.0);
                area = 0.5  * a * h;
            }

            return area;
        }
        
    }
}
