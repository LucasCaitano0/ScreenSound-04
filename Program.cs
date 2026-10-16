using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //string pais = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        //string filme = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //var paises = JsonSerializer.Deserialize<List<Pais>>(pais)!;
        //var filmes = JsonSerializer.Deserialize<List<Filme>>(filme)!;
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.filtrarMusicasDeUmArstista(musicas, "Post Malone");
        //filmes[0].ExibirDetalhesDoFilme();

        //paises[0].ExibiDetalhesDoPais();

        //foreach (var musica in musicas)
        //{
        //    musica.ExibiDetalhesDaMusica();
        //    Console.WriteLine("--------------------");
        //}

        var musicasPreferidas = new MusicasPreferidas("Lucas");
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[0]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);

        musicasPreferidas.ExibirMusicasFavoritas();

        musicasPreferidas.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}
