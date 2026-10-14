using (HttpClient client = new HttpClient())
{
    string resoosta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(resoosta);
}
