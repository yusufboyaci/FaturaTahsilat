using FaturaTahsilat.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.Data.Configurations
{
    public class AboneConfiguration : IEntityTypeConfiguration<Abone>
    {
        public void Configure(EntityTypeBuilder<Abone> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AdSoyad).IsRequired(true).HasMaxLength(100).HasColumnName("Ad Soyad");
            builder.Property(x => x.Eposta).IsRequired(true).HasMaxLength(200);
            builder.Property(x => x.AboneNo).IsRequired(true).HasMaxLength(30);
            builder.HasMany(x => x.Tahsilatlar).WithOne(x => x.Abone);
            builder.HasMany(x => x.Faturalar).WithOne(x => x.Abone);
            builder.HasOne(x => x.Kullanici).WithMany(x => x.Aboneler).HasForeignKey(x => x.KullaniciId);
            builder.ToTable("Aboneler");
        }
    }
}
