using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class SkillManager : GenericManager<Guid, Skill>, ISkillService
    {
        public SkillManager(IGenericRepository<Skill, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}