namespace WishList.src
{
    public class Serie : EntidadeBase
    {
        private int eps { get; set; }
        private int eps_assistidos { get; set; }
    
        public Serie(string titulo, Genero genero, int eps, int eps_assistidos, int ano_estreia)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.eps = eps;
            this.eps_assistidos = eps_assistidos;
            this.ano_estreia = ano_estreia;
        }

        public Serie(string titulo, Genero genero, int eps, int eps_assistidos, int ano_estreia, string sinopse)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.eps = eps;
            this.eps_assistidos = eps_assistidos;
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

    }
}