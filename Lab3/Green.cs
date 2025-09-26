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
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("x: " + x);
                Console.WriteLine("y: " + y);

                double dot_x = x - a;
                double dot_y = y - b;


                if (dot_x * dot_x + dot_y * dot_y <= r * r)
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
            double length = 100000;



            // code here
            for (int i = 0; i < n; i++)
            {
                double x = Convert.ToDouble((Console.ReadLine()));
                double y = Convert.ToDouble((Console.ReadLine()));
                if (Math.Sqrt(x*x + y*y) < length)
                {
                    length = Math.Sqrt(x * x + y * y);
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
            bool flag = true;
            while (flag)
            {
                double x, y;
                string line1 =  Console.ReadLine();
                line1 = line1.Replace(".", ",");
                if (double.TryParse(line1, out x))
                {
                    x = Convert.ToDouble(line1);
                    string line2 = Console.ReadLine();
                    line2 = line2.Replace(".", ",");

                    if (double.TryParse(line2, out y))
                    {
                        y = Convert.ToDouble(line2);
                    } else
                    {
                        break;
                    }

                    if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                    {
                        count++;
                    }


                } else
                {
                    flag = false;
                }
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
                int mark = Convert.ToInt32(Console.ReadLine());
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

            if (type == 2)
            {
                if (a < b)
                {
                    area = Math.PI * ((b * b) - (a * a));
                }
                else
                {
                    area = Math.PI * ((a * a) - (b * b));
                }
            }

            if (type == 3)
            {
                double h = Math.Sqrt(b * b - (a * a) / 4.0);
                area = 0.5 * a * h;
            }
            // end

            return area;
        }
    }
}