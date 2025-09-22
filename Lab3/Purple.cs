using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            string xCoord, yCoord;
            for (var i = 0; i < n; i++)
            {
                xCoord = Console.ReadLine();
                yCoord = Console.ReadLine();
                var coord = (Convert.ToDouble(xCoord), Convert.ToDouble(yCoord));
                if (r1 * r1 <= (coord.Item1 * coord.Item1 + coord.Item2 * coord.Item2) &&
                    (coord.Item1 * coord.Item1 + coord.Item2 * coord.Item2) <= r2 * r2)
                    count++;
            }
            // end

            return count;
        }

        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
            var sumMark = 0;
            for (var i = 0; i < n; i++)
            {
                var studMark = "";
                for (var j = 0; j < 4; j++)
                {
                    var mark = Console.ReadLine();
                    studMark += mark;
                    sumMark += Convert.ToInt32(mark);
                }

                if (studMark.Contains("2"))
                    count++;
            }

            if (sumMark != 0 || n != 0)
                average = (double)sumMark / (n * 4);
            // end

            return (count, average);
        }

        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark;
            int n = exams;
            while (exams > 0)
            {
                theory = Convert.ToInt32(Console.ReadLine());
                practice = Convert.ToInt32(Console.ReadLine());
                var score = 0.4 * theory + 0.6 * practice;
                switch (score)
                {
                    case > 85:
                        mark = 5;
                        break;
                    case > 70:
                        mark = 4;
                        break;
                    case > 50:
                        mark = 3;
                        break;
                    default:
                        mark = 2;
                        break;
                }

                avgMark += (double)mark / n;
                exams--;
            }
            // end

            return avgMark;
        }

        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Система заблокирована!";
            int attempts = 0;

            // code here
            for (var i = 0; i < limit; i++)
            {
                attempts++;
                var curCode = "";
                for (var j = 0; j < 3; j++)
                {
                    var curFigure = Console.ReadLine();
                    if (curFigure == "-1")
                        break;
                    curCode += curFigure;
                }

                if (curCode.Length < 3)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                else if (curCode == Convert.ToString(code))
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }
            // end

            return (solution, attempts);
        }

        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (var i = a; i < a + n; i++)
            {
                switch (i)
                {
                    case 1 or 8 or 15 or 22 or 29:
                        luck = Math.Min(luck * 1.5, 100);
                        break;
                    case 4 or 11 or 18 or 25:
                        luck = Math.Max(luck - 10, 0);
                        break;
                    case 7 or 14 or 21 or 28:
                        if (luck < 50)
                            luck = 55;
                        break;
                    default:
                        luck = Math.Min(luck + 5, 100);
                        break;
                }
            }
            // end

            return luck;
        }
    }
}