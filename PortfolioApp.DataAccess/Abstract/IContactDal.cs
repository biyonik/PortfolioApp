using PortfolioApp.Entites.Concrete;

namespace PortfolioApp.DataAccess.Abstract
{
    public interface IContactDal: IGenericRepository<Contact, Guid>
    {
         
    }
}