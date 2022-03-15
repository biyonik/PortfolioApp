using System.ComponentModel.DataAnnotations;
using PortfolioApp.Entites.Abstract;

namespace PortfolioApp.Entites.Concrete
{
    public class Testimonial: IEntity
    {
        [Key]
        public Guid TestimonialId { get; set; }
        public string ClientName { get; set; }
        public string Company { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}