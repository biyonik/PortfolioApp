using PortfolioApp.Entites.Abstract;

namespace PortfolioApp.DataAccess.Abstract
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : class, IEntity, new()
    {
        Task<ICollection<TEntity>> GetAllAsync();
        Task<TEntity> GetById(TKey Id);
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }

}