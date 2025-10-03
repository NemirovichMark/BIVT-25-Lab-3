using System.Security.Cryptography;
using System.Xml.Linq;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {

            // code here
            double milk = 0;
            double a = 0;
            for (int i = 0;i<n;i++)
            {

                double.TryParse(Console.ReadLine(), out a);
                if (a < norma)
                {
                    milk = milk + glass;
                }
            }
            // end
            milk = milk / 1000;
            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            double x, y;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                double.TryParse(Console.ReadLine(), out y);
                if (x>0 && y > 0)
                {
                    first++;
                }
                if (x < 0 && y > 0)
                {
                    second++;
                }
                if (x < 0 && y < 0)
                {
                    third++;
                }
                if (x > 0 && y < 0)
                {
                    fourth++;
                }
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            int a, b, c, d;
            for(int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out a);
                int.TryParse(Console.ReadLine(), out b);
                int.TryParse(Console.ReadLine(), out c);
                int.TryParse(Console.ReadLine(), out d);
                if(a!=2 && b!=2 && c!=2 && d != 2)
                {
                    if (a != 3 && b != 3 && c != 3 && d != 3)
                    {
                        count++;
                    }
                }
            }

            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10;
            serias = 0;
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
                    int.TryParse(Console.ReadLine(),out seriasTime);
                    time += seriasTime;
                    serias++;
                }
            }
            

            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            if (power < 0)
            {
                power = 0;
            }
            if (intellect < 0)
            {
                intellect = 0;
            }
            if (agility < 0)
            {
                agility = 0;
            }
            switch (number){
                case 1:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    agility += 5;
                    intellect -= 5;
                    power -= 5;
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
                default:
                    break;

            }
            if( power < 0)
            {
                power = 0;
            }
            if (intellect < 0)
            {
                intellect = 0;
            }
            if (agility < 0)
            {
                agility = 0;
            }
            // end

            return (power, agility, intellect);
        }
    }
}