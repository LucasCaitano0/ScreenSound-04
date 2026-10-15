using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int? Populacao { get; set; }

    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }

    public void ExibiDetalhesDoPais()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"População: {Populacao}");
        Console.WriteLine($"Idioma: {Idioma}");
    }
}
