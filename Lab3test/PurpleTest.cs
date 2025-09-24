namespace Lab3test
{
    [TestClass]
    public sealed class PurpleTest
    {
        Lab3.Purple _main = new Lab3.Purple();
        private const double E = 0.0001;

        [TestMethod]
        public void Test1()
        {
            var input = new (int n, int r1, int r2)[]
            {
                (0, 0, 0),
                (5, 0, 3),
                (5, 1, 3),
                (10, 2, 3),
                (10, 1, 5)
            };

            var answer = new[]
            {
                0,
                5,
                4,
                3,
                8
            };

            var test = new int[answer.Length];

            for (var i = 0; i < test.Length; i += 1)
            {
                using var stream = new StreamReader(
                    "/home/kiraflux/Documents/Misis-Prog/BIVT-25-Lab-3/Lab3test/purple-task-1"
                );

                Console.SetIn(stream);

                var (n, r1, r2) = input[i];
                test[i] = _main.Task1(n, r1, r2);
            }

            for (var i = 0; i < answer.Length; i += 1) Assert.AreEqual(answer[i], test[i]);
        }

        [TestMethod]
        public void Test2()
        {
            var input = new[]
            {
                0,
                1,
                2,
                5,
                10
            };

            var answer = new (int n, double average)[]
            {
                (0, 0.0),
                (1, 2.75),
                (1, 3.75),
                (2, 4.05),
                (3, 3.925)
            };

            var test = new (int, double)[answer.Length];

            for (var i = 0; i < test.Length; i += 1)
            {
                using var stream = new StreamReader(
                    "/home/kiraflux/Documents/Misis-Prog/BIVT-25-Lab-3/Lab3test/purple-task-2"
                );

                Console.SetIn(stream);

                var n = input[i];
                test[i] = _main.Task2(n);
            }

            for (var i = 0; i < answer.Length; i += 1) Assert.AreEqual(answer[i], test[i]);
        }

        [TestMethod]
        public void Test3()
        {
            var input = new[]
            {
                0,
                1,
                2,
                3,
                5
            };

            var answer = new[]
            {
                0,
                3,
                3.5,
                3.3333,
                3.6
            };

            var test = new double[answer.Length];

            for (var i = 0; i < test.Length; i += 1)
            {
                using var stream = new StreamReader(
                    "/home/kiraflux/Documents/Misis-Prog/BIVT-25-Lab-3/Lab3test/purple-task-3"
                );

                Console.SetIn(stream);

                var n = input[i];
                test[i] = _main.Task3(n);
            }


            for (var i = 0; i < answer.Length; i += 1) Assert.AreEqual(answer[i], test[i], 0.0001);
        }

        [TestMethod]
        public void Test4()
        {
            var input = new (int code, int limit)[]
            {
                (000, 1),
                (000, 5),
                (123, 3),
                (283, 3),
                (283, 2)
            };

            var answer = new[]
            {
                ("Система заблокирована!", 1),
                ("Аварийный выход!", 4),
                ("Доступ разрешен!", 2),
                ("Доступ разрешен!", 3),
                ("Система заблокирована!", 2),
            };

            // 1 {Task4(000, 1) == ("Система заблокирована!", 1)
            // 2 {Task4(000, 5) == ("Аварийный выход!", 4)
            // 3 {Task4(123, 3) == ("Доступ разрешен!", 2)
            // 4 {Task4(283, 3) == ("Доступ разрешен!", 3)
            // 5 {Task4(283, 2) == ("Система заблокирована!", 2)

            var test = new (string, int)[answer.Length];

            for (var i = 0; i < test.Length; i += 1)
            {
                using var stream = new StreamReader(
                    "/home/kiraflux/Documents/Misis-Prog/BIVT-25-Lab-3/Lab3test/purple-task-4"
                );

                Console.SetIn(stream);

                var (code, limit) = input[i];
                test[i] = _main.Task4(code, limit);
            }

            for (var i = 0; i < answer.Length; i += 1) Assert.AreEqual(answer[i], test[i]);
        }


        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new[,]
            {
                { 0, 1, 2, 3, 5, 10, 15, 11, 20, 10 },
                { 1, 2, 3, 5, 10, 5, 0, 11, 10, 20 }
            };
            var answer = new[] { 5, 5, 0, 55, 92.5, 55, 0, 92.5, 100, 100 };
            var test = new double[answer.Length];

            // Act
            for (var i = 0; i < answer.Length; i += 1) test[i] = _main.Task5(input[0, i], input[1, i]);

            // Assert
            for (var i = 0; i < answer.Length; i += 1) Assert.AreEqual(answer[i], test[i]);
        }
    }
}
