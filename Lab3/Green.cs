using System.Reflection;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            for (int co = 0; co < n; co++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if (Math.Sqrt((a - x) * (a - x) + (b - y) * (b - y)) < r +(2-b)*0.5)
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
            for (int co = 1; co <= n; co++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                if (Math.Sqrt((x) * (x) + (y) * (y)) < length || length==0)
                {
                    length = Math.Sqrt((x) * (x) + (y) * (y));
                    index = co;
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
                double xx;
                string x = (Console.ReadLine());
                if (double.TryParse(x, out xx))
                {
                    double yy;
                    string y = (Console.ReadLine());
                    if (double.TryParse(y, out yy))
                    {
                        if (xx>=0 && xx<=Math.PI && yy>=0 && yy <= Math.Sin(xx))
                        {
                            count++;
                        }
                    }
                    else break;
                }
                else break;
            }
            // end

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            int mark;
            while (labs>0 || cw > 0)
            {
                mark = Convert.ToInt32(Console.ReadLine());
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
                    area = Math.Abs(Math.PI*(a*a-b*b));
                    break;
                case 3:
                    double p = (a + b + b) / 2.0;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - b));
                    break;

            }
            // end

            return area;
        }
    }
}