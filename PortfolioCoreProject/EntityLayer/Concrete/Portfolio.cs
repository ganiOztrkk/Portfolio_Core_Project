using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Portfolio : IEntity
    {
        [Key]
        public int PortfolioId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? TechImageUrl { get; set; }
        public string? Completion { get; set; }
        public bool PortfolioStatus { get; set; }
    }
}

