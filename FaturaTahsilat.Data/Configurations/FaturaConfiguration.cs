using FaturaTahsilat.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace FaturaTahsilat.Data.Configurations
{
    public class FaturaConfiguration : IEntityTypeConfiguration<Fatura>
    {
        public void Configure(EntityTypeBuilder<Fatura> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FaturaDonemi).HasColumnName("Fatura Dönemi").HasMaxLength(50).IsRequired(false);
            builder.HasOne(x => x.Abone).WithMany(x => x.Faturalar).HasForeignKey(x => x.AboneId);
            //builder.HasOne(x => x.Tahsilat).WithOne(x => x.Fatura);
            builder.ToTable("Faturalar");
        }
    }
}
