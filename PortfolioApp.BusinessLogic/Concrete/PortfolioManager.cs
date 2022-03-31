using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class PortfolioManager : GenericManager<Guid, Portfolio>, IPortfolioService
    {
        public PortfolioManager(IGenericRepository<Portfolio, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}