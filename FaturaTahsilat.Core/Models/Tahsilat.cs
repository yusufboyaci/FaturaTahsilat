using FaturaTahsilat.Core.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FaturaTahsilat.Core.Models
{
    public class Tahsilat : BaseEntity
    {
        [ForeignKey("AboneId")]
        public Guid AboneId { get; set; }//FK
        [ForeignKey("FaturaId")]
        public Guid FaturaId { get; set; }
        public DateTime TahhutTarihi { get; set; }
        public decimal TahhutTutari { get; set; }
        public Abone Abone { get; set; }
        //public Fatura Fatura { get; set; }
        // public TahsilatDetay TahsilatDetay { get; set; }
    }
}
