using System.Collections;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;
            for (int i = 1; i <= n; i++){
                string? x = Console.ReadLine();
                string? y = Console.ReadLine();
                bool b1 = Double.TryParse(x, out double x1);
                bool b2 = Double.TryParse(y, out double y1);
                if (b1 && b2){
                    if ((Math.Abs(x1 * x1) + Math.Abs(y1 * y1)) <= r2 * r2 && (Math.Abs(x1 * x1) + Math.Abs(y1 * y1)) >= r1 * r1){
                        count++;
                    }
                }
            }

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            for (int i = 0; i < n; i++)
            {
                string oc1 = Console.ReadLine();
                string oc2 = Console.ReadLine();
                string oc3 = Console.ReadLine();
                string oc4 = Console.ReadLine();
                bool b1 = int.TryParse(oc1, out int occ1);
                bool b2 = int.TryParse(oc2, out int occ2);
                bool b3 = int.TryParse(oc3, out int occ3);
                bool b4 = int.TryParse(oc4, out int occ4);
                if (b1 && b2 && b1 && b4)
                {
                    if (occ1 == 2 || occ2 == 2 || occ3 == 2 || occ4 == 2)
                    {
                        count++;
                    }
                }
                average += occ1 + occ2 + occ3 + occ4;
            }
            average /= (double)(n * 4);

            return (count, average);
        }
        public double Task3(int exams)
        {
            double score, avgMark = 0;
            int mark, n = exams;
            do
            {
                string theory = Console.ReadLine();
                string practice = Console.ReadLine();
                bool b1 = int.TryParse(theory, out int theory1);
                bool b2 = int.TryParse(practice, out int practice2);
                score = 0.4 * (double)theory1 + 0.6 * (double)practice2;
                if (score > 85)
                {
                    mark = 5;
                }
                else if (score > 70)
                {
                    mark = 4;
                }
                else if (score > 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
                }
                avgMark += (double)mark / n;
                exams--;

            } while (exams > 0);


            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;
            for (int i = 1; i <= limit; i++)
            {
                string x1 = Console.ReadLine();
                string x2 = Console.ReadLine();
                string x3 = Console.ReadLine();
                bool b1 = int.TryParse(x1, out int x11), b2 = int.TryParse(x2, out int x22), b3 = int.TryParse(x3, out int x33);
                attempts++;
                if (x11 == -1 || x22 == -1 || x33 == -1)
                {
                    solution = "Аварийный выход!";

                    break;
                }
                else if (x11 == code / 100 && x22 == (code / 10) % 10 && x33 == code % 10)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }
            if (solution == "Код не подобран")
            {
                solution = "Система заблокирована!";
            }

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            for (int i = a; i < a + n; i++)
            {
                switch (i)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck *= 1.5;
                        if (luck > 100)
                        {
                            luck = (double)100;
                        }
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck -= 10;
                        if (luck < 0) {
                            luck = (double)0;
                        }
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50)
                        {
                            luck = (double)55;
                        }
                        break;
                    default:
                        luck += (double)5;
                        if (luck > 100)
                        {
                            luck = (double)100;
                        }
                        break;
                }
            }

            return luck;
        }
    }
}