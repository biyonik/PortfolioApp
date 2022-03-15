using Microsoft.EntityFrameworkCore;
using PortfolioApp.DataAccess.Abstract;
using PortfolioApp.DataAccess.Concrete.Repositories.EntityFramework;
using PortfolioApp.DataAccess.Context.EntityFramework;
using PortfolioApp.Entites.Concrete;

namespace PortfolioApp.DataAccess.Concrete.Repositories.EfRepository
{
    public class EfContactDal : GenericRepository<Contact, Guid>, IContactDal
    {
        public EfContactDal(DbSet<Contact> entity, PortfolioAppContext context) : base(entity, context)
        {
        }
    }
}