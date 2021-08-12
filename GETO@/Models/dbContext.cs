
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETO_.Models
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }
        public dbContext()
        {

        }
        public static string ConnectonString { set; get; }
        public static string ConnectionString { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<OxyDonator> OxyDonator { get; set; }
        public DbSet<PlasmaDonor> PlasmaDonor { get; set; }
        public DbSet<ApiKeyModel> ApiKeyModel { get; set; }
        public DbSet<RolesUser> RolesUsers { get; set; }
        public DbSet<Menu> Menu { get; set; }

    }
}
