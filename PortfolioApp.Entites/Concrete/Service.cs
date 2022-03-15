using System.ComponentModel.DataAnnotations;
using PortfolioApp.Entites.Abstract;

namespace PortfolioApp.Entites.Concrete
{
    public class Service: IEntity
    {
        [Key]
        public Guid ServiceId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}