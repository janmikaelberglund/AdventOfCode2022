using Xunit.Abstractions;

namespace Day_3
{
    public class TestDay3Part2
    {
        private readonly ITestOutputHelper testOutputHelper;

        public TestDay3Part2(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData(new[] { "vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg" }, 18)]
        [InlineData(new[] { "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw" }, 52)]
        public void TestSingleLineOfData(string[] input, int expected)
        {
            var day3 = new Day3(input);

            Assert.NotEmpty(day3.input);

            Assert.Equal(expected, day3.SumOfBadgePriorities());
        }

        [Fact]
        public void ActualRun()
        {
            var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "input.txt"));

            var day3 = new Day3(input);


            testOutputHelper.WriteLine($"Result: {day3.SumOfBadgePriorities()}");
        }
    }
}