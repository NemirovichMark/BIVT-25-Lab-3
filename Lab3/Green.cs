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

                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double distance = Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b));


                if (Math.Round(distance,1) < r+0.5 && distance!=r)
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
            double lengthmin=0;

            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double length1 = Math.Sqrt(x * x + y * y);
                if (i == 1)
                {
                    lengthmin = Math.Sqrt(x * x + y * y);
                }

                if (lengthmin >= length1)
                {
                    lengthmin = length1;
                    index = i;
                    length = lengthmin;
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
                try
                {
                    double x = double.Parse(Console.ReadLine());
                    double y = double.Parse(Console.ReadLine());
                    if (y >= 0 && y <= Math.Sin(x) && x>=0 && x<=Math.PI)
                    {
                        count++;
                    }
                }
                catch (Exception)
                {
                    break;
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
            if (type == 1)
            {
                area = a * b;
            }
            else if (type == 2)
            {
                if (a < b)
                {
                    int tmp = a;
                    a = b;
                    b = tmp;
                }

                area = Math.PI * a * a - Math.PI * b * b;
            }
            else if (type == 3)
            {
                double h = Math.Sqrt(b * b - a * a / 4.0);
                area = (1.0 / 2) * h * a;
            }


            // end

            return area;
        }
    }

}
