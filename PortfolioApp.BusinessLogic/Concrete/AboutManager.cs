using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class AboutManager : GenericManager<Guid, About>, IAboutService
    {
        public AboutManager(IGenericRepository<About, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}