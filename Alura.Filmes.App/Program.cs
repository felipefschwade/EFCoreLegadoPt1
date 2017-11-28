using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
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
                foreach (var ator in context.Atores.ToList())
                {
                    Console.WriteLine($"{ator.Id} {ator.PrimeiroNome} {ator.UltimoNome}");
                }
            }
        }
    }
}