using System.ComponentModel.DataAnnotations;
using PortfolioApp.Entites.Abstract;

namespace PortfolioApp.Entites.Concrete
{
    public class SocialMedia: IEntity
    {
        [Key]
        public Guid SocialMediaId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public bool Status { get; set; }
    }
}