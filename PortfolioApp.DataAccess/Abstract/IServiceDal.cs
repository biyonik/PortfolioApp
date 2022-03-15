using PortfolioApp.Entites.Concrete;

namespace PortfolioApp.DataAccess.Abstract
{
    public interface IServiceDal: IGenericRepository<Service, Guid>
    {
         
    }
}