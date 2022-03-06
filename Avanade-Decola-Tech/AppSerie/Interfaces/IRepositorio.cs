
using System.Collections.Generic;

namespace APP.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornoPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, Task entidade);
         int ProximoId();
    }
}
