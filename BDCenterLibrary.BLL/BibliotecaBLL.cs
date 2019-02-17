using BDCenterLibrary.DAL.Model;
using BDCenterLibrary.DAL.Persistance;

namespace BDCenterLibrary.BLL
{
    public class BibliotecaBLL
    {
        private LivroRepository _livroRepository = new LivroRepository();

        public void SalvarLivro(Livro livro)
        {
            _livroRepository.Inserir(livro);
        }

        public void ListarLivros()
        {
            _livroRepository.Consultar();
        }

        public void BuscarLivroPorId(int id)
        {
            _livroRepository.RetornarPorId(id);
        }

        public void RemoverLivro(Livro livro)
        {
            _livroRepository.Excluir(livro);
        }
    }
}
