using Xunit.Abstractions;

namespace Day5
{
    public class TestDay5Part1
    {
        private readonly ITestOutputHelper testOutputHelper;

        public TestDay5Part1(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void TestExampleInput()
        {
            var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "inputExample.txt"));

            var day5 = new Day5();
            day5.SetupCratesAndMoves(input);

            foreach (var move in day5.Moves)
            {
                day5.UseCrateMover9000(move);
            }

            var actual = string.Join("", day5.CrateStack.Select(stack => stack.Pop()));

            Assert.Equal("CMZ", actual);
        }

        [Fact]
        public void ActualRun()
        {
            var day5 = new Day5();
            var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "input.txt"));
            day5.SetupCratesAndMoves(input);

            foreach (var move in day5.Moves)
            {
                day5.UseCrateMover9000(move);
            }

            var actual = string.Join("", day5.CrateStack.Select(stack => stack.Pop()));

            testOutputHelper.WriteLine(actual.ToString());
        }
    }
}