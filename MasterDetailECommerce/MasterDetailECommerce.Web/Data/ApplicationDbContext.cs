using System;
using System.Collections.Generic;
using System.Text;
using MasterDetailECommerce.Models;
using MasterDetailECommerce.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MasterDetailECommerce.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {            
            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
