using System.ComponentModel.DataAnnotations;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            Console.WriteLine("Введите координату точки X");
            double.TryParse(Console.ReadLine(), out var x);
            Console.WriteLine("Введите координату точки Y");
            double.TryParse(Console.ReadLine(), out var y);
            for (int i = 0; i< n; i ++)
            {
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                {
                    count++;
                }
            }
            {

            }
            // Более простое решение
            //string l1 = console.Readline()
            //string l2 = Console.Readline()
            //double.TryParse(l1,out double x)
            //double.TryParse(l2,out double y)
            //for(int i  = 0; i<n;i++)
            //{
            //  if((x-a)*(x-a) + (y-b)*(y-b) <= r*r)
            //  {
            //   count++ 
            //  }
            //}
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;
            //code here
            double Min_lenth = 1000000000;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out var x);
                double.TryParse(Console.ReadLine(), out var y);
                double length_2 = Math.Sqrt(x * x + y * y);// Было написано  double length = Math.Sqrt(x * x + y * y);
                if (length_2 < Min_lenth)//было написано (length < Min_length)
                {
                    Min_lenth = length_2;//было написанно (Min_length = length)
                    index = i + 1;
                    length = length_2;//было написанно (length = Min_length) В ЧЕМ РАЗНИЦА???
                   
                }
            }
            //for (int i = 0; i < n; i++)
            //{

            //    string xx = Console.ReadLine();
            //    string yy = Console.ReadLine();
            //    double.TryParse(xx, out double x);
            //    double.TryParse(yy, out double y);

            //    if (Math.Sqrt(x * x + y * y) <= min)
            //    {
            //        min = Math.Sqrt(x * x + y * y);
            //        index = i + 1;
            //        length = min;
            //    }
            //}
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while(true)
            {
                bool xtrue = double.TryParse(Console.ReadLine(), out var x);
                bool ytrue = double.TryParse(Console.ReadLine(), out var y);
                if (!xtrue || !ytrue) break;
                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                    count++;
            }
            // end

                return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            while(labs>0 || cw >0)
            {
                int.TryParse(Console.ReadLine(), out var mark);
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
                    area = Math.PI * Math.Abs(a * a - b * b);
                    break;
                case 3:
                    double p = (double)(a + b + b) / 2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - b));
                    break;
                default:
                    area = 0;
                    break;
            }
            // end

                return area;
        }
    }
}