﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Skill : IEntity
    {
        [Key]
        public int SkillId { get; set; }
        public string? Title { get; set; }
        public string? Value { get; set; }
        public string? SkillImageUrl { get; set; }
        public bool SkillStatus { get; set; }
    }
}

