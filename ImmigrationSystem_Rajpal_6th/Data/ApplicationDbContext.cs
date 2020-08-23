using System;
using System.Collections.Generic;
using System.Text;
using ImmigrationSystem_Rajpal_6th.Bussiness;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ImmigrationSystem_Rajpal_6th.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Embassy> Embassies { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
