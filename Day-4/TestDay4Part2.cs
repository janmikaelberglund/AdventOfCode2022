using Xunit.Abstractions;

namespace Day_4
{
    public class TestDay4Part2
    {
        private readonly ITestOutputHelper testOutputHelper;

        public TestDay4Part2(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void TestExampleInput()
        {
            var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "inputExample.txt"));

            var actual = Day4.Day4.FindOverlaps(input);

            Assert.Equal(4, actual);
        }

        [Fact]
        public void ActualRun()
        {
            var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "input.txt"));

            var actual = Day4.Day4.FindOverlaps(input);

            testOutputHelper.WriteLine(actual.ToString());
            testOutputHelper.WriteLine(@"\n {}");
        }
    }
}