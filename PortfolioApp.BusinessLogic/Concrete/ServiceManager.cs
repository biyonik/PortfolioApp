using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class ServiceManager : GenericManager<Guid, Service>, IServiceService
    {
        public ServiceManager(IGenericRepository<Service, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}