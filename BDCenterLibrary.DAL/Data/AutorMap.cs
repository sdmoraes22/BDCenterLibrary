using FluentNHibernate.Mapping;
using BDCenterLibrary.DAL.Model;

namespace BDCenterLibrary.DAL.Data
{
    public class AutorMap : ClassMap<Autor>
    {
        public AutorMap()
        {
            Table("Autor");
            Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);

            Map(x => x.Id);
            Map(x => x.Nome);
        }
    }
}
