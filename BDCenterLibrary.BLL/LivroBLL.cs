using BDCenterLibrary.DAL.Model;
using BDCenterLibrary.DAL.Persistance;
using System.Collections;
using System.Collections.Generic;

namespace BDCenterLibrary.BLL
{
    public class LivroBLL
    {
        private LivroRepository _livroRepository = new LivroRepository();

        public void SalvarLivro(Livro livro)
        {
            _livroRepository.Inserir(livro);
        }

        public IEnumerable<Livro> ListarLivros()
        {
            return _livroRepository.Consultar();
        }

        public void BuscarLivroPorId(int id)
        {
            _livroRepository.RetornarPorId(id);
        }

        public void RemoverLivro(Livro livro)
        {
            _livroRepository.Excluir(livro);
        }

        public void AlterarLivro(Livro livro)
        {
            _livroRepository.Alterar(livro);
        }
    }
}
