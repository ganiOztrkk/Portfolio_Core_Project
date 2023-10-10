using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Feature : IEntity
    {
        [Key]
        public int FeatureId { get; set; }
        public string? Header { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Linkedin { get; set; }
        public string? Github { get; set; }
        public string? Medium { get; set; }
        public bool FeatureStatus { get; set; }
    }
}

