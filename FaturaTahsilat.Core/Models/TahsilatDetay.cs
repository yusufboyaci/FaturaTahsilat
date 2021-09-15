using FaturaTahsilat.Core.Base;
using System;
using System.Linq;

namespace FaturaTahsilat.Core.Models
{
    public class TahsilatDetay : BaseEntity
    {

        public Guid TahsilatId { get; set; }
        public Guid FaturaId { get; set; }
        // public Tahsilat Tahsilat { get; set; }
        public Fatura Fatura { get; set; }

    }
}
