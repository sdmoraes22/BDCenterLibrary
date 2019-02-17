using BDCenterLibrary.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDCenterLibrary.DAL.Persistance
{
    public interface ILivroRepository
    {
        Livro Get(int id);
        IEnumerable<Livro> GetAll();
        Livro Add(Livro livro);
        void Delete(int id);
        bool Update(Livro livro);
    }
}
