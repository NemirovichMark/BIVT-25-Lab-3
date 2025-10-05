using System;

namespace Lab3
{
    public class Green
    {
        public int Task1(int a, int b, int r, int n)
        {
            int count = 0;
            int rSquared = r * r;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                double dx = x - a;
                double dy = y - b;
                double distanceSquared = dx * dx + dy * dy;

                if (distanceSquared <= rSquared)
                {
                    count += 1;
                }
            }

            return count;
        }

        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double minLength = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                double length = Math.Sqrt(x * x + y * y);
                if (length < minLength)
                {
                    minLength = length;
                    index = i;
                }
            }

            return (index, minLength);
        }

        public int Task3()
        {
            int count = 0;

            while (true)
            {
                string inputX = Console.ReadLine();
                if (!double.TryParse(inputX, out double x))
                    break;

                string inputY = Console.ReadLine();
                if (!double.TryParse(inputY, out double y))
                    break;

                if (y >= 0 && y <= Math.Sin(x) && x >= 0 && x <= Math.PI)
                {
                    count += 1;
                }
            }

            return count;
        }

        public int Task4(int labs, int cw)
        {
            int score = 0;

            while (labs > 0 || cw > 0)
            {
                int mark = int.Parse(Console.ReadLine());

                if (labs > 0)
                {
                    score += mark;
                    labs -= 1;
                }
                else if (cw > 0)
                {
                    score += 4 * mark;
                    cw -= 1;
                }
            }

            return score;
        }

        public double Task5(int a, int b, int type)
        {
            double area = 0;

            switch (type)
            {
                case 1:
                    area = a * b;
                    break;
                case 2:
                    double R = Math.Max(a, b);
                    double r = Math.Min(a, b);
                    area = Math.PI * (R * R - r * r);
                    break;
                case 3:
                    if (b + b > a && a > 0 && b > 0)
                    {
                        double h = Math.Sqrt(b * b - (a / 2.0) * (a / 2.0));
                        area = 0.5 * a * h;
                    }
                    break;
                case 0:
                    area = 0;
                    break;
            }

            return area;
        }
    }
}