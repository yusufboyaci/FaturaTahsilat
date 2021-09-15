using FaturaTahsilat.Core.Models;
using FaturaTahsilat.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FaturaTahsilat.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<Kullanici, Rol, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Abone> Aboneler { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<Tahsilat> Tahsilatlar { get; set; }
        public DbSet<TahsilatDetay> TahsilatDetaylari { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TahsilatDetayConfiguration());
            builder.ApplyConfiguration(new TahsilatConfiguration());
            builder.ApplyConfiguration(new FaturaConfiguration());
            builder.ApplyConfiguration(new AboneConfiguration());
            builder.ApplyConfiguration(new TahsilatDetayConfiguration());
            base.OnModelCreating(builder);
        }

    }
}
