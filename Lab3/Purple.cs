using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i =0; i < n; i++)
            {
                string s = Console.ReadLine();
                double x = double.Parse(s);
                s = Console.ReadLine();
                double y = double.Parse(s);
                if (x*x+y*y>r1*r1 && y * y + x * x < r2*r2)
                {
                    count++;
                }
            }

            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            
            double average = 0;
            double x1, x2, x3, x4;
            // code here
            for (int i = 0; i < n*4; i+=4)
            {
                string s = Console.ReadLine();
                x1 = double.Parse(s);
                s = Console.ReadLine();
                x2 = double.Parse(s);
                s = Console.ReadLine();
                x3 = double.Parse(s);
                s = Console.ReadLine();
                x4 = double.Parse(s);
                if (x1<=2 || x2<=2 || x3<=2 || x4 <= 2)
                {
                    count += 1;
                    
                }
                average += (x1 + x2 + x3 + x4);

            }
            average = average / (n * 4);
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark;
            int n = exams;
            double score;
            string s;
            while (exams>0)
            {
                s = Console.ReadLine();
                theory = int.Parse(s);
                s = Console.ReadLine();
                practice = int.Parse(s);
                score = 0.4 * theory + 0.6 * practice;
                switch (score)
                {
                    case double sc when (sc>85):
                        mark = 5;
                        break;
                    case double sc when (sc > 70):
                        mark = 4;
                        break;
                    case double sc when (sc > 50):
                        mark = 3;
                        break;
                    default:
                        mark = 2;
                        break;
                }
                avgMark += Convert.ToDouble(mark) / n;
                exams--;
            }

            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;
            string s;
            string a, b, c;
            bool flag = true;
            // code here
            while (attempts < limit)
            {
                attempts++;
                a = Console.ReadLine();
                if (a == "-1")
                {
                    solution = "Аварийный выход!";
                    flag = false;
                    break;
                }
                b = Console.ReadLine();
                if (b == "-1")
                {
                    solution = "Аварийный выход!";
                    flag = false;
                    break;
                }
                c = Console.ReadLine();
                if (c == "-1")
                {
                    solution = "Аварийный выход!";
                    flag = false;
                    break;
                }
                if (Convert.ToInt32(a+b+c) == code)
                {
                    solution = "Доступ разрешен!";
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                solution = "Система заблокирована!";
            }
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = a; i < a + n; i++)
            {
                switch (i)
                {
                    case int k when (k == 1 || k == 8 || k == 15 || k == 22 || k == 29):
                        if (luck * 1.5 <= 100) luck *= 1.5;
                        else luck = 100;
                        break;
                    case int k when (k == 4 || k == 11 || k == 18 || k == 25):
                        if (luck - 10 >= 0) luck -= 10;
                        else luck = 0;
                        break;
                    case int k when (k == 7 || k == 14 || k == 21 || k == 28):
                        if (luck < 50) luck = 55;
                        break;
                    default:
                        if (luck +5 <= 100) luck += 5;
                        else luck = 100;
                        break;


                }
            }
            // end

            return luck;
        }
    }
}