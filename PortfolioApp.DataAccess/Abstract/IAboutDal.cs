using PortfolioApp.Entites.Concrete;

namespace PortfolioApp.DataAccess.Abstract
{
    public interface IAboutDal: IGenericRepository<About, Guid>
    {
    }
}