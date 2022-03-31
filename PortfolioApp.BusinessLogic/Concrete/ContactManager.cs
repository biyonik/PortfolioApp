using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class ContactManager : GenericManager<Guid, Contact>, IContactService
    {
        public ContactManager(IGenericRepository<Contact, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}