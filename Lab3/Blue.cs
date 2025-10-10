namespace Lab3
{
    public static double Task1(int n, int glass, int norma)
    {
        double answer = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите вес ученика {i + 1}: ");
            int weight = int.Parse(Console.ReadLine());
            if (weight < norma)
            {
                answer += glass;
            }
        }
        answer = answer / 1000; // перевод мл в литры
                                // end
        return answer;
    }
    public static string Task2(int n)
    {
        string answer = "";
        // code here
        int count1 = 0, count2 = 0, count3 = 0, count4 = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите координату X точки {i + 1}: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write($"Введите координату Y точки {i + 1}: ");
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

        answer = $"{count1} {count2} {count3} {count4}";
        // end
        return answer;
    }
    public static int Task3(int n)
    {
        int answer = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите 4 оценки студента {i + 1}:");
            bool hasBadGrades = false;

            for (int j = 0; j < 4; j++)
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade == 2 || grade == 3)
                {
                    hasBadGrades = true;
                }
            }

            if (!hasBadGrades)
            {
                answer++;
            }
        }
        // end
        return answer;
    }
    public static string TASK1(int time, int tasks)
    {
        string answer = "";
        // code here
        int seriasTime, taskTime = 10, serias = 0;

        while (time < 1440 && tasks > 0) // 24:00 = 1440 минут
        {
            time += taskTime;
            taskTime += 5;
            tasks--;
        }

        while (time < 1440)
        {
            Console.Write("Введите seriasTime: ");
            seriasTime = int.Parse(Console.ReadLine());
            time += seriasTime;
            serias++;
        }

        answer = $"{tasks} {serias}";
        // end
        return answer;
    }
    public static string Task5(int power, int agility, int intellect, int number)
    {
        string answer = "";
        // code here
        int newPower = power;
        int newAgility = agility;
        int newIntellect = intellect;

        // Применяем бонусы
        switch (number)
        {
            case 1:
                newPower += 10;    // увеличиваем силу на 10
                newIntellect -= 5; // понижаем интеллект на 5
                break;
            case 2:
                newAgility += 5;   // увеличиваем ловкость на 5
                newPower -= 5;     // понижаем силу на 5
                break;
            case 3:
                newPower += 10;    // увеличиваем силу на 10
                newIntellect -= 5; // понижаем интеллект на 5
                break;
            case 4:
                newAgility += 15;  // увеличиваем ловкость на 15
                newPower -= 10;    // понижаем силу на 10
                newIntellect -= 10; // понижаем интеллект на 10
                break;
            case 5:
                newIntellect += 7; // увеличиваем интеллект на 7
                newPower -= 5;     // понижаем силу на 5
                break;
        }

        // Проверка на минимальное значение 0
        if (newPower < 0) newPower = 0;
        if (newAgility < 0) newAgility = 0;
        if (newIntellect < 0) newIntellect = 0;

        answer = $"{newPower} {newAgility} {newIntellect}";
        // end
        return answer;
    }
}
