using System;

namespace BDCenterLibrary.DAL.Model
{
    public class Livro
    {
        public virtual int Id { get; protected set; }
        public virtual string Nome { get; set; }
        public virtual double Preco { get; set; }
        public virtual DateTime DataPublicacao { get; set; }
        public virtual string UrlCapa { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
