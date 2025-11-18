List<string> allowedSigns = ["rock", "paper", "scissors"];
string GetCorrectSign(string playerName)
{
    Console.WriteLine($"{playerName}, choose your sign ({string.Join('/', allowedSigns)})");
    string sign = Console.ReadLine()!;

    // while (!(firstSign.Equals(allowedSigns[0], stringComparison) || firstSign.Equals(allowedSigns[1], stringComparison) || firstSign.Equals(allowedSigns[2], stringComparison)))
    while (!allowedSigns.Contains(sign, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine($"{playerName}, choose correct sign ({string.Join('/', allowedSigns)})");
        sign = Console.ReadLine()!;
    }
    return sign;
}


const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;

Console.WriteLine("Let's play Rock-Paper-Scissors!");

// Console.WriteLine($"Player 1, choose your sign ({string.Join('/', allowedSigns)})");
// Console.WriteLine($"Player 1, choose your sign ({string.Join("/", allowedSigns)})");
// Console.WriteLine($"Player 1, choose your sign ({allowedSigns[0]}/{allowedSigns[1]}/{allowedSigns[2]})");
// string firstSign = Console.ReadLine()!;

// while (!(firstSign.Equals(allowedSigns[0], stringComparison) || firstSign.Equals(allowedSigns[1], stringComparison) || firstSign.Equals(allowedSigns[2], stringComparison)))
// while (!allowedSigns.Contains(firstSign, StringComparer.OrdinalIgnoreCase))
// {
//     Console.WriteLine($"Player 1, choose correct sign ({string.Join('/', allowedSigns)})");
//     firstSign = Console.ReadLine()!;
// }
string firstSign = GetCorrectSign("Player 1");
string secondSign = GetCorrectSign("Player 2");


if (firstSign.Equals(secondSign, stringComparison))
{
    Console.WriteLine("It's a draw!");
}
else if ((firstSign.Equals(allowedSigns[0], stringComparison) && secondSign.Equals(allowedSigns[2], stringComparison))
    || (firstSign.Equals(allowedSigns[1], stringComparison) && secondSign.Equals(allowedSigns[0], stringComparison))
    || (firstSign.Equals(allowedSigns[2], stringComparison) && secondSign.Equals(allowedSigns[1], stringComparison)))
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
}
