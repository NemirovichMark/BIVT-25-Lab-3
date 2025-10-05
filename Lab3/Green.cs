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
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here
            length = 10000;
            for (int i = 0; i<index; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (Math.Sqrt(x * x + y * y) < length)
                {
                    length = Math.Sqrt(x * x + y * y);
                }
                index++;
            }
            Console.WriteLine(length);
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            double x, y;
            string x1, y1;
            while (true)
            {
                x1 = Console.ReadLine();
                if (!double.TryParse(x1, out x))
                {
                    break;
                }
                y1 = Console.ReadLine();
                if (!double.TryParse(y1, out y))
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
            while ((labs > 0) || (cw > 0))
            {
                int mark = int.Parse(Console.ReadLine());
                if (labs>0)
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
                    area = Math.Abs(Math.PI * a * a - Math.PI * b * b); break;
                case 3:
                    area = 0.5*a*Math.Sqrt(b*b-(a*0.5)*(a*0.5)); break;
            }
            // end

            return area;
        }
    }
}