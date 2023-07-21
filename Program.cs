using System.Text.Json;
using Soundbound_API.Modelos;
using Soundbound_API.Filtros;
{

}

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
       //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
       // musicas[0].ExibirDetalhesDaMusica();
        // LinqFilter.FiltarTodosOsGenerosMusicas(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltarArtistasPorGeneroMusical(musicas, "rock");
        Console.WriteLine();
         LinqFilter.FiltrarMusicasDeUmArtista(musicas, "The Weeknd");
        Console.WriteLine();
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Post Malone");

        //var musicasPreferidasDoFelipe = new MusicasPreferidas("Felipe");
        //musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[589]);
        //musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[44]);
        //musicasPreferidasDoFelipe.AdicionarMusicasFavoritas(musicas[1254]);

        //musicasPreferidasDoFelipe.ExibirMusicasFavoristas();

        //musicasPreferidasDoFelipe.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}