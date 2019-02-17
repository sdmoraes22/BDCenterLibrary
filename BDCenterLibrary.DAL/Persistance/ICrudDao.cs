using System;
using System.Collections.Generic;
using System.Text;

namespace BDCenterLibrary.DAL.Persistance
{
    public interface ICrudDao<T>
    {
        void Inserir(T entidade);
        void Alterar(T entidade);
        void Excluir(T entidade);
        T RetornarPorId(int id);
        IList<T> Consultar();
    }
}
