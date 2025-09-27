using System.Reflection;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double x, y;

                while (!double.TryParse(Console.ReadLine(), out x))
                {
                }

                while (!double.TryParse(Console.ReadLine(), out y))
                {
                }
                double sm = (x - a) * (x - a) + (y - b) * (y - b);
                if (Math.Sqrt(sm) <= r)
                {
                    Console.WriteLine("FINNALY");
                    count++;
                }
            }
            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here
            double x, y;
            double MxValue = double.MaxValue, Min = 0;
            for (int i = 0; i < n; i++)
            {
                if (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
                {
                    length = Math.Sqrt(x * x + y * y);
                    if (length < MxValue) 
                    {
                        index = i + 1;
                        MxValue = length;
                    }
                }
            }
            length = MxValue;

            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (true)
            {
                // читаем X — если введено не число, выходим из цикла
                string sx = Console.ReadLine();
                if (sx == null || !double.TryParse(sx, out double x)) break;

                // читаем Y — если введено не число, выходим
                string sy = Console.ReadLine();
                if (sy == null || !double.TryParse(sy, out double y)) break;

                // проверка: 0 <= x <= pi и 0 <= y <= sin(x)
                if (x >= 0.0 && x <= Math.PI && y >= 0.0 && y <= Math.Sin(x))
                {
                    count++;
                }
                // end
            }
                return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;
            
            // code here
            while (labs > 0 || cw > 0)
            {
                string mark = Console.ReadLine();
                int NMark = int.Parse(mark);
                if (labs > 0)
                {
                    score += NMark;
                    labs--;
                }
                else
                {
                    score += 4 * NMark;
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
                case 1: // прямоугольник
                    area = a * b;
                    break;

                case 2: // кольцо
                    int R = Math.Max(a, b);
                    int r = Math.Min(a, b);
                    area = Math.PI * (R * R - r * r);
                    break;

                case 3: // равнобедренный треугольник
                    if (2 * b > a) // чтобы существовал треугольник
                    {
                        double h = Math.Sqrt(b * b - (a * a) / 4.0);
                        area = 0.5 * a * h;
                    }
                    break;

                default:
                    Console.WriteLine("Неверный тип фигуры");
                    break;
            }
            // end

            return area;

        }

    }
}

