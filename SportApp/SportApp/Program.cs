using SportApp;

Console.WriteLine("Witaj w aplikacji do obliczania statystyk z konkurencji sportowych");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("Wybierz nazwę konkurencji : ");
Console.WriteLine("1. Pchnięcie kulą");
Console.WriteLine("2. Rzut oszczepem");
Console.WriteLine("3. Rzut młotem");
Console.WriteLine("4. Skok w dal");
Console.WriteLine("  ");
Console.Write("Wpisz odpowiedni numer : ");
var choice = Console.ReadLine();
Console.WriteLine("  ");
Console.WriteLine("Dodaj zawodnika.");
Console.Write("Imie : ");
var name = Console.ReadLine();
Console.Write("Nazwisko : ");
var surname = Console.ReadLine();

var player = new PlayerInFile(name, surname);
player.ResultAdded += ResultAddedDelegate;

void ResultAddedDelegate(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nowy wynik");
}

while (true)
{
    Console.WriteLine("  ");
    Console.WriteLine("Dodaj wynik lub zakończ wybierając 'q'");
    var result = Console.ReadLine();
    if (result == "q")
    {
        break;
    }
    try
    {
        player.AddResult(result);
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}

var statistic = player.GetStatistics();

switch (choice)
{
    case "1":
        Console.WriteLine("Pchnięcie kulą");
        break;
    case "2":
        Console.WriteLine("Rzut oszczepem");
        break;
    case "3":
        Console.WriteLine("Rzut młotem");
        break;
    case "4":
        Console.WriteLine("Skok w dal");
        break;
    default:
        break;
}
Console.WriteLine("  ");
Console.WriteLine($"Zawodnik : {player.Name} {player.Surname}");
Console.WriteLine($"Najwyższy wynik : {statistic.MaxResult}");
Console.WriteLine($"Najniższy wynik : {statistic.MinResult}");
Console.WriteLine($"Suma wyników : {statistic.Sum}");
Console.WriteLine($"Średnia z wyników : {statistic.AvarageResult:N2}");
Console.WriteLine($"Różnica między najwyższym a najniższym wynikiem : {statistic.Difference}");