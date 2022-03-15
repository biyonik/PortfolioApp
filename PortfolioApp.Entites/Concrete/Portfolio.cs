using System.ComponentModel.DataAnnotations;
using PortfolioApp.Entites.Abstract;

namespace PortfolioApp.Entites.Concrete
{
    public class Portfolio: IEntity
    {
        [Key]
        public Guid PortfolioId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}