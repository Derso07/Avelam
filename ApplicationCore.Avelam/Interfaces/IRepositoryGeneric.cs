using ApplicationCore.Avelam.Models;

namespace ApplicationCore.Avelam.Interfaces;
public interface IRepositoryGeneric<TEntity> : IDisposable where TEntity : BaseEntity
{
    Task Create(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(long id);
    Task<TEntity> GetById(long id);
    Task<List<TEntity>> GetAll();
}
