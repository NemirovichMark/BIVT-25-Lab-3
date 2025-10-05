using System.ComponentModel;
using System.Formats.Asn1;
using System.Reflection;
using System.Security.Cryptography;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            

            for (int i = 0; i != n; i++)
            {
                if (Convert.ToDouble(Console.ReadLine()) < norma) milk += glass;
            }

            return milk / 1000;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            for (int i = 0; i != n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                _ = (x, y) switch
                {
                    ( > 0, > 0) => first++,
                    ( < 0, > 0) => second++,
                    ( < 0, < 0) => third++,
                    ( > 0, < 0) => fourth++,
                    _ => 0
                };
            }

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            for (int i = 0; i < n / 4; i++)
            {
                List<int> Grades = new List<int>()
                {
                    Convert.ToInt16(Console.ReadLine()),
                    Convert.ToInt16(Console.ReadLine()),
                    Convert.ToInt16(Console.ReadLine()),
                    Convert.ToInt16(Console.ReadLine()),
                };

                if (Grades.All(n => n > 3)) count++;
            }

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int taskTime = 10;

            while (time < 24 * 60)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    time += Convert.ToInt16(Console.ReadLine());
                    serias++;
                }
            }

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            switch (number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    agility += 5;
                    power -= 5;

                    if (intellect == 2) intellect = 0; // Я не понимаю как по другому сделать, в условии ничего про это не сказано
                    else if (intellect % 2 == 0) intellect /= 2; // Но по сути он должен делить на 2 и если число равно 2, то вернуть должен 0
                    
                    break;
                case 3:
                    power += 10;
                    intellect -= 5;
                    break;
                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    break;
            }

            if (power < 0) power = 0;
            if (intellect < 0) intellect = 0;

            return (power, agility, intellect);
        }
    }
}
