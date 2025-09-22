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
                if ((Math.Pow(x - a, 2) + Math.Pow(y - b, 2)) <= Math.Pow(r, 2))
                {
                    count++;
                }
                // if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r)
                // {
                //     count++;
                // }
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
                double currentLength = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (currentLength < length)
                {
                    length = currentLength;
                    index = i + 1;
                }
            }
            // index ++
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (true)
            {
                string inputX = Console.ReadLine();
                if (!double.TryParse(inputX, out double x))
                    break;
                
                string inputY = Console.ReadLine();
                if (!double.TryParse(inputY, out double y))
                    break;

                if (IsPointInside(x, y))
                    count++;
            }
            // end

            return count;
        }

        private bool IsPointInside(double x, double y)
        {
            const double minX = 0;
            const double maxX = Double.Pi;
            
            if (x < minX || x > maxX)
                return false;
            
            if (y < 0)
                return false;
            
            double sinX = Math.Sin(x);
            return y <= sinX;
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
            //Вариант 1
            area = type switch
            {
                1 => a * b,
                2 => Math.Abs(Math.PI * Math.Pow(a, 2) - Math.PI * Math.Pow(b, 2)),
                3 => Math.Sqrt(b * b - a * a / 4.0) * a / 2.0,
                _ => 0
            };
            // Вариант 2
            //  switch (type)
            //  {
            //      case 1:
            //          area = a * b;
            //          break;
            //      
            //      case 2:
            //          area = Math.Abs(Math.PI*Math.Pow(a, 2)-Math.PI*Math.Pow(b, 2));
            //          break;
            //      
            //      case 3:
            //          double height = Math.Sqrt(b*b - a*a/4.0);
            //          area = height * a /2;
            //          break;
            //      default:
            //          area = 0;
            //          break;
            //  }
            //  end

            return area;
        }
    }
}