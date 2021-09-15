using FaturaTahsilat.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FaturaTahsilat.Core.Models
{
    public class Fatura : BaseEntity
    {
        public Guid AboneId { get; set; }
        public bool FaturaOdendiMi { get; set; }
        public DateTime FaturaDüzenlenmeTarihi { get; set; }
        public DateTime FaturaSonOdemeTarihi { get; set; }
        public string FaturaDonemi { get; set; }
        public decimal FaturaTutari { get; set; }
        //public Tahsilat Tahsilat { get; set; }
        //public IEnumerable<Tahsilat> Tahsilatlar { get; set; }
        public Abone Abone { get; set; }
        public IEnumerable<TahsilatDetay> TahsilatDetaylar { get; set; }
    }
}
