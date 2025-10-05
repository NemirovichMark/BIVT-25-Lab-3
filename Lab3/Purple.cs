using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            if (n <= 0) return 0;

            int inner = Math.Min(r1, r2);
            int outer = Math.Max(r1, r2);
            double innerSq = (double)inner * inner;
            double outerSq = (double)outer * outer;

            int count = 0;
            for (int i = 0; i < n; ++i)
            {
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    break;
                }

                if (!double.TryParse(Console.ReadLine(), out double y))
                {
                    break;
                }

                double distSq = x * x + y * y;
                if (distSq >= innerSq && distSq <= outerSq)
                {
                    count++;
                }
            }

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            if (n <= 0)
            {
                return (0, 0);
            }

            int totalMarksSum = 0;
            int studentsWithTwoMarks = 0;

            for (int studentId = 0; studentId < n; ++studentId)
            {
                int hasTwoMark = 0;
                int studentMarksSum = 0;
                for (int markId = 0; markId < 4; ++markId)
                {
                    string? studentMarks = Console.ReadLine();
                    if (studentMarks == null || !int.TryParse(studentMarks, out int mark))
                    {
                        return (0, 0); // пусть так, в условии весь ввод валидный
                    }

                    studentMarksSum += mark;
                    hasTwoMark |= Convert.ToInt32(mark == 2);
                }

                totalMarksSum += studentMarksSum;
                studentsWithTwoMarks += hasTwoMark;
            }
            return (studentsWithTwoMarks, totalMarksSum / (double)n);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            if (exams <= 0)
            {
                return 0;
            }

            int n = exams;

            for (int i = 0; i < n; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out int theory))
                {
                    break;
                }

                if (!int.TryParse(Console.ReadLine(), out int practice))
                {
                    break;
                }

                double score = 0.4 * theory + 0.6 * practice;

                int mark;
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
            }

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            for (int i = 0; i < limit; ++i)
            {
                attempts++;

                if (!int.TryParse(Console.ReadLine(), out int d1))
                {
                    break;
                }
                if (d1 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }

                if (!int.TryParse(Console.ReadLine(), out int d2))
                {
                    break;
                }
                if (d2 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }

                if (!int.TryParse(Console.ReadLine(), out int d3)) break;
                if (d3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }

                int guessedCode = d1 * 100 + d2 * 10 + d3;

                if (guessedCode == code)
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

            for (int i = 0; i < n; i++)
            {
                int currentDay = a + i;

                switch (currentDay)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck = double.Min(100, luck * 1.5);
                        break;
                    
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck = double.Max(0, luck - 10);
                        break;
                    
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50)
                        {
                            luck = 55;
                        }
                        break;
                    
                    default:
                        luck = double.Min(100, luck + 5);
                        break;
                }
            }

            return luck;
        }
    }
}
