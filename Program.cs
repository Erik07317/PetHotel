Console.WriteLine("Bem-vindos ao PetHotel!");
Console.WriteLine("Digite as características do seu pet");

Console.WriteLine("Especíe:");
string especie = Console.ReadLine()!;

Console.WriteLine("Raça:");
string raca = Console.ReadLine()!;

Console.WriteLine("Atende pela alcunha de:");
string nome = Console.ReadLine()!;

Console.WriteLine("Idade:");
int idade = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Pelagem:");
string pelagem = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                |");
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"| Espécie: ............{especie} | Raça: ............{raca} |");
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"| Atende pela alcunha de: ...........................{nome} |");
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"| Idade: {idade} ano(s) | Pelagem/cor: ..............{pelagem}|");
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");