using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class ExperienceManager : GenericManager<Guid, Experience>, IExperienceService
    {
        public ExperienceManager(IGenericRepository<Experience, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}