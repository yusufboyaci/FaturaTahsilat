using FaturaTahsilat.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.Core.Models
{
    public class Abone : BaseEntity
    {
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        public ulong TCNo { get; set; }
        public string AboneNo { get; set; }
        public Guid KullaniciId { get; set; }//FK
        public Kullanici Kullanici { get; set; }
        public IEnumerable<Tahsilat> Tahsilatlar { get; set; }
        public IEnumerable<Fatura> Faturalar { get; set; }
    }
}
