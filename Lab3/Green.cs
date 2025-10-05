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
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                double.TryParse(x, out double X);
                double.TryParse(y, out double Y);
                if ((X - a) * (X - a) + (Y - b) * (Y - b) <= r * r)
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
            double.TryParse(Console.ReadLine(), out double mX);
            double.TryParse(Console.ReadLine(), out double mY);
            double mindist = Math.Sqrt(mX * mX + mY * mY);
            int minind = 1;
            for (int i=2;i<=n;i++)
            {
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                double.TryParse(x, out double X);
                double.TryParse(y, out double Y);
                length = Math.Sqrt(X * X + Y * Y);
                if (length < mindist)
                {
                    mindist = length;
                    mX = X;
                    mY = Y;
                    minind = i;
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
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                bool xtrue=double.TryParse(x, out double X);
                bool ytrue=double.TryParse(y, out double Y);
                if (Y >= 0 && Y <= Math.Sin(X) && X >= 0 && X <= Math.PI)
                {
                    count++;
                }
                else 
                { 
                    break; 
                }
                // end
            }
                return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here

            // end

            return score;
        }
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            // code here

            // end

            return area;
        }
    }
}