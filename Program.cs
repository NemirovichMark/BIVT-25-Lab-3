namespace CW1.Var00
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            //program.Task1(0.1, 2); // answer = 0.0995
            //program.Task2(10, 0.1); // answer = 5
            program.Task3(11, 6); // answer = 7
            program.Task4(0.1, 0.9, 0.1); // answer = 0.44350278734486975
            program.Task13(0.1, 1, 0.1); // answer = 
        }
        public double Task1(double x, int n)
        {
            double S = 0;

            double p = 1, ch = 1, zn = 1;
            double pow = x;

            for (int i = 1; i<=n; i++)
            {
                S += p * ch * pow / (zn * zn);
                p = -p;
                ch++;
                pow *= x * x;
                zn++;
            }

            Console.WriteLine(S);

            return S;
        }
        public int Task2(int questions, double accuracy)
        {
            double i = 0, mistakes = 0, answer = 0;
            do
            {
                answer = i % 10;
                answer /= 10;

                if (answer > accuracy)
                {
                    mistakes++;
                    questions += 2;
                }

                i ++;
            }
            while (i < questions && mistakes < 5);

            Console.WriteLine(mistakes);
            return (int)mistakes;
        }
        public int Task3(int eggs, int baskets)
        {
            int catched = 0, posWolf = 1, posEgg = 1;
            int dir = 1;

            for (int i = 1; i<=eggs; i++)
            {
                if (posWolf == posEgg)
                {
                    catched++;
                }

                if (posWolf == 1) dir = 1;
                if (posWolf == baskets) dir = -1;

                posWolf += dir;
                posEgg++;

                if (posEgg > baskets) posEgg = 1;
            }

            Console.WriteLine(catched);
            return catched;
        }
        public double Task4(double a, double b, double h)
        {

            double S = 0, S1 = 0;
            int n = 0;
            for (double x = a; x<=b+0.0001; x+=h)
            {
                int p = 1;
                int ch = 1;
                double pow = x;
                int zn = 1;

                //while (p * ch * pow / zn; )
            }
            return 0;
        }
        public double Task13(double a, double b, double h)
        {
            return 0;
        }
    }
}
