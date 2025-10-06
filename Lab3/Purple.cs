using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x, y;
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                double d = Math.Sqrt(x * x + y * y);
                if (d > r1 && d < r2) count++;
            }
            // end

                return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
            double t = 0;

            for (int i = 0; i < n; i++)
            {
                int a1 = int.Parse(Console.ReadLine());
                int a2 = int.Parse(Console.ReadLine());
                int a3 = int.Parse(Console.ReadLine());
                int a4 = int.Parse(Console.ReadLine());

                t += a1 + a2 + a3 + a4;

                if (a1 == 2 || a2 == 2 || a3 == 2 || a4 == 2)
                {
                    count++;
                }
            }

            average = t / (n * 4.0);
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
	    int t, p, m, n = exams;
	    double s = 0;
	    while (exams > 0)
        {
	        t = Convert.ToInt32(System.Console.ReadLine());
	        p = Convert.ToInt32(System.Console.ReadLine());
	        s = 0.4 * t + 0.6 * p;
	        if (s > 85) m = 5;
	        else if (s > 70) m = 4;
	        else if (s > 50) m = 3;
	        else m = 2;
	        avgMark += m / n;
	        exams--;
	    }

            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here

	    while (attempts < limit)
        {
	        int i1, i2, i3;
	        i1 = Convert.ToInt32(Console.ReadLine());
            if (i1 == -1)
            {
                solution = "Аварийный выход!";
                attempts++;
                break;
            }
	        i2 = Convert.ToInt32(Console.ReadLine());
            if (i2 == -1)
            {
                solution = "Аварийный выход!";
                attempts++;
                break;
            }
	        i3 = Convert.ToInt32(Console.ReadLine());
            if (i3 == -1)
            {
                solution = "Аварийный выход!";
                attempts++;
                break;
            }
	        if (i1 * 100 + i2 * 10 + i3 == code)
            {
		        solution = "";
		        attempts++;
		        break;
	        }
	      attempts++;
	    }


            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
	    for (int i = 0; i < n; i++)
        {
	        switch((a + i) % 30)
            {        
		        case 1:   luck = Math.Min(luck * 1.5, 100); break;
		        case 8:   luck = Math.Min(luck * 1.5, 100); break;
		        case 15:  luck = Math.Min(luck * 1.5, 100); break;
		        case 22:  luck = Math.Min(luck * 1.5, 100); break;
		        case 29:  luck = Math.Min(luck * 1.5, 100); break;
		        case 4:   luck = Math.Max(luck - 10, 0); break;
		        case 11:  luck = Math.Max(luck - 10, 0); break;
		        case 18:  luck = Math.Max(luck - 10, 0); break;
		        case 25:  luck = Math.Max(luck - 10, 0); break;
		        case 7:   if (luck < 50) luck = 55; break;
		        case 14:  if (luck < 50) luck = 55; break;
		        case 21:  if (luck < 50) luck = 55; break;
		        case 28:  if (luck < 50) luck = 55; break;
		        default: luck = Math.Min(luck + 5, 100); break;
	        }
	    }



            // end

            return luck;
        }
    }
}
