using PortfolioApp.BusinessLogic.Abstract;

namespace PortfolioApp.BusinessLogic.Concrete
{
    public class MessageManager : GenericManager<Guid, Message>, IMessageService
    {
        public MessageManager(IGenericRepository<Message, Guid> genericRepository) : base(genericRepository)
        {
        }
    }
}