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
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
            
                double xa = x - a;
                double yb = y - b;
                
                if (xa * xa + yb * yb <= r * r)
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
            for (int i = 1; i <= n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                double smth = Math.Sqrt(x * x + y * y);
                if (i == 1)
                    length = smth;

                if (smth <= length)
                {
                    index = i;
                    length = smth;
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
                    break;
                
                if (!double.TryParse(Console.ReadLine(), out double y))
                    break;

                if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x))
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
            while (true)
            {
                if (labs > 0 || cw > 0)
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
                else
                    break;

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
                    area = Math.PI * (Math.Max(a,b) * Math.Max(a,b) - Math.Min(a,b) *  Math.Min(a,b));
                    break;
                case 3:
                    area = (a / 4.0) * Math.Sqrt(4 * b * b - a * a);
                    break;
            }
            // end

            return area;
        }
    }
}
