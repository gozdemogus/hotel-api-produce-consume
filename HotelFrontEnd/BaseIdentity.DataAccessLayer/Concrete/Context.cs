using System;
using BaseIdentity.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BaseIdentity.DataAccessLayer.Concrete
{
	public class Context:IdentityDbContext<AppUser,AppRole,int>
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:127.0.0.1,1433;Database=BaseIdentity;MultipleActiveResultSets=true;User=SA;Password=MyPass@word;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

