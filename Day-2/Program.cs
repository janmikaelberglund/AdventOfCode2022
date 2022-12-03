



var input = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "input.txt"));


Console.WriteLine(Part1(input));
Console.WriteLine(Part2(input));

int Part1(string[] input)
{
    return input.Sum(x => Part1Logic(x[0], x[2]));
}

int Part1Logic(char move, char response)
{
    var moveValue = Convert.ToInt32(move) -64;
    var responseValue = Convert.ToInt32(response) - 23 - 64;

    if (moveValue == responseValue)
        return 3 + responseValue;
    else if (moveValue == responseValue -1 || moveValue == responseValue + 2)
        return 6 + responseValue;
    else return responseValue;
}



int Part2(string[] input)
{
    return input.Sum(x => Part2Logic(x[0], x[2]));
}


int Part2Logic(char move, char response)
{
    var moveValue = Convert.ToInt32(move) - 64;
    var responseValue = Convert.ToInt32(response) - 23 - 64;

    if (responseValue == 1)
    {
        if (moveValue + 2 > 3)
            return moveValue - 1;
        else
            return moveValue + 2;
    }
    else if (responseValue == 3)
    {
        if (moveValue + 1 > 3)
            return moveValue - 2 + 6;
        else
            return moveValue + 1 + 6;
    }
    else
    {
        return moveValue + 3;
    }
}

