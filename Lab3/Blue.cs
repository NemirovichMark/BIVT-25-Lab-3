using System.Globalization;
using System.Security.Cryptography;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                string vvod = Console.ReadLine();
                double.TryParse(vvod, NumberStyles.Float, CultureInfo.InvariantCulture, out double ves);
                if (ves < norma) milk += glass;
            }
            milk /= 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                string kxv = Console.ReadLine();
                double.TryParse(kxv, NumberStyles.Float, CultureInfo.InvariantCulture, out double kxp);
                string kyv = Console.ReadLine();
                double.TryParse(kyv, NumberStyles.Float, CultureInfo.InvariantCulture, out double kyp);
                Console.WriteLine(kxp + " " + kyp);
                if (kxp > 0 && kyp > 0) first++;
                else if (kxp < 0 && kyp > 0) second++;
                else if (kxp < 0 && kyp < 0) third++;
                else if (kxp > 0 && kyp < 0) fourth++;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            int a, b, c, d;
            for (int i = 0; i < n; i++)
            {
                Int32.TryParse(Console.ReadLine(), out a);
                Int32.TryParse(Console.ReadLine(), out b);
                Int32.TryParse(Console.ReadLine(), out c);
                Int32.TryParse(Console.ReadLine(), out d);
                if (a > 3 && b > 3 && c > 3 && d > 3) count++;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10;
            while (time < 24 * 60)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    Int32.TryParse(Console.ReadLine(), out seriasTime);
                    time += seriasTime;
                    serias++;
                }
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            switch (number)
            {
                case (1 or 3):
                    power += 10;
                    if (intellect > 4) intellect -= 5;
                    else intellect = 0;
                    break;
                case (2):
                    agility += 5;
                    if (power > 4) power -= 5;
                    else power = 0;
                    if (intellect > 4) intellect -= 5;
                    else intellect = 0;
                        break;
                case (4):
                    agility += 15;
                    if (power > 9) power -= 10;
                    else power = 0;
                    if (intellect > 9) intellect -= 10;
                    else intellect = 0;
                    break;
                case (5):
                    intellect += 7;
                    if (power > 4) power -= 5;
                    else power = 0;
                    break;
            }

            // end

            return (power, agility, intellect);
        }
    }
}
