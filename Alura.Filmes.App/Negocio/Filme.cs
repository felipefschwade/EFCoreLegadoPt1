using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoLancamento { get; set; }
        //public int LinguagemId { get; set; }
        //public virtual Linguagem Linguagem { get; set; }
        public IEnumerable<FilmeAtor> Atores { get; set; }
        public IEnumerable<FilmeCategoria> Categorias { get; set; }

        internal object Include()
        {
            throw new NotImplementedException();
        }

        public short Duracao { get; set; }
        public string Avaliacao { get; set; }

        public override string ToString()
        {
            return $@"Id: {Id} 
                   Titulo: {Titulo}
                   Descricao: {Descricao}
                   Ano: {AnoLancamento}
                   Duracao: {Duracao}
                   Avaliacao: {Avaliacao}";
        }
    }
}
