using PortfolioApp.Entites.Concrete;

namespace PortfolioApp.DataAccess.Abstract
{
    public interface IMessageDal: IGenericRepository<Message, Guid>
    {
         
    }
}