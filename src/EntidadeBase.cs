namespace WishList.src
{
    public abstract class  EntidadeBase
    {
        public int id { get; protected set; }
        public int ano_estreia { get; protected set; }
        public string titulo { get; protected set; } = "";
        public Genero genero { get; protected set; }
        public string sinopse { get; protected set; }  = "Nenhuma sinopse foi cadastrada";
    }
}