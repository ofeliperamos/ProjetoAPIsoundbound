using Soundbound_API.Modelos;
using System.Linq;


namespace Soundbound_API.Filtros;

internal class LinqFilter
{
    public static void FiltarTodosOsGenerosMusicas(List<Musica> musicas)
    {
        var todosOsGenereosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenereosMusicais)
        {
            Console.WriteLine($"-{genero}");
        }
    }

    public static void FiltarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    public  static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista) 
    {
    var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }


}
