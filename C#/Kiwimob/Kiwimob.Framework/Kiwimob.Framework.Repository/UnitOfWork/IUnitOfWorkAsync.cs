using Kiwimob.Framework.Repository.Infrastructure;
using Kiwimob.Framework.Repository.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace Kiwimob.Framework.Repository.UnitOfWork
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class, IObjectState;
    }
}