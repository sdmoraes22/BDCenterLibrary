using AutoMapper;
using BDCenterLibrary.BLL;
using BDCenterLibrary.DAL.Model;
using BDCenterLibrary.DTO;
using System.Collections.Generic;
using System.Web.Http;

namespace BDCenterLibrary.Web.Controllers.API
{
    public class BibliotecaAPIController : ApiController
    {
        static readonly LivroBLL livroBLL = new LivroBLL();

        [HttpGet]
        public IEnumerable<Livro> GetLivros()
        {
            return livroBLL.ListarLivros();
        }

        [HttpDelete]
        public void DeleteLivro(Livro livro)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Livro, LivroDto>();
            });

            var source = new Livro();
            var dest = Mapper.Map<Livro, LivroDto>(source);

            livroBLL.RemoverLivro(livro);
        }

        [HttpGet]
        public void BuscarLivroPorId(int id)
        {
            livroBLL.BuscarLivroPorId(id);
        }

        [HttpPost]
        public void InsereLivro(Livro livro)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Livro, LivroDto>();
            });

            var source = new Livro();
            var dest = Mapper.Map<Livro, LivroDto>(source);

            livroBLL.SalvarLivro(livro);
        }

        [HttpPut]
        public void Atualiza(Livro livro)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Livro, LivroDto>();
            });

            var source = new Livro();
            var dest = Mapper.Map<Livro, LivroDto>(source);

            livroBLL.AlterarLivro(livro);
        }
    }
}
