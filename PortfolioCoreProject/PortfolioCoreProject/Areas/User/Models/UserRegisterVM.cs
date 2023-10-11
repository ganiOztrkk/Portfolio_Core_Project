using System;
namespace PortfolioCoreProject.Areas.User.Models
{
	public class UserRegisterVM
	{
        public string? Username { get; set; }
		public string? Password { get; set; }
		public string? ConfirmPassword { get; set; }
		public string? Mail { get; set; }
	}
}

