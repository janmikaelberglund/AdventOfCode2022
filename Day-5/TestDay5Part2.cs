using Xunit.Abstractions;

namespace Day5
{
    public class TestDay5Part2
    {
        private readonly ITestOutputHelper testOutputHelper;

        public TestDay5Part2(ITestOutputHelper testOutputHelper)
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
                day5.UseCrateMover9001(move);
            }

            var actual = string.Join("", day5.CrateStack.Select(stack => stack.Pop()));

            Assert.Equal("MCD", actual);
        }

        [Fact]
        public void ActualRun()
        {
            var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "input.txt"));

            var day5 = new Day5();
            day5.SetupCratesAndMoves(input);

            foreach (var move in day5.Moves)
            {
                day5.UseCrateMover9001(move);
            }

            var actual = string.Join("", day5.CrateStack.Select(stack => stack.Pop()));

            testOutputHelper.WriteLine(actual);
        }
    }
}