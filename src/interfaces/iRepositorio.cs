namespace WishList.src.interfaces
{
    public interface iRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void MarcaAssistidos(int id, int epsAssistidos);
         void Exclui(int id);
         void Atualiza(int id, T objeto);
         int ProximoId();
    }
}