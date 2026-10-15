using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Filme
{
    [JsonPropertyName("rank")]
    public string? Rank { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("year")]
    public string? Year { get; set; }
    [JsonPropertyName("crew")]
    public string? Diretor { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"Rank: {Rank}");
        Console.WriteLine($"Título: {Title}");
        Console.WriteLine($"Ano: {Year}");
        Console.WriteLine($"Diretor: {Diretor}");
    }
}
