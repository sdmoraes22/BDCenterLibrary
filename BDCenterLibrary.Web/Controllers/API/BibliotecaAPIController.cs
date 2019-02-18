using BDCenterLibrary.BLL;
using BDCenterLibrary.DAL.Model;
using BDCenterLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BDCenterLibrary.Web.Controllers.API
{
    public class BibliotecaAPIController : ApiController
    {
        static readonly LivroBLL livroBLL = new LivroBLL();

        public IEnumerable<Livro> GetLivros()
        {
            return livroBLL.ListarLivros();
        }

        public void DeleteLivro(LivroDto livro)
        {
            livroBLL.RemoverLivro(livro);
        }
    }
}
