using Microsoft.EntityFrameworkCore;
using PortfolioApp.DataAccess.Abstract;
using PortfolioApp.DataAccess.Context.EntityFramework;
using PortfolioApp.Entites.Abstract;

namespace PortfolioApp.DataAccess.Concrete.Repositories.EntityFramework
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey>
    where TEntity : class, IEntity, new()
    {
        private readonly PortfolioAppContext _context;
        private DbSet<TEntity> _entity;

        public GenericRepository(DbSet<TEntity> entity, PortfolioAppContext context = null)
        {
            _entity = entity;
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            if(entity == null) {
                throw new ArgumentNullException("Ekleme işlemi başarısız oldu! Varlık öğesi boş bırakılamaz!");
            }
            await _entity.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        public async Task<TEntity> GetById(TKey Id)
        {
            return await _entity.FindAsync(Id);
        }

        public void Remove(TEntity entity)
        {
            if(entity == null) {
                throw new ArgumentNullException("Silme işlemi başarısız oldu! Varlık öğesi boş bırakılamaz!");
            }
            _entity.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if(entity == null) {
                throw new ArgumentNullException("Güncelleme işlemi başarısız oldu! Varlık öğesi boş bırakılamaz!");
            }
            _entity.Update(entity);
            _context.SaveChanges();
        }
    }
}