using System.ComponentModel.DataAnnotations;
using PortfolioApp.Entites.Abstract;

namespace PortfolioApp.Entites.Concrete
{
    public class Skill: IEntity
    {
        [Key]
        public Guid SkillId { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }
}