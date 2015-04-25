using Kiwimob.Framework.Repository.Infrastructure;
using Kiwimob.Framework.Repository.Repositories;
using System;
using System.Data;

namespace Kiwimob.Framework.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : class, IObjectState;
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
        bool Commit();
        void Rollback();
    }
}