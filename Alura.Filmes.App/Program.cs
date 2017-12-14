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
                var filmes = context.Filmes.ToList();
                foreach (var filme in filmes)
                {
                    Console.WriteLine(filme);
                }
                Console.ReadKey();
            } 
        }
    }
}