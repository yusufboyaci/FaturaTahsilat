using FaturaTahsilat.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace FaturaTahsilat.Data.Configurations
{
    public class TahsilatConfiguration : IEntityTypeConfiguration<Tahsilat>
    {
        public void Configure(EntityTypeBuilder<Tahsilat> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TahhutTutari).HasColumnType("decimal(18,2)").HasColumnName("Tahhut Tutarı");
            builder.HasOne(x => x.Abone).WithMany(x => x.Tahsilatlar).HasForeignKey(x => x.AboneId);
            //builder.HasOne(x => x.Fatura).WithOne(x => x.Tahsilat);
            builder.ToTable("Tahsilatlar");
        }
    }
}
