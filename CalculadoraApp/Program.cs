using Spectre.Console;

namespace CalculadoraApp;

class Program
{
    static void Main(string[] args)
    {
        // Título con estilo
        AnsiConsole.Write(
            new FigletText("Calculadora .NET")
                .Centered()
                .Color(Color.Cyan1));

        while (true)
        {
            // Menú principal
            var opcion = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[green]¿Qué quieres hacer?[/]")
                    .PageSize(10)
                    .AddChoices(new[] {
                        "Calcular", 
                        "Ver historial",
                        "Salir"
                    }));

            switch (opcion)
            {
                case "Calcular":
                    Calcular();
                    break;
                case "Ver historial":
                    VerHistorial();
                    break;
                case "Salir":
                    AnsiConsole.MarkupLine("[yellow]¡Hasta luego![/]");
                    return;
            }
        }
    }

    static void Calcular()
    {
        Console.Clear();
        
        // Pedir números
        double num1 = AnsiConsole.Ask<double>("[blue]Ingresa el primer número:[/]");
        double num2 = AnsiConsole.Ask<double>("[blue]Ingresa el segundo número:[/]");

        // Elegir operación
        var operacion = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[green]Elige una operación:[/]")
                .PageSize(10)
                .AddChoices(new[] { "+", "-", "*", "/" }));

        double resultado = 0;
        string operadorTexto = "";

        // Calcular según la operación
        switch (operacion)
        {
            case "+":
                resultado = num1 + num2;
                operadorTexto = "suma";
                break;
            case "-":
                resultado = num1 - num2;
                operadorTexto = "resta";
                break;
            case "*":
                resultado = num1 * num2;
                operadorTexto = "multiplicación";
                break;
            case "/":
                if (num2 == 0)
                {
                    AnsiConsole.MarkupLine("[red]¡Error! No se puede dividir entre cero.[/]");
                    return;
                }
                resultado = num1 / num2;
                operadorTexto = "división";
                break;
        }

        // Mostrar resultado con estilo
        AnsiConsole.MarkupLine($"[green]El resultado de la {operadorTexto} es: [bold]{resultado}[/][/]");
        
        // Guardar en historial (archivo temporal)
        string historial = $"{num1} {operacion} {num2} = {resultado}";
        File.AppendAllText("historial.txt", historial + Environment.NewLine);
        
        AnsiConsole.MarkupLine("[grey]Presiona cualquier tecla para continuar...[/]");
        Console.ReadKey();
        Console.Clear();
    }

    static void VerHistorial()
    {
        Console.Clear();
        
        if (File.Exists("historial.txt"))
        {
            var historial = File.ReadAllLines("historial.txt");
            
            var table = new Table();
            table.AddColumn("[yellow]Operaciones realizadas[/]");
            
            foreach (var linea in historial)
            {
                table.AddRow(linea);
            }
            
            AnsiConsole.Write(table);
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Aún no hay historial.[/]");
        }
        
        AnsiConsole.MarkupLine("[grey]Presiona cualquier tecla para continuar...[/]");
        Console.ReadKey();
        Console.Clear();
    }
}