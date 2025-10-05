namespace Lab3test
{
    [TestClass]
    public sealed class GreenTest
    {
        Lab3.Green _main = new Lab3.Green();
        private const double E = 0.0001;

        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new int[,] {
                { 0, 1, 2, 3, 5, 10, 10, 10, 12, 25 },
                { 0, 3, 5, 10, 10, 10, 11, 12, 25, 12 },
                { 0, 1, 2, 3, 5,  1,  2,  3,  1,  0 }
            };
            var answer = new double[] { 0, 3, 65.973446, 14.83029, 0, 100, 65.973446, 54.543561, 300, 0};
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[0, i], input[1, i], input[2, i]);
                Console.WriteLine(test[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
    }
}
