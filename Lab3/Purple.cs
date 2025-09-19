using System;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here

	    for (int i = 0; i < n; i++){
	      double x, y;
	      x = Convert.ToDouble(Console.ReadLine());
	      y = Convert.ToDouble(Console.ReadLine());
	      double dist = Math.Sqrt(x*x+y*y);
	      if (dist>r1 && dist<r2) count++;
	    }

            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
	    for (int i = 0; i < n; ++i){
	      int m1 = Convert.ToInt32(System.Console.ReadLine());
	      int m2 = Convert.ToInt32(System.Console.ReadLine());
	      int m3 = Convert.ToInt32(System.Console.ReadLine());
	      int m4 = Convert.ToInt32(System.Console.ReadLine());
	      if (Math.Min(m1, m2, m3, m4) == 2){
		count+=1;
	      }
	      average+=(m1+m2+m3+m4)/4;
	    }
	    average /= n;



            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here

	    int theory, practice, mark, n = exams;
	    double score = 0;
	    while (exams>0){
	      theory = Convert.ToInt32(System.Console.ReadLine());
	      practice = Convert.ToInt32(System.Console.ReadLine());
	      score = 0.4*theory+0.6*practice;
	      if (score>85) mark = 5;
	      else if (score>70) mark = 4;
	      else if (score>50) mark = 3;
	      else mark = 2;
	      avgMark += mark/n;
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

	    while (attempts < limit){
	      int i1, i2, i3;
	      i1 = Convert.ToInt32(Console.ReadLine());
	      if (i1==-1){solution = "Аварийный выход!"; attempts++; break;}
	      i2 = Convert.ToInt32(Console.ReadLine());
	      if (i2==-1){solution = "Аварийный выход!"; attempts++; break;}
	      i3 = Convert.ToInt32(Console.ReadLine());
	      if (i3==-1){solution = "Аварийный выход!"; attempts++; break;}
	      if (i1*100+i2*10+i3 == code){
		solution = "";
		attempts++;
		break;
	      }
	      attempts++;
	    }


            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here 
   
	    for (int i = 0; i < n; i++){
	      switch((a+i)%30){        
		case 1:   luck = Math.Min(luck * 1.5, 100); break;
		case 8:   luck = Math.Min(luck * 1.5, 100); break;
		case 15:  luck = Math.Min(luck * 1.5, 100); break;
		case 22:  luck = Math.Min(luck * 1.5, 100); break;
		case 29:  luck = Math.Min(luck * 1.5, 100); break;
		case 4:   luck = Math.Max(luck - 10, 0); break;
		case 11:  luck = Math.Max(luck - 10, 0); break;
		case 18:  luck = Math.Max(luck - 10, 0); break;
		case 25:  luck = Math.Max(luck - 10, 0); break;
		case 7:   if (luck < 50) luck = 55; break;
		case 14:  if (luck < 50) luck = 55; break;
		case 21:  if (luck < 50) luck = 55; break;
		case 28:  if (luck < 50) luck = 55; break;
		default: luck = Math.Min(luck + 5, 100); break;
	      }
	    }



            // end

            return luck;
        }
    }
}
