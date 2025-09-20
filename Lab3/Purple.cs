using System.Net.Http.Headers;
using System.Numerics;

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
                string? xRead = Console.ReadLine();
                int x = int.Parse(xRead);
                string? yRead = Console.ReadLine();
                int y = int.Parse(yRead);
                long dist = (long)Math.Sqrt(x * x + y * y);
                if (dist >= r1 && dist <= r2)
                {
                    count += 1;
                }
            }
        // end  

        return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            Dictionary<int, List<int>> students = new Dictionary<int, List<int>>();
            // code here
            for (int student = 1; student <= n; student++)
            {
                List<int> scores = new List<int>();
                for (int i = 0; i < 4; i++)
                {
                    int mark = int.Parse(Console.ReadLine());
                    scores.Add(mark);
                }
                students.Add(student, scores);
            }

            foreach (var student in students)
            {
                int sum = 0;
                if (student.Value.Contains(2))
                {
                    count++;
                }

                sum += student.Value.Sum();
                average += (double)sum / students.Count;
            }
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double score, avgMark = 0;
            int theory, practice, mark, n = exams;
            // code here
            while (exams > 0)
            {
                string theoryInput = Console.ReadLine();
                theory = int.Parse(theoryInput);
                
                string practiseInput = Console.ReadLine();
                practice = int.Parse(practiseInput);
                
                score = 0.4 * theory + 0.6 * practice;
                
                mark = 2;
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

                if (n > 0)
                {
                    avgMark += (double)mark / n;
                }

                exams--;

            }
            
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;
            string correctCode = code.ToString("D3");

            for (int i = 0; i < limit; i++)
            {
                string? input1 = Console.ReadLine();
                string? input2 = Console.ReadLine();
                string? input3 = Console.ReadLine();

                if (input1 == "-1" || input2 == "-1" || input3 == "-1")
                {
                    solution = "Аварийный выход!";
                    return (solution, attempts);
                }

                if (int.TryParse(input1, out int char1) &&
                    int.TryParse(input2, out int char2) &&
                    int.TryParse(input3, out int char3))
                {
                    string enteredCode = $"{char1}{char2}{char3}";
                    attempts++;

                    if (enteredCode == correctCode)
                    {
                        solution = "Доступ разрешён!";
                        return (solution, attempts);
                    }
                }
            }
    
            solution = "Система заблокирована!";
            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            List<int> energyPeak = new List<int>([1, 8, 15, 22, 29]);
            List<int> darkForces = new List<int>([4, 11, 18, 25]);
            List<int> mysticChance = new List<int>([7, 14, 21, 28]);
            // code here
            for (int day = a; day < a + n; day++)
            {
                if (energyPeak.Contains(day))
                {
                    luck *= 1.5;
                    luck = Math.Min(luck, 100);
                }
                else if (darkForces.Contains(day))
                {
                    luck -= 10;
                    luck = Math.Max(luck, 0);
                }
                else if (mysticChance.Contains(day))
                {
                    if (luck < 50)
                    {
                        luck = 55;
                    }
                }
                else
                {
                    luck += 5;
                    luck = Math.Min(luck, 100);
                }
            }
            // end

            return luck;
        }
    }
}
