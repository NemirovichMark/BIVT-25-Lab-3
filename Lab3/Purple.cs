using System.Globalization;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here 

            static double HypotSquared(double x, double y) => x * x + y * y;

            r1 *= r1;
            r2 *= r2;

            bool IsIn(double x, double y)
            {
                var h = HypotSquared(x, y);
                return h >= r1 && h <= r2;
            }

            for (var i = 0; i < n; i += 1)
            {
                var s = Console.ReadLine();
                var x = double.Parse(s, CultureInfo.InvariantCulture);
                var y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (IsIn(x, y)) count += 1;
            }

            // end

            return count;
        }

        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here

            // end

            return (count, average);
        }

        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here

            // end

            return avgMark;
        }

        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here

            // end

            return (solution, attempts);
        }

        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here

            // end

            return luck;
        }
    }
}