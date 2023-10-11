using System;
using System.ComponentModel.DataAnnotations;

namespace PortfolioCoreProject.Areas.User.Models
{
	public class UserLoginVM
	{
		[Required(ErrorMessage ="Write your username")]
		public string? Username { get; set; }
        [Required(ErrorMessage ="Write you password.")]
        public string? Password { get; set; }
	}
}

