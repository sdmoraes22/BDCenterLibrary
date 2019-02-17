using NHibernate;
using NHibernate.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using BDCenterLibrary.DAL.Helper;


namespace BDCenterLibrary.DAL.Persistance
{
    public class RepositoryCrudDao<T> : ICrudDao<T> where T : class
    {
        public void Alterar(T entidade)
        {
            using (ISession session = NHiberateHelper.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Ocorreu um erro ao tentar atualizar a entidade: " + ex.Message);
                    }
                }
            }
        }

        public IList<T> Consultar()
        {
            using (ISession session = NHiberateHelper.AbrirSession())
            {
                return (from e in session.Query<T>() select e).ToList();
            }
        }

        public void Excluir(T entidade)
        {
            using (ISession session = NHiberateHelper.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Ocorreu um erro ao tentar atualizar a entidade: " + ex.Message);
                    }
                }
            }
        }

        public void Inserir(T entidade)
        {
            using (ISession session = NHiberateHelper.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Ocorreu um erro ao tentar excluir a entidade: " + ex.Message);
                    }
                }
            }
        }

        public T RetornarPorId(int id)
        {
            using (ISession session = NHiberateHelper.AbrirSession())
            {
                return session.Get<T>(id);
            }
        }
    }
}
