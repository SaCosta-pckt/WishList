using System.Collections.Generic;
using WishList.src.interfaces;

namespace WishList.src.Classes
{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            //não pode remover para não reclassificar os itens e mudar os indices
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public void MarcaAssistidos(int id, int epsAssistidos)
        {            
            if(epsAssistidos < listaSerie[id].retornaTotalEps())
            {
                listaSerie[id].setEpsAssistidos(epsAssistidos);
            }
            else if (epsAssistidos == listaSerie[id].retornaTotalEps())
            {
                listaSerie[id].setEpsAssistidos(epsAssistidos);
                listaSerie[id].setAssistido(true);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}