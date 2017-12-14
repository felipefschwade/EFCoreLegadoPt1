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
                var filme = context.Filmes
                    .Include(f => f.Atores)
                        .ThenInclude(fa => fa.Ator)
                    .First();
                foreach (var ator in filme.Atores)
                {
                    Console.WriteLine(ator.Ator.PrimeiroNome + " " + ator.Ator.UltimoNome);
                }
                Console.ReadKey();
            } 
        }
    }
}