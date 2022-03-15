using System.ComponentModel.DataAnnotations;
using PortfolioApp.Entites.Abstract;

namespace PortfolioApp.Entites.Concrete
{
    public class Feature: IEntity
    {
        [Key]
        public Guid FeatureId { get; set; }
        public string Header { get; set; }   
        public string FullName { get; set; }
        public string Title { get; set; }
        
        
        
        
    }
}