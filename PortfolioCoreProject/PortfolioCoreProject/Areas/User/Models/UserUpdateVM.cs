﻿using System;
namespace PortfolioCoreProject.Areas.User.Models
{
	public class UserUpdateVM
	{
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? Username { get; set; }
		public string? Password { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public string? ImageUrl { get; set; }
	}
}

