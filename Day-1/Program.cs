



using System.Net;
using System;

var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "input.txt"));


Console.WriteLine(Part1(input));
Console.WriteLine(Part2(input));




string Part1(string[] input)
{
	List<int> calories = new();
	int temp = 0;
	for (int i = 0; i < input.Length; i++)
	{
		if (string.IsNullOrWhiteSpace(input[i]))
		{
			calories.Add(temp);
			temp = 0;
		}
		else
		{
			temp += int.Parse(input[i]);
		}
	}

	return calories.Max().ToString();
}


string Part2(string[] input)
{
    List<int> calories = new();
    int temp = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (string.IsNullOrWhiteSpace(input[i]))
        {
            calories.Add(temp);
            temp = 0;
        }
        else
        {
            temp += int.Parse(input[i]);
        }
    }

    return calories.OrderByDescending(x => x).Take(3).Sum().ToString();
}