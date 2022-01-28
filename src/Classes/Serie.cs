using WishList.src.Enums;

namespace WishList.src.Classes
{
    public class Serie : EntidadeBase
    {
        private int eps { get; set; }
        private int eps_assistidos { get; set; }
        private bool excluido { get; set; }

    
        public Serie(int id, string titulo, Genero genero, int eps, int eps_assistidos, int ano_estreia)
        {
            this.id = id;
            this.titulo = titulo;
            this.genero = genero;
            this.eps = eps;
            this.eps_assistidos = eps_assistidos;
            this.ano_estreia = ano_estreia;
            this.excluido = false;
        }

        public Serie(int id, string titulo, Genero genero, int eps, int ano_estreia, string sinopse)
        {
            this.id = id;
            this.titulo = titulo;
            this.genero = genero;
            this.eps = eps;
            this.ano_estreia = ano_estreia;
            this.sinopse = sinopse;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Título: " + this.titulo + Environment.NewLine;
            retorno += "Gênero: " + this.genero + Environment.NewLine;
            retorno += "Episódios: " + this.eps + Environment.NewLine;
            retorno += "Assistidos: " + this.eps_assistidos + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.ano_estreia + Environment.NewLine;
            retorno += "Excluido: " + this.excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.titulo;
        }
        public int retornaId()
        {
            return this.id;
        }

        public bool retornaExcluido()
        {
            return this.excluido;
        }

        public void Excluir()
        {
            this.excluido = true;
        }

    }
}