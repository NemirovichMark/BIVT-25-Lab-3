using System.Globalization;
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
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double dot = x * x + y * y;
                if (dot >= r1 * r1 && dot <= r2 * r2)
                    count ++;
            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here

            for (int i = 0; i < n; i++)
            {
                int mark1 = int.Parse(Console.ReadLine());
                int mark2 = int.Parse(Console.ReadLine());
                int mark3 = int.Parse(Console.ReadLine());
                int mark4 = int.Parse(Console.ReadLine());

                if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
                {
                    count++;
                }

                average += mark1;
                average += mark2;
                average += mark3;
                average += mark4;
            }
            if (n == 0)
            {
                count = 0;
                average = 0;
            }
            else {
                average /= (n * 4);
            }
            
            

            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int n = exams;

            while (exams > 0)
            {
                int theory = int.Parse(Console.ReadLine());
                int practice = int.Parse(Console.ReadLine());
                double score = 0.4 * theory + 0.6 * practice;

                int mark;
                if (score > 85) 
                    mark = 5;
                else if (score > 70)
                    mark = 4;
                else if (score > 50)
                    mark = 3;
                else
                    mark = 2;

                avgMark += (double)mark / (double)n;
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
            int fl = 0;
            for (int i = 0; i < limit; i++)
            {
                string firstNum = Console.ReadLine();
                string secondNum = Console.ReadLine();
                string thirdNum = Console.ReadLine();

                if (firstNum == "-1" || secondNum == "-1" || thirdNum == "-1")
                {
                    solution = "Аварийный выход!";
                    attempts++;
                    fl += 1;
                    break;
                    
                }

                string userNum = firstNum + secondNum + thirdNum;
                string strCode = Convert.ToString(code);

                if (userNum == strCode)
                {
                    solution = "Доступ разрешен!";
                    attempts++;
                    fl += 1;
                    break;
                }
                
                attempts++;
            }

            if (fl == 0)
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
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        if (luck * 1.5 <= 100)
                            luck *= 1.5;
                        else
                            luck = 100;
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        if (luck - 10 > 0)
                            luck -= 10;
                        else
                            luck = 0;
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50)
                            luck = 55;
                        break;
                    default:
                        if (luck + 5 < 100)
                            luck += 5;
                        else
                            luck = 100;
                        break;
                }

            }
            // end

            return luck;
        }
    }
}
