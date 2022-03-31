using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class TestimonialManager : GenericManager<Guid, Testimonial>, ITestimonialService
    {
        public TestimonialManager(IGenericRepository<Testimonial, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}