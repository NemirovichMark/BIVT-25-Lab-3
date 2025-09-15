using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here

            int Task01(int n, int r1, int r2)
            { // n - число точек

                int ans = 0;

                for (int i = 0; i < n; i++)
                {

                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("reading x input");
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine("reading y input");

                    double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                    if (d >= r1 && d <= r2)
                    {
                        ans++;
                    }


                }

                return ans;


            }


            count = Task01(n, r1, r2);

            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here

            (double, int) Task02(int n)
{
                double srednee = 0;
                int c = 0;
                List<double> grades = new List<double> { };

                for (int i = 0; i < n; i++)
                {

                    int g1 = int.Parse(Console.ReadLine());
                    int g2 = int.Parse(Console.ReadLine());
                    int g3 = int.Parse(Console.ReadLine());
                    int g4 = int.Parse(Console.ReadLine());

                    if (g1 == 2 || g2 == 2 || g3 == 2 || g4 == 2)
                    {
                        c++;
                    }

                    grades.Add(((double)g1 + (double)g2 + (double)g3 + (double)g4) / 4);


                }

                foreach (double grade in grades)
                {
                    srednee += grade;
                }

                srednee /= n;

                return (srednee, c);

            }

            (double, int) ans = Task02(n);
            count = ans.Item2;
            average = ans.Item1;

            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            double Task03(int exams)
            {
                double theory = exams;
                double practice = exams;
                double mark = exams;
                int n = exams;

                double score = 0;
                double avgMark = 0;

                while (exams > 0)
                {
                    theory = int.Parse(Console.ReadLine());
                    practice = int.Parse(Console.ReadLine());
                    score = 0.4 * theory + 0.6 * practice;

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
                    else { mark = 2; }

                    avgMark += mark / n;

                    exams--;
                }

                return avgMark;
            }

            avgMark = Task03(exams);
            Console.WriteLine(avgMark);
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here

            (string, int) Task04(string code, int limit)
            {
                int c = 0;
                string solutionSuccess = "Доступ разрешен!";
                string solutionAbort = "Аварийный выход!";
                string solutionFailed = "Система заблокирована!";


                while (limit > c)
                {

                    
                    int num1 = int.Parse(Console.ReadLine()); 
                    if (num1 == -1)
                    {
                        return (solutionAbort, c);
                    }
                    int num2 = int.Parse(Console.ReadLine());
                    if (num2 == -1)
                    {
                        return (solutionAbort, c);
                    }
                    int num3 = int.Parse(Console.ReadLine());
                    if (num3 == -1)
                    {
                        return (solutionAbort, c);
                    }


                    string solution = $"{num1}{num2}{num3}";
                    Console.WriteLine($"Iteration {c} \nSolution {solution}");

                    if (code == solution)
                    {
                        return (solutionSuccess, c);
                    }

                    c++;
                }

                return (solutionFailed, c);


            }

            (string, int) answer = Task04(code.ToString(), limit);
            solution = answer.Item1;
            attempts = answer.Item2;
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            double Task05(int a, int n)
            {
                double luck = 0;
                int curr = 0;
                int tDay = a;

                while (curr < n)
                {

                    if (tDay == 1 || tDay == 8 || tDay == 15 || tDay == 22 || tDay == 29)
                    {
                        if (luck * 1.5 <= 100)
                        {
                            luck *= 1.5;
                        }
                        else
                        {
                            luck = 100;
                        }


                    }
                    else if (tDay == 4 || tDay == 11 || tDay == 18 || tDay == 25)
                    {
                        if (luck - 10 >= 0)
                        {
                            luck -= 10;
                        }
                        else
                        {
                            luck = 0;
                        }
                    }
                    else if (tDay == 7 || tDay == 14 || tDay == 21 || tDay == 28)
                    {
                        if (luck < 50)
                        {
                            luck = 55;
                        }

                    }
                    else
                    {
                        if (luck + 5 <= 100)
                        {
                            luck += 5;
                        }
                        else { luck = 100; }
                    }


                    curr++;
                    tDay++;

                    if (tDay >= 30)
                    {
                        tDay = 1;
                    }

                }

                return luck;

            }


            luck = Task05(a, n);
            // end

            return luck;
        }
    }
}