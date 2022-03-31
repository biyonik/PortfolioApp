using PortfolioApp.BusinessLogic.Abstract;
using PortfolioApp.Entites.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class GenericManager<TKey, TEntity>: IGenericService<TKey, TEntity> where TEntity: class, IEntity, new()
    {
        private readonly IGenericRepository<TEntity, TKey> _genericRepository;
        public GenericManager(IGenericRepository<TEntity, TKey> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _genericRepository.AddAsync(entity);
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<TEntity> GetById(TKey Id)
        {
            return await _genericRepository.GetById(Id);
        }

        public void Remove(TEntity entity)
        {
            _genericRepository.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _genericRepository.Update(entity);
        }
    }
}