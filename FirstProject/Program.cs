string titleApplication = @"
▒█▀▀▀█ █▀▀ █▀▀█ █▀▀ █▀▀ █▀▀▄ 　 ▒█▀▀▀█ █▀▀█ █░░█ █▀▀▄ █▀▀▄ 
░▀▀▀▄▄ █░░ █▄▄▀ █▀▀ █▀▀ █░░█ 　 ░▀▀▀▄▄ █░░█ █░░█ █░░█ █░░█ 
▒█▄▄▄█ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀ ▀░░▀ 　 ▒█▄▄▄█ ▀▀▀▀ ░▀▀▀ ▀░░▀ ▀▀▀░";

void PrintColored(string text, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}

void TypeLine(string text, ConsoleColor color = ConsoleColor.White, int delayMs = 1)
{
    Console.ForegroundColor = color;
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(delayMs);
    }

    Console.WriteLine();
    Console.ResetColor();
}

void ShowWelcomeMessage()
{
    PrintColored(titleApplication, ConsoleColor.Cyan);
}

void DisplayMenuOptions()
{
    Console.WriteLine();
    PrintColored("                     MENU PRINCIPAL", ConsoleColor.Yellow);
    Console.WriteLine();

    TypeLine("                  [1] Registrar banda", ConsoleColor.White);
    TypeLine("                  [2] Listar todas as bandas", ConsoleColor.White);
    TypeLine("                  [3] Avaliar uma banda", ConsoleColor.White);
    TypeLine("                  [4] Ver média de avaliações", ConsoleColor.White);
    TypeLine("                  [0] Sair", ConsoleColor.Red);

    Console.WriteLine();
    Console.Write("Escolha uma opção: ");
    int optionChosen = int.Parse(Console.ReadLine()!);

    switch (optionChosen)
    {
        case 1: 
            Console.WriteLine("1");
            break;

        case 2: 
            Console.WriteLine("2"); 
            break;

        case 3: 
            Console.WriteLine("3");
            break;

        case 4: 
            Console.WriteLine("4");
            break;

        case 0:
            PrintColored("Tchau :)", ConsoleColor.DarkYellow);
            break;

        default:
            TypeLine("OPÇÃO INVÁLIDA. TENTE NOVAMENTE", ConsoleColor.Red, 30);
            Console.Clear();
            ShowWelcomeMessage();
            DisplayMenuOptions();
            break;
    }
}


ShowWelcomeMessage();
DisplayMenuOptions();