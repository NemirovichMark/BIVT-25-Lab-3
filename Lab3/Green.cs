using System.Xml;

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
                double proverka = ((x - a) * (x - a)) + ((y - b) * (y - b));
                if (proverka <= r * r)
                {
                    count += 1;
                }
            }
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 10000000;

            // code here
            for (int i = 0; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double dist = Math.Sqrt(x * x + y * y);
                if (dist <= length)
                {
                    length = dist;
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
                string X = Console.ReadLine();
                if (!double.TryParse(X, out double x))
                {
                    break;
                }

                string Y = Console.ReadLine();
                if (!double.TryParse(Y, out double y))
                {
                    break;
                }
                if (y >= 0 && x >= 0 && x <= Math.PI && y <= Math.Sin(x))
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
            switch (type)
            {
                case 1:
                    area = a * b; break;
                case 2:
                    area = Math.Abs(Math.PI * (a * a)  - Math.PI * (b * b)); break;
                case 3:
                    area = 0.25 * a * Math.Sqrt(4 * b * b - a * a); break;
            }
            // end

            return area;
        }
    }
}
