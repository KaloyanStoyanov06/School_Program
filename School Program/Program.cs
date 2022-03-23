using System.Text;
using School_Program;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

var school = new School();
Console.WriteLine(new string('-', 50));

while (true)
{
    ShowMenu();

    // Input
    Console.Write("> ");
    var command = Console.ReadLine();

    CommandHandler(command);
}

void CommandHandler(string command)
{
    switch (command.ToLower())
    {
        case "1":
        case "showprogram":
        case "show program":
            school.ShowProgram();
            break;

        case "2":
        case "showteachers":
        case "show teachers":
            school.ShowTeachers();
            break;


        case "3":
        case "exit":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Invalid Command");
            Console.WriteLine(new string('-', 50));
            break;
    }
}

void ShowMenu()
{
    Console.WriteLine("1 - Show Program");
    Console.WriteLine("2 - Show teachers");
    Console.WriteLine("3 - Exit");
    Console.WriteLine(new string('-', 50));
    Console.WriteLine("");
}