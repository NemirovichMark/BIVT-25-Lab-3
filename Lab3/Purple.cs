namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            double x, y;
            for (int i = 0; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
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

            // code here

            int x, y, z, w;
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = Convert.ToInt32(Console.ReadLine());
                w = Convert.ToInt32(Console.ReadLine());
                if ( (x == 2) || (y == 2) || (z == 2) || (w == 2))
                {
                    count++;
                }
                average += x + y + z + w;
            }
            average = average / (n * 4.0);

            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark, n = exams;
            double score;
            while (exams > 0)
            {
                theory = Convert.ToInt32(Console.ReadLine());
                practice = Convert.ToInt32(Console.ReadLine());
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
                else
                {
                    mark = 2;
                }
                avgMark += (double)mark / n;
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
            string stringCode = code.ToString("D3");
            
            for (int i = 1; i <= limit; i++)
            {
                string first = Console.ReadLine();
                if (first == "-1")
                {
                    solution = "Аварийный выход!";
                    attempts = i;
                    break;
                }

                string second = Console.ReadLine();
                if (second == "-1")
                {
                    solution = "Аварийный выход!";
                    attempts = i;
                    break;
                }

                string third = Console.ReadLine();
                if (third == "-1")
                {
                    solution = "Аварийный выход!";
                    attempts = i;
                    break;
                }

                if (first == stringCode[0].ToString() && 
                    second == stringCode[1].ToString() && 
                    third == stringCode[2].ToString())
                {
                    solution = "Доступ разрешен!";
                    attempts = i;
                    break;
                }
                
                attempts = i;
            }

            if (solution == "Код не подобран" && attempts == limit)
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
                int lunarDay = ((i - 1) % 30) + 1;

                switch (lunarDay)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck *= 1.5;
                        if (luck > 100) luck = 100;
                        break;

                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck -= 10;
                        if (luck < 0) luck = 0;
                        break;

                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50) luck = 55;
                        break;

                    default:
                        luck += 5;
                        if (luck > 100) luck = 100;
                        break;
                }
            }
            // end

                return luck;
        }
    }
}