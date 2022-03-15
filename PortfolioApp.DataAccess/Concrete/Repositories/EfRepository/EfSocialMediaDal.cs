using Microsoft.EntityFrameworkCore;
using PortfolioApp.DataAccess.Abstract;
using PortfolioApp.DataAccess.Concrete.Repositories.EntityFramework;
using PortfolioApp.DataAccess.Context.EntityFramework;
using PortfolioApp.Entites.Concrete;

namespace PortfolioApp.DataAccess.Concrete.Repositories.EfRepository
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia, Guid>, ISocialMediaDal
    {
        public EfSocialMediaDal(DbSet<SocialMedia> entity, PortfolioAppContext context) : base(entity, context)
        {
        }
    }
}