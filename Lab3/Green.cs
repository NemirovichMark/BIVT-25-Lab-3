namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите координату x точки {i + 1}: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату y точки {i + 1}: ");
                double y = double.Parse(Console.ReadLine());
                
                double distanceSquared = Math.Pow(x - a, 2) + Math.Pow(y - b, 2);
                if (distanceSquared <= Math.Pow(r, 2))
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here
            double minDistance = double.MaxValue;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите координату x точки {i + 1}: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write($"Введите координату y точки {i + 1}: ");
                double y = double.Parse(Console.ReadLine());
                
                double distance = Math.Sqrt(x * x + y * y);
                
                if (distance < minDistance)
                {
                    minDistance = distance;
                    index = i + 1;
                    length = distance;
                }
            }
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (true)
            {
                Console.Write("Введите координату x (или слово для выхода): ");
                string inputX = Console.ReadLine();
                
                // Проверяем, является ли ввод числом
                if (!double.TryParse(inputX, out double x))
                {
                    break; 
                }
                
                Console.Write("Введите координату y: ");
                string inputY = Console.ReadLine();
                if (!double.TryParse(inputY, out double y))
                {
                    break; 
                }
                
                
                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                {
                    count++;
                }
            }

            // end

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            while (labs > 0)
            {
                Console.Write("Введите оценку за лабораторную работу: ");
                int mark = int.Parse(Console.ReadLine());
                score += mark;
                labs--;
            }
            
            
            while (cw > 0)
            {
                Console.Write("Введите оценку за курсовую работу: ");
                int mark = int.Parse(Console.ReadLine());
                score += 4 * mark;
                cw--;
            }


            // end

            return score;
        }
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            // code here
            switch (type)
            {
                case 1: // Площадь прямоугольника
                    area = a * b;
                    break;
                    
                case 2: // Площадь кольца
                    double R = Math.Max(a, b);
                    double r = Math.Min(a, b);
                    area = Math.PI * (R * R - r * r);
                    break;
                    
                case 3:
                    if (2 * b > a) // Проверка существования треугольника
                    {
                        double height = Math.Sqrt(b * b - (a * a) / 4.0);
                        area = 0.5 * a * height;
                    }
                    else
                    {
                        area = 0; // Треугольник не существует
                    }
                    break;
                    
                default:
                    area = 0;
                    break;
            }

            // end

            return area;
        }
    }
}
