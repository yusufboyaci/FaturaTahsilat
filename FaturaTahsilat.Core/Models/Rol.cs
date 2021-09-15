using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.Core.Models
{
    public class Rol : IdentityRole<Guid>
    {
        public bool Aktif { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DuzeltmeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
        public Guid? Ka_KullaniciId { get; set; }
        public Guid? Du_KullaniciId { get; set; }
        public Guid? Sil_KullaniciId { get; set; }
        public bool Durum { get; set; }
    }
}
