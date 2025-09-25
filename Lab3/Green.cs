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
                bool s = double.TryParse(Console.ReadLine(), out double x);
                bool f = double.TryParse(Console.ReadLine(), out double y);
                if ((x-a)*(x-a) + (y-b)*(y-b) <= r * r)
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
                bool s = double.TryParse(Console.ReadLine(), out double x);
                bool f = double.TryParse(Console.ReadLine(), out double y);
                double current_length = Math.Sqrt(x * x + y * y);

                if (length == 0 || current_length < length)
                {
                    length = current_length;
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
                bool a = double.TryParse(Console.ReadLine(), out double x);
                bool b = double.TryParse(Console.ReadLine(), out double y);
                if (a && b && x >= 0 && x <= Math.PI && y <= Math.Sin(x))
                {
                    count++;
                }
                else if (!a || !b)
                {
                    break;
                }
                else
                {
                    continue;
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
                bool a = Int32.TryParse(Console.ReadLine(), out int mark);
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
                    area = Math.Abs(Math.PI * a * a - Math.PI * b * b);
                    break;
                case 3:
                    area = 0.25 * a * Math.Sqrt(4 * b * b - a * a);
                    break;
            }
                // end

                return area;
        }
    }
}
