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
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<MasterDetailECommerce.Web.Models.City> City { get; set; }
    }
}
