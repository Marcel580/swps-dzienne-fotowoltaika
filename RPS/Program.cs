List<string> allowedSigns = ["rock", "paper", "scissors"];
string GetCorrectSign(string playerName)
{
    Console.WriteLine($"{playerName}, choose your sign ({string.Join('/', allowedSigns)})");
    string sign = Console.ReadLine()!;

   
    while (!allowedSigns.Contains(sign, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine($"{playerName}, choose correct sign ({string.Join('/', allowedSigns)})");
        sign = Console.ReadLine()!;
    }
    return sign;
}


const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;

Console.WriteLine("Let's play Rock-Paper-Scissors!");


string firstSign = GetCorrectSign("Player 1");
string secondSign = GetCorrectSign("Player 2");

// 1. Pobierz indeks znaku podanego przez osobę drugą (np. 0, 1, 2) - nazwę to secondSignIndex
int secondSignIndex = allowedSigns.IndexOf(secondSign);
// 2. Wylicz indeks znaku, który wygrywa z podanym przez osobę drugą - wzór - (secondSignIndex + 1) % rozmiarListy
int winningSignIndex = (secondSignIndex + 1) % allowedSigns.Count;
// 3. Czy indeks znaku podanego przez pierwszą osobę to indeks wyliczony w punkcie 2.
int firstSignIndex = allowedSigns.IndexOf(firstSign);


if (firstSign.Equals(secondSign, stringComparison))
{
    Console.WriteLine("It's a draw!");
}
else if (firstSignIndex == winningSignIndex)
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
}
