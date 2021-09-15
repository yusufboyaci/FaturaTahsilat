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
    public class TahsilatDetayConfiguration : IEntityTypeConfiguration<TahsilatDetay>
    {
        public void Configure(EntityTypeBuilder<TahsilatDetay> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Tahsilat Detyaları");
        }
    }
}
