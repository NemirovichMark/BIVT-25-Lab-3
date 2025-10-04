using System.Xml.XPath;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;
            //Console.WriteLine("Enter a, b, r, n");
            //  a = int.Parse(Console.ReadLine());
            // b = int.Parse(Console.ReadLine());
            // r = int.Parse(Console.ReadLine());
            //  n = int.Parse(Console.ReadLine());

            // code here
           
            for (int i = 0; i <n; i++)
            {
                Console.Write("Enter x");
                if (!double.TryParse(Console.ReadLine(), out double x)) break;
                Console.Write("Enter y");
                if (!double.TryParse(Console.ReadLine(), out double y)) break;
                double d = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
                if (d <= r*r)
                {
                    count++;
                }
            }
            Console.WriteLine($"Points in circle:{count}");
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
           double length = 0;
          //  double mind = double.MaxValue;
           // int mini = 0;

            // code here
            for ( int i = 1; i <= n; i++)
            {
                Console.Write("Enter cordinats:");
               string intpu = Console.ReadLine();
               string[] cords = intpu.Split(' ');
               double x = Convert.ToDouble(cords[0]);
               double y = Convert.ToDouble(cords[1]);
               double cdist = Math.Sqrt(x*x - y*y);
                if (i == 1 || cdist < length)
                {
                    index = i;
                    length = cdist;
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

                Console.Write("Enter cordinat x:");
                string ix = Console.ReadLine();
                if (double.TryParse(ix,out double number ) == false)
                {
                    break;
                }
                double x = Convert.ToDouble(ix);

                Console.Write("Enter cordinat y:");
                string iy = Console.ReadLine();
                if (double.TryParse(iy, out double numbers) == false)
                {
                    break;
                }
                double y = Convert.ToDouble(iy);
                
                if (x >= 0 && x <= Math.PI && Math.Abs(y) <= Math.Sin(x))
                {
                    count++;
                }

            }
            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            while (labs > 0 || cw > 0)
            {

                Console.Write("Enter mark:");
                string input = Console.ReadLine();
                int mark = int.Parse(input);
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
            if (type == 2) {
                area = Math.PI * Math.Abs(b * b - a * a);
                    }
             if (type == 3) { 
                    double h = Math.Sqrt(b * b - (a * a / 4.0));
                    area = (a * h) / 2;
                   }
                      // end

            return area;
        }
    }
}