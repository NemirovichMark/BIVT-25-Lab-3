namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double nom = Convert.ToDouble(Console.ReadLine());
                if (nom < norma)
                {
                    milk += glass /*+ glass*/;
                }
                /*else
                {
                    milk += glass;
                }*/

            }
            milk = milk / 1000;

            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            List<double> tchka = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double x_i = Convert.ToDouble(Console.ReadLine());
                double y_i = Convert.ToDouble(Console.ReadLine());
                if (x_i > 0 && y_i > 0)
                    first += 1;
                else if (x_i < 0 && y_i > 0)
                    second += 1;
                else if (x_i < 0 && y_i < 0)
                    third += 1;
                else if (x_i > 0 && y_i < 0)
                    fourth += 1;

            }

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i <n; i++)
            {
                    int ch1 = Convert.ToInt32(Console.ReadLine());
                    int ch2 = Convert.ToInt32(Console.ReadLine());
                    int ch3 = Convert.ToInt32(Console.ReadLine());
                    int ch4 = Convert.ToInt32(Console.ReadLine());
                    if (ch1 > 3 && ch2 > 3 && ch3 > 3 && ch4 > 3)
                        count += 1;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10;
            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    seriasTime = Convert.ToInt32(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            /* В древнем храме хранятся 5 магических статуй, пронумерованные от 1 до 5.Путник может
 поклониться одной из них и получить уникальный эффект, изменяющий его основные
 характеристики: силу, ловкость и интеллект. 
            1ая и 3ая статуи увеличивают силу на 10, 
            2ая и 4ая - ловкость на 5 и 15 соответственно, 
            5ая статуя -повышает интеллект на 7.
            При этом статуи 1-3 понижают интеллект на 5, 
            статуи 2 и 5 понижают силу на 5.
            Статуя 4 понижает и силу, и интеллект на 10.
            Характеристики после изменений не могут стать меньше 0.В метод
 передаются характеристики путника: целые числа power, agility, intellect и номер статуи,
 которой он поклонился number.Определить характеристики путника после поклона*/

            // code here
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    agility += 5;
                    power -= 5;
                    intellect -= 5;
                    break ;
                case 3:
                    power += 10;
                    intellect -= 5;
                    break ;
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
            
            if (power < 0)
                power = 0;
            if (agility < 0)
                agility = 0;
            if (intellect<0)
                intellect = 0;
            
            // end

            return (power, agility, intellect);
        }
    }
}