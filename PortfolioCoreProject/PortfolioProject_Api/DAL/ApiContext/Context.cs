using System;
using Microsoft.EntityFrameworkCore;
using PortfolioProject_Api.DAL.Entity;

namespace PortfolioProject_Api.DAL.ApiContext
{
	public class Context : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=PortfolioApiDb; User Id=sa; Password=148951753Gg(.);TrustServerCertificate=True; Encrypt=false");
        }

        public DbSet<Category> Categories { get; set; }
    }
}

