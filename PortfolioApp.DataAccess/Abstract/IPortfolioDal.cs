using PortfolioApp.Entites.Concrete;

namespace PortfolioApp.DataAccess.Abstract
{
    public interface IPortfolioDal: IGenericRepository<Portfolio, Guid>
    {
         
    }
}