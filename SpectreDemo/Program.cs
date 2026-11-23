using Spectre.Console;

#region Previous Lessons

// Lesson 2
// AnsiConsole.MarkupLine("[red bold]Hello, World![/]");
// AnsiConsole.MarkupLine("Hello, World!");
// AnsiConsole.MarkupLine("[slowblink]Hello, World![/]");

#endregion

// Lesson 3
AnsiConsole.MarkupLine("[red on white bold]This is the inline markup.[/]");

Style dangerStyle = new(
    foreground: Color.Red,
    background: Color.White,
    decoration: Decoration.Bold | Decoration.Italic
);

AnsiConsole.Write(new Markup("Danger Text from Style", dangerStyle));
AnsiConsole.WriteLine(" and more...");

Console.ReadLine();
AnsiConsole.Clear();