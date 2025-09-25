using System.Globalization;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here 

            static double HypotSquared(double x, double y) => x * x + y * y;

            r1 *= r1;
            r2 *= r2;

            bool IsIn(double x, double y)
            {
                var h = HypotSquared(x, y);
                return h >= r1 && h <= r2;
            }

            for (var i = 0; i < n; i += 1)
            {
                var s = Console.ReadLine();
                var x = double.Parse(s, CultureInfo.InvariantCulture);
                var y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (IsIn(x, y)) count += 1;
            }

            // end

            return count;
        }

        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here

            double sum = 0;

            for (var studentIndex = 0; studentIndex < n; studentIndex += 1)
            {
                var failed = false;

                for (var i = 0; i < 4; i += 1)
                {
                    var mark = int.Parse(Console.ReadLine());
                    sum += mark;
                    if (mark <= 2) failed = true;
                }

                if (failed) count += 1;
            }

            if (n != 0) average = sum / (n * 4);

            // end

            return (count, average);
        }

        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here


            // Ура!! Задание для switch.
            // так вот оно какое - задание на Switch case! >:P
            static int MatchMarkByScore(int s)
            {
                switch (s)
                {
                    case > 86:
                        return 5;

                    case 85:
                    case 84:
                    case 83:
                    case 82:
                    case 81:
                    case 80:

                    case 79:
                    case 78:
                    case 77:
                    case 76:
                    case 75:
                    case 74:
                    case 73:
                    case 72:
                    case 71:
                    {
                        {
                            {
                                {
                                    {
                                        {
                                            {
                                                {
                                                    {
                                                        {
                                                            {
                                                                {
                                                                    {
                                                                        {
                                                                            {
                                                                                {
                                                                                    {
                                                                                        {
                                                                                            {
                                                                                                {
                                                                                                    {
                                                                                                        {
                                                                                                            {
                                                                                                                {
                                                                                                                    {
                                                                                                                        {
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                        return 4;

                    case 70:

                    case 69:
                    case 68:
                    case 67:
                    case 66:
                    case 65:
                    case 64:
                    case 63:
                    case 62:
                    case 61:
                    case 60:

                    case 59:
                    case 58:
                    case 57:
                    case 56:
                    case 55:
                    case 54:
                    case 53:
                    case 52:
                    case 51:
                    case 50:
                        return 3;

                    default:
                    {
                        {
                            {
                                {
                                    {
                                        {
                                            {
                                                {
                                                    {
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                        return (
                            (
                                (
                                    (
                                        (
                                            (
                                                (
                                                    (
                                                        (
                                                            (
                                                                (
                                                                    (
                                                                        (
                                                                            (
                                                                                (
                                                                                    (
                                                                                        (
                                                                                            (
                                                                                                (
                                                                                                    (
                                                                                                        2))))))))))))))))))));
                }
            }

            var n = exams;

            while (exams > 0)
            {
                var theory = int.Parse(Console.ReadLine());
                var practice = int.Parse(Console.ReadLine());

                var score = 0.4 * theory + 0.6 * practice;

                var mark = MatchMarkByScore((int)score);

                avgMark += (double)mark / n;

                exams -= 1;
            }
            // end

            return avgMark;
        }

        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here

            const int vmGuardProtectorSystemExitCodeCodeBtw = -0x7_F_6_6_A_E_A_E;

            static int VmGuardProtectorSystemReadCode()
            {
                var ret = 0;

                for (var power = 100; power > 0; power /= 10)
                {
                    var input = int.Parse(Console.ReadLine());

                    if (input == -1) return vmGuardProtectorSystemExitCodeCodeBtw;

                    ret += input * power;
                }

                return ret;
            }

            (string solution, int attempts) VmGuardProtectorSystemCoreEntry()
            {
                const string accessAccept = "Доступ разрешен!";
                const string accessDenied = "Система заблокирована!";
                const string kernelPanicLmao = "Аварийный выход!";

                var currentAttemp = 1;

                while (currentAttemp <= limit)
                {
                    var readedCode = VmGuardProtectorSystemReadCode();

                    if (readedCode == vmGuardProtectorSystemExitCodeCodeBtw)
                        return (kernelPanicLmao, currentAttemp);

                    if (readedCode == code)
                        return (accessAccept, currentAttemp);


                    currentAttemp += 1;
                }

                return (accessDenied, currentAttemp - 1);
            }

            (solution, attempts) = VmGuardProtectorSystemCoreEntry();

            // end

            return (solution, attempts);
        }

        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here

            const int enum_class_MyC00l_Enumerator_t__EnergyPeakLmao = -0x7FE_AAA_0F;
            const int enum_class_MyC00l_Enumerator_t__DarkForces = 0x0_A_00_AA_0_0;
            const int enum_class_MyC00l_Enumerator_t__PlusFive = 0x7_A_0_A_0_A_0_A;
            const int enum_class_MyC00l_Enumerator_t__MythicChanceBtw = 0x00_FF_1234;

            static double MatchLuckModifier(int x)
            {
                return x switch
                {
                    1 or 8 or 15 or 22 or 29 => enum_class_MyC00l_Enumerator_t__EnergyPeakLmao,
                    4 or 11 or 18 or 25 => enum_class_MyC00l_Enumerator_t__DarkForces,
                    7 or 14 or 21 or 28 => enum_class_MyC00l_Enumerator_t__MythicChanceBtw,
                    _ => enum_class_MyC00l_Enumerator_t__PlusFive,
                };
            }

            var aLast = a + n;

            for (var i = a; i < aLast; i += 1)
            {
                switch (MatchLuckModifier(i))
                {
                    case enum_class_MyC00l_Enumerator_t__EnergyPeakLmao:
                        luck *= 1.5;
                        goto i_use_goto_btw____SanitaseProcedure;

                    case enum_class_MyC00l_Enumerator_t__DarkForces:
                        luck -= 10.0;
                        goto i_use_goto_btw____SanitaseProcedure;

                    case enum_class_MyC00l_Enumerator_t__MythicChanceBtw:
                    {
                        if (luck < 50.0)
                        {
                            {
                                {
                                    {
                                        {
                                            {
                                                {
                                                    luck = 55.0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                        goto i_use_goto_btw____SanitaseProcedure;


                    default:
                    {
                        {
                            luck += 5.0;
                        }
                    }
                        goto i_use_goto_btw____SanitaseProcedure;
                }

                i_use_goto_btw____SanitaseProcedure:
                {
                    luck = Math.Clamp(luck, 0.0, 100.0);
                }
            }

            // end

            return luck;
        }
    }
}