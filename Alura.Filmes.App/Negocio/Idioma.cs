using System.Collections.Generic;

namespace Alura.Filmes.App.Negocio
{
    public class Idioma
    {
        public byte Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Filme> FilmesFalados { get; set; } = new List<Filme>();
        public IEnumerable<Filme> FilmesOriginais { get; set; } = new List<Filme>();

        public override string ToString()
        {
            return $"{Id}: {Nome}";
        }
    }
}