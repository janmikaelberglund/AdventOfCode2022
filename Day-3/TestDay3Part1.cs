using Xunit.Abstractions;

namespace Day_3
{
    public class TestDay3Part1
    {
        private readonly ITestOutputHelper testOutputHelper;

        public TestDay3Part1(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData(new[] { "vJrwpWtwJgWrhcsFMMfFFhFp" }, 16)]
        [InlineData(new[] { "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL" }, 38)]
        [InlineData(new[] { "PmmdzqPrVvPwwTWBwg" }, 42)]
        [InlineData(new[] { "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn" }, 22)]
        [InlineData(new[] { "ttgJtRGJQctTZtZT" }, 20)]
        [InlineData(new[] { "CrZsJsPPZsGzwwsLwLmpwMDw" }, 19)]
        public void TestSingleLineOfData(string[] input, int expected)
        {
            var day3 = new Day3(input);

            Assert.NotEmpty(day3.input);

            Assert.Equal(expected, day3.SumOfPriorities());
        }

        [Fact]
        public void TestArrayOfData()
        {
            var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "inputExample.txt"));

            var day3 = new Day3(input);

            Assert.NotEmpty(day3.input);

            Assert.Equal(157, day3.SumOfPriorities());
        }


        [Fact]
        public void ActualRun()
        {
            var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "input.txt"));

            var day3 = new Day3(input);


            testOutputHelper.WriteLine($"Result: {day3.SumOfPriorities()}");
        }
    }
}