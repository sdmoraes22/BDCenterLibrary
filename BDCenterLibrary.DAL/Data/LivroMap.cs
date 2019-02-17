using BDCenterLibrary.DAL.Model;
using FluentNHibernate.Mapping;
using System;

namespace BDCenterLibrary.DAL.Data
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Table("Livro");

            Id(x => x.Id, "Id").GeneratedBy.Identity().UnsavedValue(0);
            Map(x => x.Nome);
            Map(x => x.Preco);
            Map(x => x.DataPublicacao);
            Map(x => x.UrlCapa);
            HasOne(x => x.Autor);
        }
    }
}
