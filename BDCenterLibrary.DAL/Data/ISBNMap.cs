using BDCenterLibrary.DAL.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDCenterLibrary.DAL.Data
{
    public class ISBNMap : ClassMap <ISBN>
    {
        public ISBNMap()
        {
            Table("ISBN");

            Id(x => x.Isbn);
            HasOne(x => x.Livro);
        }

    }
}
