using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class FeatureManager : GenericManager<Guid, Feature>, IFeatureService
    {
        public FeatureManager(IGenericRepository<Feature, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}