using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class PokemonDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string? ImagenUrl { get; set; }
}

public class Program
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task Main()
    {
        Console.Write("Ingresa el nombre del Pokémon: ");
        string nombreInput = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(nombreInput))
        {
            Console.WriteLine("Debes ingresar un nombre.");
            return;
        }

        try
        {
            // Llamada directa a la API
            var response = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{nombreInput.ToLower()}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                // Extracción precisa de solo lo que necesitas
                var pokemon = new PokemonDto
                {
                    Id = root.GetProperty("id").GetInt32(),
                    Nombre = root.GetProperty("name").GetString() ?? "Desconocido",
                    ImagenUrl = root.GetProperty("sprites")
                                    .GetProperty("other")
                                    .GetProperty("official-artwork")
                                    .GetProperty("front_default")
                                    .GetString()
                };

                // Resultado final limpio
                Console.WriteLine("\n--- Resultado ---");
                Console.WriteLine($"ID: {pokemon.Id}");
                Console.WriteLine($"Nombre: {pokemon.Nombre}");
                Console.WriteLine($"Imagen: {pokemon.ImagenUrl}");
                try
                {
                    // Esto ejecuta 'xdg-open <url>' en tu Fedora, lo que abre el navegador
                    System.Diagnostics.Process.Start("xdg-open", pokemon.ImagenUrl);
                    Console.WriteLine(">> Abriendo imagen en el navegador...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No se pudo abrir el navegador automáticamente: {ex.Message}");
                    Console.WriteLine("Copia y pega la URL manualmente en tu navegador.");
                }
            }
            else
            {
                Console.WriteLine($"Error: No se encontró el Pokémon '{nombreInput}' (Código: {response.StatusCode})");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error de conexión: {ex.Message}");
        }
    }
}