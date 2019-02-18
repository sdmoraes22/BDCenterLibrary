using System;
namespace BDCenterLibrary.DTO
{
    public class LivroDto
    {
        public virtual int Id { get; protected set; }
        public virtual string Nome { get; set; }
        public virtual double Preco { get; set; }
        public virtual DateTime DataPublicacao { get; set; }
        public virtual string UrlCapa { get; set; }
        public AutorDto Autor { get; set; }
    }
}
