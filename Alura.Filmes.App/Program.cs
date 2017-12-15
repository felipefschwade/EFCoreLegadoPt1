using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AluraFilmesDbContext())
            {
                context.LogSQLToConsole();
                var idiomas = context.Idiomas
                    .Include(i => i.FilmesFalados)
                    .Include(i => i.FilmesOriginais)
                    .ToList();

                foreach (var idioma in idiomas)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Filmes da categoria {idioma}:");
                    foreach (var filme in idioma.FilmesFalados)
                    {
                        Console.WriteLine($"Falado {filme}");
                    }
                    foreach (var filme in idioma.FilmesOriginais)
                    {
                        Console.WriteLine($"Original {filme}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}