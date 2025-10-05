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
            
            

            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here
            double m = 10005000000000000000;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (Math.Sqrt(x * x + y * y) <= m)
                {
                    m = Math.Sqrt(x * x + y * y);
                    index = i + 1;
                    length = m;
                }
                
            }

            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            
            while(double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
            {
                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                {
                    count ++;
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

        }
            // end

            return score;
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            // code here
            if (type == 1)
            {
                area = a * b;
            }
            else if (type == 2)
            {
                area = Math.PI * Math.Abs(( (a*a) - (b*b) ));
            }
            else if (type == 3)
            {
                double p = (a + b + b) / 2.0;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - b));
            }
            
            
            

            // end

            return area;
        }
    }
}
