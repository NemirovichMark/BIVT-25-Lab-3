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
                if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) <= Math.Pow(r, 2))
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
            if (n > 0)
            {
                length = double.MaxValue;
            }
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double curl = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (curl < length)
                {
                    length = curl;
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
                string vx = Console.ReadLine();
                if (!double.TryParse(vx, out double x)) {break;}
                string vy = Console.ReadLine();
                if (!double.TryParse(vy, out double y)) {break;}
                if ((x >= 0) && (x <= Math.PI) && (y >= 0) && (y <= Math.Sin(x))) {count++; }
            }
            // end
            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;
            // code here
            if (labs > 0 || cw > 0)
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
                    area = Math.Abs(Math.PI * Math.Pow(a, 2) - Math.PI * Math.Pow(b, 2));
                    break;
                case 3:
                    // герон не зашел double p = (a + b + b) / 2;
                    // герон не зашел area = Math.Sqrt(p * (p - a) * (p - b) * (p - b));
                    double h = Math.Sqrt(Math.Pow(b, 2) - (Math.Pow(a, 2) / 4));
                    area = Math.Abs(h * a / 2);
                    break;
                default:
                    break;
            }
            // end
            return area;
        }
    }
}