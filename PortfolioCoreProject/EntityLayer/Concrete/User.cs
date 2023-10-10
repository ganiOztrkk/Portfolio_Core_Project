using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class User : IEntity
	{
		[Key]
		public int UserId { get; set; }
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? Username { get; set; }
		public string? Mail { get; set; }
		public string? Password { get; set; }
		public string? ImageUrl { get; set; }
		public bool Status { get; set; }

		public List<UserMessage>? UserMessages { get; set; }
	}
}

