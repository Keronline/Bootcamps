using System;
using System.Collections.Generic;
using APP.Series.Interfaces;

namespace APP.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie>  listaSerie = new List<Serie>();
        
        
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }
        public void Atualiza(int id, Task objeto)
        {

        }

        public void Exclui(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornoPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
