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
                double x = int.Parse(Console.ReadLine());
                double y = int.Parse(Console.ReadLine());
                if ((x-a)*(x-a) +(y-b)*(y-b) <= r*r)
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
            length = 10000;
            for (int i = 1; i <= n; i++)
            {
                double x = int.Parse(Console.ReadLine());
                double y = int.Parse(Console.ReadLine());
                if (Math.Sqrt(x * x + y * y) < length)
                {
                    index = i;
                    length = Math.Sqrt(x * x + y * y);
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
                double x, y;
                bool x1_bool = Double.TryParse(Console.ReadLine(), out x);
                bool y1_bool = Double.TryParse(Console.ReadLine(), out y);
                if (x1_bool == false || y1_bool == false) break;
                if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y)) count++;
            }
            // end

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            while (labs >0 || cw >0)
            {
                int mark = Int32.Parse(Console.ReadLine());
                if (labs > 0)
                {
                    score += mark;
                    labs--;
                }
                else
                {
                    score *= (4 * mark);
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
            switch(type)
            {
                case 1:
                    area = a * b;
                    break;
                    
                case 2:
                    area = Math.Abs(Math.PI*(a*a - b*b));
                    break;

                case 3:
                    area = 0.25*a*Math.Sqrt(4*b*b - (a*a));
                    break;

            }
            // end

            return area;
        }
    }
}
