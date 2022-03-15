using Microsoft.EntityFrameworkCore;
using PortfolioApp.DataAccess.Abstract;
using PortfolioApp.DataAccess.Concrete.Repositories.EntityFramework;
using PortfolioApp.DataAccess.Context.EntityFramework;
using PortfolioApp.Entites.Concrete;

namespace PortfolioApp.DataAccess.Concrete.Repositories.EfRepository
{
    public class EfServiceDal : GenericRepository<Service, Guid>, IServiceDal
    {
        public EfServiceDal(DbSet<Service> entity, PortfolioAppContext context) : base(entity, context)
        {
        }
    }
}