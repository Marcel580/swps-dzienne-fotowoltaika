using System.Security.Principal;

List<string> allowedSigns = ["rock", "paper", "scissors","lizard","spock"];
Dictionary<string,List<string>> winningMap = [];//wm
winningMap["rock"] = ["scisors ", "lizard"];
winningMap ["paper"]=["rock","spock"];
winningMap ["scisors"]=["lizard","paper"];
winningMap ["lizard"]=["paper","spock"];
winningMap ["spock"]=["rock","scisors"];

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

string GetCorrectRandomSign(string playerName)
{
    int signIndex = Random.Shared.Next(allowedSigns.Count);
    string sign = allowedSigns[signIndex];
    Console.WriteLine($"{playerName} selected {sign}");

    return sign;
}

const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;

int firstplayerpoints = 0;
int secondplayerpoints = 0;

Console.WriteLine("How many wins ?");
string maxWinsText= Console.ReadLine()!;
//int maxWins=int.Parse(maxWinsText);
bool parsingResult = uint.TryParse(maxWinsText,out uint maxWins);

while(!parsingResult|| maxWins <= 0 )
{
    maxWinsText= Console.ReadLine()!;
    parsingResult= uint.TryParse(maxWinsText,out maxWins);
    Console.WriteLine("How many wins ?");
}


while(firstplayerpoints < 3 && secondplayerpoints < 3)
{
    Console.WriteLine("Let's play Rock-Paper-Scissors!");

    string firstSign = GetCorrectSign("Player 1");//p1
    string secondSign = GetCorrectSign("Player 2");//p2

    List<string> SignsLosingWithFirstSign = winningMap[firstSign];

    if (firstSign.Equals(secondSign, stringComparison))
    {
        Console.WriteLine("It's a draw!");
    }
    else if (SignsLosingWithFirstSign.Contains(secondSign,StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine("First player won!");
        firstplayerpoints ++ ;
    }
    else
    {
        Console.WriteLine("Second player won!");
        secondplayerpoints ++;
    }
    Console.WriteLine($"First player:{firstplayerpoints}");
    Console.WriteLine($"Second Player:{secondplayerpoints}");

   // if(firstplayerpoints >= 3 || secondplayerpoints >= 3)
//{
    //break;
//}
}