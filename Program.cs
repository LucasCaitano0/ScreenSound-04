using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        string pais = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        var paises = JsonSerializer.Deserialize<List<Pais>>(pais)!;

        paises[0].ExibiDetalhesDoPais();

        //foreach (var musica in musicas)
        //{
        //    musica.ExibiDetalhesDaMusica();
        //    Console.WriteLine("--------------------");
        //}

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}
