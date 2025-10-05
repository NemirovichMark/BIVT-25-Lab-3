namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            
        
            for (int i = 0; i < n; i++)
            {
                Console.Write();
                int weight = int.Parse(Console.ReadLine());
                
                if (weight < norma)
                {
                    milk += glass;
                }
            }
            return milk / 1000;
        }

        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;
            
            for (int i = 0; i < n; i++)
                
                {
                    Console.Write();
                    double x = double.Parse(Console.ReadLine());
                    Console.Write();
                    double y = double.Parse(Console.ReadLine());
                    
                    if (x > 0 && y > 0)
                        count1++;
                    else if (x < 0 && y > 0)
                        count2++;
                    else if (x < 0 && y < 0)
                        count3++;
                    else if (x > 0 && y < 0)
                        count4++;
                }

    
            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool BadGrades = false;
                
                for (int j = 0; j < 4; j++)
                {
                    Console.Write();
                    int grade = int.Parse(Console.ReadLine());
                    
                    if (grade == 2 || grade == 3)
                    {
                        BadGrades = true;
                    }
                }
                
                if (!BadGrades)
                {
                    count++;
                }
            }
        
            return count;
        }

        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int taskTime = 10;
            int currentTime = 0;
        
            while (currentTime < time && tasks > 0)
            {
              
                if (currentTime + taskTime <= time)
                {
                    currentTime += taskTime;
                    taskTime += 5;
                    tasks--;
                    
                    
                    if (tasks > 0)
                    {
                        Console.Write();
                        int seriasTime = int.Parse(Console.ReadLine());
                        
                        if (currentTime + seriasTime <= time)
                        {
                            currentTime += seriasTime;
                            serias++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            return (tasks, serias)
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
            
            switch (number)
            {
                case 1:
                case 3:
                    power += 10;
                    break;
                case 2:
                    agility += 5;
                    break;
                case 4:
                    agility += 15;
                    break;
                case 5:
                    intellect += 7;
                    break;
            }
        
            
            switch (number)
            {
                case 1:
                case 2:
                case 3:
                    intellect -= 5;
                    break;
                case 2:
                case 5:
                    power -= 5;
                    break;
                case 4:
                    power -= 10;
                    intellect -= 10;
                    break;
            }
        
            
            power = Math.Max(0, power);
            agility = Math.Max(0, agility);
            intellect = Math.Max(0, intellect);


            return (power, agility, intellect);
        }
    }

}

