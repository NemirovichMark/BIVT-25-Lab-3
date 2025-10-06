using System;

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

                double first = x - a;
                double second = y - b;

                if (first * first + second * second <= r * r)
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
            double squareR = 100000000000;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                if (x * x + y * y < squareR)
                {
                    squareR = x * x + y * y;
                    length = Math.Sqrt(squareR);
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
                string stringX = Console.ReadLine();
                if (!double.TryParse(stringX, out double x))
                {
                    break;
                }

                string stringY = Console.ReadLine();
                if (!double.TryParse(stringY, out double y))
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
                    area = a * b;
                    break;

                case 2:
                    if (a > b) area = Math.PI * (a * a - b * b);
                    if (a < b) area = Math.PI * (b * b - a * a);
                    break;

                case 3:
                    double squareH = b * b - (a / 2.0) * (a / 2.0);
                    double h = Math.Sqrt(squareH);
                    area = 0.5 * h * a;
                    break;

                default:
                    break;
            }
            // end

            return area;
        }
    }
}