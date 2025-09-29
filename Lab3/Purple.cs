using System.Net.Http.Headers;
using System.Threading.Tasks.Sources;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;
            int r12 = r1 * r1;
            int r22 = r2 * r2;

            // code here
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int d = x * x + y * y;
                if (d >= r12 && d <= r22)
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

            for (int i = 0; i <n; i++)
            {
                bool ans = false;
                for (int j = 0; j < 4; j++)
                {
                    int m = int.Parse(Console.ReadLine());
                    average += m;
                    if (m == 2)
                    {
                        ans = true;
                    }
                }
                if (ans)
                {
                    count += 1;
                }
            }
            // code here

            // end
            average /= n;
            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            int n = exams;
            int mark;
            if (exams > 0)
            {
                int theory = int.Parse(Console.ReadLine());
                int practice = int.Parse(Console.ReadLine());
                double score = 0.4 * theory + 0.6 * practice;
                if (score > 85)
                {
                    mark = 5;
                }
                if (score > 70)
                {
                    mark = 4;
                }
                if (score > 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
                }
                avgMark += mark / n;
                exams--;

            }

            else
            {
                return avgMark;
            }
                return avgMark;
        }

        public (string solution, int attempts) Task4(int code, int limit)
        {
            int attempts = 0;
            string solution = "Код не подобран";

            string scode = code.ToString("D3");

            while (attempts < limit)
            {
                string d1 = Console.ReadLine();
                string d2 = Console.ReadLine();
                string d3 = Console.ReadLine();
                attempts++;

                if (d1 == "-1" || d2 == "-1" || d3 == "-1")
                {
                    solution = "Аварийный выход!";
                    break;
                }

                string try1 = d1 + d2 + d3;
                if (try1 == scode)
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

            for (int day = a; day < a + n; day++) {

                int lday = (day - 1) % 29 + 1;

                if (lday == 1 || lday == 8 || lday == 15 || lday == 22 || lday == 29) {
                    luck *= 1.5;
                    if (luck > 100) {
                        luck = 100;
                    }
                }

                else if (lday == 4 || lday == 11 || lday == 18 || lday == 25) {
                    luck -= 10;
                    if (luck < 0) {
                        luck = 0;
                    }
                }
                else if (lday == 7 || lday == 14 || lday == 21 || lday == 28) {
                    if (luck < 50) {
                        luck = 55;
                    }
                }
                else{
                    luck += 5;
                    if (luck > 100){
                        luck = 100;
                    }
                }
            }

            return luck;
        }
    }
}