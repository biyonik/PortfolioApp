using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class SocialMediaManager : GenericManager<Guid, SocialMedia>, ISocialMediaService
    {
        public SocialMediaManager(IGenericRepository<SocialMedia, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}