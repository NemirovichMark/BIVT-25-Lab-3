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

            for (var i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }

        // public void Test2()
        // {
        //     var input = new (int n, double average)[]
        //     {
        //         (0, 0.0),
        //         (5, 2.75),
        //         (5, 3.75),
        //         (10, 4.05),
        //         (10, 3.95)
        //     };

        //     var answer = new[]
        //     {
        //         0,
        //         5,
        //         4,
        //         3,
        //         8
        //     };

        //     var test = new int[answer.Length];

        //     for (var i = 0; i < test.Length; i += 1)
        //     {
        //         using var stream = new StreamReader(
        //             "/home/kiraflux/Documents/Misis-Prog/BIVT-25-Lab-3/Lab3test/purple-test-2"
        //         );

        //         Console.SetIn(stream);

        //         var (n, r1, r2) = input[i];
        //         test[i] = _main.Task1(n, r1, r2);
        //     }

        //     for (var i = 0; i < answer.Length; i++)
        //     {
        //         Assert.AreEqual(answer[i], test[i]);
        //     }
        // }


        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new int[,]
            {
                { 0, 1, 2, 3, 5, 10, 15, 11, 20, 10 },
                { 1, 2, 3, 5, 10, 5, 0, 11, 10, 20 }
            };
            var answer = new double[] { 5, 5, 0, 55, 92.5, 55, 0, 92.5, 100, 100 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[0, i], input[1, i]);
            }

            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
    }
}
